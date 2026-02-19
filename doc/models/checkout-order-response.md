
# Checkout Order Response

## Structure

`CheckoutOrderResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Amount` | [`Amount11`](../../doc/models/amount-11.md) | Optional | The initial amount of the order. |
| `ExpiresAt` | `string` | Optional | The expiry date for the order. |
| `OrderData` | `string` | Optional | The encrypted order data. |
| `PspReference` | `string` | Required | The `pspReference` that belongs to the order. |
| `Reference` | `string` | Optional | The merchant reference for the order. |
| `RemainingAmount` | [`Amount12`](../../doc/models/amount-12.md) | Optional | The updated remaining amount. |

## Example (as JSON)

```json
{
  "amount": {
    "currency": "currency2",
    "value": 110
  },
  "expiresAt": "expiresAt8",
  "orderData": "orderData6",
  "pspReference": "pspReference6",
  "reference": "reference2",
  "remainingAmount": {
    "currency": "currency6",
    "value": 156
  }
}
```

