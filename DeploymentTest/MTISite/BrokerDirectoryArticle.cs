global using System.ComponentModel.DataAnnotations.Schema;
global using static StriveApi.Database.MtisiteContext;
global using System.ComponentModel.DataAnnotations;

namespace StriveApi.Database.Models.MTISite;

public partial record BrokerDirectoryArticle
{
    [ForeignKey(nameof(BrokerDirectory))]
    public Guid BrokerId { get; set; }

    public Guid ArticleId { get; set; }

    public ArticleStatus ArticleStatus { get; set; }

    public DateTime CreationDateUtc { get; set; }

    public DateTime ModificationDateUtc { get; set; }

    public DateTime? FirstApprovalDateUtc { get; set; }

    public bool HasBeenApproved { get; set; }

    public string LastEditByUserId { get; set; } = null!;

    public Guid RevisionId { get; set; }

    public DateTime PublicationDateUtc { get; set; }

    public ArticleType ArticleType { get; set; }

    public string ArticleTitle { get; set; } = null!;

    public string ArticlePageTitle { get; set; } = null!;

    public string ArticleSummary { get; set; } = null!;

    public string ArticleBody { get; set; } = null!;

    public string? ArticleLink { get; set; }

    public DateTime StartDateUtc { get; set; }

    public DateTime EndDateUtc { get; set; }

    public string ArticleContact { get; set; } = null!;

    public BrokerGeoMode GeoMode { get; set; }

    public string GeoList { get; set; } = null!;

    public string CanonicalPage { get; set; } = null!;

    public string DisclaimerText { get; set; } = null!;

    public string LinkButtonCaption { get; set; } = null!;

    [Required]
    public required BrokerDirectory BrokerDirectory { get; set; }
}
