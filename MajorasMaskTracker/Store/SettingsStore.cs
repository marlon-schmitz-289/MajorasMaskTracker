using BaseClasses;
using MajorasMaskTracker.Model;

namespace MajorasMaskTracker.Store;

public class SettingsStore : BaseModel
{
    private SettingsModel _settingsModel;
    public SettingsModel SettingsModel
    {
        get => _settingsModel;
        set
        {
            _settingsModel = value;
            NotifyPropertyChanged();
        }
    }
    
    
    private ApplicationSettingsModel _applicationSettingsModel;
    public ApplicationSettingsModel ApplicationSettingsModel
    {
        get => _applicationSettingsModel;
        set
        {
            _applicationSettingsModel = value;
            NotifyPropertyChanged();
        }
    }
    
    
    private SettingsStore()
    {
        SettingsModel = new SettingsModel();
        ApplicationSettingsModel = new ApplicationSettingsModel();
    }
    
    
    public static SettingsStore Instance { get; } = new();
}