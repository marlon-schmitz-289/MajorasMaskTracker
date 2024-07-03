using System.Windows.Media;
using MajorasMaskTracker.Store;
using WPFBase.Utils;

namespace MajorasMaskTracker.Viewmodel;

public class SettingsWindowViewmodel : BaseViewModel
{
    public SolidColorBrush BackgroundBrush => SettingsStore.Instance.ApplicationSettings.BackgroundBrush;
    public SolidColorBrush ForegroundBrush => SettingsStore.Instance.ApplicationSettings.ForegroundBrush;
    
    
    public Color BackgroundColor
    {
        get => SettingsStore.Instance.ApplicationSettings.BackgroundColor;
        set
        {
            SettingsStore.Instance.ApplicationSettings.BackgroundColor = value;
            SettingsStore.Instance.ApplicationSettings.ChangedBackgroundColor();
            
            NotifyPropertyChanged();
            NotifyPropertyChanged(nameof(BackgroundBrush));

            CheckIfColorIsDark();
        }
    }


    private Color ForegroundColor
    {
        get => SettingsStore.Instance.ApplicationSettings.ForegroundColor;
        set
        {
            SettingsStore.Instance.ApplicationSettings.ForegroundColor = value;
            SettingsStore.Instance.ApplicationSettings.ChangedForegroundColor();
            
            NotifyPropertyChanged();
            NotifyPropertyChanged(nameof(ForegroundBrush));
        }
    }


    private void CheckIfColorIsDark()
    {
        ForegroundColor =
            BackgroundColor.R +
            BackgroundColor.G +
            BackgroundColor.B < 382
                ? Color.FromRgb(221, 221, 221)
                : Color.FromRgb(45, 45, 45);
    }
}