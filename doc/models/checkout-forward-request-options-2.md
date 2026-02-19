
# Checkout Forward Request Options 2

The customizations that can be applied when making a forward request.

## Structure

`CheckoutForwardRequestOptions2`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AccountUpdate` | `bool?` | Optional | Whether to check for a card account update (true) or not (false) |
| `DryRun` | `bool?` | Optional | Set to **true** to receive a copy of the request Adyen is making to the third party in the response. Any sensitive information will be masked in the response you receive. This functionality is only available in the test environment. |
| `NetworkToken` | [`CheckoutNetworkTokenOption2`](../../doc/models/checkout-network-token-option-2.md) | Optional | The object that contains the details for forwarding a network token. |
| `NetworkTxReferencePaths` | `List<string>` | Optional | Set in tokenize:true case when forwarding PAN. Addresses to the possible location(s) of networkTxReference in the incoming 3rd party response |
| `Tokenize` | `bool?` | Optional | Set to **true**, the payment details are [tokenized](https://docs.adyen.com/online-payments/tokenization). |

## Example (as JSON)

```json
{
  "accountUpdate": false,
  "dryRun": false,
  "networkToken": {
    "includeCryptogram": false,
    "useNetworkToken": false
  },
  "networkTxReferencePaths": [
    "networkTxReferencePaths3",
    "networkTxReferencePaths4"
  ],
  "tokenize": false
}
```

