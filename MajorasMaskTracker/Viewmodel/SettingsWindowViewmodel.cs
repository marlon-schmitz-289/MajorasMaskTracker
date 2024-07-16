using System.Windows.Controls;
using System.Windows.Media;
using MajorasMaskTracker.Store;
using MajorasMaskTracker.Util.Enum;
using WPFBase.Utils;

namespace MajorasMaskTracker.Viewmodel;

public class SettingsWindowViewmodel : BaseViewmodel
{
    public SettingsWindowViewmodel()
    {
        ChangeLayoutCommand = new BaseCommand(ChangeLayout);
    }


    public BaseCommand ChangeLayoutCommand { get; }


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


    public Layout CurrentLayout
    {
        get => SettingsStore.Instance.Settings.Layout;
        set
        {
            SettingsStore.Instance.Settings.Layout = value;
            NotifyPropertyChanged();
            NotifyPropertyChanged(nameof(IsHorizontalChecked));
            NotifyPropertyChanged(nameof(IsVerticalChecked));
            NotifyPropertyChanged(nameof(IsMapChecked));
        }
    }

    public bool IsHorizontalChecked => CurrentLayout == Layout.Horizontal;
    public bool IsVerticalChecked => CurrentLayout == Layout.Vertical;
    public bool IsMapChecked => CurrentLayout == Layout.Map;


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


    private void ChangeLayout(object sender)
    {
        if (sender is not RadioButton rb) return;
        CurrentLayout = rb.Name switch
        {
            "Vertical" => Layout.Vertical,
            "Horizontal" => Layout.Horizontal,
            "Map" => Layout.Map,
            _ => Layout.Horizontal
        };
    }
}