namespace StriveApi.Database.Models.MTISite;

public partial class NewsFeedLoginDatum
{
    public string WebAccessId { get; set; } = null!;

    public string StateData { get; set; } = null!;

    public DateTime? LastChangeUtc { get; set; }
}
