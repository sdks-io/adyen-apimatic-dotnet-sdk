
# Pay by Bank Ais Direct Debit

## Structure

`PayByBankAisDirectDebit`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `CheckoutAttemptId` | `string` | Optional | The checkout attempt identifier. |
| `RecurringDetailReference` | `string` | Optional | This is the `recurringDetailReference` returned in the response when you created the token. |
| `SdkData` | `string` | Optional | Base64-encoded JSON object containing SDK related parameters required by the SDK<br><br>**Constraints**: *Maximum Length*: `50000` |
| `StoredPaymentMethodId` | `string` | Optional | This is the `recurringDetailReference` returned in the response when you created the token.<br><br>**Constraints**: *Maximum Length*: `64` |
| `Type` | `string` | Required, Constant | **paybybank_AIS_DD**<br><br>**Value**: `"paybybank_AIS_DD"` |

## Example (as JSON)

```json
{
  "type": "paybybank_AIS_DD",
  "checkoutAttemptId": "checkoutAttemptId6",
  "recurringDetailReference": "recurringDetailReference0",
  "sdkData": "sdkData0",
  "storedPaymentMethodId": "storedPaymentMethodId4"
}
```

