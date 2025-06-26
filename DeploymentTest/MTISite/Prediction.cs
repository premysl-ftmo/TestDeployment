namespace StriveApi.Database.Models.MTISite;

public partial class Prediction
{
    public int PredictionId { get; set; }

    public string UserId { get; set; } = null!;

    public string? OpponentId { get; set; }

    public string PredictionSymbol { get; set; } = null!;

    public int PredictionDirection { get; set; }

    public int PredictionStateId { get; set; }

    public int AcceptancePeriod { get; set; }

    public int RunPeriod { get; set; }

    public short CanCancelEarly { get; set; }

    public short UseSystemOpponent { get; set; }

    public int Weighting { get; set; }

    public int PipTarget { get; set; }

    public decimal PriceTargetHigh { get; set; }

    public decimal PriceTargetLow { get; set; }

    public decimal OpenPrice { get; set; }

    public decimal ClosePrice { get; set; }

    public DateTime CreationTime { get; set; }

    public DateTime StartTime { get; set; }

    public DateTime EndTime { get; set; }

    public decimal PipSize { get; set; }

    public decimal GrossPipResult { get; set; }

    public decimal CreatorPipResult { get; set; }

    public decimal OpponentPipResult { get; set; }

    public int TerminationPenalty { get; set; }

    public int SystemOpponentWeighting { get; set; }

    public int CreatorBoostPercentage { get; set; }

    public int OpponentBoostPercentage { get; set; }

    public decimal LowestPrice { get; set; }

    public decimal HighestPrice { get; set; }

    public int MinTerminationPeriodMinutes { get; set; }

    public int DurationMinutes { get; set; }

    public short AllowPublicChat { get; set; }

    public int ChatMessageCount { get; set; }

    public decimal CreationPrice { get; set; }

    public int AutoWithdrawPips { get; set; }

    public decimal AutoWithdrawHighPrice { get; set; }

    public decimal AutoWithdrawLowPrice { get; set; }

    public short IsAdopted { get; set; }

    public decimal AdoptionPrice { get; set; }
}
