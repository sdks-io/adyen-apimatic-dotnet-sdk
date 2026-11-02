<!-- Generated file — do not edit; regenerated with the SDK. -->

# TerminalsTerminalLevel — operations

Accessor: `client.TerminalsTerminalLevel` · Source: `src/AdyenApIs/Api/TerminalsTerminalLevel.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### ListTerminals

- **Server group**: `DefaultManagementApi`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `ListTerminals(ListTerminalsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `searchQuery` ← `SearchQuery`, `otpQuery` ← `OtpQuery`, `countries` ← `Countries`, `merchantIds` ← `MerchantIds`, `storeIds` ← `StoreIds`, `brandModels` ← `BrandModels`, `pageNumber` ← `PageNumber`, `pageSize` ← `PageSize`
- **Returns**: `ListTerminalsResponse`
- **Error**: `ApiException<ListTerminalsError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ListTerminalsRequest` | `src/AdyenApIs/Requests/TerminalsTerminalLevel/ListTerminalsRequest.cs` |
| `ListTerminalsResponse` | `src/AdyenApIs/Models/ListTerminalsResponse.cs` |
| `ListTerminalsError` | `src/AdyenApIs/Errors/ListTerminalsError.cs` |
| `RestServiceError` | `src/AdyenApIs/Models/RestServiceError.cs` |

### ReassignTerminal

- **Server group**: `DefaultManagementApi`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `ReassignTerminal(ReassignTerminalRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `TerminalId`
- **Returns**: `void` (Task)
- **Error**: `ApiException<ReassignTerminalError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ReassignTerminalRequest` | `src/AdyenApIs/Requests/TerminalsTerminalLevel/ReassignTerminalRequest.cs` |
| `TerminalReassignmentRequest` | `src/AdyenApIs/Models/TerminalReassignmentRequest.cs` |
| `ReassignTerminalError` | `src/AdyenApIs/Errors/ReassignTerminalError.cs` |
| `RestServiceError` | `src/AdyenApIs/Models/RestServiceError.cs` |

