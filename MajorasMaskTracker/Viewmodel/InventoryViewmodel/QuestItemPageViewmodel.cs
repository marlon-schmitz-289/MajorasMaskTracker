using MajorasMaskTracker.Util;
using WPFBase.Utils;

namespace MajorasMaskTracker.Viewmodel.InventoryViewmodel;

public class QuestItemPageViewmodel : BaseViewModel
{
    private bool _isOcarinaCollected;
    public bool IsOcarinaCollected
    {
        get => _isOcarinaCollected;
        set
        {
            _isOcarinaCollected = value;
            NotifyPropertyChanged();
        }
    }
    
    private bool _isBowCollected;
    public bool IsBowCollected
    {
        get => _isBowCollected;
        set
        {
            _isBowCollected = value;
            NotifyPropertyChanged();
        }
    }
    
    private bool _isFireArrowCollected;
    public bool IsFireArrowCollected
    {
        get => _isFireArrowCollected;
        set
        {
            _isFireArrowCollected = value;
            NotifyPropertyChanged();
        }
    }
    
    private bool _isIceArrowCollected;
    public bool IsIceArrowCollected
    {
        get => _isIceArrowCollected;
        set
        {
            _isIceArrowCollected = value;
            NotifyPropertyChanged();
        }
    }
    
    private bool _isLightArrowCollected;
    public bool IsLightArrowCollected
    {
        get => _isLightArrowCollected;
        set
        {
            _isLightArrowCollected = value;
            NotifyPropertyChanged();
        }
    }
    
    private bool _isRoomKeyCollected;
    public bool IsRoomKeyCollected
    {
        get => _isRoomKeyCollected;
        set
        {
            _isRoomKeyCollected = value;
            NotifyPropertyChanged();
        }
    }
    
    private bool _isBombBagCollected;
    public bool IsBombBagCollected
    {
        get => _isBombBagCollected;
        set
        {
            _isBombBagCollected = value;
            NotifyPropertyChanged();
        }
    }
    
    private bool _isBombChusCollected;
    public bool IsBombChusCollected
    {
        get => _isBombChusCollected;
        set
        {
            _isBombChusCollected = value;
            NotifyPropertyChanged();
        }
    }
    
    private bool _isDekuStickCollected;
    public bool IsDekuStickCollected
    {
        get => _isDekuStickCollected;
        set
        {
            _isDekuStickCollected = value;
            NotifyPropertyChanged();
        }
    }
    
    private bool _isDekuNutCollected;
    public bool IsDekuNutCollected
    {
        get => _isDekuNutCollected;
        set
        {
            _isDekuNutCollected = value;
            NotifyPropertyChanged();
        }
    }
    
    private bool _isMagicBeanCollected;
    public bool IsMagicBeanCollected
    {
        get => _isMagicBeanCollected;
        set
        {
            _isMagicBeanCollected = value;
            NotifyPropertyChanged();
        }
    }
    
    private CollectedScrubTradeItem _scrubTradeItem;
    public CollectedScrubTradeItem ScrubTradeItem
    {
        get => _scrubTradeItem;
        set
        {
            if (value < 0 || value > CollectedScrubTradeItem.OceanTitleDeed) return;
            
            _scrubTradeItem = value;
            NotifyPropertyChanged();
            NotifyPropertyChanged(nameof(IsScrubTradeItemCollected));
            NotifyPropertyChanged(nameof(IsMoonsTearCollected));
            NotifyPropertyChanged(nameof(IsLandTitleDeedCollected));
            NotifyPropertyChanged(nameof(IsSwampTitleDeedCollected));
            NotifyPropertyChanged(nameof(IsMountainTitleDeedCollected));
            NotifyPropertyChanged(nameof(IsOceanTitleDeedCollected));
        }
    }
    
    public bool IsScrubTradeItemCollected => ScrubTradeItem != CollectedScrubTradeItem.None;
    public bool IsMoonsTearCollected => ScrubTradeItem == CollectedScrubTradeItem.MoonsTear;
    public bool IsLandTitleDeedCollected => ScrubTradeItem == CollectedScrubTradeItem.LandTitleDeed;
    public bool IsSwampTitleDeedCollected => ScrubTradeItem == CollectedScrubTradeItem.SwampTitleDeed;
    public bool IsMountainTitleDeedCollected => ScrubTradeItem == CollectedScrubTradeItem.MountainTitleDeed;
    public bool IsOceanTitleDeedCollected => ScrubTradeItem == CollectedScrubTradeItem.OceanTitleDeed;
    
    
    private bool _isPowderKegCollected;
    public bool IsPowderKegCollected
    {
        get => _isPowderKegCollected;
        set
        {
            _isPowderKegCollected = value;
            NotifyPropertyChanged();
        }
    }
    
    private bool _isPictoBoxCollected;
    public bool IsPictoBoxCollected
    {
        get => _isPictoBoxCollected;
        set
        {
            _isPictoBoxCollected = value;
            NotifyPropertyChanged();
        }
    }
    
    private bool _isLensOfTruthCollected;
    public bool IsLensOfTruthCollected
    {
        get => _isLensOfTruthCollected;
        set
        {
            _isLensOfTruthCollected = value;
            NotifyPropertyChanged();
        }
    }
    
    private bool _isHookshotCollected;
    public bool IsHookshotCollected
    {
        get => _isHookshotCollected;
        set
        {
            _isHookshotCollected = value;
            NotifyPropertyChanged();
        }
    }
    
