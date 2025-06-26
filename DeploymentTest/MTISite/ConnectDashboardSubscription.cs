namespace StriveApi.Database.Models.MTISite;

public partial class ConnectDashboardSubscription
{
    public string ConnectAccount { get; set; } = null!;

    public string Mtiaccount { get; set; } = null!;

    public string GroupName { get; set; } = null!;

    public string MtiaccountPin { get; set; } = null!;
}
