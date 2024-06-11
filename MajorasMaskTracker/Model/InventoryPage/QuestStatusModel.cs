using System.IO;
using System.Xml.Serialization;
using BaseClasses;
using MajorasMaskTracker.Util;

namespace MajorasMaskTracker.Model.InventoryPage;

public class QuestStatusModel : BaseModel
{
    [XmlElement("HasOdolwa")] public bool OdolwaCollected { get; set; }
    [XmlElement("HasGoht")] public bool GohtCollected { get; set; }
    [XmlElement("HasGyorg")] public bool GyorgCollected { get; set; }
    [XmlElement("HasTwinmold")] public bool TwinmoldCollected { get; set; }

    [XmlElement("AmountOfHeartPieces")] public int CollectedHeartPieces { get; set; }
    [XmlElement("HasBombersNotebook")] public bool BombersNotebookCollected { get; set; }

    [XmlElement("HasSongOfTime")] public bool SongOfTimeCollected { get; set; }
    [XmlElement("HasSongOfSoaring")] public bool SongOfHealingCollected { get; set; }
    [XmlElement("HasEponasSong")] public bool EponasSongCollected { get; set; }
    [XmlElement("HasSongOfSoaring")] public bool SongOfSoaringCollected { get; set; }
    [XmlElement("HasSongOfStorms")] public bool SongOfStormsCollected { get; set; }
    [XmlElement("HasSonataOfAwakening")] public bool SonataOfAwakeningCollected { get; set; }
    [XmlElement("HasGoronLullaby")] public bool GoronLullabyCollected { get; set; }
    [XmlElement("HasNewWaveBossaNova")] public bool NewWaveBossaNovaCollected { get; set; }
    [XmlElement("HasElegyOfEmptiness")] public bool ElegyOfEmptinessCollected { get; set; }
    [XmlElement("HasOathToOrder")] public bool OathToOrderCollected { get; set; }

    [XmlElement("Sword")] public CollectedSword Sword { get; set; } = CollectedSword.None;
    [XmlElement("Shield")] public CollectedShield Shield { get; set; } = CollectedShield.None;
    [XmlElement("Quiver")] public CollectedQuiver Quiver { get; set; } = CollectedQuiver.None;
    [XmlElement("BombBag")] public CollectedBombBag BombBag { get; set; } = CollectedBombBag.None;
    [XmlElement("Wallet")] public CollectedWallet Wallet { get; set; } = CollectedWallet.None;
    [XmlElement("Magic")] public CollectedMagic Magic { get; set; } = CollectedMagic.None;


    public string ToXml()
    {
        var stream = new StringWriter();
        var serializer = new XmlSerializer(typeof(QuestStatusModel));
        serializer.Serialize(stream, this);
        return stream.ToString();
    }
    
    
    public static QuestStatusModel FromXml(string xml)
    {
        var serializer = new XmlSerializer(typeof(QuestStatusModel));
        var ret = (QuestStatusModel) serializer.Deserialize(new StringReader(xml));
        
        return ret ?? new QuestStatusModel();
    }
}