using System.Net.Http;
using AdyenApIs.Api;
using AdyenApIs.Core;
using AdyenApIs.Core.Configuration;
using AdyenApIs.Core.Logging;
using AdyenApIs.Core.Models;

namespace AdyenApIs;

/// <summary>
/// Adyen Checkout API Configure and manage your Adyen company and merchant accounts, stores, and payment terminals.
/// ## Authentication
/// Each request to the Management API must be signed with an API key. <see href="https://docs.adyen.com/development-resources/api-credentials#generate-api-key">Generate your API key</see> in the Customer Area and then set this key to the <c>X-API-Key</c> header value.
/// <para>
/// To access the live endpoints, you need to generate a new API key in your live Customer Area.
/// ## Versioning
/// </para>
/// <para>
/// Management API handles versioning as part of the endpoint URL. For example, to send a request to this version of the <c>/companies/{companyId}/webhooks</c> endpoint, use:
/// </para>
/// <code>
/// https://management-test.adyen.com/v3/companies/{companyId}/webhooks
/// </code>
/// <para>
/// ## Going live
/// </para>
/// <para>
/// To access the live endpoints, you need an API key from your live Customer Area. Use this API key to make requests to:
/// </para>
/// <code>
/// https://management-live.adyen.com/v3
/// </code>
/// <para>
/// ## Release notes
/// Have a look at the <see href="https://docs.adyen.com/release-notes/management-api">release notes</see> to find out what changed in this version!
/// </para>
/// </summary>
public sealed class AdyenApIsClient
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    public AdyenApIsClient(HttpClient httpClient, AdyenApIsClientOptions options)
    {
        _server = new Server(options.Environment, options.Server);
        var queryParameterFactory = new QueryParameterFactory([]);
        var templateParamsFactory = new TemplateParamsFactory([]);
        var urlFactory = new UriFactory(queryParameterFactory, templateParamsFactory);
        var httpStatusPolicy = new HttpStatusPolicy([]);
        var headersFactory = new HeadersFactory([
            new HeaderParam("User-Agent", "AdyenApIsClient/71 CSharp"),
            new HeaderParam("X-APIMatic-Lang", "CSharp"),
            new HeaderParam("X-APIMatic-Package-Version", "71"),
            new HeaderParam("X-APIMatic-Gen-Version", "4.0.0"),
            new HeaderParam("X-APIMatic-OS", RuntimeEnvironment.Os),
            new HeaderParam("X-APIMatic-Runtime", RuntimeEnvironment.Runtime),
        ]);
        var resiliencePipelineFactory = new ResiliencePipelineFactory(options.Retry, options.TimeProvider);
        var httpLogger = new HttpLogger(
            options.Logging.WithEnvironmentDefaults("ADYEN_AP_IS_LOG"),
            "AdyenApIsClient",
            options.TimeProvider);
        var responseContexts = new ResponseContextFactory(options.TimeProvider, options.StreamReadTimeout);
        _rawClient =
            new RawClient(
                httpClient,
                urlFactory,
                httpStatusPolicy,
                headersFactory,
                resiliencePipelineFactory,
                httpLogger,
                options.Hooks,
                responseContexts);
        _auth = new AuthSchemes(options);
    }

    public ApiCredentialsCompanyLevel ApiCredentialsCompanyLevel =>
        field ??= new ApiCredentialsCompanyLevel(_rawClient, _server, _auth);

    public ApiCredentialsMerchantLevel ApiCredentialsMerchantLevel =>
        field ??= new ApiCredentialsMerchantLevel(_rawClient, _server, _auth);

    public ApiKeyCompanyLevel ApiKeyCompanyLevel => field ??= new ApiKeyCompanyLevel(_rawClient, _server, _auth);

    public ApiKeyMerchantLevel ApiKeyMerchantLevel => field ??= new ApiKeyMerchantLevel(_rawClient, _server, _auth);

    public AccountCompanyLevel AccountCompanyLevel => field ??= new AccountCompanyLevel(_rawClient, _server, _auth);

    public AccountMerchantLevel AccountMerchantLevel => field ??= new AccountMerchantLevel(_rawClient, _server, _auth);

    public AccountStoreLevel AccountStoreLevel => field ??= new AccountStoreLevel(_rawClient, _server, _auth);

    public AllowedOriginsCompanyLevel AllowedOriginsCompanyLevel =>
        field ??= new AllowedOriginsCompanyLevel(_rawClient, _server, _auth);

    public AllowedOriginsMerchantLevel AllowedOriginsMerchantLevel =>
        field ??= new AllowedOriginsMerchantLevel(_rawClient, _server, _auth);

    public AndroidFilesCompanyLevel AndroidFilesCompanyLevel =>
        field ??= new AndroidFilesCompanyLevel(_rawClient, _server, _auth);

    public ClientKeyCompanyLevel ClientKeyCompanyLevel =>
        field ??= new ClientKeyCompanyLevel(_rawClient, _server, _auth);

    public ClientKeyMerchantLevel ClientKeyMerchantLevel =>
        field ??= new ClientKeyMerchantLevel(_rawClient, _server, _auth);

    public Donations Donations => field ??= new Donations(_rawClient, _server, _auth);

    public Modifications Modifications => field ??= new Modifications(_rawClient, _server, _auth);

    public MyApiCredential MyApiCredential => field ??= new MyApiCredential(_rawClient, _server, _auth);

    public Orders Orders => field ??= new Orders(_rawClient, _server, _auth);

    public PaymentLinks PaymentLinks => field ??= new PaymentLinks(_rawClient, _server, _auth);

    public PaymentMethodsMerchantLevel PaymentMethodsMerchantLevel =>
        field ??= new PaymentMethodsMerchantLevel(_rawClient, _server, _auth);

    public Payments Payments => field ??= new Payments(_rawClient, _server, _auth);

    public PayoutSettingsMerchantLevel PayoutSettingsMerchantLevel =>
        field ??= new PayoutSettingsMerchantLevel(_rawClient, _server, _auth);

    public RecurringApi RecurringApi => field ??= new RecurringApi(_rawClient, _server, _auth);

    public SplitConfigurationMerchantLevel SplitConfigurationMerchantLevel =>
        field ??= new SplitConfigurationMerchantLevel(_rawClient, _server, _auth);

    public TerminalActionsCompanyLevel TerminalActionsCompanyLevel =>
        field ??= new TerminalActionsCompanyLevel(_rawClient, _server, _auth);

    public TerminalActionsTerminalLevel TerminalActionsTerminalLevel =>
        field ??= new TerminalActionsTerminalLevel(_rawClient, _server, _auth);

    public TerminalOrdersCompanyLevel TerminalOrdersCompanyLevel =>
        field ??= new TerminalOrdersCompanyLevel(_rawClient, _server, _auth);

    public TerminalOrdersMerchantLevel TerminalOrdersMerchantLevel =>
        field ??= new TerminalOrdersMerchantLevel(_rawClient, _server, _auth);

    public TerminalSettingsCompanyLevel TerminalSettingsCompanyLevel =>
        field ??= new TerminalSettingsCompanyLevel(_rawClient, _server, _auth);

    public TerminalSettingsMerchantLevel TerminalSettingsMerchantLevel =>
        field ??= new TerminalSettingsMerchantLevel(_rawClient, _server, _auth);

    public TerminalSettingsStoreLevel TerminalSettingsStoreLevel =>
        field ??= new TerminalSettingsStoreLevel(_rawClient, _server, _auth);

    public TerminalSettingsTerminalLevel TerminalSettingsTerminalLevel =>
        field ??= new TerminalSettingsTerminalLevel(_rawClient, _server, _auth);

    public TerminalsTerminalLevel TerminalsTerminalLevel =>
        field ??= new TerminalsTerminalLevel(_rawClient, _server, _auth);

    public UsersCompanyLevel UsersCompanyLevel => field ??= new UsersCompanyLevel(_rawClient, _server, _auth);

    public UsersMerchantLevel UsersMerchantLevel => field ??= new UsersMerchantLevel(_rawClient, _server, _auth);

    public Utility Utility => field ??= new Utility(_rawClient, _server, _auth);

    public WebhooksCompanyLevel WebhooksCompanyLevel => field ??= new WebhooksCompanyLevel(_rawClient, _server, _auth);

    public WebhooksMerchantLevel WebhooksMerchantLevel =>
        field ??= new WebhooksMerchantLevel(_rawClient, _server, _auth);
}
