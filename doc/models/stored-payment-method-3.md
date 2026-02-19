
# Stored Payment Method 3

*This model accepts additional fields of type object.*

## Structure

`StoredPaymentMethod3`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `CheckoutAttemptId` | `string` | Optional | The checkout attempt identifier. |
| `PixRecurring` | [`PixRecurring`](../../doc/models/pix-recurring.md) | Optional | - |
| `RecurringDetailReference` | `string` | Optional | This is the `recurringDetailReference` returned in the response when you created the token. |
| `SdkData` | `string` | Optional | Base64-encoded JSON object containing SDK related parameters required by the SDK<br><br>**Constraints**: *Maximum Length*: `50000` |
| `StoredPaymentMethodId` | `string` | Optional | This is the `recurringDetailReference` returned in the response when you created the token.<br><br>**Constraints**: *Maximum Length*: `64` |
| `Type` | [`Type39?`](../../doc/models/type-39.md) | Optional | The payment method type. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "checkoutAttemptId": "checkoutAttemptId8",
  "pixRecurring": {
    "billingDate": "billingDate0",
    "businessDayOnly": false,
    "endsAt": "endsAt8",
    "frequency": "yearly",
    "minAmount": {
      "currency": "currency6",
      "value": 156
    }
  },
  "recurringDetailReference": "recurringDetailReference2",
  "sdkData": "sdkData8",
  "storedPaymentMethodId": "storedPaymentMethodId6",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

