
# Voucher

## Structure

`Voucher`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `CheckoutAttemptId` | `string` | Optional | The checkout attempt identifier. |
| `FirstName` | `string` | Required | The shopper's first name. |
| `LastName` | `string` | Required | The shopper's last name. |
| `SdkData` | `string` | Optional | Base64-encoded JSON object containing SDK related parameters required by the SDK<br><br>**Constraints**: *Maximum Length*: `50000` |
| `ShopperEmail` | `string` | Required | The shopper's email. |
| `TelephoneNumber` | `string` | Required | The shopper's contact number. It must have an international number format, for example **+31 20 779 1846**. Formats like **+31 (0)20 779 1846** or **0031 20 779 1846** are not accepted. |
| `Type` | [`Type24`](../../doc/models/type-24.md) | Required | **econtextvoucher** |

## Example (as JSON)

```json
{
  "checkoutAttemptId": "checkoutAttemptId4",
  "firstName": "firstName6",
  "lastName": "lastName2",
  "sdkData": "sdkData2",
  "shopperEmail": "shopperEmail2",
  "telephoneNumber": "telephoneNumber0",
  "type": "econtext_stores"
}
```

