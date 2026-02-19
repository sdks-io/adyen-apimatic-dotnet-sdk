# Terminalactions-Terminallevel

```csharp
TerminalactionsTerminallevelApi terminalactionsTerminallevelApi = client.TerminalactionsTerminallevelApi;
```

## Class Name

`TerminalactionsTerminallevelApi`


# Post-Terminals-Schedule Actions

Schedules a [terminal action](https://docs.adyen.com/point-of-sale/automating-terminal-management/terminal-actions-api) by specifying the action and the terminals that the action must be applied to.

The following restrictions apply:

* You can schedule only one action at a time. For example, to install a new app version and remove an old app version, you have to make two API requests.
* The maximum number of terminals in a request is **100**. For example, to apply an action to 250 terminals, you have to divide the terminals over three API requests.
* If there is an error with one or more terminal IDs in the request, the action is scheduled for none of the terminals. You need to fix the error and try again.

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):

* Management API—Terminal actions read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

```csharp
PostTerminalsScheduleActionsAsync(
    Models.ScheduleTerminalActionsRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`ScheduleTerminalActionsRequest`](../../doc/models/schedule-terminal-actions-request.md) | Body, Optional | - |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.ScheduleTerminalActionsResponse](../../doc/models/schedule-terminal-actions-response.md).

## Example Usage

```csharp
ScheduleTerminalActionsRequest body = new ScheduleTerminalActionsRequest
{
    ActionDetails = ScheduleTerminalActionsRequestActionDetails.FromInstallAndroidAppDetails(
        new InstallAndroidAppDetails
        {
            AppId = "ANDA422LZ223223K5F694GCCF732K8",
            Type = Type27.InstallAndroidApp,
        }
    ),
    ScheduledAt = "2021-12-12T20:21:22-0100",
    StoreId = "",
    TerminalIds = new List<string>
    {
        "S1E-000150183300032",
        "S1E-000150183300033",
        "S1F2-000150183300034",
    },
};

try
{
    ApiResponse<ScheduleTerminalActionsResponse> result = await terminalActionsTerminalLevelApi.PostTerminalsScheduleActionsAsync(body);
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
  "actionDetails": {
    "appId": "ANDA422LZ223223K5F694GCCF732K8",
    "type": "InstallAndroidApp"
  },
  "scheduledAt": "2021-12-12T20:21:22-0100",
  "storeId": "",
  "items": [
    {
      "id": "TRAC422T2223223K5GFMQHM6WQ4KB6",
      "terminalId": "S1E-000150183300032"
    },
    {
      "id": "TRAC4224X22338VQ5GD4CQJCQT5PC2",
      "terminalId": "S1E-000150183300033"
    },
    {
      "id": "TRAC4224Z223223K5GD89RLBWQ6CWT",
      "terminalId": "S1F2-000150183300034"
    }
  ],
  "terminalsWithErrors": {},
  "totalScheduled": 3,
  "totalErrors": 0
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

