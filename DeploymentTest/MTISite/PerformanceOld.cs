namespace StriveApi.Database.Models.MTISite;

public partial class PerformanceOld
{
    public string UserId { get; set; } = null!;

    public DateTime MostRecentCalculation { get; set; }

    public int SystemTypeId { get; set; }

    public decimal TotalGain { get; set; }

    public decimal MonthlyGain { get; set; }

    public decimal WeeklyGain { get; set; }

    public decimal AverageTradeDuration { get; set; }

    public decimal TradesPerDay { get; set; }

    public int HistoryInDays { get; set; }

    public decimal Rrr { get; set; }

    public decimal WorstDay { get; set; }

    public decimal WorstWeek { get; set; }

    public decimal WorstMonth { get; set; }

    public decimal DeepestValley { get; set; }

    public decimal ProfitFactor { get; set; }

    public DateTime MostRecentTrade { get; set; }

    public decimal LatestEquity { get; set; }

    public decimal RoR10 { get; set; }

    public decimal RoR25 { get; set; }

    public decimal RoR50 { get; set; }

    public string? BrokerAccountNumber { get; set; }

    public string? AccountCurrency { get; set; }
}
