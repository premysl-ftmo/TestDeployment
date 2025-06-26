namespace StriveApi.Database.Models.MTISite;

public partial class Portfolio
{
    public string PortfolioId { get; set; } = null!;

    public string OwnerId { get; set; } = null!;

    public string PortfolioTitle { get; set; } = null!;

    public string? PortfolioDescription { get; set; }
}
