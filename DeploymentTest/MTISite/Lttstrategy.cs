namespace StriveApi.Database.Models.MTISite;

public partial class Lttstrategy
{
    public int LttstrategyId { get; set; }

    public string LttstrategyName { get; set; } = null!;

    public short IsVisible { get; set; }

    public string StrategyCourse { get; set; } = null!;

    public string ScannerName { get; set; } = null!;
}
