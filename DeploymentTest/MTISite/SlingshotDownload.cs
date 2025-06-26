namespace StriveApi.Database.Models.MTISite;

public partial class SlingshotDownload
{
    public string SlingshotId { get; set; } = null!;

    public DateTime DownloadDateUtc { get; set; }

    public string DownloadIpaddress { get; set; } = null!;

    public string DownloadUserId { get; set; } = null!;
}
