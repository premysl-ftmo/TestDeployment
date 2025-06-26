namespace StriveApi.Database.Models.MTISite;

public partial class RoomMessage
{
    public int RoomId { get; set; }

    public string RoomUserId { get; set; } = null!;

    public int MessageId { get; set; }

    public DateTime MessageTimeUtc { get; set; }

    public int ReplyToId { get; set; }

    public string? PrivateMessageTo { get; set; }

    public string? FollowerMessageId { get; set; }

    public int MessageStateId { get; set; }

    public int MessageTypeId { get; set; }

    public string? MessageCategory { get; set; }

    public string? MessageSubject { get; set; }

    public string MessageText { get; set; } = null!;

    public int ReplyCount { get; set; }

    public decimal MessageLikeValue { get; set; }

    public int ParentMessageId { get; set; }

    public int ParentReplyCount { get; set; }
}
