
# Platform Chargeback Logic 1

Defines how to book chargebacks when using [Adyen for Platforms](https://docs.adyen.com/adyen-for-platforms-model).

## Structure

`PlatformChargebackLogic1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Behavior` | [`Behavior?`](../../doc/models/behavior.md) | Optional | The method of handling the chargeback.<br><br>Possible values: **deductFromLiableAccount**, **deductFromOneBalanceAccount**, **deductAccordingToSplitRatio**. |
| `CostAllocationAccount` | `string` | Optional | The unique identifier of the balance account to which the chargeback fees are booked. By default, the chargeback fees are booked to your liable balance account. |
| `TargetAccount` | `string` | Optional | The unique identifier of the balance account against which the disputed amount is booked.<br><br>Required if `behavior` is **deductFromOneBalanceAccount**. |

## Example (as JSON)

```json
{
  "behavior": "deductFromLiableAccount",
  "costAllocationAccount": "costAllocationAccount0",
  "targetAccount": "targetAccount8"
}
```

