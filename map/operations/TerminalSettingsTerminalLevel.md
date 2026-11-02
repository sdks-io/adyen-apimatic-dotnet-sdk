<!-- Generated file — do not edit; regenerated with the SDK. -->

# TerminalSettingsTerminalLevel — operations

Accessor: `client.TerminalSettingsTerminalLevel` · Source: `src/AdyenApIs/Api/TerminalSettingsTerminalLevel.cs` · 4 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetTerminalLogo

- **Server group**: `DefaultManagementApi`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `GetTerminalLogo(GetTerminalLogoRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `TerminalId`
- **Returns**: `Logo`
- **Error**: `ApiException<GetTerminalLogoError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetTerminalLogoRequest` | `src/AdyenApIs/Requests/TerminalSettingsTerminalLevel/GetTerminalLogoRequest.cs` |
| `Logo` | `src/AdyenApIs/Models/Logo.cs` |
| `GetTerminalLogoError` | `src/AdyenApIs/Errors/GetTerminalLogoError.cs` |
| `RestServiceError` | `src/AdyenApIs/Models/RestServiceError.cs` |

### GetTerminalSettings

- **Server group**: `DefaultManagementApi`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `GetTerminalSettings(GetTerminalSettingsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `TerminalId`
- **Returns**: `TerminalSettings`
- **Error**: `ApiException<GetTerminalSettingsError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetTerminalSettingsRequest` | `src/AdyenApIs/Requests/TerminalSettingsTerminalLevel/GetTerminalSettingsRequest.cs` |
| `TerminalSettings` | `src/AdyenApIs/Models/TerminalSettings.cs` |
| `GetTerminalSettingsError` | `src/AdyenApIs/Errors/GetTerminalSettingsError.cs` |
| `RestServiceError` | `src/AdyenApIs/Models/RestServiceError.cs` |

### UpdateTerminalLogo

- **Server group**: `DefaultManagementApi`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `UpdateTerminalLogo(UpdateTerminalLogoRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `TerminalId`
- **Returns**: `Logo`
- **Error**: `ApiException<UpdateTerminalLogoError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UpdateTerminalLogoRequest` | `src/AdyenApIs/Requests/TerminalSettingsTerminalLevel/UpdateTerminalLogoRequest.cs` |
| `Logo` | `src/AdyenApIs/Models/Logo.cs` |
| `UpdateTerminalLogoError` | `src/AdyenApIs/Errors/UpdateTerminalLogoError.cs` |
| `RestServiceError` | `src/AdyenApIs/Models/RestServiceError.cs` |

### UpdateTerminalSettings

- **Server group**: `DefaultManagementApi`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `UpdateTerminalSettings(UpdateTerminalSettingsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `TerminalId`
- **Returns**: `TerminalSettings`
- **Error**: `ApiException<UpdateTerminalSettingsError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UpdateTerminalSettingsRequest` | `src/AdyenApIs/Requests/TerminalSettingsTerminalLevel/UpdateTerminalSettingsRequest.cs` |
| `TerminalSettings` | `src/AdyenApIs/Models/TerminalSettings.cs` |
| `UpdateTerminalSettingsError` | `src/AdyenApIs/Errors/UpdateTerminalSettingsError.cs` |
| `RestServiceError` | `src/AdyenApIs/Models/RestServiceError.cs` |

