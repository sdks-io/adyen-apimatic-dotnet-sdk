
# Pay by Bank

## Structure

`PayByBank`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `CheckoutAttemptId` | `string` | Optional | The checkout attempt identifier. |
| `Issuer` | `string` | Optional | The PayByBank issuer value of the shopper's selected bank. |
| `SdkData` | `string` | Optional | Base64-encoded JSON object containing SDK related parameters required by the SDK<br><br>**Constraints**: *Maximum Length*: `50000` |
| `Type` | `string` | Required, Constant | **paybybank**<br><br>**Value**: `"paybybank"` |

## Example (as JSON)

```json
{
  "type": "paybybank",
  "checkoutAttemptId": "checkoutAttemptId2",
  "issuer": "issuer6",
  "sdkData": "sdkData4"
}
```

