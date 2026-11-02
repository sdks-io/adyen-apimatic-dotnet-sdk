using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace AdyenApIs.Models;

public record ListCompanyResponse
{
    /// <summary>
    /// Pagination references.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("_links")]
    public PaginationLinksListCompanyResponse? Links { get; init; }

    /// <summary>
    /// The list of companies.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("data")]
    public IReadOnlyList<CompanyManagementApi>? Data { get; init; }

    /// <summary>
    /// Total number of items.
    /// </summary>
    [JsonPropertyName("itemsTotal")]
    public required int ItemsTotal { get; init; }

    /// <summary>
    /// Total number of pages.
    /// </summary>
    [JsonPropertyName("pagesTotal")]
    public required int PagesTotal { get; init; }
}
