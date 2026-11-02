<!-- Generated file — do not edit; regenerated with the SDK. -->

# TerminalSettingsStoreLevel — operations

Accessor: `client.TerminalSettingsStoreLevel` · Source: `src/AdyenApIs/Api/TerminalSettingsStoreLevel.cs` · 8 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetMerchantStoreTerminalLogoByReference

- **Server group**: `DefaultManagementApi`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `GetMerchantStoreTerminalLogoByReference(GetMerchantStoreTerminalLogoByReferenceRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `MerchantId`, `Reference`, `Model`
- **Query params (wire ← C#)**: `model` ← `Model`
- **Returns**: `Logo`
- **Error**: `ApiException<GetMerchantStoreTerminalLogoByReferenceError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetMerchantStoreTerminalLogoByReferenceRequest` | `src/AdyenApIs/Requests/TerminalSettingsStoreLevel/GetMerchantStoreTerminalLogoByReferenceRequest.cs` |
| `Logo` | `src/AdyenApIs/Models/Logo.cs` |
| `GetMerchantStoreTerminalLogoByReferenceError` | `src/AdyenApIs/Errors/GetMerchantStoreTerminalLogoByReferenceError.cs` |
| `RestServiceError` | `src/AdyenApIs/Models/RestServiceError.cs` |

### GetMerchantStoreTerminalSettingsByReference

- **Server group**: `DefaultManagementApi`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `GetMerchantStoreTerminalSettingsByReference(GetMerchantStoreTerminalSettingsByReferenceRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `MerchantId`, `Reference`
- **Returns**: `TerminalSettings`
- **Error**: `ApiException<GetMerchantStoreTerminalSettingsByReferenceError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetMerchantStoreTerminalSettingsByReferenceRequest` | `src/AdyenApIs/Requests/TerminalSettingsStoreLevel/GetMerchantStoreTerminalSettingsByReferenceRequest.cs` |
| `TerminalSettings` | `src/AdyenApIs/Models/TerminalSettings.cs` |
| `GetMerchantStoreTerminalSettingsByReferenceError` | `src/AdyenApIs/Errors/GetMerchantStoreTerminalSettingsByReferenceError.cs` |
| `RestServiceError` | `src/AdyenApIs/Models/RestServiceError.cs` |

### GetStoreTerminalLogo

- **Server group**: `DefaultManagementApi`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `GetStoreTerminalLogo(GetStoreTerminalLogoRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `StoreId`, `Model`
- **Query params (wire ← C#)**: `model` ← `Model`
- **Returns**: `Logo`
- **Error**: `ApiException<GetStoreTerminalLogoError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetStoreTerminalLogoRequest` | `src/AdyenApIs/Requests/TerminalSettingsStoreLevel/GetStoreTerminalLogoRequest.cs` |
| `Logo` | `src/AdyenApIs/Models/Logo.cs` |
| `GetStoreTerminalLogoError` | `src/AdyenApIs/Errors/GetStoreTerminalLogoError.cs` |
| `RestServiceError` | `src/AdyenApIs/Models/RestServiceError.cs` |

### GetStoreTerminalSettings

- **Server group**: `DefaultManagementApi`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `GetStoreTerminalSettings(GetStoreTerminalSettingsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `StoreId`
- **Returns**: `TerminalSettings`
- **Error**: `ApiException<GetStoreTerminalSettingsError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetStoreTerminalSettingsRequest` | `src/AdyenApIs/Requests/TerminalSettingsStoreLevel/GetStoreTerminalSettingsRequest.cs` |
| `TerminalSettings` | `src/AdyenApIs/Models/TerminalSettings.cs` |
| `GetStoreTerminalSettingsError` | `src/AdyenApIs/Errors/GetStoreTerminalSettingsError.cs` |
| `RestServiceError` | `src/AdyenApIs/Models/RestServiceError.cs` |

### UpdateMerchantStoreTerminalLogoByReference

- **Server group**: `DefaultManagementApi`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `UpdateMerchantStoreTerminalLogoByReference(UpdateMerchantStoreTerminalLogoByReferenceRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `MerchantId`, `Reference`, `Model`
- **Query params (wire ← C#)**: `model` ← `Model`
- **Returns**: `Logo`
- **Error**: `ApiException<UpdateMerchantStoreTerminalLogoByReferenceError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UpdateMerchantStoreTerminalLogoByReferenceRequest` | `src/AdyenApIs/Requests/TerminalSettingsStoreLevel/UpdateMerchantStoreTerminalLogoByReferenceRequest.cs` |
| `Logo` | `src/AdyenApIs/Models/Logo.cs` |
| `UpdateMerchantStoreTerminalLogoByReferenceError` | `src/AdyenApIs/Errors/UpdateMerchantStoreTerminalLogoByReferenceError.cs` |
| `RestServiceError` | `src/AdyenApIs/Models/RestServiceError.cs` |

### UpdateMerchantStoreTerminalSettingsByReference

- **Server group**: `DefaultManagementApi`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `UpdateMerchantStoreTerminalSettingsByReference(UpdateMerchantStoreTerminalSettingsByReferenceRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `MerchantId`, `Reference`
- **Returns**: `TerminalSettings`
- **Error**: `ApiException<UpdateMerchantStoreTerminalSettingsByReferenceError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UpdateMerchantStoreTerminalSettingsByReferenceRequest` | `src/AdyenApIs/Requests/TerminalSettingsStoreLevel/UpdateMerchantStoreTerminalSettingsByReferenceRequest.cs` |
| `TerminalSettings` | `src/AdyenApIs/Models/TerminalSettings.cs` |
| `UpdateMerchantStoreTerminalSettingsByReferenceError` | `src/AdyenApIs/Errors/UpdateMerchantStoreTerminalSettingsByReferenceError.cs` |
| `RestServiceError` | `src/AdyenApIs/Models/RestServiceError.cs` |

### UpdateStoreTerminalLogo

- **Server group**: `DefaultManagementApi`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `UpdateStoreTerminalLogo(UpdateStoreTerminalLogoRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `StoreId`, `Model`
- **Query params (wire ← C#)**: `model` ← `Model`
- **Returns**: `Logo`
- **Error**: `ApiException<UpdateStoreTerminalLogoError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UpdateStoreTerminalLogoRequest` | `src/AdyenApIs/Requests/TerminalSettingsStoreLevel/UpdateStoreTerminalLogoRequest.cs` |
| `Logo` | `src/AdyenApIs/Models/Logo.cs` |
| `UpdateStoreTerminalLogoError` | `src/AdyenApIs/Errors/UpdateStoreTerminalLogoError.cs` |
| `RestServiceError` | `src/AdyenApIs/Models/RestServiceError.cs` |

### UpdateStoreTerminalSettings

- **Server group**: `DefaultManagementApi`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `UpdateStoreTerminalSettings(UpdateStoreTerminalSettingsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `StoreId`
- **Returns**: `TerminalSettings`
- **Error**: `ApiException<UpdateStoreTerminalSettingsError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UpdateStoreTerminalSettingsRequest` | `src/AdyenApIs/Requests/TerminalSettingsStoreLevel/UpdateStoreTerminalSettingsRequest.cs` |
| `TerminalSettings` | `src/AdyenApIs/Models/TerminalSettings.cs` |
| `UpdateStoreTerminalSettingsError` | `src/AdyenApIs/Errors/UpdateStoreTerminalSettingsError.cs` |
| `RestServiceError` | `src/AdyenApIs/Models/RestServiceError.cs` |

