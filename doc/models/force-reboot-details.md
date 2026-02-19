
# Force Reboot Details

## Structure

`ForceRebootDetails`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Type` | [`Type13?`](../../doc/models/type-13.md) | Optional | The type of terminal action. The value **ForceReboot** triggers an immediate reboot of the specified terminal(s).<br><br>**Default**: `Type13.ForceReboot` |

## Example (as JSON)

```json
{
  "type": "ForceReboot"
}
```

