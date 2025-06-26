namespace StriveApi.Database.Models.MTISite;

public partial class ConnectFeed
{
    public int FeedId { get; set; }

    public string ConnectAccount { get; set; } = null!;

    public string FeedCaption { get; set; } = null!;

    public string FeedUrl { get; set; } = null!;

    public byte ShowAlerts { get; set; }
}
