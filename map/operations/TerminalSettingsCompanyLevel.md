<!-- Generated file — do not edit; regenerated with the SDK. -->

# TerminalSettingsCompanyLevel — operations

Accessor: `client.TerminalSettingsCompanyLevel` · Source: `src/AdyenApIs/Api/TerminalSettingsCompanyLevel.cs` · 4 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetCompanyTerminalLogo

- **Server group**: `DefaultManagementApi`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `GetCompanyTerminalLogo(GetCompanyTerminalLogoRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `CompanyId`, `Model`
- **Query params (wire ← C#)**: `model` ← `Model`
- **Returns**: `Logo`
- **Error**: `ApiException<GetCompanyTerminalLogoError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetCompanyTerminalLogoRequest` | `src/AdyenApIs/Requests/TerminalSettingsCompanyLevel/GetCompanyTerminalLogoRequest.cs` |
| `Logo` | `src/AdyenApIs/Models/Logo.cs` |
| `GetCompanyTerminalLogoError` | `src/AdyenApIs/Errors/GetCompanyTerminalLogoError.cs` |
| `RestServiceError` | `src/AdyenApIs/Models/RestServiceError.cs` |

### GetCompanyTerminalSettings

- **Server group**: `DefaultManagementApi`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `GetCompanyTerminalSettings(GetCompanyTerminalSettingsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `CompanyId`
- **Returns**: `TerminalSettings`
- **Error**: `ApiException<GetCompanyTerminalSettingsError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetCompanyTerminalSettingsRequest` | `src/AdyenApIs/Requests/TerminalSettingsCompanyLevel/GetCompanyTerminalSettingsRequest.cs` |
| `TerminalSettings` | `src/AdyenApIs/Models/TerminalSettings.cs` |
| `GetCompanyTerminalSettingsError` | `src/AdyenApIs/Errors/GetCompanyTerminalSettingsError.cs` |
| `RestServiceError` | `src/AdyenApIs/Models/RestServiceError.cs` |

### UpdateCompanyTerminalLogo

- **Server group**: `DefaultManagementApi`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `UpdateCompanyTerminalLogo(UpdateCompanyTerminalLogoRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `CompanyId`, `Model`
- **Query params (wire ← C#)**: `model` ← `Model`
- **Returns**: `Logo`
- **Error**: `ApiException<UpdateCompanyTerminalLogoError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UpdateCompanyTerminalLogoRequest` | `src/AdyenApIs/Requests/TerminalSettingsCompanyLevel/UpdateCompanyTerminalLogoRequest.cs` |
| `Logo` | `src/AdyenApIs/Models/Logo.cs` |
| `UpdateCompanyTerminalLogoError` | `src/AdyenApIs/Errors/UpdateCompanyTerminalLogoError.cs` |
| `RestServiceError` | `src/AdyenApIs/Models/RestServiceError.cs` |

### UpdateCompanyTerminalSettings

- **Server group**: `DefaultManagementApi`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `UpdateCompanyTerminalSettings(UpdateCompanyTerminalSettingsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `CompanyId`
- **Returns**: `TerminalSettings`
- **Error**: `ApiException<UpdateCompanyTerminalSettingsError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UpdateCompanyTerminalSettingsRequest` | `src/AdyenApIs/Requests/TerminalSettingsCompanyLevel/UpdateCompanyTerminalSettingsRequest.cs` |
| `TerminalSettings` | `src/AdyenApIs/Models/TerminalSettings.cs` |
| `UpdateCompanyTerminalSettingsError` | `src/AdyenApIs/Errors/UpdateCompanyTerminalSettingsError.cs` |
| `RestServiceError` | `src/AdyenApIs/Models/RestServiceError.cs` |

