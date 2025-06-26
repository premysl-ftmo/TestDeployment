namespace StriveApi.Database.Models.MTISite;

public partial class AutoNewsMessageType
{
    public string AutoNewsMessageType1 { get; set; } = null!;

    public string AutoNewsMessageLanguage { get; set; } = null!;

    public string AutoNewsMessageTemplate { get; set; } = null!;

    public short SendToTwitter { get; set; }
}
