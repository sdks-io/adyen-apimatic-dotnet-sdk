
# Checkout Bank Account

## Structure

`CheckoutBankAccount`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AccountType` | [`AccountType1?`](../../doc/models/account-type-1.md) | Optional | The type of the bank account. |
| `BankAccountNumber` | `string` | Optional | The bank account number (without separators). |
| `BankCity` | `string` | Optional | The bank city. |
| `BankLocationId` | `string` | Optional | The location id of the bank. The field value is `nil` in most cases. |
| `BankName` | `string` | Optional | The name of the bank. |
| `Bic` | `string` | Optional | The [Business Identifier Code](https://en.wikipedia.org/wiki/ISO_9362) (BIC) is the SWIFT address assigned to a bank. The field value is `nil` in most cases. |
| `CountryCode` | `string` | Optional | Country code where the bank is located.<br><br>A valid value is an ISO two-character country code (e.g. 'NL'). |
| `Iban` | `string` | Optional | The [International Bank Account Number](https://en.wikipedia.org/wiki/International_Bank_Account_Number) (IBAN). |
| `OwnerName` | `string` | Optional | The name of the bank account holder.<br>If you submit a name with non-Latin characters, we automatically replace some of them with corresponding Latin characters to meet the FATF recommendations. For example:<br><br>* χ12 is converted to ch12.<br>* üA is converted to euA.<br>* Peter Møller is converted to Peter Mller, because banks don't accept 'ø'.<br>  After replacement, the ownerName must have at least three alphanumeric characters (A-Z, a-z, 0-9), and at least one of them must be a valid Latin character (A-Z, a-z). For example:<br>* John17 - allowed.<br>* J17 - allowed.<br>* 171 - not allowed.<br>* John-7 - allowed.<br><br>> If provided details don't match the required format, the response returns the error message: 203 'Invalid bank account holder name'. |
| `TaxId` | `string` | Optional | The bank account holder's tax ID. |

## Example (as JSON)

```json
{
  "accountType": "checking",
  "bankAccountNumber": "bankAccountNumber2",
  "bankCity": "bankCity6",
  "bankLocationId": "bankLocationId6",
  "bankName": "bankName8"
}
```

