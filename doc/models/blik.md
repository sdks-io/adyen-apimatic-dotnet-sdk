
# Blik

## Structure

`Blik`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `BlikCode` | `string` | Optional | BLIK code consisting of 6 digits. |
| `CheckoutAttemptId` | `string` | Optional | The checkout attempt identifier. |
| `RecurringDetailReference` | `string` | Optional | This is the `recurringDetailReference` returned in the response when you created the token. |
| `SdkData` | `string` | Optional | Base64-encoded JSON object containing SDK related parameters required by the SDK<br><br>**Constraints**: *Maximum Length*: `50000` |
| `StoredPaymentMethodId` | `string` | Optional | This is the `recurringDetailReference` returned in the response when you created the token.<br><br>**Constraints**: *Maximum Length*: `64` |
| `Type` | [`Type11?`](../../doc/models/type-11.md) | Optional | **blik** |

## Example (as JSON)

```json
{
  "blikCode": "blikCode4",
  "checkoutAttemptId": "checkoutAttemptId2",
  "recurringDetailReference": "recurringDetailReference6",
  "sdkData": "sdkData4",
  "storedPaymentMethodId": "storedPaymentMethodId0"
}
```

