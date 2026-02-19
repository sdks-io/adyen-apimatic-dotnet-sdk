
# Payment Details

## Structure

`PaymentDetails`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `CheckoutAttemptId` | `string` | Optional | The checkout attempt identifier. |
| `SdkData` | `string` | Optional | Base64-encoded JSON object containing SDK related parameters required by the SDK<br><br>**Constraints**: *Maximum Length*: `50000` |
| `Type` | [`Type38?`](../../doc/models/type-38.md) | Optional | The payment method type. |

## Example (as JSON)

```json
{
  "checkoutAttemptId": "checkoutAttemptId2",
  "sdkData": "sdkData4",
  "type": "molpay_boost"
}
```

