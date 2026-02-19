
# Enhanced Scheme Data

## Structure

`EnhancedSchemeData`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Airline` | [`Airline1`](../../doc/models/airline-1.md) | Optional | [Airline enhanced scheme data](https://docs.adyen.com/payment-methods/cards/enhanced-scheme-data/airline/) that may be required for processing the transaction and/or for interchange savings. |
| `LevelTwoThree` | [`LevelTwoThree2`](../../doc/models/level-two-three-2.md) | Optional | [Level 2 and Level 3 enhanced scheme data](https://docs.adyen.com/payment-methods/cards/enhanced-scheme-data/l2-l3/) that may be required for processing the transaction and/or for interchange savings. |

## Example (as JSON)

```json
{
  "airline": {
    "agency": {
      "invoiceNumber": "invoiceNumber6",
      "planName": "planName6"
    },
    "boardingFee": 160,
    "code": "code0",
    "computerizedReservationSystem": "computerizedReservationSystem4",
    "customerReferenceNumber": "customerReferenceNumber6",
    "passengerName": "passengerName0"
  },
  "levelTwoThree": {
    "customerReferenceNumber": "customerReferenceNumber0",
    "destination": {
      "countryCode": "countryCode0",
      "postalCode": "postalCode6",
      "stateOrProvince": "stateOrProvince2"
    },
    "dutyAmount": 234,
    "freightAmount": 136,
    "itemDetailLines": [
      {
        "commodityCode": "commodityCode4",
        "description": "description8",
        "discountAmount": 220,
        "productCode": "productCode0",
        "quantity": 184
      }
    ]
  }
}
```

