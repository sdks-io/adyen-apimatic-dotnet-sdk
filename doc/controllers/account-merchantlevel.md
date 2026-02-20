# Account-Merchantlevel

```csharp
AccountMerchantlevelApi accountMerchantlevelApi = client.AccountMerchantlevelApi;
```

## Class Name

`AccountMerchantlevelApi`

## Methods

* [List Merchants](../../doc/controllers/account-merchantlevel.md#list-merchants)
* [Create Merchant](../../doc/controllers/account-merchantlevel.md#create-merchant)
* [Get Merchant](../../doc/controllers/account-merchantlevel.md#get-merchant)
* [Activate Merchant](../../doc/controllers/account-merchantlevel.md#activate-merchant)


# List Merchants

Returns the list of merchant accounts that your API credential has access to. The list is grouped into pages as defined by the query parameters.

To make this request, your API credential must have the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):

* Management API—Account read

```csharp
ListMerchantsAsync(
    int? pageNumber = null,
    int? pageSize = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `pageNumber` | `int?` | Query, Optional | The number of the page to fetch. |
| `pageSize` | `int?` | Query, Optional | The number of items to have on a page, maximum 100. The default is 10 items on a page. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.ListMerchantResponse](../../doc/models/list-merchant-response.md).

## Example Usage

```csharp
try
{
    ApiResponse<ListMerchantResponse> result = await accountMerchantLevelApi.ListMerchantsAsync();
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
      "href": "https://management-test.adyen.com/v1/merchants?pageNumber=1&pageSize=10"
    },
    "last": {
      "href": "https://management-test.adyen.com/v1/merchants?pageNumber=3&pageSize=10"
    },
    "next": {
      "href": "https://management-test.adyen.com/v1/merchants?pageNumber=2&pageSize=10"
    },
    "self": {
      "href": "https://management-test.adyen.com/v1/merchants?pageNumber=1&pageSize=10"
    }
  },
  "itemsTotal": 23,
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
      "status": "YOUR_MERCHANT_NAME_3",
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
          "href": "https://management-test.adyen.com/v1/merchants/YOUR_MERCHANT_NAME_6"
        },
        "apiCredentials": {
          "href": "https://management-test.adyen.com/v1/merchants/YOUR_MERCHANT_NAME_6/apiCredentials"
        },
        "users": {
          "href": "https://management-test.adyen.com/v1/merchants/YOUR_MERCHANT_NAME_6/users"
        },
        "webhooks": {
          "href": "https://management-test.adyen.com/v1/merchants/YOUR_MERCHANT_NAME_6/webhooks"
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


# Create Merchant

Creates a merchant account for the company account specified in the request.

Use this endpoint if your integration requires it, such as Adyen for Platforms Manage. Your Adyen contact will set up your access.

To make this request, your API credential must have the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):

* Management API—Accounts read and write

```csharp
CreateMerchantAsync(
    Models.CreateMerchantRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`CreateMerchantRequest`](../../doc/models/create-merchant-request.md) | Body, Optional | - |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.CreateMerchantResponse](../../doc/models/create-merchant-response.md).

## Example Usage

```csharp
CreateMerchantRequest body = new CreateMerchantRequest
{
    CompanyId = "YOUR_COMPANY_ACCOUNT",
    BusinessLineId = "YOUR_BUSINESS_LINE_ID",
    Description = "YOUR_DESCRIPTION",
    LegalEntityId = "YOUR_LEGAL_ENTITY_ID",
    Reference = "YOUR_OWN_REFERENCE",
};

try
{
    ApiResponse<CreateMerchantResponse> result = await accountMerchantLevelApi.CreateMerchantAsync(body);
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
  "companyId": "YOUR_COMPANY_ACCOUNT",
  "legalEntityId": "YOUR_LEGAL_ENTITY_ID",
  "businessLineId": "YOUR_BUSINESS_LINE_ID",
  "description": "YOUR_DESCRIPTION",
  "reference": "YOUR_OWN_REFERENCE",
  "id": "YOUR_OWN_REFERENCE"
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


# Get Merchant

Returns the merchant account specified in the path. Your API credential must have access to the merchant account.

To make this request, your API credential must have the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):

* Management API—Account read

```csharp
GetMerchantAsync(
    string merchantId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `merchantId` | `string` | Template, Required | The unique identifier of the merchant account. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.Merchant](../../doc/models/merchant.md).

## Example Usage

```csharp
string merchantId = "merchantId6";
try
{
    ApiResponse<Merchant> result = await accountMerchantLevelApi.GetMerchantAsync(merchantId);
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
  "id": "YOUR_MERCHANT_ACCOUNT",
  "name": "YOUR_MERCHANT_NAME",
  "captureDelay": "manual",
  "defaultShopperInteraction": "Ecommerce",
  "status": "Active",
  "shopWebAddress": "YOUR_SHOP_URL",
  "merchantCity": "Amsterdam",
  "primarySettlementCurrency": "EUR",
  "_links": {
    "self": {
      "href": "https://management-test.adyen.com/v1/merchants/YOUR_MERCHANT_ACCOUNT"
    },
    "apiCredentials": {
      "href": "https://management-test.adyen.com/v1/merchants/YOUR_MERCHANT_ACCOUNT/apiCredentials"
    },
    "users": {
      "href": "https://management-test.adyen.com/v1/merchants/YOUR_MERCHANT_ACCOUNT/users"
    },
    "webhooks": {
      "href": "https://management-test.adyen.com/v1/merchants/YOUR_MERCHANT_ACCOUNT/webhooks"
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


# Activate Merchant

Sends a request to activate the merchant account identified in the path.

You get the result of the activation asynchronously through a [`merchant.updated`](https://docs.adyen.com/api-explorer/ManagementNotification/latest/post/merchant.updated) webhook. Once the merchant account is activated, you can start using it to accept payments and payouts.

Use this endpoint if your integration requires it, such as Adyen for Platforms Manage. Your Adyen contact will set up your access.

To make this request, your API credential must have the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):

* Management API—Accounts read and write

```csharp
ActivateMerchantAsync(
    string merchantId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `merchantId` | `string` | Template, Required | The unique identifier of the merchant account. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.RequestActivationResponse](../../doc/models/request-activation-response.md).

## Example Usage

```csharp
string merchantId = "merchantId6";
try
{
    ApiResponse<RequestActivationResponse> result = await accountMerchantLevelApi.ActivateMerchantAsync(merchantId);
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

