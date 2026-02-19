
# Fund Origin 1

The person or entity funding the money.

## Structure

`FundOrigin1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `BillingAddress` | [`Address3`](../../doc/models/address-3.md) | Optional | The address where to send the invoice. |
| `ShopperEmail` | `string` | Optional | The email address of the person funding the money. |
| `ShopperName` | [`Name1`](../../doc/models/name-1.md) | Optional | The name of the person funding the money. |
| `TelephoneNumber` | `string` | Optional | The phone number of the person funding the money. |
| `WalletIdentifier` | `string` | Optional | The unique identifier of the wallet where the funds are coming from. |

## Example (as JSON)

```json
{
  "billingAddress": {
    "city": "city8",
    "country": "country6",
    "houseNumberOrName": "houseNumberOrName0",
    "postalCode": "postalCode6",
    "stateOrProvince": "stateOrProvince0",
    "street": "street2"
  },
  "shopperEmail": "shopperEmail0",
  "shopperName": {
    "firstName": "firstName2",
    "lastName": "lastName6"
  },
  "telephoneNumber": "telephoneNumber8",
  "walletIdentifier": "walletIdentifier0"
}
```

