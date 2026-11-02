# Reference

Every operation below is shown in its throwing form. On an error status it throws `ApiException<TError>` — the status code, headers, content type and the operation's error type, `RawError` (the raw body) when the spec declares none — and where an operation offers an `…AsResult` sibling, that sibling returns `ApiResult<TResponse, TError>` instead. A request that produces no usable response surfaces as `SdkConnectionException` or `SdkTimeoutException`, a body that does not match the documented response type as `ResponseDeserializationException`, and a required credential that is not configured, or one that cannot be applied, as `AuthSchemeException`; all of them derive from `SdkException` and name the failed call. See [README → Error Handling](README.md#error-handling).

> Source: [AdyenApIsClient](src/AdyenApIs/AdyenApIsClient.cs)

## ApiCredentialsCompanyLevel

> Source: [ApiCredentialsCompanyLevel](src/AdyenApIs/Api/ApiCredentialsCompanyLevel.cs)

<details>
<summary><code>Task&lt;CreateCompanyApiCredentialResponse&gt; CreateCompanyApiCredential(CreateCompanyApiCredentialOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates an [API credential](https://docs.adyen.com/development-resources/api-credentials) for the company account identified in the path. In the request, you can specify which merchant accounts the new API credential will have access to, as well as its roles and allowed origins.

The response includes several types of authentication details:
* [API key](https://docs.adyen.com/development-resources/api-authentication#api-key-authentication): used for API request authentication.
* [Client key](https://docs.adyen.com/development-resources/client-side-authentication#how-it-works): public key used for client-side authentication.
* [Username and password](https://docs.adyen.com/development-resources/api-authentication#using-basic-authentication): used for basic authentication.

> Make sure you store the API key securely in your system. You won't be able to retrieve it later.

If your API key is lost or compromised, you need to [generate a new API key](https://docs.adyen.com/api-explorer/#/ManagementService/v1/post/companies/{companyId}/apiCredentials/{apiCredentialId}/generateApiKey).

To make this request, your API credential must have the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—API credentials read and write

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ApiCredentialsCompanyLevel.CreateCompanyApiCredential(
        new CreateCompanyApiCredentialOperationRequest
        {
            CompanyId = "some example string",
            Body = new CreateCompanyApiCredentialRequest
            {
                AllowedOrigins = ["https://www.mystore.com"],
                AssociatedMerchantAccounts = [
                    "YOUR_MERCHANT_ACCOUNT_AU",
                    "YOUR_MERCHANT_ACCOUNT_EU",
                    "YOUR_MERCHANT_ACCOUNT_US",
                ],
                Roles = ["Checkout webservice role"],
            },
        });
    // TODO: Handle 'response' of type CreateCompanyApiCredentialResponse
}
catch (ApiException<CreateCompanyApiCredentialError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CreateCompanyApiCredentialOperationRequest](src/AdyenApIs/Requests/ApiCredentialsCompanyLevel/CreateCompanyApiCredentialOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CreateCompanyApiCredentialResponse](src/AdyenApIs/Models/CreateCompanyApiCredentialResponse.cs)</code>

**OnError**: <code>[ApiException](src/AdyenApIs/Core/Exceptions/ApiException.cs)&lt;[CreateCompanyApiCredentialError](src/AdyenApIs/Errors/CreateCompanyApiCredentialError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CompanyApiCredential&gt; GetCompanyApiCredential(GetCompanyApiCredentialRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the [API credential](https://docs.adyen.com/development-resources/api-credentials) identified in the path.

To make this request, your API credential must have the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—API credentials read and write

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ApiCredentialsCompanyLevel.GetCompanyApiCredential(new GetCompanyApiCredentialRequest
    {
        CompanyId = "some example string",
        ApiCredentialId = "some example string",
    });
    // TODO: Handle 'response' of type CompanyApiCredential
}
catch (ApiException<GetCompanyApiCredentialError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetCompanyApiCredentialRequest](src/AdyenApIs/Requests/ApiCredentialsCompanyLevel/GetCompanyApiCredentialRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CompanyApiCredential](src/AdyenApIs/Models/CompanyApiCredential.cs)</code>

**OnError**: <code>[ApiException](src/AdyenApIs/Core/Exceptions/ApiException.cs)&lt;[GetCompanyApiCredentialError](src/AdyenApIs/Errors/GetCompanyApiCredentialError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ListCompanyApiCredentialsResponse&gt; ListCompanyApiCredentials(ListCompanyApiCredentialsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the list of [API credentials](https://docs.adyen.com/development-resources/api-credentials) for the company account. The list is grouped into pages as defined by the query parameters.

To make this request, your API credential must have the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—API credentials read and write

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ApiCredentialsCompanyLevel.ListCompanyApiCredentials(
        new ListCompanyApiCredentialsRequest { CompanyId = "some example string" });
    // TODO: Handle 'response' of type ListCompanyApiCredentialsResponse
}
catch (ApiException<ListCompanyApiCredentialsError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ListCompanyApiCredentialsRequest](src/AdyenApIs/Requests/ApiCredentialsCompanyLevel/ListCompanyApiCredentialsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ListCompanyApiCredentialsResponse](src/AdyenApIs/Models/ListCompanyApiCredentialsResponse.cs)</code>

**OnError**: <code>[ApiException](src/AdyenApIs/Core/Exceptions/ApiException.cs)&lt;[ListCompanyApiCredentialsError](src/AdyenApIs/Errors/ListCompanyApiCredentialsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CompanyApiCredential&gt; UpdateCompanyApiCredential(UpdateCompanyApiCredentialOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Changes the API credential's roles, merchant account access, or allowed origins. The request has the new values for the fields you want to change. The response contains the full updated API credential, including the new values from the request. 

To make this request, your API credential must have the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—API credentials read and write

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ApiCredentialsCompanyLevel.UpdateCompanyApiCredential(
        new UpdateCompanyApiCredentialOperationRequest
        {
            CompanyId = "some example string",
            ApiCredentialId = "some example string",
            Body = new UpdateCompanyApiCredentialRequest { Active = true },
        });
    // TODO: Handle 'response' of type CompanyApiCredential
}
catch (ApiException<UpdateCompanyApiCredentialError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[UpdateCompanyApiCredentialOperationRequest](src/AdyenApIs/Requests/ApiCredentialsCompanyLevel/UpdateCompanyApiCredentialOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CompanyApiCredential](src/AdyenApIs/Models/CompanyApiCredential.cs)</code>

**OnError**: <code>[ApiException](src/AdyenApIs/Core/Exceptions/ApiException.cs)&lt;[UpdateCompanyApiCredentialError](src/AdyenApIs/Errors/UpdateCompanyApiCredentialError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## ApiCredentialsMerchantLevel

> Source: [ApiCredentialsMerchantLevel](src/AdyenApIs/Api/ApiCredentialsMerchantLevel.cs)

<details>
<summary><code>Task&lt;CreateApiCredentialResponse&gt; CreateMerchantApiCredential(CreateMerchantApiCredentialOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates an [API credential](https://docs.adyen.com/development-resources/api-credentials) for the company account identified in the path. In the request, you can specify the roles and allowed origins for the new API credential.

The response includes the:
* [API key](https://docs.adyen.com/development-resources/api-authentication#api-key-authentication): used for API request authentication.
* [Client key](https://docs.adyen.com/development-resources/client-side-authentication#how-it-works): public key used for client-side authentication.
* [Username and password](https://docs.adyen.com/development-resources/api-authentication#using-basic-authentication): used for basic authentication.

> Make sure you store the API key securely in your system. You won't be able to retrieve it later.

If your API key is lost or compromised, you need to [generate a new API key](https://docs.adyen.com/api-explorer/#/ManagementService/v1/post/merchants/{merchantId}/apiCredentials/{apiCredentialId}/generateApiKey).

To make this request, your API credential must have the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—API credentials read and write

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ApiCredentialsMerchantLevel.CreateMerchantApiCredential(
        new CreateMerchantApiCredentialOperationRequest
        {
            MerchantId = "some example string",
            Body = new CreateMerchantApiCredentialRequest
            {
                AllowedOrigins = ["https://www.mystore.com"],
                Roles = ["Checkout webservice role"],
            },
        });
    // TODO: Handle 'response' of type CreateApiCredentialResponse
}
catch (ApiException<CreateMerchantApiCredentialError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CreateMerchantApiCredentialOperationRequest](src/AdyenApIs/Requests/ApiCredentialsMerchantLevel/CreateMerchantApiCredentialOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CreateApiCredentialResponse](src/AdyenApIs/Models/CreateApiCredentialResponse.cs)</code>

**OnError**: <code>[ApiException](src/AdyenApIs/Core/Exceptions/ApiException.cs)&lt;[CreateMerchantApiCredentialError](src/AdyenApIs/Errors/CreateMerchantApiCredentialError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ApiCredential&gt; GetMerchantApiCredential(GetMerchantApiCredentialRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the [API credential](https://docs.adyen.com/development-resources/api-credentials) identified in the path.

To make this request, your API credential must have the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—API credentials read and write

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ApiCredentialsMerchantLevel.GetMerchantApiCredential(new GetMerchantApiCredentialRequest
    {
        MerchantId = "some example string",
        ApiCredentialId = "some example string",
    });
    // TODO: Handle 'response' of type ApiCredential
}
catch (ApiException<GetMerchantApiCredentialError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetMerchantApiCredentialRequest](src/AdyenApIs/Requests/ApiCredentialsMerchantLevel/GetMerchantApiCredentialRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ApiCredential](src/AdyenApIs/Models/ApiCredential.cs)</code>

**OnError**: <code>[ApiException](src/AdyenApIs/Core/Exceptions/ApiException.cs)&lt;[GetMerchantApiCredentialError](src/AdyenApIs/Errors/GetMerchantApiCredentialError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ListMerchantApiCredentialsResponse&gt; ListMerchantApiCredentials(ListMerchantApiCredentialsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the list of [API credentials](https://docs.adyen.com/development-resources/api-credentials) for the merchant account. The list is grouped into pages as defined by the query parameters.

To make this request, your API credential must have the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—API credentials read and write

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ApiCredentialsMerchantLevel.ListMerchantApiCredentials(
        new ListMerchantApiCredentialsRequest { MerchantId = "some example string" });
    // TODO: Handle 'response' of type ListMerchantApiCredentialsResponse
}
catch (ApiException<ListMerchantApiCredentialsError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ListMerchantApiCredentialsRequest](src/AdyenApIs/Requests/ApiCredentialsMerchantLevel/ListMerchantApiCredentialsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ListMerchantApiCredentialsResponse](src/AdyenApIs/Models/ListMerchantApiCredentialsResponse.cs)</code>

**OnError**: <code>[ApiException](src/AdyenApIs/Core/Exceptions/ApiException.cs)&lt;[ListMerchantApiCredentialsError](src/AdyenApIs/Errors/ListMerchantApiCredentialsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ApiCredential&gt; UpdateMerchantApiCredential(UpdateMerchantApiCredentialOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Changes the API credential's roles, or allowed origins. The request has the new values for the fields you want to change. The response contains the full updated API credential, including the new values from the request. 

To make this request, your API credential must have the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—API credentials read and write

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ApiCredentialsMerchantLevel.UpdateMerchantApiCredential(
        new UpdateMerchantApiCredentialOperationRequest
        {
            MerchantId = "some example string",
            ApiCredentialId = "some example string",
            Body = new UpdateMerchantApiCredentialRequest { Active = true },
        });
    // TODO: Handle 'response' of type ApiCredential
}
catch (ApiException<UpdateMerchantApiCredentialError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[UpdateMerchantApiCredentialOperationRequest](src/AdyenApIs/Requests/ApiCredentialsMerchantLevel/UpdateMerchantApiCredentialOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ApiCredential](src/AdyenApIs/Models/ApiCredential.cs)</code>

**OnError**: <code>[ApiException](src/AdyenApIs/Core/Exceptions/ApiException.cs)&lt;[UpdateMerchantApiCredentialError](src/AdyenApIs/Errors/UpdateMerchantApiCredentialError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## ApiKeyCompanyLevel

> Source: [ApiKeyCompanyLevel](src/AdyenApIs/Api/ApiKeyCompanyLevel.cs)

<details>
<summary><code>Task&lt;GenerateApiKeyResponse&gt; GenerateCompanyApiKey(GenerateCompanyApiKeyRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a new API key for the API credential. You can use the new API key a few minutes after generating it. The old API key stops working 24 hours after generating a new one.

To make this request, your API credential must have the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—API credentials read and write

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ApiKeyCompanyLevel.GenerateCompanyApiKey(new GenerateCompanyApiKeyRequest
    {
        CompanyId = "some example string",
        ApiCredentialId = "some example string",
    });
    // TODO: Handle 'response' of type GenerateApiKeyResponse
}
catch (ApiException<GenerateCompanyApiKeyError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GenerateCompanyApiKeyRequest](src/AdyenApIs/Requests/ApiKeyCompanyLevel/GenerateCompanyApiKeyRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GenerateApiKeyResponse](src/AdyenApIs/Models/GenerateApiKeyResponse.cs)</code>

**OnError**: <code>[ApiException](src/AdyenApIs/Core/Exceptions/ApiException.cs)&lt;[GenerateCompanyApiKeyError](src/AdyenApIs/Errors/GenerateCompanyApiKeyError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## ApiKeyMerchantLevel

> Source: [ApiKeyMerchantLevel](src/AdyenApIs/Api/ApiKeyMerchantLevel.cs)

<details>
<summary><code>Task&lt;GenerateApiKeyResponse&gt; GenerateMerchantApiKey(GenerateMerchantApiKeyRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a new API key for the API credential. You can use the new API key a few minutes after generating it. The old API key stops working 24 hours after generating a new one.

To make this request, your API credential must have the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—API credentials read and write

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ApiKeyMerchantLevel.GenerateMerchantApiKey(new GenerateMerchantApiKeyRequest
    {
        MerchantId = "TestMerchant",
        ApiCredentialId = "CRED_001",
    });
    // TODO: Handle 'response' of type GenerateApiKeyResponse
}
catch (ApiException<GenerateMerchantApiKeyError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GenerateMerchantApiKeyRequest](src/AdyenApIs/Requests/ApiKeyMerchantLevel/GenerateMerchantApiKeyRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GenerateApiKeyResponse](src/AdyenApIs/Models/GenerateApiKeyResponse.cs)</code>

**OnError**: <code>[ApiException](src/AdyenApIs/Core/Exceptions/ApiException.cs)&lt;[GenerateMerchantApiKeyError](src/AdyenApIs/Errors/GenerateMerchantApiKeyError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## AccountCompanyLevel

> Source: [AccountCompanyLevel](src/AdyenApIs/Api/AccountCompanyLevel.cs)

<details>
<summary><code>Task&lt;CompanyManagementApi&gt; GetCompany(GetCompanyRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the company account specified in the path. Your API credential must have access to the company account. 

To make this request, your API credential must have the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Account read

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AccountCompanyLevel.GetCompany(new GetCompanyRequest
    {
        CompanyId = "some example string",
    });
    // TODO: Handle 'response' of type CompanyManagementApi
}
catch (ApiException<GetCompanyError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetCompanyRequest](src/AdyenApIs/Requests/AccountCompanyLevel/GetCompanyRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CompanyManagementApi](src/AdyenApIs/Models/CompanyManagementApi.cs)</code>

**OnError**: <code>[ApiException](src/AdyenApIs/Core/Exceptions/ApiException.cs)&lt;[GetCompanyError](src/AdyenApIs/Errors/GetCompanyError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ListCompanyResponse&gt; ListCompanies(ListCompaniesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the list of company accounts that your API credential has access to. The list is grouped into pages as defined by the query parameters.

To make this request, your API credential must have the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):

* Management API—Account read

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AccountCompanyLevel.ListCompanies(new ListCompaniesRequest());
    // TODO: Handle 'response' of type ListCompanyResponse
}
catch (ApiException<ListCompaniesError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ListCompaniesRequest](src/AdyenApIs/Requests/AccountCompanyLevel/ListCompaniesRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ListCompanyResponse](src/AdyenApIs/Models/ListCompanyResponse.cs)</code>

**OnError**: <code>[ApiException](src/AdyenApIs/Core/Exceptions/ApiException.cs)&lt;[ListCompaniesError](src/AdyenApIs/Errors/ListCompaniesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ListMerchantResponse&gt; ListCompanyMerchants(ListCompanyMerchantsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the list of merchant accounts under the company account specified in the path. The list only includes merchant accounts that your API credential has access to. The list is grouped into pages as defined by the query parameters. 

To make this request, your API credential must have the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Account read

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AccountCompanyLevel.ListCompanyMerchants(new ListCompanyMerchantsRequest
    {
        CompanyId = "some example string",
    });
    // TODO: Handle 'response' of type ListMerchantResponse
}
catch (ApiException<ListCompanyMerchantsError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ListCompanyMerchantsRequest](src/AdyenApIs/Requests/AccountCompanyLevel/ListCompanyMerchantsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ListMerchantResponse](src/AdyenApIs/Models/ListMerchantResponse.cs)</code>

**OnError**: <code>[ApiException](src/AdyenApIs/Core/Exceptions/ApiException.cs)&lt;[ListCompanyMerchantsError](src/AdyenApIs/Errors/ListCompanyMerchantsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## AccountMerchantLevel

> Source: [AccountMerchantLevel](src/AdyenApIs/Api/AccountMerchantLevel.cs)

<details>
<summary><code>Task&lt;RequestActivationResponse&gt; ActivateMerchant(ActivateMerchantRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Sends a request to activate the merchant account identified in the path.

You get the result of the activation asynchronously through a [`merchant.updated`](https://docs.adyen.com/api-explorer/ManagementNotification/latest/post/merchant.updated) webhook. Once the merchant account is activated, you can start using it to accept payments and payouts.

Use this endpoint if your integration requires it, such as Adyen for Platforms Manage. Your Adyen contact will set up your access.

To make this request, your API credential must have the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Accounts read and write

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AccountMerchantLevel.ActivateMerchant(new ActivateMerchantRequest
    {
        MerchantId = "some example string",
    });
    // TODO: Handle 'response' of type RequestActivationResponse
}
catch (ApiException<ActivateMerchantError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ActivateMerchantRequest](src/AdyenApIs/Requests/AccountMerchantLevel/ActivateMerchantRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RequestActivationResponse](src/AdyenApIs/Models/RequestActivationResponse.cs)</code>

**OnError**: <code>[ApiException](src/AdyenApIs/Core/Exceptions/ApiException.cs)&lt;[ActivateMerchantError](src/AdyenApIs/Errors/ActivateMerchantError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CreateMerchantResponse&gt; CreateMerchant(CreateMerchantOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates a merchant account for the company account specified in the request.

Use this endpoint if your integration requires it, such as Adyen for Platforms Manage. Your Adyen contact will set up your access.

To make this request, your API credential must have the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Accounts read and write

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AccountMerchantLevel.CreateMerchant(new CreateMerchantOperationRequest
    {
        Body = new CreateMerchantRequest
        {
            BusinessLineId = "YOUR_BUSINESS_LINE_ID",
            CompanyId = "YOUR_COMPANY_ACCOUNT",
            Description = "YOUR_DESCRIPTION",
            LegalEntityId = "YOUR_LEGAL_ENTITY_ID",
            Reference = "YOUR_OWN_REFERENCE",
        },
    });
    // TODO: Handle 'response' of type CreateMerchantResponse
}
catch (ApiException<CreateMerchantError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CreateMerchantOperationRequest](src/AdyenApIs/Requests/AccountMerchantLevel/CreateMerchantOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CreateMerchantResponse](src/AdyenApIs/Models/CreateMerchantResponse.cs)</code>

**OnError**: <code>[ApiException](src/AdyenApIs/Core/Exceptions/ApiException.cs)&lt;[CreateMerchantError](src/AdyenApIs/Errors/CreateMerchantError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Merchant&gt; GetMerchant(GetMerchantRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the merchant account specified in the path. Your API credential must have access to the merchant account.

To make this request, your API credential must have the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Account read

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AccountMerchantLevel.GetMerchant(new GetMerchantRequest
    {
        MerchantId = "some example string",
    });
    // TODO: Handle 'response' of type Merchant
}
catch (ApiException<GetMerchantError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetMerchantRequest](src/AdyenApIs/Requests/AccountMerchantLevel/GetMerchantRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Merchant](src/AdyenApIs/Models/Merchant.cs)</code>

**OnError**: <code>[ApiException](src/AdyenApIs/Core/Exceptions/ApiException.cs)&lt;[GetMerchantError](src/AdyenApIs/Errors/GetMerchantError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ListMerchantResponse&gt; ListMerchants(ListMerchantsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the list of merchant accounts that your API credential has access to. The list is grouped into pages as defined by the query parameters. 

To make this request, your API credential must have the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Account read

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AccountMerchantLevel.ListMerchants(new ListMerchantsRequest());
    // TODO: Handle 'response' of type ListMerchantResponse
}
catch (ApiException<ListMerchantsError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ListMerchantsRequest](src/AdyenApIs/Requests/AccountMerchantLevel/ListMerchantsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ListMerchantResponse](src/AdyenApIs/Models/ListMerchantResponse.cs)</code>

**OnError**: <code>[ApiException](src/AdyenApIs/Core/Exceptions/ApiException.cs)&lt;[ListMerchantsError](src/AdyenApIs/Errors/ListMerchantsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## AccountStoreLevel

> Source: [AccountStoreLevel](src/AdyenApIs/Api/AccountStoreLevel.cs)

<details>
<summary><code>Task&lt;Store&gt; CreateMerchantStore(CreateMerchantStoreRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates a store for the merchant account identified in the path.

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Stores read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AccountStoreLevel.CreateMerchantStore(new CreateMerchantStoreRequest
    {
        MerchantId = "some example string",
        Body = new StoreCreationRequest
        {
            Address = new StoreLocationStoreCreationRequest
            {
                City = "Springfield",
                Country = "US",
                Line1 = "200 Main Street",
                Line2 = "Building 5A",
                Line3 = "Suite 3",
                PostalCode = "20250",
                StateOrProvince = "NY",
            },
            Description = "City centre store",
            PhoneNumber = "13123456789",
            Reference = "Spring_store_2",
            ShopperStatement = "Springfield Shop",
        },
    });
    // TODO: Handle 'response' of type Store
}
catch (ApiException<CreateMerchantStoreError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CreateMerchantStoreRequest](src/AdyenApIs/Requests/AccountStoreLevel/CreateMerchantStoreRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Store](src/AdyenApIs/Models/Store.cs)</code>

**OnError**: <code>[ApiException](src/AdyenApIs/Core/Exceptions/ApiException.cs)&lt;[CreateMerchantStoreError](src/AdyenApIs/Errors/CreateMerchantStoreError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Store&gt; CreateStore(CreateStoreRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates a store for the merchant account specified in the request.

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Stores read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AccountStoreLevel.CreateStore(new CreateStoreRequest
    {
        Body = new StoreCreationWithMerchantCodeRequest
        {
            Address = new StoreLocationStoreCreationWithMerchantCodeRequest
            {
                City = "Springfield",
                Country = "US",
                Line1 = "200 Main Street",
                Line2 = "Building 5A",
                Line3 = "Suite 3",
                PostalCode = "20250",
                StateOrProvince = "NY",
            },
            Description = "City centre store",
            MerchantId = "YOUR_MERCHANT_ACCOUNT_ID",
            PhoneNumber = "+13123456789",
            Reference = "Spring_store_2",
            ShopperStatement = "Springfield Shop",
        },
    });
    // TODO: Handle 'response' of type Store
}
catch (ApiException<CreateStoreError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CreateStoreRequest](src/AdyenApIs/Requests/AccountStoreLevel/CreateStoreRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Store](src/AdyenApIs/Models/Store.cs)</code>

**OnError**: <code>[ApiException](src/AdyenApIs/Core/Exceptions/ApiException.cs)&lt;[CreateStoreError](src/AdyenApIs/Errors/CreateStoreError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Store&gt; GetMerchantStore(GetMerchantStoreRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the details of the store identified in the path.

To make this request, your API credential must have one of the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Stores read
* Management API—Stores read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AccountStoreLevel.GetMerchantStore(new GetMerchantStoreRequest
    {
        MerchantId = "some example string",
        StoreId = "some example string",
    });
    // TODO: Handle 'response' of type Store
}
catch (ApiException<GetMerchantStoreError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetMerchantStoreRequest](src/AdyenApIs/Requests/AccountStoreLevel/GetMerchantStoreRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Store](src/AdyenApIs/Models/Store.cs)</code>

**OnError**: <code>[ApiException](src/AdyenApIs/Core/Exceptions/ApiException.cs)&lt;[GetMerchantStoreError](src/AdyenApIs/Errors/GetMerchantStoreError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Store&gt; GetStore(GetStoreRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the details of the store identified in the path.

To make this request, your API credential must have one of the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Stores read
* Management API—Stores read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AccountStoreLevel.GetStore(new GetStoreRequest { StoreId = "some example string" });
    // TODO: Handle 'response' of type Store
}
catch (ApiException<GetStoreError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetStoreRequest](src/AdyenApIs/Requests/AccountStoreLevel/GetStoreRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Store](src/AdyenApIs/Models/Store.cs)</code>

**OnError**: <code>[ApiException](src/AdyenApIs/Core/Exceptions/ApiException.cs)&lt;[GetStoreError](src/AdyenApIs/Errors/GetStoreError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ListStoresResponse&gt; ListMerchantStores(ListMerchantStoresRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a list of stores for the merchant account identified in the path. The list is grouped into pages as defined by the query parameters.

To make this request, your API credential must have one of the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Stores read
* Management API—Stores read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AccountStoreLevel.ListMerchantStores(new ListMerchantStoresRequest
    {
        MerchantId = "some example string",
    });
    // TODO: Handle 'response' of type ListStoresResponse
}
catch (ApiException<ListMerchantStoresError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ListMerchantStoresRequest](src/AdyenApIs/Requests/AccountStoreLevel/ListMerchantStoresRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ListStoresResponse](src/AdyenApIs/Models/ListStoresResponse.cs)</code>

**OnError**: <code>[ApiException](src/AdyenApIs/Core/Exceptions/ApiException.cs)&lt;[ListMerchantStoresError](src/AdyenApIs/Errors/ListMerchantStoresError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ListStoresResponse&gt; ListStores(ListStoresRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a list of stores. The list is grouped into pages as defined by the query parameters.

To make this request, your API credential must have one of the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Stores read
* Management API—Stores read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AccountStoreLevel.ListStores(new ListStoresRequest());
    // TODO: Handle 'response' of type ListStoresResponse
}
catch (ApiException<ListStoresError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ListStoresRequest](src/AdyenApIs/Requests/AccountStoreLevel/ListStoresRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ListStoresResponse](src/AdyenApIs/Models/ListStoresResponse.cs)</code>

**OnError**: <code>[ApiException](src/AdyenApIs/Core/Exceptions/ApiException.cs)&lt;[ListStoresError](src/AdyenApIs/Errors/ListStoresError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Store&gt; UpdateMerchantStore(UpdateMerchantStoreRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates the store identified in the path. You can only update some store parameters.

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Stores read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AccountStoreLevel.UpdateMerchantStore(new UpdateMerchantStoreRequest
    {
        MerchantId = "some example string",
        StoreId = "some example string",
        Body = new UpdateStoreRequest
        {
            Address = new UpdatableAddressUpdateStoreRequest
            {
                Line1 = "1776 West Pinewood Avenue",
                Line2 = "Heartland Building",
                Line3 = "",
                PostalCode = "20251",
            },
        },
    });
    // TODO: Handle 'response' of type Store
}
catch (ApiException<UpdateMerchantStoreError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[UpdateMerchantStoreRequest](src/AdyenApIs/Requests/AccountStoreLevel/UpdateMerchantStoreRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Store](src/AdyenApIs/Models/Store.cs)</code>

**OnError**: <code>[ApiException](src/AdyenApIs/Core/Exceptions/ApiException.cs)&lt;[UpdateMerchantStoreError](src/AdyenApIs/Errors/UpdateMerchantStoreError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Store&gt; UpdateStore(UpdateStoreOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates the store identified in the path.
You can only update some store parameters.

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Stores read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AccountStoreLevel.UpdateStore(new UpdateStoreOperationRequest
    {
        StoreId = "some example string",
        Body = new UpdateStoreRequest
        {
            Address = new UpdatableAddressUpdateStoreRequest
            {
                Line1 = "1776 West Pinewood Avenue",
                Line2 = "Heartland Building",
                Line3 = "",
                PostalCode = "20251",
            },
        },
    });
    // TODO: Handle 'response' of type Store
}
catch (ApiException<UpdateStoreError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[UpdateStoreOperationRequest](src/AdyenApIs/Requests/AccountStoreLevel/UpdateStoreOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Store](src/AdyenApIs/Models/Store.cs)</code>

**OnError**: <code>[ApiException](src/AdyenApIs/Core/Exceptions/ApiException.cs)&lt;[UpdateStoreError](src/AdyenApIs/Errors/UpdateStoreError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## AllowedOriginsCompanyLevel

> Source: [AllowedOriginsCompanyLevel](src/AdyenApIs/Api/AllowedOriginsCompanyLevel.cs)

<details>
<summary><code>Task&lt;AllowedOrigin&gt; CreateCompanyApiCredentialOrigin(CreateCompanyApiCredentialOriginRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Adds a new [allowed origin](https://docs.adyen.com/development-resources/client-side-authentication#allowed-origins) to the API credential's list of allowed origins.

To make this request, your API credential must have the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—API credentials read and write

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AllowedOriginsCompanyLevel.CreateCompanyApiCredentialOrigin(
        new CreateCompanyApiCredentialOriginRequest
        {
            CompanyId = "some example string",
            ApiCredentialId = "some example string",
            Body = new AllowedOrigin { Domain = "https://www.eu.mystore.com" },
        });
    // TODO: Handle 'response' of type AllowedOrigin
}
catch (ApiException<CreateCompanyApiCredentialOriginError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CreateCompanyApiCredentialOriginRequest](src/AdyenApIs/Requests/AllowedOriginsCompanyLevel/CreateCompanyApiCredentialOriginRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AllowedOrigin](src/AdyenApIs/Models/AllowedOrigin.cs)</code>

**OnError**: <code>[ApiException](src/AdyenApIs/Core/Exceptions/ApiException.cs)&lt;[CreateCompanyApiCredentialOriginError](src/AdyenApIs/Errors/CreateCompanyApiCredentialOriginError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task DeleteCompanyApiCredentialOrigin(DeleteCompanyApiCredentialOriginRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Removes the [allowed origin](https://docs.adyen.com/development-resources/client-side-authentication#allowed-origins) identified in the path. As soon as an allowed origin is removed, we no longer accept client-side requests from that domain.

To make this request, your API credential must have the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—API credentials read and write

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.AllowedOriginsCompanyLevel.DeleteCompanyApiCredentialOrigin(new DeleteCompanyApiCredentialOriginRequest
    {
        CompanyId = "some example string",
        ApiCredentialId = "some example string",
        OriginId = "some example string",
    });
}
catch (ApiException<DeleteCompanyApiCredentialOriginError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DeleteCompanyApiCredentialOriginRequest](src/AdyenApIs/Requests/AllowedOriginsCompanyLevel/DeleteCompanyApiCredentialOriginRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[ApiException](src/AdyenApIs/Core/Exceptions/ApiException.cs)&lt;[DeleteCompanyApiCredentialOriginError](src/AdyenApIs/Errors/DeleteCompanyApiCredentialOriginError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AllowedOrigin&gt; GetCompanyApiCredentialOrigin(GetCompanyApiCredentialOriginRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the [allowed origin](https://docs.adyen.com/development-resources/client-side-authentication#allowed-origins) identified in the path.

To make this request, your API credential must have the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—API credentials read and write

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AllowedOriginsCompanyLevel.GetCompanyApiCredentialOrigin(
        new GetCompanyApiCredentialOriginRequest
        {
            CompanyId = "some example string",
            ApiCredentialId = "some example string",
            OriginId = "some example string",
        });
    // TODO: Handle 'response' of type AllowedOrigin
}
catch (ApiException<GetCompanyApiCredentialOriginError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetCompanyApiCredentialOriginRequest](src/AdyenApIs/Requests/AllowedOriginsCompanyLevel/GetCompanyApiCredentialOriginRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AllowedOrigin](src/AdyenApIs/Models/AllowedOrigin.cs)</code>

**OnError**: <code>[ApiException](src/AdyenApIs/Core/Exceptions/ApiException.cs)&lt;[GetCompanyApiCredentialOriginError](src/AdyenApIs/Errors/GetCompanyApiCredentialOriginError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AllowedOriginsResponse&gt; ListCompanyApiCredentialOrigins(ListCompanyApiCredentialOriginsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the list of [allowed origins](https://docs.adyen.com/development-resources/client-side-authentication#allowed-origins) for the API credential identified in the path.

To make this request, your API credential must have the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—API credentials read and write

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AllowedOriginsCompanyLevel.ListCompanyApiCredentialOrigins(
        new ListCompanyApiCredentialOriginsRequest
        {
            CompanyId = "some example string",
            ApiCredentialId = "some example string",
        });
    // TODO: Handle 'response' of type AllowedOriginsResponse
}
catch (ApiException<ListCompanyApiCredentialOriginsError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ListCompanyApiCredentialOriginsRequest](src/AdyenApIs/Requests/AllowedOriginsCompanyLevel/ListCompanyApiCredentialOriginsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AllowedOriginsResponse](src/AdyenApIs/Models/AllowedOriginsResponse.cs)</code>

**OnError**: <code>[ApiException](src/AdyenApIs/Core/Exceptions/ApiException.cs)&lt;[ListCompanyApiCredentialOriginsError](src/AdyenApIs/Errors/ListCompanyApiCredentialOriginsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## AllowedOriginsMerchantLevel

> Source: [AllowedOriginsMerchantLevel](src/AdyenApIs/Api/AllowedOriginsMerchantLevel.cs)

<details>
<summary><code>Task&lt;AllowedOrigin&gt; CreateMerchantApiCredentialOrigin(CreateMerchantApiCredentialOriginRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Adds a new [allowed origin](https://docs.adyen.com/development-resources/client-side-authentication#allowed-origins) to the API credential's list of allowed origins.

To make this request, your API credential must have the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—API credentials read and write

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AllowedOriginsMerchantLevel.CreateMerchantApiCredentialOrigin(
        new CreateMerchantApiCredentialOriginRequest
        {
            MerchantId = "some example string",
            ApiCredentialId = "some example string",
            Body = new AllowedOrigin { Domain = "https://www.eu.mystore.com" },
        });
    // TODO: Handle 'response' of type AllowedOrigin
}
catch (ApiException<CreateMerchantApiCredentialOriginError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CreateMerchantApiCredentialOriginRequest](src/AdyenApIs/Requests/AllowedOriginsMerchantLevel/CreateMerchantApiCredentialOriginRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AllowedOrigin](src/AdyenApIs/Models/AllowedOrigin.cs)</code>

**OnError**: <code>[ApiException](src/AdyenApIs/Core/Exceptions/ApiException.cs)&lt;[CreateMerchantApiCredentialOriginError](src/AdyenApIs/Errors/CreateMerchantApiCredentialOriginError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task DeleteMerchantApiCredentialOrigin(DeleteMerchantApiCredentialOriginRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Removes the [allowed origin](https://docs.adyen.com/development-resources/client-side-authentication#allowed-origins) identified in the path. As soon as an allowed origin is removed, we no longer accept client-side requests from that domain.

To make this request, your API credential must have the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—API credentials read and write

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.AllowedOriginsMerchantLevel.DeleteMerchantApiCredentialOrigin(
        new DeleteMerchantApiCredentialOriginRequest
        {
            MerchantId = "some example string",
            ApiCredentialId = "some example string",
            OriginId = "some example string",
        });
}
catch (ApiException<DeleteMerchantApiCredentialOriginError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DeleteMerchantApiCredentialOriginRequest](src/AdyenApIs/Requests/AllowedOriginsMerchantLevel/DeleteMerchantApiCredentialOriginRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[ApiException](src/AdyenApIs/Core/Exceptions/ApiException.cs)&lt;[DeleteMerchantApiCredentialOriginError](src/AdyenApIs/Errors/DeleteMerchantApiCredentialOriginError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AllowedOrigin&gt; GetMerchantApiCredentialOrigin(GetMerchantApiCredentialOriginRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the [allowed origin](https://docs.adyen.com/development-resources/client-side-authentication#allowed-origins) identified in the path.

To make this request, your API credential must have the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—API credentials read and write

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AllowedOriginsMerchantLevel.GetMerchantApiCredentialOrigin(
        new GetMerchantApiCredentialOriginRequest
        {
            MerchantId = "some example string",
            ApiCredentialId = "some example string",
            OriginId = "some example string",
        });
    // TODO: Handle 'response' of type AllowedOrigin
}
catch (ApiException<GetMerchantApiCredentialOriginError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetMerchantApiCredentialOriginRequest](src/AdyenApIs/Requests/AllowedOriginsMerchantLevel/GetMerchantApiCredentialOriginRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AllowedOrigin](src/AdyenApIs/Models/AllowedOrigin.cs)</code>

**OnError**: <code>[ApiException](src/AdyenApIs/Core/Exceptions/ApiException.cs)&lt;[GetMerchantApiCredentialOriginError](src/AdyenApIs/Errors/GetMerchantApiCredentialOriginError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AllowedOriginsResponse&gt; ListMerchantApiCredentialOrigins(ListMerchantApiCredentialOriginsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the list of [allowed origins](https://docs.adyen.com/development-resources/client-side-authentication#allowed-origins) for the API credential identified in the path.

To make this request, your API credential must have the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—API credentials read and write

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AllowedOriginsMerchantLevel.ListMerchantApiCredentialOrigins(
        new ListMerchantApiCredentialOriginsRequest
        {
            MerchantId = "some example string",
            ApiCredentialId = "some example string",
        });
    // TODO: Handle 'response' of type AllowedOriginsResponse
}
catch (ApiException<ListMerchantApiCredentialOriginsError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ListMerchantApiCredentialOriginsRequest](src/AdyenApIs/Requests/AllowedOriginsMerchantLevel/ListMerchantApiCredentialOriginsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AllowedOriginsResponse](src/AdyenApIs/Models/AllowedOriginsResponse.cs)</code>

**OnError**: <code>[ApiException](src/AdyenApIs/Core/Exceptions/ApiException.cs)&lt;[ListMerchantApiCredentialOriginsError](src/AdyenApIs/Errors/ListMerchantApiCredentialOriginsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## AndroidFilesCompanyLevel

> Source: [AndroidFilesCompanyLevel](src/AdyenApIs/Api/AndroidFilesCompanyLevel.cs)

<details>
<summary><code>Task&lt;UploadAndroidAppResponse&gt; CreateAndroidApp(CreateAndroidAppRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Uploads an Android APK file to Adyen.
The maximum APK file size is 200 MB.
To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Android files read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).
>By choosing to upload, install, or run any third-party applications on an Adyen payment terminal, you accept full responsibility and liability for any consequences of uploading, installing, or running any such applications.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AndroidFilesCompanyLevel.CreateAndroidApp(new CreateAndroidAppRequest
    {
        CompanyId = "some example string",
    });
    // TODO: Handle 'response' of type UploadAndroidAppResponse
}
catch (ApiException<CreateAndroidAppError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CreateAndroidAppRequest](src/AdyenApIs/Requests/AndroidFilesCompanyLevel/CreateAndroidAppRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UploadAndroidAppResponse](src/AdyenApIs/Models/UploadAndroidAppResponse.cs)</code>

**OnError**: <code>[ApiException](src/AdyenApIs/Core/Exceptions/ApiException.cs)&lt;[CreateAndroidAppError](src/AdyenApIs/Errors/CreateAndroidAppError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AndroidApp&gt; GetAndroidApp(GetAndroidAppRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the details of the Android app identified in the path. 
These apps have been uploaded to Adyen and can be installed or uninstalled on Android payment terminals through [terminal actions](https://docs.adyen.com/point-of-sale/automating-terminal-management/terminal-actions-api).

To make this request, your API credential must have one of the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Android files read
* Management API—Android files read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AndroidFilesCompanyLevel.GetAndroidApp(new GetAndroidAppRequest
    {
        CompanyId = "some example string",
        Id = "some example string",
    });
    // TODO: Handle 'response' of type AndroidApp
}
catch (ApiException<GetAndroidAppError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetAndroidAppRequest](src/AdyenApIs/Requests/AndroidFilesCompanyLevel/GetAndroidAppRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AndroidApp](src/AdyenApIs/Models/AndroidApp.cs)</code>

**OnError**: <code>[ApiException](src/AdyenApIs/Core/Exceptions/ApiException.cs)&lt;[GetAndroidAppError](src/AdyenApIs/Errors/GetAndroidAppError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AndroidAppsResponse&gt; ListAndroidApps(ListAndroidAppsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a list of the Android apps that are available for the company identified in the path. 
These apps have been uploaded to Adyen and can be installed or uninstalled on Android payment terminals through [terminal actions](https://docs.adyen.com/point-of-sale/automating-terminal-management/terminal-actions-api).

To make this request, your API credential must have one of the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Android files read
* Management API—Android files read and write
* Management API—Terminal actions read
* Management API—Terminal actions read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AndroidFilesCompanyLevel.ListAndroidApps(new ListAndroidAppsRequest
    {
        CompanyId = "some example string",
    });
    // TODO: Handle 'response' of type AndroidAppsResponse
}
catch (ApiException<ListAndroidAppsError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ListAndroidAppsRequest](src/AdyenApIs/Requests/AndroidFilesCompanyLevel/ListAndroidAppsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AndroidAppsResponse](src/AdyenApIs/Models/AndroidAppsResponse.cs)</code>

**OnError**: <code>[ApiException](src/AdyenApIs/Core/Exceptions/ApiException.cs)&lt;[ListAndroidAppsError](src/AdyenApIs/Errors/ListAndroidAppsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AndroidCertificatesResponse&gt; ListAndroidCertificates(ListAndroidCertificatesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a list of the Android certificates that are available for the company identified in the path.
Typically, these certificates enable running apps on Android payment terminals. The certificates in the list have been uploaded to Adyen and can be installed or uninstalled on Android terminals through [terminal actions](https://docs.adyen.com/point-of-sale/automating-terminal-management/terminal-actions-api).

To make this request, your API credential must have one of the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Android files read
* Management API—Android files read and write
* Management API—Terminal actions read
* Management API—Terminal actions read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AndroidFilesCompanyLevel.ListAndroidCertificates(new ListAndroidCertificatesRequest
    {
        CompanyId = "some example string",
    });
    // TODO: Handle 'response' of type AndroidCertificatesResponse
}
catch (ApiException<ListAndroidCertificatesError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ListAndroidCertificatesRequest](src/AdyenApIs/Requests/AndroidFilesCompanyLevel/ListAndroidCertificatesRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AndroidCertificatesResponse](src/AdyenApIs/Models/AndroidCertificatesResponse.cs)</code>

**OnError**: <code>[ApiException](src/AdyenApIs/Core/Exceptions/ApiException.cs)&lt;[ListAndroidCertificatesError](src/AdyenApIs/Errors/ListAndroidCertificatesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ReprocessAndroidAppResponse&gt; UpdateAndroidApp(UpdateAndroidAppRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Reuploads the Android app identified in the path. 
To make this request, your API credential must have this [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Android files read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).
>By choosing to upload, install, or run any third-party applications on an Adyen payment terminal, you accept full responsibility and liability for any consequences of uploading, installing, or running any such applications.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AndroidFilesCompanyLevel.UpdateAndroidApp(new UpdateAndroidAppRequest
    {
        CompanyId = "some example string",
        Id = "some example string",
    });
    // TODO: Handle 'response' of type ReprocessAndroidAppResponse
}
catch (ApiException<UpdateAndroidAppError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[UpdateAndroidAppRequest](src/AdyenApIs/Requests/AndroidFilesCompanyLevel/UpdateAndroidAppRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ReprocessAndroidAppResponse](src/AdyenApIs/Models/ReprocessAndroidAppResponse.cs)</code>

**OnError**: <code>[ApiException](src/AdyenApIs/Core/Exceptions/ApiException.cs)&lt;[UpdateAndroidAppError](src/AdyenApIs/Errors/UpdateAndroidAppError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UploadAndroidCertificateResponse&gt; UploadAndroidCertificate(UploadAndroidCertificateRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Uploads an Android Certificate file to Adyen.

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AndroidFilesCompanyLevel.UploadAndroidCertificate(new UploadAndroidCertificateRequest
    {
        CompanyId = "some example string",
    });
    // TODO: Handle 'response' of type UploadAndroidCertificateResponse
}
catch (ApiException<UploadAndroidCertificateError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[UploadAndroidCertificateRequest](src/AdyenApIs/Requests/AndroidFilesCompanyLevel/UploadAndroidCertificateRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UploadAndroidCertificateResponse](src/AdyenApIs/Models/UploadAndroidCertificateResponse.cs)</code>

**OnError**: <code>[ApiException](src/AdyenApIs/Core/Exceptions/ApiException.cs)&lt;[UploadAndroidCertificateError](src/AdyenApIs/Errors/UploadAndroidCertificateError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## ClientKeyCompanyLevel

> Source: [ClientKeyCompanyLevel](src/AdyenApIs/Api/ClientKeyCompanyLevel.cs)

<details>
<summary><code>Task&lt;GenerateClientKeyResponse&gt; GenerateCompanyClientKey(GenerateCompanyClientKeyRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a new [client key](https://docs.adyen.com/development-resources/client-side-authentication#how-it-works) for the API credential identified in the path. You can use the new client key a few minutes after generating it. The old client key stops working 24 hours after generating a new one.

To make this request, your API credential must have the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—API credentials read and write

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ClientKeyCompanyLevel.GenerateCompanyClientKey(new GenerateCompanyClientKeyRequest
    {
        CompanyId = "some example string",
        ApiCredentialId = "some example string",
    });
    // TODO: Handle 'response' of type GenerateClientKeyResponse
}
catch (ApiException<GenerateCompanyClientKeyError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GenerateCompanyClientKeyRequest](src/AdyenApIs/Requests/ClientKeyCompanyLevel/GenerateCompanyClientKeyRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GenerateClientKeyResponse](src/AdyenApIs/Models/GenerateClientKeyResponse.cs)</code>

**OnError**: <code>[ApiException](src/AdyenApIs/Core/Exceptions/ApiException.cs)&lt;[GenerateCompanyClientKeyError](src/AdyenApIs/Errors/GenerateCompanyClientKeyError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## ClientKeyMerchantLevel

> Source: [ClientKeyMerchantLevel](src/AdyenApIs/Api/ClientKeyMerchantLevel.cs)

<details>
<summary><code>Task&lt;GenerateClientKeyResponse&gt; GenerateMerchantClientKey(GenerateMerchantClientKeyRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a new [client key](https://docs.adyen.com/development-resources/client-side-authentication#how-it-works) for the API credential identified in the path. You can use the new client key a few minutes after generating it. The old client key stops working 24 hours after generating a new one.

To make this request, your API credential must have the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—API credentials read and write

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ClientKeyMerchantLevel.GenerateMerchantClientKey(new GenerateMerchantClientKeyRequest
    {
        MerchantId = "some example string",
        ApiCredentialId = "some example string",
    });
    // TODO: Handle 'response' of type GenerateClientKeyResponse
}
catch (ApiException<GenerateMerchantClientKeyError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GenerateMerchantClientKeyRequest](src/AdyenApIs/Requests/ClientKeyMerchantLevel/GenerateMerchantClientKeyRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GenerateClientKeyResponse](src/AdyenApIs/Models/GenerateClientKeyResponse.cs)</code>

**OnError**: <code>[ApiException](src/AdyenApIs/Core/Exceptions/ApiException.cs)&lt;[GenerateMerchantClientKeyError](src/AdyenApIs/Errors/GenerateMerchantClientKeyError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Donations

> Source: [Donations](src/AdyenApIs/Api/Donations.cs)

<details>
<summary><code>Task&lt;DonationPaymentResponse&gt; CreateDonation(CreateDonationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Takes in the donation token generated by the `/payments` request and uses it to make the donation.

For more information, see [Donations](https://docs.adyen.com/online-payments/donations).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Donations.CreateDonation(new CreateDonationRequest
    {
        IdempotencyKey = "37ca9c97-d1d1-4c62-89e8-706891a563ed",
        Body = new DonationPaymentRequest
        {
            Amount = new Amount { Currency = "EUR", Value = 1000L },
            DonationCampaignId = "DONATION_CAMPAIGN_ID",
            DonationOriginalPspReference = "991559660454807J",
            DonationToken = "YOUR_DONATION_TOKEN",
            MerchantAccount = "YOUR_MERCHANT_ACCOUNT",
            PaymentMethod = new Card { Type = TypeCard.Scheme },
            Reference = "YOUR_DONATION_REFERENCE",
            ReturnUrl = "https://your-company.example.com/...",
        },
    });
    // TODO: Handle 'response' of type DonationPaymentResponse
}
catch (ApiException<CreateDonationError> ex)
{
    if (ex.Error.TryGetServiceError(out var error))
    {
        // TODO: Handle 'error' of type ServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CreateDonationRequest](src/AdyenApIs/Requests/Donations/CreateDonationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DonationPaymentResponse](src/AdyenApIs/Models/DonationPaymentResponse.cs)</code>

**OnError**: <code>[ApiException](src/AdyenApIs/Core/Exceptions/ApiException.cs)&lt;[CreateDonationError](src/AdyenApIs/Errors/CreateDonationError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DonationCampaignsResponse&gt; GetDonationCampaigns(GetDonationCampaignsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Queries the available donation campaigns for a donation based on the donation context (like merchant account, currency, and locale). The response contains active donation campaigns.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Donations.GetDonationCampaigns(new GetDonationCampaignsRequest
    {
        IdempotencyKey = "37ca9c97-d1d1-4c62-89e8-706891a563ed",
        Body = new DonationCampaignsRequest { Currency = "EUR", MerchantAccount = "YOUR_MERCHANT_ACCOUNT" },
    });
    // TODO: Handle 'response' of type DonationCampaignsResponse
}
catch (ApiException<GetDonationCampaignsError> ex)
{
    if (ex.Error.TryGetServiceError(out var error))
    {
        // TODO: Handle 'error' of type ServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetDonationCampaignsRequest](src/AdyenApIs/Requests/Donations/GetDonationCampaignsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DonationCampaignsResponse](src/AdyenApIs/Models/DonationCampaignsResponse.cs)</code>

**OnError**: <code>[ApiException](src/AdyenApIs/Core/Exceptions/ApiException.cs)&lt;[GetDonationCampaignsError](src/AdyenApIs/Errors/GetDonationCampaignsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Modifications

> Source: [Modifications](src/AdyenApIs/Api/Modifications.cs)

<details>
<summary><code>Task&lt;PaymentCancelResponse&gt; CancelAuthorisedPayment(CancelAuthorisedPaymentRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Cancels the authorisation on a payment that has not yet been [captured](https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/payments/{paymentPspReference}/captures), and returns a unique reference for this request. You get the outcome of the request asynchronously, in a [**CANCELLATION** webhook](https://docs.adyen.com/online-payments/cancel#cancellation-webhook).

If you want to cancel a payment but don't have the [`pspReference`](https://docs.adyen.com/api-explorer/Checkout/latest/post/payments#responses-200-pspReference), use the [`/cancels`](https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/cancels) endpoint instead.

If you want to cancel a payment but are not sure whether it has been captured, use the [`/payments/{paymentPspReference}/reversals`](https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/payments/{paymentPspReference}/reversals) endpoint instead.

For more information, refer to [Cancel](https://docs.adyen.com/online-payments/cancel).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Modifications.CancelAuthorisedPayment(new CancelAuthorisedPaymentRequest
    {
        PaymentPspReference = "some example string",
        IdempotencyKey = "37ca9c97-d1d1-4c62-89e8-706891a563ed",
        Body = new PaymentCancelRequest
        {
            MerchantAccount = "YOUR_MERCHANT_ACCOUNT",
            Reference = "YOUR_UNIQUE_REFERENCE",
        },
    });
    // TODO: Handle 'response' of type PaymentCancelResponse
}
catch (ApiException<CancelAuthorisedPaymentError> ex)
{
    if (ex.Error.TryGetServiceError(out var error))
    {
        // TODO: Handle 'error' of type ServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CancelAuthorisedPaymentRequest](src/AdyenApIs/Requests/Modifications/CancelAuthorisedPaymentRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PaymentCancelResponse](src/AdyenApIs/Models/PaymentCancelResponse.cs)</code>

**OnError**: <code>[ApiException](src/AdyenApIs/Core/Exceptions/ApiException.cs)&lt;[CancelAuthorisedPaymentError](src/AdyenApIs/Errors/CancelAuthorisedPaymentError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;StandalonePaymentCancelResponse&gt; CancelPayment(CancelPaymentRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Cancels the authorisation on a payment that has not yet been [captured](https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/payments/{paymentPspReference}/captures), and returns a unique reference for this request. You get the outcome of the request asynchronously, in a [**TECHNICAL_CANCEL** webhook](https://docs.adyen.com/online-payments/cancel#cancellation-webhook).

If you want to cancel a payment using the [`pspReference`](https://docs.adyen.com/api-explorer/Checkout/latest/post/payments#responses-200-pspReference), use the [`/payments/{paymentPspReference}/cancels`](https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/payments/{paymentPspReference}/cancels) endpoint instead.

If you want to cancel a payment but are not sure whether it has been captured, use the [`/payments/{paymentPspReference}/reversals`](https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/payments/{paymentPspReference}/reversals) endpoint instead.

For more information, refer to [Cancel](https://docs.adyen.com/online-payments/cancel).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Modifications.CancelPayment(new CancelPaymentRequest
    {
        IdempotencyKey = "37ca9c97-d1d1-4c62-89e8-706891a563ed",
        Body = new StandalonePaymentCancelRequest
        {
            MerchantAccount = "YOUR_MERCHANT_ACCOUNT",
            PaymentReference = "YOUR_UNIQUE_REFERENCE_FOR_THE_PAYMENT",
            Reference = "YOUR_UNIQUE_REFERENCE_FOR_THE_CANCELLATION",
        },
    });
    // TODO: Handle 'response' of type StandalonePaymentCancelResponse
}
catch (ApiException<CancelPaymentError> ex)
{
    if (ex.Error.TryGetServiceError(out var error))
    {
        // TODO: Handle 'error' of type ServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CancelPaymentRequest](src/AdyenApIs/Requests/Modifications/CancelPaymentRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[StandalonePaymentCancelResponse](src/AdyenApIs/Models/StandalonePaymentCancelResponse.cs)</code>

**OnError**: <code>[ApiException](src/AdyenApIs/Core/Exceptions/ApiException.cs)&lt;[CancelPaymentError](src/AdyenApIs/Errors/CancelPaymentError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PaymentCaptureResponse&gt; CapturePayment(CapturePaymentRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Captures an authorised payment and returns a unique reference for this request. You get the outcome of the request asynchronously, in a [**CAPTURE** webhook](https://docs.adyen.com/online-payments/capture#capture-notification).

You can capture either the full authorised amount or a part of the authorised amount. By default, any unclaimed amount after a partial capture gets cancelled. This does not apply if you enabled multiple partial captures on your account and the payment method supports multiple partial captures. 

[Automatic capture](https://docs.adyen.com/online-payments/capture#automatic-capture) is the default setting for most payment methods. In these cases, you don't need to make capture requests. However, making capture requests for payments that are captured automatically does not result in double charges.

For more information, refer to [Capture](https://docs.adyen.com/online-payments/capture).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Modifications.CapturePayment(new CapturePaymentRequest
    {
        PaymentPspReference = "some example string",
        IdempotencyKey = "37ca9c97-d1d1-4c62-89e8-706891a563ed",
        Body = new PaymentCaptureRequest
        {
            Amount = new Amount { Currency = "EUR", Value = 2000L },
            MerchantAccount = "YOUR_MERCHANT_ACCOUNT",
            Reference = "YOUR_UNIQUE_REFERENCE",
        },
    });
    // TODO: Handle 'response' of type PaymentCaptureResponse
}
catch (ApiException<CapturePaymentError> ex)
{
    if (ex.Error.TryGetServiceError(out var error))
    {
        // TODO: Handle 'error' of type ServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CapturePaymentRequest](src/AdyenApIs/Requests/Modifications/CapturePaymentRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PaymentCaptureResponse](src/AdyenApIs/Models/PaymentCaptureResponse.cs)</code>

**OnError**: <code>[ApiException](src/AdyenApIs/Core/Exceptions/ApiException.cs)&lt;[CapturePaymentError](src/AdyenApIs/Errors/CapturePaymentError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PaymentRefundResponse&gt; RefundPayment(RefundPaymentRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Refunds a payment that has been [captured](https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/payments/{paymentPspReference}/captures), and returns a unique reference for this request. You get the outcome of the request asynchronously, in a [**REFUND** webhook](https://docs.adyen.com/online-payments/refund#refund-webhook).

You can refund either the full captured amount or a part of the captured amount. You can also perform multiple partial refunds, as long as their sum doesn't exceed the captured amount.

> Some payment methods do not support partial refunds. To learn if a payment method supports partial refunds, refer to the payment method page such as [cards](https://docs.adyen.com/payment-methods/cards#supported-cards), [iDEAL](https://docs.adyen.com/payment-methods/ideal), or [Klarna](https://docs.adyen.com/payment-methods/klarna). 

If you want to refund a payment but are not sure whether it has been captured, use the [`/payments/{paymentPspReference}/reversals`](https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/payments/{paymentPspReference}/reversals) endpoint instead.

For more information, refer to [Refund](https://docs.adyen.com/online-payments/refund).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Modifications.RefundPayment(new RefundPaymentRequest
    {
        PaymentPspReference = "some example string",
        IdempotencyKey = "37ca9c97-d1d1-4c62-89e8-706891a563ed",
        Body = new PaymentRefundRequest
        {
            Amount = new Amount { Currency = "EUR", Value = 2500L },
            MerchantAccount = "YOUR_MERCHANT_ACCOUNT",
            Reference = "YOUR_UNIQUE_REFERENCE",
        },
    });
    // TODO: Handle 'response' of type PaymentRefundResponse
}
catch (ApiException<RefundPaymentError> ex)
{
    if (ex.Error.TryGetServiceError(out var error))
    {
        // TODO: Handle 'error' of type ServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[RefundPaymentRequest](src/AdyenApIs/Requests/Modifications/RefundPaymentRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PaymentRefundResponse](src/AdyenApIs/Models/PaymentRefundResponse.cs)</code>

**OnError**: <code>[ApiException](src/AdyenApIs/Core/Exceptions/ApiException.cs)&lt;[RefundPaymentError](src/AdyenApIs/Errors/RefundPaymentError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PaymentReversalResponse&gt; ReversePayment(ReversePaymentRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

[Refunds](https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/payments/{paymentPspReference}/refunds) a payment if it has already been captured, and [cancels](https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/payments/{paymentPspReference}/cancels) a payment if it has not yet been captured. Returns a unique reference for this request. You get the outcome of the request asynchronously, in a [**CANCEL_OR_REFUND** webhook](https://docs.adyen.com/online-payments/reversal/#cancel-or-refund-webhook).

The reversed amount is always the full payment amount.
> Do not use this request for payments that involve multiple partial captures.

For more information, refer to [Reversal](https://docs.adyen.com/online-payments/reversal).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Modifications.ReversePayment(new ReversePaymentRequest
    {
        PaymentPspReference = "some example string",
        IdempotencyKey = "37ca9c97-d1d1-4c62-89e8-706891a563ed",
        Body = new PaymentReversalRequest
        {
            MerchantAccount = "YOUR_MERCHANT_ACCOUNT",
            Reference = "YOUR_UNIQUE_REFERENCE",
        },
    });
    // TODO: Handle 'response' of type PaymentReversalResponse
}
catch (ApiException<ReversePaymentError> ex)
{
    if (ex.Error.TryGetServiceError(out var error))
    {
        // TODO: Handle 'error' of type ServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ReversePaymentRequest](src/AdyenApIs/Requests/Modifications/ReversePaymentRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PaymentReversalResponse](src/AdyenApIs/Models/PaymentReversalResponse.cs)</code>

**OnError**: <code>[ApiException](src/AdyenApIs/Core/Exceptions/ApiException.cs)&lt;[ReversePaymentError](src/AdyenApIs/Errors/ReversePaymentError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PaymentAmountUpdateResponse&gt; UpdatePaymentAmount(UpdatePaymentAmountRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Increases or decreases the authorised payment amount and returns a unique reference for this request. You get the outcome of the request asynchronously, in an [**AUTHORISATION_ADJUSTMENT** webhook](https://docs.adyen.com/development-resources/webhooks/webhook-types/#event-codes).

You can only update authorised amounts that have not yet been [captured](https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/payments/{paymentPspReference}/captures).

The amount you specify in the request is the updated amount, which is larger or smaller than the initial authorised amount.

For more information, refer to [Authorisation adjustment](https://docs.adyen.com/online-payments/adjust-authorisation#use-cases).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Modifications.UpdatePaymentAmount(new UpdatePaymentAmountRequest
    {
        PaymentPspReference = "some example string",
        IdempotencyKey = "37ca9c97-d1d1-4c62-89e8-706891a563ed",
        Body = new PaymentAmountUpdateRequest
        {
            Amount = new Amount { Currency = "EUR", Value = 2500L },
            MerchantAccount = "YOUR_MERCHANT_ACCOUNT",
            Reference = "YOUR_UNIQUE_REFERENCE",
        },
    });
    // TODO: Handle 'response' of type PaymentAmountUpdateResponse
}
catch (ApiException<UpdatePaymentAmountError> ex)
{
    if (ex.Error.TryGetServiceError(out var error))
    {
        // TODO: Handle 'error' of type ServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[UpdatePaymentAmountRequest](src/AdyenApIs/Requests/Modifications/UpdatePaymentAmountRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PaymentAmountUpdateResponse](src/AdyenApIs/Models/PaymentAmountUpdateResponse.cs)</code>

**OnError**: <code>[ApiException](src/AdyenApIs/Core/Exceptions/ApiException.cs)&lt;[UpdatePaymentAmountError](src/AdyenApIs/Errors/UpdatePaymentAmountError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## MyApiCredential

> Source: [MyApiCredential](src/AdyenApIs/Api/MyApiCredential.cs)

<details>
<summary><code>Task&lt;AllowedOrigin&gt; CreateMyAllowedOrigin(CreateMyAllowedOriginRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Adds an allowed origin to the list of [allowed origins](https://docs.adyen.com/development-resources/client-side-authentication#allowed-origins) of your API credential.
The API key from the request is used to identify the [API credential](https://docs.adyen.com/development-resources/api-credentials).

You can make this request with any of the Management API roles.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.MyApiCredential.CreateMyAllowedOrigin(new CreateMyAllowedOriginRequest());
    // TODO: Handle 'response' of type AllowedOrigin
}
catch (ApiException<CreateMyAllowedOriginError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CreateMyAllowedOriginRequest](src/AdyenApIs/Requests/MyApiCredential/CreateMyAllowedOriginRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AllowedOrigin](src/AdyenApIs/Models/AllowedOrigin.cs)</code>

**OnError**: <code>[ApiException](src/AdyenApIs/Core/Exceptions/ApiException.cs)&lt;[CreateMyAllowedOriginError](src/AdyenApIs/Errors/CreateMyAllowedOriginError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task DeleteMyAllowedOrigin(DeleteMyAllowedOriginRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Removes the [allowed origin](https://docs.adyen.com/development-resources/client-side-authentication#allowed-origins) specified in the path.
The API key from the request is used to identify the [API credential](https://docs.adyen.com/development-resources/api-credentials).

You can make this request with any of the Management API roles.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.MyApiCredential.DeleteMyAllowedOrigin(new DeleteMyAllowedOriginRequest
    {
        OriginId = "some example string",
    });
}
catch (ApiException<DeleteMyAllowedOriginError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DeleteMyAllowedOriginRequest](src/AdyenApIs/Requests/MyApiCredential/DeleteMyAllowedOriginRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[ApiException](src/AdyenApIs/Core/Exceptions/ApiException.cs)&lt;[DeleteMyAllowedOriginError](src/AdyenApIs/Errors/DeleteMyAllowedOriginError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GenerateClientKeyResponse&gt; GenerateMyClientKey(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Generates a new [client key](https://docs.adyen.com/development-resources/client-side-authentication/) used to authenticate requests from your payment environment.
You can use the new client key a few minutes after generating it.
The old client key stops working 24 hours after generating a new one.

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—API credentials read and write

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.MyApiCredential.GenerateMyClientKey();
    // TODO: Handle 'response' of type GenerateClientKeyResponse
}
catch (ApiException<GenerateMyClientKeyError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GenerateClientKeyResponse](src/AdyenApIs/Models/GenerateClientKeyResponse.cs)</code>

**OnError**: <code>[ApiException](src/AdyenApIs/Core/Exceptions/ApiException.cs)&lt;[GenerateMyClientKeyError](src/AdyenApIs/Errors/GenerateMyClientKeyError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AllowedOrigin&gt; GetMyAllowedOrigin(GetMyAllowedOriginRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the details of the [allowed origin](https://docs.adyen.com/development-resources/client-side-authentication#allowed-origins) specified in the path.
The API key from the request is used to identify the [API credential](https://docs.adyen.com/development-resources/api-credentials).

You can make this request with any of the Management API roles.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.MyApiCredential.GetMyAllowedOrigin(new GetMyAllowedOriginRequest
    {
        OriginId = "some example string",
    });
    // TODO: Handle 'response' of type AllowedOrigin
}
catch (ApiException<GetMyAllowedOriginError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetMyAllowedOriginRequest](src/AdyenApIs/Requests/MyApiCredential/GetMyAllowedOriginRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AllowedOrigin](src/AdyenApIs/Models/AllowedOrigin.cs)</code>

**OnError**: <code>[ApiException](src/AdyenApIs/Core/Exceptions/ApiException.cs)&lt;[GetMyAllowedOriginError](src/AdyenApIs/Errors/GetMyAllowedOriginError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;MeApiCredential&gt; GetMyApiCredential(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns your [API credential](https://docs.adyen.com/development-resources/api-credentials) details based on the API Key you used in the request.

You can make this request with any of the Management API roles.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.MyApiCredential.GetMyApiCredential();
    // TODO: Handle 'response' of type MeApiCredential
}
catch (ApiException<GetMyApiCredentialError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[MeApiCredential](src/AdyenApIs/Models/MeApiCredential.cs)</code>

**OnError**: <code>[ApiException](src/AdyenApIs/Core/Exceptions/ApiException.cs)&lt;[GetMyApiCredentialError](src/AdyenApIs/Errors/GetMyApiCredentialError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AllowedOriginsResponse&gt; ListMyAllowedOrigins(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the list of [allowed origins](https://docs.adyen.com/development-resources/client-side-authentication#allowed-origins) of your [API credential](https://docs.adyen.com/development-resources/api-credentials) based on the API key you used in the request.

You can make this request with any of the Management API roles.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.MyApiCredential.ListMyAllowedOrigins();
    // TODO: Handle 'response' of type AllowedOriginsResponse
}
catch (ApiException<ListMyAllowedOriginsError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AllowedOriginsResponse](src/AdyenApIs/Models/AllowedOriginsResponse.cs)</code>

**OnError**: <code>[ApiException](src/AdyenApIs/Core/Exceptions/ApiException.cs)&lt;[ListMyAllowedOriginsError](src/AdyenApIs/Errors/ListMyAllowedOriginsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Orders

> Source: [Orders](src/AdyenApIs/Api/Orders.cs)

<details>
<summary><code>Task&lt;CancelOrderResponse&gt; CancelOrder(CancelOrderOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Cancels an order. Cancellation of an order results in an automatic rollback of all payments made in the order, either by canceling or refunding the payment, depending on the type of payment method.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Orders.CancelOrder(new CancelOrderOperationRequest
    {
        IdempotencyKey = "37ca9c97-d1d1-4c62-89e8-706891a563ed",
        Body = new CancelOrderRequest
        {
            MerchantAccount = "YOUR_MERCHANT_ACCOUNT",
            Order = new EncryptedOrderData
            {
                OrderData = "823fh892f8f18f4...148f13f9f3f",
                PspReference = "8815517812932012",
            },
        },
    });
    // TODO: Handle 'response' of type CancelOrderResponse
}
catch (ApiException<CancelOrderError> ex)
{
    if (ex.Error.TryGetServiceError(out var error))
    {
        // TODO: Handle 'error' of type ServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CancelOrderOperationRequest](src/AdyenApIs/Requests/Orders/CancelOrderOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CancelOrderResponse](src/AdyenApIs/Models/CancelOrderResponse.cs)</code>

**OnError**: <code>[ApiException](src/AdyenApIs/Core/Exceptions/ApiException.cs)&lt;[CancelOrderError](src/AdyenApIs/Errors/CancelOrderError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CreateOrderResponse&gt; CreateOrder(CreateOrderOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates an order to be used for partial payments. Make a POST `/orders` call before making a `/payments` call when processing payments with different payment methods.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Orders.CreateOrder(new CreateOrderOperationRequest
    {
        IdempotencyKey = "37ca9c97-d1d1-4c62-89e8-706891a563ed",
        Body = new CreateOrderRequest
        {
            Amount = new Amount { Currency = "EUR", Value = 2500L },
            MerchantAccount = "YOUR_MERCHANT_ACCOUNT",
            Reference = "YOUR_ORDER_REFERENCE",
        },
    });
    // TODO: Handle 'response' of type CreateOrderResponse
}
catch (ApiException<CreateOrderError> ex)
{
    if (ex.Error.TryGetServiceError(out var error))
    {
        // TODO: Handle 'error' of type ServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CreateOrderOperationRequest](src/AdyenApIs/Requests/Orders/CreateOrderOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CreateOrderResponse](src/AdyenApIs/Models/CreateOrderResponse.cs)</code>

**OnError**: <code>[ApiException](src/AdyenApIs/Core/Exceptions/ApiException.cs)&lt;[CreateOrderError](src/AdyenApIs/Errors/CreateOrderError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;BalanceCheckResponse&gt; GetPaymentMethodBalance(GetPaymentMethodBalanceRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves the balance remaining on a shopper's gift card. To check a gift card's balance, make a POST `/paymentMethods/balance` call and include the gift card's details inside a `paymentMethod` object.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Orders.GetPaymentMethodBalance(new GetPaymentMethodBalanceRequest
    {
        IdempotencyKey = "37ca9c97-d1d1-4c62-89e8-706891a563ed",
        Body = new BalanceCheckRequest
        {
            Amount = new Amount { Currency = "EUR", Value = 1000L },
            MerchantAccount = "YOUR_MERCHANT_ACCOUNT",
            PaymentMethod = new Dictionary<string, string>
            {
                ["type"] = "givex",
                ["number"] = "4126491073027401",
                ["cvc"] = "737",
            },
        },
    });
    // TODO: Handle 'response' of type BalanceCheckResponse
}
catch (ApiException<GetPaymentMethodBalanceError> ex)
{
    if (ex.Error.TryGetServiceError(out var error))
    {
        // TODO: Handle 'error' of type ServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetPaymentMethodBalanceRequest](src/AdyenApIs/Requests/Orders/GetPaymentMethodBalanceRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[BalanceCheckResponse](src/AdyenApIs/Models/BalanceCheckResponse.cs)</code>

**OnError**: <code>[ApiException](src/AdyenApIs/Core/Exceptions/ApiException.cs)&lt;[GetPaymentMethodBalanceError](src/AdyenApIs/Errors/GetPaymentMethodBalanceError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## PaymentLinks

> Source: [PaymentLinks](src/AdyenApIs/Api/PaymentLinks.cs)

<details>
<summary><code>Task&lt;PaymentLinkResponse&gt; CreatePaymentLink(CreatePaymentLinkRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates a payment link to a [Pay by Link](https://docs.adyen.com/unified-commerce/pay-by-link/) page where the shopper can pay. The list of payment methods presented to the shopper depends on the `currency` and `country` parameters sent in the request.

For more information, refer to [Pay by Link documentation](https://docs.adyen.com/online-payments/pay-by-link#create-payment-links-through-api).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PaymentLinks.CreatePaymentLink(new CreatePaymentLinkRequest
    {
        IdempotencyKey = "37ca9c97-d1d1-4c62-89e8-706891a563ed",
        Body = new PaymentLinkRequest
        {
            Amount = new Amount { Currency = "BRL", Value = 1250L },
            BillingAddress = new Address
            {
                City = "São Paulo",
                Country = "BR",
                HouseNumberOrName = "999",
                PostalCode = "59000060",
                StateOrProvince = "SP",
                Street = "Roque Petroni Jr",
            },
            CountryCode = "BR",
            DeliveryAddress = new Address
            {
                City = "São Paulo",
                Country = "BR",
                HouseNumberOrName = "999",
                PostalCode = "59000060",
                StateOrProvince = "SP",
                Street = "Roque Petroni Jr",
            },
            MerchantAccount = "YOUR_MERCHANT_ACCOUNT",
            Reference = "YOUR_ORDER_NUMBER",
            ShopperEmail = "test@email.com",
            ShopperLocale = "pt-BR",
            ShopperReference = "YOUR_SHOPPER_REFERENCE",
        },
    });
    // TODO: Handle 'response' of type PaymentLinkResponse
}
catch (ApiException<CreatePaymentLinkError> ex)
{
    if (ex.Error.TryGetServiceError(out var error))
    {
        // TODO: Handle 'error' of type ServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CreatePaymentLinkRequest](src/AdyenApIs/Requests/PaymentLinks/CreatePaymentLinkRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PaymentLinkResponse](src/AdyenApIs/Models/PaymentLinkResponse.cs)</code>

**OnError**: <code>[ApiException](src/AdyenApIs/Core/Exceptions/ApiException.cs)&lt;[CreatePaymentLinkError](src/AdyenApIs/Errors/CreatePaymentLinkError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PaymentLinkResponse&gt; GetPaymentLink(GetPaymentLinkRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves the payment link details using the payment link `id`.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PaymentLinks.GetPaymentLink(new GetPaymentLinkRequest
    {
        LinkId = "some example string",
    });
    // TODO: Handle 'response' of type PaymentLinkResponse
}
catch (ApiException<GetPaymentLinkError> ex)
{
    if (ex.Error.TryGetServiceError(out var error))
    {
        // TODO: Handle 'error' of type ServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetPaymentLinkRequest](src/AdyenApIs/Requests/PaymentLinks/GetPaymentLinkRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PaymentLinkResponse](src/AdyenApIs/Models/PaymentLinkResponse.cs)</code>

**OnError**: <code>[ApiException](src/AdyenApIs/Core/Exceptions/ApiException.cs)&lt;[GetPaymentLinkError](src/AdyenApIs/Errors/GetPaymentLinkError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PaymentLinkResponse&gt; UpdatePaymentLink(UpdatePaymentLinkOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates the status of a payment link. Use this endpoint to [force the expiry of a payment link](https://docs.adyen.com/online-payments/pay-by-link#update-payment-link-status).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PaymentLinks.UpdatePaymentLink(new UpdatePaymentLinkOperationRequest
    {
        LinkId = "some example string",
        Body = new UpdatePaymentLinkRequest(),
    });
    // TODO: Handle 'response' of type PaymentLinkResponse
}
catch (ApiException<UpdatePaymentLinkError> ex)
{
    if (ex.Error.TryGetServiceError(out var error))
    {
        // TODO: Handle 'error' of type ServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[UpdatePaymentLinkOperationRequest](src/AdyenApIs/Requests/PaymentLinks/UpdatePaymentLinkOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PaymentLinkResponse](src/AdyenApIs/Models/PaymentLinkResponse.cs)</code>

**OnError**: <code>[ApiException](src/AdyenApIs/Core/Exceptions/ApiException.cs)&lt;[UpdatePaymentLinkError](src/AdyenApIs/Errors/UpdatePaymentLinkError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## PaymentMethodsMerchantLevel

> Source: [PaymentMethodsMerchantLevel](src/AdyenApIs/Api/PaymentMethodsMerchantLevel.cs)

<details>
<summary><code>Task AddApplePayDomains(AddApplePayDomainsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Adds the new domain to the list of Apple Pay domains that are registered with the merchant account and the payment method identified in the path. For more information, see [Apple Pay documentation](https://docs.adyen.com/payment-methods/apple-pay/web-drop-in/?tab=adyen-certificate-live_1#going-live).

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Payment methods read and write

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.PaymentMethodsMerchantLevel.AddApplePayDomains(new AddApplePayDomainsRequest
    {
        MerchantId = "some example string",
        PaymentMethodId = "some example string",
        Body = new ApplePayInfo { Domains = ["https://example.com"] },
    });
}
catch (ApiException<AddApplePayDomainsError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AddApplePayDomainsRequest](src/AdyenApIs/Requests/PaymentMethodsMerchantLevel/AddApplePayDomainsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[ApiException](src/AdyenApIs/Core/Exceptions/ApiException.cs)&lt;[AddApplePayDomainsError](src/AdyenApIs/Errors/AddApplePayDomainsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PaymentMethodManagementApi&gt; CreatePaymentMethodSetting(CreatePaymentMethodSettingRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Sends a request to add a new payment method to the merchant account identified in the path.
Depending the payment method [`type`](https://docs.adyen.com/api-explorer/Management/latest/post/merchants/_merchantId_/paymentMethodSettings#request-type), you may need to send an additional object required for the payment method.

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Payment methods read and write

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PaymentMethodsMerchantLevel.CreatePaymentMethodSetting(
        new CreatePaymentMethodSettingRequest
        {
            MerchantId = "some example string",
            Body = new PaymentMethodSetupInfo
            {
                Countries = ["US"],
                Currencies = ["USD"],
                Type = TypePaymentMethodSetupInfo.Visa,
            },
        });
    // TODO: Handle 'response' of type PaymentMethodManagementApi
}
catch (ApiException<CreatePaymentMethodSettingError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CreatePaymentMethodSettingRequest](src/AdyenApIs/Requests/PaymentMethodsMerchantLevel/CreatePaymentMethodSettingRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PaymentMethodManagementApi](src/AdyenApIs/Models/PaymentMethodManagementApi.cs)</code>

**OnError**: <code>[ApiException](src/AdyenApIs/Core/Exceptions/ApiException.cs)&lt;[CreatePaymentMethodSettingError](src/AdyenApIs/Errors/CreatePaymentMethodSettingError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ApplePayInfo&gt; GetApplePayDomains(GetApplePayDomainsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns all Apple Pay domains that are registered with the merchant account and the payment method identified in the path. For more information, see [Apple Pay documentation](https://docs.adyen.com/payment-methods/apple-pay/enable-apple-pay#register-merchant-domain).

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Payment methods read

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PaymentMethodsMerchantLevel.GetApplePayDomains(new GetApplePayDomainsRequest
    {
        MerchantId = "some example string",
        PaymentMethodId = "some example string",
    });
    // TODO: Handle 'response' of type ApplePayInfo
}
catch (ApiException<GetApplePayDomainsError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetApplePayDomainsRequest](src/AdyenApIs/Requests/PaymentMethodsMerchantLevel/GetApplePayDomainsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ApplePayInfo](src/AdyenApIs/Models/ApplePayInfo.cs)</code>

**OnError**: <code>[ApiException](src/AdyenApIs/Core/Exceptions/ApiException.cs)&lt;[GetApplePayDomainsError](src/AdyenApIs/Errors/GetApplePayDomainsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PaymentMethodManagementApi&gt; GetPaymentMethodSetting(GetPaymentMethodSettingRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns details for the merchant account and the payment method identified in the path.

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Payment methods read

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PaymentMethodsMerchantLevel.GetPaymentMethodSetting(new GetPaymentMethodSettingRequest
    {
        MerchantId = "some example string",
        PaymentMethodId = "some example string",
    });
    // TODO: Handle 'response' of type PaymentMethodManagementApi
}
catch (ApiException<GetPaymentMethodSettingError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetPaymentMethodSettingRequest](src/AdyenApIs/Requests/PaymentMethodsMerchantLevel/GetPaymentMethodSettingRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PaymentMethodManagementApi](src/AdyenApIs/Models/PaymentMethodManagementApi.cs)</code>

**OnError**: <code>[ApiException](src/AdyenApIs/Core/Exceptions/ApiException.cs)&lt;[GetPaymentMethodSettingError](src/AdyenApIs/Errors/GetPaymentMethodSettingError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PaymentMethodResponse&gt; ListPaymentMethodSettings(ListPaymentMethodSettingsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns details for all payment methods of the merchant account identified in the path.

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Payment methods read

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PaymentMethodsMerchantLevel.ListPaymentMethodSettings(
        new ListPaymentMethodSettingsRequest { MerchantId = "some example string" });
    // TODO: Handle 'response' of type PaymentMethodResponse
}
catch (ApiException<ListPaymentMethodSettingsError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ListPaymentMethodSettingsRequest](src/AdyenApIs/Requests/PaymentMethodsMerchantLevel/ListPaymentMethodSettingsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PaymentMethodResponse](src/AdyenApIs/Models/PaymentMethodResponse.cs)</code>

**OnError**: <code>[ApiException](src/AdyenApIs/Core/Exceptions/ApiException.cs)&lt;[ListPaymentMethodSettingsError](src/AdyenApIs/Errors/ListPaymentMethodSettingsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PaymentMethodManagementApi&gt; UpdatePaymentMethodSetting(UpdatePaymentMethodSettingRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates payment method details for the merchant account and the payment method identified in the path.
Depending the payment method [`type`](https://docs.adyen.com/api-explorer/Management/latest/patch/merchants/_merchantId_/paymentMethodSettings#request-type), you may need to send an additional object required for the payment method.

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Payment methods read and write

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PaymentMethodsMerchantLevel.UpdatePaymentMethodSetting(
        new UpdatePaymentMethodSettingRequest
        {
            MerchantId = "some example string",
            PaymentMethodId = "some example string",
            Body = new UpdatePaymentMethodInfo { Countries = ["NL"], Currencies = ["EUR"] },
        });
    // TODO: Handle 'response' of type PaymentMethodManagementApi
}
catch (ApiException<UpdatePaymentMethodSettingError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[UpdatePaymentMethodSettingRequest](src/AdyenApIs/Requests/PaymentMethodsMerchantLevel/UpdatePaymentMethodSettingRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PaymentMethodManagementApi](src/AdyenApIs/Models/PaymentMethodManagementApi.cs)</code>

**OnError**: <code>[ApiException](src/AdyenApIs/Core/Exceptions/ApiException.cs)&lt;[UpdatePaymentMethodSettingError](src/AdyenApIs/Errors/UpdatePaymentMethodSettingError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Payments

> Source: [Payments](src/AdyenApIs/Api/Payments.cs)

<details>
<summary><code>Task&lt;CreateCheckoutSessionResponse&gt; CreateCheckoutSession(CreateCheckoutSessionOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates a payment session for [Drop-in](https://docs.adyen.com/online-payments/build-your-integration/sessions-flow/?platform=Web&integration=Drop-in), [Components](https://docs.adyen.com/online-payments/build-your-integration/sessions-flow/?platform=Web&integration=Components), and [Hosted Checkout](https://docs.adyen.com/online-payments/build-your-integration/sessions-flow/?platform=Web&integration=Hosted+Checkout) integrations.

The response contains encrypted payment session data. The front end then uses the session data to make any required server-side calls for the payment flow.

You get the payment outcome asynchronously, in an [AUTHORISATION](https://docs.adyen.com/api-explorer/#/Webhooks/latest/post/AUTHORISATION) webhook.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Payments.CreateCheckoutSession(new CreateCheckoutSessionOperationRequest
    {
        IdempotencyKey = "37ca9c97-d1d1-4c62-89e8-706891a563ed",
        Body = new CreateCheckoutSessionRequest
        {
            Amount = new Amount { Currency = "EUR", Value = 100L },
            CountryCode = "NL",
            MerchantAccount = "YOUR_MERCHANT_ACCOUNT",
            Reference = "YOUR_PAYMENT_REFERENCE",
            ReturnUrl = "https://your-company.example.com/checkout?shopperOrder=12xy..",
        },
    });
    // TODO: Handle 'response' of type CreateCheckoutSessionResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CreateCheckoutSessionOperationRequest](src/AdyenApIs/Requests/Payments/CreateCheckoutSessionOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CreateCheckoutSessionResponse](src/AdyenApIs/Models/CreateCheckoutSessionResponse.cs)</code>

**OnError**: <code>[ApiException](src/AdyenApIs/Core/Exceptions/ApiException.cs)&lt;[RawError](src/AdyenApIs/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PaymentResponse&gt; CreatePayment(CreatePaymentRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Sends payment parameters (like amount, country, and currency) together with other required input details collected from the shopper. To know more about required parameters for specific payment methods, refer to our [payment method guides](https://docs.adyen.com/payment-methods). 
The response depends on the [payment flow](https://docs.adyen.com/payment-methods#payment-flow):
* For a direct flow, the response includes a `pspReference` and a `resultCode` with the payment result, for example **Authorised** or **Refused**. 
* For a redirect or additional action, the response contains an `action` object.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Payments.CreatePayment(new CreatePaymentRequest
    {
        IdempotencyKey = "37ca9c97-d1d1-4c62-89e8-706891a563ed",
        Body = new PaymentRequest
        {
            Amount = new Amount { Currency = "USD", Value = 1000L },
            MerchantAccount = "YOUR_MERCHANT_ACCOUNT",
            PaymentMethod = new ApplePay
            {
                ApplePayToken = "VNRWtuNlNEWkRCSm1xWndjMDFFbktkQU...",
                Type = TypeApplePay.Applepay,
            },
            Reference = "Your order number",
            ReturnUrl = "https://your-company.example.com/...",
        },
    });
    // TODO: Handle 'response' of type PaymentResponse
}
catch (ApiException<CreatePaymentError> ex)
{
    if (ex.Error.TryGetServiceError(out var error))
    {
        // TODO: Handle 'error' of type ServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CreatePaymentRequest](src/AdyenApIs/Requests/Payments/CreatePaymentRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PaymentResponse](src/AdyenApIs/Models/PaymentResponse.cs)</code>

**OnError**: <code>[ApiException](src/AdyenApIs/Core/Exceptions/ApiException.cs)&lt;[CreatePaymentError](src/AdyenApIs/Errors/CreatePaymentError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CardDetailsResponse&gt; GetCardDetails(GetCardDetailsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Use this endpoint to get information about the card or network token that enables you to decide on the routing of the transaction and the eligibility of the card for the type of transaction.

If you include [your supported brands](https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/cardDetails__reqParam_supportedBrands) in the request, the response also tells you if you support each [brand that was identified on the card](https://docs.adyen.com/api-explorer/Checkout/latest/post/cardDetails#responses-200-brands).

If you have an API-only integration and collect card data, use this endpoint to find out if the shopper's card is co-bad. For co-badged cards, you must let the shopper choose the brand to pay with  if you support both brands.

## Server-side API libraries
We provide open-source [server-side API libraries](https://docs.adyen.com/development-resources/libraries/) in several languages: 
- PHP
- Java
- Node.js
- .NET
- Go
- Python
- Ruby
- Apex (beta)

See our [integration examples](https://github.com/adyen-examples#%EF%B8%8F-official-integration-examples) for example uses of the libraries.

## Developer resources
BIN Lookup API is available through a Postman collection. Click the button below to create a fork, then set the environment variables at **Environments**&nbsp;>&nbsp;**Adyen&nbsp;APIs**. 

[Run in Postman](https://god.gw.postman.com/run-collection/25716737-677c7679-a695-4ebb-91da-68b4e7c9228a?action=collection%2Ffork&source=rip_markdown&collection-url=entityId%3D25716737-677c7679-a695-4ebb-91da-68b4e7c9228a%26entityType%3Dcollection%26workspaceId%3Da8d63f9f-cfc7-4810-90c5-9e0c60030d3e#?env%5BAdyen%20APIs%5D=W3sia2V5IjoiWC1BUEktS2V5IiwidmFsdWUiOiIiLCJlbmFibGVkIjp0cnVlLCJ0eXBlIjoic2VjcmV0In0seyJrZXkiOiJZT1VSX01FUkNIQU5UX0FDQ09VTlQiLCJ2YWx1ZSI6IiIsImVuYWJsZWQiOnRydWUsInR5cGUiOiJkZWZhdWx0In0seyJrZXkiOiJZT1VSX0NPTVBBTllfQUNDT1VOVCIsInZhbHVlIjoiIiwiZW5hYmxlZCI6dHJ1ZSwidHlwZSI6ImRlZmF1bHQifSx7ImtleSI6IllPVVJfQkFMQU5DRV9QTEFURk9STSIsInZhbHVlIjoiIiwiZW5hYmxlZCI6dHJ1ZSwidHlwZSI6ImRlZmF1bHQifV0=)

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Payments.GetCardDetails(new GetCardDetailsRequest
    {
        IdempotencyKey = "37ca9c97-d1d1-4c62-89e8-706891a563ed",
        Body = new CardDetailsRequest { CardNumber = "411111", MerchantAccount = "YOUR_MERCHANT_ACCOUNT" },
    });
    // TODO: Handle 'response' of type CardDetailsResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetCardDetailsRequest](src/AdyenApIs/Requests/Payments/GetCardDetailsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CardDetailsResponse](src/AdyenApIs/Models/CardDetailsResponse.cs)</code>

**OnError**: <code>[ApiException](src/AdyenApIs/Core/Exceptions/ApiException.cs)&lt;[RawError](src/AdyenApIs/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SessionResultResponse&gt; GetCheckoutSession(GetCheckoutSessionRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the status of the payment session with the `sessionId` and `sessionResult` specified in the path.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Payments.GetCheckoutSession(new GetCheckoutSessionRequest
    {
        SessionId = "some example string",
        SessionResult = "some example string",
    });
    // TODO: Handle 'response' of type SessionResultResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetCheckoutSessionRequest](src/AdyenApIs/Requests/Payments/GetCheckoutSessionRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SessionResultResponse](src/AdyenApIs/Models/SessionResultResponse.cs)</code>

**OnError**: <code>[ApiException](src/AdyenApIs/Core/Exceptions/ApiException.cs)&lt;[RawError](src/AdyenApIs/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PaymentDetailsResponse&gt; GetPaymentDetails(GetPaymentDetailsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Submits details for a payment created using `/payments`. This step is only needed when no final state has been reached on the `/payments` request, for example when the shopper was redirected to another page to complete the payment.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Payments.GetPaymentDetails(new GetPaymentDetailsRequest
    {
        IdempotencyKey = "37ca9c97-d1d1-4c62-89e8-706891a563ed",
        Body = new PaymentDetailsRequest
        {
            Details = new PaymentCompletionDetailsPaymentDetailsRequest { RedirectResult = "X6XtfGC3!Y..." },
        },
    });
    // TODO: Handle 'response' of type PaymentDetailsResponse
}
catch (ApiException<GetPaymentDetailsError> ex)
{
    if (ex.Error.TryGetServiceError(out var error))
    {
        // TODO: Handle 'error' of type ServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetPaymentDetailsRequest](src/AdyenApIs/Requests/Payments/GetPaymentDetailsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PaymentDetailsResponse](src/AdyenApIs/Models/PaymentDetailsResponse.cs)</code>

**OnError**: <code>[ApiException](src/AdyenApIs/Core/Exceptions/ApiException.cs)&lt;[GetPaymentDetailsError](src/AdyenApIs/Errors/GetPaymentDetailsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PaymentMethodsResponse&gt; GetPaymentMethods(GetPaymentMethodsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves the list of available payment methods for the transaction, based on the transaction information like amount, country, and currency.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Payments.GetPaymentMethods(new GetPaymentMethodsRequest
    {
        IdempotencyKey = "37ca9c97-d1d1-4c62-89e8-706891a563ed",
        Body = new PaymentMethodsRequest { MerchantAccount = "YOUR_MERCHANT_ACCOUNT" },
    });
    // TODO: Handle 'response' of type PaymentMethodsResponse
}
catch (ApiException<GetPaymentMethodsError> ex)
{
    if (ex.Error.TryGetServiceError(out var error))
    {
        // TODO: Handle 'error' of type ServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetPaymentMethodsRequest](src/AdyenApIs/Requests/Payments/GetPaymentMethodsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PaymentMethodsResponse](src/AdyenApIs/Models/PaymentMethodsResponse.cs)</code>

**OnError**: <code>[ApiException](src/AdyenApIs/Core/Exceptions/ApiException.cs)&lt;[GetPaymentMethodsError](src/AdyenApIs/Errors/GetPaymentMethodsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## PayoutSettingsMerchantLevel

> Source: [PayoutSettingsMerchantLevel](src/AdyenApIs/Api/PayoutSettingsMerchantLevel.cs)

<details>
<summary><code>Task&lt;PayoutSettings&gt; CreatePayoutSetting(CreatePayoutSettingRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Sends a request to add a payout setting for the merchant account specified in the path. A payout setting links the merchant account to the [transfer instrument](https://docs.adyen.com/api-explorer/#/legalentity/latest/post/transferInstruments) that contains the details of the payout bank account. Adyen verifies the bank account before allowing and enabling the payout setting.

If you're accepting payments in multiple currencies, you may add multiple payout settings for the merchant account.

Use this endpoint if your integration requires it, such as Adyen for Platforms Manage. Your Adyen contact will set up your access.

To make this request, your API credential must have the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):

* Management API—Payout account settings read and write

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PayoutSettingsMerchantLevel.CreatePayoutSetting(new CreatePayoutSettingRequest
    {
        MerchantId = "some example string",
    });
    // TODO: Handle 'response' of type PayoutSettings
}
catch (ApiException<CreatePayoutSettingError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CreatePayoutSettingRequest](src/AdyenApIs/Requests/PayoutSettingsMerchantLevel/CreatePayoutSettingRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PayoutSettings](src/AdyenApIs/Models/PayoutSettings.cs)</code>

**OnError**: <code>[ApiException](src/AdyenApIs/Core/Exceptions/ApiException.cs)&lt;[CreatePayoutSettingError](src/AdyenApIs/Errors/CreatePayoutSettingError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task DeletePayoutSetting(DeletePayoutSettingRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Deletes the payout setting identified in the path.

Use this endpoint if your integration requires it, such as Adyen for Platforms Manage. Your Adyen contact will set up your access.

To make this request, your API credential must have the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):

* Management API—Payout account settings read and write

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.PayoutSettingsMerchantLevel.DeletePayoutSetting(new DeletePayoutSettingRequest
    {
        MerchantId = "some example string",
        PayoutSettingsId = "some example string",
    });
}
catch (ApiException<DeletePayoutSettingError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DeletePayoutSettingRequest](src/AdyenApIs/Requests/PayoutSettingsMerchantLevel/DeletePayoutSettingRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[ApiException](src/AdyenApIs/Core/Exceptions/ApiException.cs)&lt;[DeletePayoutSettingError](src/AdyenApIs/Errors/DeletePayoutSettingError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PayoutSettings&gt; GetPayoutSetting(GetPayoutSettingRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the payout setting identified in the path.

Use this endpoint if your integration requires it, such as Adyen for Platforms Manage. Your Adyen contact will set up your access.

To make this request, your API credential must have the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Payout account settings read

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PayoutSettingsMerchantLevel.GetPayoutSetting(new GetPayoutSettingRequest
    {
        MerchantId = "some example string",
        PayoutSettingsId = "some example string",
    });
    // TODO: Handle 'response' of type PayoutSettings
}
catch (ApiException<GetPayoutSettingError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetPayoutSettingRequest](src/AdyenApIs/Requests/PayoutSettingsMerchantLevel/GetPayoutSettingRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PayoutSettings](src/AdyenApIs/Models/PayoutSettings.cs)</code>

**OnError**: <code>[ApiException](src/AdyenApIs/Core/Exceptions/ApiException.cs)&lt;[GetPayoutSettingError](src/AdyenApIs/Errors/GetPayoutSettingError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PayoutSettingsResponse&gt; ListPayoutSettings(ListPayoutSettingsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the list of payout settings for the merchant account identified in the path.

Use this endpoint if your integration requires it, such as Adyen for Platforms Manage. Your Adyen contact will set up your access.

To make this request, your API credential must have the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Payout account settings read

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PayoutSettingsMerchantLevel.ListPayoutSettings(new ListPayoutSettingsRequest
    {
        MerchantId = "some example string",
    });
    // TODO: Handle 'response' of type PayoutSettingsResponse
}
catch (ApiException<ListPayoutSettingsError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ListPayoutSettingsRequest](src/AdyenApIs/Requests/PayoutSettingsMerchantLevel/ListPayoutSettingsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PayoutSettingsResponse](src/AdyenApIs/Models/PayoutSettingsResponse.cs)</code>

**OnError**: <code>[ApiException](src/AdyenApIs/Core/Exceptions/ApiException.cs)&lt;[ListPayoutSettingsError](src/AdyenApIs/Errors/ListPayoutSettingsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PayoutSettings&gt; UpdatePayoutSetting(UpdatePayoutSettingRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates the payout setting identified in the path. You can enable or disable the payout setting.

Use this endpoint if your integration requires it, such as Adyen for Platforms Manage. Your Adyen contact will set up your access.

To make this request, your API credential must have the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):

* Management API—Payout account settings read and write

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PayoutSettingsMerchantLevel.UpdatePayoutSetting(new UpdatePayoutSettingRequest
    {
        MerchantId = "some example string",
        PayoutSettingsId = "some example string",
    });
    // TODO: Handle 'response' of type PayoutSettings
}
catch (ApiException<UpdatePayoutSettingError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[UpdatePayoutSettingRequest](src/AdyenApIs/Requests/PayoutSettingsMerchantLevel/UpdatePayoutSettingRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PayoutSettings](src/AdyenApIs/Models/PayoutSettings.cs)</code>

**OnError**: <code>[ApiException](src/AdyenApIs/Core/Exceptions/ApiException.cs)&lt;[UpdatePayoutSettingError](src/AdyenApIs/Errors/UpdatePayoutSettingError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## RecurringApi

> Source: [RecurringApi](src/AdyenApIs/Api/RecurringApi.cs)

<details>
<summary><code>Task&lt;StoredPaymentMethodResource&gt; CreateStoredPaymentMethod(CreateStoredPaymentMethodRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates a token to store the shopper's payment details. This token can be used for the shopper's future payments.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.RecurringApi.CreateStoredPaymentMethod(new CreateStoredPaymentMethodRequest
    {
        IdempotencyKey = "37ca9c97-d1d1-4c62-89e8-706891a563ed",
        Body = new StoredPaymentMethodRequest
        {
            MerchantAccount = "YOUR_MERCHANT_ACCOUNT",
            PaymentMethod = new PaymentMethodToStoreStoredPaymentMethodRequest
            {
                EncryptedCardNumber = "test_4111111111111111",
                EncryptedExpiryMonth = "test_03",
                EncryptedExpiryYear = "test_2030",
                EncryptedSecurityCode = "test_737",
                HolderName = "John Smith",
                Type = "scheme",
            },
            RecurringProcessingModel = RecurringProcessingModelStoredPaymentMethodRequest.Subscription,
            ShopperEmail = "s.hopper@test.com",
            ShopperIp = "192.0.2.1",
            ShopperReference = "YOUR_SHOPPER_REFERENCE",
        },
    });
    // TODO: Handle 'response' of type StoredPaymentMethodResource
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CreateStoredPaymentMethodRequest](src/AdyenApIs/Requests/RecurringApi/CreateStoredPaymentMethodRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[StoredPaymentMethodResource](src/AdyenApIs/Models/StoredPaymentMethodResource.cs)</code>

**OnError**: <code>[ApiException](src/AdyenApIs/Core/Exceptions/ApiException.cs)&lt;[RawError](src/AdyenApIs/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task DeleteStoredPaymentMethod(DeleteStoredPaymentMethodRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Deletes the token identified in the path. The token can no longer be used with payment requests.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.RecurringApi.DeleteStoredPaymentMethod(new DeleteStoredPaymentMethodRequest
    {
        StoredPaymentMethodId = "some example string",
        ShopperReference = "some example string",
        MerchantAccount = "some example string",
    });
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DeleteStoredPaymentMethodRequest](src/AdyenApIs/Requests/RecurringApi/DeleteStoredPaymentMethodRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[ApiException](src/AdyenApIs/Core/Exceptions/ApiException.cs)&lt;[RawError](src/AdyenApIs/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CheckoutForwardResponse&gt; ForwardRequest(ForwardRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Forwards the payment details you stored with Adyen to a third-party that you specify and returns the response from the third-party. Supports forwarding stored card details or [network tokens](https://docs.adyen.com/online-payments/network-tokenization). For more information, see [Forward stored payment details](https://docs.adyen.com/online-payments/tokenization/forward-payment-details).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.RecurringApi.ForwardRequest(new ForwardRequest
    {
        IdempotencyKey = "37ca9c97-d1d1-4c62-89e8-706891a563ed",
        Body = new CheckoutForwardRequest
        {
            BaseUrl = "http://thirdparty.example.com",
            MerchantAccount = "YOUR_MERCHANT_ACCOUNT",
            Request = new CheckoutOutgoingForwardRequestCheckoutForwardRequest
            {
                Body = "{\"amount\":{\"value\":100,\"currency\":\"USD\"},\"paymentMethod\":{\"creditCard\":{\"holderName\":\"{{holderName}}\",\"number\":\"{{number}}\",\"expiryMonth\":\"{{expiryMonth}}\",\"expiryYear\":\"{{expiryYear}}\"}}}",
                Credentials = "YOUR_CREDENTIALS_FOR_THE_THIRD_PARTY",
                Headers = new Dictionary<string, string> { ["Authorization"] = "Basic {{credentials}}" },
                HttpMethod = HttpMethodEnum.Post,
                UrlSuffix = "/payments",
            },
            ShopperReference = "YOUR_SHOPPER_REFERENCE",
            StoredPaymentMethodId = "M5N7TQ4TG5PFWR50",
        },
    });
    // TODO: Handle 'response' of type CheckoutForwardResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ForwardRequest](src/AdyenApIs/Requests/RecurringApi/ForwardRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CheckoutForwardResponse](src/AdyenApIs/Models/CheckoutForwardResponse.cs)</code>

**OnError**: <code>[ApiException](src/AdyenApIs/Core/Exceptions/ApiException.cs)&lt;[RawError](src/AdyenApIs/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ListStoredPaymentMethodsResponse&gt; ListStoredPaymentMethods(ListStoredPaymentMethodsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Lists the tokens for stored payment details for the shopper identified in the path, if there are any available. The token ID can be used with payment requests for the shopper's payment. A summary of the stored details is included.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.RecurringApi.ListStoredPaymentMethods(new ListStoredPaymentMethodsRequest());
    // TODO: Handle 'response' of type ListStoredPaymentMethodsResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ListStoredPaymentMethodsRequest](src/AdyenApIs/Requests/RecurringApi/ListStoredPaymentMethodsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ListStoredPaymentMethodsResponse](src/AdyenApIs/Models/ListStoredPaymentMethodsResponse.cs)</code>

**OnError**: <code>[ApiException](src/AdyenApIs/Core/Exceptions/ApiException.cs)&lt;[RawError](src/AdyenApIs/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## SplitConfigurationMerchantLevel

> Source: [SplitConfigurationMerchantLevel](src/AdyenApIs/Api/SplitConfigurationMerchantLevel.cs)

<details>
<summary><code>Task&lt;SplitConfiguration&gt; CreateSplitConfiguration(CreateSplitConfigurationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates a split configuration profile to [split payments automatically](https://docs.adyen.com/platforms/automatic-split-configuration/). After you [associate it with a store](https://docs.adyen.com/api-explorer/Management/latest/patch/merchants/(merchantId)/stores/(storeId)#request-splitConfiguration) in your merchant account, it splits the funds of all transactions processed through that store between your liable balance account and [your user's balance account](https://docs.adyen.com/api-explorer/Management/latest/patch/merchants/(merchantId)/stores/(storeId)#request-splitConfiguration-balanceAccountId).

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API - SplitConfiguration read and write

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SplitConfigurationMerchantLevel.CreateSplitConfiguration(
        new CreateSplitConfigurationRequest
        {
            MerchantId = "some example string",
            Body = new SplitConfiguration
            {
                Description = "Your description for the split configuration",
                Rules = [
                    new SplitConfigurationRule
                    {
                        Currency = "ANY",
                        FundingSource = FundingSourceManagementApi.Any,
                        PaymentMethod = "ANY",
                        ShopperInteraction = ShopperInteractionSplitConfigurationRule.Any,
                        SplitLogic = new SplitConfigurationLogicSplitConfigurationRule
                        {
                            AdditionalCommission = new AdditionalCommissionSplitConfigurationLogic(),
                            Chargeback = Chargeback.DeductFromLiableAccount,
                            Commission = new CommissionSplitConfigurationLogic(),
                            PaymentFee = PaymentFee.DeductFromLiableAccount,
                            Remainder = Remainder.AddToOneBalanceAccount,
                            Tip = Tip.AddToOneBalanceAccount,
                        },
                    },
                ],
            },
        });
    // TODO: Handle 'response' of type SplitConfiguration
}
catch (ApiException<CreateSplitConfigurationError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CreateSplitConfigurationRequest](src/AdyenApIs/Requests/SplitConfigurationMerchantLevel/CreateSplitConfigurationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SplitConfiguration](src/AdyenApIs/Models/SplitConfiguration.cs)</code>

**OnError**: <code>[ApiException](src/AdyenApIs/Core/Exceptions/ApiException.cs)&lt;[CreateSplitConfigurationError](src/AdyenApIs/Errors/CreateSplitConfigurationError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SplitConfiguration&gt; CreateSplitConfigurationRule(CreateSplitConfigurationRuleRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

[Creates a rule](https://docs.adyen.com/platforms/automatic-split-configuration/manage-split-configurations/api/#create-rule) in the split configuration profile specified in the path.

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API - SplitConfiguration read and write

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SplitConfigurationMerchantLevel.CreateSplitConfigurationRule(
        new CreateSplitConfigurationRuleRequest
        {
            MerchantId = "some example string",
            SplitConfigurationId = "some example string",
            Body = new SplitConfigurationRule
            {
                Currency = "USD",
                FundingSource = FundingSourceManagementApi.Any,
                PaymentMethod = "visa",
                ShopperInteraction = ShopperInteractionSplitConfigurationRule.Pos,
                SplitLogic = new SplitConfigurationLogicSplitConfigurationRule
                {
                    AdditionalCommission = new AdditionalCommissionSplitConfigurationLogic
                    {
                        BalanceAccountId = "BA3227C223222H5HQ2XX77VVH",
                        FixedAmount = 10L,
                        VariablePercentage = 50L,
                    },
                    Chargeback = Chargeback.DeductFromLiableAccount,
                    Commission = new CommissionSplitConfigurationLogic { FixedAmount = 10L, VariablePercentage = 100L },
                    PaymentFee = PaymentFee.DeductFromLiableAccount,
                    Remainder = Remainder.AddToLiableAccount,
                    Tip = Tip.AddToOneBalanceAccount,
                },
            },
        });
    // TODO: Handle 'response' of type SplitConfiguration
}
catch (ApiException<CreateSplitConfigurationRuleError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CreateSplitConfigurationRuleRequest](src/AdyenApIs/Requests/SplitConfigurationMerchantLevel/CreateSplitConfigurationRuleRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SplitConfiguration](src/AdyenApIs/Models/SplitConfiguration.cs)</code>

**OnError**: <code>[ApiException](src/AdyenApIs/Core/Exceptions/ApiException.cs)&lt;[CreateSplitConfigurationRuleError](src/AdyenApIs/Errors/CreateSplitConfigurationRuleError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SplitConfiguration&gt; DeleteSplitConfiguration(DeleteSplitConfigurationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Deletes the split configuration profile specified in the path.

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API - SplitConfiguration read and write

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SplitConfigurationMerchantLevel.DeleteSplitConfiguration(
        new DeleteSplitConfigurationRequest
        {
            MerchantId = "some example string",
            SplitConfigurationId = "some example string",
        });
    // TODO: Handle 'response' of type SplitConfiguration
}
catch (ApiException<DeleteSplitConfigurationError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DeleteSplitConfigurationRequest](src/AdyenApIs/Requests/SplitConfigurationMerchantLevel/DeleteSplitConfigurationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SplitConfiguration](src/AdyenApIs/Models/SplitConfiguration.cs)</code>

**OnError**: <code>[ApiException](src/AdyenApIs/Core/Exceptions/ApiException.cs)&lt;[DeleteSplitConfigurationError](src/AdyenApIs/Errors/DeleteSplitConfigurationError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SplitConfiguration&gt; DeleteSplitConfigurationRule(DeleteSplitConfigurationRuleRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Deletes the rule specified in the path.

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API - SplitConfiguration read and write

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SplitConfigurationMerchantLevel.DeleteSplitConfigurationRule(
        new DeleteSplitConfigurationRuleRequest
        {
            MerchantId = "some example string",
            SplitConfigurationId = "some example string",
            RuleId = "some example string",
        });
    // TODO: Handle 'response' of type SplitConfiguration
}
catch (ApiException<DeleteSplitConfigurationRuleError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DeleteSplitConfigurationRuleRequest](src/AdyenApIs/Requests/SplitConfigurationMerchantLevel/DeleteSplitConfigurationRuleRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SplitConfiguration](src/AdyenApIs/Models/SplitConfiguration.cs)</code>

**OnError**: <code>[ApiException](src/AdyenApIs/Core/Exceptions/ApiException.cs)&lt;[DeleteSplitConfigurationRuleError](src/AdyenApIs/Errors/DeleteSplitConfigurationRuleError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SplitConfiguration&gt; GetSplitConfiguration(GetSplitConfigurationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the details of the split configuration profile specified in the path.

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API - SplitConfiguration read and write

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SplitConfigurationMerchantLevel.GetSplitConfiguration(new GetSplitConfigurationRequest
    {
        MerchantId = "some example string",
        SplitConfigurationId = "some example string",
    });
    // TODO: Handle 'response' of type SplitConfiguration
}
catch (ApiException<GetSplitConfigurationError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetSplitConfigurationRequest](src/AdyenApIs/Requests/SplitConfigurationMerchantLevel/GetSplitConfigurationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SplitConfiguration](src/AdyenApIs/Models/SplitConfiguration.cs)</code>

**OnError**: <code>[ApiException](src/AdyenApIs/Core/Exceptions/ApiException.cs)&lt;[GetSplitConfigurationError](src/AdyenApIs/Errors/GetSplitConfigurationError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SplitConfigurationList&gt; ListSplitConfigurations(ListSplitConfigurationsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the list of split configuration profiles for the merchant account.

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API - SplitConfiguration read and write

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SplitConfigurationMerchantLevel.ListSplitConfigurations(
        new ListSplitConfigurationsRequest { MerchantId = "some example string" });
    // TODO: Handle 'response' of type SplitConfigurationList
}
catch (ApiException<ListSplitConfigurationsError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ListSplitConfigurationsRequest](src/AdyenApIs/Requests/SplitConfigurationMerchantLevel/ListSplitConfigurationsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SplitConfigurationList](src/AdyenApIs/Models/SplitConfigurationList.cs)</code>

**OnError**: <code>[ApiException](src/AdyenApIs/Core/Exceptions/ApiException.cs)&lt;[ListSplitConfigurationsError](src/AdyenApIs/Errors/ListSplitConfigurationsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SplitConfiguration&gt; UpdateSplitConfiguration(UpdateSplitConfigurationOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Changes the description of the split configuration profile specified in the path.

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API - SplitConfiguration read and write

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SplitConfigurationMerchantLevel.UpdateSplitConfiguration(
        new UpdateSplitConfigurationOperationRequest
        {
            MerchantId = "some example string",
            SplitConfigurationId = "some example string",
            Body = new UpdateSplitConfigurationRequest
            {
                Description = "Updated description for the split configuration",
            },
        });
    // TODO: Handle 'response' of type SplitConfiguration
}
catch (ApiException<UpdateSplitConfigurationError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[UpdateSplitConfigurationOperationRequest](src/AdyenApIs/Requests/SplitConfigurationMerchantLevel/UpdateSplitConfigurationOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SplitConfiguration](src/AdyenApIs/Models/SplitConfiguration.cs)</code>

**OnError**: <code>[ApiException](src/AdyenApIs/Core/Exceptions/ApiException.cs)&lt;[UpdateSplitConfigurationError](src/AdyenApIs/Errors/UpdateSplitConfigurationError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SplitConfiguration&gt; UpdateSplitConfigurationRule(UpdateSplitConfigurationRuleOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Changes the [split conditions of the rule](https://docs.adyen.com/platforms/automatic-split-configuration/manage-split-configurations/api/#update-condition) specified in the path.

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API - SplitConfiguration read and write

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SplitConfigurationMerchantLevel.UpdateSplitConfigurationRule(
        new UpdateSplitConfigurationRuleOperationRequest
        {
            MerchantId = "some example string",
            SplitConfigurationId = "some example string",
            RuleId = "some example string",
            Body = new UpdateSplitConfigurationRuleRequest
            {
                Currency = "EUR",
                FundingSource = "ANY",
                PaymentMethod = "visa",
                ShopperInteraction = "ANY",
            },
        });
    // TODO: Handle 'response' of type SplitConfiguration
}
catch (ApiException<UpdateSplitConfigurationRuleError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[UpdateSplitConfigurationRuleOperationRequest](src/AdyenApIs/Requests/SplitConfigurationMerchantLevel/UpdateSplitConfigurationRuleOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SplitConfiguration](src/AdyenApIs/Models/SplitConfiguration.cs)</code>

**OnError**: <code>[ApiException](src/AdyenApIs/Core/Exceptions/ApiException.cs)&lt;[UpdateSplitConfigurationRuleError](src/AdyenApIs/Errors/UpdateSplitConfigurationRuleError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SplitConfiguration&gt; UpdateSplitLogic(UpdateSplitLogicRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Changes the [split logic](https://docs.adyen.com/platforms/automatic-split-configuration/manage-split-configurations/api/#update-split-logic) specified in the path.

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API - SplitConfiguration read and write

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SplitConfigurationMerchantLevel.UpdateSplitLogic(new UpdateSplitLogicRequest
    {
        MerchantId = "some example string",
        SplitConfigurationId = "some example string",
        RuleId = "some example string",
        SplitLogicId = "some example string",
        Body = new UpdateSplitConfigurationLogicRequest
        {
            AdditionalCommission = new AdditionalCommissionUpdateSplitConfigurationLogicRequest
            {
                BalanceAccountId = "BA3227C223222H5HQ2XX77VVH",
                FixedAmount = 100L,
                VariablePercentage = 0L,
            },
            Chargeback = Chargeback.DeductFromLiableAccount,
            Commission = new CommissionUpdateSplitConfigurationLogicRequest
            {
                FixedAmount = 100L,
                VariablePercentage = 100L,
            },
            PaymentFee = PaymentFee.DeductFromLiableAccount,
            Remainder = Remainder.AddToLiableAccount,
            Tip = Tip.AddToLiableAccount,
        },
    });
    // TODO: Handle 'response' of type SplitConfiguration
}
catch (ApiException<UpdateSplitLogicError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[UpdateSplitLogicRequest](src/AdyenApIs/Requests/SplitConfigurationMerchantLevel/UpdateSplitLogicRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SplitConfiguration](src/AdyenApIs/Models/SplitConfiguration.cs)</code>

**OnError**: <code>[ApiException](src/AdyenApIs/Core/Exceptions/ApiException.cs)&lt;[UpdateSplitLogicError](src/AdyenApIs/Errors/UpdateSplitLogicError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## TerminalActionsCompanyLevel

> Source: [TerminalActionsCompanyLevel](src/AdyenApIs/Api/TerminalActionsCompanyLevel.cs)

<details>
<summary><code>Task&lt;ExternalTerminalAction&gt; GetCompanyTerminalAction(GetCompanyTerminalActionRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the details of the [terminal action](https://docs.adyen.com/point-of-sale/automating-terminal-management/terminal-actions-api) identified in the path.
To make this request, your API credential must have one of the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Terminal actions read
* Management API—Terminal actions read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TerminalActionsCompanyLevel.GetCompanyTerminalAction(new GetCompanyTerminalActionRequest
    {
        CompanyId = "some example string",
        ActionId = "some example string",
    });
    // TODO: Handle 'response' of type ExternalTerminalAction
}
catch (ApiException<GetCompanyTerminalActionError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetCompanyTerminalActionRequest](src/AdyenApIs/Requests/TerminalActionsCompanyLevel/GetCompanyTerminalActionRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ExternalTerminalAction](src/AdyenApIs/Models/ExternalTerminalAction.cs)</code>

**OnError**: <code>[ApiException](src/AdyenApIs/Core/Exceptions/ApiException.cs)&lt;[GetCompanyTerminalActionError](src/AdyenApIs/Errors/GetCompanyTerminalActionError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ListExternalTerminalActionsResponse&gt; ListCompanyTerminalActions(ListCompanyTerminalActionsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the [terminal actions](https://docs.adyen.com/point-of-sale/automating-terminal-management/terminal-actions-api) that have been scheduled for the company identified in the path.The response doesn't include actions that are scheduled by Adyen.
To make this request, your API credential must have one of the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Terminal actions read
* Management API—Terminal actions read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TerminalActionsCompanyLevel.ListCompanyTerminalActions(
        new ListCompanyTerminalActionsRequest { CompanyId = "some example string" });
    // TODO: Handle 'response' of type ListExternalTerminalActionsResponse
}
catch (ApiException<ListCompanyTerminalActionsError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ListCompanyTerminalActionsRequest](src/AdyenApIs/Requests/TerminalActionsCompanyLevel/ListCompanyTerminalActionsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ListExternalTerminalActionsResponse](src/AdyenApIs/Models/ListExternalTerminalActionsResponse.cs)</code>

**OnError**: <code>[ApiException](src/AdyenApIs/Core/Exceptions/ApiException.cs)&lt;[ListCompanyTerminalActionsError](src/AdyenApIs/Errors/ListCompanyTerminalActionsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## TerminalActionsTerminalLevel

> Source: [TerminalActionsTerminalLevel](src/AdyenApIs/Api/TerminalActionsTerminalLevel.cs)

<details>
<summary><code>Task&lt;ScheduleTerminalActionsResponse&gt; ScheduleTerminalActions(ScheduleTerminalActionsOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Schedules a [terminal action](https://docs.adyen.com/point-of-sale/automating-terminal-management/terminal-actions-api) by specifying the action and the terminals that the action must be applied to. 

The following restrictions apply:
* You can schedule only one action at a time. For example, to install a new app version and remove an old app version, you have to make two API requests. 
* The maximum number of terminals in a request is **100**. For example, to apply an action to 250 terminals, you have to divide the terminals over three API requests. 
* If there is an error with one or more terminal IDs in the request, the action is scheduled for none of the terminals. You need to fix the error and try again. 

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Terminal actions read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TerminalActionsTerminalLevel.ScheduleTerminalActions(
        new ScheduleTerminalActionsOperationRequest
        {
            Body = new ScheduleTerminalActionsRequest
            {
                ActionDetails = new InstallAndroidAppDetails
                {
                    AppId = "ANDA422LZ223223K5F694GCCF732K8",
                    Type = TypeInstallAndroidAppDetails.InstallAndroidApp,
                },
                ScheduledAt = "2021-12-12T20:21:22-0100",
                StoreId = "",
                TerminalIds = ["S1E-000150183300032", "S1E-000150183300033", "S1F2-000150183300034"],
            },
        });
    // TODO: Handle 'response' of type ScheduleTerminalActionsResponse
}
catch (ApiException<ScheduleTerminalActionsError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ScheduleTerminalActionsOperationRequest](src/AdyenApIs/Requests/TerminalActionsTerminalLevel/ScheduleTerminalActionsOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ScheduleTerminalActionsResponse](src/AdyenApIs/Models/ScheduleTerminalActionsResponse.cs)</code>

**OnError**: <code>[ApiException](src/AdyenApIs/Core/Exceptions/ApiException.cs)&lt;[ScheduleTerminalActionsError](src/AdyenApIs/Errors/ScheduleTerminalActionsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## TerminalOrdersCompanyLevel

> Source: [TerminalOrdersCompanyLevel](src/AdyenApIs/Api/TerminalOrdersCompanyLevel.cs)

<details>
<summary><code>Task&lt;TerminalOrder&gt; CancelCompanyTerminalOrder(CancelCompanyTerminalOrderRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Cancels the terminal products order identified in the path.
Cancelling is only possible while the order has the status **Placed**.
To cancel an order, make a POST call without a request body. The response returns the full order details, but with the status changed to **Cancelled**.

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Terminal ordering read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TerminalOrdersCompanyLevel.CancelCompanyTerminalOrder(
        new CancelCompanyTerminalOrderRequest { CompanyId = "some example string", OrderId = "some example string" });
    // TODO: Handle 'response' of type TerminalOrder
}
catch (ApiException<CancelCompanyTerminalOrderError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CancelCompanyTerminalOrderRequest](src/AdyenApIs/Requests/TerminalOrdersCompanyLevel/CancelCompanyTerminalOrderRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TerminalOrder](src/AdyenApIs/Models/TerminalOrder.cs)</code>

**OnError**: <code>[ApiException](src/AdyenApIs/Core/Exceptions/ApiException.cs)&lt;[CancelCompanyTerminalOrderError](src/AdyenApIs/Errors/CancelCompanyTerminalOrderError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ShippingLocation&gt; CreateCompanyShippingLocation(CreateCompanyShippingLocationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates a shipping location for the company identified in the path. A shipping location defines an address where orders can be delivered.

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Terminal ordering read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TerminalOrdersCompanyLevel.CreateCompanyShippingLocation(
        new CreateCompanyShippingLocationRequest
        {
            CompanyId = "some example string",
            Body = new ShippingLocation
            {
                Address = new AddressManagementApi
                {
                    City = "Amsterdam",
                    CompanyName = "YOUR_COMPANY",
                    Country = "NL",
                    PostalCode = "1012 KS",
                    StateOrProvince = "",
                    StreetAddress = "Rokin 21",
                },
                Contact = new ContactShippingLocation
                {
                    Email = "Paul.Green@company.com",
                    FirstName = "Paul",
                    LastName = "Green",
                    PhoneNumber = "+31 020 1234567",
                },
                Name = "YOUR_COMPANY Rokin depot",
            },
        });
    // TODO: Handle 'response' of type ShippingLocation
}
catch (ApiException<CreateCompanyShippingLocationError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CreateCompanyShippingLocationRequest](src/AdyenApIs/Requests/TerminalOrdersCompanyLevel/CreateCompanyShippingLocationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ShippingLocation](src/AdyenApIs/Models/ShippingLocation.cs)</code>

**OnError**: <code>[ApiException](src/AdyenApIs/Core/Exceptions/ApiException.cs)&lt;[CreateCompanyShippingLocationError](src/AdyenApIs/Errors/CreateCompanyShippingLocationError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TerminalOrder&gt; CreateCompanyTerminalOrder(CreateCompanyTerminalOrderRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates an order for payment terminal products for the company identified in the path.

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Terminal ordering read and write
>Requests to the Management API test endpoint do not create actual orders for test terminals. To order test terminals, you need to [submit a sales order](https://docs.adyen.com/point-of-sale/managing-terminals/order-terminals/#sales-order-steps) in your Customer Area.

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TerminalOrdersCompanyLevel.CreateCompanyTerminalOrder(
        new CreateCompanyTerminalOrderRequest
        {
            CompanyId = "some example string",
            Body = new TerminalOrderRequest
            {
                BillingEntityId = "Company.YOUR_COMPANY",
                CustomerOrderReference = "YOUR_REFERENCE",
                Items = [
                    new OrderItem { Id = "TBOX-V400m-684-EU", Name = "V400m Package", Quantity = 1 },
                    new OrderItem { Id = "PART-175746-EU", Name = "Adyen Test Card", Quantity = 1 },
                ],
                ShippingLocationId = "S2-6A6C2E3432747D4F2F2C3455485E3836457D",
            },
        });
    // TODO: Handle 'response' of type TerminalOrder
}
catch (ApiException<CreateCompanyTerminalOrderError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CreateCompanyTerminalOrderRequest](src/AdyenApIs/Requests/TerminalOrdersCompanyLevel/CreateCompanyTerminalOrderRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TerminalOrder](src/AdyenApIs/Models/TerminalOrder.cs)</code>

**OnError**: <code>[ApiException](src/AdyenApIs/Core/Exceptions/ApiException.cs)&lt;[CreateCompanyTerminalOrderError](src/AdyenApIs/Errors/CreateCompanyTerminalOrderError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TerminalOrder&gt; GetCompanyTerminalOrder(GetCompanyTerminalOrderRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the details of the terminal products order identified in the path.

To make this request, your API credential must have one of the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Terminal ordering read
* Management API—Terminal ordering read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TerminalOrdersCompanyLevel.GetCompanyTerminalOrder(new GetCompanyTerminalOrderRequest
    {
        CompanyId = "some example string",
        OrderId = "some example string",
    });
    // TODO: Handle 'response' of type TerminalOrder
}
catch (ApiException<GetCompanyTerminalOrderError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetCompanyTerminalOrderRequest](src/AdyenApIs/Requests/TerminalOrdersCompanyLevel/GetCompanyTerminalOrderRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TerminalOrder](src/AdyenApIs/Models/TerminalOrder.cs)</code>

**OnError**: <code>[ApiException](src/AdyenApIs/Core/Exceptions/ApiException.cs)&lt;[GetCompanyTerminalOrderError](src/AdyenApIs/Errors/GetCompanyTerminalOrderError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;BillingEntitiesResponse&gt; ListCompanyBillingEntities(ListCompanyBillingEntitiesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the billing entities of the company identified in the path and all merchant accounts belonging to the company.
A billing entity is a legal entity where we charge orders to. An order for terminal products must contain the ID of a billing entity.

To make this request, your API credential must have one of the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Terminal ordering read
* Management API—Terminal ordering read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TerminalOrdersCompanyLevel.ListCompanyBillingEntities(
        new ListCompanyBillingEntitiesRequest { CompanyId = "some example string" });
    // TODO: Handle 'response' of type BillingEntitiesResponse
}
catch (ApiException<ListCompanyBillingEntitiesError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ListCompanyBillingEntitiesRequest](src/AdyenApIs/Requests/TerminalOrdersCompanyLevel/ListCompanyBillingEntitiesRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[BillingEntitiesResponse](src/AdyenApIs/Models/BillingEntitiesResponse.cs)</code>

**OnError**: <code>[ApiException](src/AdyenApIs/Core/Exceptions/ApiException.cs)&lt;[ListCompanyBillingEntitiesError](src/AdyenApIs/Errors/ListCompanyBillingEntitiesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ShippingLocationsResponse&gt; ListCompanyShippingLocations(ListCompanyShippingLocationsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the shipping locations for the company identified in the path and all merchant accounts belonging to the company.
A shipping location includes the address where orders can be delivered, and an ID which you need to specify when ordering terminal products.

To make this request, your API credential must have one of the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Terminal ordering read
* Management API—Terminal ordering read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TerminalOrdersCompanyLevel.ListCompanyShippingLocations(
        new ListCompanyShippingLocationsRequest { CompanyId = "some example string" });
    // TODO: Handle 'response' of type ShippingLocationsResponse
}
catch (ApiException<ListCompanyShippingLocationsError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ListCompanyShippingLocationsRequest](src/AdyenApIs/Requests/TerminalOrdersCompanyLevel/ListCompanyShippingLocationsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ShippingLocationsResponse](src/AdyenApIs/Models/ShippingLocationsResponse.cs)</code>

**OnError**: <code>[ApiException](src/AdyenApIs/Core/Exceptions/ApiException.cs)&lt;[ListCompanyShippingLocationsError](src/AdyenApIs/Errors/ListCompanyShippingLocationsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TerminalModelsResponse&gt; ListCompanyTerminalModels(ListCompanyTerminalModelsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a list of payment terminal models that the company identified in the path has access to.
The response includes the terminal model ID, which can be used as a query parameter when getting a list of terminals or a list of products for ordering.

To make this request, your API credential must have one of the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Terminal ordering read
* Management API—Terminal ordering read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TerminalOrdersCompanyLevel.ListCompanyTerminalModels(
        new ListCompanyTerminalModelsRequest { CompanyId = "some example string" });
    // TODO: Handle 'response' of type TerminalModelsResponse
}
catch (ApiException<ListCompanyTerminalModelsError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ListCompanyTerminalModelsRequest](src/AdyenApIs/Requests/TerminalOrdersCompanyLevel/ListCompanyTerminalModelsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TerminalModelsResponse](src/AdyenApIs/Models/TerminalModelsResponse.cs)</code>

**OnError**: <code>[ApiException](src/AdyenApIs/Core/Exceptions/ApiException.cs)&lt;[ListCompanyTerminalModelsError](src/AdyenApIs/Errors/ListCompanyTerminalModelsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TerminalOrdersResponse&gt; ListCompanyTerminalOrders(ListCompanyTerminalOrdersRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a lists of terminal products orders for the company identified in the path.
To filter the list, use one or more of the query parameters.

To make this request, your API credential must have one of the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Terminal ordering read
* Management API—Terminal ordering read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TerminalOrdersCompanyLevel.ListCompanyTerminalOrders(
        new ListCompanyTerminalOrdersRequest { CompanyId = "some example string" });
    // TODO: Handle 'response' of type TerminalOrdersResponse
}
catch (ApiException<ListCompanyTerminalOrdersError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ListCompanyTerminalOrdersRequest](src/AdyenApIs/Requests/TerminalOrdersCompanyLevel/ListCompanyTerminalOrdersRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TerminalOrdersResponse](src/AdyenApIs/Models/TerminalOrdersResponse.cs)</code>

**OnError**: <code>[ApiException](src/AdyenApIs/Core/Exceptions/ApiException.cs)&lt;[ListCompanyTerminalOrdersError](src/AdyenApIs/Errors/ListCompanyTerminalOrdersError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TerminalProductsResponse&gt; ListCompanyTerminalProducts(ListCompanyTerminalProductsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a country-specific list of payment terminal packages and parts that the company identified in the path has access to.
 
To make this request, your API credential must have one of the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Terminal ordering read
* Management API—Terminal ordering read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TerminalOrdersCompanyLevel.ListCompanyTerminalProducts(
        new ListCompanyTerminalProductsRequest { CompanyId = "some example string", Country = "some example string" });
    // TODO: Handle 'response' of type TerminalProductsResponse
}
catch (ApiException<ListCompanyTerminalProductsError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ListCompanyTerminalProductsRequest](src/AdyenApIs/Requests/TerminalOrdersCompanyLevel/ListCompanyTerminalProductsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TerminalProductsResponse](src/AdyenApIs/Models/TerminalProductsResponse.cs)</code>

**OnError**: <code>[ApiException](src/AdyenApIs/Core/Exceptions/ApiException.cs)&lt;[ListCompanyTerminalProductsError](src/AdyenApIs/Errors/ListCompanyTerminalProductsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TerminalOrder&gt; UpdateCompanyTerminalOrder(UpdateCompanyTerminalOrderRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates the terminal products order identified in the path.
Updating is only possible while the order has the status **Placed**.

The request body only needs to contain what you want to change. 
However, to update the products in the `items` array, you must provide the entire array. For example, if the array has three items:
 To remove one item, the array must include the remaining two items. Or to add one item, the array must include all four items.

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Terminal ordering read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TerminalOrdersCompanyLevel.UpdateCompanyTerminalOrder(
        new UpdateCompanyTerminalOrderRequest
        {
            CompanyId = "some example string",
            OrderId = "some example string",
            Body = new TerminalOrderRequest
            {
                Items = [
                    new OrderItem { Id = "TBOX-V400m-684-EU", Name = "V400m Package", Quantity = 1 },
                    new OrderItem { Id = "PART-175746-EU", Name = "Adyen Test Card", Quantity = 1 },
                    new OrderItem { Id = "PART-620222-EU", Name = "Receipt Roll", Quantity = 5 },
                ],
            },
        });
    // TODO: Handle 'response' of type TerminalOrder
}
catch (ApiException<UpdateCompanyTerminalOrderError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[UpdateCompanyTerminalOrderRequest](src/AdyenApIs/Requests/TerminalOrdersCompanyLevel/UpdateCompanyTerminalOrderRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TerminalOrder](src/AdyenApIs/Models/TerminalOrder.cs)</code>

**OnError**: <code>[ApiException](src/AdyenApIs/Core/Exceptions/ApiException.cs)&lt;[UpdateCompanyTerminalOrderError](src/AdyenApIs/Errors/UpdateCompanyTerminalOrderError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## TerminalOrdersMerchantLevel

> Source: [TerminalOrdersMerchantLevel](src/AdyenApIs/Api/TerminalOrdersMerchantLevel.cs)

<details>
<summary><code>Task&lt;TerminalOrder&gt; CancelMerchantTerminalOrder(CancelMerchantTerminalOrderRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Cancels the terminal products order identified in the path.
Cancelling is only possible while the order has the status **Placed**.
To cancel an order, make a POST call without a request body. The response returns the full order details, but with the status changed to **Cancelled**.

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Terminal ordering read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TerminalOrdersMerchantLevel.CancelMerchantTerminalOrder(
        new CancelMerchantTerminalOrderRequest { MerchantId = "some example string", OrderId = "some example string" });
    // TODO: Handle 'response' of type TerminalOrder
}
catch (ApiException<CancelMerchantTerminalOrderError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CancelMerchantTerminalOrderRequest](src/AdyenApIs/Requests/TerminalOrdersMerchantLevel/CancelMerchantTerminalOrderRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TerminalOrder](src/AdyenApIs/Models/TerminalOrder.cs)</code>

**OnError**: <code>[ApiException](src/AdyenApIs/Core/Exceptions/ApiException.cs)&lt;[CancelMerchantTerminalOrderError](src/AdyenApIs/Errors/CancelMerchantTerminalOrderError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ShippingLocation&gt; CreateMerchantShippingLocation(CreateMerchantShippingLocationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates a shipping location for the merchant account identified in the path. A shipping location defines an address where orders can be shipped to. 

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Terminal ordering read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TerminalOrdersMerchantLevel.CreateMerchantShippingLocation(
        new CreateMerchantShippingLocationRequest
        {
            MerchantId = "some example string",
            Body = new ShippingLocation
            {
                Address = new AddressManagementApi
                {
                    City = "Barcelona",
                    CompanyName = "YOUR_COMPANY",
                    Country = "ES",
                    PostalCode = "08012",
                    StateOrProvince = "",
                    StreetAddress = "El quinto pino 42",
                },
                Contact = new ContactShippingLocation
                {
                    Email = "Rita.Perengano@company.com",
                    FirstName = "Rita",
                    LastName = "Perengano",
                    PhoneNumber = "+34 93 1234567",
                },
                Name = "YOUR_MERCHANT_ACCOUNT Barcelona depot",
            },
        });
    // TODO: Handle 'response' of type ShippingLocation
}
catch (ApiException<CreateMerchantShippingLocationError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CreateMerchantShippingLocationRequest](src/AdyenApIs/Requests/TerminalOrdersMerchantLevel/CreateMerchantShippingLocationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ShippingLocation](src/AdyenApIs/Models/ShippingLocation.cs)</code>

**OnError**: <code>[ApiException](src/AdyenApIs/Core/Exceptions/ApiException.cs)&lt;[CreateMerchantShippingLocationError](src/AdyenApIs/Errors/CreateMerchantShippingLocationError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TerminalOrder&gt; CreateMerchantTerminalOrder(CreateMerchantTerminalOrderRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates an order for payment terminal products for the merchant account identified in the path.

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Terminal ordering read and write
>Requests to the Management API test endpoint do not create actual orders for test terminals. To order test terminals, you need to [submit a sales order](https://docs.adyen.com/point-of-sale/managing-terminals/order-terminals/#sales-order-steps) in your Customer Area.

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TerminalOrdersMerchantLevel.CreateMerchantTerminalOrder(
        new CreateMerchantTerminalOrderRequest
        {
            MerchantId = "some example string",
            Body = new TerminalOrderRequest
            {
                BillingEntityId = "MerchantAccount.YOUR_MERCHANT_ACCOUNT",
                CustomerOrderReference = "YOUR_REFERENCE",
                Items = [
                    new OrderItem { Id = "PART-287001-EU", Name = "Bluetooth Charging Base - V400m", Quantity = 2 },
                    new OrderItem { Id = "PART-620222-EU", Name = "Receipt Roll", Quantity = 20 },
                ],
                ShippingLocationId = "S2-6A6C2E3432747D4F2F2C3455485E3836457D",
            },
        });
    // TODO: Handle 'response' of type TerminalOrder
}
catch (ApiException<CreateMerchantTerminalOrderError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CreateMerchantTerminalOrderRequest](src/AdyenApIs/Requests/TerminalOrdersMerchantLevel/CreateMerchantTerminalOrderRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TerminalOrder](src/AdyenApIs/Models/TerminalOrder.cs)</code>

**OnError**: <code>[ApiException](src/AdyenApIs/Core/Exceptions/ApiException.cs)&lt;[CreateMerchantTerminalOrderError](src/AdyenApIs/Errors/CreateMerchantTerminalOrderError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TerminalOrder&gt; GetMerchantTerminalOrder(GetMerchantTerminalOrderRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the details of the terminal products order identified in the path.

To make this request, your API credential must have one of the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Terminal ordering read
* Management API—Terminal ordering read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TerminalOrdersMerchantLevel.GetMerchantTerminalOrder(new GetMerchantTerminalOrderRequest
    {
        MerchantId = "some example string",
        OrderId = "some example string",
    });
    // TODO: Handle 'response' of type TerminalOrder
}
catch (ApiException<GetMerchantTerminalOrderError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetMerchantTerminalOrderRequest](src/AdyenApIs/Requests/TerminalOrdersMerchantLevel/GetMerchantTerminalOrderRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TerminalOrder](src/AdyenApIs/Models/TerminalOrder.cs)</code>

**OnError**: <code>[ApiException](src/AdyenApIs/Core/Exceptions/ApiException.cs)&lt;[GetMerchantTerminalOrderError](src/AdyenApIs/Errors/GetMerchantTerminalOrderError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;BillingEntitiesResponse&gt; ListMerchantBillingEntities(ListMerchantBillingEntitiesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the billing entities of the merchant account identified in the path.
A billing entity is a legal entity where we charge orders to. An order for terminal products must contain the ID of a billing entity.

To make this request, your API credential must have one of the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Terminal ordering read
* Management API—Terminal ordering read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TerminalOrdersMerchantLevel.ListMerchantBillingEntities(
        new ListMerchantBillingEntitiesRequest { MerchantId = "some example string" });
    // TODO: Handle 'response' of type BillingEntitiesResponse
}
catch (ApiException<ListMerchantBillingEntitiesError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ListMerchantBillingEntitiesRequest](src/AdyenApIs/Requests/TerminalOrdersMerchantLevel/ListMerchantBillingEntitiesRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[BillingEntitiesResponse](src/AdyenApIs/Models/BillingEntitiesResponse.cs)</code>

**OnError**: <code>[ApiException](src/AdyenApIs/Core/Exceptions/ApiException.cs)&lt;[ListMerchantBillingEntitiesError](src/AdyenApIs/Errors/ListMerchantBillingEntitiesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ShippingLocationsResponse&gt; ListMerchantShippingLocations(ListMerchantShippingLocationsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the shipping locations for the merchant account identified in the path.
A shipping location includes the address where orders can be delivered, and an ID which you need to specify when ordering terminal products.

To make this request, your API credential must have one of the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Terminal ordering read
* Management API—Terminal ordering read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TerminalOrdersMerchantLevel.ListMerchantShippingLocations(
        new ListMerchantShippingLocationsRequest { MerchantId = "some example string" });
    // TODO: Handle 'response' of type ShippingLocationsResponse
}
catch (ApiException<ListMerchantShippingLocationsError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ListMerchantShippingLocationsRequest](src/AdyenApIs/Requests/TerminalOrdersMerchantLevel/ListMerchantShippingLocationsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ShippingLocationsResponse](src/AdyenApIs/Models/ShippingLocationsResponse.cs)</code>

**OnError**: <code>[ApiException](src/AdyenApIs/Core/Exceptions/ApiException.cs)&lt;[ListMerchantShippingLocationsError](src/AdyenApIs/Errors/ListMerchantShippingLocationsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TerminalModelsResponse&gt; ListMerchantTerminalModels(ListMerchantTerminalModelsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the payment terminal models that the merchant account identified in the path has access to. The response includes the terminal model ID, which can be used as a query parameter when getting a list of terminals or a list of products for ordering.

To make this request, your API credential must have one of the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Terminal ordering read
* Management API—Terminal ordering read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TerminalOrdersMerchantLevel.ListMerchantTerminalModels(
        new ListMerchantTerminalModelsRequest { MerchantId = "some example string" });
    // TODO: Handle 'response' of type TerminalModelsResponse
}
catch (ApiException<ListMerchantTerminalModelsError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ListMerchantTerminalModelsRequest](src/AdyenApIs/Requests/TerminalOrdersMerchantLevel/ListMerchantTerminalModelsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TerminalModelsResponse](src/AdyenApIs/Models/TerminalModelsResponse.cs)</code>

**OnError**: <code>[ApiException](src/AdyenApIs/Core/Exceptions/ApiException.cs)&lt;[ListMerchantTerminalModelsError](src/AdyenApIs/Errors/ListMerchantTerminalModelsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TerminalOrdersResponse&gt; ListMerchantTerminalOrders(ListMerchantTerminalOrdersRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a list of terminal products orders for the merchant account identified in the path.

To make this request, your API credential must have one of the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Terminal ordering read
* Management API—Terminal ordering read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TerminalOrdersMerchantLevel.ListMerchantTerminalOrders(
        new ListMerchantTerminalOrdersRequest { MerchantId = "some example string" });
    // TODO: Handle 'response' of type TerminalOrdersResponse
}
catch (ApiException<ListMerchantTerminalOrdersError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ListMerchantTerminalOrdersRequest](src/AdyenApIs/Requests/TerminalOrdersMerchantLevel/ListMerchantTerminalOrdersRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TerminalOrdersResponse](src/AdyenApIs/Models/TerminalOrdersResponse.cs)</code>

**OnError**: <code>[ApiException](src/AdyenApIs/Core/Exceptions/ApiException.cs)&lt;[ListMerchantTerminalOrdersError](src/AdyenApIs/Errors/ListMerchantTerminalOrdersError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TerminalProductsResponse&gt; ListMerchantTerminalProducts(ListMerchantTerminalProductsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a country-specific list of payment terminal packages and parts that the merchant account identified in the path has access to.

To make this request, your API credential must have one of the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Terminal ordering read
* Management API—Terminal ordering read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TerminalOrdersMerchantLevel.ListMerchantTerminalProducts(
        new ListMerchantTerminalProductsRequest
        {
            MerchantId = "some example string",
            Country = "some example string",
        });
    // TODO: Handle 'response' of type TerminalProductsResponse
}
catch (ApiException<ListMerchantTerminalProductsError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ListMerchantTerminalProductsRequest](src/AdyenApIs/Requests/TerminalOrdersMerchantLevel/ListMerchantTerminalProductsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TerminalProductsResponse](src/AdyenApIs/Models/TerminalProductsResponse.cs)</code>

**OnError**: <code>[ApiException](src/AdyenApIs/Core/Exceptions/ApiException.cs)&lt;[ListMerchantTerminalProductsError](src/AdyenApIs/Errors/ListMerchantTerminalProductsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TerminalOrder&gt; UpdateMerchantTerminalOrder(UpdateMerchantTerminalOrderRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates the terminal products order identified in the path.
Updating is only possible while the order has the status **Placed**.

The request body only needs to contain what you want to change. 
However, to update the products in the `items` array, you must provide the entire array. For example, if the array has three items:
 To remove one item, the array must include the remaining two items. Or to add one item, the array must include all four items.

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Terminal ordering read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TerminalOrdersMerchantLevel.UpdateMerchantTerminalOrder(
        new UpdateMerchantTerminalOrderRequest
        {
            MerchantId = "some example string",
            OrderId = "some example string",
            Body = new TerminalOrderRequest
            {
                Items = [
                    new OrderItem { Id = "TBOX-V400m-684-EU", Name = "V400m Package", Quantity = 1 },
                    new OrderItem { Id = "PART-287001-EU", Name = "Bluetooth Charging Base - V400m", Quantity = 2 },
                    new OrderItem { Id = "PART-620222-EU", Name = "Receipt Roll", Quantity = 20 },
                ],
            },
        });
    // TODO: Handle 'response' of type TerminalOrder
}
catch (ApiException<UpdateMerchantTerminalOrderError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[UpdateMerchantTerminalOrderRequest](src/AdyenApIs/Requests/TerminalOrdersMerchantLevel/UpdateMerchantTerminalOrderRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TerminalOrder](src/AdyenApIs/Models/TerminalOrder.cs)</code>

**OnError**: <code>[ApiException](src/AdyenApIs/Core/Exceptions/ApiException.cs)&lt;[UpdateMerchantTerminalOrderError](src/AdyenApIs/Errors/UpdateMerchantTerminalOrderError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## TerminalSettingsCompanyLevel

> Source: [TerminalSettingsCompanyLevel](src/AdyenApIs/Api/TerminalSettingsCompanyLevel.cs)

<details>
<summary><code>Task&lt;Logo&gt; GetCompanyTerminalLogo(GetCompanyTerminalLogoRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the logo that is configured for a specific payment terminal model at the company identified in the path. 

The logo is returned as a Base64-encoded string. You need to Base64-decode the string to get the actual image file. 
This logo applies to all terminals of the specified model under the company, unless a different logo is configured at a lower level (merchant account, store, or individual terminal).

To make this request, your API credential must have one of the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Terminal settings read
* Management API—Terminal settings read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TerminalSettingsCompanyLevel.GetCompanyTerminalLogo(new GetCompanyTerminalLogoRequest
    {
        CompanyId = "some example string",
        Model = "some example string",
    });
    // TODO: Handle 'response' of type Logo
}
catch (ApiException<GetCompanyTerminalLogoError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetCompanyTerminalLogoRequest](src/AdyenApIs/Requests/TerminalSettingsCompanyLevel/GetCompanyTerminalLogoRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Logo](src/AdyenApIs/Models/Logo.cs)</code>

**OnError**: <code>[ApiException](src/AdyenApIs/Core/Exceptions/ApiException.cs)&lt;[GetCompanyTerminalLogoError](src/AdyenApIs/Errors/GetCompanyTerminalLogoError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TerminalSettings&gt; GetCompanyTerminalSettings(GetCompanyTerminalSettingsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the payment terminal settings that are configured for the company identified in the path. These settings apply to all terminals under the company, unless different values are configured at a lower level (merchant account, store, or individual terminal).

To make this request, your API credential must have one of the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Terminal settings read
* Management API—Terminal settings read and write

For [sensitive terminal settings](https://docs.adyen.com/point-of-sale/automating-terminal-management/configure-terminals-api#sensitive-terminal-settings), your API credential must have the following role:
* Management API—Terminal settings Advanced read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TerminalSettingsCompanyLevel.GetCompanyTerminalSettings(
        new GetCompanyTerminalSettingsRequest { CompanyId = "some example string" });
    // TODO: Handle 'response' of type TerminalSettings
}
catch (ApiException<GetCompanyTerminalSettingsError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetCompanyTerminalSettingsRequest](src/AdyenApIs/Requests/TerminalSettingsCompanyLevel/GetCompanyTerminalSettingsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TerminalSettings](src/AdyenApIs/Models/TerminalSettings.cs)</code>

**OnError**: <code>[ApiException](src/AdyenApIs/Core/Exceptions/ApiException.cs)&lt;[GetCompanyTerminalSettingsError](src/AdyenApIs/Errors/GetCompanyTerminalSettingsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Logo&gt; UpdateCompanyTerminalLogo(UpdateCompanyTerminalLogoRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates the logo that is configured for a specific payment terminal model at the company identified in the path. You can update the logo for only one terminal model at a time.
This logo applies to all terminals of the specified model under the company, unless a different logo is configured at a lower level (merchant account, store, or individual terminal). 
* To change the logo, specify the image file as a Base64-encoded string.
* To restore the logo inherited from the Adyen PSP level, specify an empty logo value.

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Terminal settings read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TerminalSettingsCompanyLevel.UpdateCompanyTerminalLogo(
        new UpdateCompanyTerminalLogoRequest
        {
            CompanyId = "some example string",
            Model = "some example string",
            Body = new Logo { Data = "" },
        });
    // TODO: Handle 'response' of type Logo
}
catch (ApiException<UpdateCompanyTerminalLogoError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[UpdateCompanyTerminalLogoRequest](src/AdyenApIs/Requests/TerminalSettingsCompanyLevel/UpdateCompanyTerminalLogoRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Logo](src/AdyenApIs/Models/Logo.cs)</code>

**OnError**: <code>[ApiException](src/AdyenApIs/Core/Exceptions/ApiException.cs)&lt;[UpdateCompanyTerminalLogoError](src/AdyenApIs/Errors/UpdateCompanyTerminalLogoError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TerminalSettings&gt; UpdateCompanyTerminalSettings(UpdateCompanyTerminalSettingsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates payment terminal settings for the company identified in the path. These settings apply to all terminals under the company, unless different values are configured at a lower level (merchant account, store, or individual terminal).

* To change a parameter value, include the full object that contains the parameter, even if you don't want to change all parameters in the object.
* To restore a parameter value inherited from the Adyen PSP level, include the full object that contains the parameter, and specify an empty value for the parameter or omit the parameter.
* Objects that are not included in the request are not updated.

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Terminal settings read and write

For [sensitive terminal settings](https://docs.adyen.com/point-of-sale/automating-terminal-management/configure-terminals-api#sensitive-terminal-settings), your API credential must have the following role:
* Management API—Terminal settings Advanced read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TerminalSettingsCompanyLevel.UpdateCompanyTerminalSettings(
        new UpdateCompanyTerminalSettingsRequest
        {
            CompanyId = "some example string",
            Body = new TerminalSettings
            {
                WifiProfiles = new WifiProfiles
                {
                    Profiles = [
                        new Profile
                        {
                            AuthType = "wpa-eap",
                            AutoWifi = false,
                            BssType = "infra",
                            Channel = 0,
                            DefaultProfile = true,
                            Eap = "peap",
                            EapCaCert = new File { Data = data, Name = name },
                            EapIdentity = "admin",
                            EapIntermediateCert = new File { Data = data, Name = name },
                            EapPwd = "EAP_PEAP_PASSWORD",
                            HiddenSsid = false,
                            Name = "Profile-eap-peap-1",
                            Ssid = "your-network",
                            Wsec = "ccmp",
                        },
                        new Profile
                        {
                            AuthType = "wpa-psk",
                            AutoWifi = false,
                            BssType = "infra",
                            Channel = 0,
                            DefaultProfile = false,
                            HiddenSsid = false,
                            Name = "Profile-guest-wifi",
                            Psk = "WIFI_PASSWORD",
                            Ssid = "your-network",
                            Wsec = "ccmp",
                        },
                    ],
                    Settings = new SettingsWifiProfiles { Band = "2.4GHz", Roaming = true, Timeout = 5 },
                },
            },
        });
    // TODO: Handle 'response' of type TerminalSettings
}
catch (ApiException<UpdateCompanyTerminalSettingsError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[UpdateCompanyTerminalSettingsRequest](src/AdyenApIs/Requests/TerminalSettingsCompanyLevel/UpdateCompanyTerminalSettingsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TerminalSettings](src/AdyenApIs/Models/TerminalSettings.cs)</code>

**OnError**: <code>[ApiException](src/AdyenApIs/Core/Exceptions/ApiException.cs)&lt;[UpdateCompanyTerminalSettingsError](src/AdyenApIs/Errors/UpdateCompanyTerminalSettingsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## TerminalSettingsMerchantLevel

> Source: [TerminalSettingsMerchantLevel](src/AdyenApIs/Api/TerminalSettingsMerchantLevel.cs)

<details>
<summary><code>Task&lt;Logo&gt; GetMerchantTerminalLogo(GetMerchantTerminalLogoRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the logo that is configured for a specific payment terminal model at the merchant account identified in the path. 
The logo is returned as a Base64-encoded string. You need to Base64-decode the string to get the actual image file. 
This logo applies to all terminals of the specified model under the merchant account, unless a different logo is configured at a lower level (store or individual terminal).

To make this request, your API credential must have one of the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Terminal settings read
* Management API—Terminal settings read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TerminalSettingsMerchantLevel.GetMerchantTerminalLogo(new GetMerchantTerminalLogoRequest
    {
        MerchantId = "some example string",
        Model = "some example string",
    });
    // TODO: Handle 'response' of type Logo
}
catch (ApiException<GetMerchantTerminalLogoError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetMerchantTerminalLogoRequest](src/AdyenApIs/Requests/TerminalSettingsMerchantLevel/GetMerchantTerminalLogoRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Logo](src/AdyenApIs/Models/Logo.cs)</code>

**OnError**: <code>[ApiException](src/AdyenApIs/Core/Exceptions/ApiException.cs)&lt;[GetMerchantTerminalLogoError](src/AdyenApIs/Errors/GetMerchantTerminalLogoError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TerminalSettings&gt; GetMerchantTerminalSettings(GetMerchantTerminalSettingsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the payment terminal settings that are configured for the merchant account identified in the path. These settings apply to all terminals under the merchant account unless different values are configured at a lower level (store or individual terminal).

To make this request, your API credential must have one of the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Terminal settings read
* Management API—Terminal settings read and write

For [sensitive terminal settings](https://docs.adyen.com/point-of-sale/automating-terminal-management/configure-terminals-api#sensitive-terminal-settings), your API credential must have the following role:
* Management API—Terminal settings Advanced read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TerminalSettingsMerchantLevel.GetMerchantTerminalSettings(
        new GetMerchantTerminalSettingsRequest { MerchantId = "some example string" });
    // TODO: Handle 'response' of type TerminalSettings
}
catch (ApiException<GetMerchantTerminalSettingsError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetMerchantTerminalSettingsRequest](src/AdyenApIs/Requests/TerminalSettingsMerchantLevel/GetMerchantTerminalSettingsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TerminalSettings](src/AdyenApIs/Models/TerminalSettings.cs)</code>

**OnError**: <code>[ApiException](src/AdyenApIs/Core/Exceptions/ApiException.cs)&lt;[GetMerchantTerminalSettingsError](src/AdyenApIs/Errors/GetMerchantTerminalSettingsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Logo&gt; UpdateMerchantTerminalLogo(UpdateMerchantTerminalLogoRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates the logo for a specific payment terminal model at the merchant account identified in the path. You can update the logo for only one terminal model at a time. 
This logo applies to all terminals of the specified model under the merchant account, unless a different logo is configured at a lower level (store or individual terminal).

* To change the logo, specify the image file as a Base64-encoded string.
* To restore the logo inherited from the company account, specify an empty logo value.

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Terminal settings read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TerminalSettingsMerchantLevel.UpdateMerchantTerminalLogo(
        new UpdateMerchantTerminalLogoRequest
        {
            MerchantId = "some example string",
            Model = "some example string",
            Body = new Logo { Data = "" },
        });
    // TODO: Handle 'response' of type Logo
}
catch (ApiException<UpdateMerchantTerminalLogoError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[UpdateMerchantTerminalLogoRequest](src/AdyenApIs/Requests/TerminalSettingsMerchantLevel/UpdateMerchantTerminalLogoRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Logo](src/AdyenApIs/Models/Logo.cs)</code>

**OnError**: <code>[ApiException](src/AdyenApIs/Core/Exceptions/ApiException.cs)&lt;[UpdateMerchantTerminalLogoError](src/AdyenApIs/Errors/UpdateMerchantTerminalLogoError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TerminalSettings&gt; UpdateMerchantTerminalSettings(UpdateMerchantTerminalSettingsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates payment terminal settings for the merchant account identified in the path.
These settings apply to all terminals under the merchant account, unless different values are configured at a lower level (store or individual terminal).

* To change a parameter value, include the full object that contains the parameter, even if you don't want to change all parameters in the object.
* To restore a parameter value inherited from a higher level, include the full object that contains the parameter, and specify an empty value for the parameter or omit the parameter.
* Objects that are not included in the request are not updated.

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Terminal settings read and write



For [sensitive terminal settings](https://docs.adyen.com/point-of-sale/automating-terminal-management/configure-terminals-api#sensitive-terminal-settings), your API credential must have the following role:
* Management API—Terminal settings Advanced read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TerminalSettingsMerchantLevel.UpdateMerchantTerminalSettings(
        new UpdateMerchantTerminalSettingsRequest
        {
            MerchantId = "some example string",
            Body = new TerminalSettings
            {
                WifiProfiles = new WifiProfiles
                {
                    Profiles = [
                        new Profile
                        {
                            AuthType = "wpa-eap",
                            AutoWifi = false,
                            BssType = "infra",
                            Channel = 0,
                            DefaultProfile = true,
                            Eap = "peap",
                            EapCaCert = new File { Data = data, Name = name },
                            EapIdentity = "admin",
                            EapIntermediateCert = new File { Data = data, Name = name },
                            EapPwd = "EAP_PEAP_PASSWORD",
                            HiddenSsid = false,
                            Name = "Profile-eap-peap-1",
                            Ssid = "your-network",
                            Wsec = "ccmp",
                        },
                        new Profile
                        {
                            AuthType = "wpa-psk",
                            AutoWifi = false,
                            BssType = "infra",
                            Channel = 0,
                            DefaultProfile = false,
                            HiddenSsid = false,
                            Name = "Profile-guest-wifi",
                            Psk = "WIFI_PASSWORD",
                            Ssid = "your-network",
                            Wsec = "ccmp",
                        },
                    ],
                    Settings = new SettingsWifiProfiles { Band = "2.4GHz", Roaming = true, Timeout = 5 },
                },
            },
        });
    // TODO: Handle 'response' of type TerminalSettings
}
catch (ApiException<UpdateMerchantTerminalSettingsError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[UpdateMerchantTerminalSettingsRequest](src/AdyenApIs/Requests/TerminalSettingsMerchantLevel/UpdateMerchantTerminalSettingsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TerminalSettings](src/AdyenApIs/Models/TerminalSettings.cs)</code>

**OnError**: <code>[ApiException](src/AdyenApIs/Core/Exceptions/ApiException.cs)&lt;[UpdateMerchantTerminalSettingsError](src/AdyenApIs/Errors/UpdateMerchantTerminalSettingsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## TerminalSettingsStoreLevel

> Source: [TerminalSettingsStoreLevel](src/AdyenApIs/Api/TerminalSettingsStoreLevel.cs)

<details>
<summary><code>Task&lt;Logo&gt; GetMerchantStoreTerminalLogoByReference(GetMerchantStoreTerminalLogoByReferenceRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the logo that is configured for a specific payment terminal model at the store identified in the path. 
The logo is returned as a Base64-encoded string. You need to Base64-decode the string to get the actual image file. 
This logo applies to all terminals of the specified model under the store, unless a different logo is configured for an individual terminal.

To make this request, your API credential must have one of the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Terminal settings read
* Management API—Terminal settings read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TerminalSettingsStoreLevel.GetMerchantStoreTerminalLogoByReference(
        new GetMerchantStoreTerminalLogoByReferenceRequest
        {
            MerchantId = "some example string",
            Reference = "some example string",
            Model = "some example string",
        });
    // TODO: Handle 'response' of type Logo
}
catch (ApiException<GetMerchantStoreTerminalLogoByReferenceError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetMerchantStoreTerminalLogoByReferenceRequest](src/AdyenApIs/Requests/TerminalSettingsStoreLevel/GetMerchantStoreTerminalLogoByReferenceRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Logo](src/AdyenApIs/Models/Logo.cs)</code>

**OnError**: <code>[ApiException](src/AdyenApIs/Core/Exceptions/ApiException.cs)&lt;[GetMerchantStoreTerminalLogoByReferenceError](src/AdyenApIs/Errors/GetMerchantStoreTerminalLogoByReferenceError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TerminalSettings&gt; GetMerchantStoreTerminalSettingsByReference(GetMerchantStoreTerminalSettingsByReferenceRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the payment terminal settings that are configured for the store identified in the path. These settings apply to all terminals under the store unless different values are configured for an individual terminal.

To make this request, your API credential must have one of the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Terminal settings read
* Management API—Terminal settings read and write

For [sensitive terminal settings](https://docs.adyen.com/point-of-sale/automating-terminal-management/configure-terminals-api#sensitive-terminal-settings), your API credential must have the following role:
* Management API—Terminal settings Advanced read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TerminalSettingsStoreLevel.GetMerchantStoreTerminalSettingsByReference(
        new GetMerchantStoreTerminalSettingsByReferenceRequest
        {
            MerchantId = "some example string",
            Reference = "some example string",
        });
    // TODO: Handle 'response' of type TerminalSettings
}
catch (ApiException<GetMerchantStoreTerminalSettingsByReferenceError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetMerchantStoreTerminalSettingsByReferenceRequest](src/AdyenApIs/Requests/TerminalSettingsStoreLevel/GetMerchantStoreTerminalSettingsByReferenceRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TerminalSettings](src/AdyenApIs/Models/TerminalSettings.cs)</code>

**OnError**: <code>[ApiException](src/AdyenApIs/Core/Exceptions/ApiException.cs)&lt;[GetMerchantStoreTerminalSettingsByReferenceError](src/AdyenApIs/Errors/GetMerchantStoreTerminalSettingsByReferenceError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Logo&gt; GetStoreTerminalLogo(GetStoreTerminalLogoRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the logo that is configured for a specific payment terminal model at the store identified in the path. 
The logo is returned as a Base64-encoded string. You need to Base64-decode the string to get the actual image file. 
This logo applies to all terminals of that model under the store unless a different logo is configured for an individual terminal.

To make this request, your API credential must have one of the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Terminal settings read
* Management API—Terminal settings read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TerminalSettingsStoreLevel.GetStoreTerminalLogo(new GetStoreTerminalLogoRequest
    {
        StoreId = "some example string",
        Model = "some example string",
    });
    // TODO: Handle 'response' of type Logo
}
catch (ApiException<GetStoreTerminalLogoError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetStoreTerminalLogoRequest](src/AdyenApIs/Requests/TerminalSettingsStoreLevel/GetStoreTerminalLogoRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Logo](src/AdyenApIs/Models/Logo.cs)</code>

**OnError**: <code>[ApiException](src/AdyenApIs/Core/Exceptions/ApiException.cs)&lt;[GetStoreTerminalLogoError](src/AdyenApIs/Errors/GetStoreTerminalLogoError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TerminalSettings&gt; GetStoreTerminalSettings(GetStoreTerminalSettingsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the payment terminal settings that are configured for the store identified in the path. These settings apply to all terminals under the store unless different values are configured for an individual terminal.

To make this request, your API credential must have one of the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Terminal settings read
* Management API—Terminal settings read and write

For [sensitive terminal settings](https://docs.adyen.com/point-of-sale/automating-terminal-management/configure-terminals-api#sensitive-terminal-settings), your API credential must have the following role:
* Management API—Terminal settings Advanced read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TerminalSettingsStoreLevel.GetStoreTerminalSettings(new GetStoreTerminalSettingsRequest
    {
        StoreId = "some example string",
    });
    // TODO: Handle 'response' of type TerminalSettings
}
catch (ApiException<GetStoreTerminalSettingsError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetStoreTerminalSettingsRequest](src/AdyenApIs/Requests/TerminalSettingsStoreLevel/GetStoreTerminalSettingsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TerminalSettings](src/AdyenApIs/Models/TerminalSettings.cs)</code>

**OnError**: <code>[ApiException](src/AdyenApIs/Core/Exceptions/ApiException.cs)&lt;[GetStoreTerminalSettingsError](src/AdyenApIs/Errors/GetStoreTerminalSettingsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Logo&gt; UpdateMerchantStoreTerminalLogoByReference(UpdateMerchantStoreTerminalLogoByReferenceRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates the logo that is configured for a specific payment terminal model at the store identified in the path. You can update the logo for only one terminal model at a time.
This logo applies to all terminals of the specified model under the store, unless a different logo is configured for an individual terminal. 

* To change the logo, specify the image file as a Base64-encoded string.
* To restore the logo inherited from a higher level (merchant or company account), specify an empty logo value.

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Terminal settings read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TerminalSettingsStoreLevel.UpdateMerchantStoreTerminalLogoByReference(
        new UpdateMerchantStoreTerminalLogoByReferenceRequest
        {
            MerchantId = "some example string",
            Reference = "some example string",
            Model = "some example string",
            Body = new Logo { Data = "" },
        });
    // TODO: Handle 'response' of type Logo
}
catch (ApiException<UpdateMerchantStoreTerminalLogoByReferenceError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[UpdateMerchantStoreTerminalLogoByReferenceRequest](src/AdyenApIs/Requests/TerminalSettingsStoreLevel/UpdateMerchantStoreTerminalLogoByReferenceRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Logo](src/AdyenApIs/Models/Logo.cs)</code>

**OnError**: <code>[ApiException](src/AdyenApIs/Core/Exceptions/ApiException.cs)&lt;[UpdateMerchantStoreTerminalLogoByReferenceError](src/AdyenApIs/Errors/UpdateMerchantStoreTerminalLogoByReferenceError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TerminalSettings&gt; UpdateMerchantStoreTerminalSettingsByReference(UpdateMerchantStoreTerminalSettingsByReferenceRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates payment terminal settings for the store identified in the path. These settings apply to all terminals under the store, unless different values are configured for an individual terminal.

* To change a parameter value, include the full object that contains the parameter, even if you don't want to change all parameters in the object.
* To restore a parameter value inherited from a higher level, include the full object that contains the parameter, and specify an empty value for the parameter or omit the parameter.
* Objects that are not included in the request are not updated.

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Terminal settings read and write

For [sensitive terminal settings](https://docs.adyen.com/point-of-sale/automating-terminal-management/configure-terminals-api#sensitive-terminal-settings), your API credential must have the following role:
* Management API—Terminal settings Advanced read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TerminalSettingsStoreLevel.UpdateMerchantStoreTerminalSettingsByReference(
        new UpdateMerchantStoreTerminalSettingsByReferenceRequest
        {
            MerchantId = "some example string",
            Reference = "some example string",
            Body = new TerminalSettings
            {
                WifiProfiles = new WifiProfiles
                {
                    Profiles = [
                        new Profile
                        {
                            AuthType = "wpa-eap",
                            AutoWifi = false,
                            BssType = "infra",
                            Channel = 0,
                            DefaultProfile = true,
                            Eap = "peap",
                            EapCaCert = new File { Data = data, Name = name },
                            EapIdentity = "admin",
                            EapIntermediateCert = new File { Data = data, Name = name },
                            EapPwd = "EAP_PEAP_PASSWORD",
                            Name = "Profile-eap-peap-1",
                            Ssid = "your-network",
                            Wsec = "ccmp",
                        },
                        new Profile
                        {
                            AuthType = "wpa-psk",
                            AutoWifi = false,
                            BssType = "infra",
                            Channel = 0,
                            DefaultProfile = false,
                            Name = "Profile-guest-wifi",
                            Psk = "WIFI_PASSWORD",
                            Ssid = "your-network",
                            Wsec = "ccmp",
                        },
                    ],
                    Settings = new SettingsWifiProfiles { Band = "2.4GHz", Roaming = true, Timeout = 5 },
                },
            },
        });
    // TODO: Handle 'response' of type TerminalSettings
}
catch (ApiException<UpdateMerchantStoreTerminalSettingsByReferenceError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[UpdateMerchantStoreTerminalSettingsByReferenceRequest](src/AdyenApIs/Requests/TerminalSettingsStoreLevel/UpdateMerchantStoreTerminalSettingsByReferenceRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TerminalSettings](src/AdyenApIs/Models/TerminalSettings.cs)</code>

**OnError**: <code>[ApiException](src/AdyenApIs/Core/Exceptions/ApiException.cs)&lt;[UpdateMerchantStoreTerminalSettingsByReferenceError](src/AdyenApIs/Errors/UpdateMerchantStoreTerminalSettingsByReferenceError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Logo&gt; UpdateStoreTerminalLogo(UpdateStoreTerminalLogoRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates the logo that is configured for a specific payment terminal model at the store identified in the path. You can update the logo for only one terminal model at a time.
This logo applies to all terminals of the specified model under the store, unless a different logo is configured for an individual terminal. 

* To change the logo, specify the image file as a Base64-encoded string.
* To restore the logo inherited from a higher level (merchant or company account), specify an empty logo value.

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Terminal settings read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TerminalSettingsStoreLevel.UpdateStoreTerminalLogo(new UpdateStoreTerminalLogoRequest
    {
        StoreId = "some example string",
        Model = "some example string",
        Body = new Logo { Data = "" },
    });
    // TODO: Handle 'response' of type Logo
}
catch (ApiException<UpdateStoreTerminalLogoError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[UpdateStoreTerminalLogoRequest](src/AdyenApIs/Requests/TerminalSettingsStoreLevel/UpdateStoreTerminalLogoRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Logo](src/AdyenApIs/Models/Logo.cs)</code>

**OnError**: <code>[ApiException](src/AdyenApIs/Core/Exceptions/ApiException.cs)&lt;[UpdateStoreTerminalLogoError](src/AdyenApIs/Errors/UpdateStoreTerminalLogoError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TerminalSettings&gt; UpdateStoreTerminalSettings(UpdateStoreTerminalSettingsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates payment terminal settings for the store identified in the path. These settings apply to all terminals under the store, unless different values are configured for an individual terminal.

* To change a parameter value, include the full object that contains the parameter, even if you don't want to change all parameters in the object.
* To restore a parameter value inherited from a higher level, include the full object that contains the parameter, and specify an empty value for the parameter or omit the parameter.
* Objects that are not included in the request are not updated.

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Terminal settings read and write

For [sensitive terminal settings](https://docs.adyen.com/point-of-sale/automating-terminal-management/configure-terminals-api#sensitive-terminal-settings), your API credential must have the following role:
* Management API—Terminal settings Advanced read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TerminalSettingsStoreLevel.UpdateStoreTerminalSettings(
        new UpdateStoreTerminalSettingsRequest
        {
            StoreId = "some example string",
            Body = new TerminalSettings
            {
                WifiProfiles = new WifiProfiles
                {
                    Profiles = [
                        new Profile
                        {
                            AuthType = "wpa-eap",
                            AutoWifi = false,
                            BssType = "infra",
                            Channel = 0,
                            DefaultProfile = true,
                            Eap = "peap",
                            EapCaCert = new File { Data = data, Name = name },
                            EapIdentity = "admin",
                            EapIntermediateCert = new File { Data = data, Name = name },
                            EapPwd = "EAP_PEAP_PASSWORD",
                            HiddenSsid = false,
                            Name = "Profile-eap-peap-1",
                            Ssid = "your-network",
                            Wsec = "ccmp",
                        },
                        new Profile
                        {
                            AuthType = "wpa-psk",
                            AutoWifi = false,
                            BssType = "infra",
                            Channel = 0,
                            DefaultProfile = false,
                            HiddenSsid = false,
                            Name = "Profile-guest-wifi",
                            Psk = "WIFI_PASSWORD",
                            Ssid = "your-network",
                            Wsec = "ccmp",
                        },
                    ],
                    Settings = new SettingsWifiProfiles { Band = "2.4GHz", Roaming = true, Timeout = 5 },
                },
            },
        });
    // TODO: Handle 'response' of type TerminalSettings
}
catch (ApiException<UpdateStoreTerminalSettingsError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[UpdateStoreTerminalSettingsRequest](src/AdyenApIs/Requests/TerminalSettingsStoreLevel/UpdateStoreTerminalSettingsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TerminalSettings](src/AdyenApIs/Models/TerminalSettings.cs)</code>

**OnError**: <code>[ApiException](src/AdyenApIs/Core/Exceptions/ApiException.cs)&lt;[UpdateStoreTerminalSettingsError](src/AdyenApIs/Errors/UpdateStoreTerminalSettingsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## TerminalSettingsTerminalLevel

> Source: [TerminalSettingsTerminalLevel](src/AdyenApIs/Api/TerminalSettingsTerminalLevel.cs)

<details>
<summary><code>Task&lt;Logo&gt; GetTerminalLogo(GetTerminalLogoRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the logo that is configured for the payment terminal identified in the path.
The logo is returned as a Base64-encoded string. You need to Base64-decode the string to get the actual image file.

To make this request, your API credential must have one of the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Terminal settings read
* Management API—Terminal settings read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TerminalSettingsTerminalLevel.GetTerminalLogo(new GetTerminalLogoRequest
    {
        TerminalId = "some example string",
    });
    // TODO: Handle 'response' of type Logo
}
catch (ApiException<GetTerminalLogoError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetTerminalLogoRequest](src/AdyenApIs/Requests/TerminalSettingsTerminalLevel/GetTerminalLogoRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Logo](src/AdyenApIs/Models/Logo.cs)</code>

**OnError**: <code>[ApiException](src/AdyenApIs/Core/Exceptions/ApiException.cs)&lt;[GetTerminalLogoError](src/AdyenApIs/Errors/GetTerminalLogoError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TerminalSettings&gt; GetTerminalSettings(GetTerminalSettingsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the settings that are configured for the payment terminal identified in the path.

To make this request, your API credential must have one of the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Terminal settings read
* Management API—Terminal settings read and write

For [sensitive terminal settings](https://docs.adyen.com/point-of-sale/automating-terminal-management/configure-terminals-api#sensitive-terminal-settings), your API credential must have the following role:
* Management API—Terminal settings Advanced read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TerminalSettingsTerminalLevel.GetTerminalSettings(new GetTerminalSettingsRequest
    {
        TerminalId = "some example string",
    });
    // TODO: Handle 'response' of type TerminalSettings
}
catch (ApiException<GetTerminalSettingsError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetTerminalSettingsRequest](src/AdyenApIs/Requests/TerminalSettingsTerminalLevel/GetTerminalSettingsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TerminalSettings](src/AdyenApIs/Models/TerminalSettings.cs)</code>

**OnError**: <code>[ApiException](src/AdyenApIs/Core/Exceptions/ApiException.cs)&lt;[GetTerminalSettingsError](src/AdyenApIs/Errors/GetTerminalSettingsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Logo&gt; UpdateTerminalLogo(UpdateTerminalLogoRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates the logo for the payment terminal identified in the path.

* To change the logo, specify the image file as a Base64-encoded string.
* To restore the logo inherited from a higher level (store, merchant account, or company account), specify an empty logo value.

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Terminal settings read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TerminalSettingsTerminalLevel.UpdateTerminalLogo(new UpdateTerminalLogoRequest
    {
        TerminalId = "some example string",
        Body = new Logo { Data = "" },
    });
    // TODO: Handle 'response' of type Logo
}
catch (ApiException<UpdateTerminalLogoError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[UpdateTerminalLogoRequest](src/AdyenApIs/Requests/TerminalSettingsTerminalLevel/UpdateTerminalLogoRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Logo](src/AdyenApIs/Models/Logo.cs)</code>

**OnError**: <code>[ApiException](src/AdyenApIs/Core/Exceptions/ApiException.cs)&lt;[UpdateTerminalLogoError](src/AdyenApIs/Errors/UpdateTerminalLogoError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TerminalSettings&gt; UpdateTerminalSettings(UpdateTerminalSettingsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates the settings that are configured for the payment terminal identified in the path.

* To change a parameter value, include the full object that contains the parameter, even if you don't want to change all parameters in the object.
* To restore a parameter value inherited from a higher level, include the full object that contains the parameter, and specify an empty value for the parameter or omit the parameter.
* Objects that are not included in the request are not updated.

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Terminal settings read and write

For [sensitive terminal settings](https://docs.adyen.com/point-of-sale/automating-terminal-management/configure-terminals-api#sensitive-terminal-settings), your API credential must have the following role:
* Management API—Terminal settings Advanced read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TerminalSettingsTerminalLevel.UpdateTerminalSettings(new UpdateTerminalSettingsRequest
    {
        TerminalId = "some example string",
        Body = new TerminalSettings
        {
            WifiProfiles = new WifiProfiles
            {
                Profiles = [
                    new Profile
                    {
                        AuthType = "wpa-eap",
                        AutoWifi = false,
                        BssType = "infra",
                        Channel = 0,
                        DefaultProfile = true,
                        Eap = "peap",
                        EapCaCert = new File { Data = data, Name = name },
                        EapIdentity = "admin",
                        EapIntermediateCert = new File { Data = data, Name = name },
                        EapPwd = "EAP_PEAP_PASSWORD",
                        HiddenSsid = false,
                        Name = "Profile-eap-peap-1",
                        Ssid = "your-network",
                        Wsec = "ccmp",
                    },
                    new Profile
                    {
                        AuthType = "wpa-psk",
                        AutoWifi = false,
                        BssType = "infra",
                        Channel = 0,
                        DefaultProfile = false,
                        HiddenSsid = false,
                        Name = "Profile-guest-wifi",
                        Psk = "WIFI_PASSWORD",
                        Ssid = "your-network",
                        Wsec = "ccmp",
                    },
                ],
                Settings = new SettingsWifiProfiles { Band = "2.4GHz", Roaming = true, Timeout = 5 },
            },
        },
    });
    // TODO: Handle 'response' of type TerminalSettings
}
catch (ApiException<UpdateTerminalSettingsError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[UpdateTerminalSettingsRequest](src/AdyenApIs/Requests/TerminalSettingsTerminalLevel/UpdateTerminalSettingsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TerminalSettings](src/AdyenApIs/Models/TerminalSettings.cs)</code>

**OnError**: <code>[ApiException](src/AdyenApIs/Core/Exceptions/ApiException.cs)&lt;[UpdateTerminalSettingsError](src/AdyenApIs/Errors/UpdateTerminalSettingsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## TerminalsTerminalLevel

> Source: [TerminalsTerminalLevel](src/AdyenApIs/Api/TerminalsTerminalLevel.cs)

<details>
<summary><code>Task&lt;ListTerminalsResponse&gt; ListTerminals(ListTerminalsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the payment terminals that the API credential has access to and that match the query parameters. 
To make this request, your API credential must have the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API — Terminal actions read

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TerminalsTerminalLevel.ListTerminals(new ListTerminalsRequest());
    // TODO: Handle 'response' of type ListTerminalsResponse
}
catch (ApiException<ListTerminalsError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ListTerminalsRequest](src/AdyenApIs/Requests/TerminalsTerminalLevel/ListTerminalsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ListTerminalsResponse](src/AdyenApIs/Models/ListTerminalsResponse.cs)</code>

**OnError**: <code>[ApiException](src/AdyenApIs/Core/Exceptions/ApiException.cs)&lt;[ListTerminalsError](src/AdyenApIs/Errors/ListTerminalsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task ReassignTerminal(ReassignTerminalRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Reassigns a payment terminal to a company account, merchant account, merchant account inventory, or a store.

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Assign Terminal

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.TerminalsTerminalLevel.ReassignTerminal(new ReassignTerminalRequest
    {
        TerminalId = "some example string",
        Body = new TerminalReassignmentRequest { Inventory = false, MerchantId = "YOUR_MERCHANT_ID" },
    });
}
catch (ApiException<ReassignTerminalError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ReassignTerminalRequest](src/AdyenApIs/Requests/TerminalsTerminalLevel/ReassignTerminalRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[ApiException](src/AdyenApIs/Core/Exceptions/ApiException.cs)&lt;[ReassignTerminalError](src/AdyenApIs/Errors/ReassignTerminalError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## UsersCompanyLevel

> Source: [UsersCompanyLevel](src/AdyenApIs/Api/UsersCompanyLevel.cs)

<details>
<summary><code>Task&lt;CreateCompanyUserResponse&gt; CreateCompanyUser(CreateCompanyUserOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates the user for the `companyId` identified in the path.

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Users read and write

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.UsersCompanyLevel.CreateCompanyUser(new CreateCompanyUserOperationRequest
    {
        CompanyId = "some example string",
        Body = new CreateCompanyUserRequest
        {
            AssociatedMerchantAccounts = ["YOUR_MERCHANT_ACCOUNT"],
            Email = "john.smith@example.com",
            LoginMethod = "Email",
            Name = new NameCreateCompanyUserRequest { FirstName = "John", LastName = "Smith" },
            Roles = ["Merchant standard role", "Merchant admin"],
            TimeZoneCode = "Europe/Amsterdam",
            Username = "johnsmith",
        },
    });
    // TODO: Handle 'response' of type CreateCompanyUserResponse
}
catch (ApiException<CreateCompanyUserError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CreateCompanyUserOperationRequest](src/AdyenApIs/Requests/UsersCompanyLevel/CreateCompanyUserOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CreateCompanyUserResponse](src/AdyenApIs/Models/CreateCompanyUserResponse.cs)</code>

**OnError**: <code>[ApiException](src/AdyenApIs/Core/Exceptions/ApiException.cs)&lt;[CreateCompanyUserError](src/AdyenApIs/Errors/CreateCompanyUserError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CompanyUser&gt; GetCompanyUser(GetCompanyUserRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns user details for the `userId` and the `companyId` identified in the path.

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Users read and write

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.UsersCompanyLevel.GetCompanyUser(new GetCompanyUserRequest
    {
        CompanyId = "some example string",
        UserId = "some example string",
    });
    // TODO: Handle 'response' of type CompanyUser
}
catch (ApiException<GetCompanyUserError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetCompanyUserRequest](src/AdyenApIs/Requests/UsersCompanyLevel/GetCompanyUserRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CompanyUser](src/AdyenApIs/Models/CompanyUser.cs)</code>

**OnError**: <code>[ApiException](src/AdyenApIs/Core/Exceptions/ApiException.cs)&lt;[GetCompanyUserError](src/AdyenApIs/Errors/GetCompanyUserError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ListCompanyUsersResponse&gt; ListCompanyUsers(ListCompanyUsersRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the list of users for the `companyId` identified in the path.

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Users read and write

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.UsersCompanyLevel.ListCompanyUsers(new ListCompanyUsersRequest
    {
        CompanyId = "some example string",
    });
    // TODO: Handle 'response' of type ListCompanyUsersResponse
}
catch (ApiException<ListCompanyUsersError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ListCompanyUsersRequest](src/AdyenApIs/Requests/UsersCompanyLevel/ListCompanyUsersRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ListCompanyUsersResponse](src/AdyenApIs/Models/ListCompanyUsersResponse.cs)</code>

**OnError**: <code>[ApiException](src/AdyenApIs/Core/Exceptions/ApiException.cs)&lt;[ListCompanyUsersError](src/AdyenApIs/Errors/ListCompanyUsersError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CompanyUser&gt; UpdateCompanyUser(UpdateCompanyUserOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates user details for the `userId` and the `companyId` identified in the path.

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Users read and write

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.UsersCompanyLevel.UpdateCompanyUser(new UpdateCompanyUserOperationRequest
    {
        CompanyId = "some example string",
        UserId = "some example string",
    });
    // TODO: Handle 'response' of type CompanyUser
}
catch (ApiException<UpdateCompanyUserError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[UpdateCompanyUserOperationRequest](src/AdyenApIs/Requests/UsersCompanyLevel/UpdateCompanyUserOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CompanyUser](src/AdyenApIs/Models/CompanyUser.cs)</code>

**OnError**: <code>[ApiException](src/AdyenApIs/Core/Exceptions/ApiException.cs)&lt;[UpdateCompanyUserError](src/AdyenApIs/Errors/UpdateCompanyUserError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## UsersMerchantLevel

> Source: [UsersMerchantLevel](src/AdyenApIs/Api/UsersMerchantLevel.cs)

<details>
<summary><code>Task&lt;CreateUserResponse&gt; CreateMerchantUser(CreateMerchantUserOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates a user for the `merchantId` specified in the path.

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Users read and write

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.UsersMerchantLevel.CreateMerchantUser(new CreateMerchantUserOperationRequest
    {
        MerchantId = "some example string",
        Body = new CreateMerchantUserRequest
        {
            Email = "john.smith@example.com",
            LoginMethod = "Email",
            Name = new NameCreateMerchantUserRequest { FirstName = "John", LastName = "Smith" },
            Roles = ["Merchant standard role"],
            TimeZoneCode = "Europe/Amsterdam",
            Username = "johnsmith",
        },
    });
    // TODO: Handle 'response' of type CreateUserResponse
}
catch (ApiException<CreateMerchantUserError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CreateMerchantUserOperationRequest](src/AdyenApIs/Requests/UsersMerchantLevel/CreateMerchantUserOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CreateUserResponse](src/AdyenApIs/Models/CreateUserResponse.cs)</code>

**OnError**: <code>[ApiException](src/AdyenApIs/Core/Exceptions/ApiException.cs)&lt;[CreateMerchantUserError](src/AdyenApIs/Errors/CreateMerchantUserError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;User&gt; GetMerchantUser(GetMerchantUserRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns user details for the `userId` and the `merchantId` specified in the path.

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Users read and write

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.UsersMerchantLevel.GetMerchantUser(new GetMerchantUserRequest
    {
        MerchantId = "some example string",
        UserId = "some example string",
    });
    // TODO: Handle 'response' of type User
}
catch (ApiException<GetMerchantUserError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetMerchantUserRequest](src/AdyenApIs/Requests/UsersMerchantLevel/GetMerchantUserRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[User](src/AdyenApIs/Models/User.cs)</code>

**OnError**: <code>[ApiException](src/AdyenApIs/Core/Exceptions/ApiException.cs)&lt;[GetMerchantUserError](src/AdyenApIs/Errors/GetMerchantUserError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ListMerchantUsersResponse&gt; ListMerchantUsers(ListMerchantUsersRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a list of users associated with the `merchantId` specified in the path.

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Users read and write

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.UsersMerchantLevel.ListMerchantUsers(new ListMerchantUsersRequest
    {
        MerchantId = "some example string",
    });
    // TODO: Handle 'response' of type ListMerchantUsersResponse
}
catch (ApiException<ListMerchantUsersError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ListMerchantUsersRequest](src/AdyenApIs/Requests/UsersMerchantLevel/ListMerchantUsersRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ListMerchantUsersResponse](src/AdyenApIs/Models/ListMerchantUsersResponse.cs)</code>

**OnError**: <code>[ApiException](src/AdyenApIs/Core/Exceptions/ApiException.cs)&lt;[ListMerchantUsersError](src/AdyenApIs/Errors/ListMerchantUsersError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;User&gt; UpdateMerchantUser(UpdateMerchantUserOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates user details for the `userId` and the `merchantId` specified in the path.

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Users read and write

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.UsersMerchantLevel.UpdateMerchantUser(new UpdateMerchantUserOperationRequest
    {
        MerchantId = "some example string",
        UserId = "some example string",
    });
    // TODO: Handle 'response' of type User
}
catch (ApiException<UpdateMerchantUserError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[UpdateMerchantUserOperationRequest](src/AdyenApIs/Requests/UsersMerchantLevel/UpdateMerchantUserOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[User](src/AdyenApIs/Models/User.cs)</code>

**OnError**: <code>[ApiException](src/AdyenApIs/Core/Exceptions/ApiException.cs)&lt;[UpdateMerchantUserError](src/AdyenApIs/Errors/UpdateMerchantUserError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Utility

> Source: [Utility](src/AdyenApIs/Api/Utility.cs)

<details>
<summary><code>Task&lt;UtilityResponse&gt; GenerateOriginKeys(GenerateOriginKeysRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This operation takes the origin domains and returns a JSON object containing the corresponding origin keys for the domains. 
> If you're still using origin key for your Web Drop-in or Components integration, we recommend [switching to client key](https://docs.adyen.com/development-resources/client-side-authentication/migrate-from-origin-key-to-client-key). This allows you to use a single key for all origins, add or remove origins without generating a new key, and detect the card type from the number entered in your payment form.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Utility.GenerateOriginKeys(new GenerateOriginKeysRequest
    {
        IdempotencyKey = "37ca9c97-d1d1-4c62-89e8-706891a563ed",
        Body = new UtilityRequest
        {
            OriginDomains = [
                "https://www.your-domain1.com",
                "https://www.your-domain2.com",
                "https://www.your-domain3.com",
            ],
        },
    });
    // TODO: Handle 'response' of type UtilityResponse
}
catch (ApiException<GenerateOriginKeysError> ex)
{
    if (ex.Error.TryGetServiceError(out var error))
    {
        // TODO: Handle 'error' of type ServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GenerateOriginKeysRequest](src/AdyenApIs/Requests/Utility/GenerateOriginKeysRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UtilityResponse](src/AdyenApIs/Models/UtilityResponse.cs)</code>

**OnError**: <code>[ApiException](src/AdyenApIs/Core/Exceptions/ApiException.cs)&lt;[GenerateOriginKeysError](src/AdyenApIs/Errors/GenerateOriginKeysError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ApplePaySessionResponse&gt; GetApplePaySession(GetApplePaySessionRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

You need to use this endpoint if you have an API-only integration with Apple Pay which uses Adyen's Apple Pay certificate.

The endpoint returns the Apple Pay session data which you need to complete the [Apple Pay session validation](https://docs.adyen.com/payment-methods/apple-pay/api-only?tab=adyen-certificate-validation_1#complete-apple-pay-session-validation).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Utility.GetApplePaySession(new GetApplePaySessionRequest
    {
        IdempotencyKey = "37ca9c97-d1d1-4c62-89e8-706891a563ed",
        Body = new ApplePaySessionRequest
        {
            DisplayName = "YOUR_MERCHANT_NAME",
            DomainName = "YOUR_DOMAIN_NAME",
            MerchantIdentifier = "YOUR_MERCHANT_ID",
        },
    });
    // TODO: Handle 'response' of type ApplePaySessionResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetApplePaySessionRequest](src/AdyenApIs/Requests/Utility/GetApplePaySessionRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ApplePaySessionResponse](src/AdyenApIs/Models/ApplePaySessionResponse.cs)</code>

**OnError**: <code>[ApiException](src/AdyenApIs/Core/Exceptions/ApiException.cs)&lt;[RawError](src/AdyenApIs/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PaypalUpdateOrderResponse&gt; UpdatePayPalOrder(UpdatePayPalOrderRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates the order for PayPal Express Checkout. This can be used to update the PayPal lightbox with an updated amount and delivery methods based on the delivery address.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Utility.UpdatePayPalOrder(new UpdatePayPalOrderRequest
    {
        IdempotencyKey = "37ca9c97-d1d1-4c62-89e8-706891a563ed",
        Body = new PaypalUpdateOrderRequest
        {
            Amount = new Amount { Currency = "EUR", Value = 12000L },
            DeliveryMethods = [
                new DeliveryMethod
                {
                    Amount = new Amount { Currency = "EUR", Value = 1000L },
                    Description = "Express Shipping",
                    Reference = "1",
                    Selected = true,
                    Type = TypeDeliveryMethod.Shipping,
                },
                new DeliveryMethod
                {
                    Amount = new Amount { Currency = "EUR", Value = 500L },
                    Description = "Standard Ground",
                    Reference = "2",
                    Selected = false,
                    Type = TypeDeliveryMethod.Shipping,
                },
            ],
            PaymentData = "po7XZ...",
            PspReference = "DZ4DPSHB4WD2WN82",
        },
    });
    // TODO: Handle 'response' of type PaypalUpdateOrderResponse
}
catch (ApiException<UpdatePayPalOrderError> ex)
{
    if (ex.Error.TryGetServiceError(out var error))
    {
        // TODO: Handle 'error' of type ServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[UpdatePayPalOrderRequest](src/AdyenApIs/Requests/Utility/UpdatePayPalOrderRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PaypalUpdateOrderResponse](src/AdyenApIs/Models/PaypalUpdateOrderResponse.cs)</code>

**OnError**: <code>[ApiException](src/AdyenApIs/Core/Exceptions/ApiException.cs)&lt;[UpdatePayPalOrderError](src/AdyenApIs/Errors/UpdatePayPalOrderError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ValidateShopperIdResponse&gt; ValidateShopperId(ValidateShopperIdOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Validates the shopperId.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Utility.ValidateShopperId(new ValidateShopperIdOperationRequest
    {
        Body = new ValidateShopperIdRequest
        {
            MerchantAccount = "some example string",
            PaymentMethod = new ShopperIdPaymentMethodValidateShopperIdRequest(),
        },
    });
    // TODO: Handle 'response' of type ValidateShopperIdResponse
}
catch (ApiException<ValidateShopperIdError> ex)
{
    if (ex.Error.TryGetDefaultErrorResponseEntity(out var error))
    {
        // TODO: Handle 'error' of type DefaultErrorResponseEntity
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ValidateShopperIdOperationRequest](src/AdyenApIs/Requests/Utility/ValidateShopperIdOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ValidateShopperIdResponse](src/AdyenApIs/Models/ValidateShopperIdResponse.cs)</code>

**OnError**: <code>[ApiException](src/AdyenApIs/Core/Exceptions/ApiException.cs)&lt;[ValidateShopperIdError](src/AdyenApIs/Errors/ValidateShopperIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## WebhooksCompanyLevel

> Source: [WebhooksCompanyLevel](src/AdyenApIs/Api/WebhooksCompanyLevel.cs)

<details>
<summary><code>Task&lt;Webhook&gt; CreateCompanyWebhook(CreateCompanyWebhookOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Subscribe to receive webhook notifications about events related to your company account. You can add basic authentication to make sure the data is secure.

To make this request, your API credential must have the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Webhooks read and write

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.WebhooksCompanyLevel.CreateCompanyWebhook(new CreateCompanyWebhookOperationRequest
    {
        CompanyId = "some example string",
        Body = new CreateCompanyWebhookRequest
        {
            AcceptsExpiredCertificate = false,
            AcceptsSelfSignedCertificate = true,
            AcceptsUntrustedRootCertificate = true,
            Active = true,
            CommunicationFormat = CommunicationFormat.Soap,
            FilterMerchantAccountType = FilterMerchantAccountType.IncludeAccounts,
            FilterMerchantAccounts = ["YOUR_MERCHANT_ACCOUNT"],
            Password = "YOUR_PASSWORD",
            PopulateSoapActionHeader = false,
            Type = "standard",
            Url = "YOUR_WEBHOOK_URL",
            Username = "YOUR_USER",
        },
    });
    // TODO: Handle 'response' of type Webhook
}
catch (ApiException<CreateCompanyWebhookError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CreateCompanyWebhookOperationRequest](src/AdyenApIs/Requests/WebhooksCompanyLevel/CreateCompanyWebhookOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Webhook](src/AdyenApIs/Models/Webhook.cs)</code>

**OnError**: <code>[ApiException](src/AdyenApIs/Core/Exceptions/ApiException.cs)&lt;[CreateCompanyWebhookError](src/AdyenApIs/Errors/CreateCompanyWebhookError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task DeleteCompanyWebhook(DeleteCompanyWebhookRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Remove the configuration for the webhook identified in the path.

To make this request, your API credential must have the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Webhooks read and write

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.WebhooksCompanyLevel.DeleteCompanyWebhook(new DeleteCompanyWebhookRequest
    {
        CompanyId = "some example string",
        WebhookId = "some example string",
    });
}
catch (ApiException<DeleteCompanyWebhookError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DeleteCompanyWebhookRequest](src/AdyenApIs/Requests/WebhooksCompanyLevel/DeleteCompanyWebhookRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[ApiException](src/AdyenApIs/Core/Exceptions/ApiException.cs)&lt;[DeleteCompanyWebhookError](src/AdyenApIs/Errors/DeleteCompanyWebhookError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GenerateHmacKeyResponse&gt; GenerateCompanyWebhookHmac(GenerateCompanyWebhookHmacRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns an [HMAC key](https://en.wikipedia.org/wiki/HMAC) for the webhook identified in the path. This key allows you to check the integrity and the origin of the notifications you receive.By creating an HMAC key, you start receiving [HMAC-signed notifications](https://docs.adyen.com/development-resources/webhooks/verify-hmac-signatures#enable-hmac-signatures) from Adyen. Find out more about how to [verify HMAC signatures](https://docs.adyen.com/development-resources/webhooks/verify-hmac-signatures).

To make this request, your API credential must have the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Webhooks read and write

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.WebhooksCompanyLevel.GenerateCompanyWebhookHmac(new GenerateCompanyWebhookHmacRequest
    {
        CompanyId = "some example string",
        WebhookId = "some example string",
    });
    // TODO: Handle 'response' of type GenerateHmacKeyResponse
}
catch (ApiException<GenerateCompanyWebhookHmacError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GenerateCompanyWebhookHmacRequest](src/AdyenApIs/Requests/WebhooksCompanyLevel/GenerateCompanyWebhookHmacRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GenerateHmacKeyResponse](src/AdyenApIs/Models/GenerateHmacKeyResponse.cs)</code>

**OnError**: <code>[ApiException](src/AdyenApIs/Core/Exceptions/ApiException.cs)&lt;[GenerateCompanyWebhookHmacError](src/AdyenApIs/Errors/GenerateCompanyWebhookHmacError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Webhook&gt; GetCompanyWebhook(GetCompanyWebhookRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the configuration for the webhook identified in the path.

To make this request, your API credential must have one of the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Webhooks read
* Management API—Webhooks read and write

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.WebhooksCompanyLevel.GetCompanyWebhook(new GetCompanyWebhookRequest
    {
        CompanyId = "some example string",
        WebhookId = "some example string",
    });
    // TODO: Handle 'response' of type Webhook
}
catch (ApiException<GetCompanyWebhookError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetCompanyWebhookRequest](src/AdyenApIs/Requests/WebhooksCompanyLevel/GetCompanyWebhookRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Webhook](src/AdyenApIs/Models/Webhook.cs)</code>

**OnError**: <code>[ApiException](src/AdyenApIs/Core/Exceptions/ApiException.cs)&lt;[GetCompanyWebhookError](src/AdyenApIs/Errors/GetCompanyWebhookError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ListWebhooksResponse&gt; ListCompanyWebhooks(ListCompanyWebhooksRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Lists all webhook configurations for the company account.

To make this request, your API credential must have one of the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Webhooks read
* Management API—Webhooks read and write

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.WebhooksCompanyLevel.ListCompanyWebhooks(new ListCompanyWebhooksRequest
    {
        CompanyId = "some example string",
    });
    // TODO: Handle 'response' of type ListWebhooksResponse
}
catch (ApiException<ListCompanyWebhooksError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ListCompanyWebhooksRequest](src/AdyenApIs/Requests/WebhooksCompanyLevel/ListCompanyWebhooksRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ListWebhooksResponse](src/AdyenApIs/Models/ListWebhooksResponse.cs)</code>

**OnError**: <code>[ApiException](src/AdyenApIs/Core/Exceptions/ApiException.cs)&lt;[ListCompanyWebhooksError](src/AdyenApIs/Errors/ListCompanyWebhooksError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TestWebhookResponse&gt; TestCompanyWebhook(TestCompanyWebhookOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Sends sample notifications to test if the webhook is set up correctly.

We send sample notifications for maximum 20 of the merchant accounts that the webhook is configured for. If the webhook is configured for more than 20 merchant accounts, use the `merchantIds` array to specify a subset of the merchant accounts for which to send test notifications.

We send four test notifications for each event code you choose. They cover success and failure scenarios for the hard-coded currencies EUR and GBP, regardless of the currencies configured in the merchant accounts. For custom notifications, we only send the specified custom notification.

The response describes the result of the test. The `status` field tells you if the test was successful or not. You can use the other response fields to troubleshoot unsuccessful tests.

To make this request, your API credential must have the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Webhooks read and write

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.WebhooksCompanyLevel.TestCompanyWebhook(new TestCompanyWebhookOperationRequest
    {
        CompanyId = "some example string",
        WebhookId = "some example string",
        Body = new TestCompanyWebhookRequest { MerchantIds = ["YOUR_MERCHANT_ACCOUNT"], Types = ["AUTHORISATION"] },
    });
    // TODO: Handle 'response' of type TestWebhookResponse
}
catch (ApiException<TestCompanyWebhookError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[TestCompanyWebhookOperationRequest](src/AdyenApIs/Requests/WebhooksCompanyLevel/TestCompanyWebhookOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TestWebhookResponse](src/AdyenApIs/Models/TestWebhookResponse.cs)</code>

**OnError**: <code>[ApiException](src/AdyenApIs/Core/Exceptions/ApiException.cs)&lt;[TestCompanyWebhookError](src/AdyenApIs/Errors/TestCompanyWebhookError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Webhook&gt; UpdateCompanyWebhook(UpdateCompanyWebhookOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Make changes to the configuration of the webhook identified in the path. The request contains the new values you want to have in the webhook configuration. The response contains the full configuration for the webhook, which includes the new values from the request.

To make this request, your API credential must have the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Webhooks read and write

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.WebhooksCompanyLevel.UpdateCompanyWebhook(new UpdateCompanyWebhookOperationRequest
    {
        CompanyId = "some example string",
        WebhookId = "some example string",
        Body = new UpdateCompanyWebhookRequest { Active = true },
    });
    // TODO: Handle 'response' of type Webhook
}
catch (ApiException<UpdateCompanyWebhookError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[UpdateCompanyWebhookOperationRequest](src/AdyenApIs/Requests/WebhooksCompanyLevel/UpdateCompanyWebhookOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Webhook](src/AdyenApIs/Models/Webhook.cs)</code>

**OnError**: <code>[ApiException](src/AdyenApIs/Core/Exceptions/ApiException.cs)&lt;[UpdateCompanyWebhookError](src/AdyenApIs/Errors/UpdateCompanyWebhookError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## WebhooksMerchantLevel

> Source: [WebhooksMerchantLevel](src/AdyenApIs/Api/WebhooksMerchantLevel.cs)

<details>
<summary><code>Task&lt;Webhook&gt; CreateMerchantWebhook(CreateMerchantWebhookOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Subscribe to receive webhook notifications about events related to your merchant account. You can add basic authentication to make sure the data is secure.

To make this request, your API credential must have the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Webhooks read and write

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.WebhooksMerchantLevel.CreateMerchantWebhook(new CreateMerchantWebhookOperationRequest
    {
        MerchantId = "some example string",
        Body = new CreateMerchantWebhookRequest
        {
            AcceptsExpiredCertificate = false,
            AcceptsSelfSignedCertificate = true,
            AcceptsUntrustedRootCertificate = true,
            Active = true,
            CommunicationFormat = CommunicationFormat.Json,
            Password = "YOUR_PASSWORD",
            PopulateSoapActionHeader = false,
            Type = "standard",
            Url = "YOUR_WEBHOOK_URL",
            Username = "YOUR_USER",
        },
    });
    // TODO: Handle 'response' of type Webhook
}
catch (ApiException<CreateMerchantWebhookError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CreateMerchantWebhookOperationRequest](src/AdyenApIs/Requests/WebhooksMerchantLevel/CreateMerchantWebhookOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Webhook](src/AdyenApIs/Models/Webhook.cs)</code>

**OnError**: <code>[ApiException](src/AdyenApIs/Core/Exceptions/ApiException.cs)&lt;[CreateMerchantWebhookError](src/AdyenApIs/Errors/CreateMerchantWebhookError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task DeleteMerchantWebhook(DeleteMerchantWebhookRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Remove the configuration for the webhook identified in the path.

To make this request, your API credential must have the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Webhooks read and write

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.WebhooksMerchantLevel.DeleteMerchantWebhook(new DeleteMerchantWebhookRequest
    {
        MerchantId = "some example string",
        WebhookId = "some example string",
    });
}
catch (ApiException<DeleteMerchantWebhookError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DeleteMerchantWebhookRequest](src/AdyenApIs/Requests/WebhooksMerchantLevel/DeleteMerchantWebhookRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[ApiException](src/AdyenApIs/Core/Exceptions/ApiException.cs)&lt;[DeleteMerchantWebhookError](src/AdyenApIs/Errors/DeleteMerchantWebhookError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GenerateHmacKeyResponse&gt; GenerateMerchantWebhookHmac(GenerateMerchantWebhookHmacRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns an [HMAC key](https://en.wikipedia.org/wiki/HMAC) for the webhook identified in the path. This key allows you to check the integrity and the origin of the notifications you receive.By creating an HMAC key, you start receiving [HMAC-signed notifications](https://docs.adyen.com/development-resources/webhooks/verify-hmac-signatures#enable-hmac-signatures) from Adyen. Find out more about how to [verify HMAC signatures](https://docs.adyen.com/development-resources/webhooks/verify-hmac-signatures).

To make this request, your API credential must have the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Webhooks read and write

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.WebhooksMerchantLevel.GenerateMerchantWebhookHmac(new GenerateMerchantWebhookHmacRequest
    {
        MerchantId = "some example string",
        WebhookId = "some example string",
    });
    // TODO: Handle 'response' of type GenerateHmacKeyResponse
}
catch (ApiException<GenerateMerchantWebhookHmacError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GenerateMerchantWebhookHmacRequest](src/AdyenApIs/Requests/WebhooksMerchantLevel/GenerateMerchantWebhookHmacRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GenerateHmacKeyResponse](src/AdyenApIs/Models/GenerateHmacKeyResponse.cs)</code>

**OnError**: <code>[ApiException](src/AdyenApIs/Core/Exceptions/ApiException.cs)&lt;[GenerateMerchantWebhookHmacError](src/AdyenApIs/Errors/GenerateMerchantWebhookHmacError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Webhook&gt; GetMerchantWebhook(GetMerchantWebhookRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the configuration for the webhook identified in the path.

To make this request, your API credential must have one of the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Webhooks read
* Management API—Webhooks read and write

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.WebhooksMerchantLevel.GetMerchantWebhook(new GetMerchantWebhookRequest
    {
        MerchantId = "some example string",
        WebhookId = "some example string",
    });
    // TODO: Handle 'response' of type Webhook
}
catch (ApiException<GetMerchantWebhookError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetMerchantWebhookRequest](src/AdyenApIs/Requests/WebhooksMerchantLevel/GetMerchantWebhookRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Webhook](src/AdyenApIs/Models/Webhook.cs)</code>

**OnError**: <code>[ApiException](src/AdyenApIs/Core/Exceptions/ApiException.cs)&lt;[GetMerchantWebhookError](src/AdyenApIs/Errors/GetMerchantWebhookError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ListWebhooksResponse&gt; ListMerchantWebhooks(ListMerchantWebhooksRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Lists all webhook configurations for the merchant account.

> This call does not return webhook configurations for the company account to which the specified merchant account belongs. You can see these in your Customer Area under **Developers** > **Webhooks**.

To make this request, your API credential must have one of the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Webhooks read
* Management API—Webhooks read and write

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.WebhooksMerchantLevel.ListMerchantWebhooks(new ListMerchantWebhooksRequest
    {
        MerchantId = "some example string",
    });
    // TODO: Handle 'response' of type ListWebhooksResponse
}
catch (ApiException<ListMerchantWebhooksError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ListMerchantWebhooksRequest](src/AdyenApIs/Requests/WebhooksMerchantLevel/ListMerchantWebhooksRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ListWebhooksResponse](src/AdyenApIs/Models/ListWebhooksResponse.cs)</code>

**OnError**: <code>[ApiException](src/AdyenApIs/Core/Exceptions/ApiException.cs)&lt;[ListMerchantWebhooksError](src/AdyenApIs/Errors/ListMerchantWebhooksError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TestWebhookResponse&gt; TestMerchantWebhook(TestMerchantWebhookRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Sends sample notifications to test if the webhook is set up correctly.

We send four test notifications for each event code you choose. They cover success and failure scenarios for the hard-coded currencies EUR and GBP, regardless of the currencies configured in the merchant accounts. For custom notifications, we only send the specified custom notification.

The response describes the result of the test. The `status` field tells you if the test was successful or not. You can use the other fields to troubleshoot unsuccessful tests.

To make this request, your API credential must have the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Webhooks read and write

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.WebhooksMerchantLevel.TestMerchantWebhook(new TestMerchantWebhookRequest
    {
        MerchantId = "some example string",
        WebhookId = "some example string",
        Body = new TestWebhookRequest { Types = ["AUTHORISATION"] },
    });
    // TODO: Handle 'response' of type TestWebhookResponse
}
catch (ApiException<TestMerchantWebhookError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[TestMerchantWebhookRequest](src/AdyenApIs/Requests/WebhooksMerchantLevel/TestMerchantWebhookRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TestWebhookResponse](src/AdyenApIs/Models/TestWebhookResponse.cs)</code>

**OnError**: <code>[ApiException](src/AdyenApIs/Core/Exceptions/ApiException.cs)&lt;[TestMerchantWebhookError](src/AdyenApIs/Errors/TestMerchantWebhookError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Webhook&gt; UpdateMerchantWebhook(UpdateMerchantWebhookOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Make changes to the configuration of the webhook identified in the path. The request contains the new values you want to have in the webhook configuration. The response contains the full configuration for the webhook, which includes the new values from the request.

To make this request, your API credential must have the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Webhooks read and write

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.WebhooksMerchantLevel.UpdateMerchantWebhook(new UpdateMerchantWebhookOperationRequest
    {
        MerchantId = "some example string",
        WebhookId = "some example string",
        Body = new UpdateMerchantWebhookRequest { Active = true },
    });
    // TODO: Handle 'response' of type Webhook
}
catch (ApiException<UpdateMerchantWebhookError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[UpdateMerchantWebhookOperationRequest](src/AdyenApIs/Requests/WebhooksMerchantLevel/UpdateMerchantWebhookOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Webhook](src/AdyenApIs/Models/Webhook.cs)</code>

**OnError**: <code>[ApiException](src/AdyenApIs/Core/Exceptions/ApiException.cs)&lt;[UpdateMerchantWebhookError](src/AdyenApIs/Errors/UpdateMerchantWebhookError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

