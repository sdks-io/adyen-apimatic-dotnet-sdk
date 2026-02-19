
# Ach Direct Debit

## Structure

`AchDirectDebit`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AccountHolderType` | [`AccountHolderType?`](../../doc/models/account-holder-type.md) | Optional | The account holder type (personal or business). |
| `BankAccountNumber` | `string` | Optional | The bank account number (without separators). |
| `BankAccountType` | [`BankAccountType?`](../../doc/models/bank-account-type.md) | Optional | The bank account type (checking, savings...). |
| `BankLocationId` | `string` | Optional | The bank routing number of the account. The field value is `nil` in most cases. |
| `CheckoutAttemptId` | `string` | Optional | The checkout attempt identifier. |
| `EncryptedBankAccountNumber` | `string` | Optional | Encrypted bank account number. The bank account number (without separators). |
| `EncryptedBankLocationId` | `string` | Optional | Encrypted location id. The bank routing number of the account. The field value is `nil` in most cases. |
| `OwnerName` | `string` | Optional | The name of the bank account holder.<br>If you submit a name with non-Latin characters, we automatically replace some of them with corresponding Latin characters to meet the FATF recommendations. For example:<br><br>* χ12 is converted to ch12.<br>* üA is converted to euA.<br>* Peter Møller is converted to Peter Mller, because banks don't accept 'ø'.<br>  After replacement, the ownerName must have at least three alphanumeric characters (A-Z, a-z, 0-9), and at least one of them must be a valid Latin character (A-Z, a-z). For example:<br>* John17 - allowed.<br>* J17 - allowed.<br>* 171 - not allowed.<br>* John-7 - allowed.<br><br>> If provided details don't match the required format, the response returns the error message: 203 'Invalid bank account holder name'. |
| `RecurringDetailReference` | `string` | Optional | This is the `recurringDetailReference` returned in the response when you created the token. |
| `SdkData` | `string` | Optional | Base64-encoded JSON object containing SDK related parameters required by the SDK<br><br>**Constraints**: *Maximum Length*: `50000` |
| `StoredPaymentMethodId` | `string` | Optional | This is the `recurringDetailReference` returned in the response when you created the token.<br><br>**Constraints**: *Maximum Length*: `64` |
| `TransferInstrumentId` | `string` | Optional | The unique identifier of your user's verified transfer instrument, which you can use to top up their balance accounts. |
| `Type` | [`Type?`](../../doc/models/type.md) | Optional | **ach**<br><br>**Default**: `Type.ach` |

## Example (as JSON)

```json
{
  "type": "ach",
  "accountHolderType": "business",
  "bankAccountNumber": "bankAccountNumber8",
  "bankAccountType": "checking",
  "bankLocationId": "bankLocationId2",
  "checkoutAttemptId": "checkoutAttemptId4"
}
```

