
# Cancel Order Request

## Structure

`CancelOrderRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `MerchantAccount` | `string` | Required | The merchant account identifier that orderData belongs to. |
| `Order` | [`EncryptedOrderData4`](../../doc/models/encrypted-order-data-4.md) | Required | The order request object that contains a pspReference that represents the order and the matching encrypted order data. |

## Example (as JSON)

```json
{
  "merchantAccount": "merchantAccount2",
  "order": {
    "orderData": "orderData8",
    "pspReference": "pspReference8"
  }
}
```

