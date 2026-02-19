
# Additional Settings

## Structure

`AdditionalSettings`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `IncludeEventCodes` | `List<string>` | Optional | Object containing list of event codes for which the notification will be sent. |
| `Properties` | `Dictionary<string, bool>` | Optional | Object containing boolean key-value pairs. The key can be any [standard webhook additional setting](https://docs.adyen.com/development-resources/webhooks/additional-settings), and the value indicates if the setting is enabled.<br>For example, `includeCaptureDelayHours`: **true** means the standard notifications you get will contain the number of hours remaining until the payment will be captured. |

## Example (as JSON)

```json
{
  "includeEventCodes": [
    "includeEventCodes6",
    "includeEventCodes7"
  ],
  "properties": {
    "key0": false,
    "key1": true,
    "key2": false
  }
}
```

