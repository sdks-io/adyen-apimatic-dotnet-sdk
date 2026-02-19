
# We Chat Pay

*This model accepts additional fields of type object.*

## Structure

`WeChatPay`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `CheckoutAttemptId` | `string` | Optional | The checkout attempt identifier. |
| `SdkData` | `string` | Optional | Base64-encoded JSON object containing SDK related parameters required by the SDK<br><br>**Constraints**: *Maximum Length*: `50000` |
| `Type` | [`Type50?`](../../doc/models/type-50.md) | Optional | **wechatpay**<br><br>**Default**: `Type50.wechatpay` |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "type": "wechatpay",
  "checkoutAttemptId": "checkoutAttemptId2",
  "sdkData": "sdkData4",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

