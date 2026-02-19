
# Acct Info 1

Additional information about the cardholder’s account provided by the 3DS Requestor.

## Structure

`AcctInfo1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ChAccAgeInd` | [`ChAccAgeInd?`](../../doc/models/ch-acc-age-ind.md) | Optional | Length of time that the cardholder has had the account with the 3DS Requestor.<br>Allowed values:<br><br>* **01** — No account<br>* **02** — Created during this transaction<br>* **03** — Less than 30 days<br>* **04** — 30–60 days<br>* **05** — More than 60 days<br><br>**Constraints**: *Minimum Length*: `2`, *Maximum Length*: `2` |
| `ChAccChange` | `string` | Optional | Date that the cardholder’s account with the 3DS Requestor was last changed, including Billing or Shipping address, new payment account, or new user(s) added.<br>Format: **YYYYMMDD** |
| `ChAccChangeInd` | [`ChAccChangeInd?`](../../doc/models/ch-acc-change-ind.md) | Optional | Length of time since the cardholder’s account information with the 3DS Requestor was last changed, including Billing or Shipping address, new payment account, or new user(s) added.<br>Allowed values:<br><br>* **01** — Changed during this transaction<br>* **02** — Less than 30 days<br>* **03** — 30–60 days<br>* **04** — More than 60 days<br><br>**Constraints**: *Minimum Length*: `2`, *Maximum Length*: `2` |
| `ChAccPwChange` | `string` | Optional | Date that cardholder’s account with the 3DS Requestor had a password change or account reset.<br>Format: **YYYYMMDD** |
| `ChAccPwChangeInd` | [`ChAccPwChangeInd?`](../../doc/models/ch-acc-pw-change-ind.md) | Optional | Indicates the length of time since the cardholder’s account with the 3DS Requestor had a password change or account reset.<br>Allowed values:<br><br>* **01** — No change<br>* **02** — Changed during this transaction<br>* **03** — Less than 30 days<br>* **04** — 30–60 days<br>* **05** — More than 60 days<br><br>**Constraints**: *Minimum Length*: `2`, *Maximum Length*: `2` |
| `ChAccString` | `string` | Optional | Date that the cardholder opened the account with the 3DS Requestor.<br>Format: **YYYYMMDD** |
| `NbPurchaseAccount` | `string` | Optional | Number of purchases with this cardholder account during the previous six months. Max length: 4 characters. |
| `PaymentAccAge` | `string` | Optional | String that the payment account was enrolled in the cardholder’s account with the 3DS Requestor.<br>Format: **YYYYMMDD** |
| `PaymentAccInd` | [`PaymentAccInd?`](../../doc/models/payment-acc-ind.md) | Optional | Indicates the length of time that the payment account was enrolled in the cardholder’s account with the 3DS Requestor.<br>Allowed values:<br><br>* **01** — No account (guest checkout)<br>* **02** — During this transaction<br>* **03** — Less than 30 days<br>* **04** — 30–60 days<br>* **05** — More than 60 days<br><br>**Constraints**: *Minimum Length*: `2`, *Maximum Length*: `2` |
| `ProvisionAttemptsDay` | `string` | Optional | Number of Add Card attempts in the last 24 hours. Max length: 3 characters. |
| `ShipAddressUsage` | `string` | Optional | String when the shipping address used for this transaction was first used with the 3DS Requestor.<br>Format: **YYYYMMDD** |
| `ShipAddressUsageInd` | [`ShipAddressUsageInd?`](../../doc/models/ship-address-usage-ind.md) | Optional | Indicates when the shipping address used for this transaction was first used with the 3DS Requestor.<br>Allowed values:<br><br>* **01** — This transaction<br>* **02** — Less than 30 days<br>* **03** — 30–60 days<br>* **04** — More than 60 days<br><br>**Constraints**: *Minimum Length*: `2`, *Maximum Length*: `2` |
| `ShipNameIndicator` | [`ShipNameIndicator?`](../../doc/models/ship-name-indicator.md) | Optional | Indicates if the Cardholder Name on the account is identical to the shipping Name used for this transaction.<br>Allowed values:<br><br>* **01** — Account Name identical to shipping Name<br>* **02** — Account Name different to shipping Name<br><br>**Constraints**: *Minimum Length*: `2`, *Maximum Length*: `2` |
| `SuspiciousAccActivity` | [`SuspiciousAccActivity?`](../../doc/models/suspicious-acc-activity.md) | Optional | Indicates whether the 3DS Requestor has experienced suspicious activity (including previous fraud) on the cardholder account.<br>Allowed values:<br><br>* **01** — No suspicious activity has been observed<br>* **02** — Suspicious activity has been observed<br><br>**Constraints**: *Minimum Length*: `2`, *Maximum Length*: `2` |
| `TxnActivityDay` | `string` | Optional | Number of transactions (successful and abandoned) for this cardholder account with the 3DS Requestor across all payment accounts in the previous 24 hours. Max length: 3 characters.<br><br>**Constraints**: *Maximum Length*: `3` |
| `TxnActivityYear` | `string` | Optional | Number of transactions (successful and abandoned) for this cardholder account with the 3DS Requestor across all payment accounts in the previous year. Max length: 3 characters.<br><br>**Constraints**: *Maximum Length*: `3` |

## Example (as JSON)

```json
{
  "chAccAgeInd": "04",
  "chAccChange": "chAccChange2",
  "chAccChangeInd": "01",
  "chAccPwChange": "chAccPwChange8",
  "chAccPwChangeInd": "05"
}
```

