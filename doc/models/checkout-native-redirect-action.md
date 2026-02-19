
# Checkout Native Redirect Action

## Structure

`CheckoutNativeRedirectAction`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Data` | `Dictionary<string, string>` | Optional | When the redirect URL must be accessed via POST, use this data to post to the redirect URL. |
| `Method` | `string` | Optional | Specifies the HTTP method, for example GET or POST. |
| `NativeRedirectData` | `string` | Optional | Native SDK's redirect data containing the direct issuer link and state data that must be submitted to the /v1/nativeRedirect/redirectResult. |
| `PaymentMethodType` | `string` | Optional | Specifies the payment method. |
| `Type` | `string` | Required, Constant | **nativeRedirect**<br><br>**Value**: `"nativeRedirect"` |
| `Url` | `string` | Optional | Specifies the URL to redirect to. |

## Example (as JSON)

```json
{
  "type": "nativeRedirect",
  "data": {
    "key0": "data5"
  },
  "method": "method6",
  "nativeRedirectData": "nativeRedirectData8",
  "paymentMethodType": "paymentMethodType2",
  "url": "url4"
}
```

