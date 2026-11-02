<!-- Generated file — do not edit; regenerated with the SDK. -->

# ApiKeyMerchantLevel — operations

Accessor: `client.ApiKeyMerchantLevel` · Source: `src/AdyenApIs/Api/ApiKeyMerchantLevel.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GenerateMerchantApiKey

- **Server group**: `DefaultManagementApi`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `GenerateMerchantApiKey(GenerateMerchantApiKeyRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `MerchantId`, `ApiCredentialId`
- **Returns**: `GenerateApiKeyResponse`
- **Error**: `ApiException<GenerateMerchantApiKeyError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GenerateMerchantApiKeyRequest` | `src/AdyenApIs/Requests/ApiKeyMerchantLevel/GenerateMerchantApiKeyRequest.cs` |
| `GenerateApiKeyResponse` | `src/AdyenApIs/Models/GenerateApiKeyResponse.cs` |
| `GenerateMerchantApiKeyError` | `src/AdyenApIs/Errors/GenerateMerchantApiKeyError.cs` |
| `RestServiceError` | `src/AdyenApIs/Models/RestServiceError.cs` |

