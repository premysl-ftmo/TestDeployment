namespace StriveApi.Database.Models.MTISite;

public partial class NewsItemTagsArchive
{
    public int NewsItemId { get; set; }

    public int TagType { get; set; }

    public string TagValue { get; set; } = null!;
}
