namespace StriveApi.Database.Models.MTISite;

public partial class UsageTrackingCache
{
    public DateTime HitTimeUtc { get; set; }

    public string? BrokerId { get; set; }

    public string UsageKey { get; set; } = null!;

    public int AccountNumber { get; set; }

    public string BrokerServer { get; set; } = null!;

    public string ComputerId { get; set; } = null!;

    public string PlatformId { get; set; } = null!;
}
