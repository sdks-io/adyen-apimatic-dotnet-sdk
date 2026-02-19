
# Pay Pay

## Structure

`PayPay`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `CheckoutAttemptId` | `string` | Optional | The checkout attempt identifier. |
| `RecurringDetailReference` | `string` | Optional | This is the `recurringDetailReference` returned in the response when you created the token. |
| `SdkData` | `string` | Optional | Base64-encoded JSON object containing SDK related parameters required by the SDK<br><br>**Constraints**: *Maximum Length*: `50000` |
| `StoredPaymentMethodId` | `string` | Optional | This is the `recurringDetailReference` returned in the response when you created the token.<br><br>**Constraints**: *Maximum Length*: `64` |
| `Type` | [`Type35?`](../../doc/models/type-35.md) | Optional | **paypay**<br><br>**Default**: `Type35.paypay` |

## Example (as JSON)

```json
{
  "type": "paypay",
  "checkoutAttemptId": "checkoutAttemptId8",
  "recurringDetailReference": "recurringDetailReference2",
  "sdkData": "sdkData8",
  "storedPaymentMethodId": "storedPaymentMethodId6"
}
```

