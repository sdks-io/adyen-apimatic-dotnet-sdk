
# Getting Started with Adyen APIs

## Introduction

Adyen Checkout API provides a simple and flexible way to initiate and authorise online payments. You can use the same integration for payments made with cards (including 3D Secure), mobile wallets, and local payment methods (for example, iDEAL and Sofort).

This API reference provides information on available endpoints and how to interact with them. To learn more about the API, visit [online payments documentation](https://docs.adyen.com/online-payments).

### Authentication

Each request to Checkout API must be signed with an API key. For this, [get your API key](https://docs.adyen.com/development-resources/api-credentials#generate-api-key) from your Customer Area, and set this key to the `X-API-Key` header value, for example:

```
curl
-H "Content-Type: application/json" \
-H "X-API-Key: YOUR_API_KEY" \
...
```

### Versioning

Checkout API supports [versioning](https://docs.adyen.com/development-resources/versioning) using a version suffix in the endpoint URL. This suffix has the following format: "vXX", where XX is the version number.

For example:

```
https://checkout-test.adyen.com/v71/payments
```

### Server-side API libraries

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

### Developer resources

Checkout API is available through a Postman collection. Click the button below to create a fork, then set the environment variables at **Environments**&nbsp;>&nbsp;**Adyen&nbsp;APIs**.

[![Run in Postman](https://run.pstmn.io/button.svg)](https://god.gw.postman.com/run-collection/25716737-46ad970e-dc9e-4246-bac2-769c6083e7b5?action=collection%2Ffork&source=rip_markdown&collection-url=entityId%3D25716737-46ad970e-dc9e-4246-bac2-769c6083e7b5%26entityType%3Dcollection%26workspaceId%3Da8d63f9f-cfc7-4810-90c5-9e0c60030d3e#?env%5BAdyen%20APIs%5D=W3sia2V5IjoiWC1BUEktS2V5IiwidmFsdWUiOiIiLCJlbmFibGVkIjp0cnVlLCJ0eXBlIjoic2VjcmV0In0seyJrZXkiOiJZT1VSX01FUkNIQU5UX0FDQ09VTlQiLCJ2YWx1ZSI6IiIsImVuYWJsZWQiOnRydWUsInR5cGUiOiJkZWZhdWx0In0seyJrZXkiOiJZT1VSX0NPTVBBTllfQUNDT1VOVCIsInZhbHVlIjoiIiwiZW5hYmxlZCI6dHJ1ZSwidHlwZSI6ImRlZmF1bHQifSx7ImtleSI6IllPVVJfQkFMQU5DRV9QTEFURk9STSIsInZhbHVlIjoiIiwiZW5hYmxlZCI6dHJ1ZSwidHlwZSI6ImRlZmF1bHQifV0=)

### Going live

To access the live endpoints, you need an API key from your live Customer Area.

The live endpoint URLs contain a prefix which is unique to your company account, for example:

```
https://{PREFIX}-checkout-live.adyenpayments.com/checkout/v71/payments
```

Get your `{PREFIX}` from your live Customer Area under **Developers** > **API URLs** > **Prefix**.

When preparing to do live transactions with Checkout API, follow the [go-live checklist](https://docs.adyen.com/online-payments/go-live-checklist) to make sure you've got all the required configuration in place.

### Release notes

Have a look at the [release notes](https://docs.adyen.com/online-payments/release-notes?integration_type=api&version=71) to find out what changed in this version!, Configure and manage your Adyen company and merchant accounts, stores, and payment terminals.

### Authentication

Each request to the Management API must be signed with an API key. [Generate your API key](https://docs.adyen.com/development-resources/api-credentials#generate-api-key) in the Customer Area and then set this key to the `X-API-Key` header value.

To access the live endpoints, you need to generate a new API key in your live Customer Area.

### Versioning

Management API handles versioning as part of the endpoint URL. For example, to send a request to this version of the `/companies/{companyId}/webhooks` endpoint, use:

```text
https://management-test.adyen.com/v3/companies/{companyId}/webhooks
```

### Going live

To access the live endpoints, you need an API key from your live Customer Area. Use this API key to make requests to:

```text
https://management-live.adyen.com/v3
```

### Release notes

Have a look at the [release notes](https://docs.adyen.com/release-notes/management-api) to find out what changed in this version!

## Install the Package

If you are building with .NET CLI tools then you can also use the following command:

```bash
dotnet add package AdyenApimaticSDK --version 1.0.0
```

You can also view the package at:
https://www.nuget.org/packages/AdyenApimaticSDK/1.0.0

## Initialize the API Client

**_Note:_** Documentation for the client can be found [here.](https://www.github.com/sdks-io/adyen-apimatic-dotnet-sdk/tree/1.0.0/doc/client.md)

The following parameters are configurable for the API Client:

| Parameter | Type | Description |
|  --- | --- | --- |
| Environment | [`Environment`](https://www.github.com/sdks-io/adyen-apimatic-dotnet-sdk/tree/1.0.0/README.md#environments) | The API environment. <br> **Default: `Environment.Production`** |
| Timeout | `TimeSpan` | Http client timeout.<br>*Default*: `TimeSpan.FromSeconds(30)` |
| HttpClientConfiguration | [`Action<HttpClientConfiguration.Builder>`](https://www.github.com/sdks-io/adyen-apimatic-dotnet-sdk/tree/1.0.0/doc/http-client-configuration-builder.md) | Action delegate that configures the HTTP client by using the HttpClientConfiguration.Builder for customizing API call settings.<br>*Default*: `new HttpClient()` |
| LogBuilder | [`LogBuilder`](https://www.github.com/sdks-io/adyen-apimatic-dotnet-sdk/tree/1.0.0/doc/log-builder.md) | Represents the logging configuration builder for API calls |
| ApiKeyAuthCredentials | [`ApiKeyAuthCredentials`](https://www.github.com/sdks-io/adyen-apimatic-dotnet-sdk/tree/1.0.0/doc/auth/custom-header-signature.md) | The Credentials Setter for Custom Header Signature |
| BasicAuthCredentials | [`BasicAuthCredentials`](https://www.github.com/sdks-io/adyen-apimatic-dotnet-sdk/tree/1.0.0/doc/auth/basic-authentication.md) | The Credentials Setter for Basic Authentication |

The API client can be initialized as follows:

### Code-Based Initialization

```csharp
using AdyenApIs.Standard;
using AdyenApIs.Standard.Authentication;
using Microsoft.Extensions.Logging;

namespace ConsoleApp;

AdyenApIsClient client = new AdyenApIsClient.Builder()
    .ApiKeyAuthCredentials(
        new ApiKeyAuthModel.Builder(
            "X-API-Key"
        )
        .Build())
    .BasicAuthCredentials(
        new BasicAuthModel.Builder(
            "Username",
            "Password"
        )
        .Build())
    .HttpClientConfig(httpClientConfig =>
        httpClientConfig.Timeout(TimeSpan.FromSeconds(100)))
    .Environment(AdyenApIs.Standard.Environment.Production)
    .LoggingConfig(config => config
        .LogLevel(LogLevel.Information)
        .RequestConfig(reqConfig => reqConfig.Body(true))
        .ResponseConfig(respConfig => respConfig.Headers(true))
    )
    .Build();
```

### Configuration-Based Initialization

```csharp
using AdyenApIs.Standard;
using Microsoft.Extensions.Configuration;

namespace ConsoleApp;

// Build the IConfiguration using .NET conventions (JSON, environment, etc.)
var configuration = new ConfigurationBuilder()
    .AddJsonFile("config.json")
    .AddEnvironmentVariables() // [optional] read environment variables
    .Build();

// Instantiate your SDK and configure it from IConfiguration
var client = AdyenApIsClient
    .FromConfiguration(configuration.GetSection("AdyenApIs"));
```

See the [Configuration-Based Initialization](https://www.github.com/sdks-io/adyen-apimatic-dotnet-sdk/tree/1.0.0/doc/configuration-based-initialization.md) section for details.

## Environments

The SDK can be configured to use a different environment for making API calls. Available environments are:

### Fields

| Name | Description |
|  --- | --- |
| Production | **Default** |

## Authorization

This API uses the following authentication schemes.

* [`ApiKeyAuth (Custom Header Signature)`](https://www.github.com/sdks-io/adyen-apimatic-dotnet-sdk/tree/1.0.0/doc/auth/custom-header-signature.md)
* [`BasicAuth (Basic Authentication)`](https://www.github.com/sdks-io/adyen-apimatic-dotnet-sdk/tree/1.0.0/doc/auth/basic-authentication.md)

## List of APIs

* [Paymentlinks](https://www.github.com/sdks-io/adyen-apimatic-dotnet-sdk/tree/1.0.0/doc/controllers/paymentlinks.md)
* [Account-Companylevel](https://www.github.com/sdks-io/adyen-apimatic-dotnet-sdk/tree/1.0.0/doc/controllers/account-companylevel.md)
* [Account-Merchantlevel](https://www.github.com/sdks-io/adyen-apimatic-dotnet-sdk/tree/1.0.0/doc/controllers/account-merchantlevel.md)
* [Account-Storelevel](https://www.github.com/sdks-io/adyen-apimatic-dotnet-sdk/tree/1.0.0/doc/controllers/account-storelevel.md)
* [Payoutsettings-Merchantlevel](https://www.github.com/sdks-io/adyen-apimatic-dotnet-sdk/tree/1.0.0/doc/controllers/payoutsettings-merchantlevel.md)
* [Users-Companylevel](https://www.github.com/sdks-io/adyen-apimatic-dotnet-sdk/tree/1.0.0/doc/controllers/users-companylevel.md)
* [Users-Merchantlevel](https://www.github.com/sdks-io/adyen-apimatic-dotnet-sdk/tree/1.0.0/doc/controllers/users-merchantlevel.md)
* [My AP Icredential](https://www.github.com/sdks-io/adyen-apimatic-dotnet-sdk/tree/1.0.0/doc/controllers/my-ap-icredential.md)
* [AP Icredentials-Companylevel](https://www.github.com/sdks-io/adyen-apimatic-dotnet-sdk/tree/1.0.0/doc/controllers/ap-icredentials-companylevel.md)
* [AP Icredentials-Merchantlevel](https://www.github.com/sdks-io/adyen-apimatic-dotnet-sdk/tree/1.0.0/doc/controllers/ap-icredentials-merchantlevel.md)
* [AP Ikey-Companylevel](https://www.github.com/sdks-io/adyen-apimatic-dotnet-sdk/tree/1.0.0/doc/controllers/ap-ikey-companylevel.md)
* [AP Ikey-Merchantlevel](https://www.github.com/sdks-io/adyen-apimatic-dotnet-sdk/tree/1.0.0/doc/controllers/ap-ikey-merchantlevel.md)
* [Clientkey-Companylevel](https://www.github.com/sdks-io/adyen-apimatic-dotnet-sdk/tree/1.0.0/doc/controllers/clientkey-companylevel.md)
* [Clientkey-Merchantlevel](https://www.github.com/sdks-io/adyen-apimatic-dotnet-sdk/tree/1.0.0/doc/controllers/clientkey-merchantlevel.md)
* [Allowedorigins-Companylevel](https://www.github.com/sdks-io/adyen-apimatic-dotnet-sdk/tree/1.0.0/doc/controllers/allowedorigins-companylevel.md)
* [Allowedorigins-Merchantlevel](https://www.github.com/sdks-io/adyen-apimatic-dotnet-sdk/tree/1.0.0/doc/controllers/allowedorigins-merchantlevel.md)
* [Webhooks-Companylevel](https://www.github.com/sdks-io/adyen-apimatic-dotnet-sdk/tree/1.0.0/doc/controllers/webhooks-companylevel.md)
* [Webhooks-Merchantlevel](https://www.github.com/sdks-io/adyen-apimatic-dotnet-sdk/tree/1.0.0/doc/controllers/webhooks-merchantlevel.md)
* [Paymentmethods-Merchantlevel](https://www.github.com/sdks-io/adyen-apimatic-dotnet-sdk/tree/1.0.0/doc/controllers/paymentmethods-merchantlevel.md)
* [Terminals-Terminallevel](https://www.github.com/sdks-io/adyen-apimatic-dotnet-sdk/tree/1.0.0/doc/controllers/terminals-terminallevel.md)
* [Terminalactions-Companylevel](https://www.github.com/sdks-io/adyen-apimatic-dotnet-sdk/tree/1.0.0/doc/controllers/terminalactions-companylevel.md)
* [Terminalactions-Terminallevel](https://www.github.com/sdks-io/adyen-apimatic-dotnet-sdk/tree/1.0.0/doc/controllers/terminalactions-terminallevel.md)
* [Terminalorders-Companylevel](https://www.github.com/sdks-io/adyen-apimatic-dotnet-sdk/tree/1.0.0/doc/controllers/terminalorders-companylevel.md)
* [Terminalorders-Merchantlevel](https://www.github.com/sdks-io/adyen-apimatic-dotnet-sdk/tree/1.0.0/doc/controllers/terminalorders-merchantlevel.md)
* [Terminalsettings-Companylevel](https://www.github.com/sdks-io/adyen-apimatic-dotnet-sdk/tree/1.0.0/doc/controllers/terminalsettings-companylevel.md)
* [Terminalsettings-Merchantlevel](https://www.github.com/sdks-io/adyen-apimatic-dotnet-sdk/tree/1.0.0/doc/controllers/terminalsettings-merchantlevel.md)
* [Terminalsettings-Storelevel](https://www.github.com/sdks-io/adyen-apimatic-dotnet-sdk/tree/1.0.0/doc/controllers/terminalsettings-storelevel.md)
* [Terminalsettings-Terminallevel](https://www.github.com/sdks-io/adyen-apimatic-dotnet-sdk/tree/1.0.0/doc/controllers/terminalsettings-terminallevel.md)
* [Androidfiles-Companylevel](https://www.github.com/sdks-io/adyen-apimatic-dotnet-sdk/tree/1.0.0/doc/controllers/androidfiles-companylevel.md)
* [Splitconfiguration-Merchantlevel](https://www.github.com/sdks-io/adyen-apimatic-dotnet-sdk/tree/1.0.0/doc/controllers/splitconfiguration-merchantlevel.md)
* [Payments](https://www.github.com/sdks-io/adyen-apimatic-dotnet-sdk/tree/1.0.0/doc/controllers/payments.md)
* [Donations](https://www.github.com/sdks-io/adyen-apimatic-dotnet-sdk/tree/1.0.0/doc/controllers/donations.md)
* [Modifications](https://www.github.com/sdks-io/adyen-apimatic-dotnet-sdk/tree/1.0.0/doc/controllers/modifications.md)
* [Recurring](https://www.github.com/sdks-io/adyen-apimatic-dotnet-sdk/tree/1.0.0/doc/controllers/recurring.md)
* [Orders](https://www.github.com/sdks-io/adyen-apimatic-dotnet-sdk/tree/1.0.0/doc/controllers/orders.md)
* [Utility](https://www.github.com/sdks-io/adyen-apimatic-dotnet-sdk/tree/1.0.0/doc/controllers/utility.md)

## SDK Infrastructure

### Configuration

* [Configuration-Based Initialization](https://www.github.com/sdks-io/adyen-apimatic-dotnet-sdk/tree/1.0.0/doc/configuration-based-initialization.md)
* [HttpClientConfiguration](https://www.github.com/sdks-io/adyen-apimatic-dotnet-sdk/tree/1.0.0/doc/http-client-configuration.md)
* [HttpClientConfigurationBuilder](https://www.github.com/sdks-io/adyen-apimatic-dotnet-sdk/tree/1.0.0/doc/http-client-configuration-builder.md)
* [LogBuilder](https://www.github.com/sdks-io/adyen-apimatic-dotnet-sdk/tree/1.0.0/doc/log-builder.md)
* [LogRequestBuilder](https://www.github.com/sdks-io/adyen-apimatic-dotnet-sdk/tree/1.0.0/doc/log-request-builder.md)
* [LogResponseBuilder](https://www.github.com/sdks-io/adyen-apimatic-dotnet-sdk/tree/1.0.0/doc/log-response-builder.md)
* [ProxyConfigurationBuilder](https://www.github.com/sdks-io/adyen-apimatic-dotnet-sdk/tree/1.0.0/doc/proxy-configuration-builder.md)

### HTTP

* [HttpCallback](https://www.github.com/sdks-io/adyen-apimatic-dotnet-sdk/tree/1.0.0/doc/http-callback.md)
* [HttpContext](https://www.github.com/sdks-io/adyen-apimatic-dotnet-sdk/tree/1.0.0/doc/http-context.md)
* [HttpRequest](https://www.github.com/sdks-io/adyen-apimatic-dotnet-sdk/tree/1.0.0/doc/http-request.md)
* [HttpResponse](https://www.github.com/sdks-io/adyen-apimatic-dotnet-sdk/tree/1.0.0/doc/http-response.md)
* [HttpStringResponse](https://www.github.com/sdks-io/adyen-apimatic-dotnet-sdk/tree/1.0.0/doc/http-string-response.md)

### Utilities

* [ApiException](https://www.github.com/sdks-io/adyen-apimatic-dotnet-sdk/tree/1.0.0/doc/api-exception.md)
* [ApiResponse](https://www.github.com/sdks-io/adyen-apimatic-dotnet-sdk/tree/1.0.0/doc/api-response.md)
* [ApiHelper](https://www.github.com/sdks-io/adyen-apimatic-dotnet-sdk/tree/1.0.0/doc/api-helper.md)
* [CustomDateTimeConverter](https://www.github.com/sdks-io/adyen-apimatic-dotnet-sdk/tree/1.0.0/doc/custom-date-time-converter.md)
* [UnixDateTimeConverter](https://www.github.com/sdks-io/adyen-apimatic-dotnet-sdk/tree/1.0.0/doc/unix-date-time-converter.md)

