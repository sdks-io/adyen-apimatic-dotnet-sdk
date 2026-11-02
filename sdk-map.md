<!-- Generated file — do not edit; regenerated with the SDK. -->

# SDK map — Adyen APIs (.NET)

> A generated table of contents for this SDK. Consult this map and its sub-pages to learn signatures, error types, and server/auth wiring **by lookup**. Model shapes and enum values are *not* duplicated here — the map names the file declaring each type; read the shape there. The compiler is the backstop: a wrong name fails to build.

|  |  |
| --- | --- |
| SDK display name | Adyen APIs |
| Root namespace | `AdyenApIs` |
| Target framework | `netstandard2.0` (C# `LangVersion 14`, `Nullable enable`) |
| API spec version | `71` |
| Generator | APIMatic |

Staleness check: the API spec version above changes when the SDK is regenerated from a new spec. If a lookup here fails to compile, trust the compiler and re-read the source file named in the row.

All `Source` paths on this map and its sub-pages are relative to the **SDK root** — the directory holding this file — never to the page that carries them; the project file is `src/AdyenApIs/AdyenApIs.csproj`. Open them as-is from the SDK root, from any page; if the SDK sits under a subdirectory of a larger repo, prefix that subdirectory.

---

## Getting a client

```csharp
var httpClient = new HttpClient();
// TODO: configure more client options here
var options = new AdyenApIsClientOptions
{
    ApiKeyAuth = "YOUR_API_KEY",
    BasicAuth = new BasicAuthCredentials { Username = "YOUR_USERNAME", Password = "YOUR_PASSWORD" },
    Environment = ServerEnvironment.Production,
};
var client = new AdyenApIsClient(httpClient, options);
```

DI alternative (`services.AddAdyenApIsClient`):

```csharp
services.AddAdyenApIsClient(options =>
{
    options.ApiKeyAuth = "YOUR_API_KEY";
    options.BasicAuth = new BasicAuthCredentials { Username = "YOUR_USERNAME", Password = "YOUR_PASSWORD" };
    options.Environment = ServerEnvironment.Production;
    // TODO: configure more client options here
});
```

Every API group is a property on the client (e.g. `client.ApiCredentialsCompanyLevel`). Source: `src/AdyenApIs/AdyenApIsClient.cs`. The only constructor is `AdyenApIsClient(HttpClient httpClient, AdyenApIsClientOptions options)`.

All `AdyenApIsClientOptions` properties (source: `src/AdyenApIs/AdyenApIsClientOptions.cs`):

| Property | Type |
| --- | --- |
| `Environment` | `ServerEnvironment` |
| `Retry` | `RetryOptions` |
| `Logging` | `LoggingOptions` |
| `TimeProvider` | `TimeProvider` |
| `Server` | `ServerOptions` |
| `StreamReadTimeout` | `TimeSpan?` |
| `Hooks` | `IReadOnlyList<SdkHook>` |
| `ApiKeyAuth` | `string?` |
| `ApiKeyAuthProvider` | `CredentialProvider<string>?` |
| `BasicAuth` | `BasicAuthCredentials?` |
| `BasicAuthProvider` | `CredentialProvider<BasicAuthCredentials>?` |

`ServerEnvironment` (source: `src/AdyenApIs/Servers/ServerEnvironment.cs`, namespace `AdyenApIs.Servers`)
`BasicAuthCredentials` (source: `src/AdyenApIs/Core/Authentication/Basic/BasicAuthCredentials.cs`, namespace `AdyenApIs.Core.Authentication.Basic`)

`RetryOptions` members (namespace `AdyenApIs.Core.Configuration` — add `using AdyenApIs.Core.Configuration;`; source: `src/AdyenApIs/Core/Configuration/RetryOptions.cs`; all members are `required`, so build a full instance or start from `RetryOptions.Default()`):

| Member | Type |
| --- | --- |
| `StatusCodesToRetry` | `IReadOnlyList<HttpStatusCode>` |
| `HttpMethodsToRetry` | `IReadOnlyList<HttpMethod>` |
| `MaxRetries` | `int` |
| `Delay` | `TimeSpan` |
| `Timeout` | `TimeSpan?` |
| `BackOffFactor` | `int` |
| `UseExponentialBackoff` | `bool` |
| `MaxJitter` | `TimeSpan` |
| `OnRetry` | `Action<RetryAttempt>?` |

---

## Error-handling model (read once — applies to every operation)

Operations are **throw-based**. On an error status the SDK throws `ApiException<TError>` (`src/AdyenApIs/Core/Exceptions/ApiException.cs`, namespace `AdyenApIs.Core.Exceptions`) exposing `.Error` of type `TError` beside the `StatusCode`, `Headers` and `ContentType` of the response. There are two cases:

- **Case A — typed error.** `TError` is a generated `…Error : ApiError` class (namespace `AdyenApIs.Errors`) with status-specific `TryGet…(out …)` accessors (each returns `true` when that shape is present) plus the inherited `TryGetRawError(out RawError)` fallback. The operation blocks name the exact `TryGet…` methods and the HTTP status each maps to.
- **Case B — raw error.** `TError` is `RawError` (`src/AdyenApIs/Core/ErrorResponse/RawError.cs`, namespace `AdyenApIs.Core.ErrorResponse`): `StatusCode: HttpStatusCode` · `ReadAsBytes(): ReadOnlyMemory<byte>` · `ReadAsString(): string` · `ReadAsJson<T>(): T?`.

⚠ Each of the three lives in its own namespace. `src/AdyenApIs/Core/` holds several namespaces, so a catch block naming `ApiException<T>`, a typed `{Operation}Error` and `RawError` together needs a `using` for each.

`ApiException<TError>` is one leaf of the `SdkException` family (`src/AdyenApIs/Core/Exceptions/SdkException.cs`): a request that produced no usable response surfaces as `SdkConnectionException` or `SdkTimeoutException`, a body that does not match its declared type as `ResponseDeserializationException`, and a required credential that is not configured, or one that could not be applied, as `AuthSchemeException`. Every one of them names the failed call. The full table is in [README → Error Handling](README.md#error-handling).

Core error types (`src/AdyenApIs/Core/ErrorResponse/`) — public members with their **declared types**, verbatim from source:

| Type | Public members | Source |
| --- | --- | --- |
| `ApiError` — abstract base of the 154 typed error classes in `src/AdyenApIs/Errors/` | `TryGetRawError(out RawError error): bool` | `src/AdyenApIs/Core/ErrorResponse/ApiError.cs` |
| `RawError` | `StatusCode: HttpStatusCode` · `ReadAsBytes(): ReadOnlyMemory<byte>` · `ReadAsString(): string` · `ReadAsJson<T>(): T?` | `src/AdyenApIs/Core/ErrorResponse/RawError.cs` |

Typed-error payload shapes (the `out` types in each operation page's error-accessor cells) are ordinary records/unions — no special handling. The operation's **Type sources** table gives the file that declares each one; read field names, declared types, and JSON wire names there, as for any other model.

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
}
catch (ApiException<CreateCompanyApiCredentialError> ex)
{
    // Case A — typed error
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // Handle 400, 401, 403, 422, 500
    }
    else if (ex.Error.TryGetRawError(out var raw))
    {
        // Any other error status
    }
}
catch (ApiException<RawError> ex)
{
    // Case B — raw error
    // ex.Error.StatusCode, ex.Error.ReadAsString(), ex.Error.ReadAsJson<T>()
}
```

**No-throw (`…Result`) variants: absent across this SDK** — every operation is throw-only. Of **162 operations**, **154 are Case A (typed)** and **8 are Case B (raw)**.

---

## Operations — by controller (36 groups, 162 operations)

Each links to a sub-page with one row per operation: signature, the request record's required members, query-param wire names, return type, error Case A/B, and Case A's typed accessors with their statuses. Each operation also carries a **Type sources** table — every type it names, with the file that declares it — so resolving a body, return, or error payload to its source is a lookup, never a search. `RawError` is excluded there (its members and path are above); an operation with no table names nothing but primitives and `RawError`.

**Each row states what is specific to its operation. Everything below holds for EVERY operation unless that operation's row says otherwise, so a row silent on one of these points is telling you the default here applies — take it and move on rather than opening the source to confirm it.**

| Applies to every operation | Stated where | A row appears only when |
| --- | --- | --- |
| **Throw-only** — no `…Result`/no-throw variant exists anywhere in this SDK | this page, Error-handling model | a no-throw sibling exists (none do at this SDK version) |
| **No pagination** — the operation returns a single response, not a `Pageable` | here | pagination is offered — the block carries a **Pagination** bullet naming the posture (page-, offset-, cursor- or link-based, or the `page`-without-page-size case) |
| **Case B error accessors are always these four** — `StatusCode: HttpStatusCode` · `ReadAsBytes(): ReadOnlyMemory<byte>` · `ReadAsString(): string` · `ReadAsJson<T>(): T?` | the `RawError` row above | never — a `Case B` label always implies exactly these four; Case A rows list their own typed accessors |
| **Server group `Default`** — base URL per Servers & auth below | here | the operation is on another group — its block carries a **Server group** bullet |
| **Inputs are one request record** — an operation that takes input takes a single request record as its first parameter; build it with an object initializer, using the property names in the record's source (its file is in the operation's **Type sources**). A member the row does not list as required is optional or already carries the spec's default | here | never — it always holds |

**The HTTP verb and route live on the operation itself**, in the source file named at the top of its operations page. This map is method-first: the C# method is the interface you call. When something wire-level needs the route — reproducing a raw request, pointing the client at a mock, reading a provider-side log — read it from that file; do not reconstruct it from memory or infer it from the method name.

**The endpoint's behavioural prose lives there too**, as the XML `<remarks>` on the method. Rows here give you the contract — names, types, shapes, errors. Where an operation's *semantics* decide what you must pass — a parameter whose value changes server-side behaviour, an ordering or exclusivity rule between fields — that is what `<remarks>` settles; read it there rather than filling it in from memory.

| Controller (`client.X`) | Ops | Page |
| --- | --- | --- |
| `ApiCredentialsCompanyLevel` | 4 | [map/operations/ApiCredentialsCompanyLevel.md](map/operations/ApiCredentialsCompanyLevel.md) |
| `ApiCredentialsMerchantLevel` | 4 | [map/operations/ApiCredentialsMerchantLevel.md](map/operations/ApiCredentialsMerchantLevel.md) |
| `ApiKeyCompanyLevel` | 1 | [map/operations/ApiKeyCompanyLevel.md](map/operations/ApiKeyCompanyLevel.md) |
| `ApiKeyMerchantLevel` | 1 | [map/operations/ApiKeyMerchantLevel.md](map/operations/ApiKeyMerchantLevel.md) |
| `AccountCompanyLevel` | 3 | [map/operations/AccountCompanyLevel.md](map/operations/AccountCompanyLevel.md) |
| `AccountMerchantLevel` | 4 | [map/operations/AccountMerchantLevel.md](map/operations/AccountMerchantLevel.md) |
| `AccountStoreLevel` | 8 | [map/operations/AccountStoreLevel.md](map/operations/AccountStoreLevel.md) |
| `AllowedOriginsCompanyLevel` | 4 | [map/operations/AllowedOriginsCompanyLevel.md](map/operations/AllowedOriginsCompanyLevel.md) |
| `AllowedOriginsMerchantLevel` | 4 | [map/operations/AllowedOriginsMerchantLevel.md](map/operations/AllowedOriginsMerchantLevel.md) |
| `AndroidFilesCompanyLevel` | 6 | [map/operations/AndroidFilesCompanyLevel.md](map/operations/AndroidFilesCompanyLevel.md) |
| `ClientKeyCompanyLevel` | 1 | [map/operations/ClientKeyCompanyLevel.md](map/operations/ClientKeyCompanyLevel.md) |
| `ClientKeyMerchantLevel` | 1 | [map/operations/ClientKeyMerchantLevel.md](map/operations/ClientKeyMerchantLevel.md) |
| `Donations` | 2 | [map/operations/Donations.md](map/operations/Donations.md) |
| `Modifications` | 6 | [map/operations/Modifications.md](map/operations/Modifications.md) |
| `MyApiCredential` | 6 | [map/operations/MyApiCredential.md](map/operations/MyApiCredential.md) |
| `Orders` | 3 | [map/operations/Orders.md](map/operations/Orders.md) |
| `PaymentLinks` | 3 | [map/operations/PaymentLinks.md](map/operations/PaymentLinks.md) |
| `PaymentMethodsMerchantLevel` | 6 | [map/operations/PaymentMethodsMerchantLevel.md](map/operations/PaymentMethodsMerchantLevel.md) |
| `Payments` | 6 | [map/operations/Payments.md](map/operations/Payments.md) |
| `PayoutSettingsMerchantLevel` | 5 | [map/operations/PayoutSettingsMerchantLevel.md](map/operations/PayoutSettingsMerchantLevel.md) |
| `RecurringApi` | 4 | [map/operations/RecurringApi.md](map/operations/RecurringApi.md) |
| `SplitConfigurationMerchantLevel` | 9 | [map/operations/SplitConfigurationMerchantLevel.md](map/operations/SplitConfigurationMerchantLevel.md) |
| `TerminalActionsCompanyLevel` | 2 | [map/operations/TerminalActionsCompanyLevel.md](map/operations/TerminalActionsCompanyLevel.md) |
| `TerminalActionsTerminalLevel` | 1 | [map/operations/TerminalActionsTerminalLevel.md](map/operations/TerminalActionsTerminalLevel.md) |
| `TerminalOrdersCompanyLevel` | 10 | [map/operations/TerminalOrdersCompanyLevel.md](map/operations/TerminalOrdersCompanyLevel.md) |
| `TerminalOrdersMerchantLevel` | 10 | [map/operations/TerminalOrdersMerchantLevel.md](map/operations/TerminalOrdersMerchantLevel.md) |
| `TerminalSettingsCompanyLevel` | 4 | [map/operations/TerminalSettingsCompanyLevel.md](map/operations/TerminalSettingsCompanyLevel.md) |
| `TerminalSettingsMerchantLevel` | 4 | [map/operations/TerminalSettingsMerchantLevel.md](map/operations/TerminalSettingsMerchantLevel.md) |
| `TerminalSettingsStoreLevel` | 8 | [map/operations/TerminalSettingsStoreLevel.md](map/operations/TerminalSettingsStoreLevel.md) |
| `TerminalSettingsTerminalLevel` | 4 | [map/operations/TerminalSettingsTerminalLevel.md](map/operations/TerminalSettingsTerminalLevel.md) |
| `TerminalsTerminalLevel` | 2 | [map/operations/TerminalsTerminalLevel.md](map/operations/TerminalsTerminalLevel.md) |
| `UsersCompanyLevel` | 4 | [map/operations/UsersCompanyLevel.md](map/operations/UsersCompanyLevel.md) |
| `UsersMerchantLevel` | 4 | [map/operations/UsersMerchantLevel.md](map/operations/UsersMerchantLevel.md) |
| `Utility` | 4 | [map/operations/Utility.md](map/operations/Utility.md) |
| `WebhooksCompanyLevel` | 7 | [map/operations/WebhooksCompanyLevel.md](map/operations/WebhooksCompanyLevel.md) |
| `WebhooksMerchantLevel` | 7 | [map/operations/WebhooksMerchantLevel.md](map/operations/WebhooksMerchantLevel.md) |

---

## Models — where they live, how to build them

**Shapes live only in the source.** Every file under `src/AdyenApIs/Models/`, `src/AdyenApIs/Errors/` and `src/AdyenApIs/Requests/` declares exactly one public type, named after the file, and no two share a name — so a type name *is* its path. Take it from the operation's **Type sources** table, or build it from the kind's directory below. Never grep for a type.

| Group | Count | Directory (file = `<TypeName>.cs`) |
| --- | --- | --- |
| Records (plain `record` data models) | 735 | `src/AdyenApIs/Models/` |
| Unions (`AnyOf`) — variant factories + `TryGet…` | 4 | `src/AdyenApIs/Models/AnyOf/` |
| Compositions (`AllOf`) — constituent types as `required` properties | 2 | `src/AdyenApIs/Models/AllOf/` |
| Enums (`OpenStringEnum<T>` / `OpenIntEnum<T>`) — C# member names + wire values | 198 | `src/AdyenApIs/Models/Enums/` |
| Typed error classes (`: ApiError`, one per Case A operation) | 154 | `src/AdyenApIs/Errors/` |
| Request records (one per operation that takes input; never serialized) | 159 | `src/AdyenApIs/Requests/` — a controller's records sit in a folder named after it (an operation with several tags is filed under the first tag it declares) |

Conventions: records are immutable, `init`-only; `required` properties must be set in the object initializer; `T?` is optional. A field's wire name is its `[JsonPropertyName]` and often differs from the C# name (`AmountInCents` ↔ `amount_in_cents`) — read it off the property, don't derive it. `OneOf`/`AnyOf` unions wrap `Optional<T>` variants — build via static factory or implicit conversion, read via `TryGet…(out …)`; `AllOf` compositions are not unions — every constituent is a `required` property, so set them all, and those constituent properties carry no `[JsonPropertyName]` and have no wire name of their own, because the generated converter flattens each constituent's own fields directly into the one parent JSON object. Enums are **not** C# enums — use the static members, whose names are PascalCase even when the wire value isn't (`CollectionMethod.Invoice`, not `.invoice`); there is no public factory, so resolve a raw value with `TryGetKnownValue` and branch with the generated `Match`, whose `otherwise` arm receives any value the SDK does not declare.

Namespaces by content type (add `using` accordingly):

| Contents | Namespace |
| --- | --- |
| Client & options (root) | `AdyenApIs` |
| Operation controllers (`src/AdyenApIs/Api/`) | `AdyenApIs.Api` |
| Records (`src/AdyenApIs/Models/`) | `AdyenApIs.Models` |
| Enums (`src/AdyenApIs/Models/Enums/`) | `AdyenApIs.Models.Enums` |
| AnyOf unions (`src/AdyenApIs/Models/AnyOf/`) | `AdyenApIs.Models.AnyOf` |
| AllOf compositions (`src/AdyenApIs/Models/AllOf/`) | `AdyenApIs.Models.AllOf` |
| Error classes (`src/AdyenApIs/Errors/`) | `AdyenApIs.Errors` |
| Request records (`src/AdyenApIs/Requests/`) | `AdyenApIs.Requests` — plus `.<Controller>` for a controller's records (an operation with several tags is filed under the first tag it declares) |

---

## Servers & auth

**API key (header `X-API-Key`).** Set `options.ApiKeyAuth = "<api_key>"`, or `options.ApiKeyAuthProvider` to a delegate asked on every request; sent as the `X-API-Key` request header.

**Basic auth.** Set `options.BasicAuth = new BasicAuthCredentials { Username = …, Password = … }`, or `options.BasicAuthProvider` to a delegate asked on every request.

Operation blocks name their credential in an **Auth** bullet; an operation whose spec declares no scheme carries no such bullet.

- `AND` — every credential listed must be configured; the call fails before anything is sent, naming each one that is not.
- `OR` — the first configured credential that applies is sent, in the order listed; a configured one that fails falls through to the next; when none is configured the call fails before anything is sent, naming all of them.
- `OR anonymous` — the operation accepts anonymous callers: it is authenticated when a whole alternative listed before it is configured (every credential in an AND group), and sent without credentials otherwise.
- `(scopes: …)` — the OAuth2 scopes the operation's token is requested with; a client-credentials scheme mints one token per scope set.

A required credential you never configured fails the call with `AuthSchemeException` before anything is sent, so a `401` on an operation that requires a credential means the server rejected the one that was sent. A credential option left `null` is read from an environment variable when the client is constructed; the README's **Credentials from environment variables** table names them. A value set in code always wins, including the placeholder assignments in the **Getting a client** sample; delete the line for any credential you supply through an environment variable.

**Environments.** `options.Environment` selects the target environment (`src/AdyenApIs/Servers/ServerEnvironment.cs`):

| Environment | Value | Hosting |
| --- | --- | --- |
| `ServerEnvironment.Production` *(default)* | `production` | — |

**2 server groups.** Base-URL templates and override points (`options.Server.…`):

| Group | `Production` base URL | Override point |
| --- | --- | --- |
| `Default` | `https://checkout-test.adyen.com/v71` | `options.Server.Default.Production.BaseUrl` |
| `DefaultManagementApi` | `https://management-test.adyen.com/v3` | `options.Server.DefaultManagementApi.Production.BaseUrl` |

Retry/resilience is configurable via `options.Retry` (`RetryOptions`, backed by Polly).

