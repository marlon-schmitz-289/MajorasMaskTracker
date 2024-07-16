using System.Windows.Controls;
using MajorasMaskTracker.View.Main;

namespace MajorasMaskTracker.Store;

public class MainPagesStore
{
    public Page[] MainPages { get; } =
    [
        new MainPageHorizontal(),
        new MainPageVertical()
    ];


    public static MainPagesStore Instance { get; } = new();
}