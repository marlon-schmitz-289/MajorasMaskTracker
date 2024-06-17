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

    [XmlElement]
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


    public event Action OnForegroundColorChanged;
    private Color _foregroundColor;
    private SolidColorBrush _foregroundBrush;

    [XmlElement]
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


    public ApplicationSettingsModel()
    {
        BackgroundColor = Color.FromArgb(255, 63, 63, 63);
        ForegroundColor = Color.FromArgb(255, 221, 221, 221);

        BackgroundBrush = new SolidColorBrush(BackgroundColor);
        ForegroundBrush = new SolidColorBrush(ForegroundColor);
    }


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

        return ret ?? new ApplicationSettingsModel();
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
}