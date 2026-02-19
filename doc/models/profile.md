
# Profile

## Structure

`Profile`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AuthType` | `string` | Required | The type of Wi-Fi network. Possible values: **wpa-psk**, **wpa2-psk**, **wpa-eap**, **wpa2-eap**. |
| `AutoWifi` | `bool?` | Optional | Indicates whether to automatically select the best authentication method available. Does not work on older terminal models. |
| `BssType` | `string` | Required | Use **infra** for infrastructure-based networks. This applies to most networks. Use **adhoc** only if the communication is p2p-based between base stations. |
| `Channel` | `int?` | Optional | The channel number of the Wi-Fi network. The recommended setting is **0** for automatic channel selection. |
| `DefaultProfile` | `bool?` | Optional | Indicates whether this is your preferred wireless network. If **true**, the terminal will try connecting to this network first. |
| `DomainSuffix` | `string` | Optional | Specifies the server domain name for EAP-TLS and EAP-PEAP WiFi profiles on Android 11 and above. |
| `Eap` | `string` | Optional | For `authType` **wpa-eap** or **wpa2-eap**. Possible values: **tls**, **peap**, **leap**, **fast** |
| `EapCaCert` | [`File1`](../../doc/models/file-1.md) | Optional | For `authType` **wpa-eap** or **wpa2-eap**. The root certificate from the CA that signed the certificate of the RADIUS server that is part of your wireless network. |
| `EapClientCert` | [`File2`](../../doc/models/file-2.md) | Optional | For `eap` **tls**. The certificate chain for the terminals. All terminals in the same network will use the same EAP client certificate. |
| `EapClientKey` | [`File3`](../../doc/models/file-3.md) | Optional | For `eap` **tls**. The RSA private key for the client. Include the lines BEGIN RSA PRIVATE KEY and END RSA PRIVATE KEY. |
| `EapClientPwd` | `string` | Optional | For `eap` **tls**. The password of the RSA key file, if that file is password-protected. |
| `EapIdentity` | `string` | Optional | For `authType` **wpa-eap** or **wpa2-eap**. The EAP-PEAP username from your MS-CHAP account. Must match the configuration of your RADIUS server. |
| `EapIntermediateCert` | [`File4`](../../doc/models/file-4.md) | Optional | For `eap` **tls**. The EAP intermediate certificate. |
| `EapPwd` | `string` | Optional | For `eap` **peap**. The EAP-PEAP password from your MS-CHAP account. Must match the configuration of your RADIUS server. |
| `HiddenSsid` | `bool?` | Optional | Indicates if the network doesn't broadcast its SSID. Mandatory for Android terminals, because these terminals rely on this setting to be able to connect to any network. |
| `Name` | `string` | Optional | Your name for the Wi-Fi profile. |
| `Psk` | `string` | Optional | For `authType` **wpa-psk or **wpa2-psk**. The password to the wireless network. |
| `Ssid` | `string` | Required | The name of the wireless network. |
| `Wsec` | `string` | Required | The type of encryption. Possible values: **auto**, **ccmp** (recommended), **tkip** |

## Example (as JSON)

```json
{
  "authType": "authType8",
  "autoWifi": false,
  "bssType": "bssType4",
  "channel": 16,
  "defaultProfile": false,
  "domainSuffix": "domainSuffix2",
  "eap": "eap0",
  "ssid": "ssid4",
  "wsec": "wsec6"
}
```

