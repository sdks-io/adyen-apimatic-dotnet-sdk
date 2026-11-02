<!-- Generated file — do not edit; regenerated with the SDK. -->

# AllowedOriginsCompanyLevel — operations

Accessor: `client.AllowedOriginsCompanyLevel` · Source: `src/AdyenApIs/Api/AllowedOriginsCompanyLevel.cs` · 4 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CreateCompanyApiCredentialOrigin

- **Server group**: `DefaultManagementApi`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `CreateCompanyApiCredentialOrigin(CreateCompanyApiCredentialOriginRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `CompanyId`, `ApiCredentialId`
- **Returns**: `AllowedOrigin`
- **Error**: `ApiException<CreateCompanyApiCredentialOriginError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CreateCompanyApiCredentialOriginRequest` | `src/AdyenApIs/Requests/AllowedOriginsCompanyLevel/CreateCompanyApiCredentialOriginRequest.cs` |
| `AllowedOrigin` | `src/AdyenApIs/Models/AllowedOrigin.cs` |
| `CreateCompanyApiCredentialOriginError` | `src/AdyenApIs/Errors/CreateCompanyApiCredentialOriginError.cs` |
| `RestServiceError` | `src/AdyenApIs/Models/RestServiceError.cs` |

### DeleteCompanyApiCredentialOrigin

- **Server group**: `DefaultManagementApi`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `DeleteCompanyApiCredentialOrigin(DeleteCompanyApiCredentialOriginRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `CompanyId`, `ApiCredentialId`, `OriginId`
- **Returns**: `void` (Task)
- **Error**: `ApiException<DeleteCompanyApiCredentialOriginError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeleteCompanyApiCredentialOriginRequest` | `src/AdyenApIs/Requests/AllowedOriginsCompanyLevel/DeleteCompanyApiCredentialOriginRequest.cs` |
| `DeleteCompanyApiCredentialOriginError` | `src/AdyenApIs/Errors/DeleteCompanyApiCredentialOriginError.cs` |
| `RestServiceError` | `src/AdyenApIs/Models/RestServiceError.cs` |

### GetCompanyApiCredentialOrigin

- **Server group**: `DefaultManagementApi`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `GetCompanyApiCredentialOrigin(GetCompanyApiCredentialOriginRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `CompanyId`, `ApiCredentialId`, `OriginId`
- **Returns**: `AllowedOrigin`
- **Error**: `ApiException<GetCompanyApiCredentialOriginError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetCompanyApiCredentialOriginRequest` | `src/AdyenApIs/Requests/AllowedOriginsCompanyLevel/GetCompanyApiCredentialOriginRequest.cs` |
| `AllowedOrigin` | `src/AdyenApIs/Models/AllowedOrigin.cs` |
| `GetCompanyApiCredentialOriginError` | `src/AdyenApIs/Errors/GetCompanyApiCredentialOriginError.cs` |
| `RestServiceError` | `src/AdyenApIs/Models/RestServiceError.cs` |

### ListCompanyApiCredentialOrigins

- **Server group**: `DefaultManagementApi`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `ListCompanyApiCredentialOrigins(ListCompanyApiCredentialOriginsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `CompanyId`, `ApiCredentialId`
- **Returns**: `AllowedOriginsResponse`
- **Error**: `ApiException<ListCompanyApiCredentialOriginsError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ListCompanyApiCredentialOriginsRequest` | `src/AdyenApIs/Requests/AllowedOriginsCompanyLevel/ListCompanyApiCredentialOriginsRequest.cs` |
| `AllowedOriginsResponse` | `src/AdyenApIs/Models/AllowedOriginsResponse.cs` |
| `ListCompanyApiCredentialOriginsError` | `src/AdyenApIs/Errors/ListCompanyApiCredentialOriginsError.cs` |
| `RestServiceError` | `src/AdyenApIs/Models/RestServiceError.cs` |

