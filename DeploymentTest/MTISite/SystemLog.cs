namespace StriveApi.Database.Models.MTISite;

public partial class SystemLog
{
    public DateTime LogTimeUtc { get; set; }

    public string LogUserId { get; set; } = null!;

    public string LogType { get; set; } = null!;

    public string LogDetail { get; set; } = null!;
}
