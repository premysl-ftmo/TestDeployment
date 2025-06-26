namespace StriveApi.Database.Models.MTISite;

public partial class WhiteLabelUserMapping
{
    public string UniverseId { get; set; } = null!;

    public string UserId { get; set; } = null!;

    public string MappedUsername { get; set; } = null!;

    public int AccessMode { get; set; }
}
