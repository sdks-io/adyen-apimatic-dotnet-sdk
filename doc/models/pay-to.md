
# Pay To

## Structure

`PayTo`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `CheckoutAttemptId` | `string` | Optional | The checkout attempt identifier. |
| `RecurringDetailReference` | `string` | Optional | This is the `recurringDetailReference` returned in the response when you created the token. |
| `SdkData` | `string` | Optional | Base64-encoded JSON object containing SDK related parameters required by the SDK<br><br>**Constraints**: *Maximum Length*: `50000` |
| `ShopperAccountIdentifier` | `string` | Optional | The shopper's banking details or payId reference, used to complete payment. |
| `StoredPaymentMethodId` | `string` | Optional | This is the `recurringDetailReference` returned in the response when you created the token.<br><br>**Constraints**: *Maximum Length*: `64` |
| `Type` | [`Type36?`](../../doc/models/type-36.md) | Optional | **payto**<br><br>**Default**: `Type36.payto` |

## Example (as JSON)

```json
{
  "type": "payto",
  "checkoutAttemptId": "checkoutAttemptId2",
  "recurringDetailReference": "recurringDetailReference6",
  "sdkData": "sdkData4",
  "shopperAccountIdentifier": "shopperAccountIdentifier6",
  "storedPaymentMethodId": "storedPaymentMethodId0"
}
```

