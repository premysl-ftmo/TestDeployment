namespace StriveApi.Database.Models.MTISite;

public partial class AppStoreActivity
{
    public int AppStoreLogId { get; set; }

    public string EventType { get; set; } = null!;

    public DateTime EventTimeUtc { get; set; }

    public int AppStorePackageId { get; set; }

    public int AppStoreDownloadId { get; set; }

    public string? ComputerId { get; set; }

    public string? Param1 { get; set; }

    public string Ipaddress { get; set; } = null!;
}
