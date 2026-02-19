
# Terminal Settings

## Structure

`TerminalSettings`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `CardholderReceipt` | [`CardholderReceipt1`](../../doc/models/cardholder-receipt-1.md) | Optional | Settings to define the header of the shopper receipt. |
| `Connectivity` | [`Connectivity1`](../../doc/models/connectivity-1.md) | Optional | Settings for terminal connectivity features. |
| `Gratuities` | [`List<Gratuity>`](../../doc/models/gratuity.md) | Optional | Settings for tipping with or without predefined options to choose from. The maximum number of predefined options is four, or three plus the option to enter a custom tip. |
| `Hardware` | [`Hardware1`](../../doc/models/hardware-1.md) | Optional | Settings for terminal hardware features. |
| `HomeScreen` | [`HomeScreenSettings1`](../../doc/models/home-screen-settings-1.md) | Optional | Settings for the home screen. |
| `KioskMode` | [`KioskModeSettings1`](../../doc/models/kiosk-mode-settings-1.md) | Optional | Settings for kiosk mode. |
| `Localization` | [`Localization1`](../../doc/models/localization-1.md) | Optional | Settings for localization. |
| `Moto` | [`Moto1`](../../doc/models/moto-1.md) | Optional | Settings for Mail Order/Telephone Order transactions. |
| `Nexo` | [`Nexo1`](../../doc/models/nexo-1.md) | Optional | Settings for a Terminal API integration. |
| `OfflineProcessing` | [`OfflineProcessing1`](../../doc/models/offline-processing-1.md) | Optional | Settings for [offline payment](https://docs.adyen.com/point-of-sale/offline-payments) features. |
| `Opi` | [`Opi1`](../../doc/models/opi-1.md) | Optional | Settings for an Oracle Payment Interface (OPI) integration. |
| `Passcodes` | [`Passcodes1`](../../doc/models/passcodes-1.md) | Optional | Settings for [passcodes](https://docs.adyen.com/point-of-sale/managing-terminals/menu-access?tab=manage_passcodes_with_an_api_call_2#manage-passcodes) features. |
| `PayAtTable` | [`PayAtTable1`](../../doc/models/pay-at-table-1.md) | Optional | Settings for [Pay-at-table](https://docs.adyen.com/point-of-sale/pay-at-x) features. |
| `Payment` | [`Payment11`](../../doc/models/payment-11.md) | Optional | Settings for payment features. |
| `ReceiptOptions` | [`ReceiptOptions1`](../../doc/models/receipt-options-1.md) | Optional | Generic receipt settings. |
| `ReceiptPrinting` | [`ReceiptPrinting1`](../../doc/models/receipt-printing-1.md) | Optional | Transaction outcomes that you want the terminal to print a merchant receipt or a shopper receipt for. |
| `Refunds` | [`Refunds1`](../../doc/models/refunds-1.md) | Optional | Settings for refunds. |
| `Signature` | [`Signature1`](../../doc/models/signature-1.md) | Optional | Settings to skip signature, sign on display, or sign on receipt. |
| `Standalone` | [`Standalone1`](../../doc/models/standalone-1.md) | Optional | Settings for [standalone](https://docs.adyen.com/point-of-sale/standalone/standalone-build/set-up-standalone#set-up-standalone-using-an-api-call) features. |
| `StoreAndForward` | [`StoreAndForward1`](../../doc/models/store-and-forward-1.md) | Optional | Settings for store-and-forward offline payments. The `maxAmount`, `maxPayments`, and `supportedCardTypes` parameters must be configured, either in the request or inherited from a higher level in your account structure. |
| `Surcharge` | [`Surcharge21`](../../doc/models/surcharge-21.md) | Optional | Settings for payment [surcharge](https://docs.adyen.com/point-of-sale/surcharge) features. |
| `TapToPay` | [`TapToPay1`](../../doc/models/tap-to-pay-1.md) | Optional | Settings for Tap to Pay. |
| `TerminalInstructions` | [`TerminalInstructions1`](../../doc/models/terminal-instructions-1.md) | Optional | Settings to define the behaviour of the payment terminal. |
| `Timeouts` | [`Timeouts2`](../../doc/models/timeouts-2.md) | Optional | Settings for device [time-outs](https://docs.adyen.com/point-of-sale/pos-timeouts#device-time-out). |
| `WifiProfiles` | [`WifiProfiles2`](../../doc/models/wifi-profiles-2.md) | Optional | Remote Wi-Fi profiles for WPA and WPA2 PSK and EAP Wi-Fi networks. |

## Example (as JSON)

```json
{
  "cardholderReceipt": {
    "headerForAuthorizedReceipt": "headerForAuthorizedReceipt8"
  },
  "connectivity": {
    "simcardStatus": "ACTIVATED",
    "terminalIPAddressURL": {
      "eventLocalUrls": [
        {
          "encrypted": false,
          "password": "password4",
          "url": "url4",
          "username": "username0"
        }
      ],
      "eventPublicUrls": [
        {
          "encrypted": false,
          "password": "password8",
          "url": "url8",
          "username": "username4"
        },
        {
          "encrypted": false,
          "password": "password8",
          "url": "url8",
          "username": "username4"
        }
      ]
    }
  },
  "gratuities": [
    {
      "allowCustomAmount": false,
      "currency": "currency0",
      "predefinedTipEntries": [
        "predefinedTipEntries0",
        "predefinedTipEntries1",
        "predefinedTipEntries2"
      ],
      "usePredefinedTipEntries": false
    },
    {
      "allowCustomAmount": false,
      "currency": "currency0",
      "predefinedTipEntries": [
        "predefinedTipEntries0",
        "predefinedTipEntries1",
        "predefinedTipEntries2"
      ],
      "usePredefinedTipEntries": false
    },
    {
      "allowCustomAmount": false,
      "currency": "currency0",
      "predefinedTipEntries": [
        "predefinedTipEntries0",
        "predefinedTipEntries1",
        "predefinedTipEntries2"
      ],
      "usePredefinedTipEntries": false
    }
  ],
  "hardware": {
    "displayMaximumBackLight": 142,
    "resetTotalsHour": 132,
    "restartHour": 110
  },
  "homeScreen": {
    "hideNavigationBar": false,
    "showPaymentsMenu": false,
    "showSettingsMenu": false
  }
}
```

