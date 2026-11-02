using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace AdyenApIs.Models;

public record ListCompanyUsersResponse
{
    /// <summary>
    /// Pagination references.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("_links")]
    public PaginationLinksListCompanyUsersResponse? Links { get; init; }

    /// <summary>
    /// The list of users.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("data")]
    public IReadOnlyList<CompanyUser>? Data { get; init; }

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
