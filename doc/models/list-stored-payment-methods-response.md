
# List Stored Payment Methods Response

## Structure

`ListStoredPaymentMethodsResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `MerchantAccount` | `string` | Optional | Your merchant account. |
| `ShopperReference` | `string` | Optional | Your reference to uniquely identify this shopper, for example user ID or account ID. Minimum length: 3 characters.<br><br>> Your reference must not include personally identifiable information (PII), for example name or email address. |
| `StoredPaymentMethods` | [`List<StoredPaymentMethodResource>`](../../doc/models/stored-payment-method-resource.md) | Optional | List of all stored payment methods. |

## Example (as JSON)

```json
{
  "merchantAccount": "merchantAccount4",
  "shopperReference": "shopperReference0",
  "storedPaymentMethods": [
    {
      "brand": "brand6",
      "cardBin": "cardBin8",
      "expiryMonth": "expiryMonth6",
      "expiryYear": "expiryYear6",
      "externalResponseCode": "externalResponseCode6"
    },
    {
      "brand": "brand6",
      "cardBin": "cardBin8",
      "expiryMonth": "expiryMonth6",
      "expiryYear": "expiryYear6",
      "externalResponseCode": "externalResponseCode6"
    }
  ]
}
```

