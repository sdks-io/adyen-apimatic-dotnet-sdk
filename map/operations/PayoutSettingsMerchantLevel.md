<!-- Generated file — do not edit; regenerated with the SDK. -->

# PayoutSettingsMerchantLevel — operations

Accessor: `client.PayoutSettingsMerchantLevel` · Source: `src/AdyenApIs/Api/PayoutSettingsMerchantLevel.cs` · 5 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CreatePayoutSetting

- **Server group**: `DefaultManagementApi`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `CreatePayoutSetting(CreatePayoutSettingRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `MerchantId`
- **Returns**: `PayoutSettings`
- **Error**: `ApiException<CreatePayoutSettingError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CreatePayoutSettingRequest` | `src/AdyenApIs/Requests/PayoutSettingsMerchantLevel/CreatePayoutSettingRequest.cs` |
| `PayoutSettingsRequest` | `src/AdyenApIs/Models/PayoutSettingsRequest.cs` |
| `PayoutSettings` | `src/AdyenApIs/Models/PayoutSettings.cs` |
| `CreatePayoutSettingError` | `src/AdyenApIs/Errors/CreatePayoutSettingError.cs` |
| `RestServiceError` | `src/AdyenApIs/Models/RestServiceError.cs` |

### DeletePayoutSetting

- **Server group**: `DefaultManagementApi`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `DeletePayoutSetting(DeletePayoutSettingRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `MerchantId`, `PayoutSettingsId`
- **Returns**: `void` (Task)
- **Error**: `ApiException<DeletePayoutSettingError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeletePayoutSettingRequest` | `src/AdyenApIs/Requests/PayoutSettingsMerchantLevel/DeletePayoutSettingRequest.cs` |
| `DeletePayoutSettingError` | `src/AdyenApIs/Errors/DeletePayoutSettingError.cs` |
| `RestServiceError` | `src/AdyenApIs/Models/RestServiceError.cs` |

### GetPayoutSetting

- **Server group**: `DefaultManagementApi`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `GetPayoutSetting(GetPayoutSettingRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `MerchantId`, `PayoutSettingsId`
- **Returns**: `PayoutSettings`
- **Error**: `ApiException<GetPayoutSettingError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetPayoutSettingRequest` | `src/AdyenApIs/Requests/PayoutSettingsMerchantLevel/GetPayoutSettingRequest.cs` |
| `PayoutSettings` | `src/AdyenApIs/Models/PayoutSettings.cs` |
| `GetPayoutSettingError` | `src/AdyenApIs/Errors/GetPayoutSettingError.cs` |
| `RestServiceError` | `src/AdyenApIs/Models/RestServiceError.cs` |

### ListPayoutSettings

- **Server group**: `DefaultManagementApi`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `ListPayoutSettings(ListPayoutSettingsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `MerchantId`
- **Returns**: `PayoutSettingsResponse`
- **Error**: `ApiException<ListPayoutSettingsError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ListPayoutSettingsRequest` | `src/AdyenApIs/Requests/PayoutSettingsMerchantLevel/ListPayoutSettingsRequest.cs` |
| `PayoutSettingsResponse` | `src/AdyenApIs/Models/PayoutSettingsResponse.cs` |
| `ListPayoutSettingsError` | `src/AdyenApIs/Errors/ListPayoutSettingsError.cs` |
| `RestServiceError` | `src/AdyenApIs/Models/RestServiceError.cs` |

### UpdatePayoutSetting

- **Server group**: `DefaultManagementApi`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `UpdatePayoutSetting(UpdatePayoutSettingRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `MerchantId`, `PayoutSettingsId`
- **Returns**: `PayoutSettings`
- **Error**: `ApiException<UpdatePayoutSettingError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UpdatePayoutSettingRequest` | `src/AdyenApIs/Requests/PayoutSettingsMerchantLevel/UpdatePayoutSettingRequest.cs` |
| `UpdatePayoutSettingsRequest` | `src/AdyenApIs/Models/UpdatePayoutSettingsRequest.cs` |
| `PayoutSettings` | `src/AdyenApIs/Models/PayoutSettings.cs` |
| `UpdatePayoutSettingError` | `src/AdyenApIs/Errors/UpdatePayoutSettingError.cs` |
| `RestServiceError` | `src/AdyenApIs/Models/RestServiceError.cs` |

