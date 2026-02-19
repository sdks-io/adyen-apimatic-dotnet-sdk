
# Stored Payment Method Resource

## Structure

`StoredPaymentMethodResource`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Brand` | `string` | Optional | The brand of the card. |
| `CardBin` | `string` | Optional | The bank identification number (BIN) of the card. |
| `ExpiryMonth` | `string` | Optional | The month the card expires. |
| `ExpiryYear` | `string` | Optional | The last two digits of the year the card expires. For example, **22** for the year 2022. |
| `ExternalResponseCode` | `string` | Optional | The response code returned by an external system (for example after a provisioning operation). |
| `ExternalTokenReference` | `string` | Optional | The token reference of a linked token in an external system (for example a network token reference). |
| `HolderName` | `string` | Optional | The unique payment method code. |
| `Iban` | `string` | Optional | The IBAN of the bank account. |
| `Id` | `string` | Optional | A unique identifier of this stored payment method. |
| `IssuerName` | `string` | Optional | The name of the issuer of token or card. |
| `LastFour` | `string` | Optional | The last four digits of the PAN. |
| `Mandate` | [`TokenMandate2`](../../doc/models/token-mandate-2.md) | Optional | Mandate details for the stored payment method. |
| `Name` | `string` | Optional | The display name of the stored payment method. |
| `NetworkTxReference` | `string` | Optional | Returned in the response if you are not tokenizing with Adyen and are using the Merchant-initiated transactions (MIT) framework from Mastercard or Visa.<br><br>This contains either the Mastercard Trace ID or the Visa Transaction ID. |
| `OwnerName` | `string` | Optional | The name of the bank account holder. |
| `ShopperEmail` | `string` | Optional | The shopper’s email address. |
| `ShopperReference` | `string` | Optional | Your reference to uniquely identify this shopper, for example user ID or account ID. The value is case-sensitive and must be at least three characters.<br><br>> Your reference must not include personally identifiable information (PII) such as name or email address.<br><br>**Constraints**: *Minimum Length*: `3`, *Maximum Length*: `256` |
| `SupportedRecurringProcessingModels` | `List<string>` | Optional | Defines a recurring payment type.<br>Allowed values:<br><br>* `Subscription` – A transaction for a fixed or variable amount, which follows a fixed schedule.<br>* `CardOnFile` – With a card-on-file (CoF) transaction, card details are stored to enable one-click or omnichannel journeys, or simply to streamline the checkout process. Any subscription not following a fixed schedule is also considered a card-on-file transaction.<br>* `UnscheduledCardOnFile` – An unscheduled card-on-file (UCoF) transaction is a transaction that occurs on a non-fixed schedule and/or have variable amounts. For example, automatic top-ups when a cardholder's balance drops below a certain amount. |
| `Type` | `string` | Optional | The type of payment method. |

## Example (as JSON)

```json
{
  "brand": "brand0",
  "cardBin": "cardBin2",
  "expiryMonth": "expiryMonth0",
  "expiryYear": "expiryYear0",
  "externalResponseCode": "externalResponseCode0"
}
```

