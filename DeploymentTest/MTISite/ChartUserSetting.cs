namespace StriveApi.Database.Models.MTISite;

public partial class ChartUserSetting
{
    public string UserId { get; set; } = null!;

    public byte ServerAlerts { get; set; }

    public byte SendEmail { get; set; }

    public byte SendSms { get; set; }

    public int EmailQuotaPeriod { get; set; }

    public int EmailQuotaAmount { get; set; }

    public int SmsquotaPeriod { get; set; }

    public int SmsquotaAmount { get; set; }

    public string? TwitterAccessKey { get; set; }

    public string? TwitterAccessSecret { get; set; }

    public string? TwitterScreenName { get; set; }
}
