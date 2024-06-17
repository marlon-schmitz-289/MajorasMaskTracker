using System.Windows.Media;
using MajorasMaskTracker.Store;
using MajorasMaskTracker.Util.Enum;
using WPFBase.Utils;

namespace MajorasMaskTracker.Viewmodel.InventoryViewmodel;

public class QuestItemPageViewmodel : BaseViewModel
{
    public bool IsOcarinaOfTimeCollected
    {
        get => SettingsStore.Instance.Settings.QuestItemsPageSettings.IsOcarinaOfTimeCollected;
        set
        {
            SettingsStore.Instance.Settings.QuestItemsPageSettings.IsOcarinaOfTimeCollected = value;
            NotifyPropertyChanged();
        }
    }

    public bool IsHeroBowCollected =>
        SettingsStore.Instance.Settings.QuestStatusPageSettings.CollectedQuiver != CollectedQuiver.None;

    public bool IsFireArrowCollected
    {
        get => SettingsStore.Instance.Settings.QuestItemsPageSettings.IsFireArrowCollected;
        set
        {
            SettingsStore.Instance.Settings.QuestItemsPageSettings.IsFireArrowCollected = value;
            NotifyPropertyChanged();
        }
    }

    public bool IsIceArrowCollected
    {
        get => SettingsStore.Instance.Settings.QuestItemsPageSettings.IsIceArrowCollected;
        set
        {
            SettingsStore.Instance.Settings.QuestItemsPageSettings.IsIceArrowCollected = value;
            NotifyPropertyChanged();
        }
    }

    public bool IsLightArrowCollected
    {
        get => SettingsStore.Instance.Settings.QuestItemsPageSettings.IsLightArrowCollected;
        set
        {
            SettingsStore.Instance.Settings.QuestItemsPageSettings.IsLightArrowCollected = value;
            NotifyPropertyChanged();
        }
    }

    public bool IsRoomKeyCollected
    {
        get => SettingsStore.Instance.Settings.QuestItemsPageSettings.IsRoomKeyCollected;
        set
        {
            SettingsStore.Instance.Settings.QuestItemsPageSettings.IsRoomKeyCollected = value;
            NotifyPropertyChanged();
        }
    }

    public bool IsBombBagCollected =>
        SettingsStore.Instance.Settings.QuestItemsPageSettings.IsBombBagCollected;

    public bool IsBombChusCollected
    {
        get => SettingsStore.Instance.Settings.QuestItemsPageSettings.IsBombChusCollected;
        set
        {
            SettingsStore.Instance.Settings.QuestItemsPageSettings.IsBombChusCollected = value;
            NotifyPropertyChanged();
        }
    }

    public bool IsDekuStickCollected
    {
        get => SettingsStore.Instance.Settings.QuestItemsPageSettings.IsDekuStickCollected;
        set
        {
            SettingsStore.Instance.Settings.QuestItemsPageSettings.IsDekuStickCollected = value;
            NotifyPropertyChanged();
        }
    }

    public bool IsDekuNutCollected
    {
        get => SettingsStore.Instance.Settings.QuestItemsPageSettings.IsDekuNutCollected;
        set
        {
            SettingsStore.Instance.Settings.QuestItemsPageSettings.IsDekuNutCollected = value;
            NotifyPropertyChanged();
        }
    }

    public bool IsMagicBeanCollected
    {
        get => SettingsStore.Instance.Settings.QuestItemsPageSettings.IsMagicBeanCollected;
        set
        {
            SettingsStore.Instance.Settings.QuestItemsPageSettings.IsMagicBeanCollected = value;
            NotifyPropertyChanged();
        }
    }

