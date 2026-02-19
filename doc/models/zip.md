
# Zip

*This model accepts additional fields of type object.*

## Structure

`Zip`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `CheckoutAttemptId` | `string` | Optional | The checkout attempt identifier. |
| `ClickAndCollect` | `string` | Optional | Set this to **true** if the shopper would like to pick up and collect their order, instead of having the goods delivered to them. |
| `RecurringDetailReference` | `string` | Optional | This is the `recurringDetailReference` returned in the response when you created the token. |
| `SdkData` | `string` | Optional | Base64-encoded JSON object containing SDK related parameters required by the SDK<br><br>**Constraints**: *Maximum Length*: `50000` |
| `StoredPaymentMethodId` | `string` | Optional | This is the `recurringDetailReference` returned in the response when you created the token.<br><br>**Constraints**: *Maximum Length*: `64` |
| `Type` | [`Type52?`](../../doc/models/type-52.md) | Optional | **zip**<br><br>**Default**: `Type52.zip` |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "type": "zip",
  "checkoutAttemptId": "checkoutAttemptId2",
  "clickAndCollect": "clickAndCollect6",
  "recurringDetailReference": "recurringDetailReference6",
  "sdkData": "sdkData4",
  "storedPaymentMethodId": "storedPaymentMethodId0",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

