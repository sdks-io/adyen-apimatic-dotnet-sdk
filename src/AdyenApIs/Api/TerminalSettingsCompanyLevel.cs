using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using AdyenApIs.Core;
using AdyenApIs.Core.Authentication;
using AdyenApIs.Core.Exceptions;
using AdyenApIs.Core.Models;
using AdyenApIs.Core.Request;
using AdyenApIs.Core.Response;
using AdyenApIs.Errors;
using AdyenApIs.Models;
using AdyenApIs.Requests.TerminalSettingsCompanyLevel;

namespace AdyenApIs.Api;

public sealed class TerminalSettingsCompanyLevel
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal TerminalSettingsCompanyLevel(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Get the terminal logo
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Logo"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetCompanyTerminalLogoError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns the logo that is configured for a specific payment terminal model at the company identified in the path.
    /// <para>
    /// The logo is returned as a Base64-encoded string. You need to Base64-decode the string to get the actual image file.
    /// This logo applies to all terminals of the specified model under the company, unless a different logo is configured at a lower level (merchant account, store, or individual terminal).
    /// </para>
    /// <para>
    /// To make this request, your API credential must have one of the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">roles</see>:
    /// * Management API—Terminal settings read
    /// * Management API—Terminal settings read and write
    /// </para>
    /// <para>
    /// In the live environment, requests to this endpoint are subject to <see href="https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment">rate limits</see>.
    /// </para>
    /// </remarks>
    public Task<Logo> GetCompanyTerminalLogo(GetCompanyTerminalLogoRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.DefaultManagementApi("/companies/{companyId}/terminalLogos"),
            [new TemplateParam("companyId", request.CompanyId)],
            [new Param("model", request.Model)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<Logo>(),
            GetCompanyTerminalLogoError.Response,
            AuthScheme.Any(_auth.BasicAuth, _auth.ApiKeyAuth),
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get terminal settings
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TerminalSettings"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetCompanyTerminalSettingsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns the payment terminal settings that are configured for the company identified in the path. These settings apply to all terminals under the company, unless different values are configured at a lower level (merchant account, store, or individual terminal).
    /// <para>
    /// To make this request, your API credential must have one of the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">roles</see>:
    /// * Management API—Terminal settings read
    /// * Management API—Terminal settings read and write
    /// </para>
    /// <para>
    /// For <see href="https://docs.adyen.com/point-of-sale/automating-terminal-management/configure-terminals-api#sensitive-terminal-settings">sensitive terminal settings</see>, your API credential must have the following role:
    /// * Management API—Terminal settings Advanced read and write
    /// </para>
    /// <para>
    /// In the live environment, requests to this endpoint are subject to <see href="https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment">rate limits</see>.
    /// </para>
    /// </remarks>
    public Task<TerminalSettings> GetCompanyTerminalSettings(GetCompanyTerminalSettingsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.DefaultManagementApi("/companies/{companyId}/terminalSettings"),
            [new TemplateParam("companyId", request.CompanyId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<TerminalSettings>(),
            GetCompanyTerminalSettingsError.Response,
            AuthScheme.Any(_auth.BasicAuth, _auth.ApiKeyAuth),
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Update the terminal logo
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Logo"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="UpdateCompanyTerminalLogoError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Updates the logo that is configured for a specific payment terminal model at the company identified in the path. You can update the logo for only one terminal model at a time.
    /// This logo applies to all terminals of the specified model under the company, unless a different logo is configured at a lower level (merchant account, store, or individual terminal).
    /// * To change the logo, specify the image file as a Base64-encoded string.
    /// * To restore the logo inherited from the Adyen PSP level, specify an empty logo value.
    /// <para>
    /// To make this request, your API credential must have the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">role</see>:
    /// * Management API—Terminal settings read and write
    /// </para>
    /// <para>
    /// In the live environment, requests to this endpoint are subject to <see href="https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment">rate limits</see>.
    /// </para>
    /// </remarks>
    public Task<Logo> UpdateCompanyTerminalLogo(UpdateCompanyTerminalLogoRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.DefaultManagementApi("/companies/{companyId}/terminalLogos"),
            [new TemplateParam("companyId", request.CompanyId)],
            [new Param("model", request.Model)],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            new HttpMethod("PATCH"),
            JsonRequest.Create(request.Body),
            JsonResponse.Create<Logo>(),
            UpdateCompanyTerminalLogoError.Response,
            AuthScheme.Any(_auth.BasicAuth, _auth.ApiKeyAuth),
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Update terminal settings
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TerminalSettings"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="UpdateCompanyTerminalSettingsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Updates payment terminal settings for the company identified in the path. These settings apply to all terminals under the company, unless different values are configured at a lower level (merchant account, store, or individual terminal).
    /// <list type="bullet">
    ///   <item><description>To change a parameter value, include the full object that contains the parameter, even if you don't want to change all parameters in the object.</description></item>
    ///   <item><description>To restore a parameter value inherited from the Adyen PSP level, include the full object that contains the parameter, and specify an empty value for the parameter or omit the parameter.</description></item>
    ///   <item><description>Objects that are not included in the request are not updated.</description></item>
    /// </list>
    /// <para>
    /// To make this request, your API credential must have the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">role</see>:
    /// * Management API—Terminal settings read and write
    /// </para>
    /// <para>
    /// For <see href="https://docs.adyen.com/point-of-sale/automating-terminal-management/configure-terminals-api#sensitive-terminal-settings">sensitive terminal settings</see>, your API credential must have the following role:
    /// * Management API—Terminal settings Advanced read and write
    /// </para>
    /// <para>
    /// In the live environment, requests to this endpoint are subject to <see href="https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment">rate limits</see>.
    /// </para>
    /// </remarks>
    public Task<TerminalSettings> UpdateCompanyTerminalSettings(UpdateCompanyTerminalSettingsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.DefaultManagementApi("/companies/{companyId}/terminalSettings"),
            [new TemplateParam("companyId", request.CompanyId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            new HttpMethod("PATCH"),
            JsonRequest.Create(request.Body),
            JsonResponse.Create<TerminalSettings>(),
            UpdateCompanyTerminalSettingsError.Response,
            AuthScheme.Any(_auth.BasicAuth, _auth.ApiKeyAuth),
            requestOptions,
            cancellationToken);
}
