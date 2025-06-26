namespace StriveApi.Database.Models.MTISite;

public partial class AppStorePackageFile
{
    public int AppStoreFileId { get; set; }

    public int AppStorePackageId { get; set; }

    public string AppStoreFilename { get; set; } = null!;

    public string InstallationTarget { get; set; } = null!;
}
