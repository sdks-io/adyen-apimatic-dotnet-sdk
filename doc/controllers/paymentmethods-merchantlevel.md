# Paymentmethods-Merchantlevel

```csharp
PaymentmethodsMerchantlevelApi paymentmethodsMerchantlevelApi = client.PaymentmethodsMerchantlevelApi;
```

## Class Name

`PaymentmethodsMerchantlevelApi`

## Methods

* [List Payment Method Settings](../../doc/controllers/paymentmethods-merchantlevel.md#list-payment-method-settings)
* [Create Payment Method Setting](../../doc/controllers/paymentmethods-merchantlevel.md#create-payment-method-setting)
* [Get Payment Method Setting](../../doc/controllers/paymentmethods-merchantlevel.md#get-payment-method-setting)
* [Update Payment Method Setting](../../doc/controllers/paymentmethods-merchantlevel.md#update-payment-method-setting)
* [Add Apple Pay Domains](../../doc/controllers/paymentmethods-merchantlevel.md#add-apple-pay-domains)
* [Get Apple Pay Domains](../../doc/controllers/paymentmethods-merchantlevel.md#get-apple-pay-domains)


# List Payment Method Settings

Returns details for all payment methods of the merchant account identified in the path.

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):

* Management API—Payment methods read

```csharp
ListPaymentMethodSettingsAsync(
    string merchantId,
    string storeId = null,
    string businessLineId = null,
    int? pageSize = null,
    int? pageNumber = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `merchantId` | `string` | Template, Required | The unique identifier of the merchant account. |
| `storeId` | `string` | Query, Optional | The unique identifier of the store for which to return the payment methods. |
| `businessLineId` | `string` | Query, Optional | The unique identifier of the Business Line for which to return the payment methods. |
| `pageSize` | `int?` | Query, Optional | The number of items to have on a page, maximum 100. The default is 10 items on a page. |
| `pageNumber` | `int?` | Query, Optional | The number of the page to fetch. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.PaymentMethodResponse](../../doc/models/payment-method-response.md).

## Example Usage

```csharp
string merchantId = "merchantId6";
try
{
    ApiResponse<PaymentMethodResponse> result = await paymentMethodsMerchantLevelApi.ListPaymentMethodSettingsAsync(merchantId);
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
| 429 | - | [`RestServiceErrorException`](../../doc/models/rest-service-error-exception.md) |
| 500 | Internal Server Error - the server could not process the request. | [`RestServiceErrorException`](../../doc/models/rest-service-error-exception.md) |


# Create Payment Method Setting

Sends a request to add a new payment method to the merchant account identified in the path.
Depending the payment method [`type`](https://docs.adyen.com/api-explorer/Management/latest/post/merchants/_merchantId_/paymentMethodSettings#request-type), you may need to send an additional object required for the payment method.

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):

* Management API—Payment methods read and write

```csharp
CreatePaymentMethodSettingAsync(
    string merchantId,
    Models.PaymentMethodSetupInfo body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `merchantId` | `string` | Template, Required | The unique identifier of the merchant account. |
| `body` | [`PaymentMethodSetupInfo`](../../doc/models/payment-method-setup-info.md) | Body, Optional | - |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.PaymentMethod1](../../doc/models/payment-method-1.md).

## Example Usage

```csharp
string merchantId = "merchantId6";
PaymentMethodSetupInfo body = new PaymentMethodSetupInfo
{
    Type = Type410.Visa,
    Countries = new List<string>
    {
        "US",
    },
    Currencies = new List<string>
    {
        "USD",
    },
};

try
{
    ApiResponse<PaymentMethod1> result = await paymentMethodsMerchantLevelApi.CreatePaymentMethodSettingAsync(
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
  "id": "PM3227C223224K5FH84M8CBNH",
  "type": "visa",
  "countries": [
    "US"
  ],
  "currencies": [
    "USD"
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
| 429 | - | [`RestServiceErrorException`](../../doc/models/rest-service-error-exception.md) |
| 500 | Internal Server Error - the server could not process the request. | [`RestServiceErrorException`](../../doc/models/rest-service-error-exception.md) |


# Get Payment Method Setting

Returns details for the merchant account and the payment method identified in the path.

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):

* Management API—Payment methods read

```csharp
GetPaymentMethodSettingAsync(
    string merchantId,
    string paymentMethodId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `merchantId` | `string` | Template, Required | The unique identifier of the merchant account. |
| `paymentMethodId` | `string` | Template, Required | The unique identifier of the payment method. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.PaymentMethod1](../../doc/models/payment-method-1.md).

## Example Usage

```csharp
string merchantId = "merchantId6";
string paymentMethodId = "paymentMethodId2";
try
{
    ApiResponse<PaymentMethod1> result = await paymentMethodsMerchantLevelApi.GetPaymentMethodSettingAsync(
        merchantId,
        paymentMethodId
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
| 429 | - | [`RestServiceErrorException`](../../doc/models/rest-service-error-exception.md) |
| 500 | Internal Server Error - the server could not process the request. | [`RestServiceErrorException`](../../doc/models/rest-service-error-exception.md) |


# Update Payment Method Setting

Updates payment method details for the merchant account and the payment method identified in the path.
Depending the payment method [`type`](https://docs.adyen.com/api-explorer/Management/latest/patch/merchants/_merchantId_/paymentMethodSettings#request-type), you may need to send an additional object required for the payment method.

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):

* Management API—Payment methods read and write

```csharp
UpdatePaymentMethodSettingAsync(
    string merchantId,
    string paymentMethodId,
    Models.UpdatePaymentMethodInfo body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `merchantId` | `string` | Template, Required | The unique identifier of the merchant account. |
| `paymentMethodId` | `string` | Template, Required | The unique identifier of the payment method. |
| `body` | [`UpdatePaymentMethodInfo`](../../doc/models/update-payment-method-info.md) | Body, Optional | - |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.PaymentMethod1](../../doc/models/payment-method-1.md).

## Example Usage

```csharp
string merchantId = "merchantId6";
string paymentMethodId = "paymentMethodId2";
UpdatePaymentMethodInfo body = new UpdatePaymentMethodInfo
{
    Countries = new List<string>
    {
        "NL",
    },
    Currencies = new List<string>
    {
        "EUR",
    },
};

try
{
    ApiResponse<PaymentMethod1> result = await paymentMethodsMerchantLevelApi.UpdatePaymentMethodSettingAsync(
        merchantId,
        paymentMethodId,
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
  "mc": {
    "transactionDescription": {
      "doingBusinessAsName": "YOUR_BUSINESS_NAME",
      "type": "fixed"
    }
  },
  "id": "PM322DZ243226G5LKBTGM7FBQ",
  "type": "mc",
  "enabled": true,
  "countries": [
    "NL"
  ],
  "currencies": [
    "EUR"
  ],
  "customRoutingFlags": []
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad Request - a problem reading or understanding the request. | [`RestServiceErrorException`](../../doc/models/rest-service-error-exception.md) |
| 401 | Unauthorized - authentication required. | [`RestServiceErrorException`](../../doc/models/rest-service-error-exception.md) |
| 403 | Forbidden - insufficient permissions to process the request. | [`RestServiceErrorException`](../../doc/models/rest-service-error-exception.md) |
| 422 | Unprocessable Entity - a request validation error. | [`RestServiceErrorException`](../../doc/models/rest-service-error-exception.md) |
| 429 | - | [`RestServiceErrorException`](../../doc/models/rest-service-error-exception.md) |
| 500 | Internal Server Error - the server could not process the request. | [`RestServiceErrorException`](../../doc/models/rest-service-error-exception.md) |


# Add Apple Pay Domains

Adds the new domain to the list of Apple Pay domains that are registered with the merchant account and the payment method identified in the path. For more information, see [Apple Pay documentation](https://docs.adyen.com/payment-methods/apple-pay/web-drop-in/?tab=adyen-certificate-live_1#going-live).

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):

* Management API—Payment methods read and write

```csharp
AddApplePayDomainsAsync(
    string merchantId,
    string paymentMethodId,
    Models.ApplePayInfo body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `merchantId` | `string` | Template, Required | The unique identifier of the merchant account. |
| `paymentMethodId` | `string` | Template, Required | The unique identifier of the payment method. |
| `body` | [`ApplePayInfo`](../../doc/models/apple-pay-info.md) | Body, Optional | - |

## Response Type

`Task`

## Example Usage

```csharp
string merchantId = "merchantId6";
string paymentMethodId = "paymentMethodId2";
ApplePayInfo body = new ApplePayInfo
{
    Domains = new List<string>
    {
        "https://example.com",
    },
};

try
{
    await paymentMethodsMerchantLevelApi.AddApplePayDomainsAsync(
        merchantId,
        paymentMethodId,
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

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad Request - a problem reading or understanding the request. | [`RestServiceErrorException`](../../doc/models/rest-service-error-exception.md) |
| 401 | Unauthorized - authentication required. | [`RestServiceErrorException`](../../doc/models/rest-service-error-exception.md) |
| 403 | Forbidden - insufficient permissions to process the request. | [`RestServiceErrorException`](../../doc/models/rest-service-error-exception.md) |
| 422 | Unprocessable Entity - a request validation error. | [`RestServiceErrorException`](../../doc/models/rest-service-error-exception.md) |
| 429 | - | [`RestServiceErrorException`](../../doc/models/rest-service-error-exception.md) |
| 500 | Internal Server Error - the server could not process the request. | [`RestServiceErrorException`](../../doc/models/rest-service-error-exception.md) |


# Get Apple Pay Domains

Returns all Apple Pay domains that are registered with the merchant account and the payment method identified in the path. For more information, see [Apple Pay documentation](https://docs.adyen.com/payment-methods/apple-pay/enable-apple-pay#register-merchant-domain).

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):

* Management API—Payment methods read

```csharp
GetApplePayDomainsAsync(
    string merchantId,
    string paymentMethodId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `merchantId` | `string` | Template, Required | The unique identifier of the merchant account. |
| `paymentMethodId` | `string` | Template, Required | The unique identifier of the payment method. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.ApplePayInfo](../../doc/models/apple-pay-info.md).

## Example Usage

```csharp
string merchantId = "merchantId6";
string paymentMethodId = "paymentMethodId2";
try
{
    ApiResponse<ApplePayInfo> result = await paymentMethodsMerchantLevelApi.GetApplePayDomainsAsync(
        merchantId,
        paymentMethodId
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

