
# Default Error Response Entity Exception

Standardized error response following RFC-7807 format

Find out more here: [https://www.rfc-editor.org/rfc/rfc7807](https://www.rfc-editor.org/rfc/rfc7807)

*This model accepts additional fields of type object.*

## Structure

`DefaultErrorResponseEntityException`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Detail` | `string` | Optional | A human-readable explanation specific to this occurrence of the problem. |
| `ErrorCode` | `string` | Optional | Unique business error code. |
| `Instance` | `string` | Optional | A URI that identifies the specific occurrence of the problem if applicable. |
| `InvalidFields` | [`List<InvalidField>`](../../doc/models/invalid-field.md) | Optional | Array of fields with validation errors when applicable. |
| `RequestId` | `string` | Optional | The unique reference for the request. |
| `Status` | `int?` | Optional | The HTTP status code. |
| `Title` | `string` | Optional | A short, human-readable summary of the problem type. |
| `Type` | `string` | Optional | A URI that identifies the validation error type. It points to human-readable documentation for the problem type. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "detail": "detail0",
  "errorCode": "errorCode0",
  "instance": "instance0",
  "invalidFields": [
    {
      "name": "name6",
      "value": "value8",
      "message": "message6",
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    },
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
  "requestId": "requestId6",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

