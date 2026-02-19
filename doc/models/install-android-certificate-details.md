
# Install Android Certificate Details

## Structure

`InstallAndroidCertificateDetails`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `CertificateId` | `string` | Optional | The unique identifier of the certificate to be installed. |
| `Type` | [`Type37?`](../../doc/models/type-37.md) | Optional | Type of terminal action: Install an Android certificate.<br><br>**Default**: `Type37.InstallAndroidCertificate` |

## Example (as JSON)

```json
{
  "type": "InstallAndroidCertificate",
  "certificateId": "certificateId6"
}
```

