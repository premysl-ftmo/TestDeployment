namespace StriveApi.Database.Models.MTISite;

public partial class Lttcoach
{
    public int LttcoachId { get; set; }

    public string LttemailAddress { get; set; } = null!;

    public string LttcoachName { get; set; } = null!;

    public string EncryptedPassword { get; set; } = null!;

    public string Region { get; set; } = null!;

    public short IsVisible { get; set; }

    public short IsSuperuser { get; set; }

    public short IsLoginAllowed { get; set; }

    public DateTime LockedUntil { get; set; }

    public int ConsecutiveLoginFailures { get; set; }

    public string CoachCountry { get; set; } = null!;

    public short IsLevelEditor { get; set; }

    public short SendEmails { get; set; }
}
