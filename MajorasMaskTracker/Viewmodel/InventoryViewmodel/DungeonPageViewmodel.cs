using System.Security.Cryptography.Pkcs;
using System.Windows.Media;
using MajorasMaskTracker.Store;
using WPFBase.Utils;

namespace MajorasMaskTracker.Viewmodel.InventoryViewmodel;

public class DungeonPageViewmodel : BaseViewModel
{
    #region Properties

    #region Woodfall Temple

    public bool IsWoodfallMapCollected
    {
        get => SettingsStore.Instance.SettingsModel.DungeonPageSettings.IsWoodfallMapCollected;
        set
        {
            SettingsStore.Instance.SettingsModel.DungeonPageSettings.IsWoodfallMapCollected = value;
            NotifyPropertyChanged();
        }
    }

    public bool IsWoodfallCompassCollected
    {
        get => SettingsStore.Instance.SettingsModel.DungeonPageSettings.IsWoodfallCompassCollected;
        set
        {
            SettingsStore.Instance.SettingsModel.DungeonPageSettings.IsWoodfallCompassCollected = value;
            NotifyPropertyChanged();
        }
    }

    public bool IsWoodfallBossKeyCollected
    {
        get => SettingsStore.Instance.SettingsModel.DungeonPageSettings.IsWoodfallBossKeyCollected;
        set
        {
            SettingsStore.Instance.SettingsModel.DungeonPageSettings.IsWoodfallBossKeyCollected = value;
            NotifyPropertyChanged();
        }
    }

    public bool IsWoodfallFairyCollected => CollectedWoodfallFairies > 0;

    public int CollectedWoodfallFairies
    {
        get => SettingsStore.Instance.SettingsModel.DungeonPageSettings.CollectedWoodfallFairies;
        set
        {
            if (value > MaxStrayFairies || value < 0) return;

            SettingsStore.Instance.SettingsModel.DungeonPageSettings.CollectedWoodfallFairies = value;
            NotifyPropertyChanged();
            NotifyPropertyChanged(nameof(IsWoodfallFairyCollected));
            NotifyPropertyChanged(nameof(WoodfallFairyText));
        }
    }

    public bool IsWoodfallSmallKeyCollected => CollectedWoodfallSmallKeys > 0;

    public int CollectedWoodfallSmallKeys
    {
        get => SettingsStore.Instance.SettingsModel.DungeonPageSettings.CollectedWoodfallSmallKeys;
        set
        {
            if (value > MaxWoodfallSmallKeys || value < 0) return;

            SettingsStore.Instance.SettingsModel.DungeonPageSettings.CollectedWoodfallSmallKeys = value;
            NotifyPropertyChanged();
            NotifyPropertyChanged(nameof(IsWoodfallSmallKeyCollected));
            NotifyPropertyChanged(nameof(WoodfallSmallKeyText));
        }
    }

    #endregion


    #region Snowhead Temple

    public bool IsSnowheadMapCollected
    {
        get => SettingsStore.Instance.SettingsModel.DungeonPageSettings.IsSnowheadMapCollected;
        set
        {
            SettingsStore.Instance.SettingsModel.DungeonPageSettings.IsSnowheadMapCollected = value;
            NotifyPropertyChanged();
        }
    }

    public bool IsSnowheadCompassCollected
    {
        get => SettingsStore.Instance.SettingsModel.DungeonPageSettings.IsSnowheadCompassCollected;
        set
        {
            SettingsStore.Instance.SettingsModel.DungeonPageSettings.IsSnowheadCompassCollected = value;
            NotifyPropertyChanged();
        }
    }

    public bool IsSnowheadBossKeyCollected
    {
        get => SettingsStore.Instance.SettingsModel.DungeonPageSettings.IsSnowheadBossKeyCollected;
        set
        {
            SettingsStore.Instance.SettingsModel.DungeonPageSettings.IsSnowheadBossKeyCollected = value;
            NotifyPropertyChanged();
        }
    }

    public bool IsSnowheadFairyCollected => CollectedSnowheadFairies > 0;

    public int CollectedSnowheadFairies
    {
        get => SettingsStore.Instance.SettingsModel.DungeonPageSettings.CollectedSnowheadFairies;
        set
        {
            if (value > MaxStrayFairies || value < 0) return;

            SettingsStore.Instance.SettingsModel.DungeonPageSettings.CollectedSnowheadFairies = value;
            NotifyPropertyChanged();
            NotifyPropertyChanged(nameof(IsSnowheadFairyCollected));
            NotifyPropertyChanged(nameof(SnowheadFairyText));
        }
    }

