# AP Icredentials-Companylevel

```csharp
ApIcredentialsCompanylevelApi apIcredentialsCompanylevelApi = client.ApIcredentialsCompanylevelApi;
```

## Class Name

`ApIcredentialsCompanylevelApi`

## Methods

* [List Company Api Credentials](../../doc/controllers/ap-icredentials-companylevel.md#list-company-api-credentials)
* [Create Company Api Credential](../../doc/controllers/ap-icredentials-companylevel.md#create-company-api-credential)
* [Get Company Api Credential](../../doc/controllers/ap-icredentials-companylevel.md#get-company-api-credential)
* [Update Company Api Credential](../../doc/controllers/ap-icredentials-companylevel.md#update-company-api-credential)


# List Company Api Credentials

Returns the list of [API credentials](https://docs.adyen.com/development-resources/api-credentials) for the company account. The list is grouped into pages as defined by the query parameters.

To make this request, your API credential must have the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):

* Management API—API credentials read and write

```csharp
ListCompanyApiCredentialsAsync(
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

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.ListCompanyApiCredentialsResponse](../../doc/models/list-company-api-credentials-response.md).

## Example Usage

```csharp
string companyId = "companyId0";
try
{
    ApiResponse<ListCompanyApiCredentialsResponse> result = await apiCredentialsCompanyLevelApi.ListCompanyApiCredentialsAsync(companyId);
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
      "href": "https://management-test.adyen.com/v1/companies/YOUR_COMPANY_ACCOUNT/apiCredentials?pageNumber=1&pageSize=10"
    },
    "last": {
      "href": "https://management-test.adyen.com/v1/companies/YOUR_COMPANY_ACCOUNT/apiCredentials?pageNumber=3&pageSize=10"
    },
    "next": {
      "href": "https://management-test.adyen.com/v1/companies/YOUR_COMPANY_ACCOUNT/apiCredentials?pageNumber=2&pageSize=10"
    },
    "self": {
      "href": "https://management-test.adyen.com/v1/companies/YOUR_COMPANY_ACCOUNT/apiCredentials?pageNumber=1&pageSize=10"
    }
  },
  "itemsTotal": 25,
  "pagesTotal": 3,
  "data": [
    {
      "id": "YOUR_API_CREDENTIAL_1",
      "username": "YOUR_USERNAME_1",
      "clientKey": "YOUR_CLIENT_KEY_1",
      "allowedIpAddresses": [],
      "roles": [
        "Checkout encrypted cardholder data",
        "Merchant Recurring role",
        "Checkout webservice role"
      ],
      "active": true,
      "allowedOrigins": [
        {
          "id": "YOUR_ALLOWED_ORIGIN_1",
          "domain": "http://localhost",
          "_links": {
            "self": {
              "href": "https://management-test.adyen.com/v1/companies/YOUR_COMPANY_ACCOUNT/apiCredentials/YOUR_API_CREDENTIAL_1/allowedOrigins/YOUR_ALLOWED_ORIGIN_1"
            }
          }
        },
        {
          "id": "YOUR_ALLOWED_ORIGIN_2",
          "domain": "http://localhost:3000",
          "_links": {
            "self": {
              "href": "https://management-test.adyen.com/v1/companies/YOUR_COMPANY_ACCOUNT/apiCredentials/YOUR_API_CREDENTIAL_1/allowedOrigins/YOUR_ALLOWED_ORIGIN_2"
            }
          }
        }
      ],
      "_links": {
        "self": {
          "href": "https://management-test.adyen.com/v1/companies/YOUR_COMPANY_ACCOUNT/apiCredentials/YOUR_API_CREDENTIAL_1"
        },
        "allowedOrigins": {
          "href": "https://management-test.adyen.com/v1/companies/YOUR_COMPANY_ACCOUNT/apiCredentials/YOUR_API_CREDENTIAL_1/allowedOrigins"
        },
        "company": {
          "href": "https://management-test.adyen.com/v1/companies/YOUR_COMPANY_ACCOUNT"
        },
        "generateApiKey": {
          "href": "https://management-test.adyen.com/v1/companies/YOUR_COMPANY_ACCOUNT/apiCredentials/YOUR_API_CREDENTIAL_1/generateApiKey"
        },
        "generateClientKey": {
          "href": "https://management-test.adyen.com/v1/companies/YOUR_COMPANY_ACCOUNT/apiCredentials/YOUR_API_CREDENTIAL_1/generateClientKey"
        }
      },
      "associatedMerchantAccounts": []
    },
    {
      "id": "YOUR_API_CREDENTIAL_2",
      "username": "YOUR_USERNAME_2",
      "clientKey": "YOUR_CLIENT_KEY_2",
      "allowedIpAddresses": [],
      "roles": [
        "Checkout encrypted cardholder data",
        "Merchant Recurring role",
        "Checkout webservice role"
      ],
      "active": true,
      "_links": {
        "self": {
          "href": "https://management-test.adyen.com/v1/companies/YOUR_COMPANY_ACCOUNT/apiCredentials/YOUR_API_CREDENTIAL_2"
        },
        "allowedOrigins": {
          "href": "https://management-test.adyen.com/v1/companies/YOUR_COMPANY_ACCOUNT/apiCredentials/YOUR_API_CREDENTIAL_2/allowedOrigins"
        },
        "company": {
          "href": "https://management-test.adyen.com/v1/companies/YOUR_COMPANY_ACCOUNT"
        },
        "generateApiKey": {
          "href": "https://management-test.adyen.com/v1/companies/YOUR_COMPANY_ACCOUNT/apiCredentials/YOUR_API_CREDENTIAL_2/generateApiKey"
        },
        "generateClientKey": {
          "href": "https://management-test.adyen.com/v1/companies/YOUR_COMPANY_ACCOUNT/apiCredentials/YOUR_API_CREDENTIAL_2/generateClientKey"
        }
      },
      "associatedMerchantAccounts": []
    },
    {
      "id": "YOUR_API_CREDENTIAL_3",
      "username": "YOUR_USERNAME_3",
      "clientKey": "YOUR_CLIENT_KEY_3",
      "allowedIpAddresses": [],
      "roles": [
        "API Supply MPI data with Payments",
        "Checkout encrypted cardholder data",
        "Merchant Recurring role",
        "API PCI Payments role",
        "Checkout webservice role",
        "API 3DS 2.0 to retrieve the ThreeDS2Result for authentication only"
      ],
      "active": true,
      "_links": {
        "self": {
          "href": "https://management-test.adyen.com/v1/companies/YOUR_COMPANY_ACCOUNT/apiCredentials/YOUR_API_CREDENTIAL_3"
        },
        "allowedOrigins": {
          "href": "https://management-test.adyen.com/v1/companies/YOUR_COMPANY_ACCOUNT/apiCredentials/YOUR_API_CREDENTIAL_3/allowedOrigins"
        },
        "company": {
          "href": "https://management-test.adyen.com/v1/companies/YOUR_COMPANY_ACCOUNT"
        },
        "generateApiKey": {
          "href": "https://management-test.adyen.com/v1/companies/YOUR_COMPANY_ACCOUNT/apiCredentials/YOUR_API_CREDENTIAL_3/generateApiKey"
        },
        "generateClientKey": {
          "href": "https://management-test.adyen.com/v1/companies/YOUR_COMPANY_ACCOUNT/apiCredentials/YOUR_API_CREDENTIAL_3/generateClientKey"
        }
      },
      "associatedMerchantAccounts": []
    },
    {
      "id": "YOUR_API_CREDENTIAL_4",
      "username": "YOUR_USERNAME_4",
      "clientKey": "YOUR_CLIENT_KEY_4",
      "allowedIpAddresses": [],
      "roles": [
        "Checkout encrypted cardholder data",
        "Checkout webservice role"
      ],
      "active": true,
      "_links": {
        "self": {
          "href": "https://management-test.adyen.com/v1/companies/YOUR_COMPANY_ACCOUNT/apiCredentials/YOUR_API_CREDENTIAL_4"
        },
        "allowedOrigins": {
          "href": "https://management-test.adyen.com/v1/companies/YOUR_COMPANY_ACCOUNT/apiCredentials/YOUR_API_CREDENTIAL_4/allowedOrigins"
        },
        "company": {
          "href": "https://management-test.adyen.com/v1/companies/YOUR_COMPANY_ACCOUNT"
        },
        "generateApiKey": {
          "href": "https://management-test.adyen.com/v1/companies/YOUR_COMPANY_ACCOUNT/apiCredentials/YOUR_API_CREDENTIAL_4/generateApiKey"
        },
        "generateClientKey": {
          "href": "https://management-test.adyen.com/v1/companies/YOUR_COMPANY_ACCOUNT/apiCredentials/YOUR_API_CREDENTIAL_4/generateClientKey"
        }
      },
      "associatedMerchantAccounts": [
        "YOUR_MERCHANT_ACCOUNT_1"
      ]
    },
    {
      "id": "YOUR_API_CREDENTIAL_5",
      "username": "YOUR_USERNAME_5",
      "clientKey": "YOUR_CLIENT_KEY_5",
      "allowedIpAddresses": [],
      "roles": [
        "Checkout encrypted cardholder data",
        "Merchant Recurring role",
        "API Authorise Referred Payments",
        "API PCI Payments role",
        "Checkout webservice role",
        "Merchant PAL Webservice role"
      ],
      "active": true,
      "_links": {
        "self": {
          "href": "https://management-test.adyen.com/v1/companies/YOUR_COMPANY_ACCOUNT/apiCredentials/YOUR_API_CREDENTIAL_5"
        },
        "allowedOrigins": {
          "href": "https://management-test.adyen.com/v1/companies/YOUR_COMPANY_ACCOUNT/apiCredentials/YOUR_API_CREDENTIAL_5/allowedOrigins"
        },
        "company": {
          "href": "https://management-test.adyen.com/v1/companies/YOUR_COMPANY_ACCOUNT"
        },
        "generateApiKey": {
          "href": "https://management-test.adyen.com/v1/companies/YOUR_COMPANY_ACCOUNT/apiCredentials/YOUR_API_CREDENTIAL_5/generateApiKey"
        },
        "generateClientKey": {
          "href": "https://management-test.adyen.com/v1/companies/YOUR_COMPANY_ACCOUNT/apiCredentials/YOUR_API_CREDENTIAL_5/generateClientKey"
        }
      },
      "associatedMerchantAccounts": []
    },
    {
      "id": "YOUR_API_CREDENTIAL_6",
      "username": "YOUR_USERNAME_6",
      "clientKey": "YOUR_CLIENT_KEY_6",
      "allowedIpAddresses": [],
      "roles": [
        "Merchant Report Download role"
      ],
      "active": true,
      "_links": {
        "self": {
          "href": "https://management-test.adyen.com/v1/companies/YOUR_COMPANY_ACCOUNT/apiCredentials/YOUR_API_CREDENTIAL_6"
        },
        "allowedOrigins": {
          "href": "https://management-test.adyen.com/v1/companies/YOUR_COMPANY_ACCOUNT/apiCredentials/YOUR_API_CREDENTIAL_6/allowedOrigins"
        },
        "company": {
          "href": "https://management-test.adyen.com/v1/companies/YOUR_COMPANY_ACCOUNT"
        },
        "generateApiKey": {
          "href": "https://management-test.adyen.com/v1/companies/YOUR_COMPANY_ACCOUNT/apiCredentials/YOUR_API_CREDENTIAL_6/generateApiKey"
        },
        "generateClientKey": {
          "href": "https://management-test.adyen.com/v1/companies/YOUR_COMPANY_ACCOUNT/apiCredentials/YOUR_API_CREDENTIAL_6/generateClientKey"
        }
      },
      "associatedMerchantAccounts": []
    },
    {
      "id": "YOUR_API_CREDENTIAL_7",
      "username": "YOUR_USERNAME_7",
      "clientKey": "YOUR_CLIENT_KEY_7",
      "allowedIpAddresses": [],
      "roles": [
        "Merchant Report Download role"
      ],
      "active": true,
      "_links": {
        "self": {
          "href": "https://management-test.adyen.com/v1/companies/YOUR_COMPANY_ACCOUNT/apiCredentials/YOUR_API_CREDENTIAL_7"
        },
        "allowedOrigins": {
          "href": "https://management-test.adyen.com/v1/companies/YOUR_COMPANY_ACCOUNT/apiCredentials/YOUR_API_CREDENTIAL_7/allowedOrigins"
        },
        "company": {
          "href": "https://management-test.adyen.com/v1/companies/YOUR_COMPANY_ACCOUNT"
        },
        "generateApiKey": {
          "href": "https://management-test.adyen.com/v1/companies/YOUR_COMPANY_ACCOUNT/apiCredentials/YOUR_API_CREDENTIAL_7/generateApiKey"
        },
        "generateClientKey": {
          "href": "https://management-test.adyen.com/v1/companies/YOUR_COMPANY_ACCOUNT/apiCredentials/YOUR_API_CREDENTIAL_7/generateClientKey"
        }
      },
      "associatedMerchantAccounts": [
        "YOUR_MERCHANT_ACCOUNT_2",
        "YOUR_MERCHANT_ACCOUNT_3"
      ]
    },
    {
      "id": "YOUR_API_CREDENTIAL_8",
      "username": "YOUR_USERNAME_8",
      "clientKey": "YOUR_CLIENT_KEY_8",
      "allowedIpAddresses": [],
      "roles": [
        "Merchant Report Download role"
      ],
      "active": true,
      "_links": {
        "self": {
          "href": "https://management-test.adyen.com/v1/companies/YOUR_COMPANY_ACCOUNT/apiCredentials/YOUR_API_CREDENTIAL_8"
        },
        "allowedOrigins": {
          "href": "https://management-test.adyen.com/v1/companies/YOUR_COMPANY_ACCOUNT/apiCredentials/YOUR_API_CREDENTIAL_8/allowedOrigins"
        },
        "company": {
          "href": "https://management-test.adyen.com/v1/companies/YOUR_COMPANY_ACCOUNT"
        },
        "generateApiKey": {
          "href": "https://management-test.adyen.com/v1/companies/YOUR_COMPANY_ACCOUNT/apiCredentials/YOUR_API_CREDENTIAL_8/generateApiKey"
        },
        "generateClientKey": {
          "href": "https://management-test.adyen.com/v1/companies/YOUR_COMPANY_ACCOUNT/apiCredentials/YOUR_API_CREDENTIAL_8/generateClientKey"
        }
      },
      "associatedMerchantAccounts": []
    },
    {
      "id": "YOUR_API_CREDENTIAL_9",
      "username": "YOUR_USERNAME_9",
      "clientKey": "YOUR_CLIENT_KEY_9",
      "allowedIpAddresses": [],
      "roles": [
        "Merchant Report Download role"
      ],
      "active": true,
      "_links": {
        "self": {
          "href": "https://management-test.adyen.com/v1/companies/YOUR_COMPANY_ACCOUNT/apiCredentials/YOUR_API_CREDENTIAL_9"
        },
        "allowedOrigins": {
          "href": "https://management-test.adyen.com/v1/companies/YOUR_COMPANY_ACCOUNT/apiCredentials/YOUR_API_CREDENTIAL_9/allowedOrigins"
        },
        "company": {
          "href": "https://management-test.adyen.com/v1/companies/YOUR_COMPANY_ACCOUNT"
        },
        "generateApiKey": {
          "href": "https://management-test.adyen.com/v1/companies/YOUR_COMPANY_ACCOUNT/apiCredentials/YOUR_API_CREDENTIAL_9/generateApiKey"
        },
        "generateClientKey": {
          "href": "https://management-test.adyen.com/v1/companies/YOUR_COMPANY_ACCOUNT/apiCredentials/YOUR_API_CREDENTIAL_9/generateClientKey"
        }
      },
      "associatedMerchantAccounts": [
        "YOUR_MERCHANT_ACCOUNT_4",
        "YOUR_MERCHANT_ACCOUNT_5"
      ]
    },
    {
      "id": "YOUR_API_CREDENTIAL_10",
      "username": "YOUR_USERNAME_10",
      "clientKey": "YOUR_CLIENT_KEY_10",
      "allowedIpAddresses": [],
      "roles": [
        "Merchant Report Download role"
      ],
      "active": true,
      "_links": {
        "self": {
          "href": "https://management-test.adyen.com/v1/companies/YOUR_COMPANY_ACCOUNT/apiCredentials/YOUR_API_CREDENTIAL_10"
        },
        "allowedOrigins": {
          "href": "https://management-test.adyen.com/v1/companies/YOUR_COMPANY_ACCOUNT/apiCredentials/YOUR_API_CREDENTIAL_10/allowedOrigins"
        },
        "company": {
          "href": "https://management-test.adyen.com/v1/companies/YOUR_COMPANY_ACCOUNT"
        },
        "generateApiKey": {
          "href": "https://management-test.adyen.com/v1/companies/YOUR_COMPANY_ACCOUNT/apiCredentials/YOUR_API_CREDENTIAL_10/generateApiKey"
        },
        "generateClientKey": {
          "href": "https://management-test.adyen.com/v1/companies/YOUR_COMPANY_ACCOUNT/apiCredentials/YOUR_API_CREDENTIAL_10/generateClientKey"
        }
      },
      "associatedMerchantAccounts": []
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


# Create Company Api Credential

Creates an [API credential](https://docs.adyen.com/development-resources/api-credentials) for the company account identified in the path. In the request, you can specify which merchant accounts the new API credential will have access to, as well as its roles and allowed origins.

The response includes several types of authentication details:

* [API key](https://docs.adyen.com/development-resources/api-authentication#api-key-authentication): used for API request authentication.
* [Client key](https://docs.adyen.com/development-resources/client-side-authentication#how-it-works): public key used for client-side authentication.
* [Username and password](https://docs.adyen.com/development-resources/api-authentication#using-basic-authentication): used for basic authentication.

> Make sure you store the API key securely in your system. You won't be able to retrieve it later.

If your API key is lost or compromised, you need to [generate a new API key](https://docs.adyen.com/api-explorer/#/ManagementService/v1/post/companies/{companyId}/apiCredentials/{apiCredentialId}/generateApiKey).

To make this request, your API credential must have the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):

* Management API—API credentials read and write

```csharp
CreateCompanyApiCredentialAsync(
    string companyId,
    Models.CreateCompanyApiCredentialRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `companyId` | `string` | Template, Required | The unique identifier of the company account. |
| `body` | [`CreateCompanyApiCredentialRequest`](../../doc/models/create-company-api-credential-request.md) | Body, Optional | - |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.CreateCompanyApiCredentialResponse](../../doc/models/create-company-api-credential-response.md).

## Example Usage

```csharp
string companyId = "companyId0";
CreateCompanyApiCredentialRequest body = new CreateCompanyApiCredentialRequest
{
    AllowedOrigins = new List<string>
    {
        "https://www.mystore.com",
    },
    AssociatedMerchantAccounts = new List<string>
    {
        "YOUR_MERCHANT_ACCOUNT_AU",
        "YOUR_MERCHANT_ACCOUNT_EU",
        "YOUR_MERCHANT_ACCOUNT_US",
    },
    Roles = new List<string>
    {
        "Checkout webservice role",
    },
};

try
{
    ApiResponse<CreateCompanyApiCredentialResponse> result = await apiCredentialsCompanyLevelApi.CreateCompanyApiCredentialAsync(
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
    "company": {
      "href": "https://management-test.adyen.com/v1/companies/YOUR_COMPANY_ACCOUNT"
    },
    "generateApiKey": {
      "href": "https://management-test.adyen.com/v1/companies/YOUR_COMPANY_ACCOUNT/apiCredentials/YOUR_API_CREDENTIAL/generateApiKey"
    },
    "generateClientKey": {
      "href": "https://management-test.adyen.com/v1/companies/YOUR_COMPANY_ACCOUNT/apiCredentials/YOUR_API_CREDENTIAL/generateClientKey"
    }
  },
  "apiKey": "YOUR_API_KEY",
  "password": "YOUR_PASSWORD",
  "associatedMerchantAccounts": [
    "YOUR_MERCHANT_ACCOUNT_AU",
    "YOUR_MERCHANT_ACCOUNT_EU",
    "YOUR_MERCHANT_ACCOUNT_US"
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


# Get Company Api Credential

Returns the [API credential](https://docs.adyen.com/development-resources/api-credentials) identified in the path.

To make this request, your API credential must have the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):

* Management API—API credentials read and write

```csharp
GetCompanyApiCredentialAsync(
    string companyId,
    string apiCredentialId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `companyId` | `string` | Template, Required | The unique identifier of the company account. |
| `apiCredentialId` | `string` | Template, Required | Unique identifier of the API credential. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.CompanyApiCredential](../../doc/models/company-api-credential.md).

## Example Usage

```csharp
string companyId = "companyId0";
string apiCredentialId = "apiCredentialId8";
try
{
    ApiResponse<CompanyApiCredential> result = await apiCredentialsCompanyLevelApi.GetCompanyApiCredentialAsync(
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
  "id": "YOUR_API_CREDENTIAL",
  "username": "YOUR_USERNAME",
  "clientKey": "YOUR_CLIENT_KEY",
  "allowedIpAddresses": [],
  "roles": [
    "Checkout encrypted cardholder data",
    "Merchant Recurring role",
    "Checkout webservice role"
  ],
  "active": true,
  "allowedOrigins": [
    {
      "id": "YOUR_ALLOWED_ORIGIN_1",
      "domain": "http://localhost",
      "_links": {
        "self": {
          "href": "https://management-test.adyen.com/v1/companies/YOUR_COMPANY_ACCOUNT/apiCredentials/YOUR_API_CREDENTIAL/allowedOrigins/YOUR_ALLOWED_ORIGIN_1"
        }
      }
    },
    {
      "id": "YOUR_ALLOWED_ORIGIN_2",
      "domain": "http://localhost:3000",
      "_links": {
        "self": {
          "href": "https://management-test.adyen.com/v1/companies/YOUR_COMPANY_ACCOUNT/apiCredentials/YOUR_API_CREDENTIAL/allowedOrigins/YOUR_ALLOWED_ORIGIN_2"
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
    "company": {
      "href": "https://management-test.adyen.com/v1/companies/YOUR_COMPANY_ACCOUNT"
    },
    "generateApiKey": {
      "href": "https://management-test.adyen.com/v1/companies/YOUR_COMPANY_ACCOUNT/apiCredentials/YOUR_API_CREDENTIAL/generateApiKey"
    },
    "generateClientKey": {
      "href": "https://management-test.adyen.com/v1/companies/YOUR_COMPANY_ACCOUNT/apiCredentials/YOUR_API_CREDENTIAL/generateClientKey"
    }
  },
  "associatedMerchantAccounts": []
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


# Update Company Api Credential

Changes the API credential's roles, merchant account access, or allowed origins. The request has the new values for the fields you want to change. The response contains the full updated API credential, including the new values from the request.

To make this request, your API credential must have the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):

* Management API—API credentials read and write

```csharp
UpdateCompanyApiCredentialAsync(
    string companyId,
    string apiCredentialId,
    Models.UpdateCompanyApiCredentialRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `companyId` | `string` | Template, Required | The unique identifier of the company account. |
| `apiCredentialId` | `string` | Template, Required | Unique identifier of the API credential. |
| `body` | [`UpdateCompanyApiCredentialRequest`](../../doc/models/update-company-api-credential-request.md) | Body, Optional | - |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.CompanyApiCredential](../../doc/models/company-api-credential.md).

## Example Usage

```csharp
string companyId = "companyId0";
string apiCredentialId = "apiCredentialId8";
UpdateCompanyApiCredentialRequest body = new UpdateCompanyApiCredentialRequest
{
    Active = true,
};

try
{
    ApiResponse<CompanyApiCredential> result = await apiCredentialsCompanyLevelApi.UpdateCompanyApiCredentialAsync(
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
  "id": "YOUR_API_CREDENTIAL",
  "username": "YOUR_USERNAME",
  "clientKey": "YOUR_CLIENT_KEY",
  "allowedIpAddresses": [],
  "roles": [
    "Management API - Accounts read",
    "Management API - Webhooks read",
    "Management API - API credentials read and write",
    "Management API - Stores read",
    "Management API — Payment methods read",
    "Management API - Stores read and write",
    "Management API - Webhooks read and write",
    "Merchant Recurring role",
    "Data Protection API",
    "Management API - Payout Account Settings Read",
    "Checkout webservice role",
    "Management API - Accounts read and write",
    "Merchant PAL Webservice role"
  ],
  "active": true,
  "_links": {
    "self": {
      "href": "https://management-test.adyen.com/v1/companies/YOUR_COMPANY_ACCOUNT/apiCredentials/YOUR_API_CREDENTIAL"
    },
    "allowedOrigins": {
      "href": "https://management-test.adyen.com/v1/companies/YOUR_COMPANY_ACCOUNT/apiCredentials/YOUR_API_CREDENTIAL/allowedOrigins"
    },
    "company": {
      "href": "https://management-test.adyen.com/v1/companies/YOUR_COMPANY_ACCOUNT"
    },
    "generateApiKey": {
      "href": "https://management-test.adyen.com/v1/companies/YOUR_COMPANY_ACCOUNT/apiCredentials/YOUR_API_CREDENTIAL/generateApiKey"
    },
    "generateClientKey": {
      "href": "https://management-test.adyen.com/v1/companies/YOUR_COMPANY_ACCOUNT/apiCredentials/YOUR_API_CREDENTIAL/generateClientKey"
    }
  },
  "associatedMerchantAccounts": []
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

