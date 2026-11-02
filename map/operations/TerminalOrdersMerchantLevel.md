<!-- Generated file — do not edit; regenerated with the SDK. -->

# TerminalOrdersMerchantLevel — operations

Accessor: `client.TerminalOrdersMerchantLevel` · Source: `src/AdyenApIs/Api/TerminalOrdersMerchantLevel.cs` · 10 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CancelMerchantTerminalOrder

- **Server group**: `DefaultManagementApi`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `CancelMerchantTerminalOrder(CancelMerchantTerminalOrderRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `MerchantId`, `OrderId`
- **Returns**: `TerminalOrder`
- **Error**: `ApiException<CancelMerchantTerminalOrderError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CancelMerchantTerminalOrderRequest` | `src/AdyenApIs/Requests/TerminalOrdersMerchantLevel/CancelMerchantTerminalOrderRequest.cs` |
| `TerminalOrder` | `src/AdyenApIs/Models/TerminalOrder.cs` |
| `CancelMerchantTerminalOrderError` | `src/AdyenApIs/Errors/CancelMerchantTerminalOrderError.cs` |
| `RestServiceError` | `src/AdyenApIs/Models/RestServiceError.cs` |

### CreateMerchantShippingLocation

- **Server group**: `DefaultManagementApi`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `CreateMerchantShippingLocation(CreateMerchantShippingLocationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `MerchantId`
- **Returns**: `ShippingLocation`
- **Error**: `ApiException<CreateMerchantShippingLocationError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CreateMerchantShippingLocationRequest` | `src/AdyenApIs/Requests/TerminalOrdersMerchantLevel/CreateMerchantShippingLocationRequest.cs` |
| `ShippingLocation` | `src/AdyenApIs/Models/ShippingLocation.cs` |
| `CreateMerchantShippingLocationError` | `src/AdyenApIs/Errors/CreateMerchantShippingLocationError.cs` |
| `RestServiceError` | `src/AdyenApIs/Models/RestServiceError.cs` |

### CreateMerchantTerminalOrder

- **Server group**: `DefaultManagementApi`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `CreateMerchantTerminalOrder(CreateMerchantTerminalOrderRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `MerchantId`
- **Returns**: `TerminalOrder`
- **Error**: `ApiException<CreateMerchantTerminalOrderError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CreateMerchantTerminalOrderRequest` | `src/AdyenApIs/Requests/TerminalOrdersMerchantLevel/CreateMerchantTerminalOrderRequest.cs` |
| `TerminalOrderRequest` | `src/AdyenApIs/Models/TerminalOrderRequest.cs` |
| `TerminalOrder` | `src/AdyenApIs/Models/TerminalOrder.cs` |
| `CreateMerchantTerminalOrderError` | `src/AdyenApIs/Errors/CreateMerchantTerminalOrderError.cs` |
| `RestServiceError` | `src/AdyenApIs/Models/RestServiceError.cs` |

### GetMerchantTerminalOrder

- **Server group**: `DefaultManagementApi`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `GetMerchantTerminalOrder(GetMerchantTerminalOrderRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `MerchantId`, `OrderId`
- **Returns**: `TerminalOrder`
- **Error**: `ApiException<GetMerchantTerminalOrderError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetMerchantTerminalOrderRequest` | `src/AdyenApIs/Requests/TerminalOrdersMerchantLevel/GetMerchantTerminalOrderRequest.cs` |
| `TerminalOrder` | `src/AdyenApIs/Models/TerminalOrder.cs` |
| `GetMerchantTerminalOrderError` | `src/AdyenApIs/Errors/GetMerchantTerminalOrderError.cs` |
| `RestServiceError` | `src/AdyenApIs/Models/RestServiceError.cs` |

### ListMerchantBillingEntities

- **Server group**: `DefaultManagementApi`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `ListMerchantBillingEntities(ListMerchantBillingEntitiesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `MerchantId`
- **Query params (wire ← C#)**: `name` ← `Name`
- **Returns**: `BillingEntitiesResponse`
- **Error**: `ApiException<ListMerchantBillingEntitiesError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ListMerchantBillingEntitiesRequest` | `src/AdyenApIs/Requests/TerminalOrdersMerchantLevel/ListMerchantBillingEntitiesRequest.cs` |
| `BillingEntitiesResponse` | `src/AdyenApIs/Models/BillingEntitiesResponse.cs` |
| `ListMerchantBillingEntitiesError` | `src/AdyenApIs/Errors/ListMerchantBillingEntitiesError.cs` |
| `RestServiceError` | `src/AdyenApIs/Models/RestServiceError.cs` |

### ListMerchantShippingLocations

- **Server group**: `DefaultManagementApi`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `ListMerchantShippingLocations(ListMerchantShippingLocationsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `MerchantId`
- **Query params (wire ← C#)**: `name` ← `Name`, `offset` ← `Offset`, `limit` ← `Limit`
- **Returns**: `ShippingLocationsResponse`
- **Error**: `ApiException<ListMerchantShippingLocationsError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ListMerchantShippingLocationsRequest` | `src/AdyenApIs/Requests/TerminalOrdersMerchantLevel/ListMerchantShippingLocationsRequest.cs` |
| `ShippingLocationsResponse` | `src/AdyenApIs/Models/ShippingLocationsResponse.cs` |
| `ListMerchantShippingLocationsError` | `src/AdyenApIs/Errors/ListMerchantShippingLocationsError.cs` |
| `RestServiceError` | `src/AdyenApIs/Models/RestServiceError.cs` |

### ListMerchantTerminalModels

- **Server group**: `DefaultManagementApi`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `ListMerchantTerminalModels(ListMerchantTerminalModelsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `MerchantId`
- **Returns**: `TerminalModelsResponse`
- **Error**: `ApiException<ListMerchantTerminalModelsError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ListMerchantTerminalModelsRequest` | `src/AdyenApIs/Requests/TerminalOrdersMerchantLevel/ListMerchantTerminalModelsRequest.cs` |
| `TerminalModelsResponse` | `src/AdyenApIs/Models/TerminalModelsResponse.cs` |
| `ListMerchantTerminalModelsError` | `src/AdyenApIs/Errors/ListMerchantTerminalModelsError.cs` |
| `RestServiceError` | `src/AdyenApIs/Models/RestServiceError.cs` |

### ListMerchantTerminalOrders

- **Server group**: `DefaultManagementApi`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `ListMerchantTerminalOrders(ListMerchantTerminalOrdersRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `MerchantId`
- **Query params (wire ← C#)**: `customerOrderReference` ← `CustomerOrderReference`, `status` ← `Status`, `offset` ← `Offset`, `limit` ← `Limit`
- **Returns**: `TerminalOrdersResponse`
- **Error**: `ApiException<ListMerchantTerminalOrdersError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ListMerchantTerminalOrdersRequest` | `src/AdyenApIs/Requests/TerminalOrdersMerchantLevel/ListMerchantTerminalOrdersRequest.cs` |
| `TerminalOrdersResponse` | `src/AdyenApIs/Models/TerminalOrdersResponse.cs` |
| `ListMerchantTerminalOrdersError` | `src/AdyenApIs/Errors/ListMerchantTerminalOrdersError.cs` |
| `RestServiceError` | `src/AdyenApIs/Models/RestServiceError.cs` |

### ListMerchantTerminalProducts

- **Server group**: `DefaultManagementApi`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `ListMerchantTerminalProducts(ListMerchantTerminalProductsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `MerchantId`, `Country`
- **Query params (wire ← C#)**: `country` ← `Country`, `terminalModelId` ← `TerminalModelId`, `offset` ← `Offset`, `limit` ← `Limit`
- **Returns**: `TerminalProductsResponse`
- **Error**: `ApiException<ListMerchantTerminalProductsError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ListMerchantTerminalProductsRequest` | `src/AdyenApIs/Requests/TerminalOrdersMerchantLevel/ListMerchantTerminalProductsRequest.cs` |
| `TerminalProductsResponse` | `src/AdyenApIs/Models/TerminalProductsResponse.cs` |
| `ListMerchantTerminalProductsError` | `src/AdyenApIs/Errors/ListMerchantTerminalProductsError.cs` |
| `RestServiceError` | `src/AdyenApIs/Models/RestServiceError.cs` |

### UpdateMerchantTerminalOrder

- **Server group**: `DefaultManagementApi`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `UpdateMerchantTerminalOrder(UpdateMerchantTerminalOrderRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `MerchantId`, `OrderId`
- **Returns**: `TerminalOrder`
- **Error**: `ApiException<UpdateMerchantTerminalOrderError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UpdateMerchantTerminalOrderRequest` | `src/AdyenApIs/Requests/TerminalOrdersMerchantLevel/UpdateMerchantTerminalOrderRequest.cs` |
| `TerminalOrderRequest` | `src/AdyenApIs/Models/TerminalOrderRequest.cs` |
| `TerminalOrder` | `src/AdyenApIs/Models/TerminalOrder.cs` |
| `UpdateMerchantTerminalOrderError` | `src/AdyenApIs/Errors/UpdateMerchantTerminalOrderError.cs` |
| `RestServiceError` | `src/AdyenApIs/Models/RestServiceError.cs` |

