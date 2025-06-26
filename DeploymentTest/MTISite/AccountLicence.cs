namespace StriveApi.Database.Models.MTISite;

public partial class AccountLicence
{
    public string ProductKey { get; set; } = null!;

    public string AccountNumber { get; set; } = null!;

    public string AccountServer { get; set; } = null!;

    public byte IsEnabled { get; set; }

    public DateTime ExpiryDateUtc { get; set; }
}
