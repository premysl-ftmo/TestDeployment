namespace StriveApi.Database.Models.MTISite;

public partial class TradingDrillDefinition
{
    public string DrillType { get; set; } = null!;

    public string ContingentOnDrill { get; set; } = null!;

    public string DrillCaption { get; set; } = null!;

    public int DisplayOrder { get; set; }

    public int ExpectedSuccessCode { get; set; }

    public int TimeLimitMinutes { get; set; }

    public int DeletionMinutes { get; set; }

    public int AllowCreationAt { get; set; }

    public string SymbolGroup { get; set; } = null!;

    public int AccountFlags { get; set; }

    public int MaxOpenOrders { get; set; }

    public int MaxOpenTrades { get; set; }

    public int MaxTradesEver { get; set; }

    public string AvailableSymbols { get; set; } = null!;

    public decimal FixedLotSize { get; set; }

    public int MinHoldingSeconds { get; set; }

    public int MaxLosingTrades { get; set; }

    public int MaxWinningTrades { get; set; }

    public int MinMarketsTraded { get; set; }

    public int ConstantTrading { get; set; }

    public int MinTradeRrrpercent { get; set; }

    public string DepositCurrency { get; set; } = null!;

    public int StartingFunds { get; set; }

    public int EquityTarget { get; set; }

    public int EquityShutdown { get; set; }

    public int CashLossShutdown { get; set; }

    public decimal LossPercentShutdown { get; set; }

    public int HighWaterCash { get; set; }

    public int MaxMarketProfit { get; set; }

    public int RequireFirstTradeWithinMinutes { get; set; }

    public int TerminateAfterTradingMinutes { get; set; }

    public int WaitMinutesBeforeRetry { get; set; }

    public int MaxAttempts { get; set; }

    public int AllowRepeats { get; set; }

    public int MinSlpips { get; set; }

    public int MaxSlpips { get; set; }
}
