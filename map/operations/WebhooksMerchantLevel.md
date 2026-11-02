<!-- Generated file — do not edit; regenerated with the SDK. -->

# WebhooksMerchantLevel — operations

Accessor: `client.WebhooksMerchantLevel` · Source: `src/AdyenApIs/Api/WebhooksMerchantLevel.cs` · 7 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CreateMerchantWebhook

- **Server group**: `DefaultManagementApi`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `CreateMerchantWebhook(CreateMerchantWebhookOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `MerchantId`
- **Returns**: `Webhook`
- **Error**: `ApiException<CreateMerchantWebhookError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CreateMerchantWebhookOperationRequest` | `src/AdyenApIs/Requests/WebhooksMerchantLevel/CreateMerchantWebhookOperationRequest.cs` |
| `CreateMerchantWebhookRequest` | `src/AdyenApIs/Models/CreateMerchantWebhookRequest.cs` |
| `Webhook` | `src/AdyenApIs/Models/Webhook.cs` |
| `CreateMerchantWebhookError` | `src/AdyenApIs/Errors/CreateMerchantWebhookError.cs` |
| `RestServiceError` | `src/AdyenApIs/Models/RestServiceError.cs` |

### DeleteMerchantWebhook

- **Server group**: `DefaultManagementApi`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `DeleteMerchantWebhook(DeleteMerchantWebhookRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `MerchantId`, `WebhookId`
- **Returns**: `void` (Task)
- **Error**: `ApiException<DeleteMerchantWebhookError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeleteMerchantWebhookRequest` | `src/AdyenApIs/Requests/WebhooksMerchantLevel/DeleteMerchantWebhookRequest.cs` |
| `DeleteMerchantWebhookError` | `src/AdyenApIs/Errors/DeleteMerchantWebhookError.cs` |
| `RestServiceError` | `src/AdyenApIs/Models/RestServiceError.cs` |

### GenerateMerchantWebhookHmac

- **Server group**: `DefaultManagementApi`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `GenerateMerchantWebhookHmac(GenerateMerchantWebhookHmacRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `MerchantId`, `WebhookId`
- **Returns**: `GenerateHmacKeyResponse`
- **Error**: `ApiException<GenerateMerchantWebhookHmacError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GenerateMerchantWebhookHmacRequest` | `src/AdyenApIs/Requests/WebhooksMerchantLevel/GenerateMerchantWebhookHmacRequest.cs` |
| `GenerateHmacKeyResponse` | `src/AdyenApIs/Models/GenerateHmacKeyResponse.cs` |
| `GenerateMerchantWebhookHmacError` | `src/AdyenApIs/Errors/GenerateMerchantWebhookHmacError.cs` |
| `RestServiceError` | `src/AdyenApIs/Models/RestServiceError.cs` |

### GetMerchantWebhook

- **Server group**: `DefaultManagementApi`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `GetMerchantWebhook(GetMerchantWebhookRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `MerchantId`, `WebhookId`
- **Returns**: `Webhook`
- **Error**: `ApiException<GetMerchantWebhookError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetMerchantWebhookRequest` | `src/AdyenApIs/Requests/WebhooksMerchantLevel/GetMerchantWebhookRequest.cs` |
| `Webhook` | `src/AdyenApIs/Models/Webhook.cs` |
| `GetMerchantWebhookError` | `src/AdyenApIs/Errors/GetMerchantWebhookError.cs` |
| `RestServiceError` | `src/AdyenApIs/Models/RestServiceError.cs` |

### ListMerchantWebhooks

- **Server group**: `DefaultManagementApi`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `ListMerchantWebhooks(ListMerchantWebhooksRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `MerchantId`
- **Query params (wire ← C#)**: `pageNumber` ← `PageNumber`, `pageSize` ← `PageSize`
- **Returns**: `ListWebhooksResponse`
- **Error**: `ApiException<ListMerchantWebhooksError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ListMerchantWebhooksRequest` | `src/AdyenApIs/Requests/WebhooksMerchantLevel/ListMerchantWebhooksRequest.cs` |
| `ListWebhooksResponse` | `src/AdyenApIs/Models/ListWebhooksResponse.cs` |
| `ListMerchantWebhooksError` | `src/AdyenApIs/Errors/ListMerchantWebhooksError.cs` |
| `RestServiceError` | `src/AdyenApIs/Models/RestServiceError.cs` |

### TestMerchantWebhook

- **Server group**: `DefaultManagementApi`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `TestMerchantWebhook(TestMerchantWebhookRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `MerchantId`, `WebhookId`
- **Returns**: `TestWebhookResponse`
- **Error**: `ApiException<TestMerchantWebhookError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `TestMerchantWebhookRequest` | `src/AdyenApIs/Requests/WebhooksMerchantLevel/TestMerchantWebhookRequest.cs` |
| `TestWebhookRequest` | `src/AdyenApIs/Models/TestWebhookRequest.cs` |
| `TestWebhookResponse` | `src/AdyenApIs/Models/TestWebhookResponse.cs` |
| `TestMerchantWebhookError` | `src/AdyenApIs/Errors/TestMerchantWebhookError.cs` |
| `RestServiceError` | `src/AdyenApIs/Models/RestServiceError.cs` |

### UpdateMerchantWebhook

- **Server group**: `DefaultManagementApi`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `UpdateMerchantWebhook(UpdateMerchantWebhookOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `MerchantId`, `WebhookId`
- **Returns**: `Webhook`
- **Error**: `ApiException<UpdateMerchantWebhookError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UpdateMerchantWebhookOperationRequest` | `src/AdyenApIs/Requests/WebhooksMerchantLevel/UpdateMerchantWebhookOperationRequest.cs` |
| `UpdateMerchantWebhookRequest` | `src/AdyenApIs/Models/UpdateMerchantWebhookRequest.cs` |
| `Webhook` | `src/AdyenApIs/Models/Webhook.cs` |
| `UpdateMerchantWebhookError` | `src/AdyenApIs/Errors/UpdateMerchantWebhookError.cs` |
| `RestServiceError` | `src/AdyenApIs/Models/RestServiceError.cs` |

