
# Client Class Documentation

The following parameters are configurable for the API Client:

| Parameter | Type | Description |
|  --- | --- | --- |
| Environment | [`Environment`](../README.md#environments) | The API environment. <br> **Default: `Environment.Production`** |
| Timeout | `TimeSpan` | Http client timeout.<br>*Default*: `TimeSpan.FromSeconds(30)` |
| HttpClientConfiguration | [`Action<HttpClientConfiguration.Builder>`](../doc/http-client-configuration-builder.md) | Action delegate that configures the HTTP client by using the HttpClientConfiguration.Builder for customizing API call settings.<br>*Default*: `new HttpClient()` |
| LogBuilder | [`LogBuilder`](../doc/log-builder.md) | Represents the logging configuration builder for API calls |
| ApiKeyAuthCredentials | [`ApiKeyAuthCredentials`](auth/custom-header-signature.md) | The Credentials Setter for Custom Header Signature |
| BasicAuthCredentials | [`BasicAuthCredentials`](auth/basic-authentication.md) | The Credentials Setter for Basic Authentication |

The API client can be initialized as follows:

## Code-Based Initialization

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

## Configuration-Based Initialization

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

See the [Configuration-Based Initialization](../doc/configuration-based-initialization.md) section for details.

## Adyen APIsClient Class

The gateway for the SDK. This class acts as a factory for the Apis and also holds the configuration of the SDK.

### Controllers

| Name | Description |
|  --- | --- |
| PaymentsApi | Gets PaymentsApi. |
| DonationsApi | Gets DonationsApi. |
| PaymentLinksApi | Gets PaymentLinksApi. |
| ModificationsApi | Gets ModificationsApi. |
| RecurringApi | Gets RecurringApi. |
| OrdersApi | Gets OrdersApi. |
| UtilityApi | Gets UtilityApi. |
| AccountCompanyLevelApi | Gets AccountCompanyLevelApi. |
| AccountMerchantLevelApi | Gets AccountMerchantLevelApi. |
| AccountStoreLevelApi | Gets AccountStoreLevelApi. |
| PayoutSettingsMerchantLevelApi | Gets PayoutSettingsMerchantLevelApi. |
| UsersCompanyLevelApi | Gets UsersCompanyLevelApi. |
| UsersMerchantLevelApi | Gets UsersMerchantLevelApi. |
| MyApiCredentialApi | Gets MyApiCredentialApi. |
| ApiCredentialsCompanyLevelApi | Gets ApiCredentialsCompanyLevelApi. |
| ApiCredentialsMerchantLevelApi | Gets ApiCredentialsMerchantLevelApi. |
| ApiKeyCompanyLevelApi | Gets ApiKeyCompanyLevelApi. |
| ApiKeyMerchantLevelApi | Gets ApiKeyMerchantLevelApi. |
| ClientKeyCompanyLevelApi | Gets ClientKeyCompanyLevelApi. |
| ClientKeyMerchantLevelApi | Gets ClientKeyMerchantLevelApi. |
| AllowedOriginsCompanyLevelApi | Gets AllowedOriginsCompanyLevelApi. |
| AllowedOriginsMerchantLevelApi | Gets AllowedOriginsMerchantLevelApi. |
| WebhooksCompanyLevelApi | Gets WebhooksCompanyLevelApi. |
| WebhooksMerchantLevelApi | Gets WebhooksMerchantLevelApi. |
| PaymentMethodsMerchantLevelApi | Gets PaymentMethodsMerchantLevelApi. |
| TerminalsTerminalLevelApi | Gets TerminalsTerminalLevelApi. |
| TerminalActionsCompanyLevelApi | Gets TerminalActionsCompanyLevelApi. |
| TerminalActionsTerminalLevelApi | Gets TerminalActionsTerminalLevelApi. |
| TerminalOrdersCompanyLevelApi | Gets TerminalOrdersCompanyLevelApi. |
| TerminalOrdersMerchantLevelApi | Gets TerminalOrdersMerchantLevelApi. |
| TerminalSettingsCompanyLevelApi | Gets TerminalSettingsCompanyLevelApi. |
| TerminalSettingsMerchantLevelApi | Gets TerminalSettingsMerchantLevelApi. |
| TerminalSettingsStoreLevelApi | Gets TerminalSettingsStoreLevelApi. |
| TerminalSettingsTerminalLevelApi | Gets TerminalSettingsTerminalLevelApi. |
| AndroidFilesCompanyLevelApi | Gets AndroidFilesCompanyLevelApi. |
| SplitConfigurationMerchantLevelApi | Gets SplitConfigurationMerchantLevelApi. |

### Properties

| Name | Description | Type |
|  --- | --- | --- |
| HttpClientConfiguration | Gets the configuration of the Http Client associated with this client. | [`IHttpClientConfiguration`](../doc/http-client-configuration.md) |
| Timeout | Http client timeout. | `TimeSpan` |
| Environment | Current API environment. | `Environment` |
| ApiKeyAuthCredentials | Gets the credentials to use with ApiKeyAuth. | [`IApiKeyAuthCredentials`](auth/custom-header-signature.md) |
| BasicAuthCredentials | Gets the credentials to use with BasicAuth. | [`IBasicAuthCredentials`](auth/basic-authentication.md) |

### Methods

| Name | Description | Return Type |
|  --- | --- | --- |
| `GetBaseUri(Server alias = Server.Default)` | Gets the URL for a particular alias in the current environment and appends it with template parameters. | `string` |
| `ToBuilder()` | Creates an object of the Adyen APIsClient using the values provided for the builder. | `Builder` |

## Adyen APIsClient Builder Class

Class to build instances of Adyen APIsClient.

### Methods

| Name | Description | Return Type |
|  --- | --- | --- |
| `HttpClientConfiguration(Action<`[`HttpClientConfiguration.Builder`](../doc/http-client-configuration-builder.md)`> action)` | Gets the configuration of the Http Client associated with this client. | `Builder` |
| `Timeout(TimeSpan timeout)` | Http client timeout. | `Builder` |
| `Environment(Environment environment)` | Current API environment. | `Builder` |
| `ApiKeyAuthCredentials(Action<ApiKeyAuthModel.Builder> action)` | Sets credentials for ApiKeyAuth. | `Builder` |
| `BasicAuthCredentials(Action<BasicAuthModel.Builder> action)` | Sets credentials for BasicAuth. | `Builder` |

