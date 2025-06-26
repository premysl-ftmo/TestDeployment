namespace StriveApi.Database.Models.MTISite;

public partial class BroadcastMessage
{
    public int EventId { get; set; }

    public DateTime EventTimeUtc { get; set; }

    public int EventType { get; set; }

    public string MessageChannel { get; set; } = null!;

    public string MessageId { get; set; } = null!;

    public string MessageText { get; set; } = null!;
}
