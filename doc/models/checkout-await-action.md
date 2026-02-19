
# Checkout Await Action

## Structure

`CheckoutAwaitAction`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `PaymentData` | `string` | Optional | Encoded payment data. |
| `PaymentMethodType` | `string` | Optional | Specifies the payment method. |
| `Type` | `string` | Required, Constant | **await**<br><br>**Value**: `"await"` |
| `Url` | `string` | Optional | Specifies the URL to redirect to. |

## Example (as JSON)

```json
{
  "type": "await",
  "paymentData": "paymentData8",
  "paymentMethodType": "paymentMethodType8",
  "url": "url0"
}
```

