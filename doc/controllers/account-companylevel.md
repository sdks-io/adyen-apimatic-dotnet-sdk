# Account-Companylevel

```csharp
AccountCompanylevelApi accountCompanylevelApi = client.AccountCompanylevelApi;
```

## Class Name

`AccountCompanylevelApi`

## Methods

* [Get-Companies](../../doc/controllers/account-companylevel.md#get-companies)
* [Get-Companies-Company Id](../../doc/controllers/account-companylevel.md#get-companies-company-id)
* [Get-Companies-Company Id-Merchants](../../doc/controllers/account-companylevel.md#get-companies-company-id-merchants)


# Get-Companies

Returns the list of company accounts that your API credential has access to. The list is grouped into pages as defined by the query parameters.

To make this request, your API credential must have the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):

* Management API—Account read

```csharp
GetCompaniesAsync(
    int? pageNumber = null,
    int? pageSize = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `pageNumber` | `int?` | Query, Optional | The number of the page to fetch. |
| `pageSize` | `int?` | Query, Optional | The number of items to have on a page, maximum 100. The default is 10 items on a page. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.ListCompanyResponse](../../doc/models/list-company-response.md).

## Example Usage

```csharp
try
{
    ApiResponse<ListCompanyResponse> result = await accountCompanyLevelApi.GetCompaniesAsync();
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
      "href": "https://management-test.adyen.com/v1/companies?pageNumber=1&pageSize=10"
    },
    "last": {
      "href": "https://management-test.adyen.com/v1/companies?pageNumber=1&pageSize=10"
    },
    "self": {
      "href": "https://management-test.adyen.com/v1/companies?pageNumber=1&pageSize=10"
    }
  },
  "itemsTotal": 1,
  "pagesTotal": 1,
  "data": [
    {
      "id": "YOUR_COMPANY_ACCOUNT",
      "name": "YOUR_COMPANY_NAME",
      "status": "Active",
      "dataCenters": [
        {
          "name": "default",
          "livePrefix": ""
        }
      ],
      "_links": {
        "self": {
          "href": "https://management-test.adyen.com/v1/companies/YOUR_COMPANY_ACCOUNT"
        },
        "apiCredentials": {
          "href": "https://management-test.adyen.com/v1/companies/YOUR_COMPANY_ACCOUNT/apiCredentials"
        },
        "users": {
          "href": "https://management-test.adyen.com/v1/companies/YOUR_COMPANY_ACCOUNT/users"
        },
        "webhooks": {
          "href": "https://management-test.adyen.com/v1/companies/YOUR_COMPANY_ACCOUNT/webhooks"
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


# Get-Companies-Company Id

Returns the company account specified in the path. Your API credential must have access to the company account.

To make this request, your API credential must have the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):

* Management API—Account read

```csharp
GetCompaniesCompanyIdAsync(
    string companyId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `companyId` | `string` | Template, Required | The unique identifier of the company account. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.Company2](../../doc/models/company-2.md).

## Example Usage

```csharp
string companyId = "companyId0";
try
{
    ApiResponse<Company2> result = await accountCompanyLevelApi.GetCompaniesCompanyIdAsync(companyId);
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
  "id": "YOUR_COMPANY_ACCOUNT",
  "name": "YOUR_SHOP_NAME",
  "status": "Active",
  "dataCenters": [
    {
      "name": "default",
      "livePrefix": ""
    }
  ],
  "_links": {
    "self": {
      "href": "https://management-test.adyen.com/v1/companies/YOUR_COMPANY_ACCOUNT"
    },
    "apiCredentials": {
      "href": "https://management-test.adyen.com/v1/companies/YOUR_COMPANY_ACCOUNT/apiCredentials"
    },
    "users": {
      "href": "https://management-test.adyen.com/v1/companies/YOUR_COMPANY_ACCOUNT/users"
    },
    "webhooks": {
      "href": "https://management-test.adyen.com/v1/companies/YOUR_COMPANY_ACCOUNT/webhooks"
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


# Get-Companies-Company Id-Merchants

Returns the list of merchant accounts under the company account specified in the path. The list only includes merchant accounts that your API credential has access to. The list is grouped into pages as defined by the query parameters.

To make this request, your API credential must have the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):

* Management API—Account read

```csharp
GetCompaniesCompanyIdMerchantsAsync(
    string companyId,
    int? pageNumber = null,
    int? pageSize = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `companyId` | `string` | Template, Required | The unique identifier of the company account. |
| `pageNumber` | `int?` | Query, Optional | The number of the page to fetch. |
| `pageSize` | `int?` | Query, Optional | The number of items to have on a page, maximum 100. The default is 10 items on a page. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.ListMerchantResponse](../../doc/models/list-merchant-response.md).

## Example Usage

```csharp
string companyId = "companyId0";
try
{
    ApiResponse<ListMerchantResponse> result = await accountCompanyLevelApi.GetCompaniesCompanyIdMerchantsAsync(companyId);
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
      "href": "https://management-test.adyen.com/v1/companies/YOUR_COMPANY_ACCOUNT/merchants?pageNumber=1&pageSize=10"
    },
    "last": {
      "href": "https://management-test.adyen.com/v1/companies/YOUR_COMPANY_ACCOUNT/merchants?pageNumber=3&pageSize=10"
    },
    "next": {
      "href": "https://management-test.adyen.com/v1/companies/YOUR_COMPANY_ACCOUNT/merchants?pageNumber=2&pageSize=10"
    },
    "self": {
      "href": "https://management-test.adyen.com/v1/companies/YOUR_COMPANY_ACCOUNT/merchants?pageNumber=1&pageSize=10"
    }
  },
  "itemsTotal": 22,
  "pagesTotal": 3,
  "data": [
    {
      "id": "YOUR_MERCHANT_ACCOUNT_1",
      "name": "YOUR_MERCHANT_NAME_1",
      "captureDelay": "immediate",
      "defaultShopperInteraction": "Ecommerce",
      "status": "Active",
      "shopWebAddress": "YOUR_SHOP_URL_1",
      "merchantCity": "Amsterdam",
      "primarySettlementCurrency": "EUR",
      "_links": {
        "self": {
          "href": "https://management-test.adyen.com/v1/merchants/YOUR_MERCHANT_ACCOUNT_1"
        },
        "apiCredentials": {
          "href": "https://management-test.adyen.com/v1/merchants/YOUR_MERCHANT_ACCOUNT_1/apiCredentials"
        },
        "users": {
          "href": "https://management-test.adyen.com/v1/merchants/YOUR_MERCHANT_ACCOUNT_1/users"
        },
        "webhooks": {
          "href": "https://management-test.adyen.com/v1/merchants/YOUR_MERCHANT_ACCOUNT_1/webhooks"
        }
      }
    },
    {
      "id": "YOUR_MERCHANT_ACCOUNT_2",
      "name": "YOUR_MERCHANT_NAME_2",
      "captureDelay": "immediate",
      "defaultShopperInteraction": "POS",
      "status": "Active",
      "shopWebAddress": "YOUR_SHOP_URL_2",
      "merchantCity": "",
      "primarySettlementCurrency": "EUR",
      "_links": {
        "self": {
          "href": "https://management-test.adyen.com/v1/merchants/YOUR_MERCHANT_ACCOUNT_2"
        },
        "apiCredentials": {
          "href": "https://management-test.adyen.com/v1/merchants/YOUR_MERCHANT_ACCOUNT_2/apiCredentials"
        },
        "users": {
          "href": "https://management-test.adyen.com/v1/merchants/YOUR_MERCHANT_ACCOUNT_2/users"
        },
        "webhooks": {
          "href": "https://management-test.adyen.com/v1/merchants/YOUR_MERCHANT_ACCOUNT_2/webhooks"
        }
      }
    },
    {
      "id": "YOUR_MERCHANT_ACCOUNT_3",
      "status": "Active",
      "merchantCity": "Amsterdam",
      "primarySettlementCurrency": "EUR",
      "_links": {
        "self": {
          "href": "https://management-test.adyen.com/v1/merchants/YOUR_MERCHANT_ACCOUNT_3"
        },
        "apiCredentials": {
          "href": "https://management-test.adyen.com/v1/merchants/YOUR_MERCHANT_ACCOUNT_3/apiCredentials"
        },
        "users": {
          "href": "https://management-test.adyen.com/v1/merchants/YOUR_MERCHANT_ACCOUNT_3/users"
        },
        "webhooks": {
          "href": "https://management-test.adyen.com/v1/merchants/YOUR_MERCHANT_ACCOUNT_3/webhooks"
        }
      }
    },
    {
      "id": "YOUR_MERCHANT_ACCOUNT_4",
      "name": "YOUR_MERCHANT_NAME_4",
      "captureDelay": "immediate",
      "defaultShopperInteraction": "Ecommerce",
      "status": "Active",
      "shopWebAddress": "YOUR_SHOP_URL_4",
      "merchantCity": "Sao Paulo",
      "primarySettlementCurrency": "BRL",
      "_links": {
        "self": {
          "href": "https://management-test.adyen.com/v1/merchants/YOUR_MERCHANT_ACCOUNT_4"
        },
        "apiCredentials": {
          "href": "https://management-test.adyen.com/v1/merchants/YOUR_MERCHANT_ACCOUNT_4/apiCredentials"
        },
        "users": {
          "href": "https://management-test.adyen.com/v1/merchants/YOUR_MERCHANT_ACCOUNT_4/users"
        },
        "webhooks": {
          "href": "https://management-test.adyen.com/v1/merchants/YOUR_MERCHANT_ACCOUNT_4/webhooks"
        }
      }
    },
    {
      "id": "YOUR_MERCHANT_ACCOUNT_5",
      "name": "YOUR_MERCHANT_NAME_5",
      "captureDelay": "3",
      "defaultShopperInteraction": "Ecommerce",
      "status": "Active",
      "shopWebAddress": "YOUR_SHOP_URL_5",
      "primarySettlementCurrency": "EUR",
      "_links": {
        "self": {
          "href": "https://management-test.adyen.com/v1/merchants/YOUR_MERCHANT_ACCOUNT_5"
        },
        "apiCredentials": {
          "href": "https://management-test.adyen.com/v1/merchants/YOUR_MERCHANT_ACCOUNT_5/apiCredentials"
        },
        "users": {
          "href": "https://management-test.adyen.com/v1/merchants/YOUR_MERCHANT_ACCOUNT_5/users"
        },
        "webhooks": {
          "href": "https://management-test.adyen.com/v1/merchants/YOUR_MERCHANT_ACCOUNT_5/webhooks"
        }
      }
    },
    {
      "id": "YOUR_MERCHANT_ACCOUNT_6",
      "name": "YOUR_MERCHANT_NAME_6",
      "captureDelay": "immediate",
      "defaultShopperInteraction": "Ecommerce",
      "status": "Active",
      "shopWebAddress": "YOUR_SHOP_URL_6",
      "merchantCity": "Zagreb",
      "primarySettlementCurrency": "BRL",
      "_links": {
        "self": {
          "href": "https://management-test.adyen.com/v1/merchants/YOUR_MERCHANT_ACCOUNT_6"
        },
        "apiCredentials": {
          "href": "https://management-test.adyen.com/v1/merchants/YOUR_MERCHANT_ACCOUNT_6/apiCredentials"
        },
        "users": {
          "href": "https://management-test.adyen.com/v1/merchants/YOUR_MERCHANT_ACCOUNT_6/users"
        },
        "webhooks": {
          "href": "https://management-test.adyen.com/v1/merchants/YOUR_MERCHANT_ACCOUNT_6/webhooks"
        }
      }
    },
    {
      "id": "YOUR_MERCHANT_ACCOUNT_7",
      "name": "YOUR_MERCHANT_NAME_7",
      "captureDelay": "manual",
      "defaultShopperInteraction": "Moto",
      "status": "Active",
      "shopWebAddress": "YOUR_SHOP_URL_7",
      "merchantCity": "Amsterdam",
      "primarySettlementCurrency": "EUR",
      "_links": {
        "self": {
          "href": "https://management-test.adyen.com/v1/merchants/YOUR_MERCHANT_ACCOUNT_7"
        },
        "apiCredentials": {
          "href": "https://management-test.adyen.com/v1/merchants/YOUR_MERCHANT_ACCOUNT_7/apiCredentials"
        },
        "users": {
          "href": "https://management-test.adyen.com/v1/merchants/YOUR_MERCHANT_ACCOUNT_7/users"
        },
        "webhooks": {
          "href": "https://management-test.adyen.com/v1/merchants/YOUR_MERCHANT_ACCOUNT_7/webhooks"
        }
      }
    },
    {
      "id": "YOUR_MERCHANT_ACCOUNT_8",
      "name": "YOUR_MERCHANT_NAME_8",
      "captureDelay": "immediate",
      "defaultShopperInteraction": "Ecommerce",
      "status": "Active",
      "shopWebAddress": "YOUR_SHOP_URL_8",
      "merchantCity": "Amsterdam",
      "primarySettlementCurrency": "EUR",
      "_links": {
        "self": {
          "href": "https://management-test.adyen.com/v1/merchants/YOUR_MERCHANT_ACCOUNT_8"
        },
        "apiCredentials": {
          "href": "https://management-test.adyen.com/v1/merchants/YOUR_MERCHANT_ACCOUNT_8/apiCredentials"
        },
        "users": {
          "href": "https://management-test.adyen.com/v1/merchants/YOUR_MERCHANT_ACCOUNT_8/users"
        },
        "webhooks": {
          "href": "https://management-test.adyen.com/v1/merchants/YOUR_MERCHANT_ACCOUNT_8/webhooks"
        }
      }
    },
    {
      "id": "YOUR_MERCHANT_ACCOUNT_9",
      "name": "YOUR_MERCHANT_NAME_9",
      "captureDelay": "3",
      "defaultShopperInteraction": "Ecommerce",
      "status": "Active",
      "shopWebAddress": "YOUR_SHOP_URL_9",
      "merchantCity": "",
      "primarySettlementCurrency": "EUR",
      "_links": {
        "self": {
          "href": "https://management-test.adyen.com/v1/merchants/YOUR_MERCHANT_ACCOUNT_9"
        },
        "apiCredentials": {
          "href": "https://management-test.adyen.com/v1/merchants/YOUR_MERCHANT_ACCOUNT_9/apiCredentials"
        },
        "users": {
          "href": "https://management-test.adyen.com/v1/merchants/YOUR_MERCHANT_ACCOUNT_9/users"
        },
        "webhooks": {
          "href": "https://management-test.adyen.com/v1/merchants/YOUR_MERCHANT_ACCOUNT_9/webhooks"
        }
      }
    },
    {
      "id": "YOUR_MERCHANT_ACCOUNT_10",
      "name": "YOUR_MERCHANT_NAME_10",
      "captureDelay": "manual",
      "defaultShopperInteraction": "Ecommerce",
      "status": "Active",
      "shopWebAddress": "YOUR_SHOP_URL_10",
      "merchantCity": "Paris",
      "primarySettlementCurrency": "EUR",
      "_links": {
        "self": {
          "href": "https://management-test.adyen.com/v1/merchants/YOUR_MERCHANT_ACCOUNT_10"
        },
        "apiCredentials": {
          "href": "https://management-test.adyen.com/v1/merchants/YOUR_MERCHANT_ACCOUNT_10/apiCredentials"
        },
        "users": {
          "href": "https://management-test.adyen.com/v1/merchants/YOUR_MERCHANT_ACCOUNT_10/users"
        },
        "webhooks": {
          "href": "https://management-test.adyen.com/v1/merchants/YOUR_MERCHANT_ACCOUNT_10/webhooks"
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

