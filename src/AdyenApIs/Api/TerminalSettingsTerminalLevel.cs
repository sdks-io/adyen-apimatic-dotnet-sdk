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
using AdyenApIs.Requests.TerminalSettingsTerminalLevel;

namespace AdyenApIs.Api;

public sealed class TerminalSettingsTerminalLevel
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal TerminalSettingsTerminalLevel(RawClient rawClient, Server server, AuthSchemes auth)
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
    /// <exception cref="ApiException{TError}"> of <see cref="GetTerminalLogoError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns the logo that is configured for the payment terminal identified in the path.
    /// The logo is returned as a Base64-encoded string. You need to Base64-decode the string to get the actual image file.
    /// <para>
    /// To make this request, your API credential must have one of the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">roles</see>:
    /// * Management API—Terminal settings read
    /// * Management API—Terminal settings read and write
    /// </para>
    /// <para>
    /// In the live environment, requests to this endpoint are subject to <see href="https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment">rate limits</see>.
    /// </para>
    /// </remarks>
    public Task<Logo> GetTerminalLogo(GetTerminalLogoRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.DefaultManagementApi("/terminals/{terminalId}/terminalLogos"),
            [new TemplateParam("terminalId", request.TerminalId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<Logo>(),
            GetTerminalLogoError.Response,
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
    /// <exception cref="ApiException{TError}"> of <see cref="GetTerminalSettingsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns the settings that are configured for the payment terminal identified in the path.
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
    public Task<TerminalSettings> GetTerminalSettings(GetTerminalSettingsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.DefaultManagementApi("/terminals/{terminalId}/terminalSettings"),
            [new TemplateParam("terminalId", request.TerminalId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<TerminalSettings>(),
            GetTerminalSettingsError.Response,
            AuthScheme.Any(_auth.BasicAuth, _auth.ApiKeyAuth),
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Update the logo
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Logo"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="UpdateTerminalLogoError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Updates the logo for the payment terminal identified in the path.
    /// <list type="bullet">
    ///   <item><description>To change the logo, specify the image file as a Base64-encoded string.</description></item>
    ///   <item><description>To restore the logo inherited from a higher level (store, merchant account, or company account), specify an empty logo value.</description></item>
    /// </list>
    /// <para>
    /// To make this request, your API credential must have the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">role</see>:
    /// * Management API—Terminal settings read and write
    /// </para>
    /// <para>
    /// In the live environment, requests to this endpoint are subject to <see href="https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment">rate limits</see>.
    /// </para>
    /// </remarks>
    public Task<Logo> UpdateTerminalLogo(UpdateTerminalLogoRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.DefaultManagementApi("/terminals/{terminalId}/terminalLogos"),
            [new TemplateParam("terminalId", request.TerminalId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            new HttpMethod("PATCH"),
            JsonRequest.Create(request.Body),
            JsonResponse.Create<Logo>(),
            UpdateTerminalLogoError.Response,
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
    /// <exception cref="ApiException{TError}"> of <see cref="UpdateTerminalSettingsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Updates the settings that are configured for the payment terminal identified in the path.
    /// <list type="bullet">
    ///   <item><description>To change a parameter value, include the full object that contains the parameter, even if you don't want to change all parameters in the object.</description></item>
    ///   <item><description>To restore a parameter value inherited from a higher level, include the full object that contains the parameter, and specify an empty value for the parameter or omit the parameter.</description></item>
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
    public Task<TerminalSettings> UpdateTerminalSettings(UpdateTerminalSettingsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.DefaultManagementApi("/terminals/{terminalId}/terminalSettings"),
            [new TemplateParam("terminalId", request.TerminalId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            new HttpMethod("PATCH"),
            JsonRequest.Create(request.Body),
            JsonResponse.Create<TerminalSettings>(),
            UpdateTerminalSettingsError.Response,
            AuthScheme.Any(_auth.BasicAuth, _auth.ApiKeyAuth),
            requestOptions,
            cancellationToken);
}
