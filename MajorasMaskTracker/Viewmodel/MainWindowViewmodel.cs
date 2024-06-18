using System.Windows.Controls;
using System.Windows.Media;
using MajorasMaskTracker.Store;
using MajorasMaskTracker.Util.Enum;
using WPFBase.Utils;

namespace MajorasMaskTracker.Viewmodel;

public class MainWindowViewmodel : BaseViewModel
{
    public Page CurrentPage => CurrentPageStore.Instance.CurrentPage;

    public SolidColorBrush BackgroundBrush => SettingsStore.Instance.ApplicationSettings.BackgroundBrush;

    
    public MainWindowViewmodel()
    {
        CurrentPageStore.Instance.CurrentPageChanged += () => NotifyPropertyChanged(nameof(CurrentPage));
        CurrentPageStore.Instance.CurrentPage =
            ApplicationPagesStore.Instance.ApplicationPages[(int)ApplicationPages.MainPage];
        
        SettingsStore.Instance.ApplicationSettings.OnBackgroundColorChanged +=
            () => NotifyPropertyChanged(nameof(BackgroundBrush));

        NotifyPropertyChanged(nameof(BackgroundBrush));
    }
}