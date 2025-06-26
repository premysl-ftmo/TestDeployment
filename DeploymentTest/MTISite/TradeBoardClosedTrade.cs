namespace StriveApi.Database.Models.MTISite;

public partial class TradeBoardClosedTrade
{
    public int TradeBoardClosedTradeId { get; set; }

    public int TradeBoardOpenTradeId { get; set; }

    public string UserId { get; set; } = null!;

    public string UserAccountNumber { get; set; } = null!;

    public int Ticket { get; set; }

    public short IsOrphan { get; set; }

    public int OrderAction { get; set; }

    public string Symbol { get; set; } = null!;

    public decimal OpenPrice { get; set; }

    public decimal ClosePrice { get; set; }

    public decimal Sl { get; set; }

    public decimal Tp { get; set; }

    public decimal FinalVolume { get; set; }

    public decimal OriginalVolume { get; set; }

    public DateTime BrokerOpenTime { get; set; }

    public DateTime SystemOpenTimeUtc { get; set; }

    public decimal FinalProfit { get; set; }

    public decimal FinalSwap { get; set; }

    public decimal FinalCommission { get; set; }

    public decimal FinalProfitPips { get; set; }

    public DateTime BrokerCloseTime { get; set; }

    public DateTime SystemCloseTimeUtc { get; set; }
}
