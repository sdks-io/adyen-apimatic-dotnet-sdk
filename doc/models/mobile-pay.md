
# Mobile Pay

## Structure

`MobilePay`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `CheckoutAttemptId` | `string` | Optional | The checkout attempt identifier. |
| `SdkData` | `string` | Optional | Base64-encoded JSON object containing SDK related parameters required by the SDK<br><br>**Constraints**: *Maximum Length*: `50000` |
| `Type` | [`Type32?`](../../doc/models/type-32.md) | Optional | **mobilepay**<br><br>**Default**: `Type32.mobilepay` |

## Example (as JSON)

```json
{
  "type": "mobilepay",
  "checkoutAttemptId": "checkoutAttemptId0",
  "sdkData": "sdkData6"
}
```

