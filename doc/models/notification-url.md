
# Notification Url

## Structure

`NotificationUrl`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `LocalUrls` | [`List<Url>`](../../doc/models/url.md) | Optional | One or more local URLs to send notifications to when using Terminal API. |
| `PublicUrls` | [`List<Url>`](../../doc/models/url.md) | Optional | One or more public URLs to send notifications to when using Terminal API. |

## Example (as JSON)

```json
{
  "localUrls": [
    {
      "encrypted": false,
      "password": "password4",
      "url": "url4",
      "username": "username0"
    },
    {
      "encrypted": false,
      "password": "password4",
      "url": "url4",
      "username": "username0"
    },
    {
      "encrypted": false,
      "password": "password4",
      "url": "url4",
      "username": "username0"
    }
  ],
  "publicUrls": [
    {
      "encrypted": false,
      "password": "password6",
      "url": "url6",
      "username": "username2"
    }
  ]
}
```

