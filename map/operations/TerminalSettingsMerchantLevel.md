<!-- Generated file — do not edit; regenerated with the SDK. -->

# TerminalSettingsMerchantLevel — operations

Accessor: `client.TerminalSettingsMerchantLevel` · Source: `src/AdyenApIs/Api/TerminalSettingsMerchantLevel.cs` · 4 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetMerchantTerminalLogo

- **Server group**: `DefaultManagementApi`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `GetMerchantTerminalLogo(GetMerchantTerminalLogoRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `MerchantId`, `Model`
- **Query params (wire ← C#)**: `model` ← `Model`
- **Returns**: `Logo`
- **Error**: `ApiException<GetMerchantTerminalLogoError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetMerchantTerminalLogoRequest` | `src/AdyenApIs/Requests/TerminalSettingsMerchantLevel/GetMerchantTerminalLogoRequest.cs` |
| `Logo` | `src/AdyenApIs/Models/Logo.cs` |
| `GetMerchantTerminalLogoError` | `src/AdyenApIs/Errors/GetMerchantTerminalLogoError.cs` |
| `RestServiceError` | `src/AdyenApIs/Models/RestServiceError.cs` |

### GetMerchantTerminalSettings

- **Server group**: `DefaultManagementApi`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `GetMerchantTerminalSettings(GetMerchantTerminalSettingsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `MerchantId`
- **Returns**: `TerminalSettings`
- **Error**: `ApiException<GetMerchantTerminalSettingsError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetMerchantTerminalSettingsRequest` | `src/AdyenApIs/Requests/TerminalSettingsMerchantLevel/GetMerchantTerminalSettingsRequest.cs` |
| `TerminalSettings` | `src/AdyenApIs/Models/TerminalSettings.cs` |
| `GetMerchantTerminalSettingsError` | `src/AdyenApIs/Errors/GetMerchantTerminalSettingsError.cs` |
| `RestServiceError` | `src/AdyenApIs/Models/RestServiceError.cs` |

### UpdateMerchantTerminalLogo

- **Server group**: `DefaultManagementApi`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `UpdateMerchantTerminalLogo(UpdateMerchantTerminalLogoRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `MerchantId`, `Model`
- **Query params (wire ← C#)**: `model` ← `Model`
- **Returns**: `Logo`
- **Error**: `ApiException<UpdateMerchantTerminalLogoError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UpdateMerchantTerminalLogoRequest` | `src/AdyenApIs/Requests/TerminalSettingsMerchantLevel/UpdateMerchantTerminalLogoRequest.cs` |
| `Logo` | `src/AdyenApIs/Models/Logo.cs` |
| `UpdateMerchantTerminalLogoError` | `src/AdyenApIs/Errors/UpdateMerchantTerminalLogoError.cs` |
| `RestServiceError` | `src/AdyenApIs/Models/RestServiceError.cs` |

### UpdateMerchantTerminalSettings

- **Server group**: `DefaultManagementApi`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `UpdateMerchantTerminalSettings(UpdateMerchantTerminalSettingsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `MerchantId`
- **Returns**: `TerminalSettings`
- **Error**: `ApiException<UpdateMerchantTerminalSettingsError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UpdateMerchantTerminalSettingsRequest` | `src/AdyenApIs/Requests/TerminalSettingsMerchantLevel/UpdateMerchantTerminalSettingsRequest.cs` |
| `TerminalSettings` | `src/AdyenApIs/Models/TerminalSettings.cs` |
| `UpdateMerchantTerminalSettingsError` | `src/AdyenApIs/Errors/UpdateMerchantTerminalSettingsError.cs` |
| `RestServiceError` | `src/AdyenApIs/Models/RestServiceError.cs` |

