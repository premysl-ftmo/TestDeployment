namespace StriveApi.Database.Models.MTISite;

public partial class CompetitionForum
{
    public int CompetitionForumMessageId { get; set; }

    public int CompetitionId { get; set; }

    public string UserId { get; set; } = null!;

    public DateTime MessageTimeUtc { get; set; }

    public string MessageText { get; set; } = null!;

    public byte IsRemoved { get; set; }

    public int MessageSourceId { get; set; }
}
