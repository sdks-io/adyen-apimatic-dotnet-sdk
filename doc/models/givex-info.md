
# Givex Info

## Structure

`GivexInfo`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `CurrencyCode` | `string` | Required | The three-character ISO currency code, such as **EUR**. |
| `Password` | `string` | Required | The password provided by the acquirer. |
| `PaymentFlow` | [`PaymentFlow`](../../doc/models/payment-flow.md) | Required | The sales channel used for the payment. |
| `Username` | `string` | Required | The username provided by the acquirer. |

## Example (as JSON)

```json
{
  "currencyCode": "currencyCode2",
  "password": "password6",
  "paymentFlow": "Ecommerce",
  "username": "username8"
}
```

