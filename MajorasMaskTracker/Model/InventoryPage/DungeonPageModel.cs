using System.IO;
using System.Xml.Serialization;
using BaseClasses;

namespace MajorasMaskTracker.Model.InventoryPage;

public class DungeonPageModel : BaseModel
{
    [XmlElement] public bool IsWoodfallMapCollected { get; set; }
    [XmlElement] public bool IsWoodfallCompassCollected { get; set; }
    [XmlElement] public bool IsWoodfallBossKeyCollected { get; set; }
    [XmlElement] public int CollectedWoodfallFairies { get; set; }
    [XmlElement] public int CollectedWoodfallSmallKeys { get; set; }
    
    [XmlElement] public bool IsSnowheadMapCollected { get; set; }
    [XmlElement] public bool IsSnowheadCompassCollected { get; set; }
    [XmlElement] public bool IsSnowheadBossKeyCollected { get; set; }
    [XmlElement] public int CollectedSnowheadFairies { get; set; }
    [XmlElement] public int CollectedSnowheadSmallKeys { get; set; }
    
    [XmlElement] public bool IsGreatBayMapCollected { get; set; }
    [XmlElement] public bool IsGreatBayCompassCollected { get; set; }
    [XmlElement] public bool IsGreatBayBossKeyCollected { get; set; }
    [XmlElement] public int CollectedGreatBayFairies { get; set; }
    [XmlElement] public int CollectedGreatBaySmallKeys { get; set; }
    
    [XmlElement] public bool IsStoneTowerMapCollected { get; set; }
    [XmlElement] public bool IsStoneTowerCompassCollected { get; set; }
    [XmlElement] public bool IsStoneTowerBossKeyCollected { get; set; }
    [XmlElement] public int CollectedStoneTowerFairies { get; set; }
    [XmlElement] public int CollectedStoneTowerSmallKeys { get; set; }


    public string ToXml()
    {
        var stream = new StringWriter();
        var serializer = new XmlSerializer(typeof(DungeonPageModel));
        serializer.Serialize(stream, this);
        return stream.ToString();
    }
    
    
    public static DungeonPageModel FromXml(string xml)
    {
        var serializer = new XmlSerializer(typeof(DungeonPageModel));
        var ret = (DungeonPageModel) serializer.Deserialize(new StringReader(xml));
        
        return ret ?? new DungeonPageModel();
    }
}