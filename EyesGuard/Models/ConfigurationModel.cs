namespace EyesGuard.Models;

public static class ConfigurationModel
{
    public static int IntervalMinutesTime { get; set; }
    public static int PauseDuration { get; set; }
    public static string TextToDisplay { get; set; } = null!;
    public static bool IsWindowPopupChecked { get; set; }
}