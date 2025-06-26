namespace StriveApi.Database.Models.MTISite;

public partial class AppStoreDownload
{
    public int AppStoreDownloadId { get; set; }

    public int AppStorePackageId { get; set; }

    public string? UserId { get; set; }

    public DateTime DownloadDateUtc { get; set; }

    public short WantNotifications { get; set; }

    public int DownloadVersion { get; set; }

    public string? Ipaddress { get; set; }

    public string? IpaddressCountry { get; set; }
}
