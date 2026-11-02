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
using AdyenApIs.Requests.TerminalsTerminalLevel;

namespace AdyenApIs.Api;

public sealed class TerminalsTerminalLevel
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal TerminalsTerminalLevel(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Get a list of terminals
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ListTerminalsResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="ListTerminalsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns the payment terminals that the API credential has access to and that match the query parameters.
    /// To make this request, your API credential must have the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">roles</see>:
    /// * Management API — Terminal actions read
    /// <para>
    /// In the live environment, requests to this endpoint are subject to <see href="https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment">rate limits</see>.
    /// </para>
    /// </remarks>
    public Task<ListTerminalsResponse> ListTerminals(ListTerminalsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.DefaultManagementApi("/terminals"),
            [],
            [
                new Param("searchQuery", request.SearchQuery),
                new Param("otpQuery", request.OtpQuery),
                new Param("countries", request.Countries),
                new Param("merchantIds", request.MerchantIds),
                new Param("storeIds", request.StoreIds),
                new Param("brandModels", request.BrandModels),
                new Param("pageNumber", request.PageNumber),
                new Param("pageSize", request.PageSize),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ListTerminalsResponse>(),
            ListTerminalsError.Response,
            AuthScheme.Any(_auth.BasicAuth, _auth.ApiKeyAuth),
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Reassign a terminal
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="ReassignTerminalError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Reassigns a payment terminal to a company account, merchant account, merchant account inventory, or a store.
    /// <para>
    /// To make this request, your API credential must have the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">role</see>:
    /// * Management API—Assign Terminal
    /// </para>
    /// <para>
    /// In the live environment, requests to this endpoint are subject to <see href="https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment">rate limits</see>.
    /// </para>
    /// </remarks>
    public Task ReassignTerminal(ReassignTerminalRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.DefaultManagementApi("/terminals/{terminalId}/reassign"),
            [new TemplateParam("terminalId", request.TerminalId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            VoidResponse.Instance,
            ReassignTerminalError.Response,
            AuthScheme.Any(_auth.BasicAuth, _auth.ApiKeyAuth),
            requestOptions,
            cancellationToken);
}
