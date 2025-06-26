namespace StriveApi.Database.Models.MTISite;

public partial class NewsItem
{
    public int NewsItemId { get; set; }

    public string NewsProvider { get; set; } = null!;

    public string OriginalGuid { get; set; } = null!;

    public string NewsTitle { get; set; } = null!;

    public string? NewsDescription { get; set; }

    public string NewsLanguage { get; set; } = null!;

    public DateTime OriginalPubDate { get; set; }

    public DateTime LatestPubDate { get; set; }

    public DateTime RssDate { get; set; }

    public DateTime? LatestRecordChange { get; set; }

    public virtual ICollection<NewsItemTag> NewsItemTags { get; set; } = new List<NewsItemTag>();
}
