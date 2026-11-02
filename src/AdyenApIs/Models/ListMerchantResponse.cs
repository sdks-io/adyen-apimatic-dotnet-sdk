using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace AdyenApIs.Models;

public record ListMerchantResponse
{
    /// <summary>
    /// Pagination references.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("_links")]
    public PaginationLinksListMerchantResponse? Links { get; init; }

    /// <summary>
    /// The list of merchant accounts.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("data")]
    public IReadOnlyList<Merchant>? Data { get; init; }

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
