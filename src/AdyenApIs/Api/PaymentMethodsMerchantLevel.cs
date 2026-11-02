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
using AdyenApIs.Requests.PaymentMethodsMerchantLevel;

namespace AdyenApIs.Api;

public sealed class PaymentMethodsMerchantLevel
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal PaymentMethodsMerchantLevel(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Add an Apple Pay domain
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="AddApplePayDomainsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Adds the new domain to the list of Apple Pay domains that are registered with the merchant account and the payment method identified in the path. For more information, see <see href="https://docs.adyen.com/payment-methods/apple-pay/web-drop-in/?tab=adyen-certificate-live_1#going-live">Apple Pay documentation</see>.
    /// <para>
    /// To make this request, your API credential must have the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">role</see>:
    /// * Management API—Payment methods read and write
    /// </para>
    /// </remarks>
    public Task AddApplePayDomains(AddApplePayDomainsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.DefaultManagementApi(
                "/merchants/{merchantId}/paymentMethodSettings/{paymentMethodId}/addApplePayDomains"),
            [
                new TemplateParam("merchantId", request.MerchantId),
                new TemplateParam("paymentMethodId", request.PaymentMethodId),
            ],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            VoidResponse.Instance,
            AddApplePayDomainsError.Response,
            AuthScheme.Any(_auth.BasicAuth, _auth.ApiKeyAuth),
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Request a payment method
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PaymentMethodManagementApi"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="CreatePaymentMethodSettingError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Sends a request to add a new payment method to the merchant account identified in the path.
    /// Depending the payment method <see href="https://docs.adyen.com/api-explorer/Management/latest/post/merchants/_merchantId_/paymentMethodSettings#request-type"><c>type</c></see>, you may need to send an additional object required for the payment method.
    /// <para>
    /// To make this request, your API credential must have the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">role</see>:
    /// * Management API—Payment methods read and write
    /// </para>
    /// </remarks>
    public Task<PaymentMethodManagementApi> CreatePaymentMethodSetting(CreatePaymentMethodSettingRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.DefaultManagementApi("/merchants/{merchantId}/paymentMethodSettings"),
            [new TemplateParam("merchantId", request.MerchantId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<PaymentMethodManagementApi>(),
            CreatePaymentMethodSettingError.Response,
            AuthScheme.Any(_auth.BasicAuth, _auth.ApiKeyAuth),
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get Apple Pay domains
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ApplePayInfo"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetApplePayDomainsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns all Apple Pay domains that are registered with the merchant account and the payment method identified in the path. For more information, see <see href="https://docs.adyen.com/payment-methods/apple-pay/enable-apple-pay#register-merchant-domain">Apple Pay documentation</see>.
    /// <para>
    /// To make this request, your API credential must have the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">role</see>:
    /// * Management API—Payment methods read
    /// </para>
    /// </remarks>
    public Task<ApplePayInfo> GetApplePayDomains(GetApplePayDomainsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.DefaultManagementApi(
                "/merchants/{merchantId}/paymentMethodSettings/{paymentMethodId}/getApplePayDomains"),
            [
                new TemplateParam("merchantId", request.MerchantId),
                new TemplateParam("paymentMethodId", request.PaymentMethodId),
            ],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ApplePayInfo>(),
            GetApplePayDomainsError.Response,
            AuthScheme.Any(_auth.BasicAuth, _auth.ApiKeyAuth),
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get payment method details
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PaymentMethodManagementApi"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetPaymentMethodSettingError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns details for the merchant account and the payment method identified in the path.
    /// <para>
    /// To make this request, your API credential must have the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">role</see>:
    /// * Management API—Payment methods read
    /// </para>
    /// </remarks>
    public Task<PaymentMethodManagementApi> GetPaymentMethodSetting(GetPaymentMethodSettingRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.DefaultManagementApi("/merchants/{merchantId}/paymentMethodSettings/{paymentMethodId}"),
            [
                new TemplateParam("merchantId", request.MerchantId),
                new TemplateParam("paymentMethodId", request.PaymentMethodId),
            ],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<PaymentMethodManagementApi>(),
            GetPaymentMethodSettingError.Response,
            AuthScheme.Any(_auth.BasicAuth, _auth.ApiKeyAuth),
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get all payment methods
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PaymentMethodResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="ListPaymentMethodSettingsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns details for all payment methods of the merchant account identified in the path.
    /// <para>
    /// To make this request, your API credential must have the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">role</see>:
    /// * Management API—Payment methods read
    /// </para>
    /// </remarks>
    public Task<PaymentMethodResponse> ListPaymentMethodSettings(ListPaymentMethodSettingsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.DefaultManagementApi("/merchants/{merchantId}/paymentMethodSettings"),
            [new TemplateParam("merchantId", request.MerchantId)],
            [
                new Param("storeId", request.StoreId),
                new Param("businessLineId", request.BusinessLineId),
                new Param("pageSize", request.PageSize),
                new Param("pageNumber", request.PageNumber),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<PaymentMethodResponse>(),
            ListPaymentMethodSettingsError.Response,
            AuthScheme.Any(_auth.BasicAuth, _auth.ApiKeyAuth),
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Update a payment method
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PaymentMethodManagementApi"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="UpdatePaymentMethodSettingError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Updates payment method details for the merchant account and the payment method identified in the path.
    /// Depending the payment method <see href="https://docs.adyen.com/api-explorer/Management/latest/patch/merchants/_merchantId_/paymentMethodSettings#request-type"><c>type</c></see>, you may need to send an additional object required for the payment method.
    /// <para>
    /// To make this request, your API credential must have the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">role</see>:
    /// * Management API—Payment methods read and write
    /// </para>
    /// </remarks>
    public Task<PaymentMethodManagementApi> UpdatePaymentMethodSetting(UpdatePaymentMethodSettingRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.DefaultManagementApi("/merchants/{merchantId}/paymentMethodSettings/{paymentMethodId}"),
            [
                new TemplateParam("merchantId", request.MerchantId),
                new TemplateParam("paymentMethodId", request.PaymentMethodId),
            ],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            new HttpMethod("PATCH"),
            JsonRequest.Create(request.Body),
            JsonResponse.Create<PaymentMethodManagementApi>(),
            UpdatePaymentMethodSettingError.Response,
            AuthScheme.Any(_auth.BasicAuth, _auth.ApiKeyAuth),
            requestOptions,
            cancellationToken);
}
