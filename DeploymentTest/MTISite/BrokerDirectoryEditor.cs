namespace StriveApi.Database.Models.MTISite;

public partial class BrokerDirectoryEditor
{
    public string Username { get; set; } = null!;

    public string BrokerId { get; set; } = null!;

    public int CanApprove { get; set; }

    public int IsDisabled { get; set; }
}
