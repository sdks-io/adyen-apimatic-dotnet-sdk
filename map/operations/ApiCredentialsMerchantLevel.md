<!-- Generated file — do not edit; regenerated with the SDK. -->

# ApiCredentialsMerchantLevel — operations

Accessor: `client.ApiCredentialsMerchantLevel` · Source: `src/AdyenApIs/Api/ApiCredentialsMerchantLevel.cs` · 4 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CreateMerchantApiCredential

- **Server group**: `DefaultManagementApi`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `CreateMerchantApiCredential(CreateMerchantApiCredentialOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `MerchantId`
- **Returns**: `CreateApiCredentialResponse`
- **Error**: `ApiException<CreateMerchantApiCredentialError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CreateMerchantApiCredentialOperationRequest` | `src/AdyenApIs/Requests/ApiCredentialsMerchantLevel/CreateMerchantApiCredentialOperationRequest.cs` |
| `CreateMerchantApiCredentialRequest` | `src/AdyenApIs/Models/CreateMerchantApiCredentialRequest.cs` |
| `CreateApiCredentialResponse` | `src/AdyenApIs/Models/CreateApiCredentialResponse.cs` |
| `CreateMerchantApiCredentialError` | `src/AdyenApIs/Errors/CreateMerchantApiCredentialError.cs` |
| `RestServiceError` | `src/AdyenApIs/Models/RestServiceError.cs` |

### GetMerchantApiCredential

- **Server group**: `DefaultManagementApi`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `GetMerchantApiCredential(GetMerchantApiCredentialRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `MerchantId`, `ApiCredentialId`
- **Returns**: `ApiCredential`
- **Error**: `ApiException<GetMerchantApiCredentialError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetMerchantApiCredentialRequest` | `src/AdyenApIs/Requests/ApiCredentialsMerchantLevel/GetMerchantApiCredentialRequest.cs` |
| `ApiCredential` | `src/AdyenApIs/Models/ApiCredential.cs` |
| `GetMerchantApiCredentialError` | `src/AdyenApIs/Errors/GetMerchantApiCredentialError.cs` |
| `RestServiceError` | `src/AdyenApIs/Models/RestServiceError.cs` |

### ListMerchantApiCredentials

- **Server group**: `DefaultManagementApi`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `ListMerchantApiCredentials(ListMerchantApiCredentialsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `MerchantId`
- **Query params (wire ← C#)**: `pageNumber` ← `PageNumber`, `pageSize` ← `PageSize`
- **Returns**: `ListMerchantApiCredentialsResponse`
- **Error**: `ApiException<ListMerchantApiCredentialsError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ListMerchantApiCredentialsRequest` | `src/AdyenApIs/Requests/ApiCredentialsMerchantLevel/ListMerchantApiCredentialsRequest.cs` |
| `ListMerchantApiCredentialsResponse` | `src/AdyenApIs/Models/ListMerchantApiCredentialsResponse.cs` |
| `ListMerchantApiCredentialsError` | `src/AdyenApIs/Errors/ListMerchantApiCredentialsError.cs` |
| `RestServiceError` | `src/AdyenApIs/Models/RestServiceError.cs` |

### UpdateMerchantApiCredential

- **Server group**: `DefaultManagementApi`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `UpdateMerchantApiCredential(UpdateMerchantApiCredentialOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `MerchantId`, `ApiCredentialId`
- **Returns**: `ApiCredential`
- **Error**: `ApiException<UpdateMerchantApiCredentialError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UpdateMerchantApiCredentialOperationRequest` | `src/AdyenApIs/Requests/ApiCredentialsMerchantLevel/UpdateMerchantApiCredentialOperationRequest.cs` |
| `UpdateMerchantApiCredentialRequest` | `src/AdyenApIs/Models/UpdateMerchantApiCredentialRequest.cs` |
| `ApiCredential` | `src/AdyenApIs/Models/ApiCredential.cs` |
| `UpdateMerchantApiCredentialError` | `src/AdyenApIs/Errors/UpdateMerchantApiCredentialError.cs` |
| `RestServiceError` | `src/AdyenApIs/Models/RestServiceError.cs` |

