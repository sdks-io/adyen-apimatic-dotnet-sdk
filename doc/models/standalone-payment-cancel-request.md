
# Standalone Payment Cancel Request

## Structure

`StandalonePaymentCancelRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ApplicationInfo` | [`ApplicationInfo1`](../../doc/models/application-info-1.md) | Optional | Information about your application. For more details, see [Building Adyen solutions](https://docs.adyen.com/development-resources/building-adyen-solutions). |
| `EnhancedSchemeData` | [`EnhancedSchemeData1`](../../doc/models/enhanced-scheme-data-1.md) | Optional | Enhanced scheme data that may be required for processing the payment. For example, airline information. |
| `MerchantAccount` | `string` | Required | The merchant account that is used to process the payment. |
| `PaymentReference` | `string` | Required | The [`reference`](https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/payments__reqParam_reference) of the payment that you want to cancel. |
| `Reference` | `string` | Optional | Your reference for the cancel request. Maximum length: 80 characters. |

## Example (as JSON)

```json
{
  "applicationInfo": {
    "adyenLibrary": {
      "name": "name8",
      "version": "version4"
    },
    "adyenPaymentSource": {
      "name": "name2",
      "version": "version8"
    },
    "externalPlatform": {
      "integrator": "integrator0",
      "name": "name4",
      "version": "version0"
    },
    "merchantApplication": {
      "name": "name2",
      "version": "version8"
    },
    "merchantDevice": {
      "os": "os4",
      "osVersion": "osVersion6",
      "reference": "reference8"
    }
  },
  "enhancedSchemeData": {
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
  },
  "merchantAccount": "merchantAccount4",
  "paymentReference": "paymentReference2",
  "reference": "reference2"
}
```

