
# Payment Capture Request

## Structure

`PaymentCaptureRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Amount` | [`Amount30`](../../doc/models/amount-30.md) | Required | The amount that you want to capture. The `currency` must match the currency used in authorisation, the `value` must be smaller than or equal to the authorised amount. |
| `ApplicationInfo` | [`ApplicationInfo1`](../../doc/models/application-info-1.md) | Optional | Information about your application. For more details, see [Building Adyen solutions](https://docs.adyen.com/development-resources/building-adyen-solutions). |
| `EnhancedSchemeData` | [`EnhancedSchemeData1`](../../doc/models/enhanced-scheme-data-1.md) | Optional | Enhanced scheme data that may be required for processing the payment. For example, airline information. |
| `LineItems` | [`List<LineItem>`](../../doc/models/line-item.md) | Optional | Price and product information of the refunded items, required for [partial refunds](https://docs.adyen.com/online-payments/refund#refund-a-payment).<br><br>> This field is required for partial refunds with 3x 4x Oney, Affirm, Afterpay, Atome, Clearpay, Klarna, Ratepay, Walley, and Zip. |
| `MerchantAccount` | `string` | Required | The merchant account that is used to process the payment. |
| `PlatformChargebackLogic` | [`PlatformChargebackLogic1`](../../doc/models/platform-chargeback-logic-1.md) | Optional | Defines how to book chargebacks when using [Adyen for Platforms](https://docs.adyen.com/adyen-for-platforms-model). |
| `Reference` | `string` | Optional | Your reference for the capture request. Maximum length: 80 characters. |
| `Splits` | [`List<Split>`](../../doc/models/split.md) | Optional | An array of objects specifying how the amount should be split between accounts when using Adyen for Platforms. For more information, see how to process payments for [marketplaces](https://docs.adyen.com/marketplaces/split-payments) or [platforms](https://docs.adyen.com/platforms/online-payments/split-payments/). |
| `SubMerchants` | [`List<SubMerchantInfo>`](../../doc/models/sub-merchant-info.md) | Optional | A List of sub-merchants. |

## Example (as JSON)

```json
{
  "amount": {
    "currency": "currency2",
    "value": 110
  },
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
  "lineItems": [
    {
      "amountExcludingTax": 38,
      "amountIncludingTax": 148,
      "brand": "brand6",
      "color": "color6",
      "description": "description2"
    },
    {
      "amountExcludingTax": 38,
      "amountIncludingTax": 148,
      "brand": "brand6",
      "color": "color6",
      "description": "description2"
    }
  ],
  "merchantAccount": "merchantAccount8",
  "platformChargebackLogic": {
    "behavior": "deductAccordingToSplitRatio",
    "costAllocationAccount": "costAllocationAccount8",
    "targetAccount": "targetAccount6"
  },
  "reference": "reference4"
}
```

