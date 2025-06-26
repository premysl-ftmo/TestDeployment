namespace StriveApi.Database.Models.MTISite;

public partial class Contest
{
    public int ContestCounter { get; set; }

    public DateTime CreationTimeUtc { get; set; }

    public byte IsDeleted { get; set; }

    public int ParticipantCount { get; set; }

    public string CategoryId { get; set; } = null!;

    public string ContestName { get; set; } = null!;

    public string ContestOwnerId { get; set; } = null!;

    public int ContestState { get; set; }

    public DateTime StartTimeUtc { get; set; }

    public DateTime EndTimeUtc { get; set; }

    public decimal StartingFunds { get; set; }

    public string DepositCurrency { get; set; } = null!;

    public decimal TargetPercent { get; set; }

    public decimal ShutdownPercent { get; set; }

    public decimal DailyDrawdownLimit { get; set; }

    public decimal MaxHighWaterDrawdown { get; set; }

    public decimal MaxOpenLossPercent { get; set; }

    public int MaxTradesEver { get; set; }

    public byte InvitationOnly { get; set; }

    public byte AllowJoinLate { get; set; }

    public int MaxEntrants { get; set; }

    public string SymbolGroup { get; set; } = null!;

    public string? OwnerNotes { get; set; }

    public byte FixedLotSize { get; set; }

    public byte RequireContestantVerification { get; set; }

    public int Leverage { get; set; }
}
