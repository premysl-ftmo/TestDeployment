namespace StriveApi.Database.Models.MTISite;

public partial class SoftwareLicencesIpaddressBlock
{
    public string LicenceId { get; set; } = null!;

    public string Ipaddress { get; set; } = null!;

    public DateTime BlockTimeUtc { get; set; }
}
