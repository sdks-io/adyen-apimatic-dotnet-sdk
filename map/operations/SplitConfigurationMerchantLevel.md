<!-- Generated file — do not edit; regenerated with the SDK. -->

# SplitConfigurationMerchantLevel — operations

Accessor: `client.SplitConfigurationMerchantLevel` · Source: `src/AdyenApIs/Api/SplitConfigurationMerchantLevel.cs` · 9 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CreateSplitConfiguration

- **Server group**: `DefaultManagementApi`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `CreateSplitConfiguration(CreateSplitConfigurationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `MerchantId`
- **Returns**: `SplitConfiguration`
- **Error**: `ApiException<CreateSplitConfigurationError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CreateSplitConfigurationRequest` | `src/AdyenApIs/Requests/SplitConfigurationMerchantLevel/CreateSplitConfigurationRequest.cs` |
| `SplitConfiguration` | `src/AdyenApIs/Models/SplitConfiguration.cs` |
| `CreateSplitConfigurationError` | `src/AdyenApIs/Errors/CreateSplitConfigurationError.cs` |
| `RestServiceError` | `src/AdyenApIs/Models/RestServiceError.cs` |

### CreateSplitConfigurationRule

- **Server group**: `DefaultManagementApi`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `CreateSplitConfigurationRule(CreateSplitConfigurationRuleRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `MerchantId`, `SplitConfigurationId`
- **Returns**: `SplitConfiguration`
- **Error**: `ApiException<CreateSplitConfigurationRuleError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CreateSplitConfigurationRuleRequest` | `src/AdyenApIs/Requests/SplitConfigurationMerchantLevel/CreateSplitConfigurationRuleRequest.cs` |
| `SplitConfigurationRule` | `src/AdyenApIs/Models/SplitConfigurationRule.cs` |
| `SplitConfiguration` | `src/AdyenApIs/Models/SplitConfiguration.cs` |
| `CreateSplitConfigurationRuleError` | `src/AdyenApIs/Errors/CreateSplitConfigurationRuleError.cs` |
| `RestServiceError` | `src/AdyenApIs/Models/RestServiceError.cs` |

### DeleteSplitConfiguration

- **Server group**: `DefaultManagementApi`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `DeleteSplitConfiguration(DeleteSplitConfigurationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `MerchantId`, `SplitConfigurationId`
- **Returns**: `SplitConfiguration`
- **Error**: `ApiException<DeleteSplitConfigurationError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeleteSplitConfigurationRequest` | `src/AdyenApIs/Requests/SplitConfigurationMerchantLevel/DeleteSplitConfigurationRequest.cs` |
| `SplitConfiguration` | `src/AdyenApIs/Models/SplitConfiguration.cs` |
| `DeleteSplitConfigurationError` | `src/AdyenApIs/Errors/DeleteSplitConfigurationError.cs` |
| `RestServiceError` | `src/AdyenApIs/Models/RestServiceError.cs` |

### DeleteSplitConfigurationRule

- **Server group**: `DefaultManagementApi`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `DeleteSplitConfigurationRule(DeleteSplitConfigurationRuleRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `MerchantId`, `SplitConfigurationId`, `RuleId`
- **Returns**: `SplitConfiguration`
- **Error**: `ApiException<DeleteSplitConfigurationRuleError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeleteSplitConfigurationRuleRequest` | `src/AdyenApIs/Requests/SplitConfigurationMerchantLevel/DeleteSplitConfigurationRuleRequest.cs` |
| `SplitConfiguration` | `src/AdyenApIs/Models/SplitConfiguration.cs` |
| `DeleteSplitConfigurationRuleError` | `src/AdyenApIs/Errors/DeleteSplitConfigurationRuleError.cs` |
| `RestServiceError` | `src/AdyenApIs/Models/RestServiceError.cs` |

### GetSplitConfiguration

- **Server group**: `DefaultManagementApi`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `GetSplitConfiguration(GetSplitConfigurationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `MerchantId`, `SplitConfigurationId`
- **Returns**: `SplitConfiguration`
- **Error**: `ApiException<GetSplitConfigurationError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetSplitConfigurationRequest` | `src/AdyenApIs/Requests/SplitConfigurationMerchantLevel/GetSplitConfigurationRequest.cs` |
| `SplitConfiguration` | `src/AdyenApIs/Models/SplitConfiguration.cs` |
| `GetSplitConfigurationError` | `src/AdyenApIs/Errors/GetSplitConfigurationError.cs` |
| `RestServiceError` | `src/AdyenApIs/Models/RestServiceError.cs` |

### ListSplitConfigurations

- **Server group**: `DefaultManagementApi`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `ListSplitConfigurations(ListSplitConfigurationsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `MerchantId`
- **Returns**: `SplitConfigurationList`
- **Error**: `ApiException<ListSplitConfigurationsError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ListSplitConfigurationsRequest` | `src/AdyenApIs/Requests/SplitConfigurationMerchantLevel/ListSplitConfigurationsRequest.cs` |
| `SplitConfigurationList` | `src/AdyenApIs/Models/SplitConfigurationList.cs` |
| `ListSplitConfigurationsError` | `src/AdyenApIs/Errors/ListSplitConfigurationsError.cs` |
| `RestServiceError` | `src/AdyenApIs/Models/RestServiceError.cs` |

### UpdateSplitConfiguration

- **Server group**: `DefaultManagementApi`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `UpdateSplitConfiguration(UpdateSplitConfigurationOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `MerchantId`, `SplitConfigurationId`
- **Returns**: `SplitConfiguration`
- **Error**: `ApiException<UpdateSplitConfigurationError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UpdateSplitConfigurationOperationRequest` | `src/AdyenApIs/Requests/SplitConfigurationMerchantLevel/UpdateSplitConfigurationOperationRequest.cs` |
| `UpdateSplitConfigurationRequest` | `src/AdyenApIs/Models/UpdateSplitConfigurationRequest.cs` |
| `SplitConfiguration` | `src/AdyenApIs/Models/SplitConfiguration.cs` |
| `UpdateSplitConfigurationError` | `src/AdyenApIs/Errors/UpdateSplitConfigurationError.cs` |
| `RestServiceError` | `src/AdyenApIs/Models/RestServiceError.cs` |

### UpdateSplitConfigurationRule

- **Server group**: `DefaultManagementApi`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `UpdateSplitConfigurationRule(UpdateSplitConfigurationRuleOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `MerchantId`, `SplitConfigurationId`, `RuleId`
- **Returns**: `SplitConfiguration`
- **Error**: `ApiException<UpdateSplitConfigurationRuleError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UpdateSplitConfigurationRuleOperationRequest` | `src/AdyenApIs/Requests/SplitConfigurationMerchantLevel/UpdateSplitConfigurationRuleOperationRequest.cs` |
| `UpdateSplitConfigurationRuleRequest` | `src/AdyenApIs/Models/UpdateSplitConfigurationRuleRequest.cs` |
| `SplitConfiguration` | `src/AdyenApIs/Models/SplitConfiguration.cs` |
| `UpdateSplitConfigurationRuleError` | `src/AdyenApIs/Errors/UpdateSplitConfigurationRuleError.cs` |
| `RestServiceError` | `src/AdyenApIs/Models/RestServiceError.cs` |

### UpdateSplitLogic

- **Server group**: `DefaultManagementApi`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `UpdateSplitLogic(UpdateSplitLogicRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `MerchantId`, `SplitConfigurationId`, `RuleId`, `SplitLogicId`
- **Returns**: `SplitConfiguration`
- **Error**: `ApiException<UpdateSplitLogicError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UpdateSplitLogicRequest` | `src/AdyenApIs/Requests/SplitConfigurationMerchantLevel/UpdateSplitLogicRequest.cs` |
| `UpdateSplitConfigurationLogicRequest` | `src/AdyenApIs/Models/UpdateSplitConfigurationLogicRequest.cs` |
| `SplitConfiguration` | `src/AdyenApIs/Models/SplitConfiguration.cs` |
| `UpdateSplitLogicError` | `src/AdyenApIs/Errors/UpdateSplitLogicError.cs` |
| `RestServiceError` | `src/AdyenApIs/Models/RestServiceError.cs` |

