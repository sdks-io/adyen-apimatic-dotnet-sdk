
# Additional Data Level 23

## Structure

`AdditionalDataLevel23`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `EnhancedSchemeDataCustomerReference` | `string` | Optional | The reference number to identify the customer and their order.<br><br>* Encoding: ASCII<br>* Max length: 25 characters<br>* Must not start with a space or be all spaces.<br>* Must not be all zeros. |
| `EnhancedSchemeDataDestinationCountryCode` | `string` | Optional | The three-letter [ISO 3166-1 alpha-3 country code](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-3) for the destination address.<br><br>* Encoding: ASCII<br>* Fixed length: 3 characters |
| `EnhancedSchemeDataDestinationPostalCode` | `string` | Optional | The postal code of the destination address.<br><br>* Encoding: ASCII<br>* Max length: 10 characters<br>* Must not start with a space.<br>* For the US, it must be in five or nine digits format. For example, 10001 or 10001-0000.<br>* For Canada, it must be in 6 digits format. For example, M4B 1G5. |
| `EnhancedSchemeDataDestinationStateProvinceCode` | `string` | Optional | The state or province code of the destination address.<br><br>* Encoding: ASCII<br>* Max length: 3 characters<br>* Must not start with a space. |
| `EnhancedSchemeDataDutyAmount` | `string` | Optional | The duty tax amount, in [minor units](https://docs.adyen.com/development-resources/currency-codes).<br><br>* For example, 2000 means USD 20.00.<br>* Encoding: Numeric<br>* Max length: 12 characters |
| `EnhancedSchemeDataFreightAmount` | `string` | Optional | The shipping amount, in [minor units](https://docs.adyen.com/development-resources/currency-codes).<br><br>* For example, 2000 means USD 20.00.<br>* Encoding: Numeric<br>* Max length: 12 characters |
| `EnhancedSchemeDataItemDetailLineItemNrCommodityCode` | `string` | Optional | The code that identifies the item in a standardized commodity coding scheme. There are different commodity coding schemes:<br><br>* [UNSPSC commodity codes](https://www.ungm.org/public/unspsc)<br><br>* [HS commodity codes](https://www.wcoomd.org/en/topics/nomenclature/overview.aspx)<br><br>* [NAICS commodity codes](https://www.census.gov/naics/)<br><br>* [NAPCS commodity codes](https://www.census.gov/naics/napcs/)<br><br>* Encoding: ASCII<br><br>* Max length: 12 characters<br><br>* Must not start with a space or be all spaces.<br><br>* Must not be all zeros. |
| `EnhancedSchemeDataItemDetailLineItemNrDescription` | `string` | Optional | A description of the item, that provides details about the purchase.<br><br>For Visa transactions with level 3 ESD, the description must not be the same or very similar to your merchant name, or, consist only of common words like "product", or "service".<br><br>* Encoding: ASCII<br>* Max length: 26 characters<br>* Must not be a single character.<br>* Must not be blank.<br>* Must not be all special characters.<br>* Must not be blank.<br>* Must not start with a space or be all spaces.<br>* Must not be all zeros. |
| `EnhancedSchemeDataItemDetailLineItemNrDiscountAmount` | `string` | Optional | The discount amount, in [minor units](https://docs.adyen.com/development-resources/currency-codes).<br><br>* For example, 2000 means USD 20.00.<br>* Encoding: Numeric<br>* Max length: 12 characters |
| `EnhancedSchemeDataItemDetailLineItemNrProductCode` | `string` | Optional | The product code. Must be a unique product code associated with the item or service. This can be your unique code for the item, or the manufacturer's product code.<br><br>* Encoding: ASCII.<br>* Max length: 12 characters<br>* Must not start with a space or be all spaces.<br>* Must not be all zeros. |
| `EnhancedSchemeDataItemDetailLineItemNrQuantity` | `string` | Optional | The number of items. Must be an integer greater than zero.<br><br>* Encoding: Numeric<br>* Max length: 12 characters<br>* Must not start with a space or be all spaces. |
| `EnhancedSchemeDataItemDetailLineItemNrTotalAmount` | `string` | Optional | The total amount for the line item, in [minor units](https://docs.adyen.com/development-resources/currency-codes). See [Amount requirements for level 2/3 ESD](https://docs.adyen.com//payment-methods/cards/enhanced-scheme-data/l2-l3#amount-requirements) to learn more about how to calculate the line item total.<br><br>* For example, 2000 means USD 20.00.<br>* Max length: 12 characters<br>* Must not start with a space or be all spaces.<br>* Must not be all zeros. |
| `EnhancedSchemeDataItemDetailLineItemNrUnitOfMeasure` | `string` | Optional | The unit of measurement for an item.<br><br>* Encoding: ASCII<br>* Max length: 3 characters<br>* Must not start with a space or be all spaces.<br>* Must not be all zeros. |
| `EnhancedSchemeDataItemDetailLineItemNrUnitPrice` | `string` | Optional | The unit price in [minor units](https://docs.adyen.com/development-resources/currency-codes).<br><br>* For example, 2000 means USD 20.00.<br>* Encoding: Numeric<br>* Max length: 12 characters<br>* Must not be all zeros. |
| `EnhancedSchemeDataOrderDate` | `string` | Optional | The order date.<br><br>* Format: `ddMMyy`<br>* Encoding: ASCII<br>* Max length: 6 characters |
| `EnhancedSchemeDataShipFromPostalCode` | `string` | Optional | The postal code of the address where the item is shipped from.<br><br>* Encoding: ASCII<br>* Max length: 10 characters<br>* Must not start with a space or be all spaces.<br>* Must not be all zeros.For the US, it must be in five or nine digits format. For example, 10001 or 10001-0000.<br>* For Canada, it must be in 6 digits format. For example, M4B 1G5. |
| `EnhancedSchemeDataTotalTaxAmount` | `string` | Optional | The amount of state or provincial [tax included in the total transaction amount](https://docs.adyen.com/payment-methods/cards/enhanced-scheme-data/l2-l3#requirements-to-send-level-2-3-esd), in [minor units](https://docs.adyen.com/development-resources/currency-codes).<br><br>* For example, 2000 means USD 20.00.<br>* Encoding: Numeric<br>* Max length: 12 characters<br>* For L2 data: must not be all zeroes.<br>* For L3 data: can be zero. |

## Example (as JSON)

```json
{
  "enhancedSchemeData.customerReference": "enhancedSchemeData.customerReference4",
  "enhancedSchemeData.destinationCountryCode": "enhancedSchemeData.destinationCountryCode4",
  "enhancedSchemeData.destinationPostalCode": "enhancedSchemeData.destinationPostalCode6",
  "enhancedSchemeData.destinationStateProvinceCode": "enhancedSchemeData.destinationStateProvinceCode4",
  "enhancedSchemeData.dutyAmount": "enhancedSchemeData.dutyAmount4"
}
```

