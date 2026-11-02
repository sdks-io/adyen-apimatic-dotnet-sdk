<!-- Generated file — do not edit; regenerated with the SDK. -->

# ApiKeyCompanyLevel — operations

Accessor: `client.ApiKeyCompanyLevel` · Source: `src/AdyenApIs/Api/ApiKeyCompanyLevel.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GenerateCompanyApiKey

- **Server group**: `DefaultManagementApi`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `GenerateCompanyApiKey(GenerateCompanyApiKeyRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `CompanyId`, `ApiCredentialId`
- **Returns**: `GenerateApiKeyResponse`
- **Error**: `ApiException<GenerateCompanyApiKeyError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GenerateCompanyApiKeyRequest` | `src/AdyenApIs/Requests/ApiKeyCompanyLevel/GenerateCompanyApiKeyRequest.cs` |
| `GenerateApiKeyResponse` | `src/AdyenApIs/Models/GenerateApiKeyResponse.cs` |
| `GenerateCompanyApiKeyError` | `src/AdyenApIs/Errors/GenerateCompanyApiKeyError.cs` |
| `RestServiceError` | `src/AdyenApIs/Models/RestServiceError.cs` |

