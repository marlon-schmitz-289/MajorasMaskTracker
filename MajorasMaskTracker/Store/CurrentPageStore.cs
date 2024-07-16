using System.Windows.Controls;
using MajorasMaskTracker.View;

namespace MajorasMaskTracker.Store;

public class CurrentPageStore
{
    private Page? _currentPage;

    public Page CurrentPage
    {
        get => _currentPage ??= new MainPage();
        set
        {
            _currentPage = value;
            CurrentPageChanged?.Invoke();
        }
    }


    public static CurrentPageStore Instance { get; } = new();
    public event Action? CurrentPageChanged;
}