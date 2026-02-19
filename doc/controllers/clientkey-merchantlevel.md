# Clientkey-Merchantlevel

```csharp
ClientkeyMerchantlevelApi clientkeyMerchantlevelApi = client.ClientkeyMerchantlevelApi;
```

## Class Name

`ClientkeyMerchantlevelApi`


# Post-Merchants-Merchant Id-Api Credentials-Api Credential Id-Generate Client Key

Returns a new [client key](https://docs.adyen.com/development-resources/client-side-authentication#how-it-works) for the API credential identified in the path. You can use the new client key a few minutes after generating it. The old client key stops working 24 hours after generating a new one.

To make this request, your API credential must have the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):

* Management API—API credentials read and write

```csharp
PostMerchantsMerchantIdApiCredentialsApiCredentialIdGenerateClientKeyAsync(
    string merchantId,
    string apiCredentialId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `merchantId` | `string` | Template, Required | The unique identifier of the merchant account. |
| `apiCredentialId` | `string` | Template, Required | Unique identifier of the API credential. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.GenerateClientKeyResponse](../../doc/models/generate-client-key-response.md).

## Example Usage

```csharp
string merchantId = "merchantId6";
string apiCredentialId = "apiCredentialId8";
try
{
    ApiResponse<GenerateClientKeyResponse> result = await clientKeyMerchantLevelApi.PostMerchantsMerchantIdApiCredentialsApiCredentialIdGenerateClientKeyAsync(
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

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad Request - a problem reading or understanding the request. | [`RestServiceErrorException`](../../doc/models/rest-service-error-exception.md) |
| 401 | Unauthorized - authentication required. | [`RestServiceErrorException`](../../doc/models/rest-service-error-exception.md) |
| 403 | Forbidden - insufficient permissions to process the request. | [`RestServiceErrorException`](../../doc/models/rest-service-error-exception.md) |
| 422 | Unprocessable Entity - a request validation error. | [`RestServiceErrorException`](../../doc/models/rest-service-error-exception.md) |
| 500 | Internal Server Error - the server could not process the request. | [`RestServiceErrorException`](../../doc/models/rest-service-error-exception.md) |

