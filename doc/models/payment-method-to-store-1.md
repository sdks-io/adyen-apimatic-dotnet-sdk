
# Payment Method to Store 1

Contains the information required to store a payment method.

## Structure

`PaymentMethodToStore1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Brand` | `string` | Optional | Secondary brand of the card. For example: **plastix**, **hmclub**. |
| `Cvc` | `string` | Optional | The card verification code. Only collect raw card data if you are [fully PCI compliant](https://docs.adyen.com/development-resources/pci-dss-compliance-guide). |
| `EncryptedCard` | `string` | Optional | The encrypted card.<br><br>**Constraints**: *Maximum Length*: `40000` |
| `EncryptedCardNumber` | `string` | Optional | The encrypted card number.<br><br>**Constraints**: *Maximum Length*: `15000` |
| `EncryptedExpiryMonth` | `string` | Optional | The encrypted card expiry month.<br><br>**Constraints**: *Maximum Length*: `15000` |
| `EncryptedExpiryYear` | `string` | Optional | The encrypted card expiry year.<br><br>**Constraints**: *Maximum Length*: `15000` |
| `EncryptedSecurityCode` | `string` | Optional | The encrypted card verification code.<br><br>**Constraints**: *Maximum Length*: `15000` |
| `ExpiryMonth` | `string` | Optional | The card expiry month. Only collect raw card data if you are [fully PCI compliant](https://docs.adyen.com/development-resources/pci-dss-compliance-guide). |
| `ExpiryYear` | `string` | Optional | The card expiry year. Only collect raw card data if you are [fully PCI compliant](https://docs.adyen.com/development-resources/pci-dss-compliance-guide). |
| `HolderName` | `string` | Optional | The name of the card holder. |
| `Number` | `string` | Optional | The card number. Only collect raw card data if you are [fully PCI compliant](https://docs.adyen.com/development-resources/pci-dss-compliance-guide). |
| `Type` | `string` | Optional | Set to **scheme**. |

## Example (as JSON)

```json
{
  "brand": "brand2",
  "cvc": "cvc2",
  "encryptedCard": "encryptedCard0",
  "encryptedCardNumber": "encryptedCardNumber6",
  "encryptedExpiryMonth": "encryptedExpiryMonth4"
}
```

