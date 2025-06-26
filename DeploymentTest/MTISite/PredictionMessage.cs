namespace StriveApi.Database.Models.MTISite;

public partial class PredictionMessage
{
    public int PredictionMessageId { get; set; }

    public int PredictionId { get; set; }

    public DateTime PredictionMessageTimeUtc { get; set; }

    public int PredictionMessageTypeId { get; set; }

    public string UserId { get; set; } = null!;

    public string? MessageBody { get; set; }

    public short IsDeleted { get; set; }
}
