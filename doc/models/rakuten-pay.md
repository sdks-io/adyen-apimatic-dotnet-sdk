
# Rakuten Pay

*This model accepts additional fields of type object.*

## Structure

`RakutenPay`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `CheckoutAttemptId` | `string` | Optional | The checkout attempt identifier. |
| `RecurringDetailReference` | `string` | Optional | This is the `recurringDetailReference` returned in the response when you created the token. |
| `SdkData` | `string` | Optional | Base64-encoded JSON object containing SDK related parameters required by the SDK<br><br>**Constraints**: *Maximum Length*: `50000` |
| `StoredPaymentMethodId` | `string` | Optional | This is the `recurringDetailReference` returned in the response when you created the token.<br><br>**Constraints**: *Maximum Length*: `64` |
| `Type` | [`Type41?`](../../doc/models/type-41.md) | Optional | **rakutenpay**<br><br>**Default**: `Type41.rakutenpay` |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "type": "rakutenpay",
  "checkoutAttemptId": "checkoutAttemptId6",
  "recurringDetailReference": "recurringDetailReference0",
  "sdkData": "sdkData0",
  "storedPaymentMethodId": "storedPaymentMethodId4",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

