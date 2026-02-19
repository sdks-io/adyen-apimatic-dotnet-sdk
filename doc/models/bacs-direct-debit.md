
# Bacs Direct Debit

## Structure

`BacsDirectDebit`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `BankAccountNumber` | `string` | Optional | The bank account number (without separators). |
| `BankLocationId` | `string` | Optional | The bank routing number of the account. |
| `CheckoutAttemptId` | `string` | Optional | The checkout attempt identifier. |
| `HolderName` | `string` | Optional | The name of the bank account holder. |
| `RecurringDetailReference` | `string` | Optional | This is the `recurringDetailReference` returned in the response when you created the token. |
| `SdkData` | `string` | Optional | Base64-encoded JSON object containing SDK related parameters required by the SDK<br><br>**Constraints**: *Maximum Length*: `50000` |
| `StoredPaymentMethodId` | `string` | Optional | This is the `recurringDetailReference` returned in the response when you created the token.<br><br>**Constraints**: *Maximum Length*: `64` |
| `TransferInstrumentId` | `string` | Optional | The unique identifier of your user's verified transfer instrument, which you can use to top up their balance accounts. |
| `Type` | [`Type8?`](../../doc/models/type-8.md) | Optional | **directdebit_GB**<br><br>**Default**: `Type8.directdebit_GB` |

## Example (as JSON)

```json
{
  "type": "directdebit_GB",
  "bankAccountNumber": "bankAccountNumber8",
  "bankLocationId": "bankLocationId2",
  "checkoutAttemptId": "checkoutAttemptId4",
  "holderName": "holderName4",
  "recurringDetailReference": "recurringDetailReference8"
}
```

