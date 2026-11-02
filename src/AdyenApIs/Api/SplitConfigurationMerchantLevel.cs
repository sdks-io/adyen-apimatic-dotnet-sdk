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
using AdyenApIs.Requests.SplitConfigurationMerchantLevel;

namespace AdyenApIs.Api;

public sealed class SplitConfigurationMerchantLevel
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal SplitConfigurationMerchantLevel(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Create a split configuration profile
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SplitConfiguration"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="CreateSplitConfigurationError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Creates a split configuration profile to <see href="https://docs.adyen.com/platforms/automatic-split-configuration/">split payments automatically</see>. After you <see href="https://docs.adyen.com/api-explorer/Management/latest/patch/merchants/(merchantId">associate it with a store</see>/stores/(storeId)#request-splitConfiguration) in your merchant account, it splits the funds of all transactions processed through that store between your liable balance account and <see href="https://docs.adyen.com/api-explorer/Management/latest/patch/merchants/(merchantId">your user's balance account</see>/stores/(storeId)#request-splitConfiguration-balanceAccountId).
    /// <para>
    /// To make this request, your API credential must have the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">role</see>:
    /// * Management API - SplitConfiguration read and write
    /// </para>
    /// </remarks>
    public Task<SplitConfiguration> CreateSplitConfiguration(CreateSplitConfigurationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.DefaultManagementApi("/merchants/{merchantId}/splitConfigurations"),
            [new TemplateParam("merchantId", request.MerchantId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<SplitConfiguration>(),
            CreateSplitConfigurationError.Response,
            AuthScheme.Any(_auth.BasicAuth, _auth.ApiKeyAuth),
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Create a rule
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SplitConfiguration"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="CreateSplitConfigurationRuleError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <see href="https://docs.adyen.com/platforms/automatic-split-configuration/manage-split-configurations/api/#create-rule">Creates a rule</see> in the split configuration profile specified in the path.
    /// <para>
    /// To make this request, your API credential must have the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">role</see>:
    /// * Management API - SplitConfiguration read and write
    /// </para>
    /// </remarks>
    public Task<SplitConfiguration> CreateSplitConfigurationRule(CreateSplitConfigurationRuleRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.DefaultManagementApi("/merchants/{merchantId}/splitConfigurations/{splitConfigurationId}"),
            [
                new TemplateParam("merchantId", request.MerchantId),
                new TemplateParam("splitConfigurationId", request.SplitConfigurationId),
            ],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<SplitConfiguration>(),
            CreateSplitConfigurationRuleError.Response,
            AuthScheme.Any(_auth.BasicAuth, _auth.ApiKeyAuth),
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Delete a split configuration profile
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SplitConfiguration"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="DeleteSplitConfigurationError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Deletes the split configuration profile specified in the path.
    /// <para>
    /// To make this request, your API credential must have the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">role</see>:
    /// * Management API - SplitConfiguration read and write
    /// </para>
    /// </remarks>
    public Task<SplitConfiguration> DeleteSplitConfiguration(DeleteSplitConfigurationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.DefaultManagementApi("/merchants/{merchantId}/splitConfigurations/{splitConfigurationId}"),
            [
                new TemplateParam("merchantId", request.MerchantId),
                new TemplateParam("splitConfigurationId", request.SplitConfigurationId),
            ],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<SplitConfiguration>(),
            DeleteSplitConfigurationError.Response,
            AuthScheme.Any(_auth.BasicAuth, _auth.ApiKeyAuth),
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Delete a rule
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SplitConfiguration"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="DeleteSplitConfigurationRuleError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Deletes the rule specified in the path.
    /// <para>
    /// To make this request, your API credential must have the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">role</see>:
    /// * Management API - SplitConfiguration read and write
    /// </para>
    /// </remarks>
    public Task<SplitConfiguration> DeleteSplitConfigurationRule(DeleteSplitConfigurationRuleRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.DefaultManagementApi(
                "/merchants/{merchantId}/splitConfigurations/{splitConfigurationId}/rules/{ruleId}"),
            [
                new TemplateParam("merchantId", request.MerchantId),
                new TemplateParam("splitConfigurationId", request.SplitConfigurationId),
                new TemplateParam("ruleId", request.RuleId),
            ],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<SplitConfiguration>(),
            DeleteSplitConfigurationRuleError.Response,
            AuthScheme.Any(_auth.BasicAuth, _auth.ApiKeyAuth),
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get a split configuration profile
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SplitConfiguration"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetSplitConfigurationError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns the details of the split configuration profile specified in the path.
    /// <para>
    /// To make this request, your API credential must have the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">role</see>:
    /// * Management API - SplitConfiguration read and write
    /// </para>
    /// </remarks>
    public Task<SplitConfiguration> GetSplitConfiguration(GetSplitConfigurationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.DefaultManagementApi("/merchants/{merchantId}/splitConfigurations/{splitConfigurationId}"),
            [
                new TemplateParam("merchantId", request.MerchantId),
                new TemplateParam("splitConfigurationId", request.SplitConfigurationId),
            ],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SplitConfiguration>(),
            GetSplitConfigurationError.Response,
            AuthScheme.Any(_auth.BasicAuth, _auth.ApiKeyAuth),
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get a list of split configuration profiles
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SplitConfigurationList"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="ListSplitConfigurationsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns the list of split configuration profiles for the merchant account.
    /// <para>
    /// To make this request, your API credential must have the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">role</see>:
    /// * Management API - SplitConfiguration read and write
    /// </para>
    /// </remarks>
    public Task<SplitConfigurationList> ListSplitConfigurations(ListSplitConfigurationsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.DefaultManagementApi("/merchants/{merchantId}/splitConfigurations"),
            [new TemplateParam("merchantId", request.MerchantId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SplitConfigurationList>(),
            ListSplitConfigurationsError.Response,
            AuthScheme.Any(_auth.BasicAuth, _auth.ApiKeyAuth),
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Update the description of the split configuration profile
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SplitConfiguration"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="UpdateSplitConfigurationError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Changes the description of the split configuration profile specified in the path.
    /// <para>
    /// To make this request, your API credential must have the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">role</see>:
    /// * Management API - SplitConfiguration read and write
    /// </para>
    /// </remarks>
    public Task<SplitConfiguration> UpdateSplitConfiguration(UpdateSplitConfigurationOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.DefaultManagementApi("/merchants/{merchantId}/splitConfigurations/{splitConfigurationId}"),
            [
                new TemplateParam("merchantId", request.MerchantId),
                new TemplateParam("splitConfigurationId", request.SplitConfigurationId),
            ],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            new HttpMethod("PATCH"),
            JsonRequest.Create(request.Body),
            JsonResponse.Create<SplitConfiguration>(),
            UpdateSplitConfigurationError.Response,
            AuthScheme.Any(_auth.BasicAuth, _auth.ApiKeyAuth),
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Update the split conditions
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SplitConfiguration"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="UpdateSplitConfigurationRuleError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Changes the <see href="https://docs.adyen.com/platforms/automatic-split-configuration/manage-split-configurations/api/#update-condition">split conditions of the rule</see> specified in the path.
    /// <para>
    /// To make this request, your API credential must have the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">role</see>:
    /// * Management API - SplitConfiguration read and write
    /// </para>
    /// </remarks>
    public Task<SplitConfiguration> UpdateSplitConfigurationRule(UpdateSplitConfigurationRuleOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.DefaultManagementApi(
                "/merchants/{merchantId}/splitConfigurations/{splitConfigurationId}/rules/{ruleId}"),
            [
                new TemplateParam("merchantId", request.MerchantId),
                new TemplateParam("splitConfigurationId", request.SplitConfigurationId),
                new TemplateParam("ruleId", request.RuleId),
            ],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            new HttpMethod("PATCH"),
            JsonRequest.Create(request.Body),
            JsonResponse.Create<SplitConfiguration>(),
            UpdateSplitConfigurationRuleError.Response,
            AuthScheme.Any(_auth.BasicAuth, _auth.ApiKeyAuth),
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Update the split logic
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SplitConfiguration"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="UpdateSplitLogicError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Changes the <see href="https://docs.adyen.com/platforms/automatic-split-configuration/manage-split-configurations/api/#update-split-logic">split logic</see> specified in the path.
    /// <para>
    /// To make this request, your API credential must have the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">role</see>:
    /// * Management API - SplitConfiguration read and write
    /// </para>
    /// </remarks>
    public Task<SplitConfiguration> UpdateSplitLogic(UpdateSplitLogicRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.DefaultManagementApi(
                "/merchants/{merchantId}/splitConfigurations/{splitConfigurationId}/rules/{ruleId}/splitLogic/{splitLogicId}"),
            [
                new TemplateParam("merchantId", request.MerchantId),
                new TemplateParam("splitConfigurationId", request.SplitConfigurationId),
                new TemplateParam("ruleId", request.RuleId),
                new TemplateParam("splitLogicId", request.SplitLogicId),
            ],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            new HttpMethod("PATCH"),
            JsonRequest.Create(request.Body),
            JsonResponse.Create<SplitConfiguration>(),
            UpdateSplitLogicError.Response,
            AuthScheme.Any(_auth.BasicAuth, _auth.ApiKeyAuth),
            requestOptions,
            cancellationToken);
}
