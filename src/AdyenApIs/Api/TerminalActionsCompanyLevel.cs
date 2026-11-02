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
using AdyenApIs.Requests.TerminalActionsCompanyLevel;

namespace AdyenApIs.Api;

public sealed class TerminalActionsCompanyLevel
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal TerminalActionsCompanyLevel(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Get terminal action
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ExternalTerminalAction"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetCompanyTerminalActionError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns the details of the <see href="https://docs.adyen.com/point-of-sale/automating-terminal-management/terminal-actions-api">terminal action</see> identified in the path.
    /// To make this request, your API credential must have one of the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">roles</see>:
    /// * Management API—Terminal actions read
    /// * Management API—Terminal actions read and write
    /// <para>
    /// In the live environment, requests to this endpoint are subject to <see href="https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment">rate limits</see>.
    /// </para>
    /// </remarks>
    public Task<ExternalTerminalAction> GetCompanyTerminalAction(GetCompanyTerminalActionRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.DefaultManagementApi("/companies/{companyId}/terminalActions/{actionId}"),
            [new TemplateParam("companyId", request.CompanyId), new TemplateParam("actionId", request.ActionId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ExternalTerminalAction>(),
            GetCompanyTerminalActionError.Response,
            AuthScheme.Any(_auth.BasicAuth, _auth.ApiKeyAuth),
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get a list of terminal actions
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ListExternalTerminalActionsResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="ListCompanyTerminalActionsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns the <see href="https://docs.adyen.com/point-of-sale/automating-terminal-management/terminal-actions-api">terminal actions</see> that have been scheduled for the company identified in the path.The response doesn't include actions that are scheduled by Adyen.
    /// To make this request, your API credential must have one of the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">roles</see>:
    /// * Management API—Terminal actions read
    /// * Management API—Terminal actions read and write
    /// <para>
    /// In the live environment, requests to this endpoint are subject to <see href="https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment">rate limits</see>.
    /// </para>
    /// </remarks>
    public Task<ListExternalTerminalActionsResponse> ListCompanyTerminalActions(ListCompanyTerminalActionsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.DefaultManagementApi("/companies/{companyId}/terminalActions"),
            [new TemplateParam("companyId", request.CompanyId)],
            [
                new Param("pageNumber", request.PageNumber),
                new Param("pageSize", request.PageSize),
                new Param("status", request.Status),
                new Param("type", request.Type),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ListExternalTerminalActionsResponse>(),
            ListCompanyTerminalActionsError.Response,
            AuthScheme.Any(_auth.BasicAuth, _auth.ApiKeyAuth),
            requestOptions,
            cancellationToken);
}
