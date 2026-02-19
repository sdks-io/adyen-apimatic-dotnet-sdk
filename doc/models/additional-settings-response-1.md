
# Additional Settings Response 1

Additional shopper and transaction information to be included in your [standard webhooks](https://docs.adyen.com/development-resources/webhooks/webhook-types/#event-codes). Find out more about the available [additional settings](https://docs.adyen.com/development-resources/webhooks/additional-settings).

## Structure

`AdditionalSettingsResponse1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ExcludeEventCodes` | `List<string>` | Optional | Object containing list of event codes for which the notification will not be sent. |
| `IncludeEventCodes` | `List<string>` | Optional | Object containing list of event codes for which the notification will be sent. |
| `Properties` | `Dictionary<string, bool>` | Optional | Object containing boolean key-value pairs. The key can be any [standard webhook additional setting](https://docs.adyen.com/development-resources/webhooks/additional-settings), and the value indicates if the setting is enabled.<br>For example, `includeCaptureDelayHours`: **true** means the standard notifications you get will contain the number of hours remaining until the payment will be captured. |

## Example (as JSON)

```json
{
  "excludeEventCodes": [
    "excludeEventCodes0",
    "excludeEventCodes1"
  ],
  "includeEventCodes": [
    "includeEventCodes8",
    "includeEventCodes9"
  ],
  "properties": {
    "key0": false,
    "key1": true,
    "key2": false
  }
}
```

