
# Sdk Ephem Pub Key 3

The `sdkEphemPubKey` value as received from the 3D Secure 2 SDK.
Required for `deviceChannel` set to **app**.

## Structure

`SdkEphemPubKey3`

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
  "crv": "crv2",
  "kty": "kty2",
  "x": "x0",
  "y": "y8"
}
```

