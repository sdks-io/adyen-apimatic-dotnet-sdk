
# Pay Pal Info 1

Details to provide if `type` is **paypal**.

## Structure

`PayPalInfo1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `DirectCapture` | `bool?` | Optional | Indicates if direct (immediate) capture for PayPal is enabled. If set to **true**, this setting overrides the [capture](https://docs.adyen.com/online-payments/capture) settings of your merchant account. Default value: **true**. |
| `PayerId` | `string` | Required | PayPal Merchant ID. Character length and limitations: 13 single-byte alphanumeric characters.<br><br>**Constraints**: *Minimum Length*: `13`, *Maximum Length*: `13` |
| `Subject` | `string` | Required | Your business email address. |

## Example (as JSON)

```json
{
  "directCapture": false,
  "payerId": "payerId2",
  "subject": "subject0"
}
```

