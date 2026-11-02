<!-- Generated file — do not edit; regenerated with the SDK. -->

# TerminalOrdersCompanyLevel — operations

Accessor: `client.TerminalOrdersCompanyLevel` · Source: `src/AdyenApIs/Api/TerminalOrdersCompanyLevel.cs` · 10 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CancelCompanyTerminalOrder

- **Server group**: `DefaultManagementApi`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `CancelCompanyTerminalOrder(CancelCompanyTerminalOrderRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `CompanyId`, `OrderId`
- **Returns**: `TerminalOrder`
- **Error**: `ApiException<CancelCompanyTerminalOrderError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CancelCompanyTerminalOrderRequest` | `src/AdyenApIs/Requests/TerminalOrdersCompanyLevel/CancelCompanyTerminalOrderRequest.cs` |
| `TerminalOrder` | `src/AdyenApIs/Models/TerminalOrder.cs` |
| `CancelCompanyTerminalOrderError` | `src/AdyenApIs/Errors/CancelCompanyTerminalOrderError.cs` |
| `RestServiceError` | `src/AdyenApIs/Models/RestServiceError.cs` |

### CreateCompanyShippingLocation

- **Server group**: `DefaultManagementApi`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `CreateCompanyShippingLocation(CreateCompanyShippingLocationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `CompanyId`
- **Returns**: `ShippingLocation`
- **Error**: `ApiException<CreateCompanyShippingLocationError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CreateCompanyShippingLocationRequest` | `src/AdyenApIs/Requests/TerminalOrdersCompanyLevel/CreateCompanyShippingLocationRequest.cs` |
| `ShippingLocation` | `src/AdyenApIs/Models/ShippingLocation.cs` |
| `CreateCompanyShippingLocationError` | `src/AdyenApIs/Errors/CreateCompanyShippingLocationError.cs` |
| `RestServiceError` | `src/AdyenApIs/Models/RestServiceError.cs` |

### CreateCompanyTerminalOrder

- **Server group**: `DefaultManagementApi`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `CreateCompanyTerminalOrder(CreateCompanyTerminalOrderRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `CompanyId`
- **Returns**: `TerminalOrder`
- **Error**: `ApiException<CreateCompanyTerminalOrderError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CreateCompanyTerminalOrderRequest` | `src/AdyenApIs/Requests/TerminalOrdersCompanyLevel/CreateCompanyTerminalOrderRequest.cs` |
| `TerminalOrderRequest` | `src/AdyenApIs/Models/TerminalOrderRequest.cs` |
| `TerminalOrder` | `src/AdyenApIs/Models/TerminalOrder.cs` |
| `CreateCompanyTerminalOrderError` | `src/AdyenApIs/Errors/CreateCompanyTerminalOrderError.cs` |
| `RestServiceError` | `src/AdyenApIs/Models/RestServiceError.cs` |

### GetCompanyTerminalOrder

- **Server group**: `DefaultManagementApi`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `GetCompanyTerminalOrder(GetCompanyTerminalOrderRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `CompanyId`, `OrderId`
- **Returns**: `TerminalOrder`
- **Error**: `ApiException<GetCompanyTerminalOrderError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetCompanyTerminalOrderRequest` | `src/AdyenApIs/Requests/TerminalOrdersCompanyLevel/GetCompanyTerminalOrderRequest.cs` |
| `TerminalOrder` | `src/AdyenApIs/Models/TerminalOrder.cs` |
| `GetCompanyTerminalOrderError` | `src/AdyenApIs/Errors/GetCompanyTerminalOrderError.cs` |
| `RestServiceError` | `src/AdyenApIs/Models/RestServiceError.cs` |

### ListCompanyBillingEntities

- **Server group**: `DefaultManagementApi`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `ListCompanyBillingEntities(ListCompanyBillingEntitiesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `CompanyId`
- **Query params (wire ← C#)**: `name` ← `Name`
- **Returns**: `BillingEntitiesResponse`
- **Error**: `ApiException<ListCompanyBillingEntitiesError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ListCompanyBillingEntitiesRequest` | `src/AdyenApIs/Requests/TerminalOrdersCompanyLevel/ListCompanyBillingEntitiesRequest.cs` |
| `BillingEntitiesResponse` | `src/AdyenApIs/Models/BillingEntitiesResponse.cs` |
| `ListCompanyBillingEntitiesError` | `src/AdyenApIs/Errors/ListCompanyBillingEntitiesError.cs` |
| `RestServiceError` | `src/AdyenApIs/Models/RestServiceError.cs` |

### ListCompanyShippingLocations

- **Server group**: `DefaultManagementApi`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `ListCompanyShippingLocations(ListCompanyShippingLocationsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `CompanyId`
- **Query params (wire ← C#)**: `name` ← `Name`, `offset` ← `Offset`, `limit` ← `Limit`
- **Returns**: `ShippingLocationsResponse`
- **Error**: `ApiException<ListCompanyShippingLocationsError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ListCompanyShippingLocationsRequest` | `src/AdyenApIs/Requests/TerminalOrdersCompanyLevel/ListCompanyShippingLocationsRequest.cs` |
| `ShippingLocationsResponse` | `src/AdyenApIs/Models/ShippingLocationsResponse.cs` |
| `ListCompanyShippingLocationsError` | `src/AdyenApIs/Errors/ListCompanyShippingLocationsError.cs` |
| `RestServiceError` | `src/AdyenApIs/Models/RestServiceError.cs` |

### ListCompanyTerminalModels

- **Server group**: `DefaultManagementApi`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `ListCompanyTerminalModels(ListCompanyTerminalModelsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `CompanyId`
- **Returns**: `TerminalModelsResponse`
- **Error**: `ApiException<ListCompanyTerminalModelsError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ListCompanyTerminalModelsRequest` | `src/AdyenApIs/Requests/TerminalOrdersCompanyLevel/ListCompanyTerminalModelsRequest.cs` |
| `TerminalModelsResponse` | `src/AdyenApIs/Models/TerminalModelsResponse.cs` |
| `ListCompanyTerminalModelsError` | `src/AdyenApIs/Errors/ListCompanyTerminalModelsError.cs` |
| `RestServiceError` | `src/AdyenApIs/Models/RestServiceError.cs` |

### ListCompanyTerminalOrders

- **Server group**: `DefaultManagementApi`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `ListCompanyTerminalOrders(ListCompanyTerminalOrdersRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `CompanyId`
- **Query params (wire ← C#)**: `customerOrderReference` ← `CustomerOrderReference`, `status` ← `Status`, `offset` ← `Offset`, `limit` ← `Limit`
- **Returns**: `TerminalOrdersResponse`
- **Error**: `ApiException<ListCompanyTerminalOrdersError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ListCompanyTerminalOrdersRequest` | `src/AdyenApIs/Requests/TerminalOrdersCompanyLevel/ListCompanyTerminalOrdersRequest.cs` |
| `TerminalOrdersResponse` | `src/AdyenApIs/Models/TerminalOrdersResponse.cs` |
| `ListCompanyTerminalOrdersError` | `src/AdyenApIs/Errors/ListCompanyTerminalOrdersError.cs` |
| `RestServiceError` | `src/AdyenApIs/Models/RestServiceError.cs` |

### ListCompanyTerminalProducts

- **Server group**: `DefaultManagementApi`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `ListCompanyTerminalProducts(ListCompanyTerminalProductsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `CompanyId`, `Country`
- **Query params (wire ← C#)**: `country` ← `Country`, `terminalModelId` ← `TerminalModelId`, `offset` ← `Offset`, `limit` ← `Limit`
- **Returns**: `TerminalProductsResponse`
- **Error**: `ApiException<ListCompanyTerminalProductsError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ListCompanyTerminalProductsRequest` | `src/AdyenApIs/Requests/TerminalOrdersCompanyLevel/ListCompanyTerminalProductsRequest.cs` |
| `TerminalProductsResponse` | `src/AdyenApIs/Models/TerminalProductsResponse.cs` |
| `ListCompanyTerminalProductsError` | `src/AdyenApIs/Errors/ListCompanyTerminalProductsError.cs` |
| `RestServiceError` | `src/AdyenApIs/Models/RestServiceError.cs` |

### UpdateCompanyTerminalOrder

- **Server group**: `DefaultManagementApi`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `UpdateCompanyTerminalOrder(UpdateCompanyTerminalOrderRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `CompanyId`, `OrderId`
- **Returns**: `TerminalOrder`
- **Error**: `ApiException<UpdateCompanyTerminalOrderError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UpdateCompanyTerminalOrderRequest` | `src/AdyenApIs/Requests/TerminalOrdersCompanyLevel/UpdateCompanyTerminalOrderRequest.cs` |
| `TerminalOrderRequest` | `src/AdyenApIs/Models/TerminalOrderRequest.cs` |
| `TerminalOrder` | `src/AdyenApIs/Models/TerminalOrder.cs` |
| `UpdateCompanyTerminalOrderError` | `src/AdyenApIs/Errors/UpdateCompanyTerminalOrderError.cs` |
| `RestServiceError` | `src/AdyenApIs/Models/RestServiceError.cs` |

