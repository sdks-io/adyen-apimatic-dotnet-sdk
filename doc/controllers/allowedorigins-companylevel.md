# Allowedorigins-Companylevel

```csharp
AllowedoriginsCompanylevelApi allowedoriginsCompanylevelApi = client.AllowedoriginsCompanylevelApi;
```

## Class Name

`AllowedoriginsCompanylevelApi`

## Methods

* [Get-Companies-Company Id-Api Credentials-Api Credential Id-Allowed Origins](../../doc/controllers/allowedorigins-companylevel.md#get-companies-company-id-api-credentials-api-credential-id-allowed-origins)
* [Post-Companies-Company Id-Api Credentials-Api Credential Id-Allowed Origins](../../doc/controllers/allowedorigins-companylevel.md#post-companies-company-id-api-credentials-api-credential-id-allowed-origins)
* [Delete-Companies-Company Id-Api Credentials-Api Credential Id-Allowed Origins-Origin Id](../../doc/controllers/allowedorigins-companylevel.md#delete-companies-company-id-api-credentials-api-credential-id-allowed-origins-origin-id)
* [Get-Companies-Company Id-Api Credentials-Api Credential Id-Allowed Origins-Origin Id](../../doc/controllers/allowedorigins-companylevel.md#get-companies-company-id-api-credentials-api-credential-id-allowed-origins-origin-id)


# Get-Companies-Company Id-Api Credentials-Api Credential Id-Allowed Origins

Returns the list of [allowed origins](https://docs.adyen.com/development-resources/client-side-authentication#allowed-origins) for the API credential identified in the path.

To make this request, your API credential must have the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):

* Management API—API credentials read and write

```csharp
GetCompaniesCompanyIdApiCredentialsApiCredentialIdAllowedOriginsAsync(
    string companyId,
    string apiCredentialId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `companyId` | `string` | Template, Required | The unique identifier of the company account. |
| `apiCredentialId` | `string` | Template, Required | Unique identifier of the API credential. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.AllowedOriginsResponse](../../doc/models/allowed-origins-response.md).

## Example Usage

```csharp
string companyId = "companyId0";
string apiCredentialId = "apiCredentialId8";
try
{
    ApiResponse<AllowedOriginsResponse> result = await allowedOriginsCompanyLevelApi.GetCompaniesCompanyIdApiCredentialsApiCredentialIdAllowedOriginsAsync(
        companyId,
        apiCredentialId
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
  "data": [
    {
      "id": "YOUR_ALLOWED_ORIGIN_1",
      "domain": "https://www.eu.mystore.com",
      "_links": {
        "self": {
          "href": "https://management-test.adyen.com/v1/companies/YOUR_COMPANY_ACCOUNT/apiCredentials/YOUR_API_CREDENTIAL/allowedOrigins/YOUR_ALLOWED_ORIGIN_1"
        }
      }
    },
    {
      "id": "YOUR_ALLOWED_ORIGIN_2",
      "domain": "https://www.us.mystore.com",
      "_links": {
        "self": {
          "href": "https://management-test.adyen.com/v1/companies/YOUR_COMPANY_ACCOUNT/apiCredentials/YOUR_API_CREDENTIAL/allowedOrigins/YOUR_ALLOWED_ORIGIN_2"
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


# Post-Companies-Company Id-Api Credentials-Api Credential Id-Allowed Origins

Adds a new [allowed origin](https://docs.adyen.com/development-resources/client-side-authentication#allowed-origins) to the API credential's list of allowed origins.

To make this request, your API credential must have the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):

* Management API—API credentials read and write

```csharp
PostCompaniesCompanyIdApiCredentialsApiCredentialIdAllowedOriginsAsync(
    string companyId,
    string apiCredentialId,
    Models.AllowedOrigin body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `companyId` | `string` | Template, Required | The unique identifier of the company account. |
| `apiCredentialId` | `string` | Template, Required | Unique identifier of the API credential. |
| `body` | [`AllowedOrigin`](../../doc/models/allowed-origin.md) | Body, Optional | - |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.AllowedOrigin](../../doc/models/allowed-origin.md).

## Example Usage

```csharp
string companyId = "companyId0";
string apiCredentialId = "apiCredentialId8";
AllowedOrigin body = new AllowedOrigin
{
    Domain = "https://www.eu.mystore.com",
};

try
{
    ApiResponse<AllowedOrigin> result = await allowedOriginsCompanyLevelApi.PostCompaniesCompanyIdApiCredentialsApiCredentialIdAllowedOriginsAsync(
        companyId,
        apiCredentialId,
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
  "id": "YOUR_ALLOWED_ORIGIN",
  "domain": "https://www.eu.mystore.com",
  "_links": {
    "self": {
      "href": "https://management-test.adyen.com/v1/companies/YOUR_COMPANY_ACCOUNT/apiCredentials/YOUR_API_CREDENTIAL/allowedOrigins/YOUR_ALLOWED_ORIGIN"
    }
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


# Delete-Companies-Company Id-Api Credentials-Api Credential Id-Allowed Origins-Origin Id

Removes the [allowed origin](https://docs.adyen.com/development-resources/client-side-authentication#allowed-origins) identified in the path. As soon as an allowed origin is removed, we no longer accept client-side requests from that domain.

To make this request, your API credential must have the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):

* Management API—API credentials read and write

```csharp
DeleteCompaniesCompanyIdApiCredentialsApiCredentialIdAllowedOriginsOriginIdAsync(
    string companyId,
    string apiCredentialId,
    string originId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `companyId` | `string` | Template, Required | The unique identifier of the company account. |
| `apiCredentialId` | `string` | Template, Required | Unique identifier of the API credential. |
| `originId` | `string` | Template, Required | Unique identifier of the allowed origin. |

## Response Type

`Task`

## Example Usage

```csharp
string companyId = "companyId0";
string apiCredentialId = "apiCredentialId8";
string originId = "originId6";
try
{
    await allowedOriginsCompanyLevelApi.DeleteCompaniesCompanyIdApiCredentialsApiCredentialIdAllowedOriginsOriginIdAsync(
        companyId,
        apiCredentialId,
        originId
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


# Get-Companies-Company Id-Api Credentials-Api Credential Id-Allowed Origins-Origin Id

Returns the [allowed origin](https://docs.adyen.com/development-resources/client-side-authentication#allowed-origins) identified in the path.

To make this request, your API credential must have the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):

* Management API—API credentials read and write

```csharp
GetCompaniesCompanyIdApiCredentialsApiCredentialIdAllowedOriginsOriginIdAsync(
    string companyId,
    string apiCredentialId,
    string originId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `companyId` | `string` | Template, Required | The unique identifier of the company account. |
| `apiCredentialId` | `string` | Template, Required | Unique identifier of the API credential. |
| `originId` | `string` | Template, Required | Unique identifier of the allowed origin. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.AllowedOrigin](../../doc/models/allowed-origin.md).

## Example Usage

```csharp
string companyId = "companyId0";
string apiCredentialId = "apiCredentialId8";
string originId = "originId6";
try
{
    ApiResponse<AllowedOrigin> result = await allowedOriginsCompanyLevelApi.GetCompaniesCompanyIdApiCredentialsApiCredentialIdAllowedOriginsOriginIdAsync(
        companyId,
        apiCredentialId,
        originId
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
  "id": "YOUR_ALLOWED_ORIGIN",
  "domain": "https://www.us.mystore.com",
  "_links": {
    "self": {
      "href": "https://management-test.adyen.com/v1/companies/YOUR_COMPANY_ACCOUNT/apiCredentials/YOUR_API_CREDENTIAL/allowedOrigins/YOUR_ALLOWED_ORIGIN"
    }
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

