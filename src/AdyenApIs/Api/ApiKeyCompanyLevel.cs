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
using AdyenApIs.Requests.ApiKeyCompanyLevel;

namespace AdyenApIs.Api;

public sealed class ApiKeyCompanyLevel
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal ApiKeyCompanyLevel(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Generate new API key
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="GenerateApiKeyResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GenerateCompanyApiKeyError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns a new API key for the API credential. You can use the new API key a few minutes after generating it. The old API key stops working 24 hours after generating a new one.
    /// <para>
    /// To make this request, your API credential must have the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">roles</see>:
    /// * Management API—API credentials read and write
    /// </para>
    /// </remarks>
    public Task<GenerateApiKeyResponse> GenerateCompanyApiKey(GenerateCompanyApiKeyRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.DefaultManagementApi("/companies/{companyId}/apiCredentials/{apiCredentialId}/generateApiKey"),
            [
                new TemplateParam("companyId", request.CompanyId),
                new TemplateParam("apiCredentialId", request.ApiCredentialId),
            ],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<GenerateApiKeyResponse>(),
            GenerateCompanyApiKeyError.Response,
            AuthScheme.Any(_auth.BasicAuth, _auth.ApiKeyAuth),
            requestOptions,
            cancellationToken);
}
