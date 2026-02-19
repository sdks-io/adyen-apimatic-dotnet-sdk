
# Terminal Connectivity Cellular

## Structure

`TerminalConnectivityCellular`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Iccid` | `string` | Optional | The integrated circuit card identifier (ICCID) of the primary SIM card in the terminal. |
| `Iccid2` | `string` | Optional | The integrated circuit card identifier (ICCID) of the secondary SIM card in the terminal, typically used for a [third-party SIM card](https://docs.adyen.com/point-of-sale/design-your-integration/network-and-connectivity/cellular-failover/#using-a-third-party-sim-card). |
| `Status` | [`Status31?`](../../doc/models/status-31.md) | Optional | On a terminal that supports 3G or 4G connectivity, indicates the status of the primary SIM card in the terminal. |

## Example (as JSON)

```json
{
  "iccid": "iccid8",
  "iccid2": "iccid26",
  "status": "deactivated"
}
```

