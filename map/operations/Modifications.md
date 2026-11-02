<!-- Generated file — do not edit; regenerated with the SDK. -->

# Modifications — operations

Accessor: `client.Modifications` · Source: `src/AdyenApIs/Api/Modifications.cs` · 6 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CancelAuthorisedPayment

- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `CancelAuthorisedPayment(CancelAuthorisedPaymentRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `PaymentPspReference`
- **Returns**: `PaymentCancelResponse`
- **Error**: `ApiException<CancelAuthorisedPaymentError>` — **Case A (typed)**
- **Error accessors**: `TryGetServiceError(out ServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CancelAuthorisedPaymentRequest` | `src/AdyenApIs/Requests/Modifications/CancelAuthorisedPaymentRequest.cs` |
| `PaymentCancelRequest` | `src/AdyenApIs/Models/PaymentCancelRequest.cs` |
| `PaymentCancelResponse` | `src/AdyenApIs/Models/PaymentCancelResponse.cs` |
| `CancelAuthorisedPaymentError` | `src/AdyenApIs/Errors/CancelAuthorisedPaymentError.cs` |
| `ServiceError` | `src/AdyenApIs/Models/ServiceError.cs` |

### CancelPayment

- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `CancelPayment(CancelPaymentRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `StandalonePaymentCancelResponse`
- **Error**: `ApiException<CancelPaymentError>` — **Case A (typed)**
- **Error accessors**: `TryGetServiceError(out ServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CancelPaymentRequest` | `src/AdyenApIs/Requests/Modifications/CancelPaymentRequest.cs` |
| `StandalonePaymentCancelRequest` | `src/AdyenApIs/Models/StandalonePaymentCancelRequest.cs` |
| `StandalonePaymentCancelResponse` | `src/AdyenApIs/Models/StandalonePaymentCancelResponse.cs` |
| `CancelPaymentError` | `src/AdyenApIs/Errors/CancelPaymentError.cs` |
| `ServiceError` | `src/AdyenApIs/Models/ServiceError.cs` |

### CapturePayment

- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `CapturePayment(CapturePaymentRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `PaymentPspReference`
- **Returns**: `PaymentCaptureResponse`
- **Error**: `ApiException<CapturePaymentError>` — **Case A (typed)**
- **Error accessors**: `TryGetServiceError(out ServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CapturePaymentRequest` | `src/AdyenApIs/Requests/Modifications/CapturePaymentRequest.cs` |
| `PaymentCaptureRequest` | `src/AdyenApIs/Models/PaymentCaptureRequest.cs` |
| `PaymentCaptureResponse` | `src/AdyenApIs/Models/PaymentCaptureResponse.cs` |
| `CapturePaymentError` | `src/AdyenApIs/Errors/CapturePaymentError.cs` |
| `ServiceError` | `src/AdyenApIs/Models/ServiceError.cs` |

### RefundPayment

- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `RefundPayment(RefundPaymentRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `PaymentPspReference`
- **Returns**: `PaymentRefundResponse`
- **Error**: `ApiException<RefundPaymentError>` — **Case A (typed)**
- **Error accessors**: `TryGetServiceError(out ServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `RefundPaymentRequest` | `src/AdyenApIs/Requests/Modifications/RefundPaymentRequest.cs` |
| `PaymentRefundRequest` | `src/AdyenApIs/Models/PaymentRefundRequest.cs` |
| `PaymentRefundResponse` | `src/AdyenApIs/Models/PaymentRefundResponse.cs` |
| `RefundPaymentError` | `src/AdyenApIs/Errors/RefundPaymentError.cs` |
| `ServiceError` | `src/AdyenApIs/Models/ServiceError.cs` |

### ReversePayment

- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `ReversePayment(ReversePaymentRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `PaymentPspReference`
- **Returns**: `PaymentReversalResponse`
- **Error**: `ApiException<ReversePaymentError>` — **Case A (typed)**
- **Error accessors**: `TryGetServiceError(out ServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ReversePaymentRequest` | `src/AdyenApIs/Requests/Modifications/ReversePaymentRequest.cs` |
| `PaymentReversalRequest` | `src/AdyenApIs/Models/PaymentReversalRequest.cs` |
| `PaymentReversalResponse` | `src/AdyenApIs/Models/PaymentReversalResponse.cs` |
| `ReversePaymentError` | `src/AdyenApIs/Errors/ReversePaymentError.cs` |
| `ServiceError` | `src/AdyenApIs/Models/ServiceError.cs` |

### UpdatePaymentAmount

- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `UpdatePaymentAmount(UpdatePaymentAmountRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `PaymentPspReference`
- **Returns**: `PaymentAmountUpdateResponse`
- **Error**: `ApiException<UpdatePaymentAmountError>` — **Case A (typed)**
- **Error accessors**: `TryGetServiceError(out ServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UpdatePaymentAmountRequest` | `src/AdyenApIs/Requests/Modifications/UpdatePaymentAmountRequest.cs` |
| `PaymentAmountUpdateRequest` | `src/AdyenApIs/Models/PaymentAmountUpdateRequest.cs` |
| `PaymentAmountUpdateResponse` | `src/AdyenApIs/Models/PaymentAmountUpdateResponse.cs` |
| `UpdatePaymentAmountError` | `src/AdyenApIs/Errors/UpdatePaymentAmountError.cs` |
| `ServiceError` | `src/AdyenApIs/Models/ServiceError.cs` |

