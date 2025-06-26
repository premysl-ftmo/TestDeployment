namespace StriveApi.Database.Models.MTISite;

public partial class Apiaccount
{
    public string ApiaccountKey { get; set; } = null!;

    public string UserId { get; set; } = null!;

    public string ApiloginKey { get; set; } = null!;

    public byte HasAccountSync { get; set; }

    public decimal PeakDrawdownBalance { get; set; }

    public decimal PeakDrawdownPl { get; set; }

    public decimal PeakDrawdownPercent { get; set; }

    public DateTime PeakDrawdownTimeUtc { get; set; }
}
