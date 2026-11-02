<!-- Generated file — do not edit; regenerated with the SDK. -->

# AccountMerchantLevel — operations

Accessor: `client.AccountMerchantLevel` · Source: `src/AdyenApIs/Api/AccountMerchantLevel.cs` · 4 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### ActivateMerchant

- **Server group**: `DefaultManagementApi`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `ActivateMerchant(ActivateMerchantRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `MerchantId`
- **Returns**: `RequestActivationResponse`
- **Error**: `ApiException<ActivateMerchantError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ActivateMerchantRequest` | `src/AdyenApIs/Requests/AccountMerchantLevel/ActivateMerchantRequest.cs` |
| `RequestActivationResponse` | `src/AdyenApIs/Models/RequestActivationResponse.cs` |
| `ActivateMerchantError` | `src/AdyenApIs/Errors/ActivateMerchantError.cs` |
| `RestServiceError` | `src/AdyenApIs/Models/RestServiceError.cs` |

### CreateMerchant

- **Server group**: `DefaultManagementApi`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `CreateMerchant(CreateMerchantOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `CreateMerchantResponse`
- **Error**: `ApiException<CreateMerchantError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CreateMerchantOperationRequest` | `src/AdyenApIs/Requests/AccountMerchantLevel/CreateMerchantOperationRequest.cs` |
| `CreateMerchantRequest` | `src/AdyenApIs/Models/CreateMerchantRequest.cs` |
| `CreateMerchantResponse` | `src/AdyenApIs/Models/CreateMerchantResponse.cs` |
| `CreateMerchantError` | `src/AdyenApIs/Errors/CreateMerchantError.cs` |
| `RestServiceError` | `src/AdyenApIs/Models/RestServiceError.cs` |

### GetMerchant

- **Server group**: `DefaultManagementApi`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `GetMerchant(GetMerchantRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `MerchantId`
- **Returns**: `Merchant`
- **Error**: `ApiException<GetMerchantError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetMerchantRequest` | `src/AdyenApIs/Requests/AccountMerchantLevel/GetMerchantRequest.cs` |
| `Merchant` | `src/AdyenApIs/Models/Merchant.cs` |
| `GetMerchantError` | `src/AdyenApIs/Errors/GetMerchantError.cs` |
| `RestServiceError` | `src/AdyenApIs/Models/RestServiceError.cs` |

### ListMerchants

- **Server group**: `DefaultManagementApi`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `ListMerchants(ListMerchantsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `pageNumber` ← `PageNumber`, `pageSize` ← `PageSize`
- **Returns**: `ListMerchantResponse`
- **Error**: `ApiException<ListMerchantsError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ListMerchantsRequest` | `src/AdyenApIs/Requests/AccountMerchantLevel/ListMerchantsRequest.cs` |
| `ListMerchantResponse` | `src/AdyenApIs/Models/ListMerchantResponse.cs` |
| `ListMerchantsError` | `src/AdyenApIs/Errors/ListMerchantsError.cs` |
| `RestServiceError` | `src/AdyenApIs/Models/RestServiceError.cs` |

