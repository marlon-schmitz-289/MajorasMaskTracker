using MajorasMaskTracker.Store;
using MajorasMaskTracker.Util;
using WPFBase.Utils;

namespace MajorasMaskTracker.Viewmodel.InventoryViewmodel;

public class QuestItemPageViewmodel : BaseViewModel
{
    public bool IsOcarinaOfTimeCollected
    {
        get => SettingsStore.Instance.SettingsModel.QuestItemsPageSettings.IsOcarinaOfTimeCollected;
        set
        {
            SettingsStore.Instance.SettingsModel.QuestItemsPageSettings.IsOcarinaOfTimeCollected = value;
            NotifyPropertyChanged();
        }
    }

    public bool IsHeroBowCollected =>
        SettingsStore.Instance.SettingsModel.QuestStatusPageSettings.CollectedQuiver != CollectedQuiver.None;

    public bool IsFireArrowCollected
    {
        get => SettingsStore.Instance.SettingsModel.QuestItemsPageSettings.IsFireArrowCollected;
        set
        {
            SettingsStore.Instance.SettingsModel.QuestItemsPageSettings.IsFireArrowCollected = value;
            NotifyPropertyChanged();
        }
    }

    public bool IsIceArrowCollected
    {
        get => SettingsStore.Instance.SettingsModel.QuestItemsPageSettings.IsIceArrowCollected;
        set
        {
            SettingsStore.Instance.SettingsModel.QuestItemsPageSettings.IsIceArrowCollected = value;
            NotifyPropertyChanged();
        }
    }

    public bool IsLightArrowCollected
    {
        get => SettingsStore.Instance.SettingsModel.QuestItemsPageSettings.IsLightArrowCollected;
        set
        {
            SettingsStore.Instance.SettingsModel.QuestItemsPageSettings.IsLightArrowCollected = value;
            NotifyPropertyChanged();
        }
    }

    public bool IsRoomKeyCollected
    {
        get => SettingsStore.Instance.SettingsModel.QuestItemsPageSettings.IsRoomKeyCollected;
        set
        {
            SettingsStore.Instance.SettingsModel.QuestItemsPageSettings.IsRoomKeyCollected = value;
            NotifyPropertyChanged();
        }
    }

    public bool IsBombBagCollected =>
        SettingsStore.Instance.SettingsModel.QuestItemsPageSettings.IsBombBagCollected;

    public bool IsBombChusCollected
    {
        get => SettingsStore.Instance.SettingsModel.QuestItemsPageSettings.IsBombChusCollected;
        set
        {
            SettingsStore.Instance.SettingsModel.QuestItemsPageSettings.IsBombChusCollected = value;
            NotifyPropertyChanged();
        }
    }

    public bool IsDekuStickCollected
    {
        get => SettingsStore.Instance.SettingsModel.QuestItemsPageSettings.IsDekuStickCollected;
        set
        {
            SettingsStore.Instance.SettingsModel.QuestItemsPageSettings.IsDekuStickCollected = value;
            NotifyPropertyChanged();
        }
    }

    public bool IsDekuNutCollected
    {
        get => SettingsStore.Instance.SettingsModel.QuestItemsPageSettings.IsDekuNutCollected;
        set
        {
            SettingsStore.Instance.SettingsModel.QuestItemsPageSettings.IsDekuNutCollected = value;
            NotifyPropertyChanged();
        }
    }

    public bool IsMagicBeanCollected
    {
        get => SettingsStore.Instance.SettingsModel.QuestItemsPageSettings.IsMagicBeanCollected;
        set
        {
            SettingsStore.Instance.SettingsModel.QuestItemsPageSettings.IsMagicBeanCollected = value;
            NotifyPropertyChanged();
        }
    }

