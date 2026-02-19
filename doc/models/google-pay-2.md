
# Google Pay 2

## Structure

`GooglePay2`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `CheckoutAttemptId` | `string` | Optional | The checkout attempt identifier. |
| `FundingSource` | [`FundingSource?`](../../doc/models/funding-source.md) | Optional | The funding source that should be used when multiple sources are available. For Brazilian combo cards, by default the funding source is credit. To use debit, set this value to **debit**. |
| `GooglePayCardNetwork` | `string` | Optional | The selected payment card network. |
| `GooglePayToken` | `string` | Required | The `token` that you obtained from the [Google Pay API](https://developers.google.com/pay/api/web/reference/response-objects#PaymentData) `PaymentData` response.<br><br>**Constraints**: *Maximum Length*: `10000` |
| `RecurringDetailReference` | `string` | Optional | This is the `recurringDetailReference` returned in the response when you created the token. |
| `SdkData` | `string` | Optional | Base64-encoded JSON object containing SDK related parameters required by the SDK<br><br>**Constraints**: *Maximum Length*: `50000` |
| `StoredPaymentMethodId` | `string` | Optional | This is the `recurringDetailReference` returned in the response when you created the token.<br><br>**Constraints**: *Maximum Length*: `64` |
| `ThreeDs2SdkVersion` | `string` | Optional | Required for mobile integrations. Version of the 3D Secure 2 mobile SDK.<br><br>**Constraints**: *Maximum Length*: `12` |
| `Type` | [`Type20?`](../../doc/models/type-20.md) | Optional | **googlepay**, **paywithgoogle**<br><br>**Default**: `Type20.googlepay` |

## Example (as JSON)

```json
{
  "googlePayToken": "googlePayToken6",
  "type": "googlepay",
  "checkoutAttemptId": "checkoutAttemptId0",
  "fundingSource": "credit",
  "googlePayCardNetwork": "googlePayCardNetwork0",
  "recurringDetailReference": "recurringDetailReference4",
  "sdkData": "sdkData6"
}
```

