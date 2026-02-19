
# Checkout Bank Transfer Action

## Structure

`CheckoutBankTransferAction`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AccountNumber` | `string` | Optional | The account number of the bank transfer. |
| `BankCode` | `string` | Optional | The bank code of the bank transfer. |
| `Beneficiary` | `string` | Optional | The name of the account holder. |
| `Bic` | `string` | Optional | The BIC of the IBAN. |
| `BranchCode` | `string` | Optional | The branch code of the bank transfer. |
| `DownloadUrl` | `string` | Optional | The url to download payment details with. |
| `Iban` | `string` | Optional | The IBAN of the bank transfer. |
| `PaymentMethodType` | `string` | Optional | Specifies the payment method. |
| `Reference` | `string` | Optional | The transfer reference. |
| `RoutingNumber` | `string` | Optional | The routing number of the bank transfer. |
| `ShopperEmail` | `string` | Optional | The e-mail of the shopper, included if an e-mail was sent to the shopper. |
| `SortCode` | `string` | Optional | The sort code of the bank transfer. |
| `TotalAmount` | [`Amount10`](../../doc/models/amount-10.md) | Optional | The amount of the bank transfer. |
| `Type` | `string` | Required, Constant | The type of the action.<br><br>**Value**: `"bankTransfer"` |
| `Url` | `string` | Optional | Specifies the URL to redirect to. |

## Example (as JSON)

```json
{
  "type": "bankTransfer",
  "accountNumber": "accountNumber4",
  "bankCode": "bankCode8",
  "beneficiary": "beneficiary6",
  "bic": "bic0",
  "branchCode": "branchCode0"
}
```

