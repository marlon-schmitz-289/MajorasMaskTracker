using WPFBase.Utils;

namespace MajorasMaskTracker.Viewmodel.InventoryViewmodel;

public class MaskPageViewmodel : BaseViewModel
{
    #region Properties
    
    #region First row
    
    private bool _isPostmanHatCollected = false;
    public bool IsPostmanHatCollected
    {
        get => _isPostmanHatCollected;
        set
        {
            _isPostmanHatCollected = value;
            NotifyPropertyChanged();
        }
    }
    
    private bool _isAllNightMaskCollected = false;
    public bool IsAllNightMaskCollected
    {
        get => _isAllNightMaskCollected;
        set
        {
            _isAllNightMaskCollected = value;
            NotifyPropertyChanged();
        }
    }
    
    private bool _isBlastMaskCollected = false;
    public bool IsBlastMaskCollected
    {
        get => _isBlastMaskCollected;
        set
        {
            _isBlastMaskCollected = value;
            NotifyPropertyChanged();
        }
    }
    
    private bool _isStoneMaskCollected = false;
    public bool IsStoneMaskCollected
    {
        get => _isStoneMaskCollected;
        set
        {
            _isStoneMaskCollected = value;
            NotifyPropertyChanged();
        }
    }
    
    private bool _isGreatFairyMaskCollected = false;
    public bool IsGreatFairyMaskCollected
    {
        get => _isGreatFairyMaskCollected;
        set
        {
            _isGreatFairyMaskCollected = value;
            NotifyPropertyChanged();
        }
    }
    
    private bool _isDekuMaskCollected = false;
    public bool IsDekuMaskCollected
    {
        get => _isDekuMaskCollected;
        set
        {
            _isDekuMaskCollected = value;
            NotifyPropertyChanged();
        }
    }
    
    #endregion
    
    
    #region Second row
    
    private bool _isKeatonMaskCollected = false;
    public bool IsKeatonMaskCollected
    {
        get => _isKeatonMaskCollected;
        set
        {
            _isKeatonMaskCollected = value;
            NotifyPropertyChanged();
        }
    }
    
    private bool _isBremenMaskCollected = false;
    public bool IsBremenMaskCollected
    {
        get => _isBremenMaskCollected;
        set
        {
            _isBremenMaskCollected = value;
            NotifyPropertyChanged();
        }
    }
    
    private bool _isBunnyHoodCollected = false;
    public bool IsBunnyHoodCollected
    {
        get => _isBunnyHoodCollected;
        set
        {
            _isBunnyHoodCollected = value;
            NotifyPropertyChanged();
        }
    }
    
    private bool _isDonGeroMaskCollected = false;
    public bool IsDonGeroMaskCollected
    {
        get => _isDonGeroMaskCollected;
        set
        {
            _isDonGeroMaskCollected = value;
            NotifyPropertyChanged();
        }
    }
    
    private bool _isMaskOfScentsCollected = false;
    public bool IsMaskOfScentsCollected
    {
        get => _isMaskOfScentsCollected;
        set
        {
            _isMaskOfScentsCollected = value;
            NotifyPropertyChanged();
        }
    }
    
    private bool _isGoronMaskCollected = false;
    public bool IsGoronMaskCollected
    {
        get => _isGoronMaskCollected;
        set
        {
            _isGoronMaskCollected = value;
            NotifyPropertyChanged();
        }
    }
    
    #endregion
    
    
    #region Third row
    
    private bool _isRomaniMaskCollected = false;
    public bool IsRomaniMaskCollected
    {
        get => _isRomaniMaskCollected;
        set
        {
            _isRomaniMaskCollected = value;
            NotifyPropertyChanged();
        }
    }
    
    private bool _isCircusLeadersMaskCollected = false;
    public bool IsCircusLeadersMaskCollected
    {
        get => _isCircusLeadersMaskCollected;
        set
        {
            _isCircusLeadersMaskCollected = value;
            NotifyPropertyChanged();
        }
    }
    
    private bool _isKafeisMaskCollected = false;
    public bool IsKafeisMaskCollected
    {
        get => _isKafeisMaskCollected;
        set
        {
            _isKafeisMaskCollected = value;
            NotifyPropertyChanged();
        }
    }
    
    private bool _isCoupleMaskCollected = false;
    public bool IsCoupleMaskCollected
    {
        get => _isCoupleMaskCollected;
        set
        {
            _isCoupleMaskCollected = value;
            NotifyPropertyChanged();
        }
    }
    
    private bool _isMaskOfTruthCollected = false;
    public bool IsMaskOfTruthCollected
    {
        get => _isMaskOfTruthCollected;
        set
        {
            _isMaskOfTruthCollected = value;
            NotifyPropertyChanged();
        }
    }
    
    private bool _isZoraMaskCollected = false;
    public bool IsZoraMaskCollected
    {
        get => _isZoraMaskCollected;
        set
        {
            _isZoraMaskCollected = value;
            NotifyPropertyChanged();
        }
    }
    
    #endregion
    
    
    #region Fourth row
    
