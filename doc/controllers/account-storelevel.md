# Account-Storelevel

```csharp
AccountStorelevelApi accountStorelevelApi = client.AccountStorelevelApi;
```

## Class Name

`AccountStorelevelApi`

## Methods

* [List Merchant Stores](../../doc/controllers/account-storelevel.md#list-merchant-stores)
* [Create Merchant Store](../../doc/controllers/account-storelevel.md#create-merchant-store)
* [Get Merchant Store](../../doc/controllers/account-storelevel.md#get-merchant-store)
* [Update Merchant Store](../../doc/controllers/account-storelevel.md#update-merchant-store)
* [List Stores](../../doc/controllers/account-storelevel.md#list-stores)
* [Create Store](../../doc/controllers/account-storelevel.md#create-store)
* [Get Store](../../doc/controllers/account-storelevel.md#get-store)
* [Update Store](../../doc/controllers/account-storelevel.md#update-store)


# List Merchant Stores

Returns a list of stores for the merchant account identified in the path. The list is grouped into pages as defined by the query parameters.

To make this request, your API credential must have one of the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):

* Management API—Stores read
* Management API—Stores read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

```csharp
ListMerchantStoresAsync(
    string merchantId,
    int? pageNumber = null,
    int? pageSize = null,
    string reference = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `merchantId` | `string` | Template, Required | The unique identifier of the merchant account. |
| `pageNumber` | `int?` | Query, Optional | The number of the page to fetch. |
| `pageSize` | `int?` | Query, Optional | The number of items to have on a page, maximum 100. The default is 10 items on a page. |
| `reference` | `string` | Query, Optional | The reference of the store. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.ListStoresResponse](../../doc/models/list-stores-response.md).

## Example Usage

```csharp
string merchantId = "merchantId6";
try
{
    ApiResponse<ListStoresResponse> result = await accountStoreLevelApi.ListMerchantStoresAsync(merchantId);
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
      "href": "https://management-test.adyen.com/v1/merchants/YOUR_MERCHANT_ACCOUNT_ID/stores?pageNumber=1&pageSize=1"
    },
    "last": {
      "href": "https://management-test.adyen.com/v1/merchants/YOUR_MERCHANT_ACCOUNT_ID/stores?pageNumber=2&pageSize=1"
    },
    "next": {
      "href": "https://management-test.adyen.com/v1/merchants/YOUR_MERCHANT_ACCOUNT_ID/stores?pageNumber=2&pageSize=1"
    },
    "self": {
      "href": "https://management-test.adyen.com/v1/merchants/YOUR_MERCHANT_ACCOUNT_ID/stores?pageNumber=1&pageSize=1"
    }
  },
  "itemsTotal": 2,
  "pagesTotal": 1,
  "data": [
    {
      "id": "ST322LJ223223K5F4SQNR9XL5",
      "address": {
        "city": "Springfield",
        "country": "US",
        "line1": "200 Main Street",
        "line2": "Building 5A",
        "line3": "Suite 3",
        "postalCode": "20250",
        "stateOrProvince": "NY"
      },
      "description": "City centre store",
      "merchantId": "YOUR_MERCHANT_ACCOUNT_ID",
      "phoneNumber": "+13123456789",
      "reference": "Springfield Shop",
      "status": "active",
      "_links": {
        "self": {
          "href": "https://management-test.adyen.com/v1/stores/ST322LJ223223K5F4SQNR9XL5"
        }
      }
    },
    {
      "id": "ST322LJ223223K5F4SQNR9XL6",
      "address": {
        "city": "North Madison",
        "country": "US",
        "line1": "1492 Townline Road",
        "line2": "Rowland Business Park",
        "postalCode": "20577",
        "stateOrProvince": "NY"
      },
      "description": "West location",
      "merchantId": "YOUR_MERCHANT_ACCOUNT_ID",
      "phoneNumber": "+1211992213193020",
      "reference": "Second Madison store",
      "status": "active",
      "_links": {
        "self": {
          "href": "https://management-test.adyen.com/v1/stores/ST322LJ223223K5F4SQNR9XL6"
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


# Create Merchant Store

Creates a store for the merchant account identified in the path.

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):

* Management API—Stores read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

```csharp
CreateMerchantStoreAsync(
    string merchantId,
    Models.StoreCreationRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `merchantId` | `string` | Template, Required | The unique identifier of the merchant account. |
| `body` | [`StoreCreationRequest`](../../doc/models/store-creation-request.md) | Body, Optional | - |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.Store](../../doc/models/store.md).

## Example Usage

```csharp
string merchantId = "merchantId6";
StoreCreationRequest body = new StoreCreationRequest
{
    Address = new StoreLocation1
    {
        Country = "US",
        City = "Springfield",
        Line1 = "200 Main Street",
        Line2 = "Building 5A",
        Line3 = "Suite 3",
        PostalCode = "20250",
        StateOrProvince = "NY",
    },
    Description = "City centre store",
    PhoneNumber = "13123456789",
    ShopperStatement = "Springfield Shop",
    Reference = "Spring_store_2",
};

try
{
    ApiResponse<Store> result = await accountStoreLevelApi.CreateMerchantStoreAsync(
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
  "id": "YOUR_STORE_ID",
  "address": {
    "country": "US",
    "line1": "200 Main Street",
    "line2": "Building 5A",
    "line3": "Suite 3",
    "city": "Springfield",
    "stateOrProvince": "NY",
    "postalCode": "20250"
  },
  "description": "City centre store",
  "merchantId": "YOUR_MERCHANT_ACCOUNT_ID",
  "shopperStatement": "Springfield Shop",
  "phoneNumber": "13123456789",
  "reference": "Spring_store_2",
  "status": "active",
  "_links": {
    "self": {
      "href": "https://management-test.adyen.com/v1/stores/YOUR_STORE_ID"
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


# Get Merchant Store

Returns the details of the store identified in the path.

To make this request, your API credential must have one of the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):

* Management API—Stores read
* Management API—Stores read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

```csharp
GetMerchantStoreAsync(
    string merchantId,
    string storeId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `merchantId` | `string` | Template, Required | The unique identifier of the merchant account. |
| `storeId` | `string` | Template, Required | The unique identifier of the store. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.Store](../../doc/models/store.md).

## Example Usage

```csharp
string merchantId = "merchantId6";
string storeId = "storeId6";
try
{
    ApiResponse<Store> result = await accountStoreLevelApi.GetMerchantStoreAsync(
        merchantId,
        storeId
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
  "address": {
    "city": "Springfield",
    "country": "US",
    "line1": "200 Main Street",
    "line2": "Building 5A",
    "line3": "Suite 3",
    "postalCode": "20250",
    "stateOrProvince": "NY"
  },
  "description": "City centre store",
  "merchantId": "YOUR_MERCHANT_ACCOUNT_ID",
  "phoneNumber": "+13123456789",
  "reference": "Springfield Shop",
  "status": "active",
  "_links": {
    "self": {
      "href": "https://management-test.adyen.com/v1/stores/ST322LJ223223K5F4SQNR9XL5"
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


# Update Merchant Store

Updates the store identified in the path. You can only update some store parameters.

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):

* Management API—Stores read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

```csharp
UpdateMerchantStoreAsync(
    string merchantId,
    string storeId,
    Models.UpdateStoreRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `merchantId` | `string` | Template, Required | The unique identifier of the merchant account. |
| `storeId` | `string` | Template, Required | The unique identifier of the store. |
| `body` | [`UpdateStoreRequest`](../../doc/models/update-store-request.md) | Body, Optional | - |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.Store](../../doc/models/store.md).

## Example Usage

```csharp
string merchantId = "merchantId6";
string storeId = "storeId6";
UpdateStoreRequest body = new UpdateStoreRequest
{
    Address = new UpdatableAddress1
    {
        Line1 = "1776 West Pinewood Avenue",
        Line2 = "Heartland Building",
        Line3 = "",
        PostalCode = "20251",
    },
};

try
{
    ApiResponse<Store> result = await accountStoreLevelApi.UpdateMerchantStoreAsync(
        merchantId,
        storeId,
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
  "id": "YOUR_STORE_ID",
  "address": {
    "country": "US",
    "line1": "1776 West Pinewood Avenue",
    "line2": "Heartland Building",
    "line3": "",
    "city": "Springfield",
    "stateOrProvince": "NY",
    "postalCode": "20251"
  },
  "description": "City centre store",
  "merchantId": "YOUR_MERCHANT_ACCOUNT_ID",
  "shopperStatement": "Springfield Shop",
  "phoneNumber": "+13123456789",
  "reference": "Spring_store_2",
  "status": "active",
  "_links": {
    "self": {
      "href": "https://management-test.adyen.com/v1/stores/YOUR_STORE_ID"
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


# List Stores

Returns a list of stores. The list is grouped into pages as defined by the query parameters.

To make this request, your API credential must have one of the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):

* Management API—Stores read
* Management API—Stores read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

```csharp
ListStoresAsync(
    int? pageNumber = null,
    int? pageSize = null,
    string reference = null,
    string merchantId = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `pageNumber` | `int?` | Query, Optional | The number of the page to fetch. |
| `pageSize` | `int?` | Query, Optional | The number of items to have on a page, maximum 100. The default is 10 items on a page. |
| `reference` | `string` | Query, Optional | The reference of the store. |
| `merchantId` | `string` | Query, Optional | The unique identifier of the merchant account. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.ListStoresResponse](../../doc/models/list-stores-response.md).

## Example Usage

```csharp
try
{
    ApiResponse<ListStoresResponse> result = await accountStoreLevelApi.ListStoresAsync();
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
      "href": "https://management-test.adyen.com/v1/merchants/YOUR_MERCHANT_ACCOUNT_ID/stores?pageNumber=1&pageSize=1"
    },
    "last": {
      "href": "https://management-test.adyen.com/v1/merchants/YOUR_MERCHANT_ACCOUNT_ID/stores?pageNumber=2&pageSize=1"
    },
    "next": {
      "href": "https://management-test.adyen.com/v1/merchants/YOUR_MERCHANT_ACCOUNT_ID/stores?pageNumber=2&pageSize=1"
    },
    "self": {
      "href": "https://management-test.adyen.com/v1/merchants/YOUR_MERCHANT_ACCOUNT_ID/stores?pageNumber=1&pageSize=1"
    }
  },
  "itemsTotal": 2,
  "pagesTotal": 1,
  "data": [
    {
      "id": "ST322LJ223223K5F4SQNR9XL5",
      "address": {
        "city": "Springfield",
        "country": "US",
        "line1": "200 Main Street",
        "line2": "Building 5A",
        "line3": "Suite 3",
        "postalCode": "20250",
        "stateOrProvince": "NY"
      },
      "description": "City centre store",
      "merchantId": "YOUR_MERCHANT_ACCOUNT_ID",
      "phoneNumber": "+1312345678",
      "reference": "Springfield Shop",
      "status": "active",
      "_links": {
        "self": {
          "href": "https://management-test.adyen.com/v1/stores/ST322LJ223223K5F4SQNR9XL5"
        }
      }
    },
    {
      "id": "ST322LJ223223K5F4SQNR9XL6",
      "address": {
        "city": "North Madison",
        "country": "US",
        "line1": "1492 Townline Road",
        "line2": "Rowland Business Park",
        "postalCode": "20577",
        "stateOrProvince": "NY"
      },
      "description": "West location",
      "merchantId": "YOUR_MERCHANT_ACCOUNT_ID",
      "phoneNumber": "+1211992213193020",
      "reference": "Second Madison store",
      "status": "active",
      "_links": {
        "self": {
          "href": "https://management-test.adyen.com/v1/stores/ST322LJ223223K5F4SQNR9XL6"
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


# Create Store

Creates a store for the merchant account specified in the request.

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):

* Management API—Stores read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

```csharp
CreateStoreAsync(
    Models.StoreCreationWithMerchantCodeRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`StoreCreationWithMerchantCodeRequest`](../../doc/models/store-creation-with-merchant-code-request.md) | Body, Optional | - |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.Store](../../doc/models/store.md).

## Example Usage

```csharp
StoreCreationWithMerchantCodeRequest body = new StoreCreationWithMerchantCodeRequest
{
    Address = new StoreLocation1
    {
        Country = "US",
        City = "Springfield",
        Line1 = "200 Main Street",
        Line2 = "Building 5A",
        Line3 = "Suite 3",
        PostalCode = "20250",
        StateOrProvince = "NY",
    },
    Description = "City centre store",
    MerchantId = "YOUR_MERCHANT_ACCOUNT_ID",
    PhoneNumber = "+13123456789",
    ShopperStatement = "Springfield Shop",
    Reference = "Spring_store_2",
};

try
{
    ApiResponse<Store> result = await accountStoreLevelApi.CreateStoreAsync(body);
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
  "id": "YOUR_STORE_ID",
  "address": {
    "country": "US",
    "line1": "200 Main Street",
    "line2": "Building 5A",
    "line3": "Suite 3",
    "city": "Springfield",
    "stateOrProvince": "NY",
    "postalCode": "20250"
  },
  "description": "City centre store",
  "merchantId": "YOUR_MERCHANT_ACCOUNT_ID",
  "shopperStatement": "Springfield Shop",
  "phoneNumber": "+13123456789",
  "reference": "Spring_store_2",
  "status": "active",
  "_links": {
    "self": {
      "href": "https://management-test.adyen.com/v1/stores/YOUR_STORE_ID"
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


# Get Store

Returns the details of the store identified in the path.

To make this request, your API credential must have one of the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):

* Management API—Stores read
* Management API—Stores read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

```csharp
GetStoreAsync(
    string storeId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `storeId` | `string` | Template, Required | The unique identifier of the store. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.Store](../../doc/models/store.md).

## Example Usage

```csharp
string storeId = "storeId6";
try
{
    ApiResponse<Store> result = await accountStoreLevelApi.GetStoreAsync(storeId);
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
  "id": "ST322LJ223223K5F4SQNR9XL5",
  "address": {
    "city": "Springfield",
    "country": "US",
    "line1": "200 Main Street",
    "line2": "Building 5A",
    "line3": "Suite 3",
    "postalCode": "20250",
    "stateOrProvince": "NY"
  },
  "description": "City centre store",
  "merchantId": "YOUR_MERCHANT_ACCOUNT_ID",
  "phoneNumber": "+13123456789",
  "reference": "Springfield Shop",
  "status": "active",
  "_links": {
    "self": {
      "href": "https://management-test.adyen.com/v1/stores/ST322LJ223223K5F4SQNR9XL5"
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


# Update Store

Updates the store identified in the path.
You can only update some store parameters.

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):

* Management API—Stores read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

```csharp
UpdateStoreAsync(
    string storeId,
    Models.UpdateStoreRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `storeId` | `string` | Template, Required | The unique identifier of the store. |
| `body` | [`UpdateStoreRequest`](../../doc/models/update-store-request.md) | Body, Optional | - |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.Store](../../doc/models/store.md).

## Example Usage

```csharp
string storeId = "storeId6";
UpdateStoreRequest body = new UpdateStoreRequest
{
    Address = new UpdatableAddress1
    {
        Line1 = "1776 West Pinewood Avenue",
        Line2 = "Heartland Building",
        Line3 = "",
        PostalCode = "20251",
    },
};

try
{
    ApiResponse<Store> result = await accountStoreLevelApi.UpdateStoreAsync(
        storeId,
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
  "id": "YOUR_STORE_ID",
  "address": {
    "country": "US",
    "line1": "1776 West Pinewood Avenue",
    "line2": "Heartland Building",
    "line3": "",
    "city": "Springfield",
    "stateOrProvince": "NY",
    "postalCode": "20251"
  },
  "description": "City centre store",
  "merchantId": "YOUR_MERCHANT_ACCOUNT_ID",
  "shopperStatement": "Springfield Shop",
  "phoneNumber": "+13123456789",
  "reference": "Spring_store_2",
  "status": "active",
  "_links": {
    "self": {
      "href": "https://management-test.adyen.com/v1/stores/YOUR_STORE_ID"
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

