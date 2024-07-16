using System.Windows.Controls;
using MajorasMaskTracker.View.Inventory;
using DungeonPage = MajorasMaskTracker.View.Inventory.DungeonPage;
using MaskPage = MajorasMaskTracker.View.Inventory.MaskPage;
using QuestItemPage = MajorasMaskTracker.View.Inventory.QuestItemPage;

namespace MajorasMaskTracker.Store;

public class InventoryPagesStore
{
    private static InventoryPagesStore? _instance;

    public Page[] HorizontalPages { get; } =
    [
        new QuestItemPage(),
        new MaskPage(),
        new DungeonPage(),
        new QuestStatusPage()
    ];

    public Page[] VerticalPages { get; } =
    [
        new QuestItemPage(),
        new MaskPage(),
        new DungeonPage(),
        new QuestStatusPage()
    ];

    public static InventoryPagesStore Instance => _instance ??= new InventoryPagesStore();
}