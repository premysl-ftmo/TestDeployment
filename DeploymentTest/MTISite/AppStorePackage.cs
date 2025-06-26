namespace StriveApi.Database.Models.MTISite;

public partial class AppStorePackage
{
    public int AppStorePackageId { get; set; }

    public string UserId { get; set; } = null!;

    public string PackageName { get; set; } = null!;

    public string? PackagePageName { get; set; }

    public int AppStoreCategoryId { get; set; }

    public string? PackageTermsUrl { get; set; }

    public string? DocumentationUrl { get; set; }

    public string? AuthorWebsite { get; set; }

    public string? PackageDataStoreDirectory { get; set; }

    public string? DownloadUrl { get; set; }

    public short RequireRegistration { get; set; }

    public int DownloadCount { get; set; }

    public short ShowForum { get; set; }

    public short ShowSocialLinks { get; set; }

    public DateTime CreationDate { get; set; }

    public DateTime MostRecentUpdate { get; set; }

    public int CurrentVersion { get; set; }

    public short AllowInstallers { get; set; }

    public short IsVisible { get; set; }

    public short InstallFxadverts { get; set; }

    public int FxadvertsIdForInstaller { get; set; }

    public string? SummaryText { get; set; }

    public string? MetaDescription { get; set; }

    public string? DetailText { get; set; }

    public decimal Popularity { get; set; }

    public decimal AverageRating { get; set; }

    public decimal AppPrice { get; set; }

    public int AppPricePeriod { get; set; }

    public string? AppPriceCurrency { get; set; }

    public short IsDisabled { get; set; }

    public short TreatTextAsHtml { get; set; }

    public int DisplayOrder { get; set; }

    public string? AppLogo { get; set; }

    public string? Mt4postInstallPage { get; set; }

    public short RequireEmailValidation { get; set; }

    public short RequirePhoneValidation { get; set; }

    public short IncludeInStats { get; set; }

    public string EmailTemplate { get; set; } = null!;

    public int FigaroWidgetMode { get; set; }

    public int MailJourneyId { get; set; }
}
