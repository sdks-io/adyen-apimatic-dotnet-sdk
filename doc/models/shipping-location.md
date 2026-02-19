
# Shipping Location

## Structure

`ShippingLocation`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Address` | [`Address21`](../../doc/models/address-21.md) | Optional | The address details of the shipping location. |
| `Contact` | [`Contact1`](../../doc/models/contact-1.md) | Optional | The contact details for the shipping location. |
| `Id` | `string` | Optional | The unique identifier of the shipping location, for use as `shippingLocationId` when creating an order. |
| `Name` | `string` | Optional | The unique name of the shipping location. |

## Example (as JSON)

```json
{
  "address": {
    "city": "city6",
    "companyName": "companyName8",
    "country": "country0",
    "postalCode": "postalCode8",
    "stateOrProvince": "stateOrProvince4"
  },
  "contact": {
    "email": "email4",
    "firstName": "firstName2",
    "infix": "infix6",
    "lastName": "lastName6",
    "phoneNumber": "phoneNumber2"
  },
  "id": "id2",
  "name": "name2"
}
```

