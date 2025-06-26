global using System.Text.Json.Serialization;

namespace StriveApi.Database.Models.MTISite;

public partial class BrokerDirectoryDetail
{
    [ForeignKey(nameof(BrokerDirectory))]
    public Guid BrokerId { get; set; }

    public int InfoStatus { get; set; }

    public DateTime CreationDateUtc { get; set; }

    public DateTime ModificationDateUtc { get; set; }

    public string LastEditByUserId { get; set; } = null!;

    public Guid? RevisionId { get; set; }

    public string? LiveAccountLink { get; set; }

    [JsonIgnore()]
    public byte[]? BrokerLogo { get; set; }

    public string CompanyOverview { get; set; } = null!;

    public int LogoWidth { get; set; }

    public int LogoHeight { get; set; }

    public bool HasForexMajors { get; set; }

    public bool HasForexMinors { get; set; }

    public bool HasForexExotics { get; set; }

    public bool HasGoldAndSilver { get; set; }

    public bool HasOtherMetals { get; set; }

    public bool HasCommodities { get; set; }

    public bool HasEquityIndices { get; set; }

    public bool HasDjStocks { get; set; }

    public bool HasSpStocks { get; set; }

    public bool HasUk100Stocks { get; set; }

    public bool HasDaxStocks { get; set; }

    public bool HasCrypto { get; set; }

    public bool HasMt4 { get; set; }

    public bool HasMt5 { get; set; }

    public bool HasCtrader { get; set; }

    public bool HasOwnPlatform { get; set; }

    public bool HasOtherPlatform { get; set; }

    public bool HasRegCFTC { get; set; }

    public bool HasRegFSA { get; set; }

    public bool HasRegBaFin { get; set; }

    public bool HasRegCysec { get; set; }

    public bool HasRegASIC { get; set; }

    public bool HasRegOther { get; set; }

    public string Disclaimer { get; set; } = null!;

    public string DefaultArticleDisclaimer { get; set; } = null!;

    public bool HasRegIFSC { get; set; }

    public bool HasRegFSCA { get; set; }

    public string ProprietaryPlatformName { get; set; } = null!;

    public bool HasRegKenya { get; set; }

    public bool HasRegCayman { get; set; }
}
