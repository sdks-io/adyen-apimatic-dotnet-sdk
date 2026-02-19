
# Payment Methods Request

## Structure

`PaymentMethodsRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AdditionalData` | `Dictionary<string, string>` | Optional | This field contains additional data, which may be required for a particular payment request.<br><br>The `additionalData` object consists of entries, each of which includes the key and value. |
| `AllowedPaymentMethods` | `List<string>` | Optional | List of payment methods to be presented to the shopper. To refer to payment methods, use their [payment method type](https://docs.adyen.com/payment-methods/payment-method-types).<br><br>Example: `"allowedPaymentMethods":["ideal","applepay"]` |
| `Amount` | [`Amount2`](../../doc/models/amount-2.md) | Optional | The amount information for the transaction (in [minor units](https://docs.adyen.com/development-resources/currency-codes)). For [BIN or card verification](https://docs.adyen.com/payment-methods/cards/bin-data-and-card-verification) requests, set amount to 0 (zero). |
| `BlockedPaymentMethods` | `List<string>` | Optional | List of payment methods to be hidden from the shopper. To refer to payment methods, use their [payment method type](https://docs.adyen.com/payment-methods/payment-method-types).<br><br>Example: `"blockedPaymentMethods":["ideal","applepay"]` |
| `BrowserInfo` | [`BrowserInfo2`](../../doc/models/browser-info-2.md) | Optional | The shopper's browser information.<br><br>> For 3D Secure, the full object is required for web integrations. For mobile app integrations, include the `userAgent` and `acceptHeader` fields to indicate  that your integration can support a redirect in case a payment is routed to 3D Secure 2 redirect. |
| `Channel` | [`Channel3?`](../../doc/models/channel-3.md) | Optional | The platform where a payment transaction takes place. This field can be used for filtering out payment methods that are only available on specific platforms. Possible values:<br><br>* iOS<br>* Android<br>* Web |
| `CountryCode` | `string` | Optional | The shopper's country code. |
| `MerchantAccount` | `string` | Required | The merchant account identifier, with which you want to process the transaction. |
| `Order` | [`EncryptedOrderData2`](../../doc/models/encrypted-order-data-2.md) | Optional | The order information required for partial payments. |
| `ShopperConversionId` | `string` | Optional | A unique ID that can be used to associate `/paymentMethods` and `/payments` requests with the same shopper transaction, offering insights into conversion rates.<br><br>**Constraints**: *Maximum Length*: `256` |
| `ShopperEmail` | `string` | Optional | The shopper's email address. We recommend that you provide this data, as it is used in velocity fraud checks. > Required for Visa and JCB transactions that require 3D Secure 2 authentication if you did not include the `telephoneNumber`. |
| `ShopperIp` | `string` | Optional | The shopper's IP address. We recommend that you provide this data, as it is used in a number of risk checks (for instance, number of payment attempts or location-based checks).<br><br>> Required for Visa and JCB transactions that require 3D Secure 2 authentication for all web and mobile integrations, if you did not include the `shopperEmail`. For native mobile integrations, the field is required to support cases where authentication is routed to the redirect flow. This field is also mandatory for some merchants depending on your business model. For more information, [contact Support](https://www.adyen.help/hc/en-us/requests/new). |
| `ShopperLocale` | `string` | Optional | The combination of a language code and a country code to specify the language to be used in the payment. |
| `ShopperReference` | `string` | Optional | Required for recurring payments.<br>Your reference to uniquely identify this shopper, for example user ID or account ID. The value is case-sensitive and must be at least three characters.<br><br>> Your reference must not include personally identifiable information (PII) such as name or email address. |
| `SplitCardFundingSources` | `bool?` | Optional | Boolean value indicating whether the card payment method should be split into separate debit and credit options.<br><br>**Default**: `false` |
| `Store` | `string` | Optional | Required for Adyen for Platforms integrations if you are a platform model. This is your [reference](https://docs.adyen.com/api-explorer/Management/3/post/merchants/(merchantId)/stores#request-reference) (on [balance platform](https://docs.adyen.com/platforms)) or the [storeReference](https://docs.adyen.com/api-explorer/Account/latest/post/updateAccountHolder#request-accountHolderDetails-storeDetails-storeReference) (in the [classic integration](https://docs.adyen.com/classic-platforms/processing-payments/route-payment-to-store/#route-a-payment-to-a-store)) for the ecommerce or point-of-sale store that is processing the payment.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `16` |
| `StoreFiltrationMode` | [`StoreFiltrationMode2?`](../../doc/models/store-filtration-mode-2.md) | Optional | Specifies how payment methods should be filtered based on the `store` parameter:<br><br>- **exclusive**: Only payment methods belonging to the specified `store` are returned.<br>- **inclusive**: Payment methods from the `store` and those not associated with any other store are returned. |
| `TelephoneNumber` | `string` | Optional | The shopper's telephone number.<br>The phone number must include a plus sign (+) and a country code (1-3 digits), followed by the number (4-15 digits). If the value you provide does not follow the guidelines, we do not submit it for authentication.<br><br>> Required for Visa and JCB transactions that require 3D Secure 2 authentication, if you did not include the `shopperEmail`. |

## Example (as JSON)

```json
{
  "merchantAccount": "merchantAccount2",
  "splitCardFundingSources": false,
  "additionalData": {
    "key0": "additionalData4",
    "key1": "additionalData3"
  },
  "allowedPaymentMethods": [
    "allowedPaymentMethods1",
    "allowedPaymentMethods2"
  ],
  "amount": {
    "currency": "currency2",
    "value": 110
  },
  "blockedPaymentMethods": [
    "blockedPaymentMethods6",
    "blockedPaymentMethods7",
    "blockedPaymentMethods8"
  ],
  "browserInfo": {
    "acceptHeader": "acceptHeader6",
    "colorDepth": 30,
    "javaEnabled": false,
    "javaScriptEnabled": false,
    "language": "language0",
    "screenHeight": 56,
    "screenWidth": 36,
    "timeZoneOffset": 88,
    "userAgent": "userAgent4"
  }
}
```

