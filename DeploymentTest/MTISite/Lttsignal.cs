namespace StriveApi.Database.Models.MTISite;

public partial class Lttsignal
{
    public int LttsignalId { get; set; }

    public int LttstrategyId { get; set; }

    public int LttcoachId { get; set; }

    public DateTime LttsignalTimeUtc { get; set; }

    public DateTime LttsignalExpiryUtc { get; set; }

    public int LtttradeDirection { get; set; }

    public string Lttsymbol { get; set; } = null!;

    public decimal LttentryPrice { get; set; }

    public decimal LttstopLoss { get; set; }

    public decimal LtttakeProfit { get; set; }

    public string? Lttcomments { get; set; }

    public short LttisSignalValid { get; set; }

    public int SignalMasterTicketId { get; set; }

    public DateTime CreationTimeUtc { get; set; }

    public int CreatedByUserId { get; set; }

    public DateTime LastEditTimeUtc { get; set; }

    public int LastEditByUserId { get; set; }

    public short HasScreenshot { get; set; }

    public int StrategyTimeframe { get; set; }

    public string? StrategyField1 { get; set; }

    public decimal StrategyParam1 { get; set; }

    public string? StrategyField2 { get; set; }

    public decimal StrategyParam2 { get; set; }

    public string? StrategyField3 { get; set; }

    public decimal StrategyParam3 { get; set; }

    public string? StrategyField4 { get; set; }

    public decimal StrategyParam4 { get; set; }

    public string? StrategyField5 { get; set; }

    public decimal StrategyParam5 { get; set; }

    public string? StrategyField6 { get; set; }

    public decimal StrategyParam6 { get; set; }

    public string? StrategyField7 { get; set; }

    public decimal StrategyParam7 { get; set; }

    public string? StrategyField8 { get; set; }

    public decimal StrategyParam8 { get; set; }

    public virtual Lttcoach Lttcoach { get; set; } = null!;

    public virtual Lttstrategy Lttstrategy { get; set; } = null!;
}
