
# Risk Data 4

Contains risk data, such as client-side data, used to identify risk for a transaction.

## Structure

`RiskData4`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ClientData` | `string` | Optional | Contains client-side data, like the device fingerprint, cookies, and specific browser settings.<br><br>**Constraints**: *Maximum Length*: `5000` |
| `CustomFields` | `Dictionary<string, string>` | Optional | Any custom fields used as part of the input to configured risk rules. |
| `FraudOffset` | `int?` | Optional | An integer value that is added to the normal fraud score. The value can be either positive or negative. |
| `ProfileReference` | `string` | Optional | The risk profile to assign to this payment. When left empty, the merchant-level account's default risk profile will be applied. |

## Example (as JSON)

```json
{
  "clientData": "clientData2",
  "customFields": {
    "key0": "customFields0",
    "key1": "customFields1"
  },
  "fraudOffset": 166,
  "profileReference": "profileReference0"
}
```

