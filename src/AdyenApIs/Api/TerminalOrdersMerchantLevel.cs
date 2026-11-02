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
using AdyenApIs.Requests.TerminalOrdersMerchantLevel;

namespace AdyenApIs.Api;

public sealed class TerminalOrdersMerchantLevel
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal TerminalOrdersMerchantLevel(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Cancel an order
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TerminalOrder"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="CancelMerchantTerminalOrderError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Cancels the terminal products order identified in the path.
    /// Cancelling is only possible while the order has the status <b>Placed</b>.
    /// To cancel an order, make a POST call without a request body. The response returns the full order details, but with the status changed to <b>Cancelled</b>.
    /// <para>
    /// To make this request, your API credential must have the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">role</see>:
    /// * Management API—Terminal ordering read and write
    /// </para>
    /// <para>
    /// In the live environment, requests to this endpoint are subject to <see href="https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment">rate limits</see>.
    /// </para>
    /// </remarks>
    public Task<TerminalOrder> CancelMerchantTerminalOrder(CancelMerchantTerminalOrderRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.DefaultManagementApi("/merchants/{merchantId}/terminalOrders/{orderId}/cancel"),
            [new TemplateParam("merchantId", request.MerchantId), new TemplateParam("orderId", request.OrderId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<TerminalOrder>(),
            CancelMerchantTerminalOrderError.Response,
            AuthScheme.Any(_auth.BasicAuth, _auth.ApiKeyAuth),
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Create a shipping location
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ShippingLocation"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="CreateMerchantShippingLocationError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Creates a shipping location for the merchant account identified in the path. A shipping location defines an address where orders can be shipped to.
    /// <para>
    /// To make this request, your API credential must have the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">role</see>:
    /// * Management API—Terminal ordering read and write
    /// </para>
    /// <para>
    /// In the live environment, requests to this endpoint are subject to <see href="https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment">rate limits</see>.
    /// </para>
    /// </remarks>
    public Task<ShippingLocation> CreateMerchantShippingLocation(CreateMerchantShippingLocationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.DefaultManagementApi("/merchants/{merchantId}/shippingLocations"),
            [new TemplateParam("merchantId", request.MerchantId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<ShippingLocation>(),
            CreateMerchantShippingLocationError.Response,
            AuthScheme.Any(_auth.BasicAuth, _auth.ApiKeyAuth),
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Create an order
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TerminalOrder"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="CreateMerchantTerminalOrderError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Creates an order for payment terminal products for the merchant account identified in the path.
    /// <para>
    /// To make this request, your API credential must have the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">role</see>:
    /// * Management API—Terminal ordering read and write
    /// &gt;Requests to the Management API test endpoint do not create actual orders for test terminals. To order test terminals, you need to <see href="https://docs.adyen.com/point-of-sale/managing-terminals/order-terminals/#sales-order-steps">submit a sales order</see> in your Customer Area.
    /// </para>
    /// <para>
    /// In the live environment, requests to this endpoint are subject to <see href="https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment">rate limits</see>.
    /// </para>
    /// </remarks>
    public Task<TerminalOrder> CreateMerchantTerminalOrder(CreateMerchantTerminalOrderRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.DefaultManagementApi("/merchants/{merchantId}/terminalOrders"),
            [new TemplateParam("merchantId", request.MerchantId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<TerminalOrder>(),
            CreateMerchantTerminalOrderError.Response,
            AuthScheme.Any(_auth.BasicAuth, _auth.ApiKeyAuth),
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get an order
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TerminalOrder"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetMerchantTerminalOrderError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns the details of the terminal products order identified in the path.
    /// <para>
    /// To make this request, your API credential must have one of the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">roles</see>:
    /// * Management API—Terminal ordering read
    /// * Management API—Terminal ordering read and write
    /// </para>
    /// <para>
    /// In the live environment, requests to this endpoint are subject to <see href="https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment">rate limits</see>.
    /// </para>
    /// </remarks>
    public Task<TerminalOrder> GetMerchantTerminalOrder(GetMerchantTerminalOrderRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.DefaultManagementApi("/merchants/{merchantId}/terminalOrders/{orderId}"),
            [new TemplateParam("merchantId", request.MerchantId), new TemplateParam("orderId", request.OrderId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<TerminalOrder>(),
            GetMerchantTerminalOrderError.Response,
            AuthScheme.Any(_auth.BasicAuth, _auth.ApiKeyAuth),
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get a list of billing entities
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="BillingEntitiesResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="ListMerchantBillingEntitiesError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns the billing entities of the merchant account identified in the path.
    /// A billing entity is a legal entity where we charge orders to. An order for terminal products must contain the ID of a billing entity.
    /// <para>
    /// To make this request, your API credential must have one of the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">roles</see>:
    /// * Management API—Terminal ordering read
    /// * Management API—Terminal ordering read and write
    /// </para>
    /// <para>
    /// In the live environment, requests to this endpoint are subject to <see href="https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment">rate limits</see>.
    /// </para>
    /// </remarks>
    public Task<BillingEntitiesResponse> ListMerchantBillingEntities(ListMerchantBillingEntitiesRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.DefaultManagementApi("/merchants/{merchantId}/billingEntities"),
            [new TemplateParam("merchantId", request.MerchantId)],
            [new Param("name", request.Name)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<BillingEntitiesResponse>(),
            ListMerchantBillingEntitiesError.Response,
            AuthScheme.Any(_auth.BasicAuth, _auth.ApiKeyAuth),
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get a list of shipping locations
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ShippingLocationsResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="ListMerchantShippingLocationsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns the shipping locations for the merchant account identified in the path.
    /// A shipping location includes the address where orders can be delivered, and an ID which you need to specify when ordering terminal products.
    /// <para>
    /// To make this request, your API credential must have one of the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">roles</see>:
    /// * Management API—Terminal ordering read
    /// * Management API—Terminal ordering read and write
    /// </para>
    /// <para>
    /// In the live environment, requests to this endpoint are subject to <see href="https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment">rate limits</see>.
    /// </para>
    /// </remarks>
    public Task<ShippingLocationsResponse> ListMerchantShippingLocations(ListMerchantShippingLocationsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.DefaultManagementApi("/merchants/{merchantId}/shippingLocations"),
            [new TemplateParam("merchantId", request.MerchantId)],
            [new Param("name", request.Name), new Param("offset", request.Offset), new Param("limit", request.Limit)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ShippingLocationsResponse>(),
            ListMerchantShippingLocationsError.Response,
            AuthScheme.Any(_auth.BasicAuth, _auth.ApiKeyAuth),
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get a list of terminal models
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TerminalModelsResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="ListMerchantTerminalModelsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns the payment terminal models that the merchant account identified in the path has access to. The response includes the terminal model ID, which can be used as a query parameter when getting a list of terminals or a list of products for ordering.
    /// <para>
    /// To make this request, your API credential must have one of the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">roles</see>:
    /// * Management API—Terminal ordering read
    /// * Management API—Terminal ordering read and write
    /// </para>
    /// <para>
    /// In the live environment, requests to this endpoint are subject to <see href="https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment">rate limits</see>.
    /// </para>
    /// </remarks>
    public Task<TerminalModelsResponse> ListMerchantTerminalModels(ListMerchantTerminalModelsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.DefaultManagementApi("/merchants/{merchantId}/terminalModels"),
            [new TemplateParam("merchantId", request.MerchantId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<TerminalModelsResponse>(),
            ListMerchantTerminalModelsError.Response,
            AuthScheme.Any(_auth.BasicAuth, _auth.ApiKeyAuth),
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get a list of orders
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TerminalOrdersResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="ListMerchantTerminalOrdersError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns a list of terminal products orders for the merchant account identified in the path.
    /// <para>
    /// To make this request, your API credential must have one of the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">roles</see>:
    /// * Management API—Terminal ordering read
    /// * Management API—Terminal ordering read and write
    /// </para>
    /// <para>
    /// In the live environment, requests to this endpoint are subject to <see href="https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment">rate limits</see>.
    /// </para>
    /// </remarks>
    public Task<TerminalOrdersResponse> ListMerchantTerminalOrders(ListMerchantTerminalOrdersRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.DefaultManagementApi("/merchants/{merchantId}/terminalOrders"),
            [new TemplateParam("merchantId", request.MerchantId)],
            [
                new Param("customerOrderReference", request.CustomerOrderReference),
                new Param("status", request.Status),
                new Param("offset", request.Offset),
                new Param("limit", request.Limit),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<TerminalOrdersResponse>(),
            ListMerchantTerminalOrdersError.Response,
            AuthScheme.Any(_auth.BasicAuth, _auth.ApiKeyAuth),
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get a list of terminal products
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TerminalProductsResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="ListMerchantTerminalProductsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns a country-specific list of payment terminal packages and parts that the merchant account identified in the path has access to.
    /// <para>
    /// To make this request, your API credential must have one of the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">roles</see>:
    /// * Management API—Terminal ordering read
    /// * Management API—Terminal ordering read and write
    /// </para>
    /// <para>
    /// In the live environment, requests to this endpoint are subject to <see href="https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment">rate limits</see>.
    /// </para>
    /// </remarks>
    public Task<TerminalProductsResponse> ListMerchantTerminalProducts(ListMerchantTerminalProductsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.DefaultManagementApi("/merchants/{merchantId}/terminalProducts"),
            [new TemplateParam("merchantId", request.MerchantId)],
            [
                new Param("country", request.Country),
                new Param("terminalModelId", request.TerminalModelId),
                new Param("offset", request.Offset),
                new Param("limit", request.Limit),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<TerminalProductsResponse>(),
            ListMerchantTerminalProductsError.Response,
            AuthScheme.Any(_auth.BasicAuth, _auth.ApiKeyAuth),
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Update an order
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TerminalOrder"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="UpdateMerchantTerminalOrderError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Updates the terminal products order identified in the path.
    /// Updating is only possible while the order has the status <b>Placed</b>.
    /// <para>
    /// The request body only needs to contain what you want to change.
    /// However, to update the products in the <c>items</c> array, you must provide the entire array. For example, if the array has three items:
    ///  To remove one item, the array must include the remaining two items. Or to add one item, the array must include all four items.
    /// </para>
    /// <para>
    /// To make this request, your API credential must have the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">role</see>:
    /// * Management API—Terminal ordering read and write
    /// </para>
    /// <para>
    /// In the live environment, requests to this endpoint are subject to <see href="https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment">rate limits</see>.
    /// </para>
    /// </remarks>
    public Task<TerminalOrder> UpdateMerchantTerminalOrder(UpdateMerchantTerminalOrderRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.DefaultManagementApi("/merchants/{merchantId}/terminalOrders/{orderId}"),
            [new TemplateParam("merchantId", request.MerchantId), new TemplateParam("orderId", request.OrderId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            new HttpMethod("PATCH"),
            JsonRequest.Create(request.Body),
            JsonResponse.Create<TerminalOrder>(),
            UpdateMerchantTerminalOrderError.Response,
            AuthScheme.Any(_auth.BasicAuth, _auth.ApiKeyAuth),
            requestOptions,
            cancellationToken);
}
