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
using AdyenApIs.Requests.Modifications;

namespace AdyenApIs.Api;

public sealed class Modifications
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal Modifications(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Cancel an authorised payment
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PaymentCancelResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="CancelAuthorisedPaymentError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Cancels the authorisation on a payment that has not yet been <see href="https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/payments/{paymentPspReference}/captures">captured</see>, and returns a unique reference for this request. You get the outcome of the request asynchronously, in a <see href="https://docs.adyen.com/online-payments/cancel#cancellation-webhook"><b>CANCELLATION</b> webhook</see>.
    /// <para>
    /// If you want to cancel a payment but don't have the <see href="https://docs.adyen.com/api-explorer/Checkout/latest/post/payments#responses-200-pspReference"><c>pspReference</c></see>, use the <see href="https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/cancels"><c>/cancels</c></see> endpoint instead.
    /// </para>
    /// <para>
    /// If you want to cancel a payment but are not sure whether it has been captured, use the <see href="https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/payments/{paymentPspReference}/reversals"><c>/payments/{paymentPspReference}/reversals</c></see> endpoint instead.
    /// </para>
    /// <para>
    /// For more information, refer to <see href="https://docs.adyen.com/online-payments/cancel">Cancel</see>.
    /// </para>
    /// </remarks>
    public Task<PaymentCancelResponse> CancelAuthorisedPayment(CancelAuthorisedPaymentRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/payments/{paymentPspReference}/cancels"),
            [new TemplateParam("paymentPspReference", request.PaymentPspReference)],
            [],
            [new HeaderParam("Idempotency-Key", request.IdempotencyKey)],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<PaymentCancelResponse>(),
            CancelAuthorisedPaymentError.Response,
            AuthScheme.Any(_auth.BasicAuth, _auth.ApiKeyAuth),
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Cancel an authorised payment
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="StandalonePaymentCancelResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="CancelPaymentError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Cancels the authorisation on a payment that has not yet been <see href="https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/payments/{paymentPspReference}/captures">captured</see>, and returns a unique reference for this request. You get the outcome of the request asynchronously, in a <see href="https://docs.adyen.com/online-payments/cancel#cancellation-webhook"><b>TECHNICAL_CANCEL</b> webhook</see>.
    /// <para>
    /// If you want to cancel a payment using the <see href="https://docs.adyen.com/api-explorer/Checkout/latest/post/payments#responses-200-pspReference"><c>pspReference</c></see>, use the <see href="https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/payments/{paymentPspReference}/cancels"><c>/payments/{paymentPspReference}/cancels</c></see> endpoint instead.
    /// </para>
    /// <para>
    /// If you want to cancel a payment but are not sure whether it has been captured, use the <see href="https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/payments/{paymentPspReference}/reversals"><c>/payments/{paymentPspReference}/reversals</c></see> endpoint instead.
    /// </para>
    /// <para>
    /// For more information, refer to <see href="https://docs.adyen.com/online-payments/cancel">Cancel</see>.
    /// </para>
    /// </remarks>
    public Task<StandalonePaymentCancelResponse> CancelPayment(CancelPaymentRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/cancels"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", request.IdempotencyKey)],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<StandalonePaymentCancelResponse>(),
            CancelPaymentError.Response,
            AuthScheme.Any(_auth.BasicAuth, _auth.ApiKeyAuth),
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Capture an authorised payment
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PaymentCaptureResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="CapturePaymentError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Captures an authorised payment and returns a unique reference for this request. You get the outcome of the request asynchronously, in a <see href="https://docs.adyen.com/online-payments/capture#capture-notification"><b>CAPTURE</b> webhook</see>.
    /// <para>
    /// You can capture either the full authorised amount or a part of the authorised amount. By default, any unclaimed amount after a partial capture gets cancelled. This does not apply if you enabled multiple partial captures on your account and the payment method supports multiple partial captures.
    /// </para>
    /// <para>
    /// <see href="https://docs.adyen.com/online-payments/capture#automatic-capture">Automatic capture</see> is the default setting for most payment methods. In these cases, you don't need to make capture requests. However, making capture requests for payments that are captured automatically does not result in double charges.
    /// </para>
    /// <para>
    /// For more information, refer to <see href="https://docs.adyen.com/online-payments/capture">Capture</see>.
    /// </para>
    /// </remarks>
    public Task<PaymentCaptureResponse> CapturePayment(CapturePaymentRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/payments/{paymentPspReference}/captures"),
            [new TemplateParam("paymentPspReference", request.PaymentPspReference)],
            [],
            [new HeaderParam("Idempotency-Key", request.IdempotencyKey)],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<PaymentCaptureResponse>(),
            CapturePaymentError.Response,
            AuthScheme.Any(_auth.BasicAuth, _auth.ApiKeyAuth),
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Refund a captured payment
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PaymentRefundResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RefundPaymentError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Refunds a payment that has been <see href="https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/payments/{paymentPspReference}/captures">captured</see>, and returns a unique reference for this request. You get the outcome of the request asynchronously, in a <see href="https://docs.adyen.com/online-payments/refund#refund-webhook"><b>REFUND</b> webhook</see>.
    /// <para>
    /// You can refund either the full captured amount or a part of the captured amount. You can also perform multiple partial refunds, as long as their sum doesn't exceed the captured amount.
    /// </para>
    /// <para>
    /// &gt; Some payment methods do not support partial refunds. To learn if a payment method supports partial refunds, refer to the payment method page such as <see href="https://docs.adyen.com/payment-methods/cards#supported-cards">cards</see>, <see href="https://docs.adyen.com/payment-methods/ideal">iDEAL</see>, or <see href="https://docs.adyen.com/payment-methods/klarna">Klarna</see>.
    /// </para>
    /// <para>
    /// If you want to refund a payment but are not sure whether it has been captured, use the <see href="https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/payments/{paymentPspReference}/reversals"><c>/payments/{paymentPspReference}/reversals</c></see> endpoint instead.
    /// </para>
    /// <para>
    /// For more information, refer to <see href="https://docs.adyen.com/online-payments/refund">Refund</see>.
    /// </para>
    /// </remarks>
    public Task<PaymentRefundResponse> RefundPayment(RefundPaymentRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/payments/{paymentPspReference}/refunds"),
            [new TemplateParam("paymentPspReference", request.PaymentPspReference)],
            [],
            [new HeaderParam("Idempotency-Key", request.IdempotencyKey)],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<PaymentRefundResponse>(),
            RefundPaymentError.Response,
            AuthScheme.Any(_auth.BasicAuth, _auth.ApiKeyAuth),
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Refund or cancel a payment
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PaymentReversalResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="ReversePaymentError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <see href="https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/payments/{paymentPspReference}/refunds">Refunds</see> a payment if it has already been captured, and <see href="https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/payments/{paymentPspReference}/cancels">cancels</see> a payment if it has not yet been captured. Returns a unique reference for this request. You get the outcome of the request asynchronously, in a <see href="https://docs.adyen.com/online-payments/reversal/#cancel-or-refund-webhook"><b>CANCEL_OR_REFUND</b> webhook</see>.
    /// <para>
    /// The reversed amount is always the full payment amount.
    /// &gt; Do not use this request for payments that involve multiple partial captures.
    /// </para>
    /// <para>
    /// For more information, refer to <see href="https://docs.adyen.com/online-payments/reversal">Reversal</see>.
    /// </para>
    /// </remarks>
    public Task<PaymentReversalResponse> ReversePayment(ReversePaymentRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/payments/{paymentPspReference}/reversals"),
            [new TemplateParam("paymentPspReference", request.PaymentPspReference)],
            [],
            [new HeaderParam("Idempotency-Key", request.IdempotencyKey)],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<PaymentReversalResponse>(),
            ReversePaymentError.Response,
            AuthScheme.Any(_auth.BasicAuth, _auth.ApiKeyAuth),
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Update an authorised amount
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PaymentAmountUpdateResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="UpdatePaymentAmountError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Increases or decreases the authorised payment amount and returns a unique reference for this request. You get the outcome of the request asynchronously, in an <see href="https://docs.adyen.com/development-resources/webhooks/webhook-types/#event-codes"><b>AUTHORISATION_ADJUSTMENT</b> webhook</see>.
    /// <para>
    /// You can only update authorised amounts that have not yet been <see href="https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/payments/{paymentPspReference}/captures">captured</see>.
    /// </para>
    /// <para>
    /// The amount you specify in the request is the updated amount, which is larger or smaller than the initial authorised amount.
    /// </para>
    /// <para>
    /// For more information, refer to <see href="https://docs.adyen.com/online-payments/adjust-authorisation#use-cases">Authorisation adjustment</see>.
    /// </para>
    /// </remarks>
    public Task<PaymentAmountUpdateResponse> UpdatePaymentAmount(UpdatePaymentAmountRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/payments/{paymentPspReference}/amountUpdates"),
            [new TemplateParam("paymentPspReference", request.PaymentPspReference)],
            [],
            [new HeaderParam("Idempotency-Key", request.IdempotencyKey)],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<PaymentAmountUpdateResponse>(),
            UpdatePaymentAmountError.Response,
            AuthScheme.Any(_auth.BasicAuth, _auth.ApiKeyAuth),
            requestOptions,
            cancellationToken);
}
