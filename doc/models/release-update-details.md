
# Release Update Details

## Structure

`ReleaseUpdateDetails`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Type` | [`Type53?`](../../doc/models/type-53.md) | Optional | Type of terminal action: Update Release.<br><br>**Default**: `Type53.ReleaseUpdate` |
| `UpdateAtFirstMaintenanceCall` | `bool?` | Optional | Boolean flag that tells if the terminal should update at the first next maintenance call. If false, terminal will update on its configured reboot time. |

## Example (as JSON)

```json
{
  "type": "ReleaseUpdate",
  "updateAtFirstMaintenanceCall": false
}
```

