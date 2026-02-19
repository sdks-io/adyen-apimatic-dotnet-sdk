
# Additional Data Risk Standalone

## Structure

`AdditionalDataRiskStandalone`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `PayPalCountryCode` | `string` | Optional | Shopper's country of residence in the form of ISO standard 3166 2-character country codes. |
| `PayPalEmailId` | `string` | Optional | Shopper's email. |
| `PayPalFirstName` | `string` | Optional | Shopper's first name. |
| `PayPalLastName` | `string` | Optional | Shopper's last name. |
| `PayPalPayerId` | `string` | Optional | Unique PayPal Customer Account identification number. Character length and limitations: 13 single-byte alphanumeric characters. |
| `PayPalPhone` | `string` | Optional | Shopper's phone number. |
| `PayPalProtectionEligibility` | `string` | Optional | Allowed values:<br><br>* **Eligible** — Merchant is protected by PayPal's Seller Protection Policy for Unauthorized Payments and Item Not Received.<br><br>* **PartiallyEligible** — Merchant is protected by PayPal's Seller Protection Policy for Item Not Received.<br><br>* **Ineligible** — Merchant is not protected under the Seller Protection Policy. |
| `PayPalTransactionId` | `string` | Optional | Unique transaction ID of the payment. |
| `AvsResultRaw` | `string` | Optional | Raw AVS result received from the acquirer, where available. Example: D |
| `Bin` | `string` | Optional | The Bank Identification Number of a credit card, which is the first six digits of a card number. Required for [tokenized card request](https://docs.adyen.com/online-payments/tokenization). |
| `CvcResultRaw` | `string` | Optional | Raw CVC result received from the acquirer, where available. Example: 1 |
| `RiskToken` | `string` | Optional | Unique identifier or token for the shopper's card details. |
| `ThreeDAuthenticated` | `string` | Optional | A Boolean value indicating whether 3DS authentication was completed on this payment. Example: true |
| `ThreeDOffered` | `string` | Optional | A Boolean value indicating whether 3DS was offered for this payment. Example: true |
| `TokenDataType` | `string` | Optional | Required for PayPal payments only. The only supported value is: **paypal**. |

## Example (as JSON)

```json
{
  "PayPal.CountryCode": "PayPal.CountryCode0",
  "PayPal.EmailId": "PayPal.EmailId0",
  "PayPal.FirstName": "PayPal.FirstName4",
  "PayPal.LastName": "PayPal.LastName0",
  "PayPal.PayerId": "PayPal.PayerId8"
}
```

