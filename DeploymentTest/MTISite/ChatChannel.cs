namespace StriveApi.Database.Models.MTISite;

public partial class ChatChannel
{
    public string ChannelId { get; set; } = null!;

    public string OwnerId { get; set; } = null!;

    public int ChannelType { get; set; }

    public int ChannelFlags { get; set; }

    public int MessageLimitCount { get; set; }

    public int MessageLimitSeconds { get; set; }

    public int MessageLimitLength { get; set; }

    public int MaxMessagesEver { get; set; }

    public DateTime ChannelOpenTime { get; set; }

    public DateTime ChannelCloseTime { get; set; }

    public int ChannelPageSize { get; set; }

    public byte CanEditMessages { get; set; }

    public byte CanDeleteMessages { get; set; }

    public byte CanAddMessages { get; set; }

    public virtual ICollection<Chat> Chats { get; set; } = new List<Chat>();
}
