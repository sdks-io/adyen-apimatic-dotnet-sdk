
# Sepa Direct Debit Info 1

Details to provide if `type` is **sepadirectdebit**.

## Structure

`SepaDirectDebitInfo1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `CreditorId` | `string` | Optional | Creditor id |
| `TransactionDescription` | [`TransactionDescriptionInfo1`](../../doc/models/transaction-description-info-1.md) | Optional | Information regarding the transaction description.<br><br>> You cannot configure the transaction description in the test environment. |

## Example (as JSON)

```json
{
  "creditorId": "creditorId4",
  "transactionDescription": {
    "doingBusinessAsName": "doingBusinessAsName0",
    "type": "fixed"
  }
}
```

