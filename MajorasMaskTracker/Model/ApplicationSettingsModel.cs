using System.IO;
using System.Windows.Media;
using System.Xml.Serialization;
using BaseClasses;

namespace MajorasMaskTracker.Model;

public class ApplicationSettingsModel : BaseModel
{
    private static readonly string SettingsPath =
        Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "MajorasMaskTracker");

    private static readonly string SettingsFilePath = Path.Combine(SettingsPath, "AppSettings.xml");


    public event Action OnBackgroundColorChanged;
    private Color _backgroundColor;
    private SolidColorBrush _backgroundBrush;

    [XmlIgnore]
    public Color BackgroundColor
    {
        get => _backgroundColor;
        set
        {
            _backgroundColor = value;
            OnBackgroundColorChanged?.Invoke();
        }
    }

    [XmlIgnore]
    public SolidColorBrush BackgroundBrush
    {
        get => _backgroundBrush;
        set
        {
            _backgroundBrush = value;
            OnBackgroundColorChanged?.Invoke();
        }
    }
    
    [XmlElement] private byte BackgroundColorRed { get; set; }
    [XmlElement] private byte BackgroundColorGreen { get; set; }
    [XmlElement] private byte BackgroundColorBlue { get; set; }


    public event Action OnForegroundColorChanged;
    private Color _foregroundColor;
    private SolidColorBrush _foregroundBrush;

    [XmlIgnore]
    public Color ForegroundColor
    {
        get => _foregroundColor;
        set
        {
            _foregroundColor = value;
            OnForegroundColorChanged?.Invoke();
        }
    }

    [XmlIgnore]
    public SolidColorBrush ForegroundBrush
    {
        get => _foregroundBrush;
        set
        {
            _foregroundBrush = value;
            OnForegroundColorChanged?.Invoke();
        }
    }
    
    [XmlElement] private byte ForegroundColorRed { get; set; }
    [XmlElement] private byte ForegroundColorGreen { get; set; }
    [XmlElement] private byte ForegroundColorBlue { get; set; }
    
    
    [XmlIgnore] public bool ReadFromSettings { get; private set; }


    private string ToXml()
    {
        var stream = new StringWriter();

        var nameSpace = new XmlSerializerNamespaces();
        nameSpace.Add("", "");

        var serializer = new XmlSerializer(typeof(ApplicationSettingsModel));
        serializer.Serialize(stream, this, nameSpace);
        return stream.ToString();
    }


    private static ApplicationSettingsModel FromXml(string xml)
    {
        var serializer = new XmlSerializer(typeof(ApplicationSettingsModel));
        var ret = (ApplicationSettingsModel)serializer.Deserialize(new StringReader(xml));

        if (ret is null)
        {
            var empty = new ApplicationSettingsModel();
            
            empty.InitializeBrushes();
            
            return empty;
        }
        
        ret.ReadFromSettings = true;
        
        ret.BackgroundColor = Color.FromRgb(ret.BackgroundColorRed, ret.BackgroundColorGreen, ret.BackgroundColorBlue);
        ret.BackgroundBrush = new SolidColorBrush(ret.BackgroundColor);
        
        ret.ForegroundColor = Color.FromRgb(ret.ForegroundColorRed, ret.ForegroundColorGreen, ret.ForegroundColorBlue);
        ret.ForegroundBrush = new SolidColorBrush(ret.ForegroundColor);
        
        return ret;
    }


    public void SaveSettings()
    {
        if (!Directory.Exists(SettingsPath))
        {
            Directory.CreateDirectory(SettingsPath);
        }

        var xml = ToXml();
        File.WriteAllText(SettingsFilePath, xml);
    }


    public static ApplicationSettingsModel LoadSettings()
    {
        if (!Directory.Exists(SettingsPath))
        {
            Directory.CreateDirectory(SettingsPath);
        }

        if (!File.Exists(SettingsFilePath))
        {
            return new ApplicationSettingsModel();
        }

        var xml = File.ReadAllText(SettingsFilePath);
        return FromXml(xml);
    }
    
    
    public void InitializeBrushes()
    {
        InitializeColors();
        
        BackgroundBrush = new SolidColorBrush(BackgroundColor);
        ForegroundBrush = new SolidColorBrush(ForegroundColor);
    }


    private void InitializeColors()
    {
        BackgroundColorRed = 63;
        BackgroundColorGreen = 63;
        BackgroundColorBlue = 63;
        BackgroundColor = Color.FromRgb(63, 63, 63);
        
        ForegroundColorRed = 221;
        ForegroundColorGreen = 221;
        ForegroundColorBlue = 221;
        ForegroundColor = Color.FromRgb(221, 221, 221);
    }
}