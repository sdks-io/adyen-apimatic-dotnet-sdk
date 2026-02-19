
# Riverty

*This model accepts additional fields of type object.*

## Structure

`Riverty`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `BillingAddress` | `string` | Optional | The address where to send the invoice. |
| `CheckoutAttemptId` | `string` | Optional | The checkout attempt identifier. |
| `DeliveryAddress` | `string` | Optional | The address where the goods should be delivered. |
| `DeviceFingerprint` | `string` | Optional | A string containing the shopper's device fingerprint. For more information, refer to [Device fingerprinting](https://docs.adyen.com/risk-management/device-fingerprinting).<br><br>**Constraints**: *Maximum Length*: `5000` |
| `Iban` | `string` | Optional | The iban number of the customer<br><br>**Constraints**: *Maximum Length*: `34` |
| `PersonalDetails` | `string` | Optional | Shopper name, date of birth, phone number, and email address. |
| `RecurringDetailReference` | `string` | Optional | This is the `recurringDetailReference` returned in the response when you created the token. |
| `SdkData` | `string` | Optional | Base64-encoded JSON object containing SDK related parameters required by the SDK<br><br>**Constraints**: *Maximum Length*: `50000` |
| `StoredPaymentMethodId` | `string` | Optional | This is the `recurringDetailReference` returned in the response when you created the token.<br><br>**Constraints**: *Maximum Length*: `64` |
| `Subtype` | `string` | Optional | The payment method subtype. |
| `Type` | [`Type43`](../../doc/models/type-43.md) | Required | **riverty**<br><br>**Default**: `Type43.riverty` |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "type": "riverty",
  "billingAddress": "billingAddress2",
  "checkoutAttemptId": "checkoutAttemptId0",
  "deliveryAddress": "deliveryAddress0",
  "deviceFingerprint": "deviceFingerprint0",
  "iban": "iban8",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

