namespace StriveApi.Database.Models.MTISite;

public partial class MirrorInviteCode
{
    public string MirrorInviteCode1 { get; set; } = null!;

    public string UserId { get; set; } = null!;

    public string EmailAddress { get; set; } = null!;

    public DateTime CreationDateUtc { get; set; }

    public byte IsAccepted { get; set; }

    public string SubscriberId { get; set; } = null!;
}
