namespace StriveApi.Database.Models.MTISite;

public partial class ChartState
{
    public string UserId { get; set; } = null!;

    public DateTime LastUpdateUtc { get; set; }

    public string ChartState1 { get; set; } = null!;

    public string ChartStateId { get; set; } = null!;

    public byte HasAlerts { get; set; }

    public DateTime? BrowserHeartbeatUtc { get; set; }

    public DateTime? ServerHeartbeatUtc { get; set; }

    public string? ServerAlertState { get; set; }

    public string? ServerId { get; set; }
}