    public CollectedScrubTradeItem CollectedScrubTradeItem
    {
        get => SettingsStore.Instance.SettingsModel.QuestItemsPageSettings.CollectedScrubTradeItem;
        set
        {
            if (value is < 0 or > CollectedScrubTradeItem.OceanTitleDeed) return;

            SettingsStore.Instance.SettingsModel.QuestItemsPageSettings.CollectedScrubTradeItem = value;

            NotifyPropertyChanged();
            NotifyPropertyChanged(nameof(IsScrubTradeItemCollected));
            NotifyPropertyChanged(nameof(IsMoonsTearCollected));
            NotifyPropertyChanged(nameof(IsLandTitleDeedCollected));
            NotifyPropertyChanged(nameof(IsSwampTitleDeedCollected));
            NotifyPropertyChanged(nameof(IsMountainTitleDeedCollected));
            NotifyPropertyChanged(nameof(IsOceanTitleDeedCollected));
        }
    }

    public bool IsScrubTradeItemCollected => CollectedScrubTradeItem != CollectedScrubTradeItem.None;
    public bool IsMoonsTearCollected => CollectedScrubTradeItem == CollectedScrubTradeItem.MoonsTear;
    public bool IsLandTitleDeedCollected => CollectedScrubTradeItem == CollectedScrubTradeItem.LandTitleDeed;
    public bool IsSwampTitleDeedCollected => CollectedScrubTradeItem == CollectedScrubTradeItem.SwampTitleDeed;
    public bool IsMountainTitleDeedCollected => CollectedScrubTradeItem == CollectedScrubTradeItem.MountainTitleDeed;
    public bool IsOceanTitleDeedCollected => CollectedScrubTradeItem == CollectedScrubTradeItem.OceanTitleDeed;


    public bool IsPowderKegCollected
    {
        get => SettingsStore.Instance.SettingsModel.QuestItemsPageSettings.IsPowderKegCollected;
        set
        {
            SettingsStore.Instance.SettingsModel.QuestItemsPageSettings.IsPowderKegCollected = value;
            NotifyPropertyChanged();
        }
    }

    public bool IsPictoBoxCollected
    {
        get => SettingsStore.Instance.SettingsModel.QuestItemsPageSettings.IsPictoBoxCollected;
        set
        {
            SettingsStore.Instance.SettingsModel.QuestItemsPageSettings.IsPictoBoxCollected = value;
            NotifyPropertyChanged();
        }
    }

    public bool IsLensOfTruthCollected
    {
        get => SettingsStore.Instance.SettingsModel.QuestItemsPageSettings.IsLensOfTruthCollected;
        set
        {
            SettingsStore.Instance.SettingsModel.QuestItemsPageSettings.IsLensOfTruthCollected = value;
            NotifyPropertyChanged();
        }
    }

    public bool IsHookshotCollected
    {
        get => SettingsStore.Instance.SettingsModel.QuestItemsPageSettings.IsHookshotCollected;
        set
        {
            SettingsStore.Instance.SettingsModel.QuestItemsPageSettings.IsHookshotCollected = value;
            NotifyPropertyChanged();
        }
    }

    public bool IsGreatFairySwordCollected
    {
        get => SettingsStore.Instance.SettingsModel.QuestItemsPageSettings.IsGreatFairySwordCollected;
        set
        {
            SettingsStore.Instance.SettingsModel.QuestItemsPageSettings.IsGreatFairySwordCollected = value;
            NotifyPropertyChanged();
        }
    }

    public CollectedKafeiItem CollectedKafeiItem
    {
        get => SettingsStore.Instance.SettingsModel.QuestItemsPageSettings.CollectedKafeiItem;
        set
        {
            if (value is < 0 or > CollectedKafeiItem.ExpressMailToMama) return;

            SettingsStore.Instance.SettingsModel.QuestItemsPageSettings.CollectedKafeiItem = value;

            NotifyPropertyChanged();
            NotifyPropertyChanged(nameof(IsKafeiItemCollected));
            NotifyPropertyChanged(nameof(IsPendantOfMemoriesCollected));
            NotifyPropertyChanged(nameof(IsLetterToKafeiCollected));
            NotifyPropertyChanged(nameof(IsExpressMailToMamaCollected));
        }
    }

