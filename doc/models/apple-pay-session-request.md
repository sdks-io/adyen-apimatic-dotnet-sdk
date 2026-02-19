
# Apple Pay Session Request

## Structure

`ApplePaySessionRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `DisplayName` | `string` | Required | This is the name that your shoppers will see in the Apple Pay interface.<br><br>The value returned as `configuration.merchantName` field from the [`/paymentMethods`](https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/paymentMethods) response.<br><br>**Constraints**: *Maximum Length*: `64` |
| `DomainName` | `string` | Required | The domain name you provided when you added Apple Pay in your Customer Area.<br><br>This must match the `window.location.hostname` of the web shop. |
| `MerchantIdentifier` | `string` | Required | Your merchant identifier registered with Apple Pay.<br><br>Use the value of the `configuration.merchantId` field from the [`/paymentMethods`](https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/paymentMethods) response. |

## Example (as JSON)

```json
{
  "displayName": "displayName4",
  "domainName": "domainName2",
  "merchantIdentifier": "merchantIdentifier2"
}
```

