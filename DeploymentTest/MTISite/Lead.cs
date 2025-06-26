namespace StriveApi.Database.Models.MTISite;

public partial class Lead
{
    public string LeadBatchId { get; set; } = null!;

    public DateTime LeadDateUtc { get; set; }

    public string EmailAddress { get; set; } = null!;

    public string PhoneNumber { get; set; } = null!;

    public string PhoneCountry { get; set; } = null!;

    public string PhoneGivenName { get; set; } = null!;

    public string PhoneFamilyName { get; set; } = null!;

    public string LeadCode { get; set; } = null!;

    public decimal Cpl { get; set; }

    public DateTime? PendingAllocationDate { get; set; }

    public byte IsReleased { get; set; }
}
