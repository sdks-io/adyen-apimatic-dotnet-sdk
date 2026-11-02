using System.Collections.Generic;
using Microsoft.Extensions.Logging;
using AdyenApIs.Core.Hooks;
using AdyenApIs.Core.Models;

namespace AdyenApIs.Core;

public sealed record RequestOptions
{
    public LogLevel? LogLevel { get; init; }

    public IReadOnlyList<HeaderParam>? Headers { get; init; }

    public IReadOnlyList<SdkHook>? Hooks { get; init; }
}
