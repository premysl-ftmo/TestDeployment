namespace StriveApi.Database.Models.MTISite;

public partial class Competition
{
    public int CompetitionId { get; set; }

    public DateTime CreationDateUtc { get; set; }

    public int AdvertPriority { get; set; }

    public string CompetitionName { get; set; } = null!;

    public string CompetitionOwnerId { get; set; } = null!;

    public string? CompetitionCurrency { get; set; }

    public decimal CompetitionStartEquity { get; set; }

    public decimal SingleTradeLots { get; set; }

    public decimal MaxLots { get; set; }

    public decimal MinEquity { get; set; }

    public decimal MaxDrawdownCash { get; set; }

    public decimal MaxDrawdownPercent { get; set; }

    public byte IsInvitationOnly { get; set; }

    public byte IsPublic { get; set; }

    public string PermittedSymbols { get; set; } = null!;

    public string? BrokerServer { get; set; }

    public int BrokerAccountNumberMin { get; set; }

    public int BrokerAccountNumberMax { get; set; }

    public DateTime CompetitionStartDateUtc { get; set; }

    public DateTime CompetitionEndDateUtc { get; set; }

    public byte LockCompetitorsAtStart { get; set; }

    public int CompetitionStatusId { get; set; }

    public byte RequiresManualStart { get; set; }

    public int LiveDemoTypeId { get; set; }

    public byte AllowOpenPositionsAtStart { get; set; }

    public string? CompetitionDescription { get; set; }

    public string? CompetitionUrl { get; set; }

    public string? CompetitionOwnerCaption { get; set; }

    public string? CompetitionOwnerLogo { get; set; }

    public byte AllowCompetitorMessages { get; set; }

    public int MaxCompetitors { get; set; }

    public int SoftwarePlatformId { get; set; }

    public byte HaveTriedAutoStart { get; set; }

    public byte IsExample { get; set; }

    public byte IsHidden { get; set; }

    public int RankingMode { get; set; }
}
