
# Forex Quote 2

The forex quote as returned in the response of the forex service.

## Structure

`ForexQuote2`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Account` | `string` | Optional | The account name. |
| `AccountType` | `string` | Optional | The account type. |
| `BaseAmount` | [`Amount3`](../../doc/models/amount-3.md) | Optional | The base amount. |
| `BasePoints` | `int` | Required | The base points. |
| `Buy` | [`Amount4`](../../doc/models/amount-4.md) | Optional | The buy rate. |
| `Interbank` | [`Amount5`](../../doc/models/amount-5.md) | Optional | The interbank amount. |
| `Reference` | `string` | Optional | The reference assigned to the forex quote request. |
| `Sell` | [`Amount6`](../../doc/models/amount-6.md) | Optional | The sell rate. |
| `Signature` | `string` | Optional | The signature to validate the integrity. |
| `Source` | `string` | Optional | The source of the forex quote. |
| `Type` | `string` | Optional | The type of forex. |
| `ValidTill` | `DateTime` | Required | The date until which the forex quote is valid. |

## Example (as JSON)

```json
{
  "account": "account4",
  "accountType": "accountType4",
  "baseAmount": {
    "currency": "currency8",
    "value": 202
  },
  "basePoints": 208,
  "buy": {
    "currency": "currency2",
    "value": 72
  },
  "interbank": {
    "currency": "currency4",
    "value": 244
  },
  "validTill": "2016-03-13T12:52:32.123Z"
}
```

