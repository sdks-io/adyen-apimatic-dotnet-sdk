
# Afterpay

## Structure

`Afterpay`

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
| `Type` | [`Type2`](../../doc/models/type-2.md) | Required | **afterpay_default**<br><br>**Default**: `Type2.afterpay_default` |

## Example (as JSON)

```json
{
  "type": "afterpay_default",
  "billingAddress": "billingAddress8",
  "checkoutAttemptId": "checkoutAttemptId0",
  "deliveryAddress": "deliveryAddress0",
  "personalDetails": "personalDetails2",
  "recurringDetailReference": "recurringDetailReference4"
}
```

