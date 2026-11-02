<!-- Generated file — do not edit; regenerated with the SDK. -->

# AllowedOriginsMerchantLevel — operations

Accessor: `client.AllowedOriginsMerchantLevel` · Source: `src/AdyenApIs/Api/AllowedOriginsMerchantLevel.cs` · 4 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CreateMerchantApiCredentialOrigin

- **Server group**: `DefaultManagementApi`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `CreateMerchantApiCredentialOrigin(CreateMerchantApiCredentialOriginRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `MerchantId`, `ApiCredentialId`
- **Returns**: `AllowedOrigin`
- **Error**: `ApiException<CreateMerchantApiCredentialOriginError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CreateMerchantApiCredentialOriginRequest` | `src/AdyenApIs/Requests/AllowedOriginsMerchantLevel/CreateMerchantApiCredentialOriginRequest.cs` |
| `AllowedOrigin` | `src/AdyenApIs/Models/AllowedOrigin.cs` |
| `CreateMerchantApiCredentialOriginError` | `src/AdyenApIs/Errors/CreateMerchantApiCredentialOriginError.cs` |
| `RestServiceError` | `src/AdyenApIs/Models/RestServiceError.cs` |

### DeleteMerchantApiCredentialOrigin

- **Server group**: `DefaultManagementApi`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `DeleteMerchantApiCredentialOrigin(DeleteMerchantApiCredentialOriginRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `MerchantId`, `ApiCredentialId`, `OriginId`
- **Returns**: `void` (Task)
- **Error**: `ApiException<DeleteMerchantApiCredentialOriginError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeleteMerchantApiCredentialOriginRequest` | `src/AdyenApIs/Requests/AllowedOriginsMerchantLevel/DeleteMerchantApiCredentialOriginRequest.cs` |
| `DeleteMerchantApiCredentialOriginError` | `src/AdyenApIs/Errors/DeleteMerchantApiCredentialOriginError.cs` |
| `RestServiceError` | `src/AdyenApIs/Models/RestServiceError.cs` |

### GetMerchantApiCredentialOrigin

- **Server group**: `DefaultManagementApi`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `GetMerchantApiCredentialOrigin(GetMerchantApiCredentialOriginRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `MerchantId`, `ApiCredentialId`, `OriginId`
- **Returns**: `AllowedOrigin`
- **Error**: `ApiException<GetMerchantApiCredentialOriginError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetMerchantApiCredentialOriginRequest` | `src/AdyenApIs/Requests/AllowedOriginsMerchantLevel/GetMerchantApiCredentialOriginRequest.cs` |
| `AllowedOrigin` | `src/AdyenApIs/Models/AllowedOrigin.cs` |
| `GetMerchantApiCredentialOriginError` | `src/AdyenApIs/Errors/GetMerchantApiCredentialOriginError.cs` |
| `RestServiceError` | `src/AdyenApIs/Models/RestServiceError.cs` |

### ListMerchantApiCredentialOrigins

- **Server group**: `DefaultManagementApi`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `ListMerchantApiCredentialOrigins(ListMerchantApiCredentialOriginsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `MerchantId`, `ApiCredentialId`
- **Returns**: `AllowedOriginsResponse`
- **Error**: `ApiException<ListMerchantApiCredentialOriginsError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ListMerchantApiCredentialOriginsRequest` | `src/AdyenApIs/Requests/AllowedOriginsMerchantLevel/ListMerchantApiCredentialOriginsRequest.cs` |
| `AllowedOriginsResponse` | `src/AdyenApIs/Models/AllowedOriginsResponse.cs` |
| `ListMerchantApiCredentialOriginsError` | `src/AdyenApIs/Errors/ListMerchantApiCredentialOriginsError.cs` |
| `RestServiceError` | `src/AdyenApIs/Models/RestServiceError.cs` |

