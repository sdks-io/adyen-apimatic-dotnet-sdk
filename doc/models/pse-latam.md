
# Pse Latam

*This model accepts additional fields of type object.*

## Structure

`PseLatam`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Bank` | `string` | Required | The shopper's bank. |
| `CheckoutAttemptId` | `string` | Optional | The checkout attempt identifier. |
| `ClientType` | `string` | Required | The client type. |
| `Identification` | `string` | Required | The identification code. |
| `IdentificationType` | `string` | Required | The identification type. |
| `SdkData` | `string` | Optional | Base64-encoded JSON object containing SDK related parameters required by the SDK<br><br>**Constraints**: *Maximum Length*: `50000` |
| `Type` | [`Type40?`](../../doc/models/type-40.md) | Optional | The payment method type. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "bank": "bank4",
  "checkoutAttemptId": "checkoutAttemptId2",
  "clientType": "clientType4",
  "identification": "identification4",
  "identificationType": "identificationType8",
  "sdkData": "sdkData4",
  "type": "pse_payulatam",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

