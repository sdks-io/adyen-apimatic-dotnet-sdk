
# Android Pay

## Structure

`AndroidPay`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `CheckoutAttemptId` | `string` | Optional | The checkout attempt identifier. |
| `SdkData` | `string` | Optional | Base64-encoded JSON object containing SDK related parameters required by the SDK<br><br>**Constraints**: *Maximum Length*: `50000` |
| `Type` | [`Type5?`](../../doc/models/type-5.md) | Optional | **androidpay**<br><br>**Default**: `Type5.androidpay` |

## Example (as JSON)

```json
{
  "type": "androidpay",
  "checkoutAttemptId": "checkoutAttemptId2",
  "sdkData": "sdkData4"
}
```

