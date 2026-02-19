
# Shopper Id Payment Method

*This model accepts additional fields of type object.*

## Structure

`ShopperIdPaymentMethod`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Type` | `string` | Optional | - |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "type": "upi_collect",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  },
  "virtualPaymentAddress": "virtualPaymentAddress4"
}
```

