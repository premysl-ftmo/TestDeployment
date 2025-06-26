namespace StriveApi.Database.Models.MTISite;

public partial class NewsItemTag
{
    public int NewsItemId { get; set; }

    public int TagType { get; set; }

    public string TagValue { get; set; } = null!;

    public virtual NewsItem NewsItem { get; set; } = null!;
}
