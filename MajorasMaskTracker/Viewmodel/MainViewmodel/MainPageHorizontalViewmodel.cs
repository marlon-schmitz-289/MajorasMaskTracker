using System.Windows.Controls;
using MajorasMaskTracker.Store;
using MajorasMaskTracker.Util.Enum;
using WPFBase.Utils;

namespace MajorasMaskTracker.Viewmodel.MainViewmodel;

public class MainPageHorizontalViewmodel : BaseViewmodel
{
    public Page QuestItemPage => InventoryPagesStore.Instance.HorizontalPages[(int)InventoryPages.QuestItemsPage];
    public Page MaskPage => InventoryPagesStore.Instance.HorizontalPages[(int)InventoryPages.MasksPage];
    public Page DungeonPage => InventoryPagesStore.Instance.HorizontalPages[(int)InventoryPages.DungeonItemsPage];
    public Page QuestStatusPage => InventoryPagesStore.Instance.HorizontalPages[(int)InventoryPages.QuestStatusPage];
}