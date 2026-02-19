
# Signature

## Structure

`Signature`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AskSignatureOnScreen` | `bool?` | Optional | If `skipSignature` is false, indicates whether the shopper should provide a signature on the display (**true**) or on the merchant receipt (**false**). |
| `DeviceName` | `string` | Optional | Name that identifies the terminal. |
| `DeviceSlogan` | `string` | Optional | Slogan shown on the start screen of the device.<br><br>**Constraints**: *Maximum Length*: `50` |
| `SkipSignature` | `bool?` | Optional | Skip asking for a signature. This is possible because all global card schemes (American Express, Diners, Discover, JCB, MasterCard, VISA, and UnionPay) regard a signature as optional. |

## Example (as JSON)

```json
{
  "askSignatureOnScreen": false,
  "deviceName": "deviceName8",
  "deviceSlogan": "deviceSlogan6",
  "skipSignature": false
}
```

