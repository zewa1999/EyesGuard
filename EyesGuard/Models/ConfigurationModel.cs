namespace EyesGuard.Models;

public record ConfigurationModel
{
    public int IntervalMinutesTime { get; set; }
    public string TextToDisplay { get; set; } = null!;
    public bool IsNotificationChecked { get; set; }
    public bool IsWindowPopupChecked { get; set; }
}
