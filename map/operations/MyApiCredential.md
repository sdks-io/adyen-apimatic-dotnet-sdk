<!-- Generated file — do not edit; regenerated with the SDK. -->

# MyApiCredential — operations

Accessor: `client.MyApiCredential` · Source: `src/AdyenApIs/Api/MyApiCredential.cs` · 6 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CreateMyAllowedOrigin

- **Server group**: `DefaultManagementApi`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `CreateMyAllowedOrigin(CreateMyAllowedOriginRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `AllowedOrigin`
- **Error**: `ApiException<CreateMyAllowedOriginError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CreateMyAllowedOriginRequest` | `src/AdyenApIs/Requests/MyApiCredential/CreateMyAllowedOriginRequest.cs` |
| `CreateAllowedOriginRequest` | `src/AdyenApIs/Models/CreateAllowedOriginRequest.cs` |
| `AllowedOrigin` | `src/AdyenApIs/Models/AllowedOrigin.cs` |
| `CreateMyAllowedOriginError` | `src/AdyenApIs/Errors/CreateMyAllowedOriginError.cs` |
| `RestServiceError` | `src/AdyenApIs/Models/RestServiceError.cs` |

### DeleteMyAllowedOrigin

- **Server group**: `DefaultManagementApi`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `DeleteMyAllowedOrigin(DeleteMyAllowedOriginRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `OriginId`
- **Returns**: `void` (Task)
- **Error**: `ApiException<DeleteMyAllowedOriginError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeleteMyAllowedOriginRequest` | `src/AdyenApIs/Requests/MyApiCredential/DeleteMyAllowedOriginRequest.cs` |
| `DeleteMyAllowedOriginError` | `src/AdyenApIs/Errors/DeleteMyAllowedOriginError.cs` |
| `RestServiceError` | `src/AdyenApIs/Models/RestServiceError.cs` |

### GenerateMyClientKey

- **Server group**: `DefaultManagementApi`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `GenerateMyClientKey(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `GenerateClientKeyResponse`
- **Error**: `ApiException<GenerateMyClientKeyError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GenerateClientKeyResponse` | `src/AdyenApIs/Models/GenerateClientKeyResponse.cs` |
| `GenerateMyClientKeyError` | `src/AdyenApIs/Errors/GenerateMyClientKeyError.cs` |
| `RestServiceError` | `src/AdyenApIs/Models/RestServiceError.cs` |

### GetMyAllowedOrigin

- **Server group**: `DefaultManagementApi`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `GetMyAllowedOrigin(GetMyAllowedOriginRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `OriginId`
- **Returns**: `AllowedOrigin`
- **Error**: `ApiException<GetMyAllowedOriginError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetMyAllowedOriginRequest` | `src/AdyenApIs/Requests/MyApiCredential/GetMyAllowedOriginRequest.cs` |
| `AllowedOrigin` | `src/AdyenApIs/Models/AllowedOrigin.cs` |
| `GetMyAllowedOriginError` | `src/AdyenApIs/Errors/GetMyAllowedOriginError.cs` |
| `RestServiceError` | `src/AdyenApIs/Models/RestServiceError.cs` |

### GetMyApiCredential

- **Server group**: `DefaultManagementApi`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `GetMyApiCredential(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `MeApiCredential`
- **Error**: `ApiException<GetMyApiCredentialError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `MeApiCredential` | `src/AdyenApIs/Models/MeApiCredential.cs` |
| `GetMyApiCredentialError` | `src/AdyenApIs/Errors/GetMyApiCredentialError.cs` |
| `RestServiceError` | `src/AdyenApIs/Models/RestServiceError.cs` |

### ListMyAllowedOrigins

- **Server group**: `DefaultManagementApi`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `ListMyAllowedOrigins(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `AllowedOriginsResponse`
- **Error**: `ApiException<ListMyAllowedOriginsError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `AllowedOriginsResponse` | `src/AdyenApIs/Models/AllowedOriginsResponse.cs` |
| `ListMyAllowedOriginsError` | `src/AdyenApIs/Errors/ListMyAllowedOriginsError.cs` |
| `RestServiceError` | `src/AdyenApIs/Models/RestServiceError.cs` |

