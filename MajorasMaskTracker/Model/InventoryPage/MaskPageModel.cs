using System.IO;
using System.Xml.Serialization;
using BaseClasses;

namespace MajorasMaskTracker.Model.InventoryPage;

public class MaskPageModel : BaseModel
{
    [XmlElement] public bool IsPostmanHatCollected { get; set; }
    [XmlElement] public bool IsAllNightMaskCollected { get; set; }
    [XmlElement] public bool IsBlastMaskCollected { get; set; }
    [XmlElement] public bool IsStoneMaskCollected { get; set; }
    [XmlElement] public bool IsGreatFairyMaskCollected { get; set; }
    [XmlElement] public bool IsDekuMaskCollected { get; set; }
    
    [XmlElement] public bool IsKeatonMaskCollected { get; set; }
    [XmlElement] public bool IsBremenMaskCollected { get; set; }
    [XmlElement] public bool IsBunnyHoodCollected { get; set; }
    [XmlElement] public bool IsDonGeroMaskCollected { get; set; }
    [XmlElement] public bool IsMaskOfScentsCollected { get; set; }
    [XmlElement] public bool IsGoronMaskCollected { get; set; }
    
    [XmlElement] public bool IsRomaniMaskCollected { get; set; }
    [XmlElement] public bool IsCircusLeadersMaskCollected { get; set; }
    [XmlElement] public bool IsKafeisMaskCollected { get; set; }
    [XmlElement] public bool IsCoupleMaskCollected { get; set; }
    [XmlElement] public bool IsMaskOfTruthCollected { get; set; }
    [XmlElement] public bool IsZoraMaskCollected { get; set; }
    
    [XmlElement] public bool IsKamaroMaskCollected { get; set; }
    [XmlElement] public bool IsGibdoMaskCollected { get; set; }
    [XmlElement] public bool IsGaroMaskCollected { get; set; }
    [XmlElement] public bool IsCaptainHatCollected { get; set; }
    [XmlElement] public bool IsGiantMaskCollected { get; set; }
    [XmlElement] public bool IsFierceDeityMaskCollected { get; set; }


    public string ToXml()
    {
        var stream = new StringWriter();
        var serializer = new XmlSerializer(typeof(MaskPageModel));
        serializer.Serialize(stream, this);
        return stream.ToString();
    }
    
    
    public static MaskPageModel FromXml(string xml)
    {
        var serializer = new XmlSerializer(typeof(MaskPageModel));
        var ret = (MaskPageModel) serializer.Deserialize(new StringReader(xml));
        
        return ret ?? new MaskPageModel();
    }
}