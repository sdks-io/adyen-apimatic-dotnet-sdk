
# Connectivity

## Structure

`Connectivity`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `SimcardStatus` | [`SimcardStatus?`](../../doc/models/simcard-status.md) | Optional | Indicates the status of the SIM card in the payment terminal. Can be updated and received only at terminal level, and only for models that support cellular connectivity.<br><br>Possible values:<br><br>* **ACTIVATED**: the SIM card is activated. Cellular connectivity may still need to be enabled on the terminal itself, in the **Network** settings.<br>* **INVENTORY**: the SIM card is not activated. The terminal can't use cellular connectivity. |
| `TerminalIpAddressUrl` | [`EventUrl3`](../../doc/models/event-url-3.md) | Optional | The list of local and public URLs to send notifications to when using local integrations. |

## Example (as JSON)

```json
{
  "simcardStatus": "ACTIVATED",
  "terminalIPAddressURL": {
    "eventLocalUrls": [
      {
        "encrypted": false,
        "password": "password4",
        "url": "url4",
        "username": "username0"
      }
    ],
    "eventPublicUrls": [
      {
        "encrypted": false,
        "password": "password8",
        "url": "url8",
        "username": "username4"
      },
      {
        "encrypted": false,
        "password": "password8",
        "url": "url8",
        "username": "username4"
      }
    ]
  }
}
```

