namespace StriveApi.Database.Models.MTISite;

public partial class NewsFeedLogin
{
    public string WebAccessId { get; set; } = null!;

    public string FeedProvider { get; set; } = null!;

    public string AccountNumber { get; set; } = null!;

    public string BrokerServer { get; set; } = null!;

    public string PlatformId { get; set; } = null!;

    public DateTime CreationDateUtc { get; set; }

    public DateTime ExpiryDateUtc { get; set; }

    public int AccountState { get; set; }

    public byte AllowWebAccess { get; set; }

    public int ConcurrencyThreshold { get; set; }

    public DateTime LastLoginTimeUtc { get; set; }

    public string? FeedId { get; set; }
}
