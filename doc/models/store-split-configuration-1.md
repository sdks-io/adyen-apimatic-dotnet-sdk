
# Store Split Configuration 1

Rules for Adyen for Platforms merchants to split the transaction amount and fees.

## Structure

`StoreSplitConfiguration1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `BalanceAccountId` | `string` | Optional | The [unique identifier of the balance account](https://docs.adyen.com/api-explorer/#/balanceplatform/latest/get/balanceAccounts/{id}__queryParam_id) to which the split amount must be booked, depending on the defined [split logic](https://docs.adyen.com/api-explorer/Management/latest/post/merchants/_merchantId_/splitConfigurations#request-rules-splitLogic). |
| `SplitConfigurationId` | `string` | Optional | The unique identifier of the [split configuration profile](https://docs.adyen.com/platforms/automatic-split-configuration/create-split-configuration/). |

## Example (as JSON)

```json
{
  "balanceAccountId": "balanceAccountId4",
  "splitConfigurationId": "splitConfigurationId0"
}
```

