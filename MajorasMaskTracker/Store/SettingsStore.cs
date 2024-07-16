using BaseClasses;
using MajorasMaskTracker.Model;

namespace MajorasMaskTracker.Store;

public class SettingsStore : BaseModel
{
    private ApplicationSettingsModel _applicationSettings;
    private SettingsModel _settings;


    private SettingsStore()
    {
        Settings = new SettingsModel();
        ApplicationSettings = new ApplicationSettingsModel();
    }

    public SettingsModel Settings
    {
        get => _settings;
        set
        {
            _settings = value;
            NotifyPropertyChanged();
        }
    }

    public ApplicationSettingsModel ApplicationSettings
    {
        get => _applicationSettings;
        set
        {
            _applicationSettings = value;
            NotifyPropertyChanged();
        }
    }


    public static SettingsStore Instance { get; } = new();
}