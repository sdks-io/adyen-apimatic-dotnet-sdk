# Users-Merchantlevel

```csharp
UsersMerchantlevelApi usersMerchantlevelApi = client.UsersMerchantlevelApi;
```

## Class Name

`UsersMerchantlevelApi`

## Methods

* [Get-Merchants-Merchant Id-Users](../../doc/controllers/users-merchantlevel.md#get-merchants-merchant-id-users)
* [Post-Merchants-Merchant Id-Users](../../doc/controllers/users-merchantlevel.md#post-merchants-merchant-id-users)
* [Get-Merchants-Merchant Id-Users-User Id](../../doc/controllers/users-merchantlevel.md#get-merchants-merchant-id-users-user-id)
* [Patch-Merchants-Merchant Id-Users-User Id](../../doc/controllers/users-merchantlevel.md#patch-merchants-merchant-id-users-user-id)


# Get-Merchants-Merchant Id-Users

Returns a list of users associated with the `merchantId` specified in the path.

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):

* Management API—Users read and write

```csharp
GetMerchantsMerchantIdUsersAsync(
    string merchantId,
    int? pageNumber = null,
    int? pageSize = null,
    string username = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `merchantId` | `string` | Template, Required | Unique identifier of the merchant. |
| `pageNumber` | `int?` | Query, Optional | The number of the page to fetch. |
| `pageSize` | `int?` | Query, Optional | The number of items to have on a page. Maximum value is **100**. The default is **10** items on a page. |
| `username` | `string` | Query, Optional | The partial or complete username to select all users that match. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.ListMerchantUsersResponse](../../doc/models/list-merchant-users-response.md).

## Example Usage

```csharp
string merchantId = "merchantId6";
try
{
    ApiResponse<ListMerchantUsersResponse> result = await usersMerchantLevelApi.GetMerchantsMerchantIdUsersAsync(merchantId);
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


# Post-Merchants-Merchant Id-Users

Creates a user for the `merchantId` specified in the path.

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):

* Management API—Users read and write

```csharp
PostMerchantsMerchantIdUsersAsync(
    string merchantId,
    Models.CreateMerchantUserRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `merchantId` | `string` | Template, Required | Unique identifier of the merchant. |
| `body` | [`CreateMerchantUserRequest`](../../doc/models/create-merchant-user-request.md) | Body, Optional | - |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.CreateUserResponse](../../doc/models/create-user-response.md).

## Example Usage

```csharp
string merchantId = "merchantId6";
CreateMerchantUserRequest body = new CreateMerchantUserRequest
{
    Email = "john.smith@example.com",
    Name = new Name
    {
        FirstName = "John",
        LastName = "Smith",
    },
    Username = "johnsmith",
    LoginMethod = "Email",
    Roles = new List<string>
    {
        "Merchant standard role",
    },
    TimeZoneCode = "Europe/Amsterdam",
};

try
{
    ApiResponse<CreateUserResponse> result = await usersMerchantLevelApi.PostMerchantsMerchantIdUsersAsync(
        merchantId,
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
  "id": "S2-3B3C3C3B22",
  "name": {
    "firstName": "John",
    "lastName": "Smith"
  },
  "email": "john.smith@example.com",
  "timeZoneCode": "Europe/Amsterdam",
  "username": "johnsmith",
  "roles": [
    "Merchant standard role"
  ],
  "active": true,
  "_links": {
    "self": {
      "href": "https://management-test.adyen.com/v1/merchants/YOUR_MERCHANT_ACCOUNT/users/S2-3B3C3C3B22"
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


# Get-Merchants-Merchant Id-Users-User Id

Returns user details for the `userId` and the `merchantId` specified in the path.

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):

* Management API—Users read and write

```csharp
GetMerchantsMerchantIdUsersUserIdAsync(
    string merchantId,
    string userId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `merchantId` | `string` | Template, Required | Unique identifier of the merchant. |
| `userId` | `string` | Template, Required | Unique identifier of the user. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.User](../../doc/models/user.md).

## Example Usage

```csharp
string merchantId = "merchantId6";
string userId = "userId0";
try
{
    ApiResponse<User> result = await usersMerchantLevelApi.GetMerchantsMerchantIdUsersUserIdAsync(
        merchantId,
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


# Patch-Merchants-Merchant Id-Users-User Id

Updates user details for the `userId` and the `merchantId` specified in the path.

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):

* Management API—Users read and write

```csharp
PatchMerchantsMerchantIdUsersUserIdAsync(
    string merchantId,
    string userId,
    Models.UpdateMerchantUserRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `merchantId` | `string` | Template, Required | Unique identifier of the merchant. |
| `userId` | `string` | Template, Required | Unique identifier of the user. |
| `body` | [`UpdateMerchantUserRequest`](../../doc/models/update-merchant-user-request.md) | Body, Optional | - |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.User](../../doc/models/user.md).

## Example Usage

```csharp
string merchantId = "merchantId6";
string userId = "userId0";
try
{
    ApiResponse<User> result = await usersMerchantLevelApi.PatchMerchantsMerchantIdUsersUserIdAsync(
        merchantId,
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

