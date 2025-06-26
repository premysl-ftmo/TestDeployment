namespace StriveApi.Database.Models.MTISite;

public partial class ConnectTweeter
{
    public int TweeterId { get; set; }

    public string ConnectAccount { get; set; } = null!;

    public string TweeterName { get; set; } = null!;

    public string TweeterUrl { get; set; } = null!;

    public byte ShowAlerts { get; set; }
}
