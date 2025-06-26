namespace StriveApi.Database.Models.MTISite;

public partial class SlingshotTracking
{
    public DateTime HitTimeUtc { get; set; }

    public string Ipaddress { get; set; } = null!;

    public string PackageId { get; set; } = null!;

    public string PremiumMode { get; set; } = null!;

    public string ComputerId { get; set; } = null!;

    public string PackageTitle { get; set; } = null!;

    public string PlatformId { get; set; } = null!;
}
