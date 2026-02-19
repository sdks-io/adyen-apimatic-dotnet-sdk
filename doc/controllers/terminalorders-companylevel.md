# Terminalorders-Companylevel

```csharp
TerminalordersCompanylevelApi terminalordersCompanylevelApi = client.TerminalordersCompanylevelApi;
```

## Class Name

`TerminalordersCompanylevelApi`

## Methods

* [Get-Companies-Company Id-Billing Entities](../../doc/controllers/terminalorders-companylevel.md#get-companies-company-id-billing-entities)
* [Get-Companies-Company Id-Shipping Locations](../../doc/controllers/terminalorders-companylevel.md#get-companies-company-id-shipping-locations)
* [Post-Companies-Company Id-Shipping Locations](../../doc/controllers/terminalorders-companylevel.md#post-companies-company-id-shipping-locations)
* [Get-Companies-Company Id-Terminal Models](../../doc/controllers/terminalorders-companylevel.md#get-companies-company-id-terminal-models)
* [Get-Companies-Company Id-Terminal Orders](../../doc/controllers/terminalorders-companylevel.md#get-companies-company-id-terminal-orders)
* [Post-Companies-Company Id-Terminal Orders](../../doc/controllers/terminalorders-companylevel.md#post-companies-company-id-terminal-orders)
* [Get-Companies-Company Id-Terminal Orders-Order Id](../../doc/controllers/terminalorders-companylevel.md#get-companies-company-id-terminal-orders-order-id)
* [Patch-Companies-Company Id-Terminal Orders-Order Id](../../doc/controllers/terminalorders-companylevel.md#patch-companies-company-id-terminal-orders-order-id)
* [Post-Companies-Company Id-Terminal Orders-Order Id-Cancel](../../doc/controllers/terminalorders-companylevel.md#post-companies-company-id-terminal-orders-order-id-cancel)
* [Get-Companies-Company Id-Terminal Products](../../doc/controllers/terminalorders-companylevel.md#get-companies-company-id-terminal-products)


# Get-Companies-Company Id-Billing Entities

Returns the billing entities of the company identified in the path and all merchant accounts belonging to the company.
A billing entity is a legal entity where we charge orders to. An order for terminal products must contain the ID of a billing entity.

To make this request, your API credential must have one of the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):

* Management API—Terminal ordering read
* Management API—Terminal ordering read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

```csharp
GetCompaniesCompanyIdBillingEntitiesAsync(
    string companyId,
    string name = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `companyId` | `string` | Template, Required | The unique identifier of the company account. |
| `name` | `string` | Query, Optional | The name of the billing entity. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.BillingEntitiesResponse](../../doc/models/billing-entities-response.md).

## Example Usage

```csharp
string companyId = "companyId0";
try
{
    ApiResponse<BillingEntitiesResponse> result = await terminalOrdersCompanyLevelApi.GetCompaniesCompanyIdBillingEntitiesAsync(companyId);
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
      "id": "Company.YOUR_COMPANY",
      "name": "YOUR_COMPANY",
      "taxId": "NL1234567890",
      "email": "Paul.Green@company.com",
      "address": {
        "streetAddress": "Simon Carmiggeltstraat 6-50",
        "postalCode": "1011 DJ",
        "city": "Amsterdam",
        "country": "NL"
      }
    },
    {
      "id": "MerchantAccount.YOUR_MERCHANT_ACCOUNT",
      "name": "YOUR_MERCHANT_ACCOUNT",
      "taxId": "ES1234567890",
      "email": "Pablo.Mengano@company.com",
      "address": {
        "streetAddress": "Paseo de la Castellana 43, 7",
        "postalCode": "28046",
        "city": "Madrid",
        "country": "ES"
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


# Get-Companies-Company Id-Shipping Locations

Returns the shipping locations for the company identified in the path and all merchant accounts belonging to the company.
A shipping location includes the address where orders can be delivered, and an ID which you need to specify when ordering terminal products.

To make this request, your API credential must have one of the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):

* Management API—Terminal ordering read
* Management API—Terminal ordering read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

```csharp
GetCompaniesCompanyIdShippingLocationsAsync(
    string companyId,
    string name = null,
    int? offset = null,
    int? limit = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `companyId` | `string` | Template, Required | The unique identifier of the company account. |
| `name` | `string` | Query, Optional | The name of the shipping location. |
| `offset` | `int?` | Query, Optional | The number of locations to skip. |
| `limit` | `int?` | Query, Optional | The number of locations to return. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.ShippingLocationsResponse](../../doc/models/shipping-locations-response.md).

## Example Usage

```csharp
string companyId = "companyId0";
try
{
    ApiResponse<ShippingLocationsResponse> result = await terminalOrdersCompanyLevelApi.GetCompaniesCompanyIdShippingLocationsAsync(companyId);
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
      "id": "S2-232A6D2967356F424F4369432B3F486B6A6D",
      "name": "YOUR_COMPANY HQ - POS Ops",
      "contact": {
        "firstName": "Paul",
        "lastName": "Green",
        "email": "Paul.Green@company.com"
      },
      "address": {
        "streetAddress": "Simon Carmiggeltstraat",
        "streetAddress2": "6-50",
        "postalCode": "1011 DJ",
        "city": "Amsterdam",
        "country": "NL"
      }
    },
    {
      "id": "S2-6A6C2E3432747D4F2F2C3455485E3836457D",
      "name": "YOUR_COMPANY Spain",
      "contact": {
        "firstName": "Pablo",
        "lastName": "Mengano",
        "phoneNumber": "+34911234567",
        "email": "Pablo.Mengano@company.com"
      },
      "address": {
        "streetAddress": "Paseo de la Castellana 43",
        "streetAddress2": "7 piso",
        "postalCode": "28046",
        "city": "Madrid",
        "country": "ES"
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


# Post-Companies-Company Id-Shipping Locations

Creates a shipping location for the company identified in the path. A shipping location defines an address where orders can be delivered.

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):

* Management API—Terminal ordering read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

```csharp
PostCompaniesCompanyIdShippingLocationsAsync(
    string companyId,
    Models.ShippingLocation body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `companyId` | `string` | Template, Required | The unique identifier of the company account. |
| `body` | [`ShippingLocation`](../../doc/models/shipping-location.md) | Body, Optional | - |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.ShippingLocation](../../doc/models/shipping-location.md).

## Example Usage

```csharp
string companyId = "companyId0";
ShippingLocation body = new ShippingLocation
{
    Address = new Address21
    {
        City = "Amsterdam",
        CompanyName = "YOUR_COMPANY",
        Country = "NL",
        PostalCode = "1012 KS",
        StateOrProvince = "",
        StreetAddress = "Rokin 21",
    },
    Contact = new Contact1
    {
        Email = "Paul.Green@company.com",
        FirstName = "Paul",
        LastName = "Green",
        PhoneNumber = "+31 020 1234567",
    },
    Name = "YOUR_COMPANY Rokin depot",
};

try
{
    ApiResponse<ShippingLocation> result = await terminalOrdersCompanyLevelApi.PostCompaniesCompanyIdShippingLocationsAsync(
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
  "id": "S2-7973536B20662642215526704F302044452F714622375D476169",
  "name": "YOUR_COMPANY Rokin depot",
  "contact": {
    "firstName": "Paul",
    "lastName": "Green",
    "phoneNumber": "+31 020 1234567",
    "email": "Paul.Green@company.com"
  },
  "address": {
    "companyName": "YOUR_COMPANY",
    "streetAddress": "Rokin 21",
    "postalCode": "1012 KS",
    "city": "Amsterdam",
    "stateOrProvince": ""
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


# Get-Companies-Company Id-Terminal Models

Returns a list of payment terminal models that the company identified in the path has access to.
The response includes the terminal model ID, which can be used as a query parameter when getting a list of terminals or a list of products for ordering.

To make this request, your API credential must have one of the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):

* Management API—Terminal ordering read
* Management API—Terminal ordering read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

```csharp
GetCompaniesCompanyIdTerminalModelsAsync(
    string companyId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `companyId` | `string` | Template, Required | The unique identifier of the company account. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.TerminalModelsResponse](../../doc/models/terminal-models-response.md).

## Example Usage

```csharp
string companyId = "companyId0";
try
{
    ApiResponse<TerminalModelsResponse> result = await terminalOrdersCompanyLevelApi.GetCompaniesCompanyIdTerminalModelsAsync(companyId);
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
      "id": "Verifone.e315",
      "name": "Verifone e315"
    },
    {
      "id": "Verifone.e315M",
      "name": "Verifone e315M"
    },
    {
      "id": "Verifone.E355",
      "name": "Verifone E355"
    },
    {
      "id": "Verifone.M400",
      "name": "Verifone M400"
    },
    {
      "id": "Verifone.MX915",
      "name": "Verifone MX915"
    },
    {
      "id": "Verifone.MX925",
      "name": "Verifone MX925"
    },
    {
      "id": "Verifone.P400",
      "name": "Verifone P400"
    },
    {
      "id": "Verifone.P400Plus",
      "name": "Verifone P400Plus"
    },
    {
      "id": "Verifone.P400Eth",
      "name": "Verifone P400Eth"
    },
    {
      "id": "Verifone.V240m",
      "name": "Verifone V240m"
    },
    {
      "id": "Verifone.V240mPlus",
      "name": "Verifone V240mPlus"
    },
    {
      "id": "Verifone.UX300",
      "name": "Verifone UX300"
    },
    {
      "id": "Verifone.V200cPlus",
      "name": "Verifone V200cPlus"
    },
    {
      "id": "Verifone.V400cPlus",
      "name": "Verifone V400cPlus"
    },
    {
      "id": "Verifone.V400m",
      "name": "Verifone V400m"
    },
    {
      "id": "Verifone.V210mPlus",
      "name": "Verifone V210mPlus"
    },
    {
      "id": "Verifone.VX520",
      "name": "Verifone VX520"
    },
    {
      "id": "Verifone.VX6753G",
      "name": "Verifone VX6753G"
    },
    {
      "id": "Verifone.VX675WIFIBT",
      "name": "Verifone VX675WIFIBT"
    },
    {
      "id": "Verifone.VX680",
      "name": "Verifone VX680"
    },
    {
      "id": "Verifone.VX6803G",
      "name": "Verifone VX6803G"
    },
    {
      "id": "Verifone.VX690",
      "name": "Verifone VX690"
    },
    {
      "id": "Verifone.VX700",
      "name": "Verifone VX700"
    },
    {
      "id": "Verifone.VX810",
      "name": "Verifone VX810"
    },
    {
      "id": "Verifone.VX820",
      "name": "Verifone VX820"
    },
    {
      "id": "Verifone.VX825",
      "name": "Verifone VX825"
    },
    {
      "id": "Verifone.e285",
      "name": "Verifone e285"
    },
    {
      "id": "Verifone.E285",
      "name": "Verifone E285"
    },
    {
      "id": "Verifone.e285p",
      "name": "Verifone e285p"
    },
    {
      "id": "Verifone.e280",
      "name": "Verifone e280"
    },
    {
      "id": "Verifone.UX410",
      "name": "Verifone UX410"
    },
    {
      "id": "Castles.S1E",
      "name": "Castles S1E"
    },
    {
      "id": "Castles.S1EL",
      "name": "Castles S1EL"
    },
    {
      "id": "Castles.S1F",
      "name": "Castles S1F"
    },
    {
      "id": "Castles.S1F2",
      "name": "Castles S1F2"
    },
    {
      "id": "Castles.S1F2L",
      "name": "Castles S1F2L"
    },
    {
      "id": "Castles.S1E2",
      "name": "Castles S1E2"
    },
    {
      "id": "Castles.S1E2L",
      "name": "Castles S1E2L"
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


# Get-Companies-Company Id-Terminal Orders

Returns a lists of terminal products orders for the company identified in the path.
To filter the list, use one or more of the query parameters.

To make this request, your API credential must have one of the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):

* Management API—Terminal ordering read
* Management API—Terminal ordering read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

```csharp
GetCompaniesCompanyIdTerminalOrdersAsync(
    string companyId,
    string customerOrderReference = null,
    string status = null,
    int? offset = null,
    int? limit = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `companyId` | `string` | Template, Required | The unique identifier of the company account. |
| `customerOrderReference` | `string` | Query, Optional | Your purchase order number. |
| `status` | `string` | Query, Optional | The order status. Possible values (not case-sensitive): Placed, Confirmed, Cancelled, Shipped, Delivered. |
| `offset` | `int?` | Query, Optional | The number of orders to skip. |
| `limit` | `int?` | Query, Optional | The number of orders to return. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.TerminalOrdersResponse](../../doc/models/terminal-orders-response.md).

## Example Usage

```csharp
string companyId = "companyId0";
try
{
    ApiResponse<TerminalOrdersResponse> result = await terminalOrdersCompanyLevelApi.GetCompaniesCompanyIdTerminalOrdersAsync(companyId);
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
      "id": "5265677890100681",
      "customerOrderReference": "YOUR_REFERENCE_C2",
      "status": "Placed",
      "shippingLocation": {
        "id": "S2-232A6D2967356F424F4369432B3F486B6A6D",
        "name": "YOUR_COMPANY HQ - POS Ops",
        "contact": {
          "firstName": "Paul",
          "lastName": "Green",
          "email": "Paul.Green@company.com"
        },
        "address": {
          "streetAddress": "Simon Carmiggeltstraat",
          "streetAddress2": "6-50",
          "postalCode": "1011 DJ",
          "city": "Amsterdam",
          "country": "NL"
        }
      },
      "billingEntity": {
        "id": "Company.YOUR_COMPANY",
        "name": "YOUR_COMPANY",
        "taxId": "NL1234567890",
        "email": "Paul.Green@company.com",
        "address": {
          "streetAddress": "Simon Carmiggeltstraat 6-50",
          "postalCode": "1011 DJ",
          "city": "Amsterdam",
          "country": "NL"
        }
      },
      "orderDate": "2020-06-10T17:03:11.000Z",
      "items": [
        {
          "id": "TBOX-MX925-422-EU",
          "name": "MX925 Package",
          "quantity": 1
        }
      ]
    },
    {
      "id": "9415936144678634",
      "customerOrderReference": "YOUR_REFERENCE_C1",
      "status": "Cancelled",
      "shippingLocation": {
        "id": "S2-232A6D2967356F424F4369432B3F486B6A6D",
        "name": "YOUR_COMPANY HQ - POS Ops",
        "contact": {
          "firstName": "Paul",
          "lastName": "Green",
          "email": "Paul.Green@company.com"
        },
        "address": {
          "streetAddress": "Simon Carmiggeltstraat",
          "streetAddress2": "6-50",
          "postalCode": "1011 DJ",
          "city": "Amsterdam",
          "country": "NL"
        }
      },
      "billingEntity": {
        "id": "Company.YOUR_COMPANY",
        "name": "YOUR_COMPANY",
        "taxId": "NL1234567890",
        "email": "Paul.Green@company.com",
        "address": {
          "streetAddress": "Simon Carmiggeltstraat 6-50",
          "postalCode": "1011 DJ",
          "city": "Amsterdam",
          "country": "NL"
        }
      },
      "orderDate": "2022-01-03T16:41:07.000Z",
      "items": [
        {
          "id": "TBOX-V400m-774-EU",
          "name": "V400m Package",
          "quantity": 5
        }
      ]
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


# Post-Companies-Company Id-Terminal Orders

Creates an order for payment terminal products for the company identified in the path.

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):

* Management API—Terminal ordering read and write

> Requests to the Management API test endpoint do not create actual orders for test terminals. To order test terminals, you need to [submit a sales order](https://docs.adyen.com/point-of-sale/managing-terminals/order-terminals/#sales-order-steps) in your Customer Area.

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

```csharp
PostCompaniesCompanyIdTerminalOrdersAsync(
    string companyId,
    Models.TerminalOrderRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `companyId` | `string` | Template, Required | The unique identifier of the company account. |
| `body` | [`TerminalOrderRequest`](../../doc/models/terminal-order-request.md) | Body, Optional | - |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.TerminalOrder](../../doc/models/terminal-order.md).

## Example Usage

```csharp
string companyId = "companyId0";
TerminalOrderRequest body = new TerminalOrderRequest
{
    BillingEntityId = "Company.YOUR_COMPANY",
    CustomerOrderReference = "YOUR_REFERENCE",
    Items = new List<OrderItem>
    {
        new OrderItem
        {
            Id = "TBOX-V400m-684-EU",
            Name = "V400m Package",
            Quantity = 1,
        },
        new OrderItem
        {
            Id = "PART-175746-EU",
            Name = "Adyen Test Card",
            Quantity = 1,
        },
    },
    ShippingLocationId = "S2-6A6C2E3432747D4F2F2C3455485E3836457D",
};

try
{
    ApiResponse<TerminalOrder> result = await terminalOrdersCompanyLevelApi.PostCompaniesCompanyIdTerminalOrdersAsync(
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
  "id": "5265677890100681",
  "customerOrderReference": "YOUR_REFERENCE",
  "status": "Placed",
  "shippingLocation": {
    "id": "S2-232A6D2967356F424F4369432B3F486B6A6D",
    "name": "YOUR_COMPANY HQ - POS Ops",
    "contact": {
      "firstName": "Paul",
      "lastName": "Green",
      "email": "Paul.Green@company.com"
    },
    "address": {
      "streetAddress": "Simon Carmiggeltstraat",
      "streetAddress2": "6-50",
      "postalCode": "1011 DJ",
      "city": "Amsterdam",
      "country": "NL"
    }
  },
  "billingEntity": {
    "id": "Company.YOUR_COMPANY",
    "name": "YOUR_COMPANY",
    "taxId": "NL1234567890",
    "email": "Paul.Green@company.com",
    "address": {
      "streetAddress": "Simon Carmiggeltstraat 6-50",
      "postalCode": "1011 DJ",
      "city": "Amsterdam",
      "country": "NL"
    }
  },
  "orderDate": "2022-01-20T14:12:33Z",
  "items": [
    {
      "id": "TBOX-V400m-684-EU",
      "name": "V400m Package",
      "quantity": 1
    },
    {
      "id": "PART-175746-EU",
      "name": "Adyen Test Card",
      "quantity": 1
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


# Get-Companies-Company Id-Terminal Orders-Order Id

Returns the details of the terminal products order identified in the path.

To make this request, your API credential must have one of the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):

* Management API—Terminal ordering read
* Management API—Terminal ordering read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

```csharp
GetCompaniesCompanyIdTerminalOrdersOrderIdAsync(
    string companyId,
    string orderId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `companyId` | `string` | Template, Required | The unique identifier of the company account. |
| `orderId` | `string` | Template, Required | The unique identifier of the order. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.TerminalOrder](../../doc/models/terminal-order.md).

## Example Usage

```csharp
string companyId = "companyId0";
string orderId = "orderId2";
try
{
    ApiResponse<TerminalOrder> result = await terminalOrdersCompanyLevelApi.GetCompaniesCompanyIdTerminalOrdersOrderIdAsync(
        companyId,
        orderId
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
  "id": "5265677890100681",
  "customerOrderReference": "YOUR_REFERENCE_1",
  "status": "Placed",
  "shippingLocation": {
    "id": "S2-232A6D2967356F424F4369432B3F486B6A6D",
    "name": "YOUR_COMPANY HQ - POS Ops",
    "contact": {
      "firstName": "Paul",
      "lastName": "Green",
      "email": "Paul.Green@company.com"
    },
    "address": {
      "streetAddress": "Simon Carmiggeltstraat",
      "streetAddress2": "6-50",
      "postalCode": "1011 DJ",
      "city": "Amsterdam",
      "country": "NL"
    }
  },
  "billingEntity": {
    "id": "Company.YOUR_COMPANY",
    "name": "YOUR_COMPANY",
    "taxId": "NL1234567890",
    "email": "Paul.Green@company.com",
    "address": {
      "streetAddress": "Simon Carmiggeltstraat 6-50",
      "postalCode": "1011 DJ",
      "city": "Amsterdam",
      "country": "NL"
    }
  },
  "orderDate": "2022-01-20T14:12:33Z",
  "items": [
    {
      "id": "TBOX-V400m-684-EU",
      "name": "V400m Package",
      "quantity": 1
    },
    {
      "id": "PART-175746-EU",
      "name": "Adyen Test Card",
      "quantity": 1
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


# Patch-Companies-Company Id-Terminal Orders-Order Id

Updates the terminal products order identified in the path.
Updating is only possible while the order has the status **Placed**.

The request body only needs to contain what you want to change.
However, to update the products in the `items` array, you must provide the entire array. For example, if the array has three items:
To remove one item, the array must include the remaining two items. Or to add one item, the array must include all four items.

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):

* Management API—Terminal ordering read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

```csharp
PatchCompaniesCompanyIdTerminalOrdersOrderIdAsync(
    string companyId,
    string orderId,
    Models.TerminalOrderRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `companyId` | `string` | Template, Required | The unique identifier of the company account. |
| `orderId` | `string` | Template, Required | The unique identifier of the order. |
| `body` | [`TerminalOrderRequest`](../../doc/models/terminal-order-request.md) | Body, Optional | - |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.TerminalOrder](../../doc/models/terminal-order.md).

## Example Usage

```csharp
string companyId = "companyId0";
string orderId = "orderId2";
TerminalOrderRequest body = new TerminalOrderRequest
{
    Items = new List<OrderItem>
    {
        new OrderItem
        {
            Id = "TBOX-V400m-684-EU",
            Name = "V400m Package",
            Quantity = 1,
        },
        new OrderItem
        {
            Id = "PART-175746-EU",
            Name = "Adyen Test Card",
            Quantity = 1,
        },
        new OrderItem
        {
            Id = "PART-620222-EU",
            Name = "Receipt Roll",
            Quantity = 5,
        },
    },
};

try
{
    ApiResponse<TerminalOrder> result = await terminalOrdersCompanyLevelApi.PatchCompaniesCompanyIdTerminalOrdersOrderIdAsync(
        companyId,
        orderId,
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
  "id": "5265677890100681",
  "customerOrderReference": "YOUR_REFERENCE_1",
  "status": "Placed",
  "shippingLocation": {
    "id": "S2-7973536B20662642215526704F302044452F714622375D476169",
    "name": "YOUR_COMPANY Rokin depot",
    "contact": {
      "firstName": "Paul",
      "lastName": "Green",
      "phoneNumber": "+31 020 1234567",
      "email": "Paul.Green@company.com"
    },
    "address": {
      "companyName": "YOUR_COMPANY",
      "streetAddress": "Rokin 21",
      "postalCode": "1012 KS",
      "city": "Amsterdam",
      "stateOrProvince": "",
      "country": "NL"
    }
  },
  "billingEntity": {
    "id": "Company.YOUR_COMPANY",
    "name": "YOUR_COMPANY",
    "taxId": "NL1234567890",
    "email": "Paul.Green@company.com",
    "address": {
      "streetAddress": "Simon Carmiggeltstraat 6-50",
      "postalCode": "1011 DJ",
      "city": "Amsterdam",
      "country": "NL"
    }
  },
  "orderDate": "2022-01-20T14:12:33Z",
  "items": [
    {
      "id": "TBOX-V400m-684-EU",
      "name": "V400m Package",
      "quantity": 1
    },
    {
      "id": "PART-175746-EU",
      "name": "Adyen Test Card",
      "quantity": 1
    },
    {
      "id": "PART-620222-EU",
      "name": "Receipt Roll",
      "quantity": 5
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


# Post-Companies-Company Id-Terminal Orders-Order Id-Cancel

Cancels the terminal products order identified in the path.
Cancelling is only possible while the order has the status **Placed**.
To cancel an order, make a POST call without a request body. The response returns the full order details, but with the status changed to **Cancelled**.

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):

* Management API—Terminal ordering read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

```csharp
PostCompaniesCompanyIdTerminalOrdersOrderIdCancelAsync(
    string companyId,
    string orderId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `companyId` | `string` | Template, Required | The unique identifier of the company account. |
| `orderId` | `string` | Template, Required | The unique identifier of the order. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.TerminalOrder](../../doc/models/terminal-order.md).

## Example Usage

```csharp
string companyId = "companyId0";
string orderId = "orderId2";
try
{
    ApiResponse<TerminalOrder> result = await terminalOrdersCompanyLevelApi.PostCompaniesCompanyIdTerminalOrdersOrderIdCancelAsync(
        companyId,
        orderId
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
  "id": "5265677890100681",
  "customerOrderReference": "YOUR_REFERENCE",
  "status": "Cancelled",
  "shippingLocation": {
    "id": "S2-232A6D2967356F424F4369432B3F486B6A6D",
    "name": "YOUR_COMPANY HQ - POS Ops",
    "contact": {
      "firstName": "Paul",
      "lastName": "Green",
      "email": "Paul.Green@company.com"
    },
    "address": {
      "streetAddress": "Simon Carmiggeltstraat",
      "streetAddress2": "6-50",
      "postalCode": "1011 DJ",
      "city": "Amsterdam",
      "country": "Netherlands"
    }
  },
  "billingEntity": {
    "id": "Company.YOUR_COMPANY",
    "name": "YOUR_COMPANY",
    "taxId": "NL1234567890",
    "email": "Paul.Green@company.com",
    "address": {
      "streetAddress": "Simon Carmiggeltstraat 6-50",
      "postalCode": "1011 DJ",
      "city": "Amsterdam",
      "country": "Netherlands"
    }
  },
  "orderDate": "2022-01-20T14:12:33Z",
  "items": [
    {
      "id": "TBOX-V400m-684-EU",
      "name": "V400m Package",
      "quantity": 1
    },
    {
      "id": "PART-175746-EU",
      "name": "Adyen Test Card",
      "quantity": 1
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


# Get-Companies-Company Id-Terminal Products

Returns a country-specific list of payment terminal packages and parts that the company identified in the path has access to.

To make this request, your API credential must have one of the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):

* Management API—Terminal ordering read
* Management API—Terminal ordering read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

```csharp
GetCompaniesCompanyIdTerminalProductsAsync(
    string companyId,
    string country,
    string terminalModelId = null,
    int? offset = null,
    int? limit = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `companyId` | `string` | Template, Required | The unique identifier of the company account. |
| `country` | `string` | Query, Required | The country to return products for, in [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) format. For example, **US** |
| `terminalModelId` | `string` | Query, Optional | The terminal model to return products for. Use the ID returned in the [GET `/terminalModels`](https://docs.adyen.com/api-explorer/#/ManagementService/latest/get/companies/{companyId}/terminalModels) response. For example, **Verifone.M400** |
| `offset` | `int?` | Query, Optional | The number of products to skip. |
| `limit` | `int?` | Query, Optional | The number of products to return. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.TerminalProductsResponse](../../doc/models/terminal-products-response.md).

## Example Usage

```csharp
string companyId = "companyId0";
string country = "country4";
try
{
    ApiResponse<TerminalProductsResponse> result = await terminalOrdersCompanyLevelApi.GetCompaniesCompanyIdTerminalProductsAsync(
        companyId,
        country
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
      "id": "PART-620222-EU",
      "name": "Receipt Roll",
      "price": {
        "currency": "EUR",
        "value": 0.0
      }
    },
    {
      "id": "PART-175746-EU",
      "name": "Adyen Test Card",
      "price": {
        "currency": "EUR",
        "value": 0.0
      }
    },
    {
      "id": "PART-327486-EU",
      "name": "Battery - V400m",
      "price": {
        "currency": "EUR",
        "value": 0.0
      }
    },
    {
      "id": "PART-287001-EU",
      "name": "Bluetooth Charging Base - V400m",
      "price": {
        "currency": "EUR",
        "value": 0.0
      }
    },
    {
      "id": "PART-745984-EU",
      "name": "Power Supply EU - V400m",
      "price": {
        "currency": "EUR",
        "value": 0.0
      }
    },
    {
      "id": "TBOX-V400m-684-EU",
      "name": "V400m Package",
      "description": "Includes an EU Power Supply, SIM Card and battery",
      "price": {
        "currency": "EUR",
        "value": 0.0
      },
      "itemsIncluded": [
        "Receipt Roll",
        "Terminal Device V400m EU/GB"
      ]
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

