
# Checkout Delegated Authentication Action

## Structure

`CheckoutDelegatedAuthenticationAction`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AuthorisationToken` | `string` | Optional | A token needed to authorise a payment. |
| `PaymentData` | `string` | Optional | Encoded payment data. |
| `PaymentMethodType` | `string` | Optional | Specifies the payment method. |
| `Token` | `string` | Optional | A token to pass to the delegatedAuthentication component. |
| `Type` | `string` | Required, Constant | **delegatedAuthentication**<br><br>**Value**: `"delegatedAuthentication"` |
| `Url` | `string` | Optional | Specifies the URL to redirect to. |

## Example (as JSON)

```json
{
  "type": "delegatedAuthentication",
  "authorisationToken": "authorisationToken4",
  "paymentData": "paymentData2",
  "paymentMethodType": "paymentMethodType2",
  "token": "token4",
  "url": "url4"
}
```

