
# Paypal Update Order Request

## Structure

`PaypalUpdateOrderRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Amount` | [`Amount43`](../../doc/models/amount-43.md) | Optional | The updated final payment amount. This amount is the item total plus the shipping costs of the selected `deliveryMethod`. |
| `DeliveryMethods` | [`List<DeliveryMethod>`](../../doc/models/delivery-method.md) | Optional | The list of new delivery methods and the cost of each. |
| `PaymentData` | `string` | Optional | The `paymentData` from the client side. This value changes every time you make a `/paypal/updateOrder` request. |
| `PspReference` | `string` | Optional | The original `pspReference` from the `/payments` response. |
| `SessionId` | `string` | Optional | The original `sessionId` from the `/sessions` response. |
| `TaxTotal` | [`TaxTotal2`](../../doc/models/tax-total-2.md) | Optional | Total tax amount from the order. |

## Example (as JSON)

```json
{
  "amount": {
    "currency": "currency2",
    "value": 110
  },
  "deliveryMethods": [
    {
      "amount": {
        "currency": "currency2",
        "value": 110
      },
      "description": "description6",
      "reference": "reference2",
      "selected": false,
      "type": "Shipping"
    }
  ],
  "paymentData": "paymentData0",
  "pspReference": "pspReference0",
  "sessionId": "sessionId6"
}
```