    private bool _isKamaroMaskCollected = false;
    public bool IsKamaroMaskCollected
    {
        get => _isKamaroMaskCollected;
        set
        {
            _isKamaroMaskCollected = value;
            NotifyPropertyChanged();
        }
    }
    
    private bool _isGibdoMaskCollected = false;
    public bool IsGibdoMaskCollected
    {
        get => _isGibdoMaskCollected;
        set
        {
            _isGibdoMaskCollected = value;
            NotifyPropertyChanged();
        }
    }
    
    private bool _isGaroMaskCollected = false;
    public bool IsGaroMaskCollected
    {
        get => _isGaroMaskCollected;
        set
        {
            _isGaroMaskCollected = value;
            NotifyPropertyChanged();
        }
    }
    
    private bool _isCaptainHatCollected = false;
    public bool IsCaptainHatCollected
    {
        get => _isCaptainHatCollected;
        set
        {
            _isCaptainHatCollected = value;
            NotifyPropertyChanged();
        }
    }
    
    private bool _isGiantMaskCollected = false;
    public bool IsGiantMaskCollected
    {
        get => _isGiantMaskCollected;
        set
        {
            _isGiantMaskCollected = value;
            NotifyPropertyChanged();
        }
    }
    
    private bool _isFierceDeityMaskCollected = false;
    public bool IsFierceDeityMaskCollected
    {
        get => _isFierceDeityMaskCollected;
        set
        {
            _isFierceDeityMaskCollected = value;
            NotifyPropertyChanged();
        }
    }
    
    #endregion
    
    #endregion
    
    
    #region Commands
    
    public BaseCommand CollectPostmanHatCommand { get; }
    public BaseCommand UncollectPostmanHatCommand { get; }
    
    public BaseCommand CollectAllNightMaskCommand { get; }
    public BaseCommand UncollectAllNightMaskCommand { get; }
    
    public BaseCommand CollectBlastMaskCommand { get; }
    public BaseCommand UncollectBlastMaskCommand { get; }
    
    public BaseCommand CollectStoneMaskCommand { get; }
    public BaseCommand UncollectStoneMaskCommand { get; }
    
    public BaseCommand CollectGreatFairyMaskCommand { get; }
    public BaseCommand UncollectGreatFairyMaskCommand { get; }
    
    public BaseCommand CollectDekuMaskCommand { get; }
    public BaseCommand UncollectDekuMaskCommand { get; }
    
    
    public BaseCommand CollectKeatonMaskCommand { get; }
    public BaseCommand UncollectKeatonMaskCommand { get; }
    
    public BaseCommand CollectBremenMaskCommand { get; }
    public BaseCommand UncollectBremenMaskCommand { get; }
    
    public BaseCommand CollectBunnyHoodCommand { get; }
    public BaseCommand UncollectBunnyHoodCommand { get; }
    
    public BaseCommand CollectDonGeroMaskCommand { get; }
    public BaseCommand UncollectDonGeroMaskCommand { get; }
    
    public BaseCommand CollectMaskOfScentsCommand { get; }
    public BaseCommand UncollectMaskOfScentsCommand { get; }
    
    public BaseCommand CollectGoronMaskCommand { get; }
    public BaseCommand UncollectGoronMaskCommand { get; }
    
    
    public BaseCommand CollectRomaniMaskCommand { get; }
    public BaseCommand UncollectRomaniMaskCommand { get; }
    
    public BaseCommand CollectCircusLeadersMaskCommand { get; }
    public BaseCommand UncollectCircusLeadersMaskCommand { get; }
    
    public BaseCommand CollectKafeisMaskCommand { get; }
    public BaseCommand UncollectKafeisMaskCommand { get; }
    
    public BaseCommand CollectCoupleMaskCommand { get; }
    public BaseCommand UncollectCoupleMaskCommand { get; }
    
    public BaseCommand CollectMaskOfTruthCommand { get; }
    public BaseCommand UncollectMaskOfTruthCommand { get; }
    
    public BaseCommand CollectZoraMaskCommand { get; }
    public BaseCommand UncollectZoraMaskCommand { get; }
    
    
    public BaseCommand CollectKamaroMaskCommand { get; }
    public BaseCommand UncollectKamaroMaskCommand { get; }
    
    public BaseCommand CollectGibdoMaskCommand { get; }
    public BaseCommand UncollectGibdoMaskCommand { get; }
    
    public BaseCommand CollectGaroMaskCommand { get; }
    public BaseCommand UncollectGaroMaskCommand { get; }
    
    public BaseCommand CollectCaptainHatCommand { get; }
    public BaseCommand UncollectCaptainHatCommand { get; }
    
    public BaseCommand CollectGiantMaskCommand { get; }
    public BaseCommand UncollectGiantMaskCommand { get; }
    
    public BaseCommand CollectFierceDeityMaskCommand { get; }
    public BaseCommand UncollectFierceDeityMaskCommand { get; }
    
    #endregion


