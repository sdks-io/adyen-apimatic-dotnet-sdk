
# Create Allowed Origin Request

## Structure

`CreateAllowedOriginRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Links` | [`Links2`](../../doc/models/links-2.md) | Optional | References to resources linked to the allowed origin. |
| `Domain` | `string` | Required | Domain of the allowed origin. |
| `Id` | `string` | Optional | Unique identifier of the allowed origin. |

## Example (as JSON)

```json
{
  "domain": "https://adyen.com",
  "_links": {
    "self": {
      "href": "href0"
    }
  },
  "id": "id8"
}
```

