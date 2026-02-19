
# Additional Data Open Invoice

## Structure

`AdditionalDataOpenInvoice`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `OpeninvoicedataMerchantData` | `string` | Optional | Holds different merchant data points like product, purchase, customer, and so on. It takes data in a Base64 encoded string.<br><br>The `merchantData` parameter needs to be added to the `openinvoicedata` signature at the end.<br><br>Since the field is optional, if it's not included it does not impact computing the merchant signature.<br><br>Applies only to Klarna.<br><br>You can contact Klarna for the format and structure of the string. |
| `OpeninvoicedataNumberOfLines` | `string` | Optional | The number of invoice lines included in `openinvoicedata`.<br><br>There needs to be at least one line, so `numberOfLines` needs to be at least 1. |
| `OpeninvoicedataRecipientFirstName` | `string` | Optional | First name of the recipient. If the delivery address and the billing address are different, specify the `recipientFirstName` and `recipientLastName` to share the delivery address with Klarna. Otherwise, only the billing address is shared with Klarna. |
| `OpeninvoicedataRecipientLastName` | `string` | Optional | Last name of the recipient. If the delivery address and the billing address are different, specify the `recipientFirstName` and `recipientLastName` to share the delivery address with Klarna. Otherwise, only the billing address is shared with Klarna. |
| `OpeninvoicedataLineItemNrCurrencyCode` | `string` | Optional | The three-character ISO currency code. |
| `OpeninvoicedataLineItemNrDescription` | `string` | Optional | A text description of the product the invoice line refers to. |
| `OpeninvoicedataLineItemNrItemAmount` | `string` | Optional | The price for one item in the invoice line, represented in minor units.<br><br>The due amount for the item, VAT excluded. |
| `OpeninvoicedataLineItemNrItemId` | `string` | Optional | A unique id for this item. Required for RatePay if the description of each item is not unique. |
| `OpeninvoicedataLineItemNrItemVatAmount` | `string` | Optional | The VAT due for one item in the invoice line, represented in minor units. |
| `OpeninvoicedataLineItemNrItemVatPercentage` | `string` | Optional | The VAT percentage for one item in the invoice line, represented in minor units.<br><br>For example, 19% VAT is specified as 1900. |
| `OpeninvoicedataLineItemNrNumberOfItems` | `string` | Optional | The number of units purchased of a specific product. |
| `OpeninvoicedataLineItemNrReturnShippingCompany` | `string` | Optional | Name of the shipping company handling the the return shipment. |
| `OpeninvoicedataLineItemNrReturnTrackingNumber` | `string` | Optional | The tracking number for the return of the shipment. |
| `OpeninvoicedataLineItemNrReturnTrackingUri` | `string` | Optional | URI where the customer can track the return of their shipment. |
| `OpeninvoicedataLineItemNrShippingCompany` | `string` | Optional | Name of the shipping company handling the delivery. |
| `OpeninvoicedataLineItemNrShippingMethod` | `string` | Optional | Shipping method. |
| `OpeninvoicedataLineItemNrTrackingNumber` | `string` | Optional | The tracking number for the shipment. |
| `OpeninvoicedataLineItemNrTrackingUri` | `string` | Optional | URI where the customer can track their shipment. |

## Example (as JSON)

```json
{
  "openinvoicedata.merchantData": "openinvoicedata.merchantData6",
  "openinvoicedata.numberOfLines": "openinvoicedata.numberOfLines8",
  "openinvoicedata.recipientFirstName": "openinvoicedata.recipientFirstName6",
  "openinvoicedata.recipientLastName": "openinvoicedata.recipientLastName6",
  "openinvoicedataLine[itemNr].currencyCode": "openinvoicedataLine[itemNr].currencyCode6"
}
```

