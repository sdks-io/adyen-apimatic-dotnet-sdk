
# Order Item

## Structure

`OrderItem`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Optional | The unique identifier of the product. |
| `Installments` | `long?` | Optional | The number of installments for the specified product `id`. |
| `Name` | `string` | Optional | The name of the product. |
| `Quantity` | `int?` | Optional | The number of items with the specified product `id` included in the order. |

## Example (as JSON)

```json
{
  "id": "id2",
  "installments": 214,
  "name": "name2",
  "quantity": 32
}
```