    public bool IsKafeiItemCollected => CollectedKafeiItem != CollectedKafeiItem.None;
    public bool IsPendantOfMemoriesCollected => CollectedKafeiItem == CollectedKafeiItem.PendantOfMemories;
    public bool IsLetterToKafeiCollected => CollectedKafeiItem == CollectedKafeiItem.LetterToKafei;
    public bool IsExpressMailToMamaCollected => CollectedKafeiItem == CollectedKafeiItem.ExpressMailToMama;


    public bool IsFirstBottleCollected
    {
        get => SettingsStore.Instance.SettingsModel.QuestItemsPageSettings.IsFirstBottleCollected;
        set
        {
            SettingsStore.Instance.SettingsModel.QuestItemsPageSettings.IsFirstBottleCollected = value;
            NotifyPropertyChanged();
        }
    }

    public bool IsSecondBottleCollected
    {
        get => SettingsStore.Instance.SettingsModel.QuestItemsPageSettings.IsSecondBottleCollected;
        set
        {
            SettingsStore.Instance.SettingsModel.QuestItemsPageSettings.IsSecondBottleCollected = value;
            NotifyPropertyChanged();
        }
    }

    public bool IsThirdBottleCollected
    {
        get => SettingsStore.Instance.SettingsModel.QuestItemsPageSettings.IsThirdBottleCollected;
        set
        {
            SettingsStore.Instance.SettingsModel.QuestItemsPageSettings.IsThirdBottleCollected = value;
            NotifyPropertyChanged();
        }
    }

    public bool IsFourthBottleCollected
    {
        get => SettingsStore.Instance.SettingsModel.QuestItemsPageSettings.IsFourthBottleCollected;
        set
        {
            SettingsStore.Instance.SettingsModel.QuestItemsPageSettings.IsFourthBottleCollected = value;
            NotifyPropertyChanged();
        }
    }

    public bool IsFifthBottleCollected
    {
        get => SettingsStore.Instance.SettingsModel.QuestItemsPageSettings.IsFifthBottleCollected;
        set
        {
            SettingsStore.Instance.SettingsModel.QuestItemsPageSettings.IsFifthBottleCollected = value;
            NotifyPropertyChanged();
        }
    }

    public bool IsSixthBottleCollected
    {
        get => SettingsStore.Instance.SettingsModel.QuestItemsPageSettings.IsSixthBottleCollected;
        set
        {
            SettingsStore.Instance.SettingsModel.QuestItemsPageSettings.IsSixthBottleCollected = value;
            NotifyPropertyChanged();
        }
    }


    public BaseCommand CollectOcarinaCommand { get; set; }
    public BaseCommand UnCollectOcarinaCommand { get; set; }

    public BaseCommand CollectBowCommand { get; set; }
    public BaseCommand UnCollectBowCommand { get; set; }

    public BaseCommand CollectFireArrowCommand { get; set; }
    public BaseCommand UnCollectFireArrowCommand { get; set; }

    public BaseCommand CollectIceArrowCommand { get; set; }
    public BaseCommand UnCollectIceArrowCommand { get; set; }

    public BaseCommand CollectLightArrowCommand { get; set; }
    public BaseCommand UnCollectLightArrowCommand { get; set; }

    public BaseCommand CollectRoomKeyCommand { get; set; }
    public BaseCommand UnCollectRoomKeyCommand { get; set; }

    public BaseCommand CollectBombBagCommand { get; set; }
    public BaseCommand UnCollectBombBagCommand { get; set; }

    public BaseCommand CollectBombChusCommand { get; set; }
    public BaseCommand UnCollectBombChusCommand { get; set; }

    public BaseCommand CollectDekuStickCommand { get; set; }
    public BaseCommand UnCollectDekuStickCommand { get; set; }

