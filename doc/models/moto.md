
# Moto

## Structure

`Moto`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `EnableMoto` | `bool?` | Optional | Enable MOTO transactions. |
| `MaxAmount` | `int?` | Optional | The maximum amount for MOTO transactions. You need to set the currency for this amount using the [`standalone.currencyCode`](https://docs.adyen.com/api-explorer/Management/1/patch/companies/(companyId)/terminalSettings#request-standalone-currencyCode) parameter. Do not enable standalone, unless you are using a standalone solution. |

## Example (as JSON)

```json
{
  "enableMoto": false,
  "maxAmount": 88
}
```

