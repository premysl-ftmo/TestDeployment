namespace StriveApi.Database.Models.MTISite;

public partial class CompetitionInvitation
{
    public string CompetitionInvitationId { get; set; } = null!;

    public int CompetitionId { get; set; }

    public string InvitationEmailAddress { get; set; } = null!;

    public byte IsAccepted { get; set; }

    public string? UserId { get; set; }
}
