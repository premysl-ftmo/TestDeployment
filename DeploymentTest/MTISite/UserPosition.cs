namespace StriveApi.Database.Models.MTISite;

public partial class UserPosition
{
    public string UserId { get; set; } = null!;

    public string SymbolName { get; set; } = null!;

    public decimal NetLots { get; set; }

    public short NetDirection { get; set; }

    public byte IsProfitable { get; set; }

    public DateTime PositionTimestampUtc { get; set; }

    public int IndividualTrades { get; set; }

    public int LongTrades { get; set; }

    public int ShortTrades { get; set; }

    public string? SentimentUniverse { get; set; }

    public string? SentimentSubUniverse { get; set; }
}
