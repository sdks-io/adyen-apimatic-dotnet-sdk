
# Checkout Three Ds 2 Action

## Structure

`CheckoutThreeDs2Action`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AuthorisationToken` | `string` | Optional | A token needed to authorise a payment. |
| `PaymentData` | `string` | Optional | Encoded payment data. |
| `PaymentMethodType` | `string` | Optional | Specifies the payment method. |
| `Subtype` | `string` | Optional | A subtype of the token. |
| `Token` | `string` | Optional | A token to pass to the 3DS2 Component to get the fingerprint. |
| `Type` | `string` | Required, Constant | **threeDS2**<br><br>**Value**: `"threeDS2"` |
| `Url` | `string` | Optional | Specifies the URL to redirect to. |

## Example (as JSON)

```json
{
  "type": "threeDS2",
  "authorisationToken": "authorisationToken0",
  "paymentData": "paymentData8",
  "paymentMethodType": "paymentMethodType8",
  "subtype": "subtype8",
  "token": "token0"
}
```

