
# Offline Processing

## Structure

`OfflineProcessing`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ChipFloorLimit` | `int?` | Optional | The maximum offline transaction amount for chip cards, in the processing currency and specified in [minor units](https://docs.adyen.com/development-resources/currency-codes). |
| `OfflineSwipeLimits` | [`List<MinorUnitsMonetaryValue>`](../../doc/models/minor-units-monetary-value.md) | Optional | The maximum offline transaction amount for swiped cards, in the specified currency. |

## Example (as JSON)

```json
{
  "chipFloorLimit": 146,
  "offlineSwipeLimits": [
    {
      "amount": 136,
      "currencyCode": "currencyCode8"
    }
  ]
}
```

