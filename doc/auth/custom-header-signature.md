
# Custom Header Signature



Documentation for accessing and setting credentials for ApiKeyAuth.

## Auth Credentials

| Name | Type | Description | Setter | Getter |
|  --- | --- | --- | --- | --- |
| XApiKey | `string` | - | `XApiKey` | `XApiKey` |



**Note:** Auth credentials can be set using `ApiKeyAuthCredentials` in the client builder and accessed through `ApiKeyAuthCredentials` method in the client instance.

## Usage Example

### Client Initialization

You must provide credentials in the client as shown in the following code snippet.

```csharp
using AdyenApIs.Standard;
using AdyenApIs.Standard.Authentication;

namespace ConsoleApp;

AdyenApIsClient client = new AdyenApIsClient.Builder()
    .ApiKeyAuthCredentials(
        new ApiKeyAuthModel.Builder(
            "X-API-Key"
        )
        .Build())
    .Build();
```


