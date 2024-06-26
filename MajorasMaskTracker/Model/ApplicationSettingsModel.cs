using System.IO;
using System.Windows.Media;
using System.Xml.Serialization;
using BaseClasses;

namespace MajorasMaskTracker.Model;

public class ApplicationSettingsModel : BaseModel
{
    private static readonly string _SETTINGS_PATH =
        Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "MajorasMaskTracker");

    private static readonly string _SETTINGS_FILE_PATH = Path.Combine(_SETTINGS_PATH, "AppSettings.xml");


    public event Action? OnBackgroundColorChanged;
    private Color _backgroundColor;
    private SolidColorBrush _backgroundBrush;

    [XmlIgnore]
    public Color BackgroundColor
    {
        get => _backgroundColor;
        set
        {
            _backgroundColor = value;
            BackgroundBrush = new SolidColorBrush(BackgroundColor);
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

    [XmlElement] public byte BackgroundColorRed { get; set; }
    [XmlElement] public byte BackgroundColorGreen { get; set; }
    [XmlElement] public byte BackgroundColorBlue { get; set; }


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
            ForegroundBrush = new SolidColorBrush(ForegroundColor);
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

    [XmlElement] public byte ForegroundColorRed { get; set; }
    [XmlElement] public byte ForegroundColorGreen { get; set; }
    [XmlElement] public byte ForegroundColorBlue { get; set; }


    [XmlIgnore] public bool ReadFromSettings { get; private set; }


    public void ChangedBackgroundColor()
    {
        OnBackgroundColorChanged?.Invoke();
    }


    private string ToXml()
    {
        BackgroundColorRed = BackgroundColor.R;
        BackgroundColorGreen = BackgroundColor.G;
        BackgroundColorBlue = BackgroundColor.B;

        ForegroundColorRed = ForegroundColor.R;
        ForegroundColorGreen = ForegroundColor.G;
        ForegroundColorBlue = ForegroundColor.B;

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
            ret = new ApplicationSettingsModel();
        }
        else
        {
            ret.ReadFromSettings = true;
        }
        
        ret.InitializeBrushes();
        return ret;
    }


    public void SaveSettings()
    {
        if (!Directory.Exists(_SETTINGS_PATH))
        {
            Directory.CreateDirectory(_SETTINGS_PATH);
        }

        var xml = ToXml();
        File.WriteAllText(_SETTINGS_FILE_PATH, xml);
    }


    public static ApplicationSettingsModel LoadSettings()
    {
        if (!Directory.Exists(_SETTINGS_PATH))
        {
            Directory.CreateDirectory(_SETTINGS_PATH);
        }

        if (!File.Exists(_SETTINGS_FILE_PATH))
        {
            return new ApplicationSettingsModel();
        }

        var xml = File.ReadAllText(_SETTINGS_FILE_PATH);
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
        if (!ReadFromSettings)
        {
            BackgroundColorRed = 63;
            BackgroundColorGreen = 63;
            BackgroundColorBlue = 63;

            ForegroundColorRed = 221;
            ForegroundColorGreen = 221;
            ForegroundColorBlue = 221;
        }
        
        BackgroundColor = Color.FromRgb(BackgroundColorRed, BackgroundColorGreen, BackgroundColorBlue);
        ForegroundColor = Color.FromRgb(ForegroundColorRed, ForegroundColorGreen, ForegroundColorBlue);
    }
}