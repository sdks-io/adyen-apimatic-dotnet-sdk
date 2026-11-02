using AdyenApIs.Servers;

namespace AdyenApIs;

public class ServerOptions
{
    public DefaultOptions Default { get; set; } = new();
    public DefaultManagementApiOptions DefaultManagementApi { get; set; } = new();
}
