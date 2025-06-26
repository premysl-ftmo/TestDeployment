namespace StriveApi.Database.Models.MTISite;

public partial class RoomOrder
{
    public int RoomOrderId { get; set; }

    public string RoomUserId { get; set; } = null!;

    public string BrokerAccountId { get; set; } = null!;

    public string TicketId { get; set; } = null!;

    public int OrderActionTypeId { get; set; }

    public short IsNewOrder { get; set; }

    public int IsCopyOfOrderId { get; set; }

    public int OrderStateId { get; set; }

    public string OrderSymbol { get; set; } = null!;

    public decimal OpenPrice { get; set; }

    public decimal ClosePrice { get; set; }

    public decimal Sl { get; set; }

    public decimal Tp { get; set; }

    public decimal OriginalOrderLots { get; set; }

    public decimal OriginalOrderVolume { get; set; }

    public decimal FinalOrderLots { get; set; }

    public decimal FinalOrderVolume { get; set; }

    public DateTime BrokerOpenTime { get; set; }

    public DateTime SystemOpenTimeUtc { get; set; }

    public DateTime BrokerCloseTime { get; set; }

    public DateTime SystemCloseTimeUtc { get; set; }

    public decimal OrderProfit { get; set; }

    public decimal OrderSwap { get; set; }

    public decimal OrderCommission { get; set; }

    public int MagicNumber { get; set; }

    public string? OrderComment { get; set; }

    public decimal OrderLikeValue { get; set; }

    public string? PartialCloseTicketId { get; set; }

    public DateTime LastUpdateUtc { get; set; }
}
