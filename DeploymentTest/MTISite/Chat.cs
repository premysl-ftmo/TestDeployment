namespace StriveApi.Database.Models.MTISite;

public partial class Chat
{
    public int MessageCounter { get; set; }

    public string ChannelId { get; set; } = null!;

    public string UserId { get; set; } = null!;

    public DateTime CreationTimeUtc { get; set; }

    public DateTime LastChangeTime { get; set; }

    public byte IsEdited { get; set; }

    public byte IsDeleted { get; set; }

    public int MessageFlags { get; set; }

    public string MessageText { get; set; } = null!;

    public int ReplyTo { get; set; }

    public int ThreadId { get; set; }

    public virtual ChatChannel Channel { get; set; } = null!;
}
