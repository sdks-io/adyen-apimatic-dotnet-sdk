
# Mol Pay

## Structure

`MolPay`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `CheckoutAttemptId` | `string` | Optional | The checkout attempt identifier. |
| `Issuer` | `string` | Required | The shopper's bank. Specify this with the issuer value that corresponds to this bank. |
| `SdkData` | `string` | Optional | Base64-encoded JSON object containing SDK related parameters required by the SDK<br><br>**Constraints**: *Maximum Length*: `50000` |
| `Type` | [`Type33`](../../doc/models/type-33.md) | Required | **molpay** |

## Example (as JSON)

```json
{
  "checkoutAttemptId": "checkoutAttemptId6",
  "issuer": "issuer0",
  "sdkData": "sdkData0",
  "type": "molpay_ebanking_fpx_MY"
}
```

