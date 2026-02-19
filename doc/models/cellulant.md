
# Cellulant

## Structure

`Cellulant`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `CheckoutAttemptId` | `string` | Optional | The checkout attempt identifier. |
| `Issuer` | `string` | Optional | The Cellulant issuer. |
| `SdkData` | `string` | Optional | Base64-encoded JSON object containing SDK related parameters required by the SDK<br><br>**Constraints**: *Maximum Length*: `50000` |
| `Type` | [`Type15?`](../../doc/models/type-15.md) | Optional | **Cellulant**<br><br>**Default**: `Type15.cellulant` |

## Example (as JSON)

```json
{
  "type": "cellulant",
  "checkoutAttemptId": "checkoutAttemptId0",
  "issuer": "issuer4",
  "sdkData": "sdkData6"
}
```

