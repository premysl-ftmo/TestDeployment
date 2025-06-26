namespace StriveApi.Database.Models.MTISite;

public partial class ImpressionTracking
{
    public string AdvertId { get; set; } = null!;

    public DateTime ImpressionTimeUtc { get; set; }

    public string Ipaddress { get; set; } = null!;
}
