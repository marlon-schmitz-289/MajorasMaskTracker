using System.Windows.Controls;
using MajorasMaskTracker.View;

namespace MajorasMaskTracker.Store;

public class ApplicationPagesStore
{
    public Page[] ApplicationPages { get; } =
    {
        new MainPage()
    };


    public static ApplicationPagesStore Instance { get; } = new();
}