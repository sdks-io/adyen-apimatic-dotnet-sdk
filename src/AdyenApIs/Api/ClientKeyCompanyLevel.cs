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
using AdyenApIs.Requests.ClientKeyCompanyLevel;

namespace AdyenApIs.Api;

public sealed class ClientKeyCompanyLevel
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal ClientKeyCompanyLevel(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Generate new client key
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="GenerateClientKeyResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GenerateCompanyClientKeyError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns a new <see href="https://docs.adyen.com/development-resources/client-side-authentication#how-it-works">client key</see> for the API credential identified in the path. You can use the new client key a few minutes after generating it. The old client key stops working 24 hours after generating a new one.
    /// <para>
    /// To make this request, your API credential must have the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">roles</see>:
    /// * Management API—API credentials read and write
    /// </para>
    /// </remarks>
    public Task<GenerateClientKeyResponse> GenerateCompanyClientKey(GenerateCompanyClientKeyRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.DefaultManagementApi("/companies/{companyId}/apiCredentials/{apiCredentialId}/generateClientKey"),
            [
                new TemplateParam("companyId", request.CompanyId),
                new TemplateParam("apiCredentialId", request.ApiCredentialId),
            ],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<GenerateClientKeyResponse>(),
            GenerateCompanyClientKeyError.Response,
            AuthScheme.Any(_auth.BasicAuth, _auth.ApiKeyAuth),
            requestOptions,
            cancellationToken);
}
