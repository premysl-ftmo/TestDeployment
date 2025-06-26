namespace StriveApi.Database.Models.MTISite;

public partial class CompetitionJoinMessage
{
    public string CompetitionJoinMessageId { get; set; } = null!;

    public int CompetitionId { get; set; }

    public string UserId { get; set; } = null!;

    public DateTime CreationDate { get; set; }
}
