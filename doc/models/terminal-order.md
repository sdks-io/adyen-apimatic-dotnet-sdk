
# Terminal Order

## Structure

`TerminalOrder`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `BillingEntity` | [`BillingEntity1`](../../doc/models/billing-entity-1.md) | Optional | The details of the entity that the order is billed to. |
| `CustomerOrderReference` | `string` | Optional | The merchant-defined purchase order number. This will be printed on the packing list. |
| `Id` | `string` | Optional | The unique identifier of the order. |
| `Items` | [`List<OrderItem>`](../../doc/models/order-item.md) | Optional | The products included in the order. |
| `OrderDate` | `string` | Optional | The date and time that the order was placed, in UTC ISO 8601 format. For example, "2011-12-03T10:15:30Z". |
| `ShippingLocation` | [`ShippingLocation1`](../../doc/models/shipping-location-1.md) | Optional | The details of the location where the order is shipped to. |
| `Status` | `string` | Optional | The processing status of the order. |
| `TrackingUrl` | `string` | Optional | The URL, provided by the carrier company, where the shipment can be tracked. |

## Example (as JSON)

```json
{
  "billingEntity": {
    "address": {
      "city": "city6",
      "companyName": "companyName8",
      "country": "country0",
      "postalCode": "postalCode8",
      "stateOrProvince": "stateOrProvince4"
    },
    "email": "email0",
    "id": "id6",
    "name": "name6",
    "taxId": "taxId2"
  },
  "customerOrderReference": "customerOrderReference0",
  "id": "id8",
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
    }
  ],
  "orderDate": "orderDate2"
}
```

