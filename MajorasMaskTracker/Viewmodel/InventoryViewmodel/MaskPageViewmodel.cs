using System.Windows.Media;
using MajorasMaskTracker.Store;
using WPFBase.Utils;

namespace MajorasMaskTracker.Viewmodel.InventoryViewmodel;

public class MaskPageViewmodel : BaseViewmodel
{
    public MaskPageViewmodel()
    {
        InitializeCommands();

        SettingsStore.Instance.ApplicationSettings.OnForegroundColorChanged +=
            () => NotifyPropertyChanged(nameof(ForegroundBrush));
    }


    public SolidColorBrush ForegroundBrush => SettingsStore.Instance.ApplicationSettings.ForegroundBrush;


    private void InitializeCommands()
    {
        CollectPostmanHatCommand = new BaseCommand(sender => IsPostmanHatCollected = true);
        UncollectPostmanHatCommand = new BaseCommand(sender => IsPostmanHatCollected = false);

        CollectAllNightMaskCommand = new BaseCommand(sender => IsAllNightMaskCollected = true);
        UncollectAllNightMaskCommand = new BaseCommand(sender => IsAllNightMaskCollected = false);

        CollectBlastMaskCommand = new BaseCommand(sender => IsBlastMaskCollected = true);
        UncollectBlastMaskCommand = new BaseCommand(sender => IsBlastMaskCollected = false);

        CollectStoneMaskCommand = new BaseCommand(sender => IsStoneMaskCollected = true);
        UncollectStoneMaskCommand = new BaseCommand(sender => IsStoneMaskCollected = false);

        CollectGreatFairyMaskCommand = new BaseCommand(sender => IsGreatFairyMaskCollected = true);
        UncollectGreatFairyMaskCommand = new BaseCommand(sender => IsGreatFairyMaskCollected = false);

        CollectDekuMaskCommand = new BaseCommand(sender => IsDekuMaskCollected = true);
        UncollectDekuMaskCommand = new BaseCommand(sender => IsDekuMaskCollected = false);


        CollectKeatonMaskCommand = new BaseCommand(sender => IsKeatonMaskCollected = true);
        UncollectKeatonMaskCommand = new BaseCommand(sender => IsKeatonMaskCollected = false);

        CollectBremenMaskCommand = new BaseCommand(sender => IsBremenMaskCollected = true);
        UncollectBremenMaskCommand = new BaseCommand(sender => IsBremenMaskCollected = false);

        CollectBunnyHoodCommand = new BaseCommand(sender => IsBunnyHoodCollected = true);
        UncollectBunnyHoodCommand = new BaseCommand(sender => IsBunnyHoodCollected = false);

        CollectDonGeroMaskCommand = new BaseCommand(sender => IsDonGeroMaskCollected = true);
        UncollectDonGeroMaskCommand = new BaseCommand(sender => IsDonGeroMaskCollected = false);

        CollectMaskOfScentsCommand = new BaseCommand(sender => IsMaskOfScentsCollected = true);
        UncollectMaskOfScentsCommand = new BaseCommand(sender => IsMaskOfScentsCollected = false);

        CollectGoronMaskCommand = new BaseCommand(sender => IsGoronMaskCollected = true);
        UncollectGoronMaskCommand = new BaseCommand(sender => IsGoronMaskCollected = false);


        CollectRomaniMaskCommand = new BaseCommand(sender => IsRomaniMaskCollected = true);
        UncollectRomaniMaskCommand = new BaseCommand(sender => IsRomaniMaskCollected = false);

        CollectCircusLeadersMaskCommand = new BaseCommand(sender => IsCircusLeadersMaskCollected = true);
        UncollectCircusLeadersMaskCommand = new BaseCommand(sender => IsCircusLeadersMaskCollected = false);

        CollectKafeisMaskCommand = new BaseCommand(sender => IsKafeisMaskCollected = true);
        UncollectKafeisMaskCommand = new BaseCommand(sender => IsKafeisMaskCollected = false);

        CollectCoupleMaskCommand = new BaseCommand(sender => IsCoupleMaskCollected = true);
        UncollectCoupleMaskCommand = new BaseCommand(sender => IsCoupleMaskCollected = false);

        CollectMaskOfTruthCommand = new BaseCommand(sender => IsMaskOfTruthCollected = true);
        UncollectMaskOfTruthCommand = new BaseCommand(sender => IsMaskOfTruthCollected = false);

        CollectZoraMaskCommand = new BaseCommand(sender => IsZoraMaskCollected = true);
        UncollectZoraMaskCommand = new BaseCommand(sender => IsZoraMaskCollected = false);


        CollectKamaroMaskCommand = new BaseCommand(sender => IsKamaroMaskCollected = true);
        UncollectKamaroMaskCommand = new BaseCommand(sender => IsKamaroMaskCollected = false);

        CollectGibdoMaskCommand = new BaseCommand(sender => IsGibdoMaskCollected = true);
        UncollectGibdoMaskCommand = new BaseCommand(sender => IsGibdoMaskCollected = false);

        CollectGaroMaskCommand = new BaseCommand(sender => IsGaroMaskCollected = true);
        UncollectGaroMaskCommand = new BaseCommand(sender => IsGaroMaskCollected = false);

        CollectCaptainHatCommand = new BaseCommand(sender => IsCaptainHatCollected = true);
        UncollectCaptainHatCommand = new BaseCommand(sender => IsCaptainHatCollected = false);

        CollectGiantMaskCommand = new BaseCommand(sender => IsGiantMaskCollected = true);
        UncollectGiantMaskCommand = new BaseCommand(sender => IsGiantMaskCollected = false);

        CollectFierceDeityMaskCommand = new BaseCommand(sender => IsFierceDeityMaskCollected = true);
        UncollectFierceDeityMaskCommand = new BaseCommand(sender => IsFierceDeityMaskCollected = false);
    }

