using System.Windows.Controls;
using System.Windows.Media;
using MajorasMaskTracker.Store;
using MajorasMaskTracker.Util.Enum;
using MajorasMaskTracker.View;
using WPFBase.Utils;

namespace MajorasMaskTracker.Viewmodel;

public class MainPageViewmodel : BaseViewModel
{
    public Page QuestItemPage => InventoryPagesStore.Instance.Pages[(int)InventoryPages.QuestItemsPage];
    public Page MaskPage => InventoryPagesStore.Instance.Pages[(int)InventoryPages.MasksPage];
    public Page DungeonPage => InventoryPagesStore.Instance.Pages[(int)InventoryPages.DungeonItemsPage];
    public Page QuestStatusPage => InventoryPagesStore.Instance.Pages[(int)InventoryPages.QuestStatusPage];


    public MainPageViewmodel()
    {
    }
}