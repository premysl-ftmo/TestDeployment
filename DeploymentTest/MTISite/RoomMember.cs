namespace StriveApi.Database.Models.MTISite;

public partial class RoomMember
{
    public int RoomMemberId { get; set; }

    public int RoomId { get; set; }

    public string RoomUserId { get; set; } = null!;

    public int RoomMemberLevelId { get; set; }

    public short IsAdministrator { get; set; }

    public short IsModerator { get; set; }

    public int LatestBrokerAccountId { get; set; }

    public short AllowMessages { get; set; }

    public short AllowAutoTrade { get; set; }

    public short AllowFollowers { get; set; }

    public int ShowTradeMode { get; set; }

    public DateTime MessagesDisabledUntilUtc { get; set; }

    public int MessageLimitPeriod { get; set; }

    public int MessageLimitNumber { get; set; }

    public DateTime LastOrderSyncUtc { get; set; }

    public decimal LikeWeighting { get; set; }

    public int LikeLimitPeriod { get; set; }

    public int LikeLimitNumber { get; set; }

    public DateTime MembershipExpiryUtc { get; set; }

    public short AllowApimessages { get; set; }

    public DateTime JoinDateUtc { get; set; }

    public int ShowAccountHeadline { get; set; }

    public int FollowerCount { get; set; }

    public int FollowingCount { get; set; }

    public decimal TotalMessageLikeValue { get; set; }

    public decimal TotalTradeLikeValue { get; set; }
}
