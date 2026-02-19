
# Terminal Connectivity 2

Information about bluetooth, cellular, ethernet and wifi connectivity for the terminal.

## Structure

`TerminalConnectivity2`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Bluetooth` | [`TerminalConnectivityBluetooth`](../../doc/models/terminal-connectivity-bluetooth.md) | Optional | - |
| `Cellular` | [`TerminalConnectivityCellular`](../../doc/models/terminal-connectivity-cellular.md) | Optional | - |
| `Ethernet` | [`TerminalConnectivityEthernet`](../../doc/models/terminal-connectivity-ethernet.md) | Optional | - |
| `Wifi` | [`TerminalConnectivityWifi`](../../doc/models/terminal-connectivity-wifi.md) | Optional | - |

## Example (as JSON)

```json
{
  "bluetooth": {
    "ipAddress": "ipAddress2",
    "macAddress": "macAddress2"
  },
  "cellular": {
    "iccid": "iccid6",
    "iccid2": "iccid24",
    "status": "deprecated"
  },
  "ethernet": {
    "ipAddress": "ipAddress2",
    "linkNegotiation": "linkNegotiation6",
    "macAddress": "macAddress2"
  },
  "wifi": {
    "ipAddress": "ipAddress8",
    "macAddress": "macAddress6",
    "ssid": "ssid4"
  }
}
```

