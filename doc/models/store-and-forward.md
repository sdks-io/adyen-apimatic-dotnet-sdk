
# Store and Forward

## Structure

`StoreAndForward`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `MaxAmount` | [`List<MinorUnitsMonetaryValue>`](../../doc/models/minor-units-monetary-value.md) | Optional | The maximum amount that the terminal accepts for a single store-and-forward payment. |
| `MaxPayments` | `int?` | Optional | The maximum number of store-and-forward transactions per terminal that you can process while offline. |
| `SupportedCardTypes` | [`SupportedCardTypes2`](../../doc/models/supported-card-types-2.md) | Optional | The type of card for which the terminal accepts store-and-forward payments. You can specify multiple card types. |

## Example (as JSON)

```json
{
  "maxAmount": [
    {
      "amount": 50,
      "currencyCode": "currencyCode4"
    },
    {
      "amount": 50,
      "currencyCode": "currencyCode4"
    }
  ],
  "maxPayments": 12,
  "supportedCardTypes": {
    "credit": false,
    "debit": false,
    "deferredDebit": false,
    "prepaid": false,
    "unknown": false
  }
}
```

