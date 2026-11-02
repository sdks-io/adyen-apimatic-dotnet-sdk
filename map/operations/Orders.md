<!-- Generated file — do not edit; regenerated with the SDK. -->

# Orders — operations

Accessor: `client.Orders` · Source: `src/AdyenApIs/Api/Orders.cs` · 3 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CancelOrder

- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `CancelOrder(CancelOrderOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `CancelOrderResponse`
- **Error**: `ApiException<CancelOrderError>` — **Case A (typed)**
- **Error accessors**: `TryGetServiceError(out ServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CancelOrderOperationRequest` | `src/AdyenApIs/Requests/Orders/CancelOrderOperationRequest.cs` |
| `CancelOrderRequest` | `src/AdyenApIs/Models/CancelOrderRequest.cs` |
| `CancelOrderResponse` | `src/AdyenApIs/Models/CancelOrderResponse.cs` |
| `CancelOrderError` | `src/AdyenApIs/Errors/CancelOrderError.cs` |
| `ServiceError` | `src/AdyenApIs/Models/ServiceError.cs` |

### CreateOrder

- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `CreateOrder(CreateOrderOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `CreateOrderResponse`
- **Error**: `ApiException<CreateOrderError>` — **Case A (typed)**
- **Error accessors**: `TryGetServiceError(out ServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CreateOrderOperationRequest` | `src/AdyenApIs/Requests/Orders/CreateOrderOperationRequest.cs` |
| `CreateOrderRequest` | `src/AdyenApIs/Models/CreateOrderRequest.cs` |
| `CreateOrderResponse` | `src/AdyenApIs/Models/CreateOrderResponse.cs` |
| `CreateOrderError` | `src/AdyenApIs/Errors/CreateOrderError.cs` |
| `ServiceError` | `src/AdyenApIs/Models/ServiceError.cs` |

### GetPaymentMethodBalance

- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `GetPaymentMethodBalance(GetPaymentMethodBalanceRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `BalanceCheckResponse`
- **Error**: `ApiException<GetPaymentMethodBalanceError>` — **Case A (typed)**
- **Error accessors**: `TryGetServiceError(out ServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetPaymentMethodBalanceRequest` | `src/AdyenApIs/Requests/Orders/GetPaymentMethodBalanceRequest.cs` |
| `BalanceCheckRequest` | `src/AdyenApIs/Models/BalanceCheckRequest.cs` |
| `BalanceCheckResponse` | `src/AdyenApIs/Models/BalanceCheckResponse.cs` |
| `GetPaymentMethodBalanceError` | `src/AdyenApIs/Errors/GetPaymentMethodBalanceError.cs` |
| `ServiceError` | `src/AdyenApIs/Models/ServiceError.cs` |

