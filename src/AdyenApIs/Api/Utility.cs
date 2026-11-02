using System;
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
using AdyenApIs.Requests.Utility;

namespace AdyenApIs.Api;

public sealed class Utility
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal Utility(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Create originKey values for domains
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="UtilityResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GenerateOriginKeysError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This operation takes the origin domains and returns a JSON object containing the corresponding origin keys for the domains.
    /// &gt; If you're still using origin key for your Web Drop-in or Components integration, we recommend <see href="https://docs.adyen.com/development-resources/client-side-authentication/migrate-from-origin-key-to-client-key">switching to client key</see>. This allows you to use a single key for all origins, add or remove origins without generating a new key, and detect the card type from the number entered in your payment form.
    /// </remarks>
    public Task<UtilityResponse> GenerateOriginKeys(GenerateOriginKeysRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/originKeys"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", request.IdempotencyKey)],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<UtilityResponse>(),
            GenerateOriginKeysError.Response,
            AuthScheme.Any(_auth.BasicAuth, _auth.ApiKeyAuth),
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get an Apple Pay session
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ApplePaySessionResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// You need to use this endpoint if you have an API-only integration with Apple Pay which uses Adyen's Apple Pay certificate.
    /// <para>
    /// The endpoint returns the Apple Pay session data which you need to complete the <see href="https://docs.adyen.com/payment-methods/apple-pay/api-only?tab=adyen-certificate-validation_1#complete-apple-pay-session-validation">Apple Pay session validation</see>.
    /// </para>
    /// </remarks>
    public Task<ApplePaySessionResponse> GetApplePaySession(GetApplePaySessionRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/applePay/sessions"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", request.IdempotencyKey)],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<ApplePaySessionResponse>(),
            RawErrorResponse.Instance,
            AuthScheme.Any(_auth.BasicAuth, _auth.ApiKeyAuth),
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Updates the order for PayPal Express Checkout
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PaypalUpdateOrderResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="UpdatePayPalOrderError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Updates the order for PayPal Express Checkout. This can be used to update the PayPal lightbox with an updated amount and delivery methods based on the delivery address.
    /// </remarks>
    public Task<PaypalUpdateOrderResponse> UpdatePayPalOrder(UpdatePayPalOrderRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/paypal/updateOrder"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", request.IdempotencyKey)],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<PaypalUpdateOrderResponse>(),
            UpdatePayPalOrderError.Response,
            AuthScheme.Any(_auth.BasicAuth, _auth.ApiKeyAuth),
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Validates shopper Id
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ValidateShopperIdResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="ValidateShopperIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Validates the shopperId.
    /// </remarks>
    public Task<ValidateShopperIdResponse> ValidateShopperId(ValidateShopperIdOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/validateShopperId"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<ValidateShopperIdResponse>(),
            ValidateShopperIdError.Response,
            AuthScheme.None,
            requestOptions,
            cancellationToken);
}
