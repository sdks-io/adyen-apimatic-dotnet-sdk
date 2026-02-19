
# Delivery Method

## Structure

`DeliveryMethod`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Amount` | [`Amount23`](../../doc/models/amount-23.md) | Optional | The cost of this delivery method. |
| `Description` | `string` | Optional | The name of the delivery method as shown to the shopper. |
| `Reference` | `string` | Optional | The reference of the delivery method. |
| `Selected` | `bool?` | Optional | If you display the PayPal lightbox with delivery methods, set to **true** for the delivery method that is selected. Only one delivery method can be selected at a time. |
| `Type` | [`Type18?`](../../doc/models/type-18.md) | Optional | The type of the delivery method. |

## Example (as JSON)

```json
{
  "amount": {
    "currency": "currency2",
    "value": 110
  },
  "description": "description6",
  "reference": "reference0",
  "selected": false,
  "type": "Shipping"
}
```

