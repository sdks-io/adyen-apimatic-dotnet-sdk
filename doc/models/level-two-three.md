
# Level Two Three

## Structure

`LevelTwoThree`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `CustomerReferenceNumber` | `string` | Optional | The reference number to identify the customer and their order.<br><br>* Format: ASCII<br>* Max length: 25 characters<br>* Must not start with a space or be all spaces.<br>* Must not be all zeros. |
| `Destination` | [`Destination1`](../../doc/models/destination-1.md) | Optional | The destination address information. |
| `DutyAmount` | `long?` | Optional | The duty tax amount, in [minor units](https://docs.adyen.com/development-resources/currency-codes).<br><br>* For example, 2000 means USD 20.00.<br>* Encoding: Numeric<br>* Max value: 10000000000 |
| `FreightAmount` | `long?` | Optional | The shipping amount, in [minor units](https://docs.adyen.com/development-resources/currency-codes).<br><br>* For example, 2000 means USD 20.00.<br>* Encoding: Numeric<br>* Max value: 10000000000 |
| `ItemDetailLines` | [`List<ItemDetailLine>`](../../doc/models/item-detail-line.md) | Optional | The list of item detail lines. |
| `OrderDate` | `DateTime?` | Optional | The date of the order.<br><br>* Min Length: 10 characters<br>* Max Length: 10 characters<br>* Format [ISO 8601](https://www.w3.org/TR/NOTE-datetime): yyyy-MM-dd |
| `ShipFromPostalCode` | `string` | Optional | The postal code of the address where the item is shipped from.<br><br>* Encoding: ASCII<br>* Max length: 10 characters<br>* For the US, it must be in five or nine digits format. For example, 10001 or 10001-0000.<br>* For Canada, it must be in 6 digits format. For example, M4B 1G5. |
| `TotalTaxAmount` | `long?` | Optional | The amount of state or provincial [tax included in the total transaction amount](https://docs.adyen.com/payment-methods/cards/enhanced-scheme-data/l2-l3#requirements-to-send-level-2-3-esd), in [minor units](https://docs.adyen.com/development-resources/currency-codes).<br><br>* For example, 2000 means USD 20.00.<br>* Encoding: Numeric<br>* Max value: 10000000000<br>* For L2 data: must not be all zeroes.<br>* For L3 data: can be zero. |

## Example (as JSON)

```json
{
  "customerReferenceNumber": "customerReferenceNumber0",
  "destination": {
    "countryCode": "countryCode0",
    "postalCode": "postalCode6",
    "stateOrProvince": "stateOrProvince2"
  },
  "dutyAmount": 68,
  "freightAmount": 46,
  "itemDetailLines": [
    {
      "commodityCode": "commodityCode4",
      "description": "description8",
      "discountAmount": 220,
      "productCode": "productCode0",
      "quantity": 184
    },
    {
      "commodityCode": "commodityCode4",
      "description": "description8",
      "discountAmount": 220,
      "productCode": "productCode0",
      "quantity": 184
    }
  ]
}
```

