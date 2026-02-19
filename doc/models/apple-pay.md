
# Apple Pay

## Structure

`ApplePay`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ApplePayToken` | `string` | Required | The stringified and base64 encoded `paymentData` you retrieved from the Apple framework.<br><br>**Constraints**: *Maximum Length*: `10000` |
| `CheckoutAttemptId` | `string` | Optional | The checkout attempt identifier. |
| `FundingSource` | [`FundingSource?`](../../doc/models/funding-source.md) | Optional | The funding source that should be used when multiple sources are available. For Brazilian combo cards, by default the funding source is credit. To use debit, set this value to **debit**. |
| `RecurringDetailReference` | `string` | Optional | This is the `recurringDetailReference` returned in the response when you created the token. |
| `SdkData` | `string` | Optional | Base64-encoded JSON object containing SDK related parameters required by the SDK<br><br>**Constraints**: *Maximum Length*: `50000` |
| `StoredPaymentMethodId` | `string` | Optional | This is the `recurringDetailReference` returned in the response when you created the token.<br><br>**Constraints**: *Maximum Length*: `64` |
| `Type` | [`Type6?`](../../doc/models/type-6.md) | Optional | **applepay**<br><br>**Default**: `Type6.applepay` |

## Example (as JSON)

```json
{
  "applePayToken": "applePayToken6",
  "type": "applepay",
  "checkoutAttemptId": "checkoutAttemptId0",
  "fundingSource": "credit",
  "recurringDetailReference": "recurringDetailReference4",
  "sdkData": "sdkData4",
  "storedPaymentMethodId": "storedPaymentMethodId8"
}
```

