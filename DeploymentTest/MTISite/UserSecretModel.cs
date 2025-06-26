namespace StriveApi.Database.Models.MTISite;

public partial class UserSecretModel
{
    public string? UserId { get; set; } = null;

    public int UserCounter { get; set; }

    public string? UserSecret { get; set; } = null;
}
