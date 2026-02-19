# Users-Companylevel

```csharp
UsersCompanylevelApi usersCompanylevelApi = client.UsersCompanylevelApi;
```

## Class Name

`UsersCompanylevelApi`

## Methods

* [Get-Companies-Company Id-Users](../../doc/controllers/users-companylevel.md#get-companies-company-id-users)
* [Post-Companies-Company Id-Users](../../doc/controllers/users-companylevel.md#post-companies-company-id-users)
* [Get-Companies-Company Id-Users-User Id](../../doc/controllers/users-companylevel.md#get-companies-company-id-users-user-id)
* [Patch-Companies-Company Id-Users-User Id](../../doc/controllers/users-companylevel.md#patch-companies-company-id-users-user-id)


# Get-Companies-Company Id-Users

Returns the list of users for the `companyId` identified in the path.

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):

* Management API—Users read and write

```csharp
GetCompaniesCompanyIdUsersAsync(
    string companyId,
    int? pageNumber = null,
    int? pageSize = null,
    string username = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `companyId` | `string` | Template, Required | The unique identifier of the company account. |
| `pageNumber` | `int?` | Query, Optional | The number of the page to return. |
| `pageSize` | `int?` | Query, Optional | The number of items to have on a page. Maximum value is **100**. The default is **10** items on a page. |
| `username` | `string` | Query, Optional | The partial or complete username to select all users that match. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.ListCompanyUsersResponse](../../doc/models/list-company-users-response.md).

## Example Usage

```csharp
string companyId = "companyId0";
try
{
    ApiResponse<ListCompanyUsersResponse> result = await usersCompanyLevelApi.GetCompaniesCompanyIdUsersAsync(companyId);
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


# Post-Companies-Company Id-Users

Creates the user for the `companyId` identified in the path.

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):

* Management API—Users read and write

```csharp
PostCompaniesCompanyIdUsersAsync(
    string companyId,
    Models.CreateCompanyUserRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `companyId` | `string` | Template, Required | The unique identifier of the company account. |
| `body` | [`CreateCompanyUserRequest`](../../doc/models/create-company-user-request.md) | Body, Optional | - |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.CreateCompanyUserResponse](../../doc/models/create-company-user-response.md).

## Example Usage

```csharp
string companyId = "companyId0";
CreateCompanyUserRequest body = new CreateCompanyUserRequest
{
    Email = "john.smith@example.com",
    Name = new Name
    {
        FirstName = "John",
        LastName = "Smith",
    },
    Username = "johnsmith",
    AssociatedMerchantAccounts = new List<string>
    {
        "YOUR_MERCHANT_ACCOUNT",
    },
    LoginMethod = "Email",
    Roles = new List<string>
    {
        "Merchant standard role",
        "Merchant admin",
    },
    TimeZoneCode = "Europe/Amsterdam",
};

try
{
    ApiResponse<CreateCompanyUserResponse> result = await usersCompanyLevelApi.PostCompaniesCompanyIdUsersAsync(
        companyId,
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
  "id": "S2-5C334C6770",
  "name": {
    "firstName": "John",
    "lastName": "Smith"
  },
  "email": "john.smith@example.com",
  "timeZoneCode": "Europe/Amsterdam",
  "username": "johnsmith",
  "roles": [
    "Merchant standard role",
    "Merchant admin"
  ],
  "active": true,
  "_links": {
    "self": {
      "href": "https://management-test.adyen.com/v1/companies/YOUR_COMPANY_ACCOUNT/users/S2-5C334C6770"
    }
  },
  "associatedMerchantAccounts": [
    "YOUR_MERCHANT_ACCOUNT"
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


# Get-Companies-Company Id-Users-User Id

Returns user details for the `userId` and the `companyId` identified in the path.

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):

* Management API—Users read and write

```csharp
GetCompaniesCompanyIdUsersUserIdAsync(
    string companyId,
    string userId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `companyId` | `string` | Template, Required | The unique identifier of the company account. |
| `userId` | `string` | Template, Required | The unique identifier of the user. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.CompanyUser](../../doc/models/company-user.md).

## Example Usage

```csharp
string companyId = "companyId0";
string userId = "userId0";
try
{
    ApiResponse<CompanyUser> result = await usersCompanyLevelApi.GetCompaniesCompanyIdUsersUserIdAsync(
        companyId,
        userId
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


# Patch-Companies-Company Id-Users-User Id

Updates user details for the `userId` and the `companyId` identified in the path.

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):

* Management API—Users read and write

```csharp
PatchCompaniesCompanyIdUsersUserIdAsync(
    string companyId,
    string userId,
    Models.UpdateCompanyUserRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `companyId` | `string` | Template, Required | The unique identifier of the company account. |
| `userId` | `string` | Template, Required | The unique identifier of the user. |
| `body` | [`UpdateCompanyUserRequest`](../../doc/models/update-company-user-request.md) | Body, Optional | - |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.CompanyUser](../../doc/models/company-user.md).

## Example Usage

```csharp
string companyId = "companyId0";
string userId = "userId0";
try
{
    ApiResponse<CompanyUser> result = await usersCompanyLevelApi.PatchCompaniesCompanyIdUsersUserIdAsync(
        companyId,
        userId
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

