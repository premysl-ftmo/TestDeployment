namespace StriveApi.Database.Models.MTISite;

public partial class RoomFollower
{
    public int RoomFollowerId { get; set; }

    public int RoomId { get; set; }

    public string FollowOfUserId { get; set; } = null!;

    public string FollowByUserId { get; set; } = null!;

    public DateTime CreationDateUtc { get; set; }

    public short WantDailyDigest { get; set; }
}
