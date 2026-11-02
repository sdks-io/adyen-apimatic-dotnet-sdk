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
using AdyenApIs.Requests.Orders;

namespace AdyenApIs.Api;

public sealed class Orders
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal Orders(RawClient rawClient, Server server, AuthSchemes auth)
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
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CancelOrderResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="CancelOrderError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Cancels an order. Cancellation of an order results in an automatic rollback of all payments made in the order, either by canceling or refunding the payment, depending on the type of payment method.
    /// </remarks>
    public Task<CancelOrderResponse> CancelOrder(CancelOrderOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/orders/cancel"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", request.IdempotencyKey)],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<CancelOrderResponse>(),
            CancelOrderError.Response,
            AuthScheme.Any(_auth.BasicAuth, _auth.ApiKeyAuth),
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Create an order
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CreateOrderResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="CreateOrderError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Creates an order to be used for partial payments. Make a POST <c>/orders</c> call before making a <c>/payments</c> call when processing payments with different payment methods.
    /// </remarks>
    public Task<CreateOrderResponse> CreateOrder(CreateOrderOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/orders"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", request.IdempotencyKey)],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<CreateOrderResponse>(),
            CreateOrderError.Response,
            AuthScheme.Any(_auth.BasicAuth, _auth.ApiKeyAuth),
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get the balance of a gift card
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="BalanceCheckResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetPaymentMethodBalanceError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieves the balance remaining on a shopper's gift card. To check a gift card's balance, make a POST <c>/paymentMethods/balance</c> call and include the gift card's details inside a <c>paymentMethod</c> object.
    /// </remarks>
    public Task<BalanceCheckResponse> GetPaymentMethodBalance(GetPaymentMethodBalanceRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/paymentMethods/balance"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", request.IdempotencyKey)],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<BalanceCheckResponse>(),
            GetPaymentMethodBalanceError.Response,
            AuthScheme.Any(_auth.BasicAuth, _auth.ApiKeyAuth),
            requestOptions,
            cancellationToken);
}
