namespace StriveApi.Database.Models.MTISite;

public partial class TradingDrill
{
    public int DrillCounter { get; set; }

    public string UserId { get; set; } = null!;

    public string DrillType { get; set; } = null!;

    public string AccountId { get; set; } = null!;

    public int DrillState { get; set; }

    public int FmestatusCode { get; set; }

    public DateTime CreationTimeUtc { get; set; }

    public DateTime TerminationTimeUtc { get; set; }

    public int CertificatePdfstatus { get; set; }

    public DateTime PdfstartTime { get; set; }
}
