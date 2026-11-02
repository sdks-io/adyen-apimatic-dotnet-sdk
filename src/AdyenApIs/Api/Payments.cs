using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using AdyenApIs.Core;
using AdyenApIs.Core.Authentication;
using AdyenApIs.Core.ErrorResponse;
using AdyenApIs.Core.Exceptions;
using AdyenApIs.Core.Models;
using AdyenApIs.Core.Request;
using AdyenApIs.Core.Response;
using AdyenApIs.Errors;
using AdyenApIs.Models;
using AdyenApIs.Requests.Payments;

namespace AdyenApIs.Api;

public sealed class Payments
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal Payments(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Create a payment session
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CreateCheckoutSessionResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Creates a payment session for <see href="https://docs.adyen.com/online-payments/build-your-integration/sessions-flow/?platform=Web&amp;integration=Drop-in">Drop-in</see>, <see href="https://docs.adyen.com/online-payments/build-your-integration/sessions-flow/?platform=Web&amp;integration=Components">Components</see>, and <see href="https://docs.adyen.com/online-payments/build-your-integration/sessions-flow/?platform=Web&amp;integration=Hosted+Checkout">Hosted Checkout</see> integrations.
    /// <para>
    /// The response contains encrypted payment session data. The front end then uses the session data to make any required server-side calls for the payment flow.
    /// </para>
    /// <para>
    /// You get the payment outcome asynchronously, in an <see href="https://docs.adyen.com/api-explorer/#/Webhooks/latest/post/AUTHORISATION">AUTHORISATION</see> webhook.
    /// </para>
    /// </remarks>
    public Task<CreateCheckoutSessionResponse> CreateCheckoutSession(CreateCheckoutSessionOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sessions"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", request.IdempotencyKey)],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<CreateCheckoutSessionResponse>(),
            RawErrorResponse.Instance,
            AuthScheme.Any(_auth.BasicAuth, _auth.ApiKeyAuth),
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Start a transaction
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PaymentResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="CreatePaymentError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Sends payment parameters (like amount, country, and currency) together with other required input details collected from the shopper. To know more about required parameters for specific payment methods, refer to our <see href="https://docs.adyen.com/payment-methods">payment method guides</see>.
    /// The response depends on the <see href="https://docs.adyen.com/payment-methods#payment-flow">payment flow</see>:
    /// * For a direct flow, the response includes a <c>pspReference</c> and a <c>resultCode</c> with the payment result, for example <b>Authorised</b> or <b>Refused</b>.
    /// * For a redirect or additional action, the response contains an <c>action</c> object.
    /// </remarks>
    public Task<PaymentResponse> CreatePayment(CreatePaymentRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/payments"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", request.IdempotencyKey)],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<PaymentResponse>(),
            CreatePaymentError.Response,
            AuthScheme.Any(_auth.BasicAuth, _auth.ApiKeyAuth),
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get the brands and other details of a card
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CardDetailsResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Use this endpoint to get information about the card or network token that enables you to decide on the routing of the transaction and the eligibility of the card for the type of transaction.
    /// <para>
    /// If you include <see href="https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/cardDetails__reqParam_supportedBrands">your supported brands</see> in the request, the response also tells you if you support each <see href="https://docs.adyen.com/api-explorer/Checkout/latest/post/cardDetails#responses-200-brands">brand that was identified on the card</see>.
    /// </para>
    /// <para>
    /// If you have an API-only integration and collect card data, use this endpoint to find out if the shopper's card is co-bad. For co-badged cards, you must let the shopper choose the brand to pay with  if you support both brands.
    /// </para>
    /// <para>
    /// ## Server-side API libraries
    /// We provide open-source <see href="https://docs.adyen.com/development-resources/libraries/">server-side API libraries</see> in several languages:
    /// - PHP
    /// - Java
    /// - Node.js
    /// - .NET
    /// - Go
    /// - Python
    /// - Ruby
    /// - Apex (beta)
    /// </para>
    /// <para>
    /// See our <see href="https://github.com/adyen-examples#%EF%B8%8F-official-integration-examples">integration examples</see> for example uses of the libraries.
    /// </para>
    /// <para>
    /// ## Developer resources
    /// BIN Lookup API is available through a Postman collection. Click the button below to create a fork, then set the environment variables at <b>Environments</b>&amp;nbsp;&gt;&amp;nbsp;<b>Adyen&amp;nbsp;APIs</b>.
    /// </para>
    /// <para>
    /// <see href="https://god.gw.postman.com/run-collection/25716737-677c7679-a695-4ebb-91da-68b4e7c9228a?action=collection%2Ffork&amp;source=rip_markdown&amp;collection-url=entityId%3D25716737-677c7679-a695-4ebb-91da-68b4e7c9228a%26entityType%3Dcollection%26workspaceId%3Da8d63f9f-cfc7-4810-90c5-9e0c60030d3e#?env%5BAdyen%20APIs%5D=W3sia2V5IjoiWC1BUEktS2V5IiwidmFsdWUiOiIiLCJlbmFibGVkIjp0cnVlLCJ0eXBlIjoic2VjcmV0In0seyJrZXkiOiJZT1VSX01FUkNIQU5UX0FDQ09VTlQiLCJ2YWx1ZSI6IiIsImVuYWJsZWQiOnRydWUsInR5cGUiOiJkZWZhdWx0In0seyJrZXkiOiJZT1VSX0NPTVBBTllfQUNDT1VOVCIsInZhbHVlIjoiIiwiZW5hYmxlZCI6dHJ1ZSwidHlwZSI6ImRlZmF1bHQifSx7ImtleSI6IllPVVJfQkFMQU5DRV9QTEFURk9STSIsInZhbHVlIjoiIiwiZW5hYmxlZCI6dHJ1ZSwidHlwZSI6ImRlZmF1bHQifV0=">Run in Postman</see>
    /// </para>
    /// </remarks>
    public Task<CardDetailsResponse> GetCardDetails(GetCardDetailsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/cardDetails"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", request.IdempotencyKey)],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<CardDetailsResponse>(),
            RawErrorResponse.Instance,
            AuthScheme.Any(_auth.BasicAuth, _auth.ApiKeyAuth),
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get the result of a payment session
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SessionResultResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns the status of the payment session with the <c>sessionId</c> and <c>sessionResult</c> specified in the path.
    /// </remarks>
    public Task<SessionResultResponse> GetCheckoutSession(GetCheckoutSessionRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sessions/{sessionId}"),
            [new TemplateParam("sessionId", request.SessionId)],
            [new Param("sessionResult", request.SessionResult)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SessionResultResponse>(),
            RawErrorResponse.Instance,
            AuthScheme.Any(_auth.BasicAuth, _auth.ApiKeyAuth),
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Submit details for a payment
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PaymentDetailsResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetPaymentDetailsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Submits details for a payment created using <c>/payments</c>. This step is only needed when no final state has been reached on the <c>/payments</c> request, for example when the shopper was redirected to another page to complete the payment.
    /// </remarks>
    public Task<PaymentDetailsResponse> GetPaymentDetails(GetPaymentDetailsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/payments/details"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", request.IdempotencyKey)],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<PaymentDetailsResponse>(),
            GetPaymentDetailsError.Response,
            AuthScheme.Any(_auth.BasicAuth, _auth.ApiKeyAuth),
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get a list of available payment methods
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PaymentMethodsResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetPaymentMethodsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieves the list of available payment methods for the transaction, based on the transaction information like amount, country, and currency.
    /// </remarks>
    public Task<PaymentMethodsResponse> GetPaymentMethods(GetPaymentMethodsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/paymentMethods"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", request.IdempotencyKey)],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<PaymentMethodsResponse>(),
            GetPaymentMethodsError.Response,
            AuthScheme.Any(_auth.BasicAuth, _auth.ApiKeyAuth),
            requestOptions,
            cancellationToken);
}
