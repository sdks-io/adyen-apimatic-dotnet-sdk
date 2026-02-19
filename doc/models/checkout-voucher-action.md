
# Checkout Voucher Action

## Structure

`CheckoutVoucherAction`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AlternativeReference` | `string` | Optional | The voucher alternative reference code. |
| `CollectionInstitutionNumber` | `string` | Optional | A collection institution number (store number) for Econtext Pay-Easy ATM. |
| `DownloadUrl` | `string` | Optional | The URL to download the voucher. |
| `Entity` | `string` | Optional | An entity number of Multibanco. |
| `ExpiresAt` | `string` | Optional | The date time of the voucher expiry. |
| `InitialAmount` | [`Amount13`](../../doc/models/amount-13.md) | Optional | The initial amount. |
| `InstructionsUrl` | `string` | Optional | The URL to the detailed instructions to make payment using the voucher. |
| `Issuer` | `string` | Optional | The issuer of the voucher. |
| `MaskedTelephoneNumber` | `string` | Optional | The shopper telephone number (partially masked). |
| `MerchantName` | `string` | Optional | The merchant name. |
| `MerchantReference` | `string` | Optional | The merchant reference. |
| `PassCreationToken` | `string` | Optional | A Base64-encoded token containing all properties of the voucher. For iOS, you can use this to pass a voucher to Apple Wallet. |
| `PaymentData` | `string` | Optional | Encoded payment data. |
| `PaymentMethodType` | `string` | Optional | Specifies the payment method. |
| `Reference` | `string` | Optional | The voucher reference code. |
| `ShopperEmail` | `string` | Optional | The shopper email. |
| `ShopperName` | `string` | Optional | The shopper name. |
| `Surcharge` | [`Amount14`](../../doc/models/amount-14.md) | Optional | The surcharge amount. |
| `TotalAmount` | [`Amount15`](../../doc/models/amount-15.md) | Optional | The total amount (initial plus surcharge amount). |
| `Type` | `string` | Required, Constant | **voucher**<br><br>**Value**: `"voucher"` |
| `Url` | `string` | Optional | Specifies the URL to redirect to. |

## Example (as JSON)

```json
{
  "type": "voucher",
  "alternativeReference": "alternativeReference4",
  "collectionInstitutionNumber": "collectionInstitutionNumber2",
  "downloadUrl": "downloadUrl4",
  "entity": "entity4",
  "expiresAt": "expiresAt2"
}
```

