
# Amounts 1

The object that contains the fixed donation amounts that the shopper can select from.

## Structure

`Amounts1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Currency` | `string` | Required | The three-character [ISO currency code](https://docs.adyen.com/development-resources/currency-codes/). |
| `Values` | `List<long>` | Required | The amounts of the donation (in [minor units](https://docs.adyen.com/development-resources/currency-codes/)). |

## Example (as JSON)

```json
{
  "currency": "currency0",
  "values": [
    116,
    117
  ]
}
```

