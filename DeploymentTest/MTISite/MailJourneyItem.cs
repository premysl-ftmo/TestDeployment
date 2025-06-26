namespace StriveApi.Database.Models.MTISite;

public partial class MailJourneyItem
{
    public string MailJourneyItemId { get; set; } = null!;

    public string UserId { get; set; } = null!;

    public int MailJourneyId { get; set; }

    public byte IsPending { get; set; }

    public DateTime SendTimeUtc { get; set; }
}
