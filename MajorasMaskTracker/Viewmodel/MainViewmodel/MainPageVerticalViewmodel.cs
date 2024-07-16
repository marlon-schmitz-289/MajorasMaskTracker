using System.Windows.Controls;
using MajorasMaskTracker.Store;
using MajorasMaskTracker.Util.Enum;
using WPFBase.Utils;

namespace MajorasMaskTracker.Viewmodel.MainViewmodel;

public class MainPageVerticalViewmodel : BaseViewmodel
{
    public Page QuestItemPage => InventoryPagesStore.Instance.VerticalPages[(int)InventoryPages.QuestItemsPage];
    public Page MaskPage => InventoryPagesStore.Instance.VerticalPages[(int)InventoryPages.MasksPage];
    public Page DungeonPage => InventoryPagesStore.Instance.VerticalPages[(int)InventoryPages.DungeonItemsPage];
    public Page QuestStatusPage => InventoryPagesStore.Instance.VerticalPages[(int)InventoryPages.QuestStatusPage];
}