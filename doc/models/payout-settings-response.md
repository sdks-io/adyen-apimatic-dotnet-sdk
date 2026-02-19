
# Payout Settings Response

## Structure

`PayoutSettingsResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Data` | [`List<PayoutSettings>`](../../doc/models/payout-settings.md) | Optional | The list of payout accounts. |

## Example (as JSON)

```json
{
  "data": [
    {
      "allowed": false,
      "enabled": false,
      "enabledFromDate": "enabledFromDate2",
      "id": "id0",
      "priority": "urgent",
      "transferInstrumentId": "transferInstrumentId8",
      "verificationStatus": "rejected"
    },
    {
      "allowed": false,
      "enabled": false,
      "enabledFromDate": "enabledFromDate2",
      "id": "id0",
      "priority": "urgent",
      "transferInstrumentId": "transferInstrumentId8",
      "verificationStatus": "rejected"
    }
  ]
}
```

