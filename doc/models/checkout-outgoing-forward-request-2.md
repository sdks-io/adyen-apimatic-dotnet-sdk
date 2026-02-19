
# Checkout Outgoing Forward Request 2

The [details of the request](https://docs.adyen.com/online-payments/tokenization/forward-payment-details#request-to-adyen-card) that you want to forward to the third-party.

## Structure

`CheckoutOutgoingForwardRequest2`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Body` | `string` | Required | The request body that you want Adyen to forward to the third party on your behalf, in string format.<br><br>Include key value pairs to specify the payment details, and use [placeholders](https://docs.adyen.com/online-payments/tokenization/forward-payment-details#placeholders) for the values. Adyen replaces the placeholders with the payment details when making the request to the third party.<br><br>When forwarding a network token, include a [condition](https://docs.adyen.com/online-payments/tokenization/forward-payment-details#conditional-placeholders) that checks if the network token exists, and informs Adyen of which fields to send depending on the outcome.<br><br>**Constraints**: *Maximum Length*: `20000` |
| `Credentials` | `string` | Optional | Your credentials that are needed to authenticate with the third party. |
| `Headers` | `Dictionary<string, string>` | Optional | The request headers that will be included in the request Adyen makes to the third party on your behalf. Supports the `{{credentials}}` [placeholder](https://docs.adyen.com/online-payments/tokenization/forward-payment-details#placeholders). |
| `HttpMethod` | [`HttpMethod`](../../doc/models/http-method.md) | Required | The HTTP method to use for the request Adyen makes on your behalf to the third party. |
| `UrlSuffix` | `string` | Optional | The suffix that Adyen needs to append to the `baseUrl` to construct the destination URL that belongs to the third party. This is usually the endpoint name for the request, for example, **/payments**. |

## Example (as JSON)

```json
{
  "body": "body4",
  "credentials": "credentials8",
  "headers": {
    "key0": "headers1",
    "key1": "headers2",
    "key2": "headers3"
  },
  "httpMethod": "put",
  "urlSuffix": "urlSuffix4"
}
```

