
# Pay U

## Structure

`PayU`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `CheckoutAttemptId` | `string` | Optional | The checkout attempt identifier. |
| `RecurringDetailReference` | `string` | Optional | This is the `recurringDetailReference` returned in the response when you created the token. |
| `SdkData` | `string` | Optional | Base64-encoded JSON object containing SDK related parameters required by the SDK<br><br>**Constraints**: *Maximum Length*: `50000` |
| `ShopperNotificationReference` | `string` | Optional | The `shopperNotificationReference` returned in the response when you requested to notify the shopper. Used for recurring payment only. |
| `StoredPaymentMethodId` | `string` | Optional | This is the `recurringDetailReference` returned in the response when you created the token.<br><br>**Constraints**: *Maximum Length*: `64` |
| `Type` | `string` | Required, Constant | **payu_IN_upi**<br><br>**Value**: `"payu_IN_upi"` |
| `VirtualPaymentAddress` | `string` | Optional | The virtual payment address for UPI. |

## Example (as JSON)

```json
{
  "type": "payu_IN_upi",
  "checkoutAttemptId": "checkoutAttemptId8",
  "recurringDetailReference": "recurringDetailReference2",
  "sdkData": "sdkData8",
  "shopperNotificationReference": "shopperNotificationReference2",
  "storedPaymentMethodId": "storedPaymentMethodId6"
}
```

