namespace StriveApi.Database.Models.MTISite;

public partial class Slingshot
{
    public string SlingshotId { get; set; } = null!;

    public string UserId { get; set; } = null!;

    public DateTime CreationDateUtc { get; set; }

    public string SlingshotTitle { get; set; } = null!;

    public string? SlingshotDescription { get; set; }

    public string? DisplayUrl { get; set; }

    public short IsPageHidden { get; set; }

    public short ShowForum { get; set; }

    public short DownloadNeedsLogin { get; set; }

    public short PackageIsPremium { get; set; }

    public short PackageHasPassword { get; set; }

    public string PackageMode { get; set; } = null!;

    public string PackageManifest { get; set; } = null!;

    public short PackageIsDeleted { get; set; }

    public int PackageSize { get; set; }

    public string? OneTimeLogin { get; set; }

    public int DownloadCount { get; set; }

    public int AverageRating { get; set; }

    public int RatingCount { get; set; }

    public string? UpgradedById { get; set; }

    public int CommentCount { get; set; }

    public DateTime? MostRecentCommentUtc { get; set; }

    public short ForumLocked { get; set; }

    public DateTime LastUploadUtc { get; set; }

    public short NoRatings { get; set; }
}
