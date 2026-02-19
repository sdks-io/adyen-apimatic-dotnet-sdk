
# Stored Payment Method

## Structure

`StoredPaymentMethod`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Cashtag` | `string` | Optional | Cash App issued cashtag for recurring payment |
| `CheckoutAttemptId` | `string` | Optional | The checkout attempt identifier. |
| `CustomerId` | `string` | Optional | Cash App issued customerId for recurring payment |
| `GrantId` | `string` | Optional | Cash App issued grantId for one time payment |
| `OnFileGrantId` | `string` | Optional | Cash App issued onFileGrantId for recurring payment |
| `RecurringDetailReference` | `string` | Optional | This is the `recurringDetailReference` returned in the response when you created the token. |
| `RequestId` | `string` | Optional | Cash App request id |
| `SdkData` | `string` | Optional | Base64-encoded JSON object containing SDK related parameters required by the SDK<br><br>**Constraints**: *Maximum Length*: `50000` |
| `StoredPaymentMethodId` | `string` | Optional | This is the `recurringDetailReference` returned in the response when you created the token.<br><br>**Constraints**: *Maximum Length*: `64` |
| `Subtype` | `string` | Optional | The payment method subtype. |
| `Type` | [`Type14?`](../../doc/models/type-14.md) | Optional | cashapp<br><br>**Default**: `Type14.cashapp` |

## Example (as JSON)

```json
{
  "type": "cashapp",
  "cashtag": "cashtag0",
  "checkoutAttemptId": "checkoutAttemptId8",
  "customerId": "customerId6",
  "grantId": "grantId0",
  "onFileGrantId": "onFileGrantId0"
}
```

