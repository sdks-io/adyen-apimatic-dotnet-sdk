
# Pay Pal

## Structure

`PayPal`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `CheckoutAttemptId` | `string` | Optional | The checkout attempt identifier. |
| `OrderId` | `string` | Optional | The unique ID associated with the order. |
| `PayeePreferred` | `string` | Optional | IMMEDIATE_PAYMENT_REQUIRED or UNRESTRICTED |
| `PayerId` | `string` | Optional | The unique ID associated with the payer. |
| `PayerSelected` | `string` | Optional | PAYPAL or PAYPAL_CREDIT |
| `RecurringDetailReference` | `string` | Optional | This is the `recurringDetailReference` returned in the response when you created the token. |
| `SdkData` | `string` | Optional | Base64-encoded JSON object containing SDK related parameters required by the SDK<br><br>**Constraints**: *Maximum Length*: `50000` |
| `StoredPaymentMethodId` | `string` | Optional | This is the `recurringDetailReference` returned in the response when you created the token.<br><br>**Constraints**: *Maximum Length*: `64` |
| `Subtype` | [`Subtype?`](../../doc/models/subtype.md) | Optional | The type of flow to initiate. |
| `Type` | `string` | Required, Constant | **paypal**<br><br>**Value**: `"paypal"` |

## Example (as JSON)

```json
{
  "type": "paypal",
  "checkoutAttemptId": "checkoutAttemptId2",
  "orderID": "orderID0",
  "payeePreferred": "payeePreferred6",
  "payerID": "payerID2",
  "payerSelected": "payerSelected2"
}
```