    private bool _isGreatFairySwordCollected;
    public bool IsGreatFairySwordCollected
    {
        get => _isGreatFairySwordCollected;
        set
        {
            _isGreatFairySwordCollected = value;
            NotifyPropertyChanged();
        }
    }
    
    private CollectedKafeiItem _kafeiItem;
    public CollectedKafeiItem KafeiItem
    {
        get => _kafeiItem;
        set
        {
            if (value < 0 || value > CollectedKafeiItem.ExpressMailToMama) return;
            
            _kafeiItem = value;
            NotifyPropertyChanged();
            NotifyPropertyChanged(nameof(IsKafeiItemCollected));
            NotifyPropertyChanged(nameof(IsPendantOfMemoriesCollected));
            NotifyPropertyChanged(nameof(IsLetterToKafeiCollected));
            NotifyPropertyChanged(nameof(IsExpressMailToMamaCollected));
        }
    }
    
    public bool IsKafeiItemCollected => KafeiItem != CollectedKafeiItem.None;
    public bool IsPendantOfMemoriesCollected => KafeiItem == CollectedKafeiItem.PendantOfMemories;
    public bool IsLetterToKafeiCollected => KafeiItem == CollectedKafeiItem.LetterToKafei;
    public bool IsExpressMailToMamaCollected => KafeiItem == CollectedKafeiItem.ExpressMailToMama;
    
    
    
    private bool _isFirstBottleCollected;
    public bool IsFirstBottleCollected
    {
        get => _isFirstBottleCollected;
        set
        {
            _isFirstBottleCollected = value;
            NotifyPropertyChanged();
        }
    }
    
    private bool _isSecondBottleCollected;
    public bool IsSecondBottleCollected
    {
        get => _isSecondBottleCollected;
        set
        {
            _isSecondBottleCollected = value;
            NotifyPropertyChanged();
        }
    }
    
    private bool _isThirdBottleCollected;
    public bool IsThirdBottleCollected
    {
        get => _isThirdBottleCollected;
        set
        {
            _isThirdBottleCollected = value;
            NotifyPropertyChanged();
        }
    }
    
    private bool _isFourthBottleCollected;
    public bool IsFourthBottleCollected
    {
        get => _isFourthBottleCollected;
        set
        {
            _isFourthBottleCollected = value;
            NotifyPropertyChanged();
        }
    }
    
    private bool _isFifthBottleCollected;
    public bool IsFifthBottleCollected
    {
        get => _isFifthBottleCollected;
        set
        {
            _isFifthBottleCollected = value;
            NotifyPropertyChanged();
        }
    }
    
    private bool _isSixthBottleCollected;
    public bool IsSixthBottleCollected
    {
        get => _isSixthBottleCollected;
        set
        {
            _isSixthBottleCollected = value;
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
        CollectOcarinaCommand = new BaseCommand((o) => IsOcarinaCollected = true);
        UnCollectOcarinaCommand = new BaseCommand((o) => IsOcarinaCollected = false);

        CollectBowCommand = new BaseCommand((o) => IsBowCollected = true);
        UnCollectBowCommand = new BaseCommand((o) => IsBowCollected = false);

        CollectFireArrowCommand = new BaseCommand((o) => IsFireArrowCollected = true);
        UnCollectFireArrowCommand = new BaseCommand((o) => IsFireArrowCollected = false);

        CollectIceArrowCommand = new BaseCommand((o) => IsIceArrowCollected = true);
        UnCollectIceArrowCommand = new BaseCommand((o) => IsIceArrowCollected = false);
        
        CollectLightArrowCommand = new BaseCommand((o) => IsLightArrowCollected = true);
        UnCollectLightArrowCommand = new BaseCommand((o) => IsLightArrowCollected = false);
        
        CollectRoomKeyCommand = new BaseCommand((o) => IsRoomKeyCollected = true);
        UnCollectRoomKeyCommand = new BaseCommand((o) => IsRoomKeyCollected = false);
        
        CollectBombBagCommand = new BaseCommand((o) => IsBombBagCollected = true);
        UnCollectBombBagCommand = new BaseCommand((o) => IsBombBagCollected = false);
        
        CollectBombChusCommand = new BaseCommand((o) => IsBombChusCollected = true);
        UnCollectBombChusCommand = new BaseCommand((o) => IsBombChusCollected = false);
        
        CollectDekuStickCommand = new BaseCommand((o) => IsDekuStickCollected = true);
        UnCollectDekuStickCommand = new BaseCommand((o) => IsDekuStickCollected = false);
        
        CollectDekuNutCommand = new BaseCommand((o) => IsDekuNutCollected = true);
        UnCollectDekuNutCommand = new BaseCommand((o) => IsDekuNutCollected = false);
        
        CollectMagicBeanCommand = new BaseCommand((o) => IsMagicBeanCollected = true);
        UnCollectMagicBeanCommand = new BaseCommand((o) => IsMagicBeanCollected = false);
        
        CollectScrubTradeItemCommand = new BaseCommand((o) => ScrubTradeItem++);
        UnCollectScrubTradeItemCommand = new BaseCommand((o) => ScrubTradeItem--);
        
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
        
        CollectKafeiItemCommand = new BaseCommand((o) => KafeiItem++);
        UnCollectKafeiItemCommand = new BaseCommand((o) => KafeiItem--);
        
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