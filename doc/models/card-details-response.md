
# Card Details Response

## Structure

`CardDetailsResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Brands` | [`List<CardBrandDetails>`](../../doc/models/card-brand-details.md) | Optional | The list of brands identified for the card. |
| `FundingSource` | `string` | Optional | The funding source of the card, for example **DEBIT**, **CREDIT**, or **PREPAID**. |
| `IsCardCommercial` | `bool?` | Optional | Indicates if this is a commercial card or a consumer card. If **true**, it is a commercial card. If **false**, it is a consumer card. |
| `IssuingCountryCode` | `string` | Optional | The two-letter country code  of the country where the card was issued. |

## Example (as JSON)

```json
{
  "brands": [
    {
      "supported": false,
      "type": "type6"
    },
    {
      "supported": false,
      "type": "type6"
    },
    {
      "supported": false,
      "type": "type6"
    }
  ],
  "fundingSource": "fundingSource4",
  "isCardCommercial": false,
  "issuingCountryCode": "issuingCountryCode4"
}
```

