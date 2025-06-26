namespace StriveApi.Database.Models.MTISite;

public partial class ConnectFeedFilter
{
    public int FeedFilterId { get; set; }

    public string ConnectAccount { get; set; } = null!;

    public string FilterCaption { get; set; } = null!;

    public string FilterText { get; set; } = null!;

    public byte ShowAlerts { get; set; }
}
