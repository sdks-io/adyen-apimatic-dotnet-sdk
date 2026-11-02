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
using AdyenApIs.Requests.UsersMerchantLevel;

namespace AdyenApIs.Api;

public sealed class UsersMerchantLevel
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal UsersMerchantLevel(RawClient rawClient, Server server, AuthSchemes auth)
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
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CreateUserResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="CreateMerchantUserError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Creates a user for the <c>merchantId</c> specified in the path.
    /// <para>
    /// To make this request, your API credential must have the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">role</see>:
    /// * Management API—Users read and write
    /// </para>
    /// </remarks>
    public Task<CreateUserResponse> CreateMerchantUser(CreateMerchantUserOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.DefaultManagementApi("/merchants/{merchantId}/users"),
            [new TemplateParam("merchantId", request.MerchantId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<CreateUserResponse>(),
            CreateMerchantUserError.Response,
            AuthScheme.Any(_auth.BasicAuth, _auth.ApiKeyAuth),
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get user details
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="User"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetMerchantUserError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns user details for the <c>userId</c> and the <c>merchantId</c> specified in the path.
    /// <para>
    /// To make this request, your API credential must have the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">role</see>:
    /// * Management API—Users read and write
    /// </para>
    /// </remarks>
    public Task<User> GetMerchantUser(GetMerchantUserRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.DefaultManagementApi("/merchants/{merchantId}/users/{userId}"),
            [new TemplateParam("merchantId", request.MerchantId), new TemplateParam("userId", request.UserId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<User>(),
            GetMerchantUserError.Response,
            AuthScheme.Any(_auth.BasicAuth, _auth.ApiKeyAuth),
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get a list of users
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ListMerchantUsersResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="ListMerchantUsersError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns a list of users associated with the <c>merchantId</c> specified in the path.
    /// <para>
    /// To make this request, your API credential must have the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">role</see>:
    /// * Management API—Users read and write
    /// </para>
    /// </remarks>
    public Task<ListMerchantUsersResponse> ListMerchantUsers(ListMerchantUsersRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.DefaultManagementApi("/merchants/{merchantId}/users"),
            [new TemplateParam("merchantId", request.MerchantId)],
            [
                new Param("pageNumber", request.PageNumber),
                new Param("pageSize", request.PageSize),
                new Param("username", request.Username),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ListMerchantUsersResponse>(),
            ListMerchantUsersError.Response,
            AuthScheme.Any(_auth.BasicAuth, _auth.ApiKeyAuth),
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Update a user
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="User"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="UpdateMerchantUserError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Updates user details for the <c>userId</c> and the <c>merchantId</c> specified in the path.
    /// <para>
    /// To make this request, your API credential must have the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">role</see>:
    /// * Management API—Users read and write
    /// </para>
    /// </remarks>
    public Task<User> UpdateMerchantUser(UpdateMerchantUserOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.DefaultManagementApi("/merchants/{merchantId}/users/{userId}"),
            [new TemplateParam("merchantId", request.MerchantId), new TemplateParam("userId", request.UserId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            new HttpMethod("PATCH"),
            JsonRequest.Create(request.Body),
            JsonResponse.Create<User>(),
            UpdateMerchantUserError.Response,
            AuthScheme.Any(_auth.BasicAuth, _auth.ApiKeyAuth),
            requestOptions,
            cancellationToken);
}
