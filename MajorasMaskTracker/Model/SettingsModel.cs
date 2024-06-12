using System.IO;
using System.Xml.Serialization;
using BaseClasses;
using MajorasMaskTracker.Model.InventoryPage;

namespace MajorasMaskTracker.Model;

public class SettingsModel : BaseModel
{
    public DungeonPageModel DungeonPageSettings { get; set; } = new DungeonPageModel();
    public MaskPageModel MasksPageSettings { get; set; } = new MaskPageModel();
    public QuestStatusPageModel QuestStatusPageSettings { get; set; } = new QuestStatusPageModel();
    public QuestItemPageModel QuestItemsPageSettings { get; set; } = new QuestItemPageModel();
    
    
    public string ToXml()
    {
        var stream = new StringWriter();
        var serializer = new XmlSerializer(typeof(SettingsModel));
        serializer.Serialize(stream, this);
        return stream.ToString();
    }


    public static SettingsModel FromXml(string xml)
    {
        var serializer = new XmlSerializer(typeof(QuestStatusPageModel));
        var ret = (SettingsModel)serializer.Deserialize(new StringReader(xml));

        return ret ?? new SettingsModel();
    }
}