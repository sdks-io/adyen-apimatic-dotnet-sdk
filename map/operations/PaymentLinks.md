<!-- Generated file — do not edit; regenerated with the SDK. -->

# PaymentLinks — operations

Accessor: `client.PaymentLinks` · Source: `src/AdyenApIs/Api/PaymentLinks.cs` · 3 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CreatePaymentLink

- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `CreatePaymentLink(CreatePaymentLinkRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `PaymentLinkResponse`
- **Error**: `ApiException<CreatePaymentLinkError>` — **Case A (typed)**
- **Error accessors**: `TryGetServiceError(out ServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CreatePaymentLinkRequest` | `src/AdyenApIs/Requests/PaymentLinks/CreatePaymentLinkRequest.cs` |
| `PaymentLinkRequest` | `src/AdyenApIs/Models/PaymentLinkRequest.cs` |
| `PaymentLinkResponse` | `src/AdyenApIs/Models/PaymentLinkResponse.cs` |
| `CreatePaymentLinkError` | `src/AdyenApIs/Errors/CreatePaymentLinkError.cs` |
| `ServiceError` | `src/AdyenApIs/Models/ServiceError.cs` |

### GetPaymentLink

- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `GetPaymentLink(GetPaymentLinkRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `LinkId`
- **Returns**: `PaymentLinkResponse`
- **Error**: `ApiException<GetPaymentLinkError>` — **Case A (typed)**
- **Error accessors**: `TryGetServiceError(out ServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetPaymentLinkRequest` | `src/AdyenApIs/Requests/PaymentLinks/GetPaymentLinkRequest.cs` |
| `PaymentLinkResponse` | `src/AdyenApIs/Models/PaymentLinkResponse.cs` |
| `GetPaymentLinkError` | `src/AdyenApIs/Errors/GetPaymentLinkError.cs` |
| `ServiceError` | `src/AdyenApIs/Models/ServiceError.cs` |

### UpdatePaymentLink

- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `UpdatePaymentLink(UpdatePaymentLinkOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `LinkId`
- **Returns**: `PaymentLinkResponse`
- **Error**: `ApiException<UpdatePaymentLinkError>` — **Case A (typed)**
- **Error accessors**: `TryGetServiceError(out ServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UpdatePaymentLinkOperationRequest` | `src/AdyenApIs/Requests/PaymentLinks/UpdatePaymentLinkOperationRequest.cs` |
| `UpdatePaymentLinkRequest` | `src/AdyenApIs/Models/UpdatePaymentLinkRequest.cs` |
| `PaymentLinkResponse` | `src/AdyenApIs/Models/PaymentLinkResponse.cs` |
| `UpdatePaymentLinkError` | `src/AdyenApIs/Errors/UpdatePaymentLinkError.cs` |
| `ServiceError` | `src/AdyenApIs/Models/ServiceError.cs` |