    public bool IsSnowheadSmallKeyCollected => CollectedSnowheadSmallKeys > 0;

    public int CollectedSnowheadSmallKeys
    {
        get => SettingsStore.Instance.SettingsModel.DungeonPageSettings.CollectedSnowheadSmallKeys;
        set
        {
            if (value > MaxSnowheadSmallKeys || value < 0) return;

            SettingsStore.Instance.SettingsModel.DungeonPageSettings.CollectedSnowheadSmallKeys = value;
            NotifyPropertyChanged();
            NotifyPropertyChanged(nameof(IsSnowheadSmallKeyCollected));
            NotifyPropertyChanged(nameof(SnowheadSmallKeyText));
        }
    }

    #endregion


    #region Great Bay Temple

    public bool IsGreatBayMapCollected
    {
        get => SettingsStore.Instance.SettingsModel.DungeonPageSettings.IsGreatBayMapCollected;
        set
        {
            SettingsStore.Instance.SettingsModel.DungeonPageSettings.IsGreatBayMapCollected = value;
            NotifyPropertyChanged();
        }
    }

    public bool IsGreatBayCompassCollected
    {
        get => SettingsStore.Instance.SettingsModel.DungeonPageSettings.IsGreatBayCompassCollected;
        set
        {
            SettingsStore.Instance.SettingsModel.DungeonPageSettings.IsGreatBayCompassCollected = value;
            NotifyPropertyChanged();
        }
    }

    public bool IsGreatBayBossKeyCollected
    {
        get => SettingsStore.Instance.SettingsModel.DungeonPageSettings.IsGreatBayBossKeyCollected;
        set
        {
            SettingsStore.Instance.SettingsModel.DungeonPageSettings.IsGreatBayBossKeyCollected = value;
            NotifyPropertyChanged();
        }
    }

    public bool IsGreatBayFairyCollected => CollectedGreatBayFairies > 0;

    public int CollectedGreatBayFairies
    {
        get => SettingsStore.Instance.SettingsModel.DungeonPageSettings.CollectedGreatBayFairies;
        set
        {
            if (value > MaxStrayFairies || value < 0) return;

            SettingsStore.Instance.SettingsModel.DungeonPageSettings.CollectedGreatBayFairies = value;
            NotifyPropertyChanged();
            NotifyPropertyChanged(nameof(IsGreatBayFairyCollected));
            NotifyPropertyChanged(nameof(GreatBayFairyText));
        }
    }

    public bool IsGreatBaySmallKeyCollected => CollectedGreatBaySmallKeys > 0;

    public int CollectedGreatBaySmallKeys
    {
        get => SettingsStore.Instance.SettingsModel.DungeonPageSettings.CollectedGreatBaySmallKeys;
        set
        {
            if (value > MaxGreatBaySmallKeys || value < 0) return;

            SettingsStore.Instance.SettingsModel.DungeonPageSettings.CollectedGreatBaySmallKeys = value;
            NotifyPropertyChanged();
            NotifyPropertyChanged(nameof(IsGreatBaySmallKeyCollected));
            NotifyPropertyChanged(nameof(GreatBaySmallKeyText));
        }
    }

    #endregion


    #region Stone Tower Temple

    public bool IsStoneTowerMapCollected
    {
        get => SettingsStore.Instance.SettingsModel.DungeonPageSettings.IsStoneTowerMapCollected;
        set
        {
            SettingsStore.Instance.SettingsModel.DungeonPageSettings.IsStoneTowerMapCollected = value;
            NotifyPropertyChanged();
        }
    }

    public bool IsStoneTowerCompassCollected
    {
        get => SettingsStore.Instance.SettingsModel.DungeonPageSettings.IsStoneTowerCompassCollected;
        set
        {
            SettingsStore.Instance.SettingsModel.DungeonPageSettings.IsStoneTowerCompassCollected = value;
            NotifyPropertyChanged();
        }
    }