    public MaskPageViewmodel()
    {
        CollectPostmanHatCommand = new BaseCommand((sender) => IsPostmanHatCollected = true);
        UncollectPostmanHatCommand = new BaseCommand((sender) => IsPostmanHatCollected = false);
        
        CollectAllNightMaskCommand = new BaseCommand((sender) => IsAllNightMaskCollected = true);
        UncollectAllNightMaskCommand = new BaseCommand((sender) => IsAllNightMaskCollected = false);
        
        CollectBlastMaskCommand = new BaseCommand((sender) => IsBlastMaskCollected = true);
        UncollectBlastMaskCommand = new BaseCommand((sender) => IsBlastMaskCollected = false);
        
        CollectStoneMaskCommand = new BaseCommand((sender) => IsStoneMaskCollected = true);
        UncollectStoneMaskCommand = new BaseCommand((sender) => IsStoneMaskCollected = false);
        
        CollectGreatFairyMaskCommand = new BaseCommand((sender) => IsGreatFairyMaskCollected = true);
        UncollectGreatFairyMaskCommand = new BaseCommand((sender) => IsGreatFairyMaskCollected = false);
        
        CollectDekuMaskCommand = new BaseCommand((sender) => IsDekuMaskCollected = true);
        UncollectDekuMaskCommand = new BaseCommand((sender) => IsDekuMaskCollected = false);
        
        
        CollectKeatonMaskCommand = new BaseCommand((sender) => IsKeatonMaskCollected = true);
        UncollectKeatonMaskCommand = new BaseCommand((sender) => IsKeatonMaskCollected = false);
        
        CollectBremenMaskCommand = new BaseCommand((sender) => IsBremenMaskCollected = true);
        UncollectBremenMaskCommand = new BaseCommand((sender) => IsBremenMaskCollected = false);
        
        CollectBunnyHoodCommand = new BaseCommand((sender) => IsBunnyHoodCollected = true);
        UncollectBunnyHoodCommand = new BaseCommand((sender) => IsBunnyHoodCollected = false);
        
        CollectDonGeroMaskCommand = new BaseCommand((sender) => IsDonGeroMaskCollected = true);
        UncollectDonGeroMaskCommand = new BaseCommand((sender) => IsDonGeroMaskCollected = false);
        
        CollectMaskOfScentsCommand = new BaseCommand((sender) => IsMaskOfScentsCollected = true);
        UncollectMaskOfScentsCommand = new BaseCommand((sender) => IsMaskOfScentsCollected = false);
        
        CollectGoronMaskCommand = new BaseCommand((sender) => IsGoronMaskCollected = true);
        UncollectGoronMaskCommand = new BaseCommand((sender) => IsGoronMaskCollected = false);
        
        
        CollectRomaniMaskCommand = new BaseCommand((sender) => IsRomaniMaskCollected = true);
        UncollectRomaniMaskCommand = new BaseCommand((sender) => IsRomaniMaskCollected = false);
        
        CollectCircusLeadersMaskCommand = new BaseCommand((sender) => IsCircusLeadersMaskCollected = true);
        UncollectCircusLeadersMaskCommand = new BaseCommand((sender) => IsCircusLeadersMaskCollected = false);
        
        CollectKafeisMaskCommand = new BaseCommand((sender) => IsKafeisMaskCollected = true);
        UncollectKafeisMaskCommand = new BaseCommand((sender) => IsKafeisMaskCollected = false);
        
        CollectCoupleMaskCommand = new BaseCommand((sender) => IsCoupleMaskCollected = true);
        UncollectCoupleMaskCommand = new BaseCommand((sender) => IsCoupleMaskCollected = false);
        
        CollectMaskOfTruthCommand = new BaseCommand((sender) => IsMaskOfTruthCollected = true);
        UncollectMaskOfTruthCommand = new BaseCommand((sender) => IsMaskOfTruthCollected = false);
        
        CollectZoraMaskCommand = new BaseCommand((sender) => IsZoraMaskCollected = true);
        UncollectZoraMaskCommand = new BaseCommand((sender) => IsZoraMaskCollected = false);
        
        
        CollectKamaroMaskCommand = new BaseCommand((sender) => IsKamaroMaskCollected = true);
        UncollectKamaroMaskCommand = new BaseCommand((sender) => IsKamaroMaskCollected = false);
        
        CollectGibdoMaskCommand = new BaseCommand((sender) => IsGibdoMaskCollected = true);
        UncollectGibdoMaskCommand = new BaseCommand((sender) => IsGibdoMaskCollected = false);
        
        CollectGaroMaskCommand = new BaseCommand((sender) => IsGaroMaskCollected = true);
        UncollectGaroMaskCommand = new BaseCommand((sender) => IsGaroMaskCollected = false);
        
        CollectCaptainHatCommand = new BaseCommand((sender) => IsCaptainHatCollected = true);
        UncollectCaptainHatCommand = new BaseCommand((sender) => IsCaptainHatCollected = false);
        
        CollectGiantMaskCommand = new BaseCommand((sender) => IsGiantMaskCollected = true);
        UncollectGiantMaskCommand = new BaseCommand((sender) => IsGiantMaskCollected = false);
        
        CollectFierceDeityMaskCommand = new BaseCommand((sender) => IsFierceDeityMaskCollected = true);
        UncollectFierceDeityMaskCommand = new BaseCommand((sender) => IsFierceDeityMaskCollected = false);
    }
}