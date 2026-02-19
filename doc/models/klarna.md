
# Klarna

## Structure

`Klarna`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `BillingAddress` | `string` | Optional | The address where to send the invoice. |
| `CheckoutAttemptId` | `string` | Optional | The checkout attempt identifier. |
| `DeliveryAddress` | `string` | Optional | The address where the goods should be delivered. |
| `PersonalDetails` | `string` | Optional | Shopper name, date of birth, phone number, and email address. |
| `RecurringDetailReference` | `string` | Optional | This is the `recurringDetailReference` returned in the response when you created the token. |
| `SdkData` | `string` | Optional | Base64-encoded JSON object containing SDK related parameters required by the SDK<br><br>**Constraints**: *Maximum Length*: `50000` |
| `StoredPaymentMethodId` | `string` | Optional | This is the `recurringDetailReference` returned in the response when you created the token.<br><br>**Constraints**: *Maximum Length*: `64` |
| `Subtype` | `string` | Optional | The type of flow to initiate. |
| `Type` | [`Type29`](../../doc/models/type-29.md) | Required | **klarna**<br><br>**Default**: `Type29.klarna` |

## Example (as JSON)

```json
{
  "type": "klarna",
  "billingAddress": "billingAddress8",
  "checkoutAttemptId": "checkoutAttemptId6",
  "deliveryAddress": "deliveryAddress6",
  "personalDetails": "personalDetails8",
  "recurringDetailReference": "recurringDetailReference0"
}
```

