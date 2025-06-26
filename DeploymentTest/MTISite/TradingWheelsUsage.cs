namespace StriveApi.Database.Models.MTISite;

public partial class TradingWheelsUsage
{
    public DateTime UsageTimeUtc { get; set; }

    public string LicenceCode { get; set; } = null!;

    public string Ipaddress { get; set; } = null!;

    public string ComputerId { get; set; } = null!;

    public string DemoServer { get; set; } = null!;

    public string DemoAccount { get; set; } = null!;

    public string LiveServer { get; set; } = null!;

    public string LiveAccount { get; set; } = null!;
}
