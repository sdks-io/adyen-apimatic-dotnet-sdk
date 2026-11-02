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
using AdyenApIs.Requests.AccountCompanyLevel;

namespace AdyenApIs.Api;

public sealed class AccountCompanyLevel
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal AccountCompanyLevel(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Get a company account
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CompanyManagementApi"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetCompanyError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns the company account specified in the path. Your API credential must have access to the company account.
    /// <para>
    /// To make this request, your API credential must have the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">roles</see>:
    /// * Management API—Account read
    /// </para>
    /// </remarks>
    public Task<CompanyManagementApi> GetCompany(GetCompanyRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.DefaultManagementApi("/companies/{companyId}"),
            [new TemplateParam("companyId", request.CompanyId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<CompanyManagementApi>(),
            GetCompanyError.Response,
            AuthScheme.Any(_auth.BasicAuth, _auth.ApiKeyAuth),
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get a list of company accounts
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ListCompanyResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="ListCompaniesError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns the list of company accounts that your API credential has access to. The list is grouped into pages as defined by the query parameters.
    /// <para>
    /// To make this request, your API credential must have the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">roles</see>:
    /// </para>
    /// <list type="bullet">
    ///   <item><description>Management API—Account read</description></item>
    /// </list>
    /// </remarks>
    public Task<ListCompanyResponse> ListCompanies(ListCompaniesRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.DefaultManagementApi("/companies"),
            [],
            [new Param("pageNumber", request.PageNumber), new Param("pageSize", request.PageSize)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ListCompanyResponse>(),
            ListCompaniesError.Response,
            AuthScheme.Any(_auth.BasicAuth, _auth.ApiKeyAuth),
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get a list of merchant accounts
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ListMerchantResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="ListCompanyMerchantsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns the list of merchant accounts under the company account specified in the path. The list only includes merchant accounts that your API credential has access to. The list is grouped into pages as defined by the query parameters.
    /// <para>
    /// To make this request, your API credential must have the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">roles</see>:
    /// * Management API—Account read
    /// </para>
    /// </remarks>
    public Task<ListMerchantResponse> ListCompanyMerchants(ListCompanyMerchantsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.DefaultManagementApi("/companies/{companyId}/merchants"),
            [new TemplateParam("companyId", request.CompanyId)],
            [new Param("pageNumber", request.PageNumber), new Param("pageSize", request.PageSize)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ListMerchantResponse>(),
            ListCompanyMerchantsError.Response,
            AuthScheme.Any(_auth.BasicAuth, _auth.ApiKeyAuth),
            requestOptions,
            cancellationToken);
}
