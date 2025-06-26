namespace StriveApi.Database.Models.MTISite;

public partial class Apilogin
{
    public string ApiloginKey { get; set; } = null!;

    public string UserUniverse { get; set; } = null!;

    public string ApiloginCaption { get; set; } = null!;

    public byte AllowLogin { get; set; }

    public byte AllowUserCreation { get; set; }
}
