
# Hardware 1

Settings for terminal hardware features.

## Structure

`Hardware1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `DisplayMaximumBackLight` | `int?` | Optional | The brightness of the display when the terminal is being used, expressed as a percentage. |
| `ResetTotalsHour` | `int?` | Optional | The hour of the day when the terminal is set to reset the Totals report. By default, the reset hour is at 6:00 AM in the timezone of the terminal. Minimum value: 0, maximum value: 23. |
| `RestartHour` | `int?` | Optional | The hour of the day when the terminal is set to reboot to apply the configuration and software updates. By default, the restart hour is at 6:00 AM in the timezone of the terminal. Minimum value: 0, maximum value: 23. |

## Example (as JSON)

```json
{
  "displayMaximumBackLight": 54,
  "resetTotalsHour": 192,
  "restartHour": 86
}
```

