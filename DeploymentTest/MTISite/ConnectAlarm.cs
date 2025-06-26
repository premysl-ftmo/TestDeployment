namespace StriveApi.Database.Models.MTISite;

public partial class ConnectAlarm
{
    public int AlarmId { get; set; }

    public string ConnectAccount { get; set; } = null!;

    public string AlarmCaption { get; set; } = null!;

    public DateTime AlarmTimeUtc { get; set; }

    public string ItemHash { get; set; } = null!;
}
