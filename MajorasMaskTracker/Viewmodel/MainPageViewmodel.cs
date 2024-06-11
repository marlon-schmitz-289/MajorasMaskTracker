using System.Windows.Controls;
using MajorasMaskTracker.Store;
using MajorasMaskTracker.Util;
using WPFBase.Utils;

namespace MajorasMaskTracker.Viewmodel;

public class MainPageViewmodel : BaseViewModel
{
    public Page[] Pages => InventoryPagesStore.Instance.Pages;
    
    public Page QuestItemPage => InventoryPagesStore.Instance.Pages[(int)InventoryPages.QuestItemsPage];
    public Page MaskPage => InventoryPagesStore.Instance.Pages[(int)InventoryPages.MasksPage];
    public Page DungeonPage => InventoryPagesStore.Instance.Pages[(int)InventoryPages.DungeonItemsPage];
    public Page QuestStatusPage => InventoryPagesStore.Instance.Pages[(int)InventoryPages.QuestStatusPage];
}