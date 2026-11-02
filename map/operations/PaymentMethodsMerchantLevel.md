<!-- Generated file — do not edit; regenerated with the SDK. -->

# PaymentMethodsMerchantLevel — operations

Accessor: `client.PaymentMethodsMerchantLevel` · Source: `src/AdyenApIs/Api/PaymentMethodsMerchantLevel.cs` · 6 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### AddApplePayDomains

- **Server group**: `DefaultManagementApi`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `AddApplePayDomains(AddApplePayDomainsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `MerchantId`, `PaymentMethodId`
- **Returns**: `void` (Task)
- **Error**: `ApiException<AddApplePayDomainsError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 429, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `AddApplePayDomainsRequest` | `src/AdyenApIs/Requests/PaymentMethodsMerchantLevel/AddApplePayDomainsRequest.cs` |
| `ApplePayInfo` | `src/AdyenApIs/Models/ApplePayInfo.cs` |
| `AddApplePayDomainsError` | `src/AdyenApIs/Errors/AddApplePayDomainsError.cs` |
| `RestServiceError` | `src/AdyenApIs/Models/RestServiceError.cs` |

### CreatePaymentMethodSetting

- **Server group**: `DefaultManagementApi`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `CreatePaymentMethodSetting(CreatePaymentMethodSettingRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `MerchantId`
- **Returns**: `PaymentMethodManagementApi`
- **Error**: `ApiException<CreatePaymentMethodSettingError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 429, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CreatePaymentMethodSettingRequest` | `src/AdyenApIs/Requests/PaymentMethodsMerchantLevel/CreatePaymentMethodSettingRequest.cs` |
| `PaymentMethodSetupInfo` | `src/AdyenApIs/Models/PaymentMethodSetupInfo.cs` |
| `PaymentMethodManagementApi` | `src/AdyenApIs/Models/PaymentMethodManagementApi.cs` |
| `CreatePaymentMethodSettingError` | `src/AdyenApIs/Errors/CreatePaymentMethodSettingError.cs` |
| `RestServiceError` | `src/AdyenApIs/Models/RestServiceError.cs` |

### GetApplePayDomains

- **Server group**: `DefaultManagementApi`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `GetApplePayDomains(GetApplePayDomainsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `MerchantId`, `PaymentMethodId`
- **Returns**: `ApplePayInfo`
- **Error**: `ApiException<GetApplePayDomainsError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetApplePayDomainsRequest` | `src/AdyenApIs/Requests/PaymentMethodsMerchantLevel/GetApplePayDomainsRequest.cs` |
| `ApplePayInfo` | `src/AdyenApIs/Models/ApplePayInfo.cs` |
| `GetApplePayDomainsError` | `src/AdyenApIs/Errors/GetApplePayDomainsError.cs` |
| `RestServiceError` | `src/AdyenApIs/Models/RestServiceError.cs` |

### GetPaymentMethodSetting

- **Server group**: `DefaultManagementApi`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `GetPaymentMethodSetting(GetPaymentMethodSettingRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `MerchantId`, `PaymentMethodId`
- **Returns**: `PaymentMethodManagementApi`
- **Error**: `ApiException<GetPaymentMethodSettingError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 429, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetPaymentMethodSettingRequest` | `src/AdyenApIs/Requests/PaymentMethodsMerchantLevel/GetPaymentMethodSettingRequest.cs` |
| `PaymentMethodManagementApi` | `src/AdyenApIs/Models/PaymentMethodManagementApi.cs` |
| `GetPaymentMethodSettingError` | `src/AdyenApIs/Errors/GetPaymentMethodSettingError.cs` |
| `RestServiceError` | `src/AdyenApIs/Models/RestServiceError.cs` |

### ListPaymentMethodSettings

- **Server group**: `DefaultManagementApi`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `ListPaymentMethodSettings(ListPaymentMethodSettingsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `MerchantId`
- **Query params (wire ← C#)**: `storeId` ← `StoreId`, `businessLineId` ← `BusinessLineId`, `pageSize` ← `PageSize`, `pageNumber` ← `PageNumber`
- **Returns**: `PaymentMethodResponse`
- **Error**: `ApiException<ListPaymentMethodSettingsError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 429, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ListPaymentMethodSettingsRequest` | `src/AdyenApIs/Requests/PaymentMethodsMerchantLevel/ListPaymentMethodSettingsRequest.cs` |
| `PaymentMethodResponse` | `src/AdyenApIs/Models/PaymentMethodResponse.cs` |
| `ListPaymentMethodSettingsError` | `src/AdyenApIs/Errors/ListPaymentMethodSettingsError.cs` |
| `RestServiceError` | `src/AdyenApIs/Models/RestServiceError.cs` |

### UpdatePaymentMethodSetting

- **Server group**: `DefaultManagementApi`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `UpdatePaymentMethodSetting(UpdatePaymentMethodSettingRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `MerchantId`, `PaymentMethodId`
- **Returns**: `PaymentMethodManagementApi`
- **Error**: `ApiException<UpdatePaymentMethodSettingError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 429, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UpdatePaymentMethodSettingRequest` | `src/AdyenApIs/Requests/PaymentMethodsMerchantLevel/UpdatePaymentMethodSettingRequest.cs` |
| `UpdatePaymentMethodInfo` | `src/AdyenApIs/Models/UpdatePaymentMethodInfo.cs` |
| `PaymentMethodManagementApi` | `src/AdyenApIs/Models/PaymentMethodManagementApi.cs` |
| `UpdatePaymentMethodSettingError` | `src/AdyenApIs/Errors/UpdatePaymentMethodSettingError.cs` |
| `RestServiceError` | `src/AdyenApIs/Models/RestServiceError.cs` |

