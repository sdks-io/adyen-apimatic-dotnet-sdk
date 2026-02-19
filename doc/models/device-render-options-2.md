
# Device Render Options 2

Display options for the 3D Secure 2 SDK.
Optional and only for `deviceChannel` **app**.

## Structure

`DeviceRenderOptions2`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `SdkInterface` | [`SdkInterface?`](../../doc/models/sdk-interface.md) | Optional | Supported SDK interface types.<br>Allowed values:<br><br>* native<br>* html<br>* both<br><br>**Default**: `SdkInterface.both` |
| `SdkUiType` | [`List<SdkUiType>`](../../doc/models/sdk-ui-type.md) | Optional | UI types supported for displaying specific challenges.<br>Allowed values:<br><br>* text<br>* singleSelect<br>* outOfBand<br>* otherHtml<br>* multiSelect |

## Example (as JSON)

```json
{
  "sdkInterface": "both",
  "sdkUiType": [
    "text",
    "multiSelect",
    "otherHtml"
  ]
}
```

