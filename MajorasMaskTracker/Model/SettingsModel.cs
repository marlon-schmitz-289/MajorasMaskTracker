using System.IO;
using System.Xml.Serialization;
using BaseClasses;
using MajorasMaskTracker.Model.InventoryPage;

namespace MajorasMaskTracker.Model;

public class SettingsModel : BaseModel
{
    public MaskModel Masks { get; set; } = new MaskModel();
    public QuestStatusModel QuestStatus { get; set; } = new QuestStatusModel();
    public QuestItemModel QuestItems { get; set; } = new QuestItemModel();
    
    
    public string ToXml()
    {
        var stream = new StringWriter();
        var serializer = new XmlSerializer(typeof(SettingsModel));
        serializer.Serialize(stream, this);
        return stream.ToString();
    }


    public static SettingsModel FromXml(string xml)
    {
        var serializer = new XmlSerializer(typeof(QuestStatusModel));
        var ret = (SettingsModel)serializer.Deserialize(new StringReader(xml));

        return ret ?? new SettingsModel();
    }
}