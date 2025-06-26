namespace StriveApi.Database.Models.MTISite;

public partial class CountryCode
{
    public string CountryCode1 { get; set; } = null!;

    public string CountryName { get; set; } = null!;

    public string ISO3 { get; set; } = null!;

    public byte IsEU { get; set; }

    public byte IsEFTA { get; set; }

    public byte IsGeoEurope { get; set; }

    public byte IsMENA { get; set; }

    public byte IsAPAC { get; set; }
}
