
# Receipt Printing 1

Transaction outcomes that you want the terminal to print a merchant receipt or a shopper receipt for.

## Structure

`ReceiptPrinting1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `MerchantApproved` | `bool?` | Optional | Print a merchant receipt when the payment is approved. |
| `MerchantCancelled` | `bool?` | Optional | Print a merchant receipt when the transaction is cancelled. |
| `MerchantCaptureApproved` | `bool?` | Optional | Print a merchant receipt when capturing the payment is approved. |
| `MerchantCaptureRefused` | `bool?` | Optional | Print a merchant receipt when capturing the payment is refused. |
| `MerchantRefundApproved` | `bool?` | Optional | Print a merchant receipt when the refund is approved. |
| `MerchantRefundRefused` | `bool?` | Optional | Print a merchant receipt when the refund is refused. |
| `MerchantRefused` | `bool?` | Optional | Print a merchant receipt when the payment is refused. |
| `MerchantVoid` | `bool?` | Optional | Print a merchant receipt when a previous transaction is voided. |
| `ShopperApproved` | `bool?` | Optional | Print a shopper receipt when the payment is approved. |
| `ShopperCancelled` | `bool?` | Optional | Print a shopper receipt when the transaction is cancelled. |
| `ShopperCaptureApproved` | `bool?` | Optional | Print a shopper receipt when capturing the payment is approved. |
| `ShopperCaptureRefused` | `bool?` | Optional | Print a shopper receipt when capturing the payment is refused. |
| `ShopperRefundApproved` | `bool?` | Optional | Print a shopper receipt when the refund is approved. |
| `ShopperRefundRefused` | `bool?` | Optional | Print a shopper receipt when the refund is refused. |
| `ShopperRefused` | `bool?` | Optional | Print a shopper receipt when the payment is refused. |
| `ShopperVoid` | `bool?` | Optional | Print a shopper receipt when a previous transaction is voided. |

## Example (as JSON)

```json
{
  "merchantApproved": false,
  "merchantCancelled": false,
  "merchantCaptureApproved": false,
  "merchantCaptureRefused": false,
  "merchantRefundApproved": false
}
```

