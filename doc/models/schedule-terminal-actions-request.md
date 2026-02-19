
# Schedule Terminal Actions Request

## Structure

`ScheduleTerminalActionsRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ActionDetails` | [`ScheduleTerminalActionsRequestActionDetails`](../../doc/models/containers/schedule-terminal-actions-request-action-details.md) | Optional | This is a container for one-of cases. |
| `ScheduledAt` | `string` | Optional | The date and time when the action should happen.<br>Format: [RFC 3339](https://www.rfc-editor.org/rfc/rfc3339), but without the **Z** before the time offset. For example, **2021-11-15T12:16:21+0100**<br>The action is sent with the first [maintenance call](https://docs.adyen.com/point-of-sale/automating-terminal-management/terminal-actions-api#when-actions-take-effect) after the specified date and time in the time zone of the terminal.<br>An empty value causes the action to be sent as soon as possible: at the next maintenance call. |
| `StoreId` | `string` | Optional | The unique ID of the [store](https://docs.adyen.com/api-explorer/#/ManagementService/latest/get/stores). If present, all terminals in the `terminalIds` list must be assigned to this store. |
| `TerminalIds` | `List<string>` | Optional | A list of unique IDs of the terminals to apply the action to. You can extract the IDs from the [GET `/terminals`](https://docs.adyen.com/api-explorer/#/ManagementService/latest/get/terminals) response. Maximum length: 100 IDs. |

## Example (as JSON)

```json
{
  "actionDetails": {
    "type": "ForceReboot"
  },
  "scheduledAt": "scheduledAt6",
  "storeId": "storeId4",
  "terminalIds": [
    "terminalIds2",
    "terminalIds3"
  ]
}
```

