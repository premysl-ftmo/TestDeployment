namespace StriveApi.Database.Models.MTISite;

public partial class DemoAccountPool
{
    public string PoolGroup { get; set; } = null!;

    public int AccountNumber { get; set; }

    public string AccountPassword { get; set; } = null!;

    public string AccountServer { get; set; } = null!;

    public int UsageCount { get; set; }
}
