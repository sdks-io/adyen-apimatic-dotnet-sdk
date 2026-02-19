
# Invalid Field

*This model accepts additional fields of type object.*

## Structure

`InvalidField`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | The field that has an invalid value. |
| `MValue` | `string` | Required | The invalid value. |
| `Message` | `string` | Required | Description of the validation error. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "name": "name8",
  "value": "value0",
  "message": "message2",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

