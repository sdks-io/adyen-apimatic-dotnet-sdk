
# File 2

For `eap` **tls**. The certificate chain for the terminals. All terminals in the same network will use the same EAP client certificate.

## Structure

`File2`

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

