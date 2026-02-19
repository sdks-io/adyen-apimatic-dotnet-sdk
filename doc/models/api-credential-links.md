
# Api Credential Links

## Structure

`ApiCredentialLinks`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AllowedOrigins` | [`LinksElement1`](../../doc/models/links-element-1.md) | Optional | List of allowed origins. |
| `Company` | [`LinksElement2`](../../doc/models/links-element-2.md) | Optional | Company account that the API credential is linked to. Only present for company-level webhooks. |
| `GenerateApiKey` | [`LinksElement3`](../../doc/models/links-element-3.md) | Optional | Generates a new API key. When you generate a new one, the existing key remains valid for 24 hours. |
| `GenerateClientKey` | [`LinksElement4`](../../doc/models/links-element-4.md) | Optional | Generates a new client key, used to authenticate client-side requests. When you generate a new one, the existing key remains valid for 24 hours. |
| `Merchant` | [`LinksElement5`](../../doc/models/links-element-5.md) | Optional | The merchant account that the API credential is linked to. Only present for merchant-level API credentials. |
| `Self` | [`LinksElement6`](../../doc/models/links-element-6.md) | Required | Link to the resource itself. |

## Example (as JSON)

```json
{
  "allowedOrigins": {
    "href": "href6"
  },
  "company": {
    "href": "href2"
  },
  "generateApiKey": {
    "href": "href6"
  },
  "generateClientKey": {
    "href": "href4"
  },
  "merchant": {
    "href": "href6"
  },
  "self": {
    "href": "href0"
  }
}
```

