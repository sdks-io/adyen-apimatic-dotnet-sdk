
# Bill Desk

## Structure

`BillDesk`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `CheckoutAttemptId` | `string` | Optional | The checkout attempt identifier. |
| `Issuer` | `string` | Required | The issuer id of the shopper's selected bank. |
| `SdkData` | `string` | Optional | Base64-encoded JSON object containing SDK related parameters required by the SDK<br><br>**Constraints**: *Maximum Length*: `50000` |
| `Type` | [`Type10`](../../doc/models/type-10.md) | Required | **billdesk** |

## Example (as JSON)

```json
{
  "checkoutAttemptId": "checkoutAttemptId6",
  "issuer": "issuer0",
  "sdkData": "sdkData0",
  "type": "billdesk_online"
}
```

