
# Doku

## Structure

`Doku`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `CheckoutAttemptId` | `string` | Optional | The checkout attempt identifier. |
| `FirstName` | `string` | Required | The shopper's first name. |
| `LastName` | `string` | Required | The shopper's last name. |
| `SdkData` | `string` | Optional | Base64-encoded JSON object containing SDK related parameters required by the SDK<br><br>**Constraints**: *Maximum Length*: `50000` |
| `ShopperEmail` | `string` | Required | The shopper's email. |
| `Type` | [`Type19`](../../doc/models/type-19.md) | Required | **doku** |

## Example (as JSON)

```json
{
  "checkoutAttemptId": "checkoutAttemptId4",
  "firstName": "firstName6",
  "lastName": "lastName2",
  "sdkData": "sdkData2",
  "shopperEmail": "shopperEmail8",
  "type": "doku_bni_va"
}
```

