
# Response Additional Data Billing Address

## Structure

`ResponseAdditionalDataBillingAddress`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `BillingAddressCity` | `string` | Optional | The billing address city passed in the payment request. |
| `BillingAddressCountry` | `string` | Optional | The billing address country passed in the payment request.<br><br>Example: NL |
| `BillingAddressHouseNumberOrName` | `string` | Optional | The billing address house number or name passed in the payment request. |
| `BillingAddressPostalCode` | `string` | Optional | The billing address postal code passed in the payment request.<br><br>Example: 1011 DJ |
| `BillingAddressStateOrProvince` | `string` | Optional | The billing address state or province passed in the payment request.<br><br>Example: NH |
| `BillingAddressStreet` | `string` | Optional | The billing address street passed in the payment request. |

## Example (as JSON)

```json
{
  "billingAddress.city": "billingAddress.city8",
  "billingAddress.country": "billingAddress.country2",
  "billingAddress.houseNumberOrName": "billingAddress.houseNumberOrName6",
  "billingAddress.postalCode": "billingAddress.postalCode4",
  "billingAddress.stateOrProvince": "billingAddress.stateOrProvince4"
}
```

