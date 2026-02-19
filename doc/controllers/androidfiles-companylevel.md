# Androidfiles-Companylevel

```csharp
AndroidfilesCompanylevelApi androidfilesCompanylevelApi = client.AndroidfilesCompanylevelApi;
```

## Class Name

`AndroidfilesCompanylevelApi`

## Methods

* [Get-Companies-Company Id-Android Apps](../../doc/controllers/androidfiles-companylevel.md#get-companies-company-id-android-apps)
* [Post-Companies-Company Id-Android Apps](../../doc/controllers/androidfiles-companylevel.md#post-companies-company-id-android-apps)
* [Get-Companies-Company Id-Android Apps-Id](../../doc/controllers/androidfiles-companylevel.md#get-companies-company-id-android-apps-id)
* [Patch-Companies-Company Id-Android Apps-Id](../../doc/controllers/androidfiles-companylevel.md#patch-companies-company-id-android-apps-id)
* [Get-Companies-Company Id-Android Certificates](../../doc/controllers/androidfiles-companylevel.md#get-companies-company-id-android-certificates)
* [Post-Companies-Company Id-Android Certificates](../../doc/controllers/androidfiles-companylevel.md#post-companies-company-id-android-certificates)


# Get-Companies-Company Id-Android Apps

Returns a list of the Android apps that are available for the company identified in the path.
These apps have been uploaded to Adyen and can be installed or uninstalled on Android payment terminals through [terminal actions](https://docs.adyen.com/point-of-sale/automating-terminal-management/terminal-actions-api).

To make this request, your API credential must have one of the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):

* Management API—Android files read
* Management API—Android files read and write
* Management API—Terminal actions read
* Management API—Terminal actions read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

```csharp
GetCompaniesCompanyIdAndroidAppsAsync(
    string companyId,
    int? pageNumber = null,
    int? pageSize = null,
    string packageName = null,
    int? versionCode = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `companyId` | `string` | Template, Required | The unique identifier of the company account. |
| `pageNumber` | `int?` | Query, Optional | The number of the page to fetch. |
| `pageSize` | `int?` | Query, Optional | The number of items to have on a page, maximum 100. The default is 20 items on a page. |
| `packageName` | `string` | Query, Optional | The package name that uniquely identifies the Android app. |
| `versionCode` | `int?` | Query, Optional | The version number of the app. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.AndroidAppsResponse](../../doc/models/android-apps-response.md).

## Example Usage

```csharp
string companyId = "companyId0";
try
{
    ApiResponse<AndroidAppsResponse> result = await androidFilesCompanyLevelApi.GetCompaniesCompanyIdAndroidAppsAsync(companyId);
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
  "data": [
    {
      "id": "ANDA422LZ223223K5F694GCCF732K8",
      "packageName": "com.your_company.posapp",
      "versionCode": 7700203,
      "description": "POS2",
      "label": "POS system",
      "versionName": "7.7",
      "status": "ready"
    },
    {
      "id": "ANDA422LZ223223K5F694FWCF738PL",
      "packageName": "com.your_company.posapp",
      "versionCode": 7602003,
      "description": "POS1",
      "label": "POS system",
      "versionName": "7.6",
      "status": "ready"
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


# Post-Companies-Company Id-Android Apps

Uploads an Android APK file to Adyen.
The maximum APK file size is 200 MB.
To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):

* Management API—Android files read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

> By choosing to upload, install, or run any third-party applications on an Adyen payment terminal, you accept full responsibility and liability for any consequences of uploading, installing, or running any such applications.

```csharp
PostCompaniesCompanyIdAndroidAppsAsync(
    string companyId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `companyId` | `string` | Template, Required | The unique identifier of the company account. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.UploadAndroidAppResponse](../../doc/models/upload-android-app-response.md).

## Example Usage

```csharp
string companyId = "companyId0";
try
{
    ApiResponse<UploadAndroidAppResponse> result = await androidFilesCompanyLevelApi.PostCompaniesCompanyIdAndroidAppsAsync(companyId);
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


# Get-Companies-Company Id-Android Apps-Id

Returns the details of the Android app identified in the path.
These apps have been uploaded to Adyen and can be installed or uninstalled on Android payment terminals through [terminal actions](https://docs.adyen.com/point-of-sale/automating-terminal-management/terminal-actions-api).

To make this request, your API credential must have one of the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):

* Management API—Android files read
* Management API—Android files read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

```csharp
GetCompaniesCompanyIdAndroidAppsIdAsync(
    string companyId,
    string id)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `companyId` | `string` | Template, Required | The unique identifier of the company account. |
| `id` | `string` | Template, Required | The unique identifier of the app. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.AndroidApp](../../doc/models/android-app.md).

## Example Usage

```csharp
string companyId = "companyId0";
string id = "id0";
try
{
    ApiResponse<AndroidApp> result = await androidFilesCompanyLevelApi.GetCompaniesCompanyIdAndroidAppsIdAsync(
        companyId,
        id
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


# Patch-Companies-Company Id-Android Apps-Id

Reuploads the Android app identified in the path.
To make this request, your API credential must have this [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):

* Management API—Android files read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

> By choosing to upload, install, or run any third-party applications on an Adyen payment terminal, you accept full responsibility and liability for any consequences of uploading, installing, or running any such applications.

```csharp
PatchCompaniesCompanyIdAndroidAppsIdAsync(
    string companyId,
    string id)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `companyId` | `string` | Template, Required | The unique identifier of the company account. |
| `id` | `string` | Template, Required | The unique identifier of the app. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.ReprocessAndroidAppResponse](../../doc/models/reprocess-android-app-response.md).

## Example Usage

```csharp
string companyId = "companyId0";
string id = "id0";
try
{
    ApiResponse<ReprocessAndroidAppResponse> result = await androidFilesCompanyLevelApi.PatchCompaniesCompanyIdAndroidAppsIdAsync(
        companyId,
        id
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


# Get-Companies-Company Id-Android Certificates

Returns a list of the Android certificates that are available for the company identified in the path.
Typically, these certificates enable running apps on Android payment terminals. The certificates in the list have been uploaded to Adyen and can be installed or uninstalled on Android terminals through [terminal actions](https://docs.adyen.com/point-of-sale/automating-terminal-management/terminal-actions-api).

To make this request, your API credential must have one of the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):

* Management API—Android files read
* Management API—Android files read and write
* Management API—Terminal actions read
* Management API—Terminal actions read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

```csharp
GetCompaniesCompanyIdAndroidCertificatesAsync(
    string companyId,
    int? pageNumber = null,
    int? pageSize = null,
    string certificateName = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `companyId` | `string` | Template, Required | The unique identifier of the company account. |
| `pageNumber` | `int?` | Query, Optional | The number of the page to fetch. |
| `pageSize` | `int?` | Query, Optional | The number of items to have on a page, maximum 100. The default is 20 items on a page. |
| `certificateName` | `string` | Query, Optional | The name of the certificate. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.AndroidCertificatesResponse](../../doc/models/android-certificates-response.md).

## Example Usage

```csharp
string companyId = "companyId0";
try
{
    ApiResponse<AndroidCertificatesResponse> result = await androidFilesCompanyLevelApi.GetCompaniesCompanyIdAndroidCertificatesAsync(companyId);
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
  "data": [
    {
      "id": "ANDC422LZ223223K5F78NVN9SL4VPH",
      "name": "mycert",
      "extension": ".crt",
      "description": "",
      "status": "ready",
      "notBefore": "2008-04-20T00:00:00+02:00",
      "notAfter": "2038-04-12T00:00:00+02:00"
    },
    {
      "id": "ANDC533MA33433L689OWO0TM5WQI",
      "name": "mynewcert",
      "extension": ".pem",
      "description": "",
      "status": "ready",
      "notBefore": "2008-04-20T00:00:00+02:00",
      "notAfter": "2048-04-12T00:00:00+02:00"
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


# Post-Companies-Company Id-Android Certificates

Uploads an Android Certificate file to Adyen.

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

```csharp
PostCompaniesCompanyIdAndroidCertificatesAsync(
    string companyId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `companyId` | `string` | Template, Required | The unique identifier of the company account. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.UploadAndroidCertificateResponse](../../doc/models/upload-android-certificate-response.md).

## Example Usage

```csharp
string companyId = "companyId0";
try
{
    ApiResponse<UploadAndroidCertificateResponse> result = await androidFilesCompanyLevelApi.PostCompaniesCompanyIdAndroidCertificatesAsync(companyId);
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

