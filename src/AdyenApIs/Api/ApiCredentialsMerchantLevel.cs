using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using AdyenApIs.Core;
using AdyenApIs.Core.Authentication;
using AdyenApIs.Core.Exceptions;
using AdyenApIs.Core.Models;
using AdyenApIs.Core.Request;
using AdyenApIs.Core.Response;
using AdyenApIs.Errors;
using AdyenApIs.Models;
using AdyenApIs.Requests.ApiCredentialsMerchantLevel;

namespace AdyenApIs.Api;

public sealed class ApiCredentialsMerchantLevel
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal ApiCredentialsMerchantLevel(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Create an API credential
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CreateApiCredentialResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="CreateMerchantApiCredentialError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Creates an <see href="https://docs.adyen.com/development-resources/api-credentials">API credential</see> for the company account identified in the path. In the request, you can specify the roles and allowed origins for the new API credential.
    /// <para>
    /// The response includes the:
    /// * <see href="https://docs.adyen.com/development-resources/api-authentication#api-key-authentication">API key</see>: used for API request authentication.
    /// * <see href="https://docs.adyen.com/development-resources/client-side-authentication#how-it-works">Client key</see>: public key used for client-side authentication.
    /// * <see href="https://docs.adyen.com/development-resources/api-authentication#using-basic-authentication">Username and password</see>: used for basic authentication.
    /// </para>
    /// <para>
    /// &gt; Make sure you store the API key securely in your system. You won't be able to retrieve it later.
    /// </para>
    /// <para>
    /// If your API key is lost or compromised, you need to <see href="https://docs.adyen.com/api-explorer/#/ManagementService/v1/post/merchants/{merchantId}/apiCredentials/{apiCredentialId}/generateApiKey">generate a new API key</see>.
    /// </para>
    /// <para>
    /// To make this request, your API credential must have the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">roles</see>:
    /// * Management API—API credentials read and write
    /// </para>
    /// </remarks>
    public Task<CreateApiCredentialResponse> CreateMerchantApiCredential(CreateMerchantApiCredentialOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.DefaultManagementApi("/merchants/{merchantId}/apiCredentials"),
            [new TemplateParam("merchantId", request.MerchantId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<CreateApiCredentialResponse>(),
            CreateMerchantApiCredentialError.Response,
            AuthScheme.Any(_auth.BasicAuth, _auth.ApiKeyAuth),
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get an API credential
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ApiCredential"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetMerchantApiCredentialError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns the <see href="https://docs.adyen.com/development-resources/api-credentials">API credential</see> identified in the path.
    /// <para>
    /// To make this request, your API credential must have the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">roles</see>:
    /// * Management API—API credentials read and write
    /// </para>
    /// </remarks>
    public Task<ApiCredential> GetMerchantApiCredential(GetMerchantApiCredentialRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.DefaultManagementApi("/merchants/{merchantId}/apiCredentials/{apiCredentialId}"),
            [
                new TemplateParam("merchantId", request.MerchantId),
                new TemplateParam("apiCredentialId", request.ApiCredentialId),
            ],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ApiCredential>(),
            GetMerchantApiCredentialError.Response,
            AuthScheme.Any(_auth.BasicAuth, _auth.ApiKeyAuth),
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get a list of API credentials
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ListMerchantApiCredentialsResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="ListMerchantApiCredentialsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns the list of <see href="https://docs.adyen.com/development-resources/api-credentials">API credentials</see> for the merchant account. The list is grouped into pages as defined by the query parameters.
    /// <para>
    /// To make this request, your API credential must have the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">roles</see>:
    /// * Management API—API credentials read and write
    /// </para>
    /// </remarks>
    public Task<ListMerchantApiCredentialsResponse> ListMerchantApiCredentials(ListMerchantApiCredentialsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.DefaultManagementApi("/merchants/{merchantId}/apiCredentials"),
            [new TemplateParam("merchantId", request.MerchantId)],
            [new Param("pageNumber", request.PageNumber), new Param("pageSize", request.PageSize)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ListMerchantApiCredentialsResponse>(),
            ListMerchantApiCredentialsError.Response,
            AuthScheme.Any(_auth.BasicAuth, _auth.ApiKeyAuth),
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Update an API credential
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ApiCredential"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="UpdateMerchantApiCredentialError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Changes the API credential's roles, or allowed origins. The request has the new values for the fields you want to change. The response contains the full updated API credential, including the new values from the request.
    /// <para>
    /// To make this request, your API credential must have the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">roles</see>:
    /// * Management API—API credentials read and write
    /// </para>
    /// </remarks>
    public Task<ApiCredential> UpdateMerchantApiCredential(UpdateMerchantApiCredentialOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.DefaultManagementApi("/merchants/{merchantId}/apiCredentials/{apiCredentialId}"),
            [
                new TemplateParam("merchantId", request.MerchantId),
                new TemplateParam("apiCredentialId", request.ApiCredentialId),
            ],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            new HttpMethod("PATCH"),
            JsonRequest.Create(request.Body),
            JsonResponse.Create<ApiCredential>(),
            UpdateMerchantApiCredentialError.Response,
            AuthScheme.Any(_auth.BasicAuth, _auth.ApiKeyAuth),
            requestOptions,
            cancellationToken);
}
