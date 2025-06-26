namespace StriveApi.Database.Models.MTISite;

public partial class BrokerPermissionAccountLogin
{
    public string BrokerId { get; set; } = null!;

    public string BrokerUsername { get; set; } = null!;

    public string BrokerPassword { get; set; } = null!;

    public string BrokerUsageKeyMatch { get; set; } = null!;
}
