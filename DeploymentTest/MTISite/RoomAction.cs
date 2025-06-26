namespace StriveApi.Database.Models.MTISite;

public partial class RoomAction
{
    public int RoomActionId { get; set; }

    public int RoomId { get; set; }

    public int RoomEntityId { get; set; }

    public int RoomEntityTypeId { get; set; }

    public DateTime RoomActionTimeUtc { get; set; }

    public int RoomActionTypeId { get; set; }

    public string? User1Id { get; set; }

    public string? User2Id { get; set; }
}
