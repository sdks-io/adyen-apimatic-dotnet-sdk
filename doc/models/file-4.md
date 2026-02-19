
# File 4

For `eap` **tls**. The EAP intermediate certificate.

## Structure

`File4`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Data` | `string` | Required | The certificate content converted to a Base64-encoded string. |
| `Name` | `string` | Required | The name of the certificate. Must be unique across Wi-Fi profiles. |

## Example (as JSON)

```json
{
  "data": "data2",
  "name": "name2"
}
```