    public CollectedScrubTradeItem CollectedScrubTradeItem
    {
        get => SettingsStore.Instance.Settings.QuestItemsPageSettings.CollectedScrubTradeItem;
        set
        {
            if (value is < 0 or > CollectedScrubTradeItem.OceanTitleDeed) return;

            SettingsStore.Instance.Settings.QuestItemsPageSettings.CollectedScrubTradeItem = value;

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
        get => SettingsStore.Instance.Settings.QuestItemsPageSettings.IsPowderKegCollected;
        set
        {
            SettingsStore.Instance.Settings.QuestItemsPageSettings.IsPowderKegCollected = value;
            NotifyPropertyChanged();
        }
    }

    public bool IsPictoBoxCollected
    {
        get => SettingsStore.Instance.Settings.QuestItemsPageSettings.IsPictoBoxCollected;
        set
        {
            SettingsStore.Instance.Settings.QuestItemsPageSettings.IsPictoBoxCollected = value;
            NotifyPropertyChanged();
        }
    }

    public bool IsLensOfTruthCollected
    {
        get => SettingsStore.Instance.Settings.QuestItemsPageSettings.IsLensOfTruthCollected;
        set
        {
            SettingsStore.Instance.Settings.QuestItemsPageSettings.IsLensOfTruthCollected = value;
            NotifyPropertyChanged();
        }
    }

    public bool IsHookshotCollected
    {
        get => SettingsStore.Instance.Settings.QuestItemsPageSettings.IsHookshotCollected;
        set
        {
            SettingsStore.Instance.Settings.QuestItemsPageSettings.IsHookshotCollected = value;
            NotifyPropertyChanged();
        }
    }

    public bool IsGreatFairySwordCollected
    {
        get => SettingsStore.Instance.Settings.QuestItemsPageSettings.IsGreatFairySwordCollected;
        set
        {
            SettingsStore.Instance.Settings.QuestItemsPageSettings.IsGreatFairySwordCollected = value;
            NotifyPropertyChanged();
        }
    }

    public CollectedKafeiItem CollectedKafeiItem
    {
        get => SettingsStore.Instance.Settings.QuestItemsPageSettings.CollectedKafeiItem;
        set
        {
            if (value is < 0 or > CollectedKafeiItem.ExpressMailToMama) return;

            SettingsStore.Instance.Settings.QuestItemsPageSettings.CollectedKafeiItem = value;

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
        get => SettingsStore.Instance.Settings.QuestItemsPageSettings.IsFirstBottleCollected;
        set
        {
            SettingsStore.Instance.Settings.QuestItemsPageSettings.IsFirstBottleCollected = value;
            NotifyPropertyChanged();
        }
    }

    public bool IsSecondBottleCollected
    {
        get => SettingsStore.Instance.Settings.QuestItemsPageSettings.IsSecondBottleCollected;
        set
        {
            SettingsStore.Instance.Settings.QuestItemsPageSettings.IsSecondBottleCollected = value;
            NotifyPropertyChanged();
        }
    }

    public bool IsThirdBottleCollected
    {
        get => SettingsStore.Instance.Settings.QuestItemsPageSettings.IsThirdBottleCollected;
        set
        {
            SettingsStore.Instance.Settings.QuestItemsPageSettings.IsThirdBottleCollected = value;
            NotifyPropertyChanged();
        }
    }

    public bool IsFourthBottleCollected
    {
        get => SettingsStore.Instance.Settings.QuestItemsPageSettings.IsFourthBottleCollected;
        set
        {
            SettingsStore.Instance.Settings.QuestItemsPageSettings.IsFourthBottleCollected = value;
            NotifyPropertyChanged();
        }
    }

    public bool IsFifthBottleCollected
    {
        get => SettingsStore.Instance.Settings.QuestItemsPageSettings.IsFifthBottleCollected;
        set
        {
            SettingsStore.Instance.Settings.QuestItemsPageSettings.IsFifthBottleCollected = value;
            NotifyPropertyChanged();
        }
    }

    public bool IsSixthBottleCollected
    {
        get => SettingsStore.Instance.Settings.QuestItemsPageSettings.IsSixthBottleCollected;
        set
        {
            SettingsStore.Instance.Settings.QuestItemsPageSettings.IsSixthBottleCollected = value;
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


    public SolidColorBrush ForegroundBrush => SettingsStore.Instance.ApplicationSettings.ForegroundBrush;


    public QuestItemPageViewmodel()
    {
        InitializeCommands();

        SettingsStore.Instance.Settings.QuestStatusPageSettings.OnCollectedQuiverChanged += () =>
        {
            NotifyPropertyChanged(nameof(IsHeroBowCollected));
        };

        SettingsStore.Instance.Settings.QuestStatusPageSettings.OnCollectedBombBagChanged += () =>
        {
            NotifyPropertyChanged(nameof(IsBombBagCollected));
        };

        SettingsStore.Instance.ApplicationSettings.OnForegroundColorChanged +=
            () => NotifyPropertyChanged(nameof(ForegroundBrush));
    }


    private void InitializeCommands()
    {
        CollectOcarinaCommand = new BaseCommand((o) => IsOcarinaOfTimeCollected = true);
        UnCollectOcarinaCommand = new BaseCommand((o) => IsOcarinaOfTimeCollected = false);

        CollectBowCommand = new BaseCommand((o) =>
            SettingsStore.Instance.Settings.QuestStatusPageSettings.CollectedQuiver++);
        UnCollectBowCommand = new BaseCommand((o) =>
            SettingsStore.Instance.Settings.QuestStatusPageSettings.CollectedQuiver--);

        CollectFireArrowCommand = new BaseCommand((o) => IsFireArrowCollected = true);
        UnCollectFireArrowCommand = new BaseCommand((o) => IsFireArrowCollected = false);

        CollectIceArrowCommand = new BaseCommand((o) => IsIceArrowCollected = true);
        UnCollectIceArrowCommand = new BaseCommand((o) => IsIceArrowCollected = false);

        CollectLightArrowCommand = new BaseCommand((o) => IsLightArrowCollected = true);
        UnCollectLightArrowCommand = new BaseCommand((o) => IsLightArrowCollected = false);

        CollectRoomKeyCommand = new BaseCommand((o) => IsRoomKeyCollected = true);
        UnCollectRoomKeyCommand = new BaseCommand((o) => IsRoomKeyCollected = false);

        CollectBombBagCommand = new BaseCommand((o) =>
            SettingsStore.Instance.Settings.QuestStatusPageSettings.CollectedBombBag++);
        UnCollectBombBagCommand = new BaseCommand((o) =>
            SettingsStore.Instance.Settings.QuestStatusPageSettings.CollectedBombBag--);

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