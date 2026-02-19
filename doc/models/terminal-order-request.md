
# Terminal Order Request

## Structure

`TerminalOrderRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `BillingEntityId` | `string` | Optional | The identification of the billing entity to use for the order.<br><br>> When ordering products in Brazil, you do not need to include the `billingEntityId` in the request. |
| `CustomerOrderReference` | `string` | Optional | The merchant-defined purchase order reference. |
| `Items` | [`List<OrderItem>`](../../doc/models/order-item.md) | Optional | The products included in the order. |
| `OrderType` | `string` | Optional | Type of order |
| `ShippingLocationId` | `string` | Optional | The identification of the shipping location to use for the order. |
| `TaxId` | `string` | Optional | The tax number of the billing entity. |

## Example (as JSON)

```json
{
  "billingEntityId": "billingEntityId6",
  "customerOrderReference": "customerOrderReference8",
  "items": [
    {
      "id": "id8",
      "installments": 204,
      "name": "name8",
      "quantity": 22
    },
    {
      "id": "id8",
      "installments": 204,
      "name": "name8",
      "quantity": 22
    },
    {
      "id": "id8",
      "installments": 204,
      "name": "name8",
      "quantity": 22
    }
  ],
  "orderType": "orderType4",
  "shippingLocationId": "shippingLocationId4"
}
```

