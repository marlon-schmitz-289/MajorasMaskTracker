using BaseClasses;
using MajorasMaskTracker.Model;

namespace MajorasMaskTracker.Store;

public class SettingsModelStore : BaseModel
{
    private SettingsModel _settingsModel = new();
    public SettingsModel SettingsModel
    {
        get => _settingsModel;
        set
        {
            _settingsModel = value;
            NotifyPropertyChanged();
        }
    }
    
    
    public static SettingsModelStore Instance { get; } = new();
}