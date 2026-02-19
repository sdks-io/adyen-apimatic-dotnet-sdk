
# Mb Way

## Structure

`MbWay`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `CheckoutAttemptId` | `string` | Optional | The checkout attempt identifier. |
| `SdkData` | `string` | Optional | Base64-encoded JSON object containing SDK related parameters required by the SDK<br><br>**Constraints**: *Maximum Length*: `50000` |
| `ShopperEmail` | `string` | Required | - |
| `TelephoneNumber` | `string` | Required | - |
| `Type` | [`Type31?`](../../doc/models/type-31.md) | Optional | **mbway**<br><br>**Default**: `Type31.mbway` |

## Example (as JSON)

```json
{
  "shopperEmail": "shopperEmail4",
  "telephoneNumber": "telephoneNumber4",
  "type": "mbway",
  "checkoutAttemptId": "checkoutAttemptId8",
  "sdkData": "sdkData8"
}
```

