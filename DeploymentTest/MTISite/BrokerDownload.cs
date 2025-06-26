namespace StriveApi.Database.Models.MTISite;

public partial class BrokerDownload
{
    public int DownloadId { get; set; }

    public string? AccountId { get; set; }

    public string? UserId { get; set; }

    public string BrokerId { get; set; } = null!;

    public DateTime? CreationTime { get; set; }

    public string? DownloadIpaddress { get; set; }

    public DateTime? InstallTime { get; set; }

    public string? InstallIpaddress { get; set; }
}
