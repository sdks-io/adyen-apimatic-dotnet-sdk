
# Klarna Info 1

Details to provide if `type` is **klarna** or its variant.

You can use the following payment method `type` values for Klarna:

* **klarna**: Klarna Pay Later
* **klarna_account**: Klarna Pay over time
* **klarna_paynow**: Klarna Pay now
* **klarna_b2b**: [Billie via Klarna](https://docs.adyen.com/payment-methods/klarna/billie)

## Structure

`KlarnaInfo1`

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
  "disputeEmail": "disputeEmail4",
  "region": "NA",
  "supportEmail": "supportEmail8"
}
```

