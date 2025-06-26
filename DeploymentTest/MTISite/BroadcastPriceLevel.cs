namespace StriveApi.Database.Models.MTISite;

public partial class BroadcastPriceLevel
{
    public string ProviderId { get; set; } = null!;

    public int LevelId { get; set; }

    public string LevelSymbol { get; set; } = null!;

    public int LevelTimeframe { get; set; }

    public decimal LevelPrice { get; set; }

    public DateTime LevelStartUtc { get; set; }

    public DateTime LevelExpiryUtc { get; set; }

    public int LevelMode { get; set; }

    public decimal LevelTolerance { get; set; }
}
