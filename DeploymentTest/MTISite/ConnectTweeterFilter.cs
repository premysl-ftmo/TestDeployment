namespace StriveApi.Database.Models.MTISite;

public partial class ConnectTweeterFilter
{
    public int TweeterFilterId { get; set; }

    public string ConnectAccount { get; set; } = null!;

    public string FilterCaption { get; set; } = null!;

    public string FilterText { get; set; } = null!;

    public byte ShowAlerts { get; set; }
}
