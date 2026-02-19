
# Three Ds Requestor Authentication Info

## Structure

`ThreeDsRequestorAuthenticationInfo`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ThreeDsReqAuthData` | `string` | Optional | Data that documents and supports a specific authentication process. Maximum length: 2048 bytes. |
| `ThreeDsReqAuthMethod` | [`ThreeDsReqAuthMethod?`](../../doc/models/three-ds-req-auth-method.md) | Optional | Mechanism used by the Cardholder to authenticate to the 3DS Requestor. Allowed values:<br><br>* **01** — No 3DS Requestor authentication occurred (for example, cardholder “logged in” as guest).<br>* **02** — Login to the cardholder account at the 3DS Requestor system using 3DS Requestor’s own credentials.<br>* **03** — Login to the cardholder account at the 3DS Requestor system using federated ID.<br>* **04** — Login to the cardholder account at the 3DS Requestor system using issuer credentials.<br>* **05** — Login to the cardholder account at the 3DS Requestor system using third-party authentication.<br>* **06** — Login to the cardholder account at the 3DS Requestor system using FIDO Authenticator.<br><br>**Constraints**: *Minimum Length*: `2`, *Maximum Length*: `2` |
| `ThreeDsReqAuthTimestamp` | `string` | Optional | Date and time in UTC of the cardholder authentication. Format: YYYYMMDDHHMM<br><br>**Constraints**: *Minimum Length*: `12`, *Maximum Length*: `12` |

## Example (as JSON)

```json
{
  "threeDSReqAuthData": "threeDSReqAuthData4",
  "threeDSReqAuthMethod": "05",
  "threeDSReqAuthTimestamp": "threeDSReqAuthTimestamp4"
}
```

