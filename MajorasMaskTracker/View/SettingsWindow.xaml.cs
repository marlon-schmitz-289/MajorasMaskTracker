using System.Windows;

namespace MajorasMaskTracker.View;

public partial class SettingsWindow
{
    public SettingsWindow()
    {
        InitializeComponent();
        Initialize();

        CanMaximize = false;
    }


    public static void OpenDialog(Window window)
    {
        var settingsWindow = new SettingsWindow
        {
            Owner = window
        };
        settingsWindow.ShowDialog();
    }
}