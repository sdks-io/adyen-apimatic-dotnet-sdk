
# Receipt Options

## Structure

`ReceiptOptions`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Logo` | `string` | Optional | The receipt logo converted to a Base64-encoded string. The image must be a .bmp file of < 256 KB, dimensions 240 (H) x 384 (W) px.<br><br>**Constraints**: *Maximum Length*: `350000` |
| `PromptBeforePrinting` | `bool?` | Optional | Indicates whether a screen appears asking if you want to print the shopper receipt. |
| `QrCodeData` | `string` | Optional | Data to print on the receipt as a QR code. This can include static text and the following variables:<br><br>- `${merchantreference}`: the merchant reference of the transaction.<br>- `${pspreference}`: the PSP reference of the transaction.<br><br>For example, **http://www.example.com/order/${pspreference}/${merchantreference}**. |

## Example (as JSON)

```json
{
  "logo": "logo8",
  "promptBeforePrinting": false,
  "qrCodeData": "qrCodeData8"
}
```