    #region Properties

    #region First row

    public bool IsPostmanHatCollected
    {
        get => SettingsStore.Instance.Settings.MasksPageSettings.IsPostmanHatCollected;
        set
        {
            SettingsStore.Instance.Settings.MasksPageSettings.IsPostmanHatCollected = value;
            NotifyPropertyChanged();
        }
    }

    public bool IsAllNightMaskCollected
    {
        get => SettingsStore.Instance.Settings.MasksPageSettings.IsAllNightMaskCollected;
        set
        {
            SettingsStore.Instance.Settings.MasksPageSettings.IsAllNightMaskCollected = value;
            NotifyPropertyChanged();
        }
    }

    public bool IsBlastMaskCollected
    {
        get => SettingsStore.Instance.Settings.MasksPageSettings.IsBlastMaskCollected;
        set
        {
            SettingsStore.Instance.Settings.MasksPageSettings.IsBlastMaskCollected = value;
            NotifyPropertyChanged();
        }
    }

    public bool IsStoneMaskCollected
    {
        get => SettingsStore.Instance.Settings.MasksPageSettings.IsStoneMaskCollected;
        set
        {
            SettingsStore.Instance.Settings.MasksPageSettings.IsStoneMaskCollected = value;
            NotifyPropertyChanged();
        }
    }

    public bool IsGreatFairyMaskCollected
    {
        get => SettingsStore.Instance.Settings.MasksPageSettings.IsGreatFairyMaskCollected;
        set
        {
            SettingsStore.Instance.Settings.MasksPageSettings.IsGreatFairyMaskCollected = value;
            NotifyPropertyChanged();
        }
    }

    public bool IsDekuMaskCollected
    {
        get => SettingsStore.Instance.Settings.MasksPageSettings.IsDekuMaskCollected;
        set
        {
            SettingsStore.Instance.Settings.MasksPageSettings.IsDekuMaskCollected = value;
            NotifyPropertyChanged();
        }
    }

    #endregion


    #region Second row

    public bool IsKeatonMaskCollected
    {
        get => SettingsStore.Instance.Settings.MasksPageSettings.IsKeatonMaskCollected;
        set
        {
            SettingsStore.Instance.Settings.MasksPageSettings.IsKeatonMaskCollected = value;
            NotifyPropertyChanged();
        }
    }

    public bool IsBremenMaskCollected
    {
        get => SettingsStore.Instance.Settings.MasksPageSettings.IsBremenMaskCollected;
        set
        {
            SettingsStore.Instance.Settings.MasksPageSettings.IsBremenMaskCollected = value;
            NotifyPropertyChanged();
        }
    }

