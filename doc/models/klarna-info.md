
# Klarna Info

## Structure

`KlarnaInfo`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AutoCapture` | `bool?` | Optional | Indicates the status of [Automatic capture](https://docs.adyen.com/online-payments/capture#automatic-capture). Default value: **false**. |
| `DisputeEmail` | `string` | Required | The email address for disputes. |
| `Region` | [`Region`](../../doc/models/region.md) | Required | The region of operation. For example, **NA**, **EU**, **CH**, **AU**.<br><br>**Constraints**: *Minimum Length*: `2`, *Maximum Length*: `2` |
| `SupportEmail` | `string` | Required | The email address of merchant support. |

## Example (as JSON)

```json
{
  "autoCapture": false,
  "disputeEmail": "disputeEmail8",
  "region": "CH",
  "supportEmail": "supportEmail2"
}
```

