namespace StriveApi.Database.Models.MTISite;

public partial class AutoNewsEventsOld
{
    public int AutoNewsEventId { get; set; }

    public DateTime AutoNewsEventTimeUtc { get; set; }

    public string AutoNewsEventLanguage { get; set; } = null!;

    public string AutoNewsEventType { get; set; } = null!;

    public string EventTitle { get; set; } = null!;

    public string EventCategory { get; set; } = null!;
}
