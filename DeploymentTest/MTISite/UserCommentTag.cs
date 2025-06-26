namespace StriveApi.Database.Models.MTISite;

public partial class UserCommentTag
{
    public string UserId { get; set; } = null!;

    public string TagCaption { get; set; } = null!;

    public int MatchType { get; set; }

    public string MatchAgainst { get; set; } = null!;
}
