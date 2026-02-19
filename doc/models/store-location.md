
# Store Location

## Structure

`StoreLocation`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `City` | `string` | Optional | The name of the city. |
| `Country` | `string` | Required | The two-letter country code in [ISO_3166-1_alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) format. |
| `Line1` | `string` | Optional | The street address. |
| `Line2` | `string` | Optional | Second address line. |
| `Line3` | `string` | Optional | Third address line. |
| `PostalCode` | `string` | Optional | The postal code. |
| `StateOrProvince` | `string` | Optional | The state or province code as defined in [ISO 3166-2](https://www.iso.org/standard/72483.html). For example, **ON** for Ontario, Canada.<br><br>Required for the following countries:<br><br>- Australia<br>- Brazil<br>- Canada<br>- India<br>- Mexico<br>- New Zealand<br>- United States |

## Example (as JSON)

```json
{
  "city": "city6",
  "country": "country0",
  "line1": "line18",
  "line2": "line20",
  "line3": "line38",
  "postalCode": "postalCode2"
}
```

