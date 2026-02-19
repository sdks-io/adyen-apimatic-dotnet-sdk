
# Checkout Redirect Action

## Structure

`CheckoutRedirectAction`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Data` | `Dictionary<string, string>` | Optional | When the redirect URL must be accessed via POST, use this data to post to the redirect URL. |
| `Method` | `string` | Optional | Specifies the HTTP method, for example GET or POST. |
| `PaymentMethodType` | `string` | Optional | Specifies the payment method. |
| `Type` | `string` | Required, Constant | **redirect**<br><br>**Value**: `"redirect"` |
| `Url` | `string` | Optional | Specifies the URL to redirect to. |

## Example (as JSON)

```json
{
  "type": "redirect",
  "data": {
    "key0": "data5",
    "key1": "data6",
    "key2": "data7"
  },
  "method": "method4",
  "paymentMethodType": "paymentMethodType2",
  "url": "url4"
}
```

