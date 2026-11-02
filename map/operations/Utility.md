<!-- Generated file — do not edit; regenerated with the SDK. -->

# Utility — operations

Accessor: `client.Utility` · Source: `src/AdyenApIs/Api/Utility.cs` · 4 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GenerateOriginKeys

- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `GenerateOriginKeys(GenerateOriginKeysRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `UtilityResponse`
- **Error**: `ApiException<GenerateOriginKeysError>` — **Case A (typed)**
- **Error accessors**: `TryGetServiceError(out ServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GenerateOriginKeysRequest` | `src/AdyenApIs/Requests/Utility/GenerateOriginKeysRequest.cs` |
| `UtilityRequest` | `src/AdyenApIs/Models/UtilityRequest.cs` |
| `UtilityResponse` | `src/AdyenApIs/Models/UtilityResponse.cs` |
| `GenerateOriginKeysError` | `src/AdyenApIs/Errors/GenerateOriginKeysError.cs` |
| `ServiceError` | `src/AdyenApIs/Models/ServiceError.cs` |

### GetApplePaySession

- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `GetApplePaySession(GetApplePaySessionRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `ApplePaySessionResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `GetApplePaySessionRequest` | `src/AdyenApIs/Requests/Utility/GetApplePaySessionRequest.cs` |
| `ApplePaySessionRequest` | `src/AdyenApIs/Models/ApplePaySessionRequest.cs` |
| `ApplePaySessionResponse` | `src/AdyenApIs/Models/ApplePaySessionResponse.cs` |

### UpdatePayPalOrder

- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `UpdatePayPalOrder(UpdatePayPalOrderRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `PaypalUpdateOrderResponse`
- **Error**: `ApiException<UpdatePayPalOrderError>` — **Case A (typed)**
- **Error accessors**: `TryGetServiceError(out ServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UpdatePayPalOrderRequest` | `src/AdyenApIs/Requests/Utility/UpdatePayPalOrderRequest.cs` |
| `PaypalUpdateOrderRequest` | `src/AdyenApIs/Models/PaypalUpdateOrderRequest.cs` |
| `PaypalUpdateOrderResponse` | `src/AdyenApIs/Models/PaypalUpdateOrderResponse.cs` |
| `UpdatePayPalOrderError` | `src/AdyenApIs/Errors/UpdatePayPalOrderError.cs` |
| `ServiceError` | `src/AdyenApIs/Models/ServiceError.cs` |

### ValidateShopperId

- **Signature**: `ValidateShopperId(ValidateShopperIdOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `ValidateShopperIdResponse`
- **Error**: `ApiException<ValidateShopperIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetDefaultErrorResponseEntity(out DefaultErrorResponseEntity)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ValidateShopperIdOperationRequest` | `src/AdyenApIs/Requests/Utility/ValidateShopperIdOperationRequest.cs` |
| `ValidateShopperIdRequest` | `src/AdyenApIs/Models/ValidateShopperIdRequest.cs` |
| `ValidateShopperIdResponse` | `src/AdyenApIs/Models/ValidateShopperIdResponse.cs` |
| `ValidateShopperIdError` | `src/AdyenApIs/Errors/ValidateShopperIdError.cs` |
| `DefaultErrorResponseEntity` | `src/AdyenApIs/Models/DefaultErrorResponseEntity.cs` |