    public bool IsStoneTowerBossKeyCollected
    {
        get => SettingsStore.Instance.SettingsModel.DungeonPageSettings.IsStoneTowerBossKeyCollected;
        set
        {
            SettingsStore.Instance.SettingsModel.DungeonPageSettings.IsStoneTowerBossKeyCollected = value;
            NotifyPropertyChanged();
        }
    }

    public bool IsStoneTowerFairyCollected => CollectedStoneTowerFairies > 0;

    public int CollectedStoneTowerFairies
    {
        get => SettingsStore.Instance.SettingsModel.DungeonPageSettings.CollectedStoneTowerFairies;
        set
        {
            if (value > MaxStrayFairies || value < 0) return;
            
            SettingsStore.Instance.SettingsModel.DungeonPageSettings.CollectedStoneTowerFairies = value;
            NotifyPropertyChanged();
            NotifyPropertyChanged(nameof(IsStoneTowerFairyCollected));
            NotifyPropertyChanged(nameof(StoneTowerFairyText));
        }
    }

    public bool IsStoneTowerSmallKeyCollected => CollectedStoneTowerSmallKeys > 0;

    public int CollectedStoneTowerSmallKeys
    {
        get => SettingsStore.Instance.SettingsModel.DungeonPageSettings.CollectedStoneTowerSmallKeys;
        set
        {
            if (value > MaxStoneTowerSmallKeys || value < 0) return;

            SettingsStore.Instance.SettingsModel.DungeonPageSettings.CollectedStoneTowerSmallKeys = value;
            NotifyPropertyChanged();
            NotifyPropertyChanged(nameof(IsStoneTowerSmallKeyCollected));
            NotifyPropertyChanged(nameof(StoneTowerSmallKeyText));
        }
    }

    #endregion

    #endregion


    #region Commands

    #region Woodfall Temple

    public BaseCommand CollectWoodfallMapCommand => new BaseCommand((s) => IsWoodfallMapCollected = true);
    public BaseCommand UncollectWoodfallMapCommand => new BaseCommand((s) => IsWoodfallMapCollected = false);

    public BaseCommand CollectWoodfallCompassCommand => new BaseCommand((s) => IsWoodfallCompassCollected = true);
    public BaseCommand UncollectWoodfallCompassCommand => new BaseCommand((s) => IsWoodfallCompassCollected = false);

    public BaseCommand CollectWoodfallBossKeyCommand => new BaseCommand((s) => IsWoodfallBossKeyCollected = true);
    public BaseCommand UncollectWoodfallBossKeyCommand => new BaseCommand((s) => IsWoodfallBossKeyCollected = false);

    public BaseCommand CollectWoodfallFairyCommand => new BaseCommand((s) => CollectedWoodfallFairies++);
    public BaseCommand UncollectWoodfallFairyCommand => new BaseCommand((s) => CollectedWoodfallFairies--);

    public BaseCommand CollectWoodfallSmallKeyCommand => new BaseCommand((s) => CollectedWoodfallSmallKeys++);
    public BaseCommand UncollectWoodfallSmallKeyCommand => new BaseCommand((s) => CollectedWoodfallSmallKeys--);

    #endregion


    #region Snowhead Temple

    public BaseCommand CollectSnowheadMapCommand => new BaseCommand((s) => IsSnowheadMapCollected = true);
    public BaseCommand UncollectSnowheadMapCommand => new BaseCommand((s) => IsSnowheadMapCollected = false);

    public BaseCommand CollectSnowheadCompassCommand => new BaseCommand((s) => IsSnowheadCompassCollected = true);
    public BaseCommand UncollectSnowheadCompassCommand => new BaseCommand((s) => IsSnowheadCompassCollected = false);

    public BaseCommand CollectSnowheadBossKeyCommand => new BaseCommand((s) => IsSnowheadBossKeyCollected = true);
    public BaseCommand UncollectSnowheadBossKeyCommand => new BaseCommand((s) => IsSnowheadBossKeyCollected = false);

    public BaseCommand CollectSnowheadFairyCommand => new BaseCommand((s) => CollectedSnowheadFairies++);
    public BaseCommand UncollectSnowheadFairyCommand => new BaseCommand((s) => CollectedSnowheadFairies--);

    public BaseCommand CollectSnowheadSmallKeyCommand => new BaseCommand((s) => CollectedSnowheadSmallKeys++);
    public BaseCommand UncollectSnowheadSmallKeyCommand => new BaseCommand((s) => CollectedSnowheadSmallKeys--);

