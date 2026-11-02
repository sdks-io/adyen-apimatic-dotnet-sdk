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
using AdyenApIs.Requests.AllowedOriginsMerchantLevel;

namespace AdyenApIs.Api;

public sealed class AllowedOriginsMerchantLevel
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal AllowedOriginsMerchantLevel(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Create an allowed origin
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AllowedOrigin"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="CreateMerchantApiCredentialOriginError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Adds a new <see href="https://docs.adyen.com/development-resources/client-side-authentication#allowed-origins">allowed origin</see> to the API credential's list of allowed origins.
    /// <para>
    /// To make this request, your API credential must have the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">roles</see>:
    /// * Management API—API credentials read and write
    /// </para>
    /// </remarks>
    public Task<AllowedOrigin> CreateMerchantApiCredentialOrigin(CreateMerchantApiCredentialOriginRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.DefaultManagementApi("/merchants/{merchantId}/apiCredentials/{apiCredentialId}/allowedOrigins"),
            [
                new TemplateParam("merchantId", request.MerchantId),
                new TemplateParam("apiCredentialId", request.ApiCredentialId),
            ],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<AllowedOrigin>(),
            CreateMerchantApiCredentialOriginError.Response,
            AuthScheme.Any(_auth.BasicAuth, _auth.ApiKeyAuth),
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Delete an allowed origin
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="DeleteMerchantApiCredentialOriginError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Removes the <see href="https://docs.adyen.com/development-resources/client-side-authentication#allowed-origins">allowed origin</see> identified in the path. As soon as an allowed origin is removed, we no longer accept client-side requests from that domain.
    /// <para>
    /// To make this request, your API credential must have the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">roles</see>:
    /// * Management API—API credentials read and write
    /// </para>
    /// </remarks>
    public Task DeleteMerchantApiCredentialOrigin(DeleteMerchantApiCredentialOriginRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.DefaultManagementApi(
                "/merchants/{merchantId}/apiCredentials/{apiCredentialId}/allowedOrigins/{originId}"),
            [
                new TemplateParam("merchantId", request.MerchantId),
                new TemplateParam("apiCredentialId", request.ApiCredentialId),
                new TemplateParam("originId", request.OriginId),
            ],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            VoidResponse.Instance,
            DeleteMerchantApiCredentialOriginError.Response,
            AuthScheme.Any(_auth.BasicAuth, _auth.ApiKeyAuth),
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get an allowed origin
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AllowedOrigin"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetMerchantApiCredentialOriginError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns the <see href="https://docs.adyen.com/development-resources/client-side-authentication#allowed-origins">allowed origin</see> identified in the path.
    /// <para>
    /// To make this request, your API credential must have the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">roles</see>:
    /// * Management API—API credentials read and write
    /// </para>
    /// </remarks>
    public Task<AllowedOrigin> GetMerchantApiCredentialOrigin(GetMerchantApiCredentialOriginRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.DefaultManagementApi(
                "/merchants/{merchantId}/apiCredentials/{apiCredentialId}/allowedOrigins/{originId}"),
            [
                new TemplateParam("merchantId", request.MerchantId),
                new TemplateParam("apiCredentialId", request.ApiCredentialId),
                new TemplateParam("originId", request.OriginId),
            ],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<AllowedOrigin>(),
            GetMerchantApiCredentialOriginError.Response,
            AuthScheme.Any(_auth.BasicAuth, _auth.ApiKeyAuth),
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get a list of allowed origins
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AllowedOriginsResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="ListMerchantApiCredentialOriginsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns the list of <see href="https://docs.adyen.com/development-resources/client-side-authentication#allowed-origins">allowed origins</see> for the API credential identified in the path.
    /// <para>
    /// To make this request, your API credential must have the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">roles</see>:
    /// * Management API—API credentials read and write
    /// </para>
    /// </remarks>
    public Task<AllowedOriginsResponse> ListMerchantApiCredentialOrigins(ListMerchantApiCredentialOriginsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.DefaultManagementApi("/merchants/{merchantId}/apiCredentials/{apiCredentialId}/allowedOrigins"),
            [
                new TemplateParam("merchantId", request.MerchantId),
                new TemplateParam("apiCredentialId", request.ApiCredentialId),
            ],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<AllowedOriginsResponse>(),
            ListMerchantApiCredentialOriginsError.Response,
            AuthScheme.Any(_auth.BasicAuth, _auth.ApiKeyAuth),
            requestOptions,
            cancellationToken);
}
