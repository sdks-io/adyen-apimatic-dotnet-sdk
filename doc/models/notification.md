
# Notification

## Structure

`Notification`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Category` | [`Category?`](../../doc/models/category.md) | Optional | The type of event notification sent when you select the notification button. |
| `Details` | `string` | Optional | The text shown in the prompt which opens when you select the notification button. For example, the description of the input box for pay-at-table. |
| `Enabled` | `bool?` | Optional | Enables sending event notifications either by pressing the Confirm key on terminals with a keypad or by tapping the event notification button on the terminal screen. |
| `ShowButton` | `bool?` | Optional | Shows or hides the event notification button on the screen of terminal models that have a keypad. |
| `Title` | `string` | Optional | The name of the notification button on the terminal screen. |

## Example (as JSON)

```json
{
  "category": "SaleWakeUp",
  "details": "details6",
  "enabled": false,
  "showButton": false,
  "title": "title2"
}
```

