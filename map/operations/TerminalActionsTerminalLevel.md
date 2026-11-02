<!-- Generated file — do not edit; regenerated with the SDK. -->

# TerminalActionsTerminalLevel — operations

Accessor: `client.TerminalActionsTerminalLevel` · Source: `src/AdyenApIs/Api/TerminalActionsTerminalLevel.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### ScheduleTerminalActions

- **Server group**: `DefaultManagementApi`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `ScheduleTerminalActions(ScheduleTerminalActionsOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `ScheduleTerminalActionsResponse`
- **Error**: `ApiException<ScheduleTerminalActionsError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ScheduleTerminalActionsOperationRequest` | `src/AdyenApIs/Requests/TerminalActionsTerminalLevel/ScheduleTerminalActionsOperationRequest.cs` |
| `ScheduleTerminalActionsRequest` | `src/AdyenApIs/Models/ScheduleTerminalActionsRequest.cs` |
| `ScheduleTerminalActionsResponse` | `src/AdyenApIs/Models/ScheduleTerminalActionsResponse.cs` |
| `ScheduleTerminalActionsError` | `src/AdyenApIs/Errors/ScheduleTerminalActionsError.cs` |
| `RestServiceError` | `src/AdyenApIs/Models/RestServiceError.cs` |

