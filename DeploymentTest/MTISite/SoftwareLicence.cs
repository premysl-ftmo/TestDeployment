namespace StriveApi.Database.Models.MTISite;

public partial class SoftwareLicence
{
    public string LicenceId { get; set; } = null!;

    public string AffiliateId { get; set; } = null!;

    public string LicenceProduct { get; set; } = null!;

    public DateTime LicenceExpiryDate { get; set; }

    public short IsDisabled { get; set; }

    public short CheckConcurrency { get; set; }

    public DateTime? FirstLicenceHitUtc { get; set; }

    public string? LastIpaddress { get; set; }

    public DateTime? LastIpaddressTime { get; set; }

    public short CheckAccountNumber { get; set; }

    public string? LockedAgainstAccountNumber { get; set; }

    public short CheckHardwareId { get; set; }

    public string? AssignedToHardwareId { get; set; }

    public DateTime? LastReleaseTimeUtc { get; set; }
}
