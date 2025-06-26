namespace StriveApi.Database.Models.MTISite;

public partial class ConnectPriceList
{
    public string ConnectAccount { get; set; } = null!;

    public string PriceSymbol { get; set; } = null!;

    public int DisplayOrder { get; set; }
}
