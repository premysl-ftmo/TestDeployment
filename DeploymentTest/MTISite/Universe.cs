namespace StriveApi.Database.Models.MTISite;

public partial class Universe
{
    public string UniverseId { get; set; } = null!;

    public string UniverseName { get; set; } = null!;

    public string DefaultLanguage { get; set; } = null!;

    public int DefaultServerGmtoffset { get; set; }

    public int DefaultServerDstmode { get; set; }
}
