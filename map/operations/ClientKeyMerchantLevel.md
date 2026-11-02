<!-- Generated file — do not edit; regenerated with the SDK. -->

# ClientKeyMerchantLevel — operations

Accessor: `client.ClientKeyMerchantLevel` · Source: `src/AdyenApIs/Api/ClientKeyMerchantLevel.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GenerateMerchantClientKey

- **Server group**: `DefaultManagementApi`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `GenerateMerchantClientKey(GenerateMerchantClientKeyRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `MerchantId`, `ApiCredentialId`
- **Returns**: `GenerateClientKeyResponse`
- **Error**: `ApiException<GenerateMerchantClientKeyError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GenerateMerchantClientKeyRequest` | `src/AdyenApIs/Requests/ClientKeyMerchantLevel/GenerateMerchantClientKeyRequest.cs` |
| `GenerateClientKeyResponse` | `src/AdyenApIs/Models/GenerateClientKeyResponse.cs` |
| `GenerateMerchantClientKeyError` | `src/AdyenApIs/Errors/GenerateMerchantClientKeyError.cs` |
| `RestServiceError` | `src/AdyenApIs/Models/RestServiceError.cs` |

