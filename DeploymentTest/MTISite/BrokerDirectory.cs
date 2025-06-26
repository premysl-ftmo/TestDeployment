using static StriveApi.Database.MtisiteContext;

namespace StriveApi.Database.Models.MTISite;

public partial class BrokerDirectory
{
    public Guid BrokerId { get; set; }

    public string BrokerPageName { get; set; } = null!;

    public string BrokerCompanyName { get; set; } = null!;

    public string ContactEmail { get; set; } = null!;

    /// <summary>
    /// Also known as <c>EntryStatus</c> in XML
    /// </summary>
    public CurrentDetailsStatus CurrentDetailsStatus { get; set; }

    public int SpreadId { get; set; }

    public bool Published { get; set; }

    public int SponsorshipLevel { get; set; }

    public bool CanHaveLogo { get; set; }

    public int MaxArticles { get; set; }

    public int MaxOffers { get; set; }

    public int MaxCompetitions { get; set; }

    public int MaxBlogs { get; set; }

    public BrokerGeoMode GeoMode { get; set; }

    public string GeoList { get; set; } = null!;

    public ICollection<BrokerDirectoryArticle> BrokerDirectoryArticles { get; set; } = [];
}
