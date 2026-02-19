
# Sub Merchant Info

## Structure

`SubMerchantInfo`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Address` | [`BillingAddress4`](../../doc/models/billing-address-4.md) | Optional | Required for transactions performed by registered payment facilitators. The sub-merchant's address. |
| `Amount` | [`Amount31`](../../doc/models/amount-31.md) | Optional | Required for transactions performed by registered payment facilitators. The amount of the payment corresponding to each sub-merchant. This value will be different than the request amount if shopper is purchasing items at different sub-merchants' shops. |
| `Email` | `string` | Optional | Required for transactions performed by registered payment facilitators. The email associated with the sub-merchant's account.<br><br>**Constraints**: *Maximum Length*: `320` |
| `Id` | `string` | Optional | Required for transactions performed by registered payment facilitators. A unique identifier that you create for the sub-merchant, used by schemes to identify the sub-merchant.<br><br>* Format: Alphanumeric<br>* Maximum length: 15 characters |
| `Mcc` | `string` | Optional | Required for transactions performed by registered payment facilitators. The sub-merchant's 4-digit Merchant Category Code (MCC).<br><br>* Format: Numeric<br>* Fixed length: 4 digits |
| `Name` | `string` | Optional | Required for transactions performed by registered payment facilitators. The name of the sub-merchant. Based on scheme specifications, this value will overwrite the shopper statement that will appear in the card statement.<br>Exception: for acquirers in Brazil, this value does not overwrite the shopper statement.<br><br>* Format: Alphanumeric<br>* Maximum length: 22 characters |
| `PhoneNumber` | `string` | Optional | Required for transactions performed by registered payment facilitators. The phone number associated with the sub-merchant's account.<br><br>**Constraints**: *Maximum Length*: `20` |
| `RegisteredSince` | `string` | Optional | - |
| `TaxId` | `string` | Optional | Required for transactions performed by registered payment facilitators. The tax ID of the sub-merchant.<br><br>* Format: Numeric<br>* Fixed length: 11 digits for the CPF or 14 digits for the CNPJ |
| `Url` | `string` | Optional | Required for transactions performed by registered payment facilitators. The sub-merchant's URL on the platform, i.e. the sub-merchant's shop.<br><br>**Constraints**: *Maximum Length*: `320` |

## Example (as JSON)

```json
{
  "address": {
    "city": "city6",
    "country": "country0",
    "houseNumberOrName": "houseNumberOrName4",
    "postalCode": "postalCode8",
    "stateOrProvince": "stateOrProvince4",
    "street": "street6"
  },
  "amount": {
    "currency": "currency2",
    "value": 110
  },
  "email": "email4",
  "id": "id2",
  "mcc": "mcc2"
}
```

