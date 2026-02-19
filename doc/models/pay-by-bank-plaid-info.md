
# Pay by Bank Plaid Info

## Structure

`PayByBankPlaidInfo`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Logo` | `string` | Optional | Merchant logo (max. size 150kB). Format: Base64-encoded string. |
| `TransactionDescription` | [`TransactionDescriptionInfo1`](../../doc/models/transaction-description-info-1.md) | Optional | Information regarding the transaction description.<br><br>> You cannot configure the transaction description in the test environment. |

## Example (as JSON)

```json
{
  "logo": "logo4",
  "transactionDescription": {
    "doingBusinessAsName": "doingBusinessAsName0",
    "type": "fixed"
  }
}
```

