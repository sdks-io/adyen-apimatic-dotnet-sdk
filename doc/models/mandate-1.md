
# Mandate 1

The mandate details to initiate recurring transaction.

## Structure

`Mandate1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Amount` | `string` | Required | The billing amount (in minor units) of the recurring transactions. |
| `AmountRule` | [`AmountRule?`](../../doc/models/amount-rule.md) | Optional | The limitation rule of the billing amount.<br><br>Possible values:<br><br>* **max**: The transaction amount can not exceed the `amount`.<br><br>* **exact**: The transaction amount should be the same as the `amount`. |
| `BillingAttemptsRule` | [`BillingAttemptsRule?`](../../doc/models/billing-attempts-rule.md) | Optional | The rule to specify the period, within which the recurring debit can happen, relative to the mandate recurring date.<br><br>Possible values:<br><br>* **on**: On a specific date.<br><br>* **before**:  Before and on a specific date.<br><br>* **after**: On and after a specific date. |
| `BillingDay` | `string` | Optional | The number of the day, on which the recurring debit can happen. Should be within the same calendar month as the mandate recurring date.<br><br>Possible values: 1-31 based on the `frequency`. |
| `Count` | `string` | Optional | The number of transactions that can be performed within the given frequency. |
| `EndsAt` | `string` | Required | End date of the billing plan, in YYYY-MM-DD format. |
| `Frequency` | [`Frequency`](../../doc/models/frequency.md) | Required | The frequency with which a shopper should be charged.<br><br>Possible values: **adhoc**, **daily**, **weekly**, **biWeekly**, **monthly**, **quarterly**, **halfYearly**, **yearly**. |
| `Remarks` | `string` | Optional | The message shown by UPI to the shopper on the approval screen. |
| `StartsAt` | `string` | Optional | Start date of the billing plan, in YYYY-MM-DD format. By default, the transaction date. |

## Example (as JSON)

```json
{
  "amount": "amount2",
  "amountRule": "max",
  "billingAttemptsRule": "after",
  "billingDay": "billingDay2",
  "count": "count4",
  "endsAt": "endsAt0",
  "frequency": "weekly",
  "remarks": "remarks4"
}
```

