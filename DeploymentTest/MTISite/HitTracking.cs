namespace StriveApi.Database.Models.MTISite;

public partial class HitTracking
{
    public DateTime HitTimeUtc { get; set; }

    public string HitUrl { get; set; } = null!;

    public string? UserId { get; set; }

    public int Data1 { get; set; }

    public string Ipaddress { get; set; } = null!;
}
