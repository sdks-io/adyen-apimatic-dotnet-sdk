
# Sepa Direct Debit

*This model accepts additional fields of type object.*

## Structure

`SepaDirectDebit`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `CheckoutAttemptId` | `string` | Optional | The checkout attempt identifier. |
| `DueDate` | `string` | Optional | The date that the the shopper's bank account is charged. |
| `Iban` | `string` | Required | The International Bank Account Number (IBAN). |
| `OwnerName` | `string` | Required | The name of the bank account holder. |
| `RecurringDetailReference` | `string` | Optional | This is the `recurringDetailReference` returned in the response when you created the token. |
| `SdkData` | `string` | Optional | Base64-encoded JSON object containing SDK related parameters required by the SDK<br><br>**Constraints**: *Maximum Length*: `50000` |
| `StoredPaymentMethodId` | `string` | Optional | This is the `recurringDetailReference` returned in the response when you created the token.<br><br>**Constraints**: *Maximum Length*: `64` |
| `TransferInstrumentId` | `string` | Optional | The unique identifier of your user's verified transfer instrument, which you can use to top up their balance accounts. |
| `Type` | [`Type45?`](../../doc/models/type-45.md) | Optional | **sepadirectdebit**<br><br>**Default**: `Type45.sepadirectdebit` |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "iban": "iban4",
  "ownerName": "ownerName4",
  "type": "sepadirectdebit",
  "checkoutAttemptId": "checkoutAttemptId6",
  "dueDate": "dueDate6",
  "recurringDetailReference": "recurringDetailReference0",
  "sdkData": "sdkData0",
  "storedPaymentMethodId": "storedPaymentMethodId4",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

