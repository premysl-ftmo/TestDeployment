namespace StriveApi.Database.Models.MTISite;

public partial class PredictionSymbolPrice
{
    public string PredictionSymbol { get; set; } = null!;

    public decimal MidPrice { get; set; }

    public DateTime PriceTimeUtc { get; set; }
}
