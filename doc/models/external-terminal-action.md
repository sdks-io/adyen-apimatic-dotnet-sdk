
# External Terminal Action

## Structure

`ExternalTerminalAction`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ActionType` | `string` | Optional | The type of terminal action: **InstallAndroidApp**, **UninstallAndroidApp**, **InstallAndroidCertificate**, or **UninstallAndroidCertificate**. |
| `Config` | `string` | Optional | Technical information about the terminal action. |
| `ConfirmedAt` | `DateTime?` | Optional | The date and time when the action was carried out. |
| `Id` | `string` | Optional | The unique ID of the terminal action. |
| `Result` | `string` | Optional | The result message for the action. |
| `ScheduledAt` | `DateTime?` | Optional | The date and time when the action was scheduled to happen. |
| `Status` | `string` | Optional | The status of the terminal action: **pending**, **successful**, **failed**, **cancelled**, or **tryLater**. |
| `TerminalId` | `string` | Optional | The unique ID of the terminal that the action applies to. |

## Example (as JSON)

```json
{
  "actionType": "actionType6",
  "config": "config2",
  "confirmedAt": "2016-03-13T12:52:32.123Z",
  "id": "id6",
  "result": "result0"
}
```

