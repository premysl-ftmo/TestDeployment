namespace StriveApi.Database.Models.MTISite;

public partial class LttemailSubscription
{
    public string LttlicenceId { get; set; } = null!;

    public string EmailAddress { get; set; } = null!;

    public string StrategyInclusions { get; set; } = null!;

    public string CoachExclusions { get; set; } = null!;

    public short IsActive { get; set; }
}
