namespace StriveApi.Database.Models.MTISite;

public partial class UsageTracking
{
    public string UsageKey { get; set; } = null!;

    public string Ipaddress { get; set; } = null!;

    public string ComputerKey { get; set; } = null!;

    public DateTime FirstHitUtc { get; set; }

    public DateTime MostRecentHitUtc { get; set; }

    public int TotalHits { get; set; }
}
