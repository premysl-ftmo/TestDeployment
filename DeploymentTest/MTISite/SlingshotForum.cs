namespace StriveApi.Database.Models.MTISite;

public partial class SlingshotForum
{
    public int SlingshotMessageId { get; set; }

    public string SlingshotId { get; set; } = null!;

    public string UserId { get; set; } = null!;

    public int ReplyToMessageId { get; set; }

    public DateTime CreationDateUtc { get; set; }

    public DateTime LastEditUtc { get; set; }

    public int MessageState { get; set; }

    public string ForumMessage { get; set; } = null!;

    public int Rating { get; set; }

    public int MessageSubType { get; set; }
}
