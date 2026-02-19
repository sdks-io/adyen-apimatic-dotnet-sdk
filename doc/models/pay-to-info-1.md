
# Pay to Info 1

Details to provide if `type` is **payto**.

## Structure

`PayToInfo1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `MerchantName` | `string` | Required | Merchant name displayed to the shopper in the Agreements |
| `PayToPurpose` | `string` | Required | Represents the purpose of the Agreements created, it relates to the business type<br>**Allowed values**: mortgage, utility, loan, gambling, retail, salary, personal, government, pension, tax, other |

## Example (as JSON)

```json
{
  "merchantName": "merchantName8",
  "payToPurpose": "payToPurpose6"
}
```

