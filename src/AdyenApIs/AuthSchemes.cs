using AdyenApIs.Core;
using AdyenApIs.Core.Authentication;
using AdyenApIs.Core.Authentication.ApiKey;
using AdyenApIs.Core.Authentication.Basic;

namespace AdyenApIs;

internal sealed class AuthSchemes
{
    public IAuthScheme ApiKeyAuth { get; }
    public IAuthScheme BasicAuth { get; }

    public AuthSchemes(AdyenApIsClientOptions options)
    {
        ApiKeyAuth =
            ApiKeyHeaderScheme.Create(
                "ApiKeyAuth",
                "X-API-Key",
                options.ApiKeyAuthProvider,
                options.ApiKeyAuth ?? EnvironmentVariables.Get("ADYEN_AP_IS_API_KEY_AUTH"));
        BasicAuth =
            BasicAuthScheme.Create(
                "BasicAuth",
                options.BasicAuthProvider,
                options.BasicAuth.WithEnvironmentDefaults(
                    "ADYEN_AP_IS_BASIC_AUTH_USERNAME",
                    "ADYEN_AP_IS_BASIC_AUTH_PASSWORD"));
    }
}
