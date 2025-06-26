namespace StriveApi.Database.Models.MTISite;

public partial class PredictionpricebarsOld
{
    public string Symbol { get; set; } = null!;

    public int BarDate { get; set; }

    public decimal PriceOpen { get; set; }

    public decimal PriceHigh { get; set; }

    public decimal PriceLow { get; set; }

    public decimal PriceClose { get; set; }
}
