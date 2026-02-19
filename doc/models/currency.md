
# Currency

## Structure

`Currency`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Amount` | `int?` | Optional | Surcharge amount per transaction, in [minor units](https://docs.adyen.com/development-resources/currency-codes). |
| `CurrencyCode` | `string` | Required | Three-character [ISO currency code](https://docs.adyen.com/development-resources/currency-codes). For example, **AUD**. |
| `MaxAmount` | `int?` | Optional | The maximum surcharge amount per transaction, in [minor units](https://docs.adyen.com/development-resources/currency-codes). |
| `Percentage` | `double?` | Optional | Surcharge percentage per transaction. The maximum number of decimal places is two. For example, **1%** or **2.27%**. |

## Example (as JSON)

```json
{
  "amount": 66,
  "currencyCode": "currencyCode8",
  "maxAmount": 16,
  "percentage": 46.26
}
```

