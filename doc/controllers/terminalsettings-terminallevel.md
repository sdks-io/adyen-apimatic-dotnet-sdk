# Terminalsettings-Terminallevel

```csharp
TerminalsettingsTerminallevelApi terminalsettingsTerminallevelApi = client.TerminalsettingsTerminallevelApi;
```

## Class Name

`TerminalsettingsTerminallevelApi`

## Methods

* [Get-Terminals-Terminal Id-Terminal Logos](../../doc/controllers/terminalsettings-terminallevel.md#get-terminals-terminal-id-terminal-logos)
* [Patch-Terminals-Terminal Id-Terminal Logos](../../doc/controllers/terminalsettings-terminallevel.md#patch-terminals-terminal-id-terminal-logos)
* [Get-Terminals-Terminal Id-Terminal Settings](../../doc/controllers/terminalsettings-terminallevel.md#get-terminals-terminal-id-terminal-settings)
* [Patch-Terminals-Terminal Id-Terminal Settings](../../doc/controllers/terminalsettings-terminallevel.md#patch-terminals-terminal-id-terminal-settings)


# Get-Terminals-Terminal Id-Terminal Logos

Returns the logo that is configured for the payment terminal identified in the path.
The logo is returned as a Base64-encoded string. You need to Base64-decode the string to get the actual image file.

To make this request, your API credential must have one of the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):

* Management API—Terminal settings read
* Management API—Terminal settings read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

```csharp
GetTerminalsTerminalIdTerminalLogosAsync(
    string terminalId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `terminalId` | `string` | Template, Required | The unique identifier of the payment terminal. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.Logo](../../doc/models/logo.md).

## Example Usage

```csharp
string terminalId = "terminalId2";
try
{
    ApiResponse<Logo> result = await terminalSettingsTerminalLevelApi.GetTerminalsTerminalIdTerminalLogosAsync(terminalId);
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is RestServiceErrorException)
    {
       // TODO: Handle RestServiceErrorException exception here
    }
}
```

## Example Response *(as JSON)*

```json
{
  "data": "BASE-64_ENCODED_STRING"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad Request - a problem reading or understanding the request. | [`RestServiceErrorException`](../../doc/models/rest-service-error-exception.md) |
| 401 | Unauthorized - authentication required. | [`RestServiceErrorException`](../../doc/models/rest-service-error-exception.md) |
| 403 | Forbidden - insufficient permissions to process the request. | [`RestServiceErrorException`](../../doc/models/rest-service-error-exception.md) |
| 422 | Unprocessable Entity - a request validation error. | [`RestServiceErrorException`](../../doc/models/rest-service-error-exception.md) |
| 500 | Internal Server Error - the server could not process the request. | [`RestServiceErrorException`](../../doc/models/rest-service-error-exception.md) |


# Patch-Terminals-Terminal Id-Terminal Logos

Updates the logo for the payment terminal identified in the path.

* To change the logo, specify the image file as a Base64-encoded string.
* To restore the logo inherited from a higher level (store, merchant account, or company account), specify an empty logo value.

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):

* Management API—Terminal settings read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

```csharp
PatchTerminalsTerminalIdTerminalLogosAsync(
    string terminalId,
    Models.Logo body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `terminalId` | `string` | Template, Required | The unique identifier of the payment terminal. |
| `body` | [`Logo`](../../doc/models/logo.md) | Body, Optional | - |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.Logo](../../doc/models/logo.md).

## Example Usage

```csharp
string terminalId = "terminalId2";
Logo body = new Logo
{
    Data = "",
};

try
{
    ApiResponse<Logo> result = await terminalSettingsTerminalLevelApi.PatchTerminalsTerminalIdTerminalLogosAsync(
        terminalId,
        body
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is RestServiceErrorException)
    {
       // TODO: Handle RestServiceErrorException exception here
    }
}
```

## Example Response *(as JSON)*

```json
{
  "data": "LOGO_INHERITED_FROM_HIGHER_LEVEL_BASE-64_ENCODED_STRING"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad Request - a problem reading or understanding the request. | [`RestServiceErrorException`](../../doc/models/rest-service-error-exception.md) |
| 401 | Unauthorized - authentication required. | [`RestServiceErrorException`](../../doc/models/rest-service-error-exception.md) |
| 403 | Forbidden - insufficient permissions to process the request. | [`RestServiceErrorException`](../../doc/models/rest-service-error-exception.md) |
| 422 | Unprocessable Entity - a request validation error. | [`RestServiceErrorException`](../../doc/models/rest-service-error-exception.md) |
| 500 | Internal Server Error - the server could not process the request. | [`RestServiceErrorException`](../../doc/models/rest-service-error-exception.md) |


# Get-Terminals-Terminal Id-Terminal Settings

Returns the settings that are configured for the payment terminal identified in the path.

To make this request, your API credential must have one of the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):

* Management API—Terminal settings read
* Management API—Terminal settings read and write

For [sensitive terminal settings](https://docs.adyen.com/point-of-sale/automating-terminal-management/configure-terminals-api#sensitive-terminal-settings), your API credential must have the following role:

* Management API—Terminal settings Advanced read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

```csharp
GetTerminalsTerminalIdTerminalSettingsAsync(
    string terminalId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `terminalId` | `string` | Template, Required | The unique identifier of the payment terminal. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.TerminalSettings](../../doc/models/terminal-settings.md).

## Example Usage

```csharp
string terminalId = "terminalId2";
try
{
    ApiResponse<TerminalSettings> result = await terminalSettingsTerminalLevelApi.GetTerminalsTerminalIdTerminalSettingsAsync(terminalId);
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is RestServiceErrorException)
    {
       // TODO: Handle RestServiceErrorException exception here
    }
}
```

## Example Response *(as JSON)*

```json
{
  "cardholderReceipt": {
    "headerForAuthorizedReceipt": "header1,header2,filler"
  },
  "gratuities": [
    {
      "currency": "EUR",
      "usePredefinedTipEntries": true,
      "predefinedTipEntries": [
        "100",
        "1%",
        "5%"
      ],
      "allowCustomAmount": true
    }
  ],
  "nexo": {
    "displayUrls": {
      "localUrls": [
        {
          "password": "BASIC_AUTH_PASSWORD",
          "url": "https://your-display-notifications-endpoint.com",
          "username": "BASIC_AUTH_USERNAME"
        }
      ]
    },
    "encryptionKey": {
      "identifier": "KEY_IDENTIFIER",
      "passphrase": "KEY_PASSPHRASE",
      "version": 1
    },
    "eventUrls": {
      "eventPublicUrls": [
        {
          "password": "BASIC_AUTH_PASSWORD",
          "url": "https://your-event-notifications-endpoint.com",
          "username": "BASIC_AUTH_USERNAME"
        }
      ]
    },
    "notification": {
      "showButton": true
    }
  },
  "opi": {
    "enablePayAtTable": true,
    "payAtTableStoreNumber": "1",
    "payAtTableURL": "https:/your-pay-at-table-endpoint.com"
  },
  "offlineProcessing": {
    "chipFloorLimit": 0
  },
  "receiptOptions": {
    "qrCodeData": "http://www.example.com/order/${pspreference}/${merchantreference}"
  },
  "receiptPrinting": {
    "shopperApproved": true,
    "shopperRefused": true,
    "shopperCancelled": true,
    "shopperRefundApproved": true,
    "shopperRefundRefused": true,
    "shopperVoid": true
  },
  "signature": {
    "askSignatureOnScreen": true,
    "skipSignature": false,
    "deviceName": "Amsterdam-236203386"
  },
  "wifiProfiles": {
    "profiles": [
      {
        "authType": "wpa-psk",
        "autoWifi": false,
        "bssType": "infra",
        "channel": 0,
        "defaultProfile": true,
        "hiddenSsid": false,
        "name": "Guest Wi-Fi",
        "psk": "4R8R2R3V456X",
        "ssid": "G470P37660D4G",
        "wsec": "ccmp"
      }
    ],
    "settings": {
      "band": "All",
      "roaming": true
    }
  },
  "timeouts": {
    "fromActiveToSleep": 30
  },
  "hardware": {
    "displayMaximumBackLight": 75,
    "restartHour": 5
  },
  "passcodes": {
    "adminMenuPin": "1234",
    "txMenuPin": "1234",
    "refundPin": "123456",
    "screenLockPin": "1234"
  },
  "connectivity": {
    "simcardStatus": "INVENTORY"
  },
  "storeAndForward": {
    "maxAmount": [
      {
        "amount": 10000,
        "currencyCode": "EUR"
      }
    ],
    "maxPayments": 10,
    "supportedCardTypes": {
      "credit": true,
      "debit": true,
      "deferredDebit": true,
      "prepaid": true,
      "unknown": false
    }
  },
  "terminalInstructions": {
    "adyenAppRestart": true
  }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad Request - a problem reading or understanding the request. | [`RestServiceErrorException`](../../doc/models/rest-service-error-exception.md) |
| 401 | Unauthorized - authentication required. | [`RestServiceErrorException`](../../doc/models/rest-service-error-exception.md) |
| 403 | Forbidden - insufficient permissions to process the request. | [`RestServiceErrorException`](../../doc/models/rest-service-error-exception.md) |
| 422 | Unprocessable Entity - a request validation error. | [`RestServiceErrorException`](../../doc/models/rest-service-error-exception.md) |
| 500 | Internal Server Error - the server could not process the request. | [`RestServiceErrorException`](../../doc/models/rest-service-error-exception.md) |


# Patch-Terminals-Terminal Id-Terminal Settings

Updates the settings that are configured for the payment terminal identified in the path.

* To change a parameter value, include the full object that contains the parameter, even if you don't want to change all parameters in the object.
* To restore a parameter value inherited from a higher level, include the full object that contains the parameter, and specify an empty value for the parameter or omit the parameter.
* Objects that are not included in the request are not updated.

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):

* Management API—Terminal settings read and write

For [sensitive terminal settings](https://docs.adyen.com/point-of-sale/automating-terminal-management/configure-terminals-api#sensitive-terminal-settings), your API credential must have the following role:

* Management API—Terminal settings Advanced read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

```csharp
PatchTerminalsTerminalIdTerminalSettingsAsync(
    string terminalId,
    Models.TerminalSettings body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `terminalId` | `string` | Template, Required | The unique identifier of the payment terminal. |
| `body` | [`TerminalSettings`](../../doc/models/terminal-settings.md) | Body, Optional | - |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.TerminalSettings](../../doc/models/terminal-settings.md).

## Example Usage

```csharp
string terminalId = "terminalId2";
TerminalSettings body = new TerminalSettings
{
    WifiProfiles = new WifiProfiles2
    {
        Profiles = new List<Profile>
        {
            new Profile
            {
                AuthType = "wpa-eap",
                BssType = "infra",
                Ssid = "your-network",
                Wsec = "ccmp",
                AutoWifi = false,
                Channel = 0,
                DefaultProfile = true,
                Eap = "peap",
                EapCaCert = new File1
                {
                    Data = "MD1rKS05M2JqRVFNQ...RTtLH1tLWo=",
                    Name = "eap-peap-ca.pem",
                },
                EapIdentity = "admin",
                EapIntermediateCert = new File4
                {
                    Data = "PD3tUS1CRDdJTiGDR...EFoLS0tLQg=",
                    Name = "eap-peap-client.pem",
                },
                EapPwd = "EAP_PEAP_PASSWORD",
                HiddenSsid = false,
                Name = "Profile-eap-peap-1",
            },
            new Profile
            {
                AuthType = "wpa-psk",
                BssType = "infra",
                Ssid = "your-network",
                Wsec = "ccmp",
                AutoWifi = false,
                Channel = 0,
                DefaultProfile = false,
                HiddenSsid = false,
                Name = "Profile-guest-wifi",
                Psk = "WIFI_PASSWORD",
            },
        },
        Settings = new Settings1
        {
            Band = "2.4GHz",
            Roaming = true,
            Timeout = 5,
        },
    },
};

try
{
    ApiResponse<TerminalSettings> result = await terminalSettingsTerminalLevelApi.PatchTerminalsTerminalIdTerminalSettingsAsync(
        terminalId,
        body
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is RestServiceErrorException)
    {
       // TODO: Handle RestServiceErrorException exception here
    }
}
```

## Example Response *(as JSON)*

```json
{
  "cardholderReceipt": {
    "headerForAuthorizedReceipt": "header1,header2,filler"
  },
  "gratuities": [
    {
      "currency": "EUR",
      "usePredefinedTipEntries": true,
      "predefinedTipEntries": [
        "100",
        "1%",
        "5%"
      ],
      "allowCustomAmount": true
    }
  ],
  "nexo": {
    "displayUrls": {
      "localUrls": [
        {
          "password": "BASIC_AUTH_PASSWORD",
          "url": "https://your-display-notifications-endpoint.com",
          "username": "BASIC_AUTH_USERNAME"
        }
      ]
    },
    "encryptionKey": {
      "identifier": "KEY_IDENTIFIER",
      "passphrase": "KEY_PASSPHRASE",
      "version": 1
    },
    "eventUrls": {
      "eventPublicUrls": [
        {
          "password": "BASIC_AUTH_PASSWORD",
          "url": "https://your-event-notifications-endpoint.com",
          "username": "BASIC_AUTH_USERNAME"
        }
      ]
    },
    "notification": {
      "showButton": true
    }
  },
  "opi": {
    "enablePayAtTable": true,
    "payAtTableStoreNumber": "1",
    "payAtTableURL": "https:/your-pay-at-table-endpoint.com"
  },
  "offlineProcessing": {
    "chipFloorLimit": 0
  },
  "receiptOptions": {
    "qrCodeData": "http://www.example.com/order/${pspreference}/${merchantreference}"
  },
  "receiptPrinting": {
    "shopperApproved": true,
    "shopperRefused": true,
    "shopperCancelled": true,
    "shopperRefundApproved": true,
    "shopperRefundRefused": true,
    "shopperVoid": true
  },
  "signature": {
    "askSignatureOnScreen": true,
    "skipSignature": false,
    "deviceName": "Amsterdam-236203386"
  },
  "wifiProfiles": {
    "profiles": [
      {
        "authType": "wpa-eap",
        "autoWifi": false,
        "bssType": "infra",
        "channel": 0,
        "defaultProfile": true,
        "eap": "peap",
        "eapCaCert": {
          "data": "MD1rKS05M2JqRVFNQ...RTtLH1tLWo=",
          "name": "eap-peap-ca.pem"
        },
        "eapIdentity": "admin",
        "eapIntermediateCert": {
          "data": "PD3tUS1CRDdJTiGDR...EFoLS0tLQg=",
          "name": "eap-peap-client.pem"
        },
        "eapPwd": "EAP_PEAP_PASSWORD",
        "hiddenSsid": false,
        "name": "Profile-eap-peap-1",
        "ssid": "your-network",
        "wsec": "ccmp"
      },
      {
        "authType": "wpa-psk",
        "autoWifi": false,
        "bssType": "infra",
        "channel": 0,
        "defaultProfile": false,
        "hiddenSsid": false,
        "name": "Profile-guest-wifi",
        "psk": "WIFI_PASSWORD",
        "ssid": "your-network",
        "wsec": "ccmp"
      }
    ],
    "settings": {
      "band": "2.4GHz",
      "roaming": true,
      "timeout": 5
    }
  },
  "timeouts": {
    "fromActiveToSleep": 30
  },
  "hardware": {
    "displayMaximumBackLight": 75,
    "restartHour": 5
  },
  "passcodes": {
    "adminMenuPin": "1234",
    "txMenuPin": "1234",
    "refundPin": "123456",
    "screenLockPin": "1111"
  },
  "connectivity": {
    "simcardStatus": "INVENTORY"
  }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad Request - a problem reading or understanding the request. | [`RestServiceErrorException`](../../doc/models/rest-service-error-exception.md) |
| 401 | Unauthorized - authentication required. | [`RestServiceErrorException`](../../doc/models/rest-service-error-exception.md) |
| 403 | Forbidden - insufficient permissions to process the request. | [`RestServiceErrorException`](../../doc/models/rest-service-error-exception.md) |
| 422 | Unprocessable Entity - a request validation error. | [`RestServiceErrorException`](../../doc/models/rest-service-error-exception.md) |
| 500 | Internal Server Error - the server could not process the request. | [`RestServiceErrorException`](../../doc/models/rest-service-error-exception.md) |