    public bool IsBunnyHoodCollected
    {
        get => SettingsStore.Instance.Settings.MasksPageSettings.IsBunnyHoodCollected;
        set
        {
            SettingsStore.Instance.Settings.MasksPageSettings.IsBunnyHoodCollected = value;
            NotifyPropertyChanged();
        }
    }

    public bool IsDonGeroMaskCollected
    {
        get => SettingsStore.Instance.Settings.MasksPageSettings.IsDonGeroMaskCollected;
        set
        {
            SettingsStore.Instance.Settings.MasksPageSettings.IsDonGeroMaskCollected = value;
            NotifyPropertyChanged();
        }
    }

    public bool IsMaskOfScentsCollected
    {
        get => SettingsStore.Instance.Settings.MasksPageSettings.IsMaskOfScentsCollected;
        set
        {
            SettingsStore.Instance.Settings.MasksPageSettings.IsMaskOfScentsCollected = value;
            NotifyPropertyChanged();
        }
    }

    public bool IsGoronMaskCollected
    {
        get => SettingsStore.Instance.Settings.MasksPageSettings.IsGoronMaskCollected;
        set
        {
            SettingsStore.Instance.Settings.MasksPageSettings.IsGoronMaskCollected = value;
            NotifyPropertyChanged();
        }
    }

    #endregion


    #region Third row

    public bool IsRomaniMaskCollected
    {
        get => SettingsStore.Instance.Settings.MasksPageSettings.IsRomaniMaskCollected;
        set
        {
            SettingsStore.Instance.Settings.MasksPageSettings.IsRomaniMaskCollected = value;
            NotifyPropertyChanged();
        }
    }

    public bool IsCircusLeadersMaskCollected
    {
        get => SettingsStore.Instance.Settings.MasksPageSettings.IsCircusLeadersMaskCollected;
        set
        {
            SettingsStore.Instance.Settings.MasksPageSettings.IsCircusLeadersMaskCollected = value;
            NotifyPropertyChanged();
        }
    }

    public bool IsKafeisMaskCollected
    {
        get => SettingsStore.Instance.Settings.MasksPageSettings.IsKafeisMaskCollected;
        set
        {
            SettingsStore.Instance.Settings.MasksPageSettings.IsKafeisMaskCollected = value;
            NotifyPropertyChanged();
        }
    }

    public bool IsCoupleMaskCollected
    {
        get => SettingsStore.Instance.Settings.MasksPageSettings.IsCoupleMaskCollected;
        set
        {
            SettingsStore.Instance.Settings.MasksPageSettings.IsCoupleMaskCollected = value;
            NotifyPropertyChanged();
        }
    }

    public bool IsMaskOfTruthCollected
    {
        get => SettingsStore.Instance.Settings.MasksPageSettings.IsMaskOfTruthCollected;
        set
        {
            SettingsStore.Instance.Settings.MasksPageSettings.IsMaskOfTruthCollected = value;
            NotifyPropertyChanged();
        }
    }

    public bool IsZoraMaskCollected
    {
        get => SettingsStore.Instance.Settings.MasksPageSettings.IsZoraMaskCollected;
        set
        {
            SettingsStore.Instance.Settings.MasksPageSettings.IsZoraMaskCollected = value;
            NotifyPropertyChanged();
        }
    }

    #endregion


    #region Fourth row

    public bool IsKamaroMaskCollected
    {
        get => SettingsStore.Instance.Settings.MasksPageSettings.IsKamaroMaskCollected;
        set
        {
            SettingsStore.Instance.Settings.MasksPageSettings.IsKamaroMaskCollected = value;
            NotifyPropertyChanged();
        }
    }

    public bool IsGibdoMaskCollected
    {
        get => SettingsStore.Instance.Settings.MasksPageSettings.IsGibdoMaskCollected;
        set
        {
            SettingsStore.Instance.Settings.MasksPageSettings.IsGibdoMaskCollected = value;
            NotifyPropertyChanged();
        }
    }

    public bool IsGaroMaskCollected
    {
        get => SettingsStore.Instance.Settings.MasksPageSettings.IsGaroMaskCollected;
        set
        {
            SettingsStore.Instance.Settings.MasksPageSettings.IsGaroMaskCollected = value;
            NotifyPropertyChanged();
        }
    }

    public bool IsCaptainHatCollected
    {
        get => SettingsStore.Instance.Settings.MasksPageSettings.IsCaptainHatCollected;
        set
        {
            SettingsStore.Instance.Settings.MasksPageSettings.IsCaptainHatCollected = value;
            NotifyPropertyChanged();
        }
    }

