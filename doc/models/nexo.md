
# Nexo

## Structure

`Nexo`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `DisplayUrls` | [`NotificationUrl2`](../../doc/models/notification-url-2.md) | Optional | The list of local and public URLs to send display notifications to when using Terminal API. |
| `EncryptionKey` | [`Key1`](../../doc/models/key-1.md) | Optional | The key you share with Adyen to secure local communications when using Terminal API. |
| `EventUrls` | [`EventUrl2`](../../doc/models/event-url-2.md) | Optional | The list of local and public URLs to send event notifications to when using Terminal API. |
| `NexoEventUrls` | `List<string>` | Optional | One or more URLs to send event messages to when using Terminal API. |
| `Notification` | [`Notification2`](../../doc/models/notification-2.md) | Optional | Configures sending event notifications by pressing a button on a terminal, for example used for pay-at-table. |

## Example (as JSON)

```json
{
  "displayUrls": {
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
  },
  "encryptionKey": {
    "identifier": "identifier6",
    "passphrase": "passphrase6",
    "version": 8
  },
  "eventUrls": {
    "eventLocalUrls": [
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
    "eventPublicUrls": [
      {
        "encrypted": false,
        "password": "password8",
        "url": "url8",
        "username": "username4"
      }
    ]
  },
  "nexoEventUrls": [
    "nexoEventUrls2"
  ],
  "notification": {
    "category": "SaleWakeUp",
    "details": "details2",
    "enabled": false,
    "showButton": false,
    "title": "title2"
  }
}
```

