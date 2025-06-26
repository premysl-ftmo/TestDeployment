namespace StriveApi.Database.Models.MTISite;

public partial class Contestant
{
    public int ContestCounter { get; set; }

    public string UserId { get; set; } = null!;

    public string AccountId { get; set; } = null!;

    public int AccountState { get; set; }

    public int FinalRank { get; set; }

    public decimal FinalEquity { get; set; }

    public int TotalTradesEver { get; set; }

    public byte IsAccountDeleted { get; set; }

    public decimal PeakEquity { get; set; }

    public decimal TroughEquity { get; set; }
}
