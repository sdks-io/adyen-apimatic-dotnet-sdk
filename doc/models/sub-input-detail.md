
# Sub Input Detail

## Structure

`SubInputDetail`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Configuration` | `Dictionary<string, string>` | Optional | Configuration parameters for the required input. |
| `Items` | [`List<Item>`](../../doc/models/item.md) | Optional | In case of a select, the items to choose from. |
| `Key` | `string` | Optional | The value to provide in the result. |
| `Optional` | `bool?` | Optional | True if this input is optional to provide. |
| `Type` | `string` | Optional | The type of the required input. |
| `MValue` | `string` | Optional | The value can be pre-filled, if available. |

## Example (as JSON)

```json
{
  "configuration": {
    "key0": "configuration0",
    "key1": "configuration9"
  },
  "items": [
    {
      "id": "id8",
      "name": "name8"
    }
  ],
  "key": "key4",
  "optional": false,
  "type": "type6"
}
```

