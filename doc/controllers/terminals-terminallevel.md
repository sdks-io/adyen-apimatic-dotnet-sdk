# Terminals-Terminallevel

```csharp
TerminalsTerminallevelApi terminalsTerminallevelApi = client.TerminalsTerminallevelApi;
```

## Class Name

`TerminalsTerminallevelApi`

## Methods

* [List Terminals](../../doc/controllers/terminals-terminallevel.md#list-terminals)
* [Reassign Terminal](../../doc/controllers/terminals-terminallevel.md#reassign-terminal)


# List Terminals

Returns the payment terminals that the API credential has access to and that match the query parameters.
To make this request, your API credential must have the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):

* Management API — Terminal actions read

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

```csharp
ListTerminalsAsync(
    string searchQuery = null,
    string otpQuery = null,
    string countries = null,
    string merchantIds = null,
    string storeIds = null,
    string brandModels = null,
    int? pageNumber = null,
    int? pageSize = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `searchQuery` | `string` | Query, Optional | Returns terminals with an ID that contains the specified string. If present, other query parameters are ignored. |
| `otpQuery` | `string` | Query, Optional | Returns one or more terminals associated with the one-time passwords specified in the request. If this query parameter is used, other query parameters are ignored. |
| `countries` | `string` | Query, Optional | Returns terminals located in the countries specified by their [two-letter country code](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2). |
| `merchantIds` | `string` | Query, Optional | Returns terminals that belong to the merchant accounts specified by their unique merchant account ID. |
| `storeIds` | `string` | Query, Optional | Returns terminals that are assigned to the [stores](https://docs.adyen.com/api-explorer/#/ManagementService/latest/get/stores) specified by their unique store ID. |
| `brandModels` | `string` | Query, Optional | Returns terminals of the [models](https://docs.adyen.com/api-explorer/#/ManagementService/latest/get/companies/{companyId}/terminalModels) specified in the format *brand.model*. |
| `pageNumber` | `int?` | Query, Optional | The number of the page to fetch. |
| `pageSize` | `int?` | Query, Optional | The number of items to have on a page, maximum 100. The default is 20 items on a page. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.ListTerminalsResponse](../../doc/models/list-terminals-response.md).

## Example Usage

```csharp
try
{
    ApiResponse<ListTerminalsResponse> result = await terminalsTerminalLevelApi.ListTerminalsAsync();
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
  "_links": {
    "first": {
      "href": "https://management-test.adyen.com/v3/terminals?pageNumber=1&pageSize=20"
    },
    "last": {
      "href": "https://management-test.adyen.com/v3/terminals?pageNumber=1&pageSize=20"
    },
    "next": {
      "href": "https://management-test.adyen.com/v3/terminals?pageNumber=1&pageSize=20"
    },
    "self": {
      "href": "https://management-test.adyen.com/v3/terminals?pageNumber=0&pageSize=20"
    }
  },
  "itemsTotal": 1,
  "pagesTotal": 1,
  "data": [
    {
      "id": "AMS1-000150183300032",
      "model": "AMS1",
      "serialNumber": "000150183300032",
      "firmwareVersion": "Castles_Android 1.89.4",
      "assignment": {
        "companyId": "YOUR_COMPANY_ACCOUNT",
        "merchantId": "YOUR_MERCHANT_ACCOUNT",
        "storeId": "YOUR_STORE_ID",
        "status": "reassignmentInProgress",
        "reassignmentTarget": {
          "inventory": true
        }
      },
      "connectivity": {
        "cellular": {
          "iccid": "6006491286999921374"
        },
        "wifi": {
          "ipAddress": "198.51.100.1",
          "macAddress": "C4:6E:33:26:36:E4"
        }
      }
    }
  ]
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


# Reassign Terminal

Reassigns a payment terminal to a company account, merchant account, merchant account inventory, or a store.

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):

* Management API—Assign Terminal

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

```csharp
ReassignTerminalAsync(
    string terminalId,
    Models.TerminalReassignmentRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `terminalId` | `string` | Template, Required | The unique identifier of the payment terminal. |
| `body` | [`TerminalReassignmentRequest`](../../doc/models/terminal-reassignment-request.md) | Body, Optional | - |

## Response Type

`Task`

## Example Usage

```csharp
string terminalId = "terminalId2";
TerminalReassignmentRequest body = new TerminalReassignmentRequest
{
    Inventory = false,
    MerchantId = "YOUR_MERCHANT_ID",
};

try
{
    await terminalsTerminalLevelApi.ReassignTerminalAsync(
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

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad Request - a problem reading or understanding the request. | [`RestServiceErrorException`](../../doc/models/rest-service-error-exception.md) |
| 401 | Unauthorized - authentication required. | [`RestServiceErrorException`](../../doc/models/rest-service-error-exception.md) |
| 403 | Forbidden - insufficient permissions to process the request. | [`RestServiceErrorException`](../../doc/models/rest-service-error-exception.md) |
| 422 | Unprocessable Entity - a request validation error. | [`RestServiceErrorException`](../../doc/models/rest-service-error-exception.md) |
| 500 | Internal Server Error - the server could not process the request. | [`RestServiceErrorException`](../../doc/models/rest-service-error-exception.md) |

