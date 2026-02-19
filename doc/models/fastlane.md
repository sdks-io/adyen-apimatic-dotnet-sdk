
# Fastlane

## Structure

`Fastlane`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `CheckoutAttemptId` | `string` | Optional | The checkout attempt identifier. |
| `FastlaneData` | `string` | Required | The encoded fastlane data blob |
| `RecurringDetailReference` | `string` | Optional | This is the `recurringDetailReference` returned in the response when you created the token. |
| `SdkData` | `string` | Optional | Base64-encoded JSON object containing SDK related parameters required by the SDK<br><br>**Constraints**: *Maximum Length*: `50000` |
| `StoredPaymentMethodId` | `string` | Optional | This is the `recurringDetailReference` returned in the response when you created the token.<br><br>**Constraints**: *Maximum Length*: `64` |
| `Type` | `string` | Required, Constant | **fastlane**<br><br>**Value**: `"fastlane"` |

## Example (as JSON)

```json
{
  "fastlaneData": "fastlaneData2",
  "type": "fastlane",
  "checkoutAttemptId": "checkoutAttemptId4",
  "recurringDetailReference": "recurringDetailReference8",
  "sdkData": "sdkData2",
  "storedPaymentMethodId": "storedPaymentMethodId2"
}
```

