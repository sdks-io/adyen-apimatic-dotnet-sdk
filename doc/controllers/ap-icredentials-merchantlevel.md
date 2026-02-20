# AP Icredentials-Merchantlevel

```csharp
ApIcredentialsMerchantlevelApi apIcredentialsMerchantlevelApi = client.ApIcredentialsMerchantlevelApi;
```

## Class Name

`ApIcredentialsMerchantlevelApi`

## Methods

* [List Merchant Api Credentials](../../doc/controllers/ap-icredentials-merchantlevel.md#list-merchant-api-credentials)
* [Create Merchant Api Credential](../../doc/controllers/ap-icredentials-merchantlevel.md#create-merchant-api-credential)
* [Get Merchant Api Credential](../../doc/controllers/ap-icredentials-merchantlevel.md#get-merchant-api-credential)
* [Update Merchant Api Credential](../../doc/controllers/ap-icredentials-merchantlevel.md#update-merchant-api-credential)


# List Merchant Api Credentials

Returns the list of [API credentials](https://docs.adyen.com/development-resources/api-credentials) for the merchant account. The list is grouped into pages as defined by the query parameters.

To make this request, your API credential must have the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):

* Management API—API credentials read and write

```csharp
ListMerchantApiCredentialsAsync(
    string merchantId,
    int? pageNumber = null,
    int? pageSize = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `merchantId` | `string` | Template, Required | The unique identifier of the merchant account. |
| `pageNumber` | `int?` | Query, Optional | The number of the page to fetch. |
| `pageSize` | `int?` | Query, Optional | The number of items to have on a page, maximum 100. The default is 10 items on a page. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.ListMerchantApiCredentialsResponse](../../doc/models/list-merchant-api-credentials-response.md).

## Example Usage

```csharp
string merchantId = "merchantId6";
try
{
    ApiResponse<ListMerchantApiCredentialsResponse> result = await apiCredentialsMerchantLevelApi.ListMerchantApiCredentialsAsync(merchantId);
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
      "href": "https://management-test.adyen.com/v1/merchants/YOUR_MERCHANT_ACCOUNT/apiCredentials?pageNumber=1&pageSize=10"
    },
    "last": {
      "href": "https://management-test.adyen.com/v1/merchants/YOUR_MERCHANT_ACCOUNT/apiCredentials?pageNumber=2&pageSize=10"
    },
    "next": {
      "href": "https://management-test.adyen.com/v1/merchants/YOUR_MERCHANT_ACCOUNT/apiCredentials?pageNumber=2&pageSize=10"
    },
    "self": {
      "href": "https://management-test.adyen.com/v1/merchants/YOUR_MERCHANT_ACCOUNT/apiCredentials?pageNumber=1&pageSize=10"
    }
  },
  "itemsTotal": 11,
  "pagesTotal": 2,
  "data": [
    {
      "id": "YOUR_API_CREDENTIAL_1",
      "username": "YOUR_USERNAME_1",
      "clientKey": "YOUR_CLIENT_KEY_1",
      "allowedIpAddresses": [],
      "roles": [
        "Merchant Report Download role"
      ],
      "active": true,
      "_links": {
        "self": {
          "href": "https://management-test.adyen.com/v1/merchants/YOUR_MERCHANT_ACCOUNT/apiCredentials/YOUR_CREDENTIAL_1"
        },
        "allowedOrigins": {
          "href": "https://management-test.adyen.com/v1/merchants/YOUR_MERCHANT_ACCOUNT/apiCredentials/YOUR_CREDENTIAL_1/allowedOrigins"
        },
        "generateApiKey": {
          "href": "https://management-test.adyen.com/v1/merchants/YOUR_MERCHANT_ACCOUNT/apiCredentials/YOUR_CREDENTIAL_1/generateApiKey"
        },
        "generateClientKey": {
          "href": "https://management-test.adyen.com/v1/merchants/YOUR_MERCHANT_ACCOUNT/apiCredentials/YOUR_CREDENTIAL_1/generateClientKey"
        },
        "merchant": {
          "href": "https://management-test.adyen.com/v1/merchants/YOUR_MERCHANT_ACCOUNT"
        }
      }
    },
    {
      "id": "YOUR_API_CREDENTIAL_2",
      "username": "YOUR_USERNAME_2",
      "clientKey": "YOUR_CLIENT_KEY_2",
      "allowedIpAddresses": [],
      "roles": [
        "Merchant Rss feed role"
      ],
      "active": true,
      "_links": {
        "self": {
          "href": "https://management-test.adyen.com/v1/merchants/YOUR_MERCHANT_ACCOUNT/apiCredentials/YOUR_API_CREDENTIAL_2"
        },
        "allowedOrigins": {
          "href": "https://management-test.adyen.com/v1/merchants/YOUR_MERCHANT_ACCOUNT/apiCredentials/YOUR_API_CREDENTIAL_2/allowedOrigins"
        },
        "generateApiKey": {
          "href": "https://management-test.adyen.com/v1/merchants/YOUR_MERCHANT_ACCOUNT/apiCredentials/YOUR_API_CREDENTIAL_2/generateApiKey"
        },
        "generateClientKey": {
          "href": "https://management-test.adyen.com/v1/merchants/YOUR_MERCHANT_ACCOUNT/apiCredentials/YOUR_API_CREDENTIAL_2/generateClientKey"
        },
        "merchant": {
          "href": "https://management-test.adyen.com/v1/merchants/YOUR_MERCHANT_ACCOUNT"
        }
      }
    },
    {
      "id": "YOUR_API_CREDENTIAL_3",
      "username": "YOUR_USERNAME_3",
      "clientKey": "YOUR_CLIENT_KEY_3",
      "allowedIpAddresses": [],
      "roles": [
        "Merchant iDeal-API Webservice role",
        "Management API - Accounts read",
        "Management API - API credentials read and write",
        "Management API — Payment methods read",
        "Merchant PAL Donation role",
        "Merchant PAL Charity role",
        "Checkout encrypted cardholder data",
        "Checkout webservice role",
        "Store payout detail and submit payout - withdrawal",
        "Management API - Accounts read and write",
        "Management API - Webhooks read",
        "Merchant Payout role",
        "API tokenise payment details",
        "General API Payments role",
        "API Supply MPI data with Payments",
        "API Authorise Referred Payments",
        "API PCI Payments role",
        "Management API - Stores read",
        "API Payment RefundWithData",
        "API Clientside Encryption Payments role",
        "API to retrieve authentication data",
        "Management API - Stores read and write",
        "Management API - Webhooks read and write",
        "Mastercard inControl service",
        "Merchant Recurring role",
        "Management API - Payout Account Settings Read",
        "API surcharge cost estimation and regulatory information",
        "Store payout detail",
        "Merchant PAL Webservice role"
      ],
      "active": true,
      "allowedOrigins": [
        {
          "id": "YOUR_ALLOWED_ORIGIN_1",
          "domain": "YOUR_DOMAIN_1",
          "_links": {
            "self": {
              "href": "https://management-test.adyen.com/v1/merchants/YOUR_MERCHANT_ACCOUNT/apiCredentials/YOUR_API_CREDENTIAL_3/allowedOrigins/YOUR_ALLOWED_ORIGIN_1"
            }
          }
        },
        {
          "id": "YOUR_ALLOWED_ORIGIN_2",
          "domain": "YOUR_DOMAIN_2",
          "_links": {
            "self": {
              "href": "https://management-test.adyen.com/v1/merchants/YOUR_MERCHANT_ACCOUNT/apiCredentials/YOUR_API_CREDENTIAL_3/allowedOrigins/YOUR_ALLOWED_ORIGIN_2"
            }
          }
        }
      ],
      "_links": {
        "self": {
          "href": "https://management-test.adyen.com/v1/merchants/YOUR_MERCHANT_ACCOUNT/apiCredentials/YOUR_API_CREDENTIAL_3"
        },
        "allowedOrigins": {
          "href": "https://management-test.adyen.com/v1/merchants/YOUR_MERCHANT_ACCOUNT/apiCredentials/YOUR_API_CREDENTIAL_3/allowedOrigins"
        },
        "generateApiKey": {
          "href": "https://management-test.adyen.com/v1/merchants/YOUR_MERCHANT_ACCOUNT/apiCredentials/YOUR_API_CREDENTIAL_3/generateApiKey"
        },
        "generateClientKey": {
          "href": "https://management-test.adyen.com/v1/merchants/YOUR_MERCHANT_ACCOUNT/apiCredentials/YOUR_API_CREDENTIAL_3/generateClientKey"
        },
        "merchant": {
          "href": "https://management-test.adyen.com/v1/merchants/YOUR_MERCHANT_ACCOUNT"
        }
      }
    },
    {
      "id": "YOUR_API_CREDENTIAL_4",
      "username": "YOUR_USERNAME_4",
      "clientKey": "YOUR_CLIENT_KEY_4",
      "allowedIpAddresses": [],
      "roles": [
        "API Clientside Encryption Payments role",
        "API tokenise payment details",
        "General API Payments role",
        "Checkout encrypted cardholder data",
        "Merchant Recurring role",
        "API PCI Payments role",
        "Checkout webservice role",
        "ThreeDSecure WebService Role",
        "Merchant PAL Webservice role"
      ],
      "active": true,
      "_links": {
        "self": {
          "href": "https://management-test.adyen.com/v1/merchants/YOUR_MERCHANT_ACCOUNT/apiCredentials/YOUR_API_CREDENTIAL_4"
        },
        "allowedOrigins": {
          "href": "https://management-test.adyen.com/v1/merchants/YOUR_MERCHANT_ACCOUNT/apiCredentials/YOUR_API_CREDENTIAL_4/allowedOrigins"
        },
        "generateApiKey": {
          "href": "https://management-test.adyen.com/v1/merchants/YOUR_MERCHANT_ACCOUNT/apiCredentials/YOUR_API_CREDENTIAL_4/generateApiKey"
        },
        "generateClientKey": {
          "href": "https://management-test.adyen.com/v1/merchants/YOUR_MERCHANT_ACCOUNT/apiCredentials/YOUR_API_CREDENTIAL_4/generateClientKey"
        },
        "merchant": {
          "href": "https://management-test.adyen.com/v1/merchants/YOUR_MERCHANT_ACCOUNT"
        }
      }
    },
    {
      "id": "YOUR_API_CREDENTIAL_5",
      "username": "YOUR_USERNAME_5",
      "clientKey": "YOUR_CLIENT_KEY_5",
      "allowedIpAddresses": [],
      "roles": [
        "Merchant iDeal-API Webservice role",
        "General API Payments role",
        "Checkout encrypted cardholder data",
        "Merchant Recurring role",
        "Checkout webservice role",
        "Merchant PAL Webservice role"
      ],
      "active": true,
      "_links": {
        "self": {
          "href": "https://management-test.adyen.com/v1/merchants/YOUR_MERCHANT_ACCOUNT/apiCredentials/YOUR_API_CREDENTIAL_5"
        },
        "allowedOrigins": {
          "href": "https://management-test.adyen.com/v1/merchants/YOUR_MERCHANT_ACCOUNT/apiCredentials/YOUR_API_CREDENTIAL_5/allowedOrigins"
        },
        "generateApiKey": {
          "href": "https://management-test.adyen.com/v1/merchants/YOUR_MERCHANT_ACCOUNT/apiCredentials/YOUR_API_CREDENTIAL_5/generateApiKey"
        },
        "generateClientKey": {
          "href": "https://management-test.adyen.com/v1/merchants/YOUR_MERCHANT_ACCOUNT/apiCredentials/YOUR_API_CREDENTIAL_5/generateClientKey"
        },
        "merchant": {
          "href": "https://management-test.adyen.com/v1/merchants/YOUR_MERCHANT_ACCOUNT"
        }
      }
    },
    {
      "id": "YOUR_API_CREDENTIAL_6",
      "username": "YOUR_USERNAME_6",
      "clientKey": "YOUR_CLIENT_KEY_6",
      "allowedIpAddresses": [],
      "roles": [
        "Checkout encrypted cardholder data",
        "Merchant Recurring role",
        "API PCI Payments role",
        "Checkout webservice role",
        "Merchant PAL Webservice role"
      ],
      "active": true,
      "_links": {
        "self": {
          "href": "https://management-test.adyen.com/v1/merchants/YOUR_MERCHANT_ACCOUNT/apiCredentials/YOUR_API_CREDENTIAL_6"
        },
        "allowedOrigins": {
          "href": "https://management-test.adyen.com/v1/merchants/YOUR_MERCHANT_ACCOUNT/apiCredentials/YOUR_API_CREDENTIAL_6/allowedOrigins"
        },
        "generateApiKey": {
          "href": "https://management-test.adyen.com/v1/merchants/YOUR_MERCHANT_ACCOUNT/apiCredentials/YOUR_API_CREDENTIAL_6/generateApiKey"
        },
        "generateClientKey": {
          "href": "https://management-test.adyen.com/v1/merchants/YOUR_MERCHANT_ACCOUNT/apiCredentials/YOUR_API_CREDENTIAL_6/generateClientKey"
        },
        "merchant": {
          "href": "https://management-test.adyen.com/v1/merchants/YOUR_MERCHANT_ACCOUNT"
        }
      }
    },
    {
      "id": "YOUR_API_CREDENTIAL_7",
      "username": "YOUR_USERNAME_7",
      "clientKey": "YOUR_CLIENT_KEY_7",
      "allowedIpAddresses": [],
      "roles": [
        "Checkout encrypted cardholder data",
        "Checkout webservice role",
        "Merchant PAL Webservice role"
      ],
      "active": true,
      "_links": {
        "self": {
          "href": "https://management-test.adyen.com/v1/merchants/YOUR_MERCHANT_ACCOUNT/apiCredentials/YOUR_API_CREDENTIAL_7"
        },
        "allowedOrigins": {
          "href": "https://management-test.adyen.com/v1/merchants/YOUR_MERCHANT_ACCOUNT/apiCredentials/YOUR_API_CREDENTIAL_7/allowedOrigins"
        },
        "generateApiKey": {
          "href": "https://management-test.adyen.com/v1/merchants/YOUR_MERCHANT_ACCOUNT/apiCredentials/YOUR_API_CREDENTIAL_7/generateApiKey"
        },
        "generateClientKey": {
          "href": "https://management-test.adyen.com/v1/merchants/YOUR_MERCHANT_ACCOUNT/apiCredentials/YOUR_API_CREDENTIAL_7/generateClientKey"
        },
        "merchant": {
          "href": "https://management-test.adyen.com/v1/merchants/YOUR_MERCHANT_ACCOUNT"
        }
      }
    },
    {
      "id": "YOUR_API_CREDENTIAL_8",
      "username": "YOUR_USERNAME_8",
      "clientKey": "YOUR_CLIENT_KEY_8",
      "allowedIpAddresses": [],
      "roles": [
        "Checkout encrypted cardholder data",
        "Merchant Recurring role",
        "Checkout webservice role",
        "Merchant PAL Webservice role"
      ],
      "active": true,
      "_links": {
        "self": {
          "href": "https://management-test.adyen.com/v1/merchants/YOUR_MERCHANT_ACCOUNT/apiCredentials/YOUR_API_CREDENTIAL_8"
        },
        "allowedOrigins": {
          "href": "https://management-test.adyen.com/v1/merchants/YOUR_MERCHANT_ACCOUNT/apiCredentials/YOUR_API_CREDENTIAL_8/allowedOrigins"
        },
        "generateApiKey": {
          "href": "https://management-test.adyen.com/v1/merchants/YOUR_MERCHANT_ACCOUNT/apiCredentials/YOUR_API_CREDENTIAL_8/generateApiKey"
        },
        "generateClientKey": {
          "href": "https://management-test.adyen.com/v1/merchants/YOUR_MERCHANT_ACCOUNT/apiCredentials/YOUR_API_CREDENTIAL_8/generateClientKey"
        },
        "merchant": {
          "href": "https://management-test.adyen.com/v1/merchants/YOUR_MERCHANT_ACCOUNT"
        }
      }
    },
    {
      "id": "YOUR_API_CREDENTIAL_9",
      "username": "YOUR_USERNAME_9",
      "clientKey": "YOUR_CLIENT_KEY_9",
      "allowedIpAddresses": [],
      "roles": [
        "Checkout encrypted cardholder data",
        "Merchant Recurring role",
        "API PCI Payments role",
        "Checkout webservice role",
        "Merchant PAL Webservice role"
      ],
      "active": true,
      "_links": {
        "self": {
          "href": "https://management-test.adyen.com/v1/merchants/YOUR_MERCHANT_ACCOUNT/apiCredentials/YOUR_API_CREDENTIAL_9"
        },
        "allowedOrigins": {
          "href": "https://management-test.adyen.com/v1/merchants/YOUR_MERCHANT_ACCOUNT/apiCredentials/YOUR_API_CREDENTIAL_9/allowedOrigins"
        },
        "generateApiKey": {
          "href": "https://management-test.adyen.com/v1/merchants/YOUR_MERCHANT_ACCOUNT/apiCredentials/YOUR_API_CREDENTIAL_9/generateApiKey"
        },
        "generateClientKey": {
          "href": "https://management-test.adyen.com/v1/merchants/YOUR_MERCHANT_ACCOUNT/apiCredentials/YOUR_API_CREDENTIAL_9/generateClientKey"
        },
        "merchant": {
          "href": "https://management-test.adyen.com/v1/merchants/YOUR_MERCHANT_ACCOUNT"
        }
      }
    },
    {
      "id": "YOUR_API_CREDENTIAL_10",
      "username": "YOUR_USERNAME_10",
      "clientKey": "YOUR_CLIENT_KEY_10",
      "allowedIpAddresses": [],
      "roles": [
        "Checkout encrypted cardholder data",
        "Merchant Recurring role",
        "Checkout webservice role",
        "Merchant PAL Webservice role"
      ],
      "active": true,
      "_links": {
        "self": {
          "href": "https://management-test.adyen.com/v1/merchants/YOUR_MERCHANT_ACCOUNT/apiCredentials/YOUR_API_CREDENTIAL_10"
        },
        "allowedOrigins": {
          "href": "https://management-test.adyen.com/v1/merchants/YOUR_MERCHANT_ACCOUNT/apiCredentials/YOUR_API_CREDENTIAL_10/allowedOrigins"
        },
        "generateApiKey": {
          "href": "https://management-test.adyen.com/v1/merchants/YOUR_MERCHANT_ACCOUNT/apiCredentials/YOUR_API_CREDENTIAL_10/generateApiKey"
        },
        "generateClientKey": {
          "href": "https://management-test.adyen.com/v1/merchants/YOUR_MERCHANT_ACCOUNT/apiCredentials/YOUR_API_CREDENTIAL_10/generateClientKey"
        },
        "merchant": {
          "href": "https://management-test.adyen.com/v1/merchants/YOUR_MERCHANT_ACCOUNT"
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


# Create Merchant Api Credential

Creates an [API credential](https://docs.adyen.com/development-resources/api-credentials) for the company account identified in the path. In the request, you can specify the roles and allowed origins for the new API credential.

The response includes the:

* [API key](https://docs.adyen.com/development-resources/api-authentication#api-key-authentication): used for API request authentication.
* [Client key](https://docs.adyen.com/development-resources/client-side-authentication#how-it-works): public key used for client-side authentication.
* [Username and password](https://docs.adyen.com/development-resources/api-authentication#using-basic-authentication): used for basic authentication.

> Make sure you store the API key securely in your system. You won't be able to retrieve it later.

If your API key is lost or compromised, you need to [generate a new API key](https://docs.adyen.com/api-explorer/#/ManagementService/v1/post/merchants/{merchantId}/apiCredentials/{apiCredentialId}/generateApiKey).

To make this request, your API credential must have the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):

* Management API—API credentials read and write

```csharp
CreateMerchantApiCredentialAsync(
    string merchantId,
    Models.CreateMerchantApiCredentialRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `merchantId` | `string` | Template, Required | The unique identifier of the merchant account. |
| `body` | [`CreateMerchantApiCredentialRequest`](../../doc/models/create-merchant-api-credential-request.md) | Body, Optional | - |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.CreateApiCredentialResponse](../../doc/models/create-api-credential-response.md).

## Example Usage

```csharp
string merchantId = "merchantId6";
CreateMerchantApiCredentialRequest body = new CreateMerchantApiCredentialRequest
{
    AllowedOrigins = new List<string>
    {
        "https://www.mystore.com",
    },
    Roles = new List<string>
    {
        "Checkout webservice role",
    },
};

try
{
    ApiResponse<CreateApiCredentialResponse> result = await apiCredentialsMerchantLevelApi.CreateMerchantApiCredentialAsync(
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
  "id": "YOUR_API_CREDENTIAL",
  "username": "YOUR_USERNAME",
  "clientKey": "YOUR_CLIENT_KEY",
  "allowedIpAddresses": [],
  "roles": [
    "Checkout webservice role"
  ],
  "active": true,
  "allowedOrigins": [
    {
      "id": "YOUR_ALLOWED_ORIGIN",
      "domain": "https://www.mystore.com",
      "_links": {
        "self": {
          "href": "https://management-test.adyen.com/v1/companies/YOUR_COMPANY_ACCOUNT/apiCredentials/YOUR_API_CREDENTIAL/allowedOrigins/YOUR_ALLOWED_ORIGIN"
        }
      }
    }
  ],
  "_links": {
    "self": {
      "href": "https://management-test.adyen.com/v1/companies/YOUR_COMPANY_ACCOUNT/apiCredentials/YOUR_API_CREDENTIAL"
    },
    "allowedOrigins": {
      "href": "https://management-test.adyen.com/v1/companies/YOUR_COMPANY_ACCOUNT/apiCredentials/YOUR_API_CREDENTIAL/allowedOrigins"
    },
    "generateApiKey": {
      "href": "https://management-test.adyen.com/v1/companies/YOUR_COMPANY_ACCOUNT/apiCredentials/YOUR_API_CREDENTIAL/generateApiKey"
    },
    "generateClientKey": {
      "href": "https://management-test.adyen.com/v1/companies/YOUR_COMPANY_ACCOUNT/apiCredentials/YOUR_API_CREDENTIAL/generateClientKey"
    },
    "merchant": {
      "href": "https://management-test.adyen.com/v1/merchants/YOUR_MERCHANT_ACCOUNT"
    }
  },
  "apiKey": "YOUR_API_KEY",
  "password": "YOUR_PASSWORD"
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


# Get Merchant Api Credential

Returns the [API credential](https://docs.adyen.com/development-resources/api-credentials) identified in the path.

To make this request, your API credential must have the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):

* Management API—API credentials read and write

```csharp
GetMerchantApiCredentialAsync(
    string merchantId,
    string apiCredentialId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `merchantId` | `string` | Template, Required | The unique identifier of the merchant account. |
| `apiCredentialId` | `string` | Template, Required | Unique identifier of the API credential. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.ApiCredential](../../doc/models/api-credential.md).

## Example Usage

```csharp
string merchantId = "merchantId6";
string apiCredentialId = "apiCredentialId8";
try
{
    ApiResponse<ApiCredential> result = await apiCredentialsMerchantLevelApi.GetMerchantApiCredentialAsync(
        merchantId,
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
  "id": "YOUR_API_CREDENTIAL",
  "username": "YOUR_USERNAME",
  "clientKey": "YOUR_CLIENT_KEY",
  "allowedIpAddresses": [],
  "roles": [
    "Merchant Report Download role"
  ],
  "active": true,
  "_links": {
    "self": {
      "href": "https://management-test.adyen.com/v1/merchants/YOUR_MERCHANT_ACCOUNT/apiCredentials/YOUR_CREDENTIAL"
    },
    "allowedOrigins": {
      "href": "https://management-test.adyen.com/v1/merchants/YOUR_MERCHANT_ACCOUNT/apiCredentials/YOUR_CREDENTIAL/allowedOrigins"
    },
    "generateApiKey": {
      "href": "https://management-test.adyen.com/v1/merchants/YOUR_MERCHANT_ACCOUNT/apiCredentials/YOUR_CREDENTIAL/generateApiKey"
    },
    "generateClientKey": {
      "href": "https://management-test.adyen.com/v1/merchants/YOUR_MERCHANT_ACCOUNT/apiCredentials/YOUR_CREDENTIAL/generateClientKey"
    },
    "merchant": {
      "href": "https://management-test.adyen.com/v1/merchants/YOUR_MERCHANT_ACCOUNT"
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


# Update Merchant Api Credential

Changes the API credential's roles, or allowed origins. The request has the new values for the fields you want to change. The response contains the full updated API credential, including the new values from the request.

To make this request, your API credential must have the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):

* Management API—API credentials read and write

```csharp
UpdateMerchantApiCredentialAsync(
    string merchantId,
    string apiCredentialId,
    Models.UpdateMerchantApiCredentialRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `merchantId` | `string` | Template, Required | The unique identifier of the merchant account. |
| `apiCredentialId` | `string` | Template, Required | Unique identifier of the API credential. |
| `body` | [`UpdateMerchantApiCredentialRequest`](../../doc/models/update-merchant-api-credential-request.md) | Body, Optional | - |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.ApiCredential](../../doc/models/api-credential.md).

## Example Usage

```csharp
string merchantId = "merchantId6";
string apiCredentialId = "apiCredentialId8";
UpdateMerchantApiCredentialRequest body = new UpdateMerchantApiCredentialRequest
{
    Active = true,
};

try
{
    ApiResponse<ApiCredential> result = await apiCredentialsMerchantLevelApi.UpdateMerchantApiCredentialAsync(
        merchantId,
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
  "id": "YOUR_API_CREDENTIAL",
  "username": "YOUR_USERNAME",
  "clientKey": "YOUR_CLIENT_KEY",
  "allowedIpAddresses": [],
  "roles": [
    "Checkout webservice role",
    "Merchant PAL Webservice role"
  ],
  "active": true,
  "allowedOrigins": [
    {
      "id": "YOUR_ALLOWED_ORIGIN",
      "domain": "https://www.mystore.com",
      "_links": {
        "self": {
          "href": "https://management-test.adyen.com/v1/companies/YOUR_COMPANY_ACCOUNT/apiCredentials/YOUR_API_CREDENTIAL/allowedOrigins/YOUR_ALLOWED_ORIGIN"
        }
      }
    }
  ],
  "_links": {
    "self": {
      "href": "https://management-test.adyen.com/v1/companies/YOUR_COMPANY_ACCOUNT/apiCredentials/YOUR_API_CREDENTIAL"
    },
    "allowedOrigins": {
      "href": "https://management-test.adyen.com/v1/companies/YOUR_COMPANY_ACCOUNT/apiCredentials/YOUR_API_CREDENTIAL/allowedOrigins"
    },
    "generateApiKey": {
      "href": "https://management-test.adyen.com/v1/companies/YOUR_COMPANY_ACCOUNT/apiCredentials/YOUR_API_CREDENTIAL/generateApiKey"
    },
    "generateClientKey": {
      "href": "https://management-test.adyen.com/v1/companies/YOUR_COMPANY_ACCOUNT/apiCredentials/YOUR_API_CREDENTIAL/generateClientKey"
    },
    "merchant": {
      "href": "https://management-test.adyen.com/v1/merchants/YOUR_MERCHANT_ACCOUNT"
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

