
# Encryption Protocol

SSL version to access the public webhook URL specified in the `url` field. Possible values:

* **TLSv1.3**
* **TLSv1.2**
* **HTTP** - Only allowed on Test environment.

If not specified, the webhook will use `sslVersion`: **TLSv1.2**.

## Enumeration

`EncryptionProtocol`

## Fields

| Name |
|  --- |
| `Http` |
| `EnumTlSv12` |
| `EnumTlSv13` |

## Example

```
TLSv1.2
```

