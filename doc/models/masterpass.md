
# Masterpass

## Structure

`Masterpass`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `CheckoutAttemptId` | `string` | Optional | The checkout attempt identifier. |
| `FundingSource` | [`FundingSource?`](../../doc/models/funding-source.md) | Optional | The funding source that should be used when multiple sources are available. For Brazilian combo cards, by default the funding source is credit. To use debit, set this value to **debit**. |
| `MasterpassTransactionId` | `string` | Required | The Masterpass transaction ID. |
| `SdkData` | `string` | Optional | Base64-encoded JSON object containing SDK related parameters required by the SDK<br><br>**Constraints**: *Maximum Length*: `50000` |
| `Type` | [`Type30?`](../../doc/models/type-30.md) | Optional | **masterpass**<br><br>**Default**: `Type30.masterpass` |

## Example (as JSON)

```json
{
  "masterpassTransactionId": "masterpassTransactionId0",
  "type": "masterpass",
  "checkoutAttemptId": "checkoutAttemptId4",
  "fundingSource": "credit",
  "sdkData": "sdkData2"
}
```

