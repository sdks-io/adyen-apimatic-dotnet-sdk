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
using AdyenApIs.Requests.AccountMerchantLevel;

namespace AdyenApIs.Api;

public sealed class AccountMerchantLevel
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal AccountMerchantLevel(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Request to activate a merchant account
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="RequestActivationResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="ActivateMerchantError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Sends a request to activate the merchant account identified in the path.
    /// <para>
    /// You get the result of the activation asynchronously through a <see href="https://docs.adyen.com/api-explorer/ManagementNotification/latest/post/merchant.updated"><c>merchant.updated</c></see> webhook. Once the merchant account is activated, you can start using it to accept payments and payouts.
    /// </para>
    /// <para>
    /// Use this endpoint if your integration requires it, such as Adyen for Platforms Manage. Your Adyen contact will set up your access.
    /// </para>
    /// <para>
    /// To make this request, your API credential must have the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">roles</see>:
    /// * Management API—Accounts read and write
    /// </para>
    /// </remarks>
    public Task<RequestActivationResponse> ActivateMerchant(ActivateMerchantRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.DefaultManagementApi("/merchants/{merchantId}/activate"),
            [new TemplateParam("merchantId", request.MerchantId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<RequestActivationResponse>(),
            ActivateMerchantError.Response,
            AuthScheme.Any(_auth.BasicAuth, _auth.ApiKeyAuth),
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Create a merchant account
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CreateMerchantResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="CreateMerchantError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Creates a merchant account for the company account specified in the request.
    /// <para>
    /// Use this endpoint if your integration requires it, such as Adyen for Platforms Manage. Your Adyen contact will set up your access.
    /// </para>
    /// <para>
    /// To make this request, your API credential must have the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">roles</see>:
    /// * Management API—Accounts read and write
    /// </para>
    /// </remarks>
    public Task<CreateMerchantResponse> CreateMerchant(CreateMerchantOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.DefaultManagementApi("/merchants"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<CreateMerchantResponse>(),
            CreateMerchantError.Response,
            AuthScheme.Any(_auth.BasicAuth, _auth.ApiKeyAuth),
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get a merchant account
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Merchant"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetMerchantError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns the merchant account specified in the path. Your API credential must have access to the merchant account.
    /// <para>
    /// To make this request, your API credential must have the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">roles</see>:
    /// * Management API—Account read
    /// </para>
    /// </remarks>
    public Task<Merchant> GetMerchant(GetMerchantRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.DefaultManagementApi("/merchants/{merchantId}"),
            [new TemplateParam("merchantId", request.MerchantId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<Merchant>(),
            GetMerchantError.Response,
            AuthScheme.Any(_auth.BasicAuth, _auth.ApiKeyAuth),
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get a list of merchant accounts
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ListMerchantResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="ListMerchantsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns the list of merchant accounts that your API credential has access to. The list is grouped into pages as defined by the query parameters.
    /// <para>
    /// To make this request, your API credential must have the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">roles</see>:
    /// * Management API—Account read
    /// </para>
    /// </remarks>
    public Task<ListMerchantResponse> ListMerchants(ListMerchantsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.DefaultManagementApi("/merchants"),
            [],
            [new Param("pageNumber", request.PageNumber), new Param("pageSize", request.PageSize)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ListMerchantResponse>(),
            ListMerchantsError.Response,
            AuthScheme.Any(_auth.BasicAuth, _auth.ApiKeyAuth),
            requestOptions,
            cancellationToken);
}
