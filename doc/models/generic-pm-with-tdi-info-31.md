
# Generic Pm With Tdi Info 31

Details to provide if `type` is **jcb**.
For merchants operating in Japan, `midNumber`, `reuseMidNumber`, and `serviceLevel` fields are required.
For merchants operating outside of Japan, these fields are not required.

## Structure

`GenericPmWithTdiInfo31`

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

