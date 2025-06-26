namespace StriveApi.Database.Models.MTISite;

public partial class FixiTemp
{
    public int CompetitionId { get; set; }

    public string UserId { get; set; } = null!;

    public decimal FirstRecordedEquity { get; set; }

    public decimal LatestEquity { get; set; }

    public decimal LatestBalance { get; set; }

    public int DisqualificationReasonId { get; set; }

    public string? BrokerAccountNumber { get; set; }

    public decimal PeakEquity { get; set; }

    public decimal TroughEquity { get; set; }

    public decimal PeakLossPercent { get; set; }

    public string? DisqualificationReasonText { get; set; }

    public int FinalRank { get; set; }

    public decimal GrossDeposits { get; set; }

    public string? CompetitorCountry { get; set; }

    public int CurrentOpenOrders { get; set; }

    public int TotalOrdersEver { get; set; }

    public decimal LotsTradedEver { get; set; }

    public decimal? PercentReturn { get; set; }
}
