using System.Windows.Controls;
using MajorasMaskTracker.Store;
using MajorasMaskTracker.Util.Enum;
using WPFBase.Utils;

namespace MajorasMaskTracker.Viewmodel;

public class MainPageViewmodel : BaseViewmodel
{
    private Page _currMainPage;

    public MainPageViewmodel()
    {
        SettingsStore.Instance.Settings.LayoutChanged += ChangeMainPage;
        ChangeMainPage();
    }

    public Page CurrMainPage
    {
        get => _currMainPage;
        private set
        {
            _currMainPage = value;
            NotifyPropertyChanged();
        }
    }


    private void ChangeMainPage()
    {
        CurrMainPage = SettingsStore.Instance.Settings.Layout switch
        {
            Layout.Horizontal or Layout.Vertical => MainPagesStore.Instance.MainPages[
                (int)SettingsStore.Instance.Settings.Layout],
            _ => MainPagesStore.Instance.MainPages[(int)Layout.Horizontal]
        };

        var pages = SettingsStore.Instance.Settings.Layout switch
        {
            Layout.Horizontal => InventoryPagesStore.Instance.HorizontalPages,
            Layout.Vertical => InventoryPagesStore.Instance.VerticalPages,
            _ => InventoryPagesStore.Instance.HorizontalPages
        };
        foreach (var page in pages) (page.DataContext as BaseViewmodel)?.Update();
    }
}