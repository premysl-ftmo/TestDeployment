namespace StriveApi.Database.Models.MTISite;

public partial class UserPositionSnapshotsExternal
{
    public DateTime SnapshotTimeUtc { get; set; }

    public string SymbolName { get; set; } = null!;

    public int LongWin { get; set; }

    public int LongLoss { get; set; }

    public int ShortWin { get; set; }

    public int ShortLoss { get; set; }

    public int TotalTraders { get; set; }

    public int ActiveTraders { get; set; }

    public int TotalTrades { get; set; }

    public int TotalLongTrades { get; set; }

    public int TotalShortTrades { get; set; }

    public string SentimentUniverse { get; set; } = null!;
}
