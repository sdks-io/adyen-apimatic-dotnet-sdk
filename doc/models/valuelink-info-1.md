
# Valuelink Info 1

Details to provide if `type` is **valuelink**.

## Structure

`ValuelinkInfo1`

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
  "authorisationMid": "authorisationMid8",
  "pinSupport": "PIN",
  "submitterId": "submitterId4",
  "terminalId": "terminalId0"
}
```

