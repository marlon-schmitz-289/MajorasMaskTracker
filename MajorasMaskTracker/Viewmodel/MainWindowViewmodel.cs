using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using MajorasMaskTracker.Store;
using MajorasMaskTracker.Util.Enum;
using MajorasMaskTracker.View;
using WPFBase.Utils;

namespace MajorasMaskTracker.Viewmodel;

public class MainWindowViewmodel : BaseViewModel
{
    public Page CurrentPage => CurrentPageStore.Instance.CurrentPage;

    public SolidColorBrush BackgroundBrush => SettingsStore.Instance.ApplicationSettings.BackgroundBrush;
    public SolidColorBrush ForegroundBrush => SettingsStore.Instance.ApplicationSettings.ForegroundBrush;


    public BaseCommand SettingsCommand => new BaseCommand((o) =>
    {
        SettingsWindow.OpenDialog(Application.Current.MainWindow);
    });


    public MainWindowViewmodel()
    {
        CurrentPageStore.Instance.CurrentPageChanged += () => NotifyPropertyChanged(nameof(CurrentPage));
        CurrentPageStore.Instance.CurrentPage =
            ApplicationPagesStore.Instance.ApplicationPages[(int)ApplicationPages.MainPage];

        SettingsStore.Instance.ApplicationSettings.OnBackgroundColorChanged +=
            () => { NotifyPropertyChanged(nameof(BackgroundBrush)); };
        
        SettingsStore.Instance.ApplicationSettings.OnForegroundColorChanged +=
            () => { NotifyPropertyChanged(nameof(ForegroundBrush)); };

        SettingsStore.Instance.ApplicationSettings.ChangedBackgroundColor();
    }
}