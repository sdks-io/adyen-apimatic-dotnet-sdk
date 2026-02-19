
# Terminal Product

## Structure

`TerminalProduct`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Description` | `string` | Optional | Information about items included and integration options. |
| `Id` | `string` | Optional | The unique identifier of the product. |
| `ItemsIncluded` | `List<string>` | Optional | A list of parts included in the terminal package. |
| `Name` | `string` | Optional | The descriptive name of the product. |
| `Price` | [`TerminalProductPrice2`](../../doc/models/terminal-product-price-2.md) | Optional | The price of the product. |

## Example (as JSON)

```json
{
  "description": "description6",
  "id": "id6",
  "itemsIncluded": [
    "itemsIncluded9"
  ],
  "name": "name6",
  "price": {
    "currency": "currency2",
    "value": 203.04
  }
}
```

