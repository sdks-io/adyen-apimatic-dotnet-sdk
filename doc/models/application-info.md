
# Application Info

## Structure

`ApplicationInfo`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AdyenLibrary` | [`CommonField4`](../../doc/models/common-field-4.md) | Optional | Adyen-developed software, such as libraries and plugins, used to interact with the Adyen API. For example, Magento plugin, Java API library, etc. |
| `AdyenPaymentSource` | [`CommonField1`](../../doc/models/common-field-1.md) | Optional | Adyen-developed software to get payment details. For example, Checkout SDK, Secured Fields SDK, etc. |
| `ExternalPlatform` | [`ExternalPlatform2`](../../doc/models/external-platform-2.md) | Optional | Third-party developed platform used to initiate payment requests. For example, Magento, Zuora, etc. |
| `MerchantApplication` | [`CommonField2`](../../doc/models/common-field-2.md) | Optional | Merchant developed software, such as cashier application, used to interact with the Adyen API. |
| `MerchantDevice` | [`MerchantDevice2`](../../doc/models/merchant-device-2.md) | Optional | Merchant device information. |
| `ShopperInteractionDevice` | [`ShopperInteractionDevice2`](../../doc/models/shopper-interaction-device-2.md) | Optional | Shopper interaction device, such as terminal, mobile device or web browser, to initiate payment requests. |

## Example (as JSON)

```json
{
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
}
```

