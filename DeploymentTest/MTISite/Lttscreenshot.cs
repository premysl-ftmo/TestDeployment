namespace StriveApi.Database.Models.MTISite;

public partial class Lttscreenshot
{
    public int LttsignalId { get; set; }

    public byte[] ScreenshotData { get; set; } = null!;

    public int ScreenshotWidth { get; set; }

    public int ScreenshotHeight { get; set; }

    public string ScreenshotFormat { get; set; } = null!;
}
