﻿using System.IO;
using System.Xml.Serialization;
using BaseClasses;
using MajorasMaskTracker.Store;
using MajorasMaskTracker.Util.Enum;

namespace MajorasMaskTracker.Model.Inventory;

public class QuestItemPageModel : BaseModel
{
    [XmlElement] public bool IsOcarinaOfTimeCollected { get; set; }
    [XmlElement] public bool IsHeroBowCollected { get; set; }
    [XmlElement] public bool IsFireArrowCollected { get; set; }
    [XmlElement] public bool IsIceArrowCollected { get; set; }
    [XmlElement] public bool IsLightArrowCollected { get; set; }
    [XmlElement] public bool IsRoomKeyCollected { get; set; }

    [XmlIgnore]
    public bool IsBombBagCollected => SettingsStore.Instance.Settings.QuestStatusPageSettings.CollectedBombBag !=
                                      CollectedBombBag.None;

    [XmlElement] public bool IsBombChusCollected { get; set; }
    [XmlElement] public bool IsDekuStickCollected { get; set; }
    [XmlElement] public bool IsDekuNutCollected { get; set; }
    [XmlElement] public bool IsMagicBeanCollected { get; set; }
    [XmlElement] public CollectedScrubTradeItem CollectedScrubTradeItem { get; set; } = CollectedScrubTradeItem.None;

    [XmlElement] public bool IsPowderKegCollected { get; set; }
    [XmlElement] public bool IsPictoBoxCollected { get; set; }
    [XmlElement] public bool IsLensOfTruthCollected { get; set; }
    [XmlElement] public bool IsHookshotCollected { get; set; }
    [XmlElement] public bool IsGreatFairySwordCollected { get; set; }
    [XmlElement] public CollectedKafeiItem CollectedKafeiItem { get; set; } = CollectedKafeiItem.None;

    [XmlElement] public bool IsFirstBottleCollected { get; set; }
    [XmlElement] public bool IsSecondBottleCollected { get; set; }
    [XmlElement] public bool IsThirdBottleCollected { get; set; }
    [XmlElement] public bool IsFourthBottleCollected { get; set; }
    [XmlElement] public bool IsFifthBottleCollected { get; set; }
    [XmlElement] public bool IsSixthBottleCollected { get; set; }


    public string ToXml()
    {
        var stream = new StringWriter();
        var serializer = new XmlSerializer(typeof(QuestItemPageModel));
        serializer.Serialize(stream, this);
        return stream.ToString();
    }


    public static QuestItemPageModel FromXml(string xml)
    {
        var serializer = new XmlSerializer(typeof(QuestItemPageModel));
        var ret = (QuestItemPageModel)serializer.Deserialize(new StringReader(xml));

        return ret ?? new QuestItemPageModel();
    }
}