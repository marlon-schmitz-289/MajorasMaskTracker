using BaseClasses;
using MajorasMaskTracker.Model;

namespace MajorasMaskTracker.Store;

public class SettingsStore : BaseModel
{
    private SettingsModel _settings;

    public SettingsModel Settings
    {
        get => _settings;
        set
        {
            _settings = value;
            NotifyPropertyChanged();
        }
    }


    private ApplicationSettingsModel _applicationSettings;

    public ApplicationSettingsModel ApplicationSettings
    {
        get => _applicationSettings;
        set
        {
            _applicationSettings = value;
            NotifyPropertyChanged();
        }
    }


    private SettingsStore()
    {
        Settings = new SettingsModel();
        ApplicationSettings = new ApplicationSettingsModel();
    }


    public static SettingsStore Instance { get; } = new();
}