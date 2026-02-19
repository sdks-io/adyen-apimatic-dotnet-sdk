
# Payment Reversal Response

## Structure

`PaymentReversalResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `MerchantAccount` | `string` | Required | The merchant account that is used to process the payment. |
| `PaymentPspReference` | `string` | Required | The [`pspReference`](https://docs.adyen.com/api-explorer/Checkout/latest/post/payments#responses-200-pspReference) of the payment to reverse. |
| `PspReference` | `string` | Required | Adyen's 16-character reference associated with the reversal request. |
| `Reference` | `string` | Optional | Your reference for the reversal request. |
| `Status` | `string` | Required, Constant | The status of your request. This will always have the value **received**.<br><br>**Value**: `"received"` |

## Example (as JSON)

```json
{
  "merchantAccount": "merchantAccount4",
  "paymentPspReference": "paymentPspReference0",
  "pspReference": "pspReference6",
  "status": "received",
  "reference": "reference2"
}
```

