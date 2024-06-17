using MajorasMaskTracker.Store;
using WPFBase.Utils;

namespace MajorasMaskTracker.Viewmodel.InventoryViewmodel;

public class MaskPageViewmodel : BaseViewModel
{
    #region Properties
    
    #region First row
    
    public bool IsPostmanHatCollected
    {
        get => SettingsStore.Instance.SettingsModel.MasksPageSettings.IsPostmanHatCollected;
        set
        {
            SettingsStore.Instance.SettingsModel.MasksPageSettings.IsPostmanHatCollected = value;
            NotifyPropertyChanged();
        }
    }
    
    public bool IsAllNightMaskCollected
    {
        get => SettingsStore.Instance.SettingsModel.MasksPageSettings.IsAllNightMaskCollected;
        set
        {
            SettingsStore.Instance.SettingsModel.MasksPageSettings.IsAllNightMaskCollected = value;
            NotifyPropertyChanged();
        }
    }
    
    public bool IsBlastMaskCollected
    {
        get => SettingsStore.Instance.SettingsModel.MasksPageSettings.IsBlastMaskCollected;
        set
        {
            SettingsStore.Instance.SettingsModel.MasksPageSettings.IsBlastMaskCollected = value;
            NotifyPropertyChanged();
        }
    }
    
    public bool IsStoneMaskCollected
    {
        get => SettingsStore.Instance.SettingsModel.MasksPageSettings.IsStoneMaskCollected;
        set
        {
            SettingsStore.Instance.SettingsModel.MasksPageSettings.IsStoneMaskCollected = value;
            NotifyPropertyChanged();
        }
    }
    
    public bool IsGreatFairyMaskCollected
    {
        get => SettingsStore.Instance.SettingsModel.MasksPageSettings.IsGreatFairyMaskCollected;
        set
        {
            SettingsStore.Instance.SettingsModel.MasksPageSettings.IsGreatFairyMaskCollected = value;
            NotifyPropertyChanged();
        }
    }
    
    public bool IsDekuMaskCollected
    {
        get => SettingsStore.Instance.SettingsModel.MasksPageSettings.IsDekuMaskCollected;
        set
        {
            SettingsStore.Instance.SettingsModel.MasksPageSettings.IsDekuMaskCollected = value;
            NotifyPropertyChanged();
        }
    }
    
    #endregion
    
    
    #region Second row
    
    public bool IsKeatonMaskCollected
    {
        get => SettingsStore.Instance.SettingsModel.MasksPageSettings.IsKeatonMaskCollected;
        set
        {
            SettingsStore.Instance.SettingsModel.MasksPageSettings.IsKeatonMaskCollected = value;
            NotifyPropertyChanged();
        }
    }
    
    public bool IsBremenMaskCollected
    {
        get => SettingsStore.Instance.SettingsModel.MasksPageSettings.IsBremenMaskCollected;
        set
        {
            SettingsStore.Instance.SettingsModel.MasksPageSettings.IsBremenMaskCollected = value;
            NotifyPropertyChanged();
        }
    }
    
    public bool IsBunnyHoodCollected
    {
        get => SettingsStore.Instance.SettingsModel.MasksPageSettings.IsBunnyHoodCollected;
        set
        {
            SettingsStore.Instance.SettingsModel.MasksPageSettings.IsBunnyHoodCollected = value;
            NotifyPropertyChanged();
        }
    }
    
    public bool IsDonGeroMaskCollected
    {
        get => SettingsStore.Instance.SettingsModel.MasksPageSettings.IsDonGeroMaskCollected;
        set
        {
            SettingsStore.Instance.SettingsModel.MasksPageSettings.IsDonGeroMaskCollected = value;
            NotifyPropertyChanged();
        }
    }
    
    public bool IsMaskOfScentsCollected
    {
        get => SettingsStore.Instance.SettingsModel.MasksPageSettings.IsMaskOfScentsCollected;
        set
        {
            SettingsStore.Instance.SettingsModel.MasksPageSettings.IsMaskOfScentsCollected = value;
            NotifyPropertyChanged();
        }
    }
    
    public bool IsGoronMaskCollected
    {
        get => SettingsStore.Instance.SettingsModel.MasksPageSettings.IsGoronMaskCollected;
        set
        {
            SettingsStore.Instance.SettingsModel.MasksPageSettings.IsGoronMaskCollected = value;
            NotifyPropertyChanged();
        }
    }
    
