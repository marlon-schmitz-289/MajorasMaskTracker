using System.IO;
using System.Xml.Serialization;
using BaseClasses;
using MajorasMaskTracker.Model.Inventory;
using MajorasMaskTracker.Util.Enum;

namespace MajorasMaskTracker.Model;

public class SettingsModel : BaseModel
{
    private static readonly string SettingsPath =
        Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "MajorasMaskTracker");

    private static readonly string SettingsFilePath = Path.Combine(SettingsPath, "Settings.xml");
    private Layout _layout = Layout.Horizontal;

    public DungeonPageModel DungeonPageSettings { get; set; } = new();
    public MaskPageModel MasksPageSettings { get; set; } = new();
    public QuestStatusPageModel QuestStatusPageSettings { get; set; } = new();
    public QuestItemPageModel QuestItemsPageSettings { get; set; } = new();

    public Layout Layout
    {
        get => _layout;
        set
        {
            _layout = value;
            LayoutChanged?.Invoke();
        }
    }


    public event Action LayoutChanged;


    private string ToXml()
    {
        var stream = new StringWriter();

        var nameSpace = new XmlSerializerNamespaces();
        nameSpace.Add("", "");

        var serializer = new XmlSerializer(typeof(SettingsModel));
        serializer.Serialize(stream, this, nameSpace);
        return stream.ToString();
    }


    private static SettingsModel FromXml(string xml)
    {
        var serializer = new XmlSerializer(typeof(SettingsModel));
        var ret = (SettingsModel)serializer.Deserialize(new StringReader(xml));

        return ret ?? new SettingsModel();
    }


    public void SaveSettings()
    {
        if (!Directory.Exists(SettingsPath)) Directory.CreateDirectory(SettingsPath);

        var xml = ToXml();
        File.WriteAllText(SettingsFilePath, xml);
    }


    public static SettingsModel LoadSettings()
    {
        if (!Directory.Exists(SettingsPath)) Directory.CreateDirectory(SettingsPath);

        if (!File.Exists(SettingsFilePath)) return new SettingsModel();

        var xml = File.ReadAllText(SettingsFilePath);
        return FromXml(xml);
    }
}