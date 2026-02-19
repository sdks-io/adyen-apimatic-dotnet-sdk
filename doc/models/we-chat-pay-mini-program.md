
# We Chat Pay Mini Program

*This model accepts additional fields of type object.*

## Structure

`WeChatPayMiniProgram`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AppId` | `string` | Optional | - |
| `CheckoutAttemptId` | `string` | Optional | The checkout attempt identifier. |
| `Openid` | `string` | Optional | - |
| `RecurringDetailReference` | `string` | Optional | This is the `recurringDetailReference` returned in the response when you created the token. |
| `SdkData` | `string` | Optional | Base64-encoded JSON object containing SDK related parameters required by the SDK<br><br>**Constraints**: *Maximum Length*: `50000` |
| `StoredPaymentMethodId` | `string` | Optional | This is the `recurringDetailReference` returned in the response when you created the token.<br><br>**Constraints**: *Maximum Length*: `64` |
| `Type` | [`Type51?`](../../doc/models/type-51.md) | Optional | **wechatpayMiniProgram**<br><br>**Default**: `Type51.wechatpayMiniProgram` |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "type": "wechatpayMiniProgram",
  "appId": "appId2",
  "checkoutAttemptId": "checkoutAttemptId2",
  "openid": "openid6",
  "recurringDetailReference": "recurringDetailReference6",
  "sdkData": "sdkData6",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

