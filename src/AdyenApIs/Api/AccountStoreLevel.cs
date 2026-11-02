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
using AdyenApIs.Requests.AccountStoreLevel;

namespace AdyenApIs.Api;

public sealed class AccountStoreLevel
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal AccountStoreLevel(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Create a store
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Store"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="CreateMerchantStoreError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Creates a store for the merchant account identified in the path.
    /// <para>
    /// To make this request, your API credential must have the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">role</see>:
    /// * Management API—Stores read and write
    /// </para>
    /// <para>
    /// In the live environment, requests to this endpoint are subject to <see href="https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment">rate limits</see>.
    /// </para>
    /// </remarks>
    public Task<Store> CreateMerchantStore(CreateMerchantStoreRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.DefaultManagementApi("/merchants/{merchantId}/stores"),
            [new TemplateParam("merchantId", request.MerchantId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<Store>(),
            CreateMerchantStoreError.Response,
            AuthScheme.Any(_auth.BasicAuth, _auth.ApiKeyAuth),
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Create a store
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Store"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="CreateStoreError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Creates a store for the merchant account specified in the request.
    /// <para>
    /// To make this request, your API credential must have the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">role</see>:
    /// * Management API—Stores read and write
    /// </para>
    /// <para>
    /// In the live environment, requests to this endpoint are subject to <see href="https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment">rate limits</see>.
    /// </para>
    /// </remarks>
    public Task<Store> CreateStore(CreateStoreRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.DefaultManagementApi("/stores"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<Store>(),
            CreateStoreError.Response,
            AuthScheme.Any(_auth.BasicAuth, _auth.ApiKeyAuth),
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get a store
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Store"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetMerchantStoreError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns the details of the store identified in the path.
    /// <para>
    /// To make this request, your API credential must have one of the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">roles</see>:
    /// * Management API—Stores read
    /// * Management API—Stores read and write
    /// </para>
    /// <para>
    /// In the live environment, requests to this endpoint are subject to <see href="https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment">rate limits</see>.
    /// </para>
    /// </remarks>
    public Task<Store> GetMerchantStore(GetMerchantStoreRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.DefaultManagementApi("/merchants/{merchantId}/stores/{storeId}"),
            [new TemplateParam("merchantId", request.MerchantId), new TemplateParam("storeId", request.StoreId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<Store>(),
            GetMerchantStoreError.Response,
            AuthScheme.Any(_auth.BasicAuth, _auth.ApiKeyAuth),
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get a store
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Store"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetStoreError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns the details of the store identified in the path.
    /// <para>
    /// To make this request, your API credential must have one of the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">roles</see>:
    /// * Management API—Stores read
    /// * Management API—Stores read and write
    /// </para>
    /// <para>
    /// In the live environment, requests to this endpoint are subject to <see href="https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment">rate limits</see>.
    /// </para>
    /// </remarks>
    public Task<Store> GetStore(GetStoreRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.DefaultManagementApi("/stores/{storeId}"),
            [new TemplateParam("storeId", request.StoreId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<Store>(),
            GetStoreError.Response,
            AuthScheme.Any(_auth.BasicAuth, _auth.ApiKeyAuth),
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get a list of stores
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ListStoresResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="ListMerchantStoresError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns a list of stores for the merchant account identified in the path. The list is grouped into pages as defined by the query parameters.
    /// <para>
    /// To make this request, your API credential must have one of the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">roles</see>:
    /// * Management API—Stores read
    /// * Management API—Stores read and write
    /// </para>
    /// <para>
    /// In the live environment, requests to this endpoint are subject to <see href="https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment">rate limits</see>.
    /// </para>
    /// </remarks>
    public Task<ListStoresResponse> ListMerchantStores(ListMerchantStoresRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.DefaultManagementApi("/merchants/{merchantId}/stores"),
            [new TemplateParam("merchantId", request.MerchantId)],
            [
                new Param("pageNumber", request.PageNumber),
                new Param("pageSize", request.PageSize),
                new Param("reference", request.Reference),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ListStoresResponse>(),
            ListMerchantStoresError.Response,
            AuthScheme.Any(_auth.BasicAuth, _auth.ApiKeyAuth),
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get a list of stores
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ListStoresResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="ListStoresError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns a list of stores. The list is grouped into pages as defined by the query parameters.
    /// <para>
    /// To make this request, your API credential must have one of the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">roles</see>:
    /// * Management API—Stores read
    /// * Management API—Stores read and write
    /// </para>
    /// <para>
    /// In the live environment, requests to this endpoint are subject to <see href="https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment">rate limits</see>.
    /// </para>
    /// </remarks>
    public Task<ListStoresResponse> ListStores(ListStoresRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.DefaultManagementApi("/stores"),
            [],
            [
                new Param("pageNumber", request.PageNumber),
                new Param("pageSize", request.PageSize),
                new Param("reference", request.Reference),
                new Param("merchantId", request.MerchantId),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ListStoresResponse>(),
            ListStoresError.Response,
            AuthScheme.Any(_auth.BasicAuth, _auth.ApiKeyAuth),
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Update a store
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Store"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="UpdateMerchantStoreError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Updates the store identified in the path. You can only update some store parameters.
    /// <para>
    /// To make this request, your API credential must have the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">role</see>:
    /// * Management API—Stores read and write
    /// </para>
    /// <para>
    /// In the live environment, requests to this endpoint are subject to <see href="https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment">rate limits</see>.
    /// </para>
    /// </remarks>
    public Task<Store> UpdateMerchantStore(UpdateMerchantStoreRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.DefaultManagementApi("/merchants/{merchantId}/stores/{storeId}"),
            [new TemplateParam("merchantId", request.MerchantId), new TemplateParam("storeId", request.StoreId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            new HttpMethod("PATCH"),
            JsonRequest.Create(request.Body),
            JsonResponse.Create<Store>(),
            UpdateMerchantStoreError.Response,
            AuthScheme.Any(_auth.BasicAuth, _auth.ApiKeyAuth),
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Update a store
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Store"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="UpdateStoreError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Updates the store identified in the path.
    /// You can only update some store parameters.
    /// <para>
    /// To make this request, your API credential must have the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">role</see>:
    /// * Management API—Stores read and write
    /// </para>
    /// <para>
    /// In the live environment, requests to this endpoint are subject to <see href="https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment">rate limits</see>.
    /// </para>
    /// </remarks>
    public Task<Store> UpdateStore(UpdateStoreOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.DefaultManagementApi("/stores/{storeId}"),
            [new TemplateParam("storeId", request.StoreId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            new HttpMethod("PATCH"),
            JsonRequest.Create(request.Body),
            JsonResponse.Create<Store>(),
            UpdateStoreError.Response,
            AuthScheme.Any(_auth.BasicAuth, _auth.ApiKeyAuth),
            requestOptions,
            cancellationToken);
}
