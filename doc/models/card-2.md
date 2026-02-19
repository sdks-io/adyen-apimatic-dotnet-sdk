
# Card 2

The payment method used by the shopper.

## Structure

`Card2`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `BillingSequenceNumber` | `string` | Optional | The sequence number for the debit. For example, send **2** if this is the second debit for the subscription. The sequence number is included in the notification sent to the shopper. |
| `Brand` | `string` | Optional | Secondary brand of the card. For example: **plastix**, **hmclub**. |
| `CheckoutAttemptId` | `string` | Optional | The checkout attempt identifier. |
| `CupsecureplusSmscode` | `string` | Optional | - |
| `Cvc` | `string` | Optional | The card verification code. Only collect raw card data if you are [fully PCI compliant](https://docs.adyen.com/development-resources/pci-dss-compliance-guide). |
| `EncryptedCard` | `string` | Optional | Only include this for JSON Web Encryption (JWE) implementations. The JWE-encrypted card details.<br><br>**Constraints**: *Maximum Length*: `40000` |
| `EncryptedCardNumber` | `string` | Optional | The encrypted card number.<br><br>**Constraints**: *Maximum Length*: `15000` |
| `EncryptedExpiryMonth` | `string` | Optional | The encrypted card expiry month.<br><br>**Constraints**: *Maximum Length*: `15000` |
| `EncryptedExpiryYear` | `string` | Optional | The encrypted card expiry year.<br><br>**Constraints**: *Maximum Length*: `15000` |
| `EncryptedPassword` | `string` | Optional | This field contains an encrypted, one-time password or an authentication code provided by the cardholder.<br><br>**Constraints**: *Maximum Length*: `15000` |
| `EncryptedSecurityCode` | `string` | Optional | The encrypted card verification code.<br><br>**Constraints**: *Maximum Length*: `15000` |
| `ExpiryMonth` | `string` | Optional | The card expiry month. Only collect raw card data if you are [fully PCI compliant](https://docs.adyen.com/development-resources/pci-dss-compliance-guide). |
| `ExpiryYear` | `string` | Optional | The card expiry year. Only collect raw card data if you are [fully PCI compliant](https://docs.adyen.com/development-resources/pci-dss-compliance-guide). |
| `FastlaneData` | `string` | Optional | The encoded fastlane data blob |
| `FundingSource` | [`FundingSource?`](../../doc/models/funding-source.md) | Optional | The funding source that should be used when multiple sources are available. For Brazilian combo cards, by default the funding source is credit. To use debit, set this value to **debit**. |
| `HolderName` | `string` | Optional | The name of the card holder.<br><br>**Constraints**: *Maximum Length*: `15000` |
| `NetworkPaymentReference` | `string` | Optional | The transaction identifier from card schemes. This is the [`networkTxReference`](https://docs.adyen.com/api-explorer/Checkout/latest/post/payments#responses-200-additionalData-ResponseAdditionalDataCommon-networkTxReference) from the response to the first payment. |
| `Number` | `string` | Optional | The card number. Only collect raw card data if you are [fully PCI compliant](https://docs.adyen.com/development-resources/pci-dss-compliance-guide). |
| `RecurringDetailReference` | `string` | Optional | This is the `recurringDetailReference` returned in the response when you created the token. |
| `SdkData` | `string` | Optional | Base64-encoded JSON object containing SDK related parameters required by the SDK<br><br>**Constraints**: *Maximum Length*: `50000` |
| `ShopperNotificationReference` | `string` | Optional | The `shopperNotificationReference` returned in the response when you requested to notify the shopper. Used only for recurring payments in India. |
| `SrcCorrelationId` | `string` | Optional | An identifier used for the Click to Pay transaction. |
| `SrcDigitalCardId` | `string` | Optional | The SRC reference for the Click to Pay token. |
| `SrcScheme` | `string` | Optional | The scheme that is being used for Click to Pay. |
| `SrcTokenReference` | `string` | Optional | The reference for the Click to Pay token. |
| `StoredPaymentMethodId` | `string` | Optional | This is the `recurringDetailReference` returned in the response when you created the token.<br><br>**Constraints**: *Maximum Length*: `64` |
| `ThreeDs2SdkVersion` | `string` | Optional | Required for mobile integrations. Version of the 3D Secure 2 mobile SDK.<br><br>**Constraints**: *Maximum Length*: `12` |
| `Type` | [`Type12?`](../../doc/models/type-12.md) | Optional | Default payment method details. Common for scheme payment methods, and for simple payment method details.<br><br>**Default**: `Type12.scheme` |

## Example (as JSON)

```json
{
  "type": "scheme",
  "billingSequenceNumber": "billingSequenceNumber8",
  "brand": "brand2",
  "checkoutAttemptId": "checkoutAttemptId4",
  "cupsecureplus.smscode": "cupsecureplus.smscode6",
  "cvc": "cvc2"
}
```