    #endregion
    
    
    #region Third row
    
    public bool IsRomaniMaskCollected
    {
        get => SettingsStore.Instance.SettingsModel.MasksPageSettings.IsRomaniMaskCollected;
        set
        {
            SettingsStore.Instance.SettingsModel.MasksPageSettings.IsRomaniMaskCollected = value;
            NotifyPropertyChanged();
        }
    }
    
    public bool IsCircusLeadersMaskCollected
    {
        get => SettingsStore.Instance.SettingsModel.MasksPageSettings.IsCircusLeadersMaskCollected;
        set
        {
            SettingsStore.Instance.SettingsModel.MasksPageSettings.IsCircusLeadersMaskCollected = value;
            NotifyPropertyChanged();
        }
    }
    
    public bool IsKafeisMaskCollected
    {
        get => SettingsStore.Instance.SettingsModel.MasksPageSettings.IsKafeisMaskCollected;
        set
        {
            SettingsStore.Instance.SettingsModel.MasksPageSettings.IsKafeisMaskCollected = value;
            NotifyPropertyChanged();
        }
    }
    
    public bool IsCoupleMaskCollected
    {
        get => SettingsStore.Instance.SettingsModel.MasksPageSettings.IsCoupleMaskCollected;
        set
        {
            SettingsStore.Instance.SettingsModel.MasksPageSettings.IsCoupleMaskCollected = value;
            NotifyPropertyChanged();
        }
    }
    
    public bool IsMaskOfTruthCollected
    {
        get => SettingsStore.Instance.SettingsModel.MasksPageSettings.IsMaskOfTruthCollected;
        set
        {
            SettingsStore.Instance.SettingsModel.MasksPageSettings.IsMaskOfTruthCollected = value;
            NotifyPropertyChanged();
        }
    }
    
    public bool IsZoraMaskCollected
    {
        get => SettingsStore.Instance.SettingsModel.MasksPageSettings.IsZoraMaskCollected;
        set
        {
            SettingsStore.Instance.SettingsModel.MasksPageSettings.IsZoraMaskCollected = value;
            NotifyPropertyChanged();
        }
    }
    
    #endregion
    
    
    #region Fourth row
    
    public bool IsKamaroMaskCollected
    {
        get => SettingsStore.Instance.SettingsModel.MasksPageSettings.IsKamaroMaskCollected;
        set
        {
            SettingsStore.Instance.SettingsModel.MasksPageSettings.IsKamaroMaskCollected = value;
            NotifyPropertyChanged();
        }
    }
    
    public bool IsGibdoMaskCollected
    {
        get => SettingsStore.Instance.SettingsModel.MasksPageSettings.IsGibdoMaskCollected;
        set
        {
            SettingsStore.Instance.SettingsModel.MasksPageSettings.IsGibdoMaskCollected = value;
            NotifyPropertyChanged();
        }
    }
    
    public bool IsGaroMaskCollected
    {
        get => SettingsStore.Instance.SettingsModel.MasksPageSettings.IsGaroMaskCollected;
        set
        {
            SettingsStore.Instance.SettingsModel.MasksPageSettings.IsGaroMaskCollected = value;
            NotifyPropertyChanged();
        }
    }
    
    public bool IsCaptainHatCollected
    {
        get => SettingsStore.Instance.SettingsModel.MasksPageSettings.IsCaptainHatCollected;
        set
        {
            SettingsStore.Instance.SettingsModel.MasksPageSettings.IsCaptainHatCollected = value;
            NotifyPropertyChanged();
        }
    }
    
    public bool IsGiantMaskCollected
    {
        get => SettingsStore.Instance.SettingsModel.MasksPageSettings.IsGiantMaskCollected;
        set
        {
            SettingsStore.Instance.SettingsModel.MasksPageSettings.IsGiantMaskCollected = value;
            NotifyPropertyChanged();
        }
    }
    
    public bool IsFierceDeityMaskCollected
    {
        get => SettingsStore.Instance.SettingsModel.MasksPageSettings.IsFierceDeityMaskCollected;
        set
        {
            SettingsStore.Instance.SettingsModel.MasksPageSettings.IsFierceDeityMaskCollected = value;
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