
# Browser Info 2

The shopper's browser information.

> For 3D Secure, the full object is required for web integrations. For mobile app integrations, include the `userAgent` and `acceptHeader` fields to indicate  that your integration can support a redirect in case a payment is routed to 3D Secure 2 redirect.

## Structure

`BrowserInfo2`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AcceptHeader` | `string` | Required | The accept header value of the shopper's browser. |
| `ColorDepth` | `int` | Required | The color depth of the shopper's browser in bits per pixel. This should be obtained by using the browser's `screen.colorDepth` property. Accepted values: 1, 4, 8, 15, 16, 24, 30, 32 or 48 bit color depth. |
| `JavaEnabled` | `bool` | Required | Boolean value indicating if the shopper's browser is able to execute Java. |
| `JavaScriptEnabled` | `bool?` | Optional | Boolean value indicating if the shopper's browser is able to execute JavaScript. A default 'true' value is assumed if the field is not present.<br><br>**Default**: `true` |
| `Language` | `string` | Required | The `navigator.language` value of the shopper's browser (as defined in IETF BCP 47). |
| `ScreenHeight` | `int` | Required | The total height of the shopper's device screen in pixels. |
| `ScreenWidth` | `int` | Required | The total width of the shopper's device screen in pixels. |
| `TimeZoneOffset` | `int` | Required | Time difference between UTC time and the shopper's browser local time, in minutes. |
| `UserAgent` | `string` | Required | The user agent value of the shopper's browser. |

## Example (as JSON)

```json
{
  "acceptHeader": "acceptHeader8",
  "colorDepth": 12,
  "javaEnabled": false,
  "javaScriptEnabled": true,
  "language": "language2",
  "screenHeight": 38,
  "screenWidth": 18,
  "timeZoneOffset": 70,
  "userAgent": "userAgent6"
}
```

