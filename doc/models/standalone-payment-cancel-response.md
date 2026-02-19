
# Standalone Payment Cancel Response

## Structure

`StandalonePaymentCancelResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `MerchantAccount` | `string` | Required | The merchant account that is used to process the payment. |
| `PaymentReference` | `string` | Required | The [`reference`](https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/payments__reqParam_reference) of the payment to cancel. |
| `PspReference` | `string` | Required | Adyen's 16-character reference associated with the cancel request. |
| `Reference` | `string` | Optional | Your reference for the cancel request. |
| `Status` | `string` | Required, Constant | The status of your request. This will always have the value **received**.<br><br>**Value**: `"received"` |

## Example (as JSON)

```json
{
  "merchantAccount": "merchantAccount6",
  "paymentReference": "paymentReference2",
  "pspReference": "pspReference6",
  "status": "received",
  "reference": "reference2"
}
```

