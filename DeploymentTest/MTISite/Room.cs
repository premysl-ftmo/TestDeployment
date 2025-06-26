namespace StriveApi.Database.Models.MTISite;

public partial class Room
{
    public int RoomId { get; set; }

    public int ParentRoomId { get; set; }

    public string RoomName { get; set; } = null!;

    public string RoomOwnerId { get; set; } = null!;

    public short IsInvitationOnly { get; set; }

    public short AllowGuestViewing { get; set; }

    public int MinShowTradeMode { get; set; }

    public int MaxShowTradeMode { get; set; }

    public short ShowTrades { get; set; }

    public int MessageWaitPeriodMinutes { get; set; }

    public int DefaultMessageLimitPeriod { get; set; }

    public int DefaultMessageLimitNumber { get; set; }

    public int DefaultMemberExpiryDays { get; set; }

    public short AllowMessages { get; set; }

    public short DefaultMemberAllowMessages { get; set; }

    public short InMaintenance { get; set; }

    public int DefaultLikeLimitPeriod { get; set; }

    public int DefaultLikeLimitNumber { get; set; }

    public int DefaultMembershipExpiryDays { get; set; }
}
