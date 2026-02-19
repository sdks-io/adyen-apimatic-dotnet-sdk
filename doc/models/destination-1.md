
# Destination 1

The destination address information.

## Structure

`Destination1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `CountryCode` | `string` | Optional | The two-letter [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) or three-letter [ISO 3166-1 alpha-3 country code](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-3) for the destination address.<br><br>* Encoding: ASCII<br>* Min length: 2 characters<br>* Max length: 3 characters |
| `PostalCode` | `string` | Optional | The postal code of the destination address.<br><br>* Encoding: ASCII<br>* Max length: 10 characters<br>* Must not start with a space.<br>* For the US, it must be in five or nine digits format. For example, 10001 or 10001-0000.<br>* For Canada, it must be in 6 digits format. For example, M4B 1G5. |
| `StateOrProvince` | `string` | Optional | The state or province code of the destination address.<br><br>* Encoding: ASCII<br>* Max length: 3 characters<br>* Must not start with a space. |

## Example (as JSON)

```json
{
  "countryCode": "countryCode4",
  "postalCode": "postalCode8",
  "stateOrProvince": "stateOrProvince8"
}
```

