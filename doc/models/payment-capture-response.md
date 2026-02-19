
# Payment Capture Response

## Structure

`PaymentCaptureResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Amount` | [`Amount32`](../../doc/models/amount-32.md) | Required | The captured amount. |
| `LineItems` | [`List<LineItem>`](../../doc/models/line-item.md) | Optional | Price and product information of the refunded items, required for [partial refunds](https://docs.adyen.com/online-payments/refund#refund-a-payment).<br><br>> This field is required for partial refunds with 3x 4x Oney, Affirm, Afterpay, Atome, Clearpay, Klarna, Ratepay, Walley, and Zip. |
| `MerchantAccount` | `string` | Required | The merchant account that is used to process the payment. |
| `PaymentPspReference` | `string` | Required | The [`pspReference`](https://docs.adyen.com/api-explorer/Checkout/latest/post/payments#responses-200-pspReference) of the payment to capture. |
| `PlatformChargebackLogic` | [`PlatformChargebackLogic1`](../../doc/models/platform-chargeback-logic-1.md) | Optional | Defines how to book chargebacks when using [Adyen for Platforms](https://docs.adyen.com/adyen-for-platforms-model). |
| `PspReference` | `string` | Required | Adyen's 16-character reference associated with the capture request. |
| `Reference` | `string` | Optional | Your reference for the capture request. |
| `Splits` | [`List<Split>`](../../doc/models/split.md) | Optional | An array of objects specifying how the amount should be split between accounts when using Adyen for Platforms. For more information, see how to process payments for [marketplaces](https://docs.adyen.com/marketplaces/split-payments) or [platforms](https://docs.adyen.com/platforms/online-payments/split-payments/). |
| `Status` | `string` | Required, Constant | The status of your request. This will always have the value **received**.<br><br>**Value**: `"received"` |
| `SubMerchants` | [`List<SubMerchantInfo>`](../../doc/models/sub-merchant-info.md) | Optional | List of sub-merchants. |

## Example (as JSON)

```json
{
  "amount": {
    "currency": "currency2",
    "value": 110
  },
  "merchantAccount": "merchantAccount0",
  "paymentPspReference": "paymentPspReference6",
  "pspReference": "pspReference0",
  "status": "received",
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
  "platformChargebackLogic": {
    "behavior": "deductAccordingToSplitRatio",
    "costAllocationAccount": "costAllocationAccount8",
    "targetAccount": "targetAccount6"
  },
  "reference": "reference4",
  "splits": [
    {
      "account": "account2",
      "amount": {
        "currency": "currency2",
        "value": 110
      },
      "description": "description2",
      "reference": "reference2",
      "type": "Default"
    },
    {
      "account": "account2",
      "amount": {
        "currency": "currency2",
        "value": 110
      },
      "description": "description2",
      "reference": "reference2",
      "type": "Default"
    }
  ],
  "subMerchants": [
    {
      "address": {
        "city": "city6",
        "country": "country0",
        "houseNumberOrName": "houseNumberOrName4",
        "postalCode": "postalCode8",
        "stateOrProvince": "stateOrProvince4",
        "street": "street6"
      },
      "amount": {
        "currency": "currency2",
        "value": 110
      },
      "email": "email6",
      "id": "id0",
      "mcc": "mcc0"
    },
    {
      "address": {
        "city": "city6",
        "country": "country0",
        "houseNumberOrName": "houseNumberOrName4",
        "postalCode": "postalCode8",
        "stateOrProvince": "stateOrProvince4",
        "street": "street6"
      },
      "amount": {
        "currency": "currency2",
        "value": 110
      },
      "email": "email6",
      "id": "id0",
      "mcc": "mcc0"
    },
    {
      "address": {
        "city": "city6",
        "country": "country0",
        "houseNumberOrName": "houseNumberOrName4",
        "postalCode": "postalCode8",
        "stateOrProvince": "stateOrProvince4",
        "street": "street6"
      },
      "amount": {
        "currency": "currency2",
        "value": 110
      },
      "email": "email6",
      "id": "id0",
      "mcc": "mcc0"
    }
  ]
}
```

