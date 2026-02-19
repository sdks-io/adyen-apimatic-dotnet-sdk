
# Updatable Address

## Structure

`UpdatableAddress`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `City` | `string` | Optional | The name of the city. |
| `Line1` | `string` | Optional | The street address. |
| `Line2` | `string` | Optional | Second address line. |
| `Line3` | `string` | Optional | Third address line. |
| `PostalCode` | `string` | Optional | The postal code. |
| `StateOrProvince` | `string` | Optional | The state or province code as defined in [ISO 3166-2](https://www.iso.org/standard/72483.html). For example, **ON** for Ontario, Canada.<br><br>Required for the following countries:<br><br>- Australia<br>- Brazil<br>- Canada<br>- India<br>- Mexico<br>- New Zealand<br>- United States |

## Example (as JSON)

```json
{
  "city": "city4",
  "line1": "line16",
  "line2": "line28",
  "line3": "line36",
  "postalCode": "postalCode6"
}
```

