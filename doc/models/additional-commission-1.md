
# Additional Commission 1

Defines whether to book an additional commission for payments to your user's balance account. The commission amount can be defined as a fixed amount (specified in minor units), a percentage (specified in basis points), or both.

## Structure

`AdditionalCommission1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `BalanceAccountId` | `string` | Optional | Unique identifier of the balance account to which the additional commission is booked. |
| `FixedAmount` | `long?` | Optional | A fixed commission fee, in minor units. |
| `VariablePercentage` | `long?` | Optional | A variable commission fee, in basis points. |

## Example (as JSON)

```json
{
  "balanceAccountId": "balanceAccountId0",
  "fixedAmount": 246,
  "variablePercentage": 154
}
```

