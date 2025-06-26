namespace StriveApi.Database.Models.MTISite;

public partial class ChartSharing
{
    public string ChartSharingId { get; set; } = null!;

    public string FromUserId { get; set; } = null!;

    public string ToAddress { get; set; } = null!;

    public string ChartNotes { get; set; } = null!;

    public string ChartState { get; set; } = null!;

    public DateTime CreationTimeUtc { get; set; }

    public int ReadCount { get; set; }

    public DateTime LastAccessTimeUtc { get; set; }
}
