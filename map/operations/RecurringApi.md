<!-- Generated file — do not edit; regenerated with the SDK. -->

# RecurringApi — operations

Accessor: `client.RecurringApi` · Source: `src/AdyenApIs/Api/RecurringApi.cs` · 4 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CreateStoredPaymentMethod

- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `CreateStoredPaymentMethod(CreateStoredPaymentMethodRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `StoredPaymentMethodResource`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreateStoredPaymentMethodRequest` | `src/AdyenApIs/Requests/RecurringApi/CreateStoredPaymentMethodRequest.cs` |
| `StoredPaymentMethodRequest` | `src/AdyenApIs/Models/StoredPaymentMethodRequest.cs` |
| `StoredPaymentMethodResource` | `src/AdyenApIs/Models/StoredPaymentMethodResource.cs` |

### DeleteStoredPaymentMethod

- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `DeleteStoredPaymentMethod(DeleteStoredPaymentMethodRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `StoredPaymentMethodId`, `ShopperReference`, `MerchantAccount`
- **Query params (wire ← C#)**: `shopperReference` ← `ShopperReference`, `merchantAccount` ← `MerchantAccount`
- **Returns**: `void` (Task)
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `DeleteStoredPaymentMethodRequest` | `src/AdyenApIs/Requests/RecurringApi/DeleteStoredPaymentMethodRequest.cs` |

### ForwardRequest

- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `ForwardRequest(ForwardRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `CheckoutForwardResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ForwardRequest` | `src/AdyenApIs/Requests/RecurringApi/ForwardRequest.cs` |
| `CheckoutForwardRequest` | `src/AdyenApIs/Models/CheckoutForwardRequest.cs` |
| `CheckoutForwardResponse` | `src/AdyenApIs/Models/CheckoutForwardResponse.cs` |

### ListStoredPaymentMethods

- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `ListStoredPaymentMethods(ListStoredPaymentMethodsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `shopperReference` ← `ShopperReference`, `merchantAccount` ← `MerchantAccount`
- **Returns**: `ListStoredPaymentMethodsResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ListStoredPaymentMethodsRequest` | `src/AdyenApIs/Requests/RecurringApi/ListStoredPaymentMethodsRequest.cs` |
| `ListStoredPaymentMethodsResponse` | `src/AdyenApIs/Models/ListStoredPaymentMethodsResponse.cs` |

