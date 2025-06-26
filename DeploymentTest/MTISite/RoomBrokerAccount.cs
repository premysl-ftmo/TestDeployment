namespace StriveApi.Database.Models.MTISite;

public partial class RoomBrokerAccount
{
    public int RoomBrokerAccountId { get; set; }

    public string RoomUserId { get; set; } = null!;

    public string BrokerAccountId { get; set; } = null!;

    public int BrokerAccountTypeId { get; set; }

    public string? BrokerServer { get; set; }

    public string? AccountName { get; set; }

    public decimal AccountBalance { get; set; }

    public decimal AccountEquity { get; set; }

    public decimal AccountFloatingPl { get; set; }

    public decimal AccountClosedPl { get; set; }

    public decimal AccountFreeMargin { get; set; }

    public decimal AccountMarginInUse { get; set; }

    public decimal AccountLeverage { get; set; }

    public decimal AccountCredit { get; set; }

    public string AccountCurrency { get; set; } = null!;

    public DateTime AccountBrokerTime { get; set; }

    public decimal UsdconversionFactor { get; set; }

    public decimal EurusdlotSize { get; set; }

    public decimal EurusdminVolume { get; set; }

    public int TradingPlatformId { get; set; }

    public int AccountFlags { get; set; }

    public DateTime LastUpdateUtc { get; set; }

    public string? LastUpdateIpaddress { get; set; }

    public int IsRemoteTradingAllowed { get; set; }

    public decimal PublisherVersion { get; set; }
}
