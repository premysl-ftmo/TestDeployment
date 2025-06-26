namespace StriveApi.Database.Models.MTISite;

public partial class AccountCollectionLog
{
    public DateTime CollectionTimeUtc { get; set; }

    public string UserId { get; set; } = null!;

    public int ResultCode { get; set; }

    public string FromIpaddress { get; set; } = null!;
}
