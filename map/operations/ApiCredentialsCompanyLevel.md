<!-- Generated file — do not edit; regenerated with the SDK. -->

# ApiCredentialsCompanyLevel — operations

Accessor: `client.ApiCredentialsCompanyLevel` · Source: `src/AdyenApIs/Api/ApiCredentialsCompanyLevel.cs` · 4 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CreateCompanyApiCredential

- **Server group**: `DefaultManagementApi`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `CreateCompanyApiCredential(CreateCompanyApiCredentialOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `CompanyId`
- **Returns**: `CreateCompanyApiCredentialResponse`
- **Error**: `ApiException<CreateCompanyApiCredentialError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CreateCompanyApiCredentialOperationRequest` | `src/AdyenApIs/Requests/ApiCredentialsCompanyLevel/CreateCompanyApiCredentialOperationRequest.cs` |
| `CreateCompanyApiCredentialRequest` | `src/AdyenApIs/Models/CreateCompanyApiCredentialRequest.cs` |
| `CreateCompanyApiCredentialResponse` | `src/AdyenApIs/Models/CreateCompanyApiCredentialResponse.cs` |
| `CreateCompanyApiCredentialError` | `src/AdyenApIs/Errors/CreateCompanyApiCredentialError.cs` |
| `RestServiceError` | `src/AdyenApIs/Models/RestServiceError.cs` |

### GetCompanyApiCredential

- **Server group**: `DefaultManagementApi`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `GetCompanyApiCredential(GetCompanyApiCredentialRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `CompanyId`, `ApiCredentialId`
- **Returns**: `CompanyApiCredential`
- **Error**: `ApiException<GetCompanyApiCredentialError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetCompanyApiCredentialRequest` | `src/AdyenApIs/Requests/ApiCredentialsCompanyLevel/GetCompanyApiCredentialRequest.cs` |
| `CompanyApiCredential` | `src/AdyenApIs/Models/CompanyApiCredential.cs` |
| `GetCompanyApiCredentialError` | `src/AdyenApIs/Errors/GetCompanyApiCredentialError.cs` |
| `RestServiceError` | `src/AdyenApIs/Models/RestServiceError.cs` |

### ListCompanyApiCredentials

- **Server group**: `DefaultManagementApi`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `ListCompanyApiCredentials(ListCompanyApiCredentialsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `CompanyId`
- **Query params (wire ← C#)**: `pageNumber` ← `PageNumber`, `pageSize` ← `PageSize`
- **Returns**: `ListCompanyApiCredentialsResponse`
- **Error**: `ApiException<ListCompanyApiCredentialsError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ListCompanyApiCredentialsRequest` | `src/AdyenApIs/Requests/ApiCredentialsCompanyLevel/ListCompanyApiCredentialsRequest.cs` |
| `ListCompanyApiCredentialsResponse` | `src/AdyenApIs/Models/ListCompanyApiCredentialsResponse.cs` |
| `ListCompanyApiCredentialsError` | `src/AdyenApIs/Errors/ListCompanyApiCredentialsError.cs` |
| `RestServiceError` | `src/AdyenApIs/Models/RestServiceError.cs` |

### UpdateCompanyApiCredential

- **Server group**: `DefaultManagementApi`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `UpdateCompanyApiCredential(UpdateCompanyApiCredentialOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `CompanyId`, `ApiCredentialId`
- **Returns**: `CompanyApiCredential`
- **Error**: `ApiException<UpdateCompanyApiCredentialError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UpdateCompanyApiCredentialOperationRequest` | `src/AdyenApIs/Requests/ApiCredentialsCompanyLevel/UpdateCompanyApiCredentialOperationRequest.cs` |
| `UpdateCompanyApiCredentialRequest` | `src/AdyenApIs/Models/UpdateCompanyApiCredentialRequest.cs` |
| `CompanyApiCredential` | `src/AdyenApIs/Models/CompanyApiCredential.cs` |
| `UpdateCompanyApiCredentialError` | `src/AdyenApIs/Errors/UpdateCompanyApiCredentialError.cs` |
| `RestServiceError` | `src/AdyenApIs/Models/RestServiceError.cs` |

