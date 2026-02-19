
# Vipps Info

## Structure

`VippsInfo`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Logo` | `string` | Required | Vipps logo. Format: Base64-encoded string. |
| `SubscriptionCancelUrl` | `string` | Optional | Vipps subscription cancel url (required in case of [recurring payments](https://docs.adyen.com/online-payments/tokenization)) |

## Example (as JSON)

```json
{
  "logo": "logo8",
  "subscriptionCancelUrl": "subscriptionCancelUrl0"
}
```

