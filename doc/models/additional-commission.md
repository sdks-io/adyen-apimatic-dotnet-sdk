
# Additional Commission

## Structure

`AdditionalCommission`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `BalanceAccountId` | `string` | Optional | Unique identifier of the balance account to which the additional commission is booked. |
| `FixedAmount` | `long?` | Optional | A fixed commission fee, in minor units. |
| `VariablePercentage` | `long?` | Optional | A variable commission fee, in basis points. |

## Example (as JSON)

```json
{
  "balanceAccountId": "balanceAccountId8",
  "fixedAmount": 254,
  "variablePercentage": 166
}
```

