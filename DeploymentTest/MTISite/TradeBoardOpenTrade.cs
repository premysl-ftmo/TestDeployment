namespace StriveApi.Database.Models.MTISite;

public partial class TradeBoardOpenTrade
{
    public int TradeBoardOpenTradeId { get; set; }

    public string UserId { get; set; } = null!;

    public string UserAccountNumber { get; set; } = null!;

    public int Ticket { get; set; }

    public int OrderAction { get; set; }

    public string Symbol { get; set; } = null!;

    public decimal OpenPrice { get; set; }

    public decimal Sl { get; set; }

    public decimal Tp { get; set; }

    public decimal CurrentVolume { get; set; }

    public decimal OriginalVolume { get; set; }

    public DateTime BrokerOpenTime { get; set; }

    public DateTime SystemOpenTimeUtc { get; set; }

    public decimal LatestProfit { get; set; }

    public decimal LatestSwap { get; set; }

    public decimal LatestCommission { get; set; }

    public decimal LatestProfitPips { get; set; }

    public decimal EquityAtOpen { get; set; }

    public DateTime? LatestUpdateTimeUtc { get; set; }
}
