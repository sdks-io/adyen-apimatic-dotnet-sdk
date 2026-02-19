
# Donation Campaigns Request

## Structure

`DonationCampaignsRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Currency` | `string` | Required | The three-character [ISO currency code](https://docs.adyen.com/development-resources/currency-codes/). |
| `Locale` | `string` | Optional | Locale on the shopper interaction device. |
| `MerchantAccount` | `string` | Required | Your merchant account identifier. |

## Example (as JSON)

```json
{
  "currency": "currency0",
  "locale": "locale8",
  "merchantAccount": "merchantAccount8"
}
```

