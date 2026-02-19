
# Checkout Forward Response

## Structure

`CheckoutForwardResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `MerchantReference` | `string` | Optional | Merchant defined payment reference. |
| `PspReference` | `string` | Optional | Adyen's 16-character reference associated with the transaction/request. This value is globally unique. Use this reference when you communicate with us about this request. |
| `Response` | [`CheckoutForwardResponseFromUrl2`](../../doc/models/checkout-forward-response-from-url-2.md) | Required | The details of the response Adyen received from the third party. |
| `StoredPaymentMethodId` | `string` | Optional | The unique identifier of the token. |

## Example (as JSON)

```json
{
  "merchantReference": "merchantReference4",
  "pspReference": "pspReference6",
  "response": {
    "body": "body6",
    "headers": {
      "key0": "headers3",
      "key1": "headers4",
      "key2": "headers5"
    },
    "status": 110
  },
  "storedPaymentMethodId": "storedPaymentMethodId6"
}
```

