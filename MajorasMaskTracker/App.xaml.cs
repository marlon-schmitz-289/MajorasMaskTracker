using System.Windows;
using MajorasMaskTracker.Model;
using MajorasMaskTracker.Store;

namespace MajorasMaskTracker;

public partial class App : Application
{
    protected override void OnStartup(StartupEventArgs e)
    {
        base.OnStartup(e);
        SettingsStore.Instance.Settings = SettingsModel.LoadSettings();
        SettingsStore.Instance.ApplicationSettings = ApplicationSettingsModel.LoadSettings();

        SettingsStore.Instance.ApplicationSettings.InitializeBrushes();
    }

    protected override void OnExit(ExitEventArgs e)
    {
        base.OnExit(e);
        SettingsStore.Instance.Settings.SaveSettings();
        SettingsStore.Instance.ApplicationSettings.SaveSettings();
    }
}