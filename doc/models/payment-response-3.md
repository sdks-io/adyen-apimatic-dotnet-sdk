
# Payment Response 3

Only returned for `resultCode`: **Authorised**.
Details about the payment method used in the transaction.

## Structure

`PaymentResponse3`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Brand` | `string` | Optional | The card brand that the shopper used to pay. Only returned if `paymentMethod.type` is **scheme**. |
| `Type` | `string` | Optional | The `paymentMethod.type` value used in the request. |

## Example (as JSON)

```json
{
  "brand": "brand6",
  "type": "type2"
}
```

