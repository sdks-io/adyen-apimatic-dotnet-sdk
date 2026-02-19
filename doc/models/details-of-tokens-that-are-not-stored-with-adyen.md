
# Details of Tokens That Are Not Stored With Adyen

## Structure

`DetailsOfTokensThatAreNotStoredWithAdyen`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `CheckoutAttemptId` | `string` | Optional | The checkout attempt identifier. |
| `ExpiryMonth` | `string` | Optional | The card expiry month. Only collect raw card data if you are [fully PCI compliant](https://docs.adyen.com/development-resources/pci-dss-compliance-guide). |
| `ExpiryYear` | `string` | Optional | The card expiry year. Only collect raw card data if you are [fully PCI compliant](https://docs.adyen.com/development-resources/pci-dss-compliance-guide). |
| `HolderName` | `string` | Optional | The name of the card holder.<br><br>**Constraints**: *Maximum Length*: `15000` |
| `Number` | `string` | Optional | The card number. Only collect raw card data if you are [fully PCI compliant](https://docs.adyen.com/development-resources/pci-dss-compliance-guide). |
| `StoredPaymentMethodId` | `string` | Required | Identifier used to fetch the token from the external service<br><br>**Constraints**: *Maximum Length*: `64` |
| `Subtype` | `string` | Required, Constant | The external service from which to fetch the token. Supported only for specific companies. Contact Adyen if you want to use this feature.<br><br>**Value**: `"hilton"` |
| `Type` | `string` | Required, Constant | The type of token. Allowed value: **externalToken**.<br><br>**Value**: `"externalToken"` |

## Example (as JSON)

```json
{
  "storedPaymentMethodId": "storedPaymentMethodId8",
  "subtype": "hilton",
  "type": "externalToken",
  "checkoutAttemptId": "checkoutAttemptId0",
  "expiryMonth": "expiryMonth8",
  "expiryYear": "expiryYear8",
  "holderName": "holderName0",
  "number": "number2"
}
```

