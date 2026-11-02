<!-- Generated file — do not edit; regenerated with the SDK. -->

# Payments — operations

Accessor: `client.Payments` · Source: `src/AdyenApIs/Api/Payments.cs` · 6 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CreateCheckoutSession

- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `CreateCheckoutSession(CreateCheckoutSessionOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `CreateCheckoutSessionResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreateCheckoutSessionOperationRequest` | `src/AdyenApIs/Requests/Payments/CreateCheckoutSessionOperationRequest.cs` |
| `CreateCheckoutSessionRequest` | `src/AdyenApIs/Models/CreateCheckoutSessionRequest.cs` |
| `CreateCheckoutSessionResponse` | `src/AdyenApIs/Models/CreateCheckoutSessionResponse.cs` |

### CreatePayment

- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `CreatePayment(CreatePaymentRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `PaymentResponse`
- **Error**: `ApiException<CreatePaymentError>` — **Case A (typed)**
- **Error accessors**: `TryGetServiceError(out ServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CreatePaymentRequest` | `src/AdyenApIs/Requests/Payments/CreatePaymentRequest.cs` |
| `PaymentRequest` | `src/AdyenApIs/Models/PaymentRequest.cs` |
| `PaymentResponse` | `src/AdyenApIs/Models/PaymentResponse.cs` |
| `CreatePaymentError` | `src/AdyenApIs/Errors/CreatePaymentError.cs` |
| `ServiceError` | `src/AdyenApIs/Models/ServiceError.cs` |

### GetCardDetails

- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `GetCardDetails(GetCardDetailsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `CardDetailsResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `GetCardDetailsRequest` | `src/AdyenApIs/Requests/Payments/GetCardDetailsRequest.cs` |
| `CardDetailsRequest` | `src/AdyenApIs/Models/CardDetailsRequest.cs` |
| `CardDetailsResponse` | `src/AdyenApIs/Models/CardDetailsResponse.cs` |

### GetCheckoutSession

- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `GetCheckoutSession(GetCheckoutSessionRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `SessionId`, `SessionResult`
- **Query params (wire ← C#)**: `sessionResult` ← `SessionResult`
- **Returns**: `SessionResultResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `GetCheckoutSessionRequest` | `src/AdyenApIs/Requests/Payments/GetCheckoutSessionRequest.cs` |
| `SessionResultResponse` | `src/AdyenApIs/Models/SessionResultResponse.cs` |

### GetPaymentDetails

- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `GetPaymentDetails(GetPaymentDetailsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `PaymentDetailsResponse`
- **Error**: `ApiException<GetPaymentDetailsError>` — **Case A (typed)**
- **Error accessors**: `TryGetServiceError(out ServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetPaymentDetailsRequest` | `src/AdyenApIs/Requests/Payments/GetPaymentDetailsRequest.cs` |
| `PaymentDetailsRequest` | `src/AdyenApIs/Models/PaymentDetailsRequest.cs` |
| `PaymentDetailsResponse` | `src/AdyenApIs/Models/PaymentDetailsResponse.cs` |
| `GetPaymentDetailsError` | `src/AdyenApIs/Errors/GetPaymentDetailsError.cs` |
| `ServiceError` | `src/AdyenApIs/Models/ServiceError.cs` |

### GetPaymentMethods

- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `GetPaymentMethods(GetPaymentMethodsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `PaymentMethodsResponse`
- **Error**: `ApiException<GetPaymentMethodsError>` — **Case A (typed)**
- **Error accessors**: `TryGetServiceError(out ServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetPaymentMethodsRequest` | `src/AdyenApIs/Requests/Payments/GetPaymentMethodsRequest.cs` |
| `PaymentMethodsRequest` | `src/AdyenApIs/Models/PaymentMethodsRequest.cs` |
| `PaymentMethodsResponse` | `src/AdyenApIs/Models/PaymentMethodsResponse.cs` |
| `GetPaymentMethodsError` | `src/AdyenApIs/Errors/GetPaymentMethodsError.cs` |
| `ServiceError` | `src/AdyenApIs/Models/ServiceError.cs` |

