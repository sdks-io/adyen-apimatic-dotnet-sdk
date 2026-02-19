
# Upi Payment Method

*This model accepts additional fields of type object.*

## Structure

`UpiPaymentMethod`

## Inherits From

[`ShopperIdPaymentMethod`](../../doc/models/shopper-id-payment-method.md)

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `VirtualPaymentAddress` | `string` | Optional | **Constraints**: *Minimum Length*: `1`, *Maximum Length*: `256` |
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

