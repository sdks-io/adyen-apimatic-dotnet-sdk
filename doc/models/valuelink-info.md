
# Valuelink Info

## Structure

`ValuelinkInfo`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AuthorisationMid` | `string` | Required | Authorisation Mid |
| `PinSupport` | [`PinSupport`](../../doc/models/pin-support.md) | Required | PIN Support. For ecommerce, PIN is required. |
| `SubmitterId` | `string` | Optional | Submitter ID |
| `TerminalId` | `string` | Optional | Terminal ID |

## Example (as JSON)

```json
{
  "authorisationMid": "authorisationMid2",
  "pinSupport": "PIN",
  "submitterId": "submitterId8",
  "terminalId": "terminalId4"
}
```

