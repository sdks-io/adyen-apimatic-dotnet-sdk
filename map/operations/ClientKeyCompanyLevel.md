<!-- Generated file — do not edit; regenerated with the SDK. -->

# ClientKeyCompanyLevel — operations

Accessor: `client.ClientKeyCompanyLevel` · Source: `src/AdyenApIs/Api/ClientKeyCompanyLevel.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GenerateCompanyClientKey

- **Server group**: `DefaultManagementApi`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `GenerateCompanyClientKey(GenerateCompanyClientKeyRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `CompanyId`, `ApiCredentialId`
- **Returns**: `GenerateClientKeyResponse`
- **Error**: `ApiException<GenerateCompanyClientKeyError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GenerateCompanyClientKeyRequest` | `src/AdyenApIs/Requests/ClientKeyCompanyLevel/GenerateCompanyClientKeyRequest.cs` |
| `GenerateClientKeyResponse` | `src/AdyenApIs/Models/GenerateClientKeyResponse.cs` |
| `GenerateCompanyClientKeyError` | `src/AdyenApIs/Errors/GenerateCompanyClientKeyError.cs` |
| `RestServiceError` | `src/AdyenApIs/Models/RestServiceError.cs` |

