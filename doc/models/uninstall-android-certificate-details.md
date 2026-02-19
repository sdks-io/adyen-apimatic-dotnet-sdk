
# Uninstall Android Certificate Details

*This model accepts additional fields of type object.*

## Structure

`UninstallAndroidCertificateDetails`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `CertificateId` | `string` | Optional | The unique identifier of the certificate to be uninstalled. |
| `Type` | [`Type71?`](../../doc/models/type-71.md) | Optional | Type of terminal action: Uninstall an Android certificate.<br><br>**Default**: `Type71.UninstallAndroidCertificate` |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "type": "UninstallAndroidCertificate",
  "certificateId": "certificateId6",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

