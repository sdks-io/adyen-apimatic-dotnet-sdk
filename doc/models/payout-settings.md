
# Payout Settings

## Structure

`PayoutSettings`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Allowed` | `bool?` | Optional | Indicates if payouts to the bank account are allowed. This value is set automatically based on the status of the verification process. The value is:<br><br>* **true** if `verificationStatus` is **valid**.<br>* **false** for all other values. |
| `Enabled` | `bool?` | Optional | Indicates if payouts to this bank account are enabled. Default: **true**.<br><br>To receive payouts into this bank account, both `enabled` and `allowed` must be **true**. |
| `EnabledFromDate` | `string` | Optional | The date when Adyen starts paying out to this bank account.<br><br>Format: [ISO 8601](https://www.w3.org/TR/NOTE-datetime), for example, **2019-11-23T12:25:28Z** or **2020-05-27T20:25:28+08:00**.<br><br>If not specified, the `enabled` field indicates if payouts are enabled for this bank account.<br><br>If a date is specified and:<br><br>* `enabled`: **true**, payouts are enabled starting the specified date.<br>* `enabled`: **false**, payouts are disabled until the specified date. On the specified date, `enabled` changes to **true** and this field is reset to **null**. |
| `Id` | `string` | Required | The unique identifier of the payout setting. |
| `Priority` | [`Priority?`](../../doc/models/priority.md) | Optional | Determines how long it takes for the funds to reach the bank account. Adyen pays out based on the [payout frequency](https://docs.adyen.com/account/getting-paid#payout-frequency). Depending on the currencies and banks involved in transferring the money, it may take up to three days for the payout funds to arrive in the bank account.<br><br>Possible values:<br><br>* **first**: same day.<br>* **urgent**: the next day.<br>* **normal**: between 1 and 3 days. |
| `TransferInstrumentId` | `string` | Required | The unique identifier of the [transfer instrument](https://docs.adyen.com/api-explorer/#/legalentity/latest/post/transferInstruments) that contains the details of the bank account. |
| `VerificationStatus` | [`VerificationStatus1?`](../../doc/models/verification-status-1.md) | Optional | The status of the verification process for the bank account.<br><br>Possible values:<br><br>* **valid**: the verification was successful.<br>* **pending**: the verification is in progress.<br>* **invalid**: the information provided is not complete.<br>* **rejected**:  there are reasons to refuse working with this entity. |

## Example (as JSON)

```json
{
  "allowed": false,
  "enabled": false,
  "enabledFromDate": "enabledFromDate8",
  "id": "id6",
  "priority": "first",
  "transferInstrumentId": "transferInstrumentId4",
  "verificationStatus": "invalid"
}
```

