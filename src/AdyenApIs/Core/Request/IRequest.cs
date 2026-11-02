using System.Net.Http;

namespace AdyenApIs.Core.Request;

internal interface IRequest
{
    HttpContent Get();

    bool CanRetry { get; }
}
