
# Additional Data Wallets

## Structure

`AdditionalDataWallets`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AndroidpayToken` | `string` | Optional | The Android Pay token retrieved from the SDK. |
| `MasterpassTransactionId` | `string` | Optional | The Mastercard Masterpass Transaction ID retrieved from the SDK. |
| `PaymentToken` | `string` | Optional | The Apple Pay token retrieved from the SDK. |
| `PaywithgoogleToken` | `string` | Optional | The Google Pay token retrieved from the SDK. |
| `SamsungpayToken` | `string` | Optional | The Samsung Pay token retrieved from the SDK. |
| `VisacheckoutCallId` | `string` | Optional | The Visa Checkout Call ID retrieved from the SDK. |

## Example (as JSON)

```json
{
  "androidpay.token": "androidpay.token2",
  "masterpass.transactionId": "masterpass.transactionId2",
  "payment.token": "payment.token4",
  "paywithgoogle.token": "paywithgoogle.token0",
  "samsungpay.token": "samsungpay.token0"
}
```

