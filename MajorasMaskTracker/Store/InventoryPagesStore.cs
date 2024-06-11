using System.Windows.Controls;
using MajorasMaskTracker.View.InventoryPage;

namespace MajorasMaskTracker.Store;

public class InventoryPagesStore
{
    public Page[] Pages { get; } =
    {
        new QuestItemPage(),
        new MaskPage(),
        new DungeonPage(),
        new QuestStatusPage(),
    };


    private static InventoryPagesStore? _instance;
    public static InventoryPagesStore Instance => _instance ??= new InventoryPagesStore();
}