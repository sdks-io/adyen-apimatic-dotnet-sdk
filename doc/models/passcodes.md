
# Passcodes

## Structure

`Passcodes`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AdminMenuPin` | `string` | Optional | The passcode for the Admin menu and the Settings menu.<br><br>**Constraints**: *Maximum Length*: `6` |
| `RefundPin` | `string` | Optional | The passcode for referenced and unreferenced refunds on standalone terminals.<br><br>**Constraints**: *Maximum Length*: `6` |
| `ScreenLockPin` | `string` | Optional | The passcode to unlock the terminal screen after a timeout.<br><br>**Constraints**: *Minimum Length*: `4`, *Maximum Length*: `6` |
| `TxMenuPin` | `string` | Optional | The passcode for the Transactions menu.<br><br>**Constraints**: *Maximum Length*: `6` |

## Example (as JSON)

```json
{
  "adminMenuPin": "adminMenuPin8",
  "refundPin": "refundPin2",
  "screenLockPin": "screenLockPin2",
  "txMenuPin": "txMenuPin2"
}
```

