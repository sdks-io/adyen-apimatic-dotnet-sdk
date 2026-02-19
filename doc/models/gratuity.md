
# Gratuity

## Structure

`Gratuity`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AllowCustomAmount` | `bool?` | Optional | Indicates whether one of the predefined tipping options is to let the shopper enter a custom tip. If **true**, only three of the other options defined in `predefinedTipEntries` are shown. |
| `Currency` | `string` | Optional | The currency that the tipping settings apply to. |
| `PredefinedTipEntries` | `List<string>` | Optional | Tipping options the shopper can choose from if `usePredefinedTipEntries` is **true**. The maximum number of predefined options is four, or three plus the option to enter a custom tip.<br>The options can be a mix of:<br><br>- A percentage of the transaction amount. Example: **5%**<br>- A tip amount in [minor units](https://docs.adyen.com/development-resources/currency-codes). Example: **500** for a EUR 5 tip. |
| `UsePredefinedTipEntries` | `bool?` | Optional | Indicates whether the terminal shows a prompt to enter a tip (**false**), or predefined tipping options to choose from (**true**). |

## Example (as JSON)

```json
{
  "allowCustomAmount": false,
  "currency": "currency6",
  "predefinedTipEntries": [
    "predefinedTipEntries6",
    "predefinedTipEntries7"
  ],
  "usePredefinedTipEntries": false
}
```

