
# Wifi Profiles 2

Remote Wi-Fi profiles for WPA and WPA2 PSK and EAP Wi-Fi networks.

## Structure

`WifiProfiles2`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Profiles` | [`List<Profile>`](../../doc/models/profile.md) | Optional | List of remote Wi-Fi profiles. |
| `Settings` | [`Settings1`](../../doc/models/settings-1.md) | Optional | General Wi-Fi settings. |

## Example (as JSON)

```json
{
  "profiles": [
    {
      "authType": "authType8",
      "autoWifi": false,
      "bssType": "bssType4",
      "channel": 198,
      "defaultProfile": false,
      "domainSuffix": "domainSuffix2",
      "eap": "eap0",
      "ssid": "ssid6",
      "wsec": "wsec4"
    },
    {
      "authType": "authType8",
      "autoWifi": false,
      "bssType": "bssType4",
      "channel": 198,
      "defaultProfile": false,
      "domainSuffix": "domainSuffix2",
      "eap": "eap0",
      "ssid": "ssid6",
      "wsec": "wsec4"
    }
  ],
  "settings": {
    "band": "band0",
    "roaming": false,
    "timeout": 124
  }
}
```

