
# Webhook Links

## Structure

`WebhookLinks`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Company` | [`LinksElement15`](../../doc/models/links-element-15.md) | Optional | The company account that the webhook is configured for. Only present for company-level webhooks. |
| `GenerateHmac` | [`LinksElement16`](../../doc/models/links-element-16.md) | Required | Generate an HMAC key. |
| `Merchant` | [`LinksElement17`](../../doc/models/links-element-17.md) | Optional | The merchant account that the webhook is configured for. Only present for merchant-level webhooks. |
| `Self` | [`LinksElement6`](../../doc/models/links-element-6.md) | Required | Link to the resource itself. |
| `TestWebhook` | [`LinksElement19`](../../doc/models/links-element-19.md) | Required | Test the webhook setup. |

## Example (as JSON)

```json
{
  "company": {
    "href": "href2"
  },
  "generateHmac": {
    "href": "href6"
  },
  "merchant": {
    "href": "href6"
  },
  "self": {
    "href": "href0"
  },
  "testWebhook": {
    "href": "href6"
  }
}
```

