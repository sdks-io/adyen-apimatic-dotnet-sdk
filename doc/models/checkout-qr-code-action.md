
# Checkout Qr Code Action

## Structure

`CheckoutQrCodeAction`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ExpiresAt` | `string` | Optional | Expiry time of the QR code. |
| `PaymentData` | `string` | Optional | Encoded payment data. |
| `PaymentMethodType` | `string` | Optional | Specifies the payment method. |
| `QrCodeData` | `string` | Optional | The contents of the QR code as a UTF8 string. |
| `Type` | `string` | Required, Constant | **qrCode**<br><br>**Value**: `"qrCode"` |
| `Url` | `string` | Optional | Specifies the URL to redirect to. |

## Example (as JSON)

```json
{
  "type": "qrCode",
  "expiresAt": "expiresAt8",
  "paymentData": "paymentData4",
  "paymentMethodType": "paymentMethodType4",
  "qrCodeData": "qrCodeData4",
  "url": "url6"
}
```

