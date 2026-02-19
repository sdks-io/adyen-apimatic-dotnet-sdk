
# Additional Data Opi

## Structure

`AdditionalDataOpi`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `OpiIncludeTransToken` | `string` | Optional | Optional boolean indicator. Set to **true** if you want an ecommerce transaction to return an `opi.transToken` as additional data in the response.<br><br>You can store this Oracle Payment Interface token in your Oracle Opera database. For more information and required settings, see [Oracle Opera](https://docs.adyen.com/plugins/oracle-opera#opi-token-ecommerce). |

## Example (as JSON)

```json
{
  "opi.includeTransToken": "opi.includeTransToken4"
}
```

