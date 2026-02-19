
# Uninstall Android App Details

*This model accepts additional fields of type object.*

## Structure

`UninstallAndroidAppDetails`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AppId` | `string` | Optional | The unique identifier of the app to be uninstalled. |
| `Type` | [`Type61?`](../../doc/models/type-61.md) | Optional | Type of terminal action: Uninstall an Android app.<br><br>**Default**: `Type61.UninstallAndroidApp` |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "type": "UninstallAndroidApp",
  "appId": "appId0",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

