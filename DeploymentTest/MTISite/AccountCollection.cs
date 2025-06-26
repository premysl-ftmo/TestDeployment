namespace StriveApi.Database.Models.MTISite;

public partial class AccountCollection
{
    public string UserId { get; set; } = null!;

    public int LastRequestTimestamp { get; set; }

    public int LastStatus { get; set; }

    public int DisableReasonId { get; set; }

    public DateTime? LastCollectionTimeUtc { get; set; }

    public DateTime? LastSuccessfulCollectionTimeUtc { get; set; }

    public int ConsecutiveErrors { get; set; }

    public string? BrokerServer { get; set; }

    public string AccountLogin { get; set; } = null!;

    public string EncryptedPassword { get; set; } = null!;

    public short IncludeOpenOrders { get; set; }

    public short IncludePendingOrders { get; set; }

    public short IncludeOpenProfit { get; set; }

    public short PublishOrderComments { get; set; }

    public short PublishDelay { get; set; }

    public string SubGroup { get; set; } = null!;
}
