
# Donation Campaign

## Structure

`DonationCampaign`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Amounts` | [`Amounts1`](../../doc/models/amounts-1.md) | Optional | The object that contains the fixed donation amounts that the shopper can select from. |
| `BannerUrl` | `string` | Optional | The URL for the banner of the nonprofit or campaign. |
| `CampaignName` | `string` | Optional | The name of the donation campaign.. |
| `CauseName` | `string` | Optional | The cause of the nonprofit. |
| `Donation` | [`Donation1`](../../doc/models/donation-1.md) | Optional | The object that contains the details of the donation. |
| `Id` | `string` | Optional | The unique campaign ID of the donation campaign. |
| `LogoUrl` | `string` | Optional | The URL for the logo of the nonprofit. |
| `NonprofitDescription` | `string` | Optional | The description of the nonprofit. |
| `NonprofitName` | `string` | Optional | The name of the nonprofit organization that receives the donation. |
| `NonprofitUrl` | `string` | Optional | The website URL of the nonprofit. |
| `TermsAndConditionsUrl` | `string` | Optional | The URL of the terms and conditions page of the nonprofit and the campaign. |

## Example (as JSON)

```json
{
  "amounts": {
    "currency": "currency6",
    "values": [
      48,
      49
    ]
  },
  "bannerUrl": "bannerUrl0",
  "campaignName": "campaignName2",
  "causeName": "causeName6",
  "donation": {
    "currency": "currency0",
    "donationType": "donationType2",
    "maxRoundupAmount": 114,
    "type": "type0",
    "values": [
      106,
      105,
      104
    ]
  }
}
```

