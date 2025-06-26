namespace StriveApi.Database.Models.MTISite;

public partial class UserAccessRestriction
{
    public string AccessToUserId { get; set; } = null!;

    public string AccessByUserId { get; set; } = null!;
}
