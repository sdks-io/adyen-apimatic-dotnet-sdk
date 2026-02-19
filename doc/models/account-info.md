
# Account Info

## Structure

`AccountInfo`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AccountAgeIndicator` | [`AccountAgeIndicator?`](../../doc/models/account-age-indicator.md) | Optional | Indicator for the length of time since this shopper account was created in the merchant's environment.<br>Allowed values:<br><br>* notApplicable<br>* thisTransaction<br>* lessThan30Days<br>* from30To60Days<br>* moreThan60Days |
| `AccountChangeDate` | `DateTime?` | Optional | Date when the shopper's account was last changed. |
| `AccountChangeIndicator` | [`AccountChangeIndicator?`](../../doc/models/account-change-indicator.md) | Optional | Indicator for the length of time since the shopper's account was last updated.<br>Allowed values:<br><br>* thisTransaction<br>* lessThan30Days<br>* from30To60Days<br>* moreThan60Days |
| `AccountCreationDate` | `DateTime?` | Optional | Date when the shopper's account was created. |
| `AccountType` | [`AccountType?`](../../doc/models/account-type.md) | Optional | Indicates the type of account. For example, for a multi-account card product.<br>Allowed values:<br><br>* notApplicable<br>* credit<br>* debit |
| `AddCardAttemptsDay` | `int?` | Optional | Number of attempts the shopper tried to add a card to their account in the last day. |
| `DeliveryAddressUsageDate` | `DateTime?` | Optional | Date the selected delivery address was first used. |
| `DeliveryAddressUsageIndicator` | [`DeliveryAddressUsageIndicator?`](../../doc/models/delivery-address-usage-indicator.md) | Optional | Indicator for the length of time since this delivery address was first used.<br>Allowed values:<br><br>* thisTransaction<br>* lessThan30Days<br>* from30To60Days<br>* moreThan60Days |
| `HomePhone` | `string` | Optional | Shopper's home phone number (including the country code). |
| `MobilePhone` | `string` | Optional | Shopper's mobile phone number (including the country code). |
| `PasswordChangeDate` | `DateTime?` | Optional | Date when the shopper last changed their password. |
| `PasswordChangeIndicator` | [`PasswordChangeIndicator?`](../../doc/models/password-change-indicator.md) | Optional | Indicator when the shopper has changed their password.<br>Allowed values:<br><br>* notApplicable<br>* thisTransaction<br>* lessThan30Days<br>* from30To60Days<br>* moreThan60Days |
| `PastTransactionsDay` | `int?` | Optional | Number of all transactions (successful and abandoned) from this shopper in the past 24 hours. |
| `PastTransactionsYear` | `int?` | Optional | Number of all transactions (successful and abandoned) from this shopper in the past year. |
| `PaymentAccountAge` | `DateTime?` | Optional | Date this payment method was added to the shopper's account. |
| `PaymentAccountIndicator` | [`PaymentAccountIndicator?`](../../doc/models/payment-account-indicator.md) | Optional | Indicator for the length of time since this payment method was added to this shopper's account.<br>Allowed values:<br><br>* notApplicable<br>* thisTransaction<br>* lessThan30Days<br>* from30To60Days<br>* moreThan60Days |
| `PurchasesLast6Months` | `int?` | Optional | Number of successful purchases in the last six months. |
| `SuspiciousActivity` | `bool?` | Optional | Whether suspicious activity was recorded on this account. |
| `WorkPhone` | `string` | Optional | Shopper's work phone number (including the country code). |

## Example (as JSON)

```json
{
  "accountAgeIndicator": "lessThan30Days",
  "accountChangeDate": "2016-03-13T12:52:32.123Z",
  "accountChangeIndicator": "thisTransaction",
  "accountCreationDate": "2016-03-13T12:52:32.123Z",
  "accountType": "credit"
}
```

