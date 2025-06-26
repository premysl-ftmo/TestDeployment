namespace StriveApi.Database.Models.MTISite;

public partial class AppStoreCategory
{
    public int AppStoreCategoryId { get; set; }

    public string AppStoreCategoryName { get; set; } = null!;

    public int ParentCategoryId { get; set; }

    public int DisplayOrder { get; set; }

    public int AppCount { get; set; }

    public string? CategoryPageName { get; set; }

    public string? CategoryDescription { get; set; }
}
