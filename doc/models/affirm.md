
# Affirm

## Structure

`Affirm`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `CheckoutAttemptId` | `string` | Optional | The checkout attempt identifier. |
| `SdkData` | `string` | Optional | Base64-encoded JSON object containing SDK related parameters required by the SDK<br><br>**Constraints**: *Maximum Length*: `50000` |
| `Type` | [`Type1?`](../../doc/models/type-1.md) | Optional | **affirm**<br><br>**Default**: `Type1.affirm` |

## Example (as JSON)

```json
{
  "type": "affirm",
  "checkoutAttemptId": "checkoutAttemptId6",
  "sdkData": "sdkData0"
}
```

