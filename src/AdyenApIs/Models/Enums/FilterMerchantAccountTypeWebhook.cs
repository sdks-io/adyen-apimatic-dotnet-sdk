using System;
using System.Text.Json.Serialization;
using AdyenApIs.Core.Enum;

namespace AdyenApIs.Models.Enums;

/// <summary>
/// Shows how merchant accounts are included in company-level webhooks. Possible values:
/// * <b>includeAccounts</b>
/// * <b>excludeAccounts</b>
/// * <b>allAccounts</b>: Includes all merchant accounts, and does not require specifying <c>filterMerchantAccounts</c>.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<FilterMerchantAccountTypeWebhook>))]
public sealed record FilterMerchantAccountTypeWebhook : OpenStringEnum<FilterMerchantAccountTypeWebhook>
{
    private FilterMerchantAccountTypeWebhook(string value) : base(value)
    {
    }

    public static readonly FilterMerchantAccountTypeWebhook AllAccounts = new("allAccounts");

    public static readonly FilterMerchantAccountTypeWebhook ExcludeAccounts = new("excludeAccounts");

    public static readonly FilterMerchantAccountTypeWebhook IncludeAccounts = new("includeAccounts");

    public TResult Match<TResult>(Func<TResult> onAllAccounts,
        Func<TResult> onExcludeAccounts,
        Func<TResult> onIncludeAccounts,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == AllAccounts => onAllAccounts(),
            _ when this == ExcludeAccounts => onExcludeAccounts(),
            _ when this == IncludeAccounts => onIncludeAccounts(),
            _ => otherwise(Value)
        };

    public void Match(Action onAllAccounts,
        Action onExcludeAccounts,
        Action onIncludeAccounts,
        Action<string> otherwise)
    {
        if (this == AllAccounts) onAllAccounts();
        else if (this == ExcludeAccounts) onExcludeAccounts();
        else if (this == IncludeAccounts) onIncludeAccounts();
        else otherwise(Value);
    }
}
