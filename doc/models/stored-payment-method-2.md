
# Stored Payment Method 2

## Structure

`StoredPaymentMethod2`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `BankAccountNumber` | `string` | Optional | The bank account number (without separators). |
| `BankLocationId` | `string` | Optional | The location id of the bank. The field value is `nil` in most cases. |
| `Brand` | `string` | Optional | The brand of the card. |
| `ExpiryMonth` | `string` | Optional | The two-digit month when the card expires |
| `ExpiryYear` | `string` | Optional | The last two digits of the year the card expires. For example, **22** for the year 2022. |
| `HolderName` | `string` | Optional | The unique payment method code. |
| `Iban` | `string` | Optional | The IBAN of the bank account. |
| `Id` | `string` | Optional | A unique identifier of this stored payment method. |
| `Label` | `string` | Optional | The shopper’s issuer account label |
| `LastFour` | `string` | Optional | The last four digits of the PAN. |
| `Name` | `string` | Optional | The display name of the stored payment method. |
| `NetworkTxReference` | `string` | Optional | Returned in the response if you are not tokenizing with Adyen and are using the Merchant-initiated transactions (MIT) framework from Mastercard or Visa.<br><br>This contains either the Mastercard Trace ID or the Visa Transaction ID. |
| `OwnerName` | `string` | Optional | The name of the bank account holder. |
| `ShopperEmail` | `string` | Optional | The shopper’s email address. |
| `SupportedRecurringProcessingModels` | `List<string>` | Optional | The supported recurring processing models for this stored payment method. |
| `SupportedShopperInteractions` | `List<string>` | Optional | The supported shopper interactions for this stored payment method. |
| `Type` | `string` | Optional | The type of payment method. |

## Example (as JSON)

```json
{
  "bankAccountNumber": "bankAccountNumber2",
  "bankLocationId": "bankLocationId4",
  "brand": "brand6",
  "expiryMonth": "expiryMonth6",
  "expiryYear": "expiryYear4"
}
```

