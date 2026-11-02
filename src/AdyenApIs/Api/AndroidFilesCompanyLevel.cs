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
using AdyenApIs.Requests.AndroidFilesCompanyLevel;

namespace AdyenApIs.Api;

public sealed class AndroidFilesCompanyLevel
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal AndroidFilesCompanyLevel(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Upload Android App
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="UploadAndroidAppResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="CreateAndroidAppError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Uploads an Android APK file to Adyen.
    /// The maximum APK file size is 200 MB.
    /// To make this request, your API credential must have the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">role</see>:
    /// * Management API—Android files read and write
    /// <para>
    /// In the live environment, requests to this endpoint are subject to <see href="https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment">rate limits</see>.
    /// &gt;By choosing to upload, install, or run any third-party applications on an Adyen payment terminal, you accept full responsibility and liability for any consequences of uploading, installing, or running any such applications.
    /// </para>
    /// </remarks>
    public Task<UploadAndroidAppResponse> CreateAndroidApp(CreateAndroidAppRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.DefaultManagementApi("/companies/{companyId}/androidApps"),
            [new TemplateParam("companyId", request.CompanyId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<UploadAndroidAppResponse>(),
            CreateAndroidAppError.Response,
            AuthScheme.Any(_auth.BasicAuth, _auth.ApiKeyAuth),
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get Android app
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AndroidApp"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetAndroidAppError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns the details of the Android app identified in the path.
    /// These apps have been uploaded to Adyen and can be installed or uninstalled on Android payment terminals through <see href="https://docs.adyen.com/point-of-sale/automating-terminal-management/terminal-actions-api">terminal actions</see>.
    /// <para>
    /// To make this request, your API credential must have one of the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">roles</see>:
    /// * Management API—Android files read
    /// * Management API—Android files read and write
    /// </para>
    /// <para>
    /// In the live environment, requests to this endpoint are subject to <see href="https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment">rate limits</see>.
    /// </para>
    /// </remarks>
    public Task<AndroidApp> GetAndroidApp(GetAndroidAppRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.DefaultManagementApi("/companies/{companyId}/androidApps/{id}"),
            [new TemplateParam("companyId", request.CompanyId), new TemplateParam("id", request.Id)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<AndroidApp>(),
            GetAndroidAppError.Response,
            AuthScheme.Any(_auth.BasicAuth, _auth.ApiKeyAuth),
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get a list of Android apps
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AndroidAppsResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="ListAndroidAppsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns a list of the Android apps that are available for the company identified in the path.
    /// These apps have been uploaded to Adyen and can be installed or uninstalled on Android payment terminals through <see href="https://docs.adyen.com/point-of-sale/automating-terminal-management/terminal-actions-api">terminal actions</see>.
    /// <para>
    /// To make this request, your API credential must have one of the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">roles</see>:
    /// * Management API—Android files read
    /// * Management API—Android files read and write
    /// * Management API—Terminal actions read
    /// * Management API—Terminal actions read and write
    /// </para>
    /// <para>
    /// In the live environment, requests to this endpoint are subject to <see href="https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment">rate limits</see>.
    /// </para>
    /// </remarks>
    public Task<AndroidAppsResponse> ListAndroidApps(ListAndroidAppsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.DefaultManagementApi("/companies/{companyId}/androidApps"),
            [new TemplateParam("companyId", request.CompanyId)],
            [
                new Param("pageNumber", request.PageNumber),
                new Param("pageSize", request.PageSize),
                new Param("packageName", request.PackageName),
                new Param("versionCode", request.VersionCode),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<AndroidAppsResponse>(),
            ListAndroidAppsError.Response,
            AuthScheme.Any(_auth.BasicAuth, _auth.ApiKeyAuth),
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get a list of Android certificates
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AndroidCertificatesResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="ListAndroidCertificatesError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns a list of the Android certificates that are available for the company identified in the path.
    /// Typically, these certificates enable running apps on Android payment terminals. The certificates in the list have been uploaded to Adyen and can be installed or uninstalled on Android terminals through <see href="https://docs.adyen.com/point-of-sale/automating-terminal-management/terminal-actions-api">terminal actions</see>.
    /// <para>
    /// To make this request, your API credential must have one of the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">roles</see>:
    /// * Management API—Android files read
    /// * Management API—Android files read and write
    /// * Management API—Terminal actions read
    /// * Management API—Terminal actions read and write
    /// </para>
    /// <para>
    /// In the live environment, requests to this endpoint are subject to <see href="https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment">rate limits</see>.
    /// </para>
    /// </remarks>
    public Task<AndroidCertificatesResponse> ListAndroidCertificates(ListAndroidCertificatesRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.DefaultManagementApi("/companies/{companyId}/androidCertificates"),
            [new TemplateParam("companyId", request.CompanyId)],
            [
                new Param("pageNumber", request.PageNumber),
                new Param("pageSize", request.PageSize),
                new Param("certificateName", request.CertificateName),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<AndroidCertificatesResponse>(),
            ListAndroidCertificatesError.Response,
            AuthScheme.Any(_auth.BasicAuth, _auth.ApiKeyAuth),
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Reprocess Android App
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ReprocessAndroidAppResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="UpdateAndroidAppError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Reuploads the Android app identified in the path.
    /// To make this request, your API credential must have this <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">role</see>:
    /// * Management API—Android files read and write
    /// <para>
    /// In the live environment, requests to this endpoint are subject to <see href="https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment">rate limits</see>.
    /// &gt;By choosing to upload, install, or run any third-party applications on an Adyen payment terminal, you accept full responsibility and liability for any consequences of uploading, installing, or running any such applications.
    /// </para>
    /// </remarks>
    public Task<ReprocessAndroidAppResponse> UpdateAndroidApp(UpdateAndroidAppRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.DefaultManagementApi("/companies/{companyId}/androidApps/{id}"),
            [new TemplateParam("companyId", request.CompanyId), new TemplateParam("id", request.Id)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            new HttpMethod("PATCH"),
            EmptyBody.Instance,
            JsonResponse.Create<ReprocessAndroidAppResponse>(),
            UpdateAndroidAppError.Response,
            AuthScheme.Any(_auth.BasicAuth, _auth.ApiKeyAuth),
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Upload Android Certificate
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="UploadAndroidCertificateResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="UploadAndroidCertificateError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Uploads an Android Certificate file to Adyen.
    /// <para>
    /// In the live environment, requests to this endpoint are subject to <see href="https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment">rate limits</see>.
    /// </para>
    /// </remarks>
    public Task<UploadAndroidCertificateResponse> UploadAndroidCertificate(UploadAndroidCertificateRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.DefaultManagementApi("/companies/{companyId}/androidCertificates"),
            [new TemplateParam("companyId", request.CompanyId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<UploadAndroidCertificateResponse>(),
            UploadAndroidCertificateError.Response,
            AuthScheme.Any(_auth.BasicAuth, _auth.ApiKeyAuth),
            requestOptions,
            cancellationToken);
}
