namespace StriveApi.Database.Models.MTISite;

public partial class MailJourney
{
    public int MailJourneyId { get; set; }

    public string Caption { get; set; } = null!;

    public string MailFileName { get; set; } = null!;

    public int DelayMinutes { get; set; }

    public int NextJourneyId { get; set; }

    public byte AllowDuplicates { get; set; }

    public byte CheckDuplicatesByEmailAddress { get; set; }

    public int ExpireDuplicatesAfterDays { get; set; }

    public int ClickJourneyId { get; set; }

    public string ClickJourneyRedirect { get; set; } = null!;
}
