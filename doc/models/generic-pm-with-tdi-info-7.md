
# Generic Pm With Tdi Info 7

Details to provide if `type` is **interac_card**.

## Structure

`GenericPmWithTdiInfo7`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `TransactionDescription` | [`TransactionDescriptionInfo1`](../../doc/models/transaction-description-info-1.md) | Optional | Information regarding the transaction description.<br><br>> You cannot configure the transaction description in the test environment. |

## Example (as JSON)

```json
{
  "transactionDescription": {
    "doingBusinessAsName": "doingBusinessAsName0",
    "type": "fixed"
  }
}
```