    public BaseCommand CollectDekuNutCommand { get; set; }
    public BaseCommand UnCollectDekuNutCommand { get; set; }

    public BaseCommand CollectMagicBeanCommand { get; set; }
    public BaseCommand UnCollectMagicBeanCommand { get; set; }

    public BaseCommand CollectScrubTradeItemCommand { get; set; }
    public BaseCommand UnCollectScrubTradeItemCommand { get; set; }

    public BaseCommand CollectPowderKegCommand { get; set; }
    public BaseCommand UnCollectPowderKegCommand { get; set; }

    public BaseCommand CollectPictoBoxCommand { get; set; }
    public BaseCommand UnCollectPictoBoxCommand { get; set; }

    public BaseCommand CollectLensOfTruthCommand { get; set; }
    public BaseCommand UnCollectLensOfTruthCommand { get; set; }

    public BaseCommand CollectHookshotCommand { get; set; }
    public BaseCommand UnCollectHookshotCommand { get; set; }

    public BaseCommand CollectGreatFairySwordCommand { get; set; }
    public BaseCommand UnCollectGreatFairySwordCommand { get; set; }

    public BaseCommand CollectKafeiItemCommand { get; set; }
    public BaseCommand UnCollectKafeiItemCommand { get; set; }

    public BaseCommand CollectFirstBottleCommand { get; set; }
    public BaseCommand UnCollectFirstBottleCommand { get; set; }

    public BaseCommand CollectSecondBottleCommand { get; set; }
    public BaseCommand UnCollectSecondBottleCommand { get; set; }

    public BaseCommand CollectThirdBottleCommand { get; set; }
    public BaseCommand UnCollectThirdBottleCommand { get; set; }

    public BaseCommand CollectFourthBottleCommand { get; set; }
    public BaseCommand UnCollectFourthBottleCommand { get; set; }

    public BaseCommand CollectFifthBottleCommand { get; set; }
    public BaseCommand UnCollectFifthBottleCommand { get; set; }

    public BaseCommand CollectSixthBottleCommand { get; set; }
    public BaseCommand UnCollectSixthBottleCommand { get; set; }


    public QuestItemPageViewmodel()
    {
        InitializeCommands();

        SettingsStore.Instance.SettingsModel.QuestStatusPageSettings.OnCollectedQuiverChanged += () =>
        {
            NotifyPropertyChanged(nameof(IsHeroBowCollected));
        };

        SettingsStore.Instance.SettingsModel.QuestStatusPageSettings.OnCollectedBombBagChanged += () =>
        {
            NotifyPropertyChanged(nameof(IsBombBagCollected));
        };
    }


