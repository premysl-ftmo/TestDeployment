namespace StriveApi.Database.Models.MTISite;

public partial class PredictionCredit
{
    public int PredictionCreditId { get; set; }

    public string UserId { get; set; } = null!;

    public int PredictionId { get; set; }

    public DateTime CreditTimeUtc { get; set; }

    public int PredictionRoleType { get; set; }

    public int WinCounter { get; set; }

    public int LossCounter { get; set; }

    public decimal PipCredit { get; set; }

    public int TimeCredit { get; set; }
}
