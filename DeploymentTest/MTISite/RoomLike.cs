namespace StriveApi.Database.Models.MTISite;

public partial class RoomLike
{
    public int RoomLikeId { get; set; }

    public string LikeByUserId { get; set; } = null!;

    public string LikeOfUserId { get; set; } = null!;

    public int RoomId { get; set; }

    public int LikeEntityId { get; set; }

    public int LikeEntityTypeId { get; set; }

    public decimal LikeValue { get; set; }

    public DateTime LikeDateUtc { get; set; }
}
