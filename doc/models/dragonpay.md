
# Dragonpay

## Structure

`Dragonpay`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `CheckoutAttemptId` | `string` | Optional | The checkout attempt identifier. |
| `Issuer` | `string` | Required | The Dragonpay issuer value of the shopper's selected bank. Set this to an **id** of a Dragonpay issuer to preselect it. |
| `SdkData` | `string` | Optional | Base64-encoded JSON object containing SDK related parameters required by the SDK<br><br>**Constraints**: *Maximum Length*: `50000` |
| `ShopperEmail` | `string` | Optional | The shopper’s email address. |
| `Type` | [`Type23`](../../doc/models/type-23.md) | Required | **dragonpay** |

## Example (as JSON)

```json
{
  "checkoutAttemptId": "checkoutAttemptId8",
  "issuer": "issuer2",
  "sdkData": "sdkData2",
  "shopperEmail": "shopperEmail6",
  "type": "dragonpay_otc_non_banking"
}
```

