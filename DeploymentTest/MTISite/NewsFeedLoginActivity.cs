namespace StriveApi.Database.Models.MTISite;

public partial class NewsFeedLoginActivity
{
    public string WebAccessId { get; set; } = null!;

    public DateTime AccessTimeUtc { get; set; }

    public string Ipaddress { get; set; } = null!;

    public string ComputerId { get; set; } = null!;

    public byte ConcurrencyExempt { get; set; }
}