    #endregion


    #region Great Bay Temple

    public BaseCommand CollectGreatBayMapCommand => new BaseCommand((s) => IsGreatBayMapCollected = true);
    public BaseCommand UncollectGreatBayMapCommand => new BaseCommand((s) => IsGreatBayMapCollected = false);

    public BaseCommand CollectGreatBayCompassCommand => new BaseCommand((s) => IsGreatBayCompassCollected = true);
    public BaseCommand UncollectGreatBayCompassCommand => new BaseCommand((s) => IsGreatBayCompassCollected = false);

    public BaseCommand CollectGreatBayBossKeyCommand => new BaseCommand((s) => IsGreatBayBossKeyCollected = true);
    public BaseCommand UncollectGreatBayBossKeyCommand => new BaseCommand((s) => IsGreatBayBossKeyCollected = false);

    public BaseCommand CollectGreatBayFairyCommand => new BaseCommand((s) => CollectedGreatBayFairies++);
    public BaseCommand UncollectGreatBayFairyCommand => new BaseCommand((s) => CollectedGreatBayFairies--);

    public BaseCommand CollectGreatBaySmallKeyCommand => new BaseCommand((s) => CollectedGreatBaySmallKeys++);
    public BaseCommand UncollectGreatBaySmallKeyCommand => new BaseCommand((s) => CollectedGreatBaySmallKeys--);

    #endregion


    #region Stone Tower Temple

    public BaseCommand CollectStoneTowerMapCommand => new BaseCommand((s) => IsStoneTowerMapCollected = true);
    public BaseCommand UncollectStoneTowerMapCommand => new BaseCommand((s) => IsStoneTowerMapCollected = false);

    public BaseCommand CollectStoneTowerCompassCommand => new BaseCommand((s) => IsStoneTowerCompassCollected = true);

    public BaseCommand UncollectStoneTowerCompassCommand =>
        new BaseCommand((s) => IsStoneTowerCompassCollected = false);

    public BaseCommand CollectStoneTowerBossKeyCommand => new BaseCommand((s) => IsStoneTowerBossKeyCollected = true);

    public BaseCommand UncollectStoneTowerBossKeyCommand =>
        new BaseCommand((s) => IsStoneTowerBossKeyCollected = false);

    public BaseCommand CollectStoneTowerFairyCommand => new BaseCommand((s) => CollectedStoneTowerFairies++);
    public BaseCommand UncollectStoneTowerFairyCommand => new BaseCommand((s) => CollectedStoneTowerFairies--);

    public BaseCommand CollectStoneTowerSmallKeyCommand => new BaseCommand((s) => CollectedStoneTowerSmallKeys++);
    public BaseCommand UncollectStoneTowerSmallKeyCommand => new BaseCommand((s) => CollectedStoneTowerSmallKeys--);

    #endregion

    #endregion


    #region UI only properties

    public int MaxStrayFairies => 15;
    public int MaxWoodfallSmallKeys => 1;
    public int MaxSnowheadSmallKeys => 3;
    public int MaxGreatBaySmallKeys => 1;
    public int MaxStoneTowerSmallKeys => 4;

    public string WoodfallFairyText => $"{CollectedWoodfallFairies}/{MaxStrayFairies}";
    public string SnowheadFairyText => $"{CollectedSnowheadFairies}/{MaxStrayFairies}";
    public string GreatBayFairyText => $"{CollectedGreatBayFairies}/{MaxStrayFairies}";
    public string StoneTowerFairyText => $"{CollectedStoneTowerFairies}/{MaxStrayFairies}";

    public string WoodfallSmallKeyText => $"{CollectedWoodfallSmallKeys}/{MaxWoodfallSmallKeys}";
    public string SnowheadSmallKeyText => $"{CollectedSnowheadSmallKeys}/{MaxSnowheadSmallKeys}";
    public string GreatBaySmallKeyText => $"{CollectedGreatBaySmallKeys}/{MaxGreatBaySmallKeys}";
    public string StoneTowerSmallKeyText => $"{CollectedStoneTowerSmallKeys}/{MaxStoneTowerSmallKeys}";
    
    public SolidColorBrush ForegroundBrush => SettingsStore.Instance.ApplicationSettingsModel.ForegroundBrush;

    #endregion


    public DungeonPageViewmodel()
    {
    }
}