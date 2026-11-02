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
using AdyenApIs.Requests.UsersCompanyLevel;

namespace AdyenApIs.Api;

public sealed class UsersCompanyLevel
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal UsersCompanyLevel(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Create a new user
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CreateCompanyUserResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="CreateCompanyUserError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Creates the user for the <c>companyId</c> identified in the path.
    /// <para>
    /// To make this request, your API credential must have the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">role</see>:
    /// * Management API—Users read and write
    /// </para>
    /// </remarks>
    public Task<CreateCompanyUserResponse> CreateCompanyUser(CreateCompanyUserOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.DefaultManagementApi("/companies/{companyId}/users"),
            [new TemplateParam("companyId", request.CompanyId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<CreateCompanyUserResponse>(),
            CreateCompanyUserError.Response,
            AuthScheme.Any(_auth.BasicAuth, _auth.ApiKeyAuth),
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get user details
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CompanyUser"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetCompanyUserError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns user details for the <c>userId</c> and the <c>companyId</c> identified in the path.
    /// <para>
    /// To make this request, your API credential must have the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">role</see>:
    /// * Management API—Users read and write
    /// </para>
    /// </remarks>
    public Task<CompanyUser> GetCompanyUser(GetCompanyUserRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.DefaultManagementApi("/companies/{companyId}/users/{userId}"),
            [new TemplateParam("companyId", request.CompanyId), new TemplateParam("userId", request.UserId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<CompanyUser>(),
            GetCompanyUserError.Response,
            AuthScheme.Any(_auth.BasicAuth, _auth.ApiKeyAuth),
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get a list of users
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ListCompanyUsersResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="ListCompanyUsersError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns the list of users for the <c>companyId</c> identified in the path.
    /// <para>
    /// To make this request, your API credential must have the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">role</see>:
    /// * Management API—Users read and write
    /// </para>
    /// </remarks>
    public Task<ListCompanyUsersResponse> ListCompanyUsers(ListCompanyUsersRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.DefaultManagementApi("/companies/{companyId}/users"),
            [new TemplateParam("companyId", request.CompanyId)],
            [
                new Param("pageNumber", request.PageNumber),
                new Param("pageSize", request.PageSize),
                new Param("username", request.Username),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ListCompanyUsersResponse>(),
            ListCompanyUsersError.Response,
            AuthScheme.Any(_auth.BasicAuth, _auth.ApiKeyAuth),
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Update user details
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CompanyUser"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="UpdateCompanyUserError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Updates user details for the <c>userId</c> and the <c>companyId</c> identified in the path.
    /// <para>
    /// To make this request, your API credential must have the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">role</see>:
    /// * Management API—Users read and write
    /// </para>
    /// </remarks>
    public Task<CompanyUser> UpdateCompanyUser(UpdateCompanyUserOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.DefaultManagementApi("/companies/{companyId}/users/{userId}"),
            [new TemplateParam("companyId", request.CompanyId), new TemplateParam("userId", request.UserId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            new HttpMethod("PATCH"),
            JsonRequest.Create(request.Body),
            JsonResponse.Create<CompanyUser>(),
            UpdateCompanyUserError.Response,
            AuthScheme.Any(_auth.BasicAuth, _auth.ApiKeyAuth),
            requestOptions,
            cancellationToken);
}
