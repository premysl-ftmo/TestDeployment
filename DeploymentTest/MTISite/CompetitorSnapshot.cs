namespace StriveApi.Database.Models.MTISite;

public partial class CompetitorSnapshot
{
    public int CompetitionId { get; set; }

    public string UserId { get; set; } = null!;

    public DateTime SnapshotTime { get; set; }

    public decimal SnapshotEquity { get; set; }

    public decimal SnapshotBalance { get; set; }

    public decimal SnapshotPeakEquity { get; set; }

    public decimal SnapshotTroughEquity { get; set; }

    public DateTime SnapshotMostRecentCalculation { get; set; }

    public int CompetitorRank { get; set; }

    public int DisqualificationReasonId { get; set; }

    public decimal? SnapshotGrossDeposits { get; set; }

    public decimal? SnapshotPercentReturn { get; set; }
}
