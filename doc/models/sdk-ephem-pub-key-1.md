
# Sdk Ephem Pub Key 1

The `sdkEphemPubKey` value as received from the 3D Secure 2 SDK.

## Structure

`SdkEphemPubKey1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Crv` | `string` | Optional | The `crv` value as received from the 3D Secure 2 SDK. |
| `Kty` | `string` | Optional | The `kty` value as received from the 3D Secure 2 SDK. |
| `X` | `string` | Optional | The `x` value as received from the 3D Secure 2 SDK. |
| `Y` | `string` | Optional | The `y` value as received from the 3D Secure 2 SDK. |

## Example (as JSON)

```json
{
  "crv": "crv8",
  "kty": "kty8",
  "x": "x6",
  "y": "y4"
}
```