    private void InitializeCommands()
    {
        CollectOcarinaCommand = new BaseCommand((o) => IsOcarinaOfTimeCollected = true);
        UnCollectOcarinaCommand = new BaseCommand((o) => IsOcarinaOfTimeCollected = false);

        CollectBowCommand = new BaseCommand((o) => SettingsStore.Instance.SettingsModel.QuestStatusPageSettings.CollectedQuiver++);
        UnCollectBowCommand = new BaseCommand((o) => SettingsStore.Instance.SettingsModel.QuestStatusPageSettings.CollectedQuiver--);

        CollectFireArrowCommand = new BaseCommand((o) => IsFireArrowCollected = true);
        UnCollectFireArrowCommand = new BaseCommand((o) => IsFireArrowCollected = false);

        CollectIceArrowCommand = new BaseCommand((o) => IsIceArrowCollected = true);
        UnCollectIceArrowCommand = new BaseCommand((o) => IsIceArrowCollected = false);

        CollectLightArrowCommand = new BaseCommand((o) => IsLightArrowCollected = true);
        UnCollectLightArrowCommand = new BaseCommand((o) => IsLightArrowCollected = false);

        CollectRoomKeyCommand = new BaseCommand((o) => IsRoomKeyCollected = true);
        UnCollectRoomKeyCommand = new BaseCommand((o) => IsRoomKeyCollected = false);

        CollectBombBagCommand = new BaseCommand((o) => SettingsStore.Instance.SettingsModel.QuestStatusPageSettings.CollectedBombBag++);
        UnCollectBombBagCommand = new BaseCommand((o) => SettingsStore.Instance.SettingsModel.QuestStatusPageSettings.CollectedBombBag--);

        CollectBombChusCommand = new BaseCommand((o) => IsBombChusCollected = true);
        UnCollectBombChusCommand = new BaseCommand((o) => IsBombChusCollected = false);

        CollectDekuStickCommand = new BaseCommand((o) => IsDekuStickCollected = true);
        UnCollectDekuStickCommand = new BaseCommand((o) => IsDekuStickCollected = false);

        CollectDekuNutCommand = new BaseCommand((o) => IsDekuNutCollected = true);
        UnCollectDekuNutCommand = new BaseCommand((o) => IsDekuNutCollected = false);

        CollectMagicBeanCommand = new BaseCommand((o) => IsMagicBeanCollected = true);
        UnCollectMagicBeanCommand = new BaseCommand((o) => IsMagicBeanCollected = false);

        CollectScrubTradeItemCommand = new BaseCommand((o) => CollectedScrubTradeItem++);
        UnCollectScrubTradeItemCommand = new BaseCommand((o) => CollectedScrubTradeItem--);

        CollectPowderKegCommand = new BaseCommand((o) => IsPowderKegCollected = true);
        UnCollectPowderKegCommand = new BaseCommand((o) => IsPowderKegCollected = false);

        CollectPictoBoxCommand = new BaseCommand((o) => IsPictoBoxCollected = true);
        UnCollectPictoBoxCommand = new BaseCommand((o) => IsPictoBoxCollected = false);

        CollectLensOfTruthCommand = new BaseCommand((o) => IsLensOfTruthCollected = true);
        UnCollectLensOfTruthCommand = new BaseCommand((o) => IsLensOfTruthCollected = false);

        CollectHookshotCommand = new BaseCommand((o) => IsHookshotCollected = true);
        UnCollectHookshotCommand = new BaseCommand((o) => IsHookshotCollected = false);

        CollectGreatFairySwordCommand = new BaseCommand((o) => IsGreatFairySwordCollected = true);
        UnCollectGreatFairySwordCommand = new BaseCommand((o) => IsGreatFairySwordCollected = false);

        CollectKafeiItemCommand = new BaseCommand((o) => CollectedKafeiItem++);
        UnCollectKafeiItemCommand = new BaseCommand((o) => CollectedKafeiItem--);

        CollectFirstBottleCommand = new BaseCommand((o) => IsFirstBottleCollected = true);
        UnCollectFirstBottleCommand = new BaseCommand((o) => IsFirstBottleCollected = false);

        CollectSecondBottleCommand = new BaseCommand((o) => IsSecondBottleCollected = true);
        UnCollectSecondBottleCommand = new BaseCommand((o) => IsSecondBottleCollected = false);

        CollectThirdBottleCommand = new BaseCommand((o) => IsThirdBottleCollected = true);
        UnCollectThirdBottleCommand = new BaseCommand((o) => IsThirdBottleCollected = false);

        CollectFourthBottleCommand = new BaseCommand((o) => IsFourthBottleCollected = true);
        UnCollectFourthBottleCommand = new BaseCommand((o) => IsFourthBottleCollected = false);

        CollectFifthBottleCommand = new BaseCommand((o) => IsFifthBottleCollected = true);
        UnCollectFifthBottleCommand = new BaseCommand((o) => IsFifthBottleCollected = false);

        CollectSixthBottleCommand = new BaseCommand((o) => IsSixthBottleCollected = true);
        UnCollectSixthBottleCommand = new BaseCommand((o) => IsSixthBottleCollected = false);
    }
}