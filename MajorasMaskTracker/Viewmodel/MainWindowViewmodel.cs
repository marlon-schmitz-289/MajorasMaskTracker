using System.Windows.Controls;
using MajorasMaskTracker.Store;
using MajorasMaskTracker.Util;
using WPFBase.Utils;

namespace MajorasMaskTracker.Viewmodel;

public class MainWindowViewmodel : BaseViewModel
{
    public Page CurrentPage => CurrentPageStore.Instance.CurrentPage;
    
    public MainWindowViewmodel()
    {
        CurrentPageStore.Instance.CurrentPageChanged += () => NotifyPropertyChanged(nameof(CurrentPage));
        CurrentPageStore.Instance.CurrentPage = ApplicationPagesStore.Instance.ApplicationPages[(int)ApplicationPages.MainPage];
    }
}