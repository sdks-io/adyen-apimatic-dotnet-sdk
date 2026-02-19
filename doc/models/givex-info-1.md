
# Givex Info 1

Details to provide if `type` is **givex**.

## Structure

`GivexInfo1`

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
  "currencyCode": "currencyCode0",
  "password": "password4",
  "paymentFlow": "Ecommerce",
  "username": "username0"
}
```

