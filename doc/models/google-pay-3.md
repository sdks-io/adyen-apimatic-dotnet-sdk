
# Google Pay 3

## Structure

`GooglePay3`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `CheckoutAttemptId` | `string` | Optional | The checkout attempt identifier. |
| `FundingSource` | [`FundingSource?`](../../doc/models/funding-source.md) | Optional | The funding source that should be used when multiple sources are available. For Brazilian combo cards, by default the funding source is credit. To use debit, set this value to **debit**. |
| `GooglePayToken` | `string` | Required | The `token` that you obtained from the [Google Pay API](https://developers.google.com/pay/api/web/reference/response-objects#PaymentData) `PaymentData` response.<br><br>**Constraints**: *Maximum Length*: `5000` |
| `RecurringDetailReference` | `string` | Optional | This is the `recurringDetailReference` returned in the response when you created the token. |
| `SdkData` | `string` | Optional | Base64-encoded JSON object containing SDK related parameters required by the SDK<br><br>**Constraints**: *Maximum Length*: `50000` |
| `StoredPaymentMethodId` | `string` | Optional | This is the `recurringDetailReference` returned in the response when you created the token.<br><br>**Constraints**: *Maximum Length*: `64` |
| `ThreeDs2SdkVersion` | `string` | Optional | Required for mobile integrations. Version of the 3D Secure 2 mobile SDK.<br><br>**Constraints**: *Maximum Length*: `12` |
| `Type` | [`Type22?`](../../doc/models/type-22.md) | Optional | **paywithgoogle**<br><br>**Default**: `Type22.paywithgoogle` |

## Example (as JSON)

```json
{
  "googlePayToken": "googlePayToken6",
  "type": "paywithgoogle",
  "checkoutAttemptId": "checkoutAttemptId0",
  "fundingSource": "prepaid",
  "recurringDetailReference": "recurringDetailReference4",
  "sdkData": "sdkData6",
  "storedPaymentMethodId": "storedPaymentMethodId8"
}
```

