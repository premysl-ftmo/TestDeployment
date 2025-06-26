namespace StriveApi.Database.Models.MTISite;

public partial class AcctTable
{
    public int HostId { get; set; }

    public int HostPort { get; set; }

    public string Username { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string HomePath { get; set; } = null!;

    public string HomePerm { get; set; } = null!;

    public int NoPassword { get; set; }

    public int HideGrpPath { get; set; }
}
