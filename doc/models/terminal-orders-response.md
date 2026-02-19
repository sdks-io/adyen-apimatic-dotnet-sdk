
# Terminal Orders Response

## Structure

`TerminalOrdersResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Data` | [`List<TerminalOrder>`](../../doc/models/terminal-order.md) | Optional | List of orders for payment terminal packages and parts. |

## Example (as JSON)

```json
{
  "data": [
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
      "customerOrderReference": "customerOrderReference2",
      "id": "id0",
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
      "orderDate": "orderDate0"
    }
  ]
}
```

