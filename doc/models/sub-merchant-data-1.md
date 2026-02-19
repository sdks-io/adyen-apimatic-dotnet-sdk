
# Sub Merchant Data 1

The sub-merchant data relevant for registered payment facilitators transacting on standalone terminals.

## Structure

`SubMerchantData1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Email` | `string` | Required | The email associated with the sub-merchant's account.<br><br>**Constraints**: *Maximum Length*: `320` |
| `Id` | `string` | Required | A unique identifier that you create for the sub-merchant, used by schemes to identify the sub-merchant.<br><br>* Format: Alphanumeric<br>* Maximum length: 15 characters |
| `Mcc` | `string` | Required | The sub-merchant's 4-digit Merchant Category Code (MCC).<br><br>* Format: Numeric<br>* Fixed length: 4 digits |
| `Name` | `string` | Required | The name of the sub-merchant. Based on scheme specifications, this value will overwrite the shopper statement that will appear in the card statement.<br><br>* Format: Alphanumeric<br>* Maximum length: 22 characters |

## Example (as JSON)

```json
{
  "email": "email2",
  "id": "id4",
  "mcc": "mcc4",
  "name": "name4"
}
```

