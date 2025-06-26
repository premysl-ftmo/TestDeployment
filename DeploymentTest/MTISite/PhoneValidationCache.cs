namespace StriveApi.Database.Models.MTISite;

public partial class PhoneValidationCache
{
    public string PhoneNumber { get; set; } = null!;

    public string NetworkType { get; set; } = null!;

    public string Validity { get; set; } = null!;

    public string Reachability { get; set; } = null!;

    public DateTime CacheDateUtc { get; set; }
}
