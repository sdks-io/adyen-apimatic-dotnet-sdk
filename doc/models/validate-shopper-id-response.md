
# Validate Shopper Id Response

*This model accepts additional fields of type object.*

## Structure

`ValidateShopperIdResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Reason` | `string` | Optional | Reason for the result. |
| `Result` | [`Result1?`](../../doc/models/result-1.md) | Optional | Result of the validation. Ex: valid, invalid, unknown |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "reason": "reason8",
  "result": "INVALID",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

