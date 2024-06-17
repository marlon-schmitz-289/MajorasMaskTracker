using System.Configuration;
using System.Data;
using System.Windows;
using MajorasMaskTracker.Model;
using MajorasMaskTracker.Store;

namespace MajorasMaskTracker;

public partial class App : Application
{
    protected override void OnStartup(StartupEventArgs e)
    {
        base.OnStartup(e);
        SettingsStore.Instance.SettingsModel = SettingsModel.LoadSettings();
    }

    protected override void OnExit(ExitEventArgs e)
    {
        base.OnExit(e);
        SettingsStore.Instance.SettingsModel.SaveSettings();
    }
}