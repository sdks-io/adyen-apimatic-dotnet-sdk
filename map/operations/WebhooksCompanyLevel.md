<!-- Generated file — do not edit; regenerated with the SDK. -->

# WebhooksCompanyLevel — operations

Accessor: `client.WebhooksCompanyLevel` · Source: `src/AdyenApIs/Api/WebhooksCompanyLevel.cs` · 7 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CreateCompanyWebhook

- **Server group**: `DefaultManagementApi`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `CreateCompanyWebhook(CreateCompanyWebhookOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `CompanyId`
- **Returns**: `Webhook`
- **Error**: `ApiException<CreateCompanyWebhookError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CreateCompanyWebhookOperationRequest` | `src/AdyenApIs/Requests/WebhooksCompanyLevel/CreateCompanyWebhookOperationRequest.cs` |
| `CreateCompanyWebhookRequest` | `src/AdyenApIs/Models/CreateCompanyWebhookRequest.cs` |
| `Webhook` | `src/AdyenApIs/Models/Webhook.cs` |
| `CreateCompanyWebhookError` | `src/AdyenApIs/Errors/CreateCompanyWebhookError.cs` |
| `RestServiceError` | `src/AdyenApIs/Models/RestServiceError.cs` |

### DeleteCompanyWebhook

- **Server group**: `DefaultManagementApi`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `DeleteCompanyWebhook(DeleteCompanyWebhookRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `CompanyId`, `WebhookId`
- **Returns**: `void` (Task)
- **Error**: `ApiException<DeleteCompanyWebhookError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeleteCompanyWebhookRequest` | `src/AdyenApIs/Requests/WebhooksCompanyLevel/DeleteCompanyWebhookRequest.cs` |
| `DeleteCompanyWebhookError` | `src/AdyenApIs/Errors/DeleteCompanyWebhookError.cs` |
| `RestServiceError` | `src/AdyenApIs/Models/RestServiceError.cs` |

### GenerateCompanyWebhookHmac

- **Server group**: `DefaultManagementApi`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `GenerateCompanyWebhookHmac(GenerateCompanyWebhookHmacRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `CompanyId`, `WebhookId`
- **Returns**: `GenerateHmacKeyResponse`
- **Error**: `ApiException<GenerateCompanyWebhookHmacError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GenerateCompanyWebhookHmacRequest` | `src/AdyenApIs/Requests/WebhooksCompanyLevel/GenerateCompanyWebhookHmacRequest.cs` |
| `GenerateHmacKeyResponse` | `src/AdyenApIs/Models/GenerateHmacKeyResponse.cs` |
| `GenerateCompanyWebhookHmacError` | `src/AdyenApIs/Errors/GenerateCompanyWebhookHmacError.cs` |
| `RestServiceError` | `src/AdyenApIs/Models/RestServiceError.cs` |

### GetCompanyWebhook

- **Server group**: `DefaultManagementApi`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `GetCompanyWebhook(GetCompanyWebhookRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `CompanyId`, `WebhookId`
- **Returns**: `Webhook`
- **Error**: `ApiException<GetCompanyWebhookError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetCompanyWebhookRequest` | `src/AdyenApIs/Requests/WebhooksCompanyLevel/GetCompanyWebhookRequest.cs` |
| `Webhook` | `src/AdyenApIs/Models/Webhook.cs` |
| `GetCompanyWebhookError` | `src/AdyenApIs/Errors/GetCompanyWebhookError.cs` |
| `RestServiceError` | `src/AdyenApIs/Models/RestServiceError.cs` |

### ListCompanyWebhooks

- **Server group**: `DefaultManagementApi`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `ListCompanyWebhooks(ListCompanyWebhooksRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `CompanyId`
- **Query params (wire ← C#)**: `pageNumber` ← `PageNumber`, `pageSize` ← `PageSize`
- **Returns**: `ListWebhooksResponse`
- **Error**: `ApiException<ListCompanyWebhooksError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ListCompanyWebhooksRequest` | `src/AdyenApIs/Requests/WebhooksCompanyLevel/ListCompanyWebhooksRequest.cs` |
| `ListWebhooksResponse` | `src/AdyenApIs/Models/ListWebhooksResponse.cs` |
| `ListCompanyWebhooksError` | `src/AdyenApIs/Errors/ListCompanyWebhooksError.cs` |
| `RestServiceError` | `src/AdyenApIs/Models/RestServiceError.cs` |

### TestCompanyWebhook

- **Server group**: `DefaultManagementApi`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `TestCompanyWebhook(TestCompanyWebhookOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `CompanyId`, `WebhookId`
- **Returns**: `TestWebhookResponse`
- **Error**: `ApiException<TestCompanyWebhookError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `TestCompanyWebhookOperationRequest` | `src/AdyenApIs/Requests/WebhooksCompanyLevel/TestCompanyWebhookOperationRequest.cs` |
| `TestCompanyWebhookRequest` | `src/AdyenApIs/Models/TestCompanyWebhookRequest.cs` |
| `TestWebhookResponse` | `src/AdyenApIs/Models/TestWebhookResponse.cs` |
| `TestCompanyWebhookError` | `src/AdyenApIs/Errors/TestCompanyWebhookError.cs` |
| `RestServiceError` | `src/AdyenApIs/Models/RestServiceError.cs` |

### UpdateCompanyWebhook

- **Server group**: `DefaultManagementApi`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `UpdateCompanyWebhook(UpdateCompanyWebhookOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `CompanyId`, `WebhookId`
- **Returns**: `Webhook`
- **Error**: `ApiException<UpdateCompanyWebhookError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UpdateCompanyWebhookOperationRequest` | `src/AdyenApIs/Requests/WebhooksCompanyLevel/UpdateCompanyWebhookOperationRequest.cs` |
| `UpdateCompanyWebhookRequest` | `src/AdyenApIs/Models/UpdateCompanyWebhookRequest.cs` |
| `Webhook` | `src/AdyenApIs/Models/Webhook.cs` |
| `UpdateCompanyWebhookError` | `src/AdyenApIs/Errors/UpdateCompanyWebhookError.cs` |
| `RestServiceError` | `src/AdyenApIs/Models/RestServiceError.cs` |

