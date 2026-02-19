
# Pay by Bank Plaid Info 1

Details to provide if `type` is **paybybank_plaid**.

## Structure

`PayByBankPlaidInfo1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Logo` | `string` | Optional | Merchant logo (max. size 150kB). Format: Base64-encoded string. |
| `TransactionDescription` | [`TransactionDescriptionInfo1`](../../doc/models/transaction-description-info-1.md) | Optional | Information regarding the transaction description.<br><br>> You cannot configure the transaction description in the test environment. |

## Example (as JSON)

```json
{
  "logo": "logo0",
  "transactionDescription": {
    "doingBusinessAsName": "doingBusinessAsName0",
    "type": "fixed"
  }
}
```

