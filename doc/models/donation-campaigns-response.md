
# Donation Campaigns Response

## Structure

`DonationCampaignsResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `DonationCampaigns` | [`List<DonationCampaign>`](../../doc/models/donation-campaign.md) | Optional | List of active donation campaigns for your merchant account. |

## Example (as JSON)

```json
{
  "donationCampaigns": [
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
    },
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
    },
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
  ]
}
```

