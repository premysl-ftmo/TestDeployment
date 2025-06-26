namespace StriveApi.Database.Models.MTISite;

public partial class RoomCommand
{
    public int RoomCommandId { get; set; }

    public string RoomUserId { get; set; } = null!;

    public int RoomCommandStateId { get; set; }

    public DateTime CreationDateUtc { get; set; }

    public DateTime CollectionDateUtc { get; set; }

    public DateTime ResultDateUtc { get; set; }

    public int IsCopyOfOrderId { get; set; }

    public string? HasCreatedTicketId { get; set; }

    public int CommandErrorCode { get; set; }

    public string CommandText { get; set; } = null!;

    public string? CommandTicketId { get; set; }

    public string? CommandSymbol { get; set; }

    public decimal CommandVolume { get; set; }

    public decimal CommandPrice { get; set; }

    public decimal CommandSl { get; set; }

    public decimal CommandTp { get; set; }

    public string? CommandParams { get; set; }

    public decimal BaseEquity { get; set; }

    public string? SourceUserId { get; set; }
}
