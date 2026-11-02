<!-- Generated file — do not edit; regenerated with the SDK. -->

# AccountStoreLevel — operations

Accessor: `client.AccountStoreLevel` · Source: `src/AdyenApIs/Api/AccountStoreLevel.cs` · 8 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CreateMerchantStore

- **Server group**: `DefaultManagementApi`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `CreateMerchantStore(CreateMerchantStoreRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `MerchantId`
- **Returns**: `Store`
- **Error**: `ApiException<CreateMerchantStoreError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CreateMerchantStoreRequest` | `src/AdyenApIs/Requests/AccountStoreLevel/CreateMerchantStoreRequest.cs` |
| `StoreCreationRequest` | `src/AdyenApIs/Models/StoreCreationRequest.cs` |
| `Store` | `src/AdyenApIs/Models/Store.cs` |
| `CreateMerchantStoreError` | `src/AdyenApIs/Errors/CreateMerchantStoreError.cs` |
| `RestServiceError` | `src/AdyenApIs/Models/RestServiceError.cs` |

### CreateStore

- **Server group**: `DefaultManagementApi`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `CreateStore(CreateStoreRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `Store`
- **Error**: `ApiException<CreateStoreError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CreateStoreRequest` | `src/AdyenApIs/Requests/AccountStoreLevel/CreateStoreRequest.cs` |
| `StoreCreationWithMerchantCodeRequest` | `src/AdyenApIs/Models/StoreCreationWithMerchantCodeRequest.cs` |
| `Store` | `src/AdyenApIs/Models/Store.cs` |
| `CreateStoreError` | `src/AdyenApIs/Errors/CreateStoreError.cs` |
| `RestServiceError` | `src/AdyenApIs/Models/RestServiceError.cs` |

### GetMerchantStore

- **Server group**: `DefaultManagementApi`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `GetMerchantStore(GetMerchantStoreRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `MerchantId`, `StoreId`
- **Returns**: `Store`
- **Error**: `ApiException<GetMerchantStoreError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetMerchantStoreRequest` | `src/AdyenApIs/Requests/AccountStoreLevel/GetMerchantStoreRequest.cs` |
| `Store` | `src/AdyenApIs/Models/Store.cs` |
| `GetMerchantStoreError` | `src/AdyenApIs/Errors/GetMerchantStoreError.cs` |
| `RestServiceError` | `src/AdyenApIs/Models/RestServiceError.cs` |

### GetStore

- **Server group**: `DefaultManagementApi`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `GetStore(GetStoreRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `StoreId`
- **Returns**: `Store`
- **Error**: `ApiException<GetStoreError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetStoreRequest` | `src/AdyenApIs/Requests/AccountStoreLevel/GetStoreRequest.cs` |
| `Store` | `src/AdyenApIs/Models/Store.cs` |
| `GetStoreError` | `src/AdyenApIs/Errors/GetStoreError.cs` |
| `RestServiceError` | `src/AdyenApIs/Models/RestServiceError.cs` |

### ListMerchantStores

- **Server group**: `DefaultManagementApi`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `ListMerchantStores(ListMerchantStoresRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `MerchantId`
- **Query params (wire ← C#)**: `pageNumber` ← `PageNumber`, `pageSize` ← `PageSize`, `reference` ← `Reference`
- **Returns**: `ListStoresResponse`
- **Error**: `ApiException<ListMerchantStoresError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ListMerchantStoresRequest` | `src/AdyenApIs/Requests/AccountStoreLevel/ListMerchantStoresRequest.cs` |
| `ListStoresResponse` | `src/AdyenApIs/Models/ListStoresResponse.cs` |
| `ListMerchantStoresError` | `src/AdyenApIs/Errors/ListMerchantStoresError.cs` |
| `RestServiceError` | `src/AdyenApIs/Models/RestServiceError.cs` |

### ListStores

- **Server group**: `DefaultManagementApi`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `ListStores(ListStoresRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `pageNumber` ← `PageNumber`, `pageSize` ← `PageSize`, `reference` ← `Reference`, `merchantId` ← `MerchantId`
- **Returns**: `ListStoresResponse`
- **Error**: `ApiException<ListStoresError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ListStoresRequest` | `src/AdyenApIs/Requests/AccountStoreLevel/ListStoresRequest.cs` |
| `ListStoresResponse` | `src/AdyenApIs/Models/ListStoresResponse.cs` |
| `ListStoresError` | `src/AdyenApIs/Errors/ListStoresError.cs` |
| `RestServiceError` | `src/AdyenApIs/Models/RestServiceError.cs` |

### UpdateMerchantStore

- **Server group**: `DefaultManagementApi`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `UpdateMerchantStore(UpdateMerchantStoreRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `MerchantId`, `StoreId`
- **Returns**: `Store`
- **Error**: `ApiException<UpdateMerchantStoreError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UpdateMerchantStoreRequest` | `src/AdyenApIs/Requests/AccountStoreLevel/UpdateMerchantStoreRequest.cs` |
| `UpdateStoreRequest` | `src/AdyenApIs/Models/UpdateStoreRequest.cs` |
| `Store` | `src/AdyenApIs/Models/Store.cs` |
| `UpdateMerchantStoreError` | `src/AdyenApIs/Errors/UpdateMerchantStoreError.cs` |
| `RestServiceError` | `src/AdyenApIs/Models/RestServiceError.cs` |

### UpdateStore

- **Server group**: `DefaultManagementApi`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `UpdateStore(UpdateStoreOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `StoreId`
- **Returns**: `Store`
- **Error**: `ApiException<UpdateStoreError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UpdateStoreOperationRequest` | `src/AdyenApIs/Requests/AccountStoreLevel/UpdateStoreOperationRequest.cs` |
| `UpdateStoreRequest` | `src/AdyenApIs/Models/UpdateStoreRequest.cs` |
| `Store` | `src/AdyenApIs/Models/Store.cs` |
| `UpdateStoreError` | `src/AdyenApIs/Errors/UpdateStoreError.cs` |
| `RestServiceError` | `src/AdyenApIs/Models/RestServiceError.cs` |

