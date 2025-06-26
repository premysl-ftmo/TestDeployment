namespace StriveApi.Database.Models.MTISite;

public partial class BrokerPermissionAccountList
{
    public string BrokerId { get; set; } = null!;

    public int AccountNumber { get; set; }

    public int PermissionMode { get; set; }
}
