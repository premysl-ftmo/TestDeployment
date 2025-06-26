namespace StriveApi.Database.Models.MTISite;

public partial class ChartAlertLog
{
    public string UserId { get; set; } = null!;

    public DateTime AlertTimeUtc { get; set; }

    public string AlertText { get; set; } = null!;

    public byte SentByEmail { get; set; }

    public byte SentBySms { get; set; }

    public byte EmailOverQuota { get; set; }

    public byte SmsOverQuota { get; set; }
}
