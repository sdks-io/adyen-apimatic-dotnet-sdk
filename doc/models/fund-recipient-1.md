
# Fund Recipient 1

the person or entity receiving the money

## Structure

`FundRecipient1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Iban` | `string` | Optional | The IBAN of the bank account where the funds are being transferred to. |
| `BillingAddress` | [`Address3`](../../doc/models/address-3.md) | Optional | The address where to send the invoice. |
| `PaymentMethod` | [`Card2`](../../doc/models/card-2.md) | Optional | The payment method used by the shopper. |
| `ShopperEmail` | `string` | Optional | The email address of the shopper. |
| `ShopperName` | [`Name2`](../../doc/models/name-2.md) | Optional | The name of the shopper. |
| `ShopperReference` | `string` | Optional | Required for recurring payments.<br>Your reference to uniquely identify this shopper, for example user ID or account ID. The value is case-sensitive and must be at least three characters.<br><br>> Your reference must not include personally identifiable information (PII) such as name or email address.<br><br>**Constraints**: *Minimum Length*: `3`, *Maximum Length*: `256` |
| `StoredPaymentMethodId` | `string` | Optional | This is the `recurringDetailReference` returned in the response when you created the token.<br><br>**Constraints**: *Maximum Length*: `64` |
| `SubMerchant` | [`SubMerchant2`](../../doc/models/sub-merchant-2.md) | Optional | Required for back-to-back/purchase-driven-load transactions, where the funds are taken from the shopper's stored card when the wallet balance is insufficient.<br>The final merchant who will receive the money, also known as a [sub-merchant](https://docs.adyen.com/get-started-with-adyen/payment-glossary/#submerchant). |
| `TelephoneNumber` | `string` | Optional | The telephone number of the shopper. |
| `WalletIdentifier` | `string` | Optional | The unique identifier for the wallet the funds are being transferred to. You can use the shopper reference or any other identifier. |
| `WalletOwnerTaxId` | `string` | Optional | The tax identifier of the person receiving the funds. |
| `WalletPurpose` | [`WalletPurpose?`](../../doc/models/wallet-purpose.md) | Optional | The purpose of a digital wallet transaction. |

## Example (as JSON)

```json
{
  "IBAN": "IBAN8",
  "billingAddress": {
    "city": "city8",
    "country": "country6",
    "houseNumberOrName": "houseNumberOrName0",
    "postalCode": "postalCode6",
    "stateOrProvince": "stateOrProvince0",
    "street": "street2"
  },
  "paymentMethod": {
    "billingSequenceNumber": "billingSequenceNumber2",
    "brand": "brand6",
    "checkoutAttemptId": "checkoutAttemptId8",
    "cupsecureplus.smscode": "cupsecureplus.smscode0",
    "cvc": "cvc6"
  },
  "shopperEmail": "shopperEmail8",
  "shopperName": {
    "firstName": "firstName2",
    "lastName": "lastName6"
  }
}
```

