
# Install Android App Details

## Structure

`InstallAndroidAppDetails`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AppId` | `string` | Optional | The unique identifier of the app to be installed. |
| `Type` | [`Type27?`](../../doc/models/type-27.md) | Optional | Type of terminal action: Install an Android app.<br><br>**Default**: `Type27.InstallAndroidApp` |

## Example (as JSON)

```json
{
  "type": "InstallAndroidApp",
  "appId": "appId6"
}
```

