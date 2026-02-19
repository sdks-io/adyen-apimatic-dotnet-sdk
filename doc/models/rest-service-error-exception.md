
# Rest Service Error Exception

*This model accepts additional fields of type object.*

## Structure

`RestServiceErrorException`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Detail` | `string` | Required | A human-readable explanation specific to this occurrence of the problem. |
| `ErrorCode` | `string` | Required | A code that identifies the problem type. |
| `Instance` | `string` | Optional | A unique URI that identifies the specific occurrence of the problem. |
| `InvalidFields` | [`List<InvalidField>`](../../doc/models/invalid-field.md) | Optional | Detailed explanation of each validation error, when applicable. |
| `RequestId` | `string` | Optional | A unique reference for the request, essentially the same as `pspReference`. |
| `Response` | `object` | Optional | JSON response payload. |
| `Status` | `int` | Required | The HTTP status code. |
| `Title` | `string` | Required | A short, human-readable summary of the problem type. |
| `Type` | `string` | Required | A URI that identifies the problem type, pointing to human-readable documentation on this problem type. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "detail": "detail8",
  "errorCode": "errorCode8",
  "instance": "instance8",
  "invalidFields": [
    {
      "name": "name6",
      "value": "value8",
      "message": "message6",
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    }
  ],
  "requestId": "requestId4",
  "response": {
    "key1": "val1",
    "key2": "val2"
  },
  "status": 158,
  "title": "title8",
  "type": "type2",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

