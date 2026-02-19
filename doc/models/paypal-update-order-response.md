
# Paypal Update Order Response

## Structure

`PaypalUpdateOrderResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `PaymentData` | `string` | Required | The updated paymentData. |
| `Status` | [`Status3`](../../doc/models/status-3.md) | Required | The status of the request. This indicates whether the order was successfully updated with PayPal. |

## Example (as JSON)

```json
{
  "paymentData": "paymentData0",
  "status": "error"
}
```

