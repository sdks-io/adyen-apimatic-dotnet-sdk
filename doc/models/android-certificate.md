
# Android Certificate

## Structure

`AndroidCertificate`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Description` | `string` | Optional | The description that was provided when uploading the certificate. |
| `Extension` | `string` | Optional | The file format of the certificate, as indicated by the file extension. For example, **.cert** or **.pem**. |
| `Id` | `string` | Required | The unique identifier of the certificate. |
| `Name` | `string` | Optional | The file name of the certificate. For example, **mycert**. |
| `NotAfter` | `DateTime?` | Optional | The date when the certificate stops to be valid. |
| `NotBefore` | `DateTime?` | Optional | The date when the certificate starts to be valid. |
| `Status` | `string` | Optional | The status of the certificate. |

## Example (as JSON)

```json
{
  "description": "description8",
  "extension": "extension4",
  "id": "id8",
  "name": "name8",
  "notAfter": "2016-03-13T12:52:32.123Z",
  "notBefore": "2016-03-13T12:52:32.123Z"
}
```

