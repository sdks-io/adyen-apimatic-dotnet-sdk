<!-- Generated file — do not edit; regenerated with the SDK. -->

# TerminalActionsCompanyLevel — operations

Accessor: `client.TerminalActionsCompanyLevel` · Source: `src/AdyenApIs/Api/TerminalActionsCompanyLevel.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetCompanyTerminalAction

- **Server group**: `DefaultManagementApi`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `GetCompanyTerminalAction(GetCompanyTerminalActionRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `CompanyId`, `ActionId`
- **Returns**: `ExternalTerminalAction`
- **Error**: `ApiException<GetCompanyTerminalActionError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetCompanyTerminalActionRequest` | `src/AdyenApIs/Requests/TerminalActionsCompanyLevel/GetCompanyTerminalActionRequest.cs` |
| `ExternalTerminalAction` | `src/AdyenApIs/Models/ExternalTerminalAction.cs` |
| `GetCompanyTerminalActionError` | `src/AdyenApIs/Errors/GetCompanyTerminalActionError.cs` |
| `RestServiceError` | `src/AdyenApIs/Models/RestServiceError.cs` |

### ListCompanyTerminalActions

- **Server group**: `DefaultManagementApi`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `ListCompanyTerminalActions(ListCompanyTerminalActionsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `CompanyId`
- **Query params (wire ← C#)**: `pageNumber` ← `PageNumber`, `pageSize` ← `PageSize`, `status` ← `Status`, `type` ← `Type`
- **Returns**: `ListExternalTerminalActionsResponse`
- **Error**: `ApiException<ListCompanyTerminalActionsError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ListCompanyTerminalActionsRequest` | `src/AdyenApIs/Requests/TerminalActionsCompanyLevel/ListCompanyTerminalActionsRequest.cs` |
| `ListExternalTerminalActionsResponse` | `src/AdyenApIs/Models/ListExternalTerminalActionsResponse.cs` |
| `ListCompanyTerminalActionsError` | `src/AdyenApIs/Errors/ListCompanyTerminalActionsError.cs` |
| `RestServiceError` | `src/AdyenApIs/Models/RestServiceError.cs` |

