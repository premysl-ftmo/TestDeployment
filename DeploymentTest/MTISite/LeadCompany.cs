namespace StriveApi.Database.Models.MTISite;

public partial class LeadCompany
{
    public string LeadCode { get; set; } = null!;

    public string LeadContacts { get; set; } = null!;

    public byte SendEmail { get; set; }

    public byte SendEmptyEmails { get; set; }

    public byte SendMonthlySummary { get; set; }

    public string? EmailPassword { get; set; }
}
