# Payoutsettings-Merchantlevel

```csharp
PayoutsettingsMerchantlevelApi payoutsettingsMerchantlevelApi = client.PayoutsettingsMerchantlevelApi;
```

## Class Name

`PayoutsettingsMerchantlevelApi`

## Methods

* [Get-Merchants-Merchant Id-Payout Settings](../../doc/controllers/payoutsettings-merchantlevel.md#get-merchants-merchant-id-payout-settings)
* [Post-Merchants-Merchant Id-Payout Settings](../../doc/controllers/payoutsettings-merchantlevel.md#post-merchants-merchant-id-payout-settings)
* [Delete-Merchants-Merchant Id-Payout Settings-Payout Settings Id](../../doc/controllers/payoutsettings-merchantlevel.md#delete-merchants-merchant-id-payout-settings-payout-settings-id)
* [Get-Merchants-Merchant Id-Payout Settings-Payout Settings Id](../../doc/controllers/payoutsettings-merchantlevel.md#get-merchants-merchant-id-payout-settings-payout-settings-id)
* [Patch-Merchants-Merchant Id-Payout Settings-Payout Settings Id](../../doc/controllers/payoutsettings-merchantlevel.md#patch-merchants-merchant-id-payout-settings-payout-settings-id)


# Get-Merchants-Merchant Id-Payout Settings

Returns the list of payout settings for the merchant account identified in the path.

Use this endpoint if your integration requires it, such as Adyen for Platforms Manage. Your Adyen contact will set up your access.

To make this request, your API credential must have the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):

* Management API—Payout account settings read

```csharp
GetMerchantsMerchantIdPayoutSettingsAsync(
    string merchantId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `merchantId` | `string` | Template, Required | The unique identifier of the merchant account. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.PayoutSettingsResponse](../../doc/models/payout-settings-response.md).

## Example Usage

```csharp
string merchantId = "merchantId6";
try
{
    ApiResponse<PayoutSettingsResponse> result = await payoutSettingsMerchantLevelApi.GetMerchantsMerchantIdPayoutSettingsAsync(merchantId);
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


# Post-Merchants-Merchant Id-Payout Settings

Sends a request to add a payout setting for the merchant account specified in the path. A payout setting links the merchant account to the [transfer instrument](https://docs.adyen.com/api-explorer/#/legalentity/latest/post/transferInstruments) that contains the details of the payout bank account. Adyen verifies the bank account before allowing and enabling the payout setting.

If you're accepting payments in multiple currencies, you may add multiple payout settings for the merchant account.

Use this endpoint if your integration requires it, such as Adyen for Platforms Manage. Your Adyen contact will set up your access.

To make this request, your API credential must have the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):

* Management API—Payout account settings read and write

```csharp
PostMerchantsMerchantIdPayoutSettingsAsync(
    string merchantId,
    Models.PayoutSettingsRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `merchantId` | `string` | Template, Required | The unique identifier of the merchant account. |
| `body` | [`PayoutSettingsRequest`](../../doc/models/payout-settings-request.md) | Body, Optional | - |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.PayoutSettings](../../doc/models/payout-settings.md).

## Example Usage

```csharp
string merchantId = "merchantId6";
try
{
    ApiResponse<PayoutSettings> result = await payoutSettingsMerchantLevelApi.PostMerchantsMerchantIdPayoutSettingsAsync(merchantId);
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


# Delete-Merchants-Merchant Id-Payout Settings-Payout Settings Id

Deletes the payout setting identified in the path.

Use this endpoint if your integration requires it, such as Adyen for Platforms Manage. Your Adyen contact will set up your access.

To make this request, your API credential must have the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):

* Management API—Payout account settings read and write

```csharp
DeleteMerchantsMerchantIdPayoutSettingsPayoutSettingsIdAsync(
    string merchantId,
    string payoutSettingsId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `merchantId` | `string` | Template, Required | The unique identifier of the merchant account. |
| `payoutSettingsId` | `string` | Template, Required | The unique identifier of the payout setting. |

## Response Type

`Task`

## Example Usage

```csharp
string merchantId = "merchantId6";
string payoutSettingsId = "payoutSettingsId6";
try
{
    await payoutSettingsMerchantLevelApi.DeleteMerchantsMerchantIdPayoutSettingsPayoutSettingsIdAsync(
        merchantId,
        payoutSettingsId
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


# Get-Merchants-Merchant Id-Payout Settings-Payout Settings Id

Returns the payout setting identified in the path.

Use this endpoint if your integration requires it, such as Adyen for Platforms Manage. Your Adyen contact will set up your access.

To make this request, your API credential must have the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):

* Management API—Payout account settings read

```csharp
GetMerchantsMerchantIdPayoutSettingsPayoutSettingsIdAsync(
    string merchantId,
    string payoutSettingsId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `merchantId` | `string` | Template, Required | The unique identifier of the merchant account. |
| `payoutSettingsId` | `string` | Template, Required | The unique identifier of the payout setting. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.PayoutSettings](../../doc/models/payout-settings.md).

## Example Usage

```csharp
string merchantId = "merchantId6";
string payoutSettingsId = "payoutSettingsId6";
try
{
    ApiResponse<PayoutSettings> result = await payoutSettingsMerchantLevelApi.GetMerchantsMerchantIdPayoutSettingsPayoutSettingsIdAsync(
        merchantId,
        payoutSettingsId
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


# Patch-Merchants-Merchant Id-Payout Settings-Payout Settings Id

Updates the payout setting identified in the path. You can enable or disable the payout setting.

Use this endpoint if your integration requires it, such as Adyen for Platforms Manage. Your Adyen contact will set up your access.

To make this request, your API credential must have the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):

* Management API—Payout account settings read and write

```csharp
PatchMerchantsMerchantIdPayoutSettingsPayoutSettingsIdAsync(
    string merchantId,
    string payoutSettingsId,
    Models.UpdatePayoutSettingsRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `merchantId` | `string` | Template, Required | The unique identifier of the merchant account. |
| `payoutSettingsId` | `string` | Template, Required | The unique identifier of the payout setting. |
| `body` | [`UpdatePayoutSettingsRequest`](../../doc/models/update-payout-settings-request.md) | Body, Optional | - |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.PayoutSettings](../../doc/models/payout-settings.md).

## Example Usage

```csharp
string merchantId = "merchantId6";
string payoutSettingsId = "payoutSettingsId6";
try
{
    ApiResponse<PayoutSettings> result = await payoutSettingsMerchantLevelApi.PatchMerchantsMerchantIdPayoutSettingsPayoutSettingsIdAsync(
        merchantId,
        payoutSettingsId
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