    public bool IsGiantMaskCollected
    {
        get => SettingsStore.Instance.Settings.MasksPageSettings.IsGiantMaskCollected;
        set
        {
            SettingsStore.Instance.Settings.MasksPageSettings.IsGiantMaskCollected = value;
            NotifyPropertyChanged();
        }
    }

    public bool IsFierceDeityMaskCollected
    {
        get => SettingsStore.Instance.Settings.MasksPageSettings.IsFierceDeityMaskCollected;
        set
        {
            SettingsStore.Instance.Settings.MasksPageSettings.IsFierceDeityMaskCollected = value;
            NotifyPropertyChanged();
        }
    }

    #endregion

    #endregion


    #region Commands

    public BaseCommand CollectPostmanHatCommand { get; set; }
    public BaseCommand UncollectPostmanHatCommand { get; set; }

    public BaseCommand CollectAllNightMaskCommand { get; set; }
    public BaseCommand UncollectAllNightMaskCommand { get; set; }

    public BaseCommand CollectBlastMaskCommand { get; set; }
    public BaseCommand UncollectBlastMaskCommand { get; set; }

    public BaseCommand CollectStoneMaskCommand { get; set; }
    public BaseCommand UncollectStoneMaskCommand { get; set; }

    public BaseCommand CollectGreatFairyMaskCommand { get; set; }
    public BaseCommand UncollectGreatFairyMaskCommand { get; set; }

    public BaseCommand CollectDekuMaskCommand { get; set; }
    public BaseCommand UncollectDekuMaskCommand { get; set; }


    public BaseCommand CollectKeatonMaskCommand { get; set; }
    public BaseCommand UncollectKeatonMaskCommand { get; set; }

    public BaseCommand CollectBremenMaskCommand { get; set; }
    public BaseCommand UncollectBremenMaskCommand { get; set; }

    public BaseCommand CollectBunnyHoodCommand { get; set; }
    public BaseCommand UncollectBunnyHoodCommand { get; set; }

    public BaseCommand CollectDonGeroMaskCommand { get; set; }
    public BaseCommand UncollectDonGeroMaskCommand { get; set; }

    public BaseCommand CollectMaskOfScentsCommand { get; set; }
    public BaseCommand UncollectMaskOfScentsCommand { get; set; }

    public BaseCommand CollectGoronMaskCommand { get; set; }
    public BaseCommand UncollectGoronMaskCommand { get; set; }


    public BaseCommand CollectRomaniMaskCommand { get; set; }
    public BaseCommand UncollectRomaniMaskCommand { get; set; }

    public BaseCommand CollectCircusLeadersMaskCommand { get; set; }
    public BaseCommand UncollectCircusLeadersMaskCommand { get; set; }

    public BaseCommand CollectKafeisMaskCommand { get; set; }
    public BaseCommand UncollectKafeisMaskCommand { get; set; }

    public BaseCommand CollectCoupleMaskCommand { get; set; }
    public BaseCommand UncollectCoupleMaskCommand { get; set; }

    public BaseCommand CollectMaskOfTruthCommand { get; set; }
    public BaseCommand UncollectMaskOfTruthCommand { get; set; }

    public BaseCommand CollectZoraMaskCommand { get; set; }
    public BaseCommand UncollectZoraMaskCommand { get; set; }


    public BaseCommand CollectKamaroMaskCommand { get; set; }
    public BaseCommand UncollectKamaroMaskCommand { get; set; }

    public BaseCommand CollectGibdoMaskCommand { get; set; }
    public BaseCommand UncollectGibdoMaskCommand { get; set; }

    public BaseCommand CollectGaroMaskCommand { get; set; }
    public BaseCommand UncollectGaroMaskCommand { get; set; }

    public BaseCommand CollectCaptainHatCommand { get; set; }
    public BaseCommand UncollectCaptainHatCommand { get; set; }

    public BaseCommand CollectGiantMaskCommand { get; set; }
    public BaseCommand UncollectGiantMaskCommand { get; set; }

    public BaseCommand CollectFierceDeityMaskCommand { get; set; }
    public BaseCommand UncollectFierceDeityMaskCommand { get; set; }

    #endregion
}