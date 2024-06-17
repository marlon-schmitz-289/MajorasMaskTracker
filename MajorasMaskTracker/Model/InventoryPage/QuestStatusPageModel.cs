using System.IO;
using System.Xml.Serialization;
using BaseClasses;
using MajorasMaskTracker.Util;

namespace MajorasMaskTracker.Model.InventoryPage;

public class QuestStatusPageModel : BaseModel
{
    [XmlElement] public bool IsOdolwaCollected { get; set; }
    [XmlElement] public bool IsGohtCollected { get; set; }
    [XmlElement] public bool IsGyorgCollected { get; set; }
    [XmlElement] public bool IsTwinmoldCollected { get; set; }

    [XmlElement] public int CollectedHeartPieces { get; set; }
    [XmlElement] public bool IsBombersNotebookCollected { get; set; }

    [XmlElement] public bool IsSongOfTimeCollected { get; set; }
    [XmlElement] public bool IsSongOfHealingCollected { get; set; }
    [XmlElement] public bool IsEponasSongCollected { get; set; }
    [XmlElement] public bool IsSongOfSoaringCollected { get; set; }
    [XmlElement] public bool IsSongOfStormsCollected { get; set; }
    [XmlElement] public bool IsSonataOfAwakeningCollected { get; set; }
    [XmlElement] public bool IsGoronLullabyCollected { get; set; }
    [XmlElement] public bool IsNewWaveBossaNovaCollected { get; set; }
    [XmlElement] public bool IsElegyOfEmptinessCollected { get; set; }
    [XmlElement] public bool IsOathToOrderCollected { get; set; }

    [XmlElement] public CollectedSword CollectedSword { get; set; } = CollectedSword.None;
    [XmlElement] public CollectedShield CollectedShield { get; set; } = CollectedShield.None;

    private CollectedQuiver _collectedQuiver = CollectedQuiver.None;

    [XmlElement]
    public CollectedQuiver CollectedQuiver
    {
        get => _collectedQuiver;
        set
        {
            _collectedQuiver = value;
            OnCollectedQuiverChanged?.Invoke();
        }
    }

    private CollectedBombBag _collectedBombBag = CollectedBombBag.None;

    [XmlElement]
    public CollectedBombBag CollectedBombBag
    {
        get => _collectedBombBag;
        set
        {
            _collectedBombBag = value;
            OnCollectedBombBagChanged?.Invoke();
        }
    }

    [XmlElement] public CollectedWallet CollectedWallet { get; set; } = CollectedWallet.None;
    [XmlElement] public CollectedMagic CollectedMagic { get; set; } = CollectedMagic.None;

    public event Action OnCollectedQuiverChanged;
    public event Action OnCollectedBombBagChanged;


    public string ToXml()
    {
        var stream = new StringWriter();
        var serializer = new XmlSerializer(typeof(QuestStatusPageModel));
        serializer.Serialize(stream, this);
        return stream.ToString();
    }


    public static QuestStatusPageModel FromXml(string xml)
    {
        var serializer = new XmlSerializer(typeof(QuestStatusPageModel));
        var ret = (QuestStatusPageModel)serializer.Deserialize(new StringReader(xml));

        return ret ?? new QuestStatusPageModel();
    }
}