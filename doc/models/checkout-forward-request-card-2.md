
# Checkout Forward Request Card 2

The card details.

## Structure

`CheckoutForwardRequestCard2`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Cvc` | `string` | Optional | The [card verification code](https://docs.adyen.com/payments-fundamentals/payment-glossary#card-security-code-cvc-cvv-cid) (1-20 characters). Depending on the card brand, it is also known as:<br><br>* CVV2/CVC2 – length: 3 digits<br>* CID – length: 4 digits |
| `EncryptedCardNumber` | `string` | Optional | The encrypted card number. |
| `EncryptedExpiryMonth` | `string` | Optional | The encrypted expiryMonth |
| `EncryptedExpiryYear` | `string` | Optional | The encrypted card expiry year. |
| `EncryptedSecurityCode` | `string` | Optional | The encrypted security code. |
| `ExpiryMonth` | `string` | Optional | The card expiry month.<br>Format: 2 digits, zero-padded for single digits. For example:<br><br>* 03 = March<br>* 11 = November |
| `ExpiryYear` | `string` | Optional | The card expiry year. |
| `HolderName` | `string` | Optional | The name of the cardholder. |
| `Number` | `string` | Optional | The card number. Only collect raw card data if you are fully [PCI compliant](https://docs.adyen.com/development-resources/pci-dss-compliance-guide).<br>Format: Do not use separators. |
| `Type` | [`Type16?`](../../doc/models/type-16.md) | Optional | Default payment method details. Common for scheme payment methods, and for simple payment method details.<br><br>**Default**: `Type16.scheme` |

## Example (as JSON)

```json
{
  "type": "scheme",
  "cvc": "cvc6",
  "encryptedCardNumber": "encryptedCardNumber0",
  "encryptedExpiryMonth": "encryptedExpiryMonth8",
  "encryptedExpiryYear": "encryptedExpiryYear2",
  "encryptedSecurityCode": "encryptedSecurityCode8"
}
```

