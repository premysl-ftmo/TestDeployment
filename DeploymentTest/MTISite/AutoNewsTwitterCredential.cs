namespace StriveApi.Database.Models.MTISite;

public partial class AutoNewsTwitterCredential
{
    public string AutoNewsLanguage { get; set; } = null!;

    public string AccessToken { get; set; } = null!;

    public string AccessTokenSecret { get; set; } = null!;

    public string ConsumerKey { get; set; } = null!;

    public string ConsumerKeySecret { get; set; } = null!;

    public string? AutoNewsTwitterId { get; set; }
}
