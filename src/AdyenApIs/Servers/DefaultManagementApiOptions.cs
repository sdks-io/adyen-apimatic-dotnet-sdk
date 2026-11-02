using AdyenApIs.Core.Models;

namespace AdyenApIs.Servers;

public class DefaultManagementApiOptions
{
    public ProductionOptions Production { get; set; } = new();

    internal UrlTemplate Resolve(ServerEnvironment environment, string path) =>
        environment.Match(() => new UrlTemplate(Production.BaseUrl, path, []));

    public class ProductionOptions
    {
        public string BaseUrl { get; set; } = "https://management-test.adyen.com/v3";
    }
}
