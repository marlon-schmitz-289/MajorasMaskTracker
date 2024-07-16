using System.Windows.Media;
using MajorasMaskTracker.Store;
using WPFBase.Utils;

namespace MajorasMaskTracker.Viewmodel.InventoryViewmodel;

public class DungeonPageViewmodel : BaseViewmodel
{
    public DungeonPageViewmodel()
    {
        SettingsStore.Instance.ApplicationSettings.OnForegroundColorChanged +=
            () => NotifyPropertyChanged(nameof(ForegroundBrush));
    }

    #region Properties

    #region Woodfall Temple

    public bool IsWoodfallMapCollected
    {
        get => SettingsStore.Instance.Settings.DungeonPageSettings.IsWoodfallMapCollected;
        set
        {
            SettingsStore.Instance.Settings.DungeonPageSettings.IsWoodfallMapCollected = value;
            NotifyPropertyChanged();
        }
    }

    public bool IsWoodfallCompassCollected
    {
        get => SettingsStore.Instance.Settings.DungeonPageSettings.IsWoodfallCompassCollected;
        set
        {
            SettingsStore.Instance.Settings.DungeonPageSettings.IsWoodfallCompassCollected = value;
            NotifyPropertyChanged();
        }
    }

    public bool IsWoodfallBossKeyCollected
    {
        get => SettingsStore.Instance.Settings.DungeonPageSettings.IsWoodfallBossKeyCollected;
        set
        {
            SettingsStore.Instance.Settings.DungeonPageSettings.IsWoodfallBossKeyCollected = value;
            NotifyPropertyChanged();
        }
    }

    public bool IsWoodfallFairyCollected => CollectedWoodfallFairies > 0;

    public int CollectedWoodfallFairies
    {
        get => SettingsStore.Instance.Settings.DungeonPageSettings.CollectedWoodfallFairies;
        set
        {
            if (value > MaxStrayFairies || value < 0) return;

            SettingsStore.Instance.Settings.DungeonPageSettings.CollectedWoodfallFairies = value;
            NotifyPropertyChanged();
            NotifyPropertyChanged(nameof(IsWoodfallFairyCollected));
            NotifyPropertyChanged(nameof(WoodfallFairyText));
        }
    }

    public bool IsWoodfallSmallKeyCollected => CollectedWoodfallSmallKeys > 0;

    public int CollectedWoodfallSmallKeys
    {
        get => SettingsStore.Instance.Settings.DungeonPageSettings.CollectedWoodfallSmallKeys;
        set
        {
            if (value > MaxWoodfallSmallKeys || value < 0) return;

            SettingsStore.Instance.Settings.DungeonPageSettings.CollectedWoodfallSmallKeys = value;
            NotifyPropertyChanged();
            NotifyPropertyChanged(nameof(IsWoodfallSmallKeyCollected));
            NotifyPropertyChanged(nameof(WoodfallSmallKeyText));
        }
    }

    #endregion


    #region Snowhead Temple

    public bool IsSnowheadMapCollected
    {
        get => SettingsStore.Instance.Settings.DungeonPageSettings.IsSnowheadMapCollected;
        set
        {
            SettingsStore.Instance.Settings.DungeonPageSettings.IsSnowheadMapCollected = value;
            NotifyPropertyChanged();
        }
    }

    public bool IsSnowheadCompassCollected
    {
        get => SettingsStore.Instance.Settings.DungeonPageSettings.IsSnowheadCompassCollected;
        set
        {
            SettingsStore.Instance.Settings.DungeonPageSettings.IsSnowheadCompassCollected = value;
            NotifyPropertyChanged();
        }
    }

    public bool IsSnowheadBossKeyCollected
    {
        get => SettingsStore.Instance.Settings.DungeonPageSettings.IsSnowheadBossKeyCollected;
        set
        {
            SettingsStore.Instance.Settings.DungeonPageSettings.IsSnowheadBossKeyCollected = value;
            NotifyPropertyChanged();
        }
    }

    public bool IsSnowheadFairyCollected => CollectedSnowheadFairies > 0;

    public int CollectedSnowheadFairies
    {
        get => SettingsStore.Instance.Settings.DungeonPageSettings.CollectedSnowheadFairies;
        set
        {
            if (value > MaxStrayFairies || value < 0) return;

            SettingsStore.Instance.Settings.DungeonPageSettings.CollectedSnowheadFairies = value;
            NotifyPropertyChanged();
            NotifyPropertyChanged(nameof(IsSnowheadFairyCollected));
            NotifyPropertyChanged(nameof(SnowheadFairyText));
        }
    }

    public bool IsSnowheadSmallKeyCollected => CollectedSnowheadSmallKeys > 0;

    public int CollectedSnowheadSmallKeys
    {
        get => SettingsStore.Instance.Settings.DungeonPageSettings.CollectedSnowheadSmallKeys;
        set
        {
            if (value > MaxSnowheadSmallKeys || value < 0) return;

            SettingsStore.Instance.Settings.DungeonPageSettings.CollectedSnowheadSmallKeys = value;
            NotifyPropertyChanged();
            NotifyPropertyChanged(nameof(IsSnowheadSmallKeyCollected));
            NotifyPropertyChanged(nameof(SnowheadSmallKeyText));
        }
    }

    #endregion


    #region Great Bay Temple

    public bool IsGreatBayMapCollected
    {
        get => SettingsStore.Instance.Settings.DungeonPageSettings.IsGreatBayMapCollected;
        set
        {
            SettingsStore.Instance.Settings.DungeonPageSettings.IsGreatBayMapCollected = value;
            NotifyPropertyChanged();
        }
    }

    public bool IsGreatBayCompassCollected
    {
        get => SettingsStore.Instance.Settings.DungeonPageSettings.IsGreatBayCompassCollected;
        set
        {
            SettingsStore.Instance.Settings.DungeonPageSettings.IsGreatBayCompassCollected = value;
            NotifyPropertyChanged();
        }
    }

    public bool IsGreatBayBossKeyCollected
    {
        get => SettingsStore.Instance.Settings.DungeonPageSettings.IsGreatBayBossKeyCollected;
        set
        {
            SettingsStore.Instance.Settings.DungeonPageSettings.IsGreatBayBossKeyCollected = value;
            NotifyPropertyChanged();
        }
    }

    public bool IsGreatBayFairyCollected => CollectedGreatBayFairies > 0;

    public int CollectedGreatBayFairies
    {
        get => SettingsStore.Instance.Settings.DungeonPageSettings.CollectedGreatBayFairies;
        set
        {
            if (value > MaxStrayFairies || value < 0) return;

            SettingsStore.Instance.Settings.DungeonPageSettings.CollectedGreatBayFairies = value;
            NotifyPropertyChanged();
            NotifyPropertyChanged(nameof(IsGreatBayFairyCollected));
            NotifyPropertyChanged(nameof(GreatBayFairyText));
        }
    }

    public bool IsGreatBaySmallKeyCollected => CollectedGreatBaySmallKeys > 0;

    public int CollectedGreatBaySmallKeys
    {
        get => SettingsStore.Instance.Settings.DungeonPageSettings.CollectedGreatBaySmallKeys;
        set
        {
            if (value > MaxGreatBaySmallKeys || value < 0) return;

            SettingsStore.Instance.Settings.DungeonPageSettings.CollectedGreatBaySmallKeys = value;
            NotifyPropertyChanged();
            NotifyPropertyChanged(nameof(IsGreatBaySmallKeyCollected));
            NotifyPropertyChanged(nameof(GreatBaySmallKeyText));
        }
    }

    #endregion


    #region Stone Tower Temple

    public bool IsStoneTowerMapCollected
    {
        get => SettingsStore.Instance.Settings.DungeonPageSettings.IsStoneTowerMapCollected;
        set
        {
            SettingsStore.Instance.Settings.DungeonPageSettings.IsStoneTowerMapCollected = value;
            NotifyPropertyChanged();
        }
    }

    public bool IsStoneTowerCompassCollected
    {
        get => SettingsStore.Instance.Settings.DungeonPageSettings.IsStoneTowerCompassCollected;
        set
        {
            SettingsStore.Instance.Settings.DungeonPageSettings.IsStoneTowerCompassCollected = value;
            NotifyPropertyChanged();
        }
    }

    public bool IsStoneTowerBossKeyCollected
    {
        get => SettingsStore.Instance.Settings.DungeonPageSettings.IsStoneTowerBossKeyCollected;
        set
        {
            SettingsStore.Instance.Settings.DungeonPageSettings.IsStoneTowerBossKeyCollected = value;
            NotifyPropertyChanged();
        }
    }

    public bool IsStoneTowerFairyCollected => CollectedStoneTowerFairies > 0;

    public int CollectedStoneTowerFairies
    {
        get => SettingsStore.Instance.Settings.DungeonPageSettings.CollectedStoneTowerFairies;
        set
        {
            if (value > MaxStrayFairies || value < 0) return;

            SettingsStore.Instance.Settings.DungeonPageSettings.CollectedStoneTowerFairies = value;
            NotifyPropertyChanged();
            NotifyPropertyChanged(nameof(IsStoneTowerFairyCollected));
            NotifyPropertyChanged(nameof(StoneTowerFairyText));
        }
    }

    public bool IsStoneTowerSmallKeyCollected => CollectedStoneTowerSmallKeys > 0;

    public int CollectedStoneTowerSmallKeys
    {
        get => SettingsStore.Instance.Settings.DungeonPageSettings.CollectedStoneTowerSmallKeys;
        set
        {
            if (value > MaxStoneTowerSmallKeys || value < 0) return;

            SettingsStore.Instance.Settings.DungeonPageSettings.CollectedStoneTowerSmallKeys = value;
            NotifyPropertyChanged();
            NotifyPropertyChanged(nameof(IsStoneTowerSmallKeyCollected));
            NotifyPropertyChanged(nameof(StoneTowerSmallKeyText));
        }
    }

    #endregion

    #endregion


    #region Commands

    #region Woodfall Temple

    public BaseCommand CollectWoodfallMapCommand => new(s => IsWoodfallMapCollected = true);
    public BaseCommand UncollectWoodfallMapCommand => new(s => IsWoodfallMapCollected = false);

    public BaseCommand CollectWoodfallCompassCommand => new(s => IsWoodfallCompassCollected = true);
    public BaseCommand UncollectWoodfallCompassCommand => new(s => IsWoodfallCompassCollected = false);

    public BaseCommand CollectWoodfallBossKeyCommand => new(s => IsWoodfallBossKeyCollected = true);
    public BaseCommand UncollectWoodfallBossKeyCommand => new(s => IsWoodfallBossKeyCollected = false);

    public BaseCommand CollectWoodfallFairyCommand => new(s => CollectedWoodfallFairies++);
    public BaseCommand UncollectWoodfallFairyCommand => new(s => CollectedWoodfallFairies--);

    public BaseCommand CollectWoodfallSmallKeyCommand => new(s => CollectedWoodfallSmallKeys++);
    public BaseCommand UncollectWoodfallSmallKeyCommand => new(s => CollectedWoodfallSmallKeys--);

    #endregion


    #region Snowhead Temple

    public BaseCommand CollectSnowheadMapCommand => new(s => IsSnowheadMapCollected = true);
    public BaseCommand UncollectSnowheadMapCommand => new(s => IsSnowheadMapCollected = false);

    public BaseCommand CollectSnowheadCompassCommand => new(s => IsSnowheadCompassCollected = true);
    public BaseCommand UncollectSnowheadCompassCommand => new(s => IsSnowheadCompassCollected = false);

    public BaseCommand CollectSnowheadBossKeyCommand => new(s => IsSnowheadBossKeyCollected = true);
    public BaseCommand UncollectSnowheadBossKeyCommand => new(s => IsSnowheadBossKeyCollected = false);

    public BaseCommand CollectSnowheadFairyCommand => new(s => CollectedSnowheadFairies++);
    public BaseCommand UncollectSnowheadFairyCommand => new(s => CollectedSnowheadFairies--);

    public BaseCommand CollectSnowheadSmallKeyCommand => new(s => CollectedSnowheadSmallKeys++);
    public BaseCommand UncollectSnowheadSmallKeyCommand => new(s => CollectedSnowheadSmallKeys--);

    #endregion


    #region Great Bay Temple

    public BaseCommand CollectGreatBayMapCommand => new(s => IsGreatBayMapCollected = true);
    public BaseCommand UncollectGreatBayMapCommand => new(s => IsGreatBayMapCollected = false);

    public BaseCommand CollectGreatBayCompassCommand => new(s => IsGreatBayCompassCollected = true);
    public BaseCommand UncollectGreatBayCompassCommand => new(s => IsGreatBayCompassCollected = false);

    public BaseCommand CollectGreatBayBossKeyCommand => new(s => IsGreatBayBossKeyCollected = true);
    public BaseCommand UncollectGreatBayBossKeyCommand => new(s => IsGreatBayBossKeyCollected = false);

    public BaseCommand CollectGreatBayFairyCommand => new(s => CollectedGreatBayFairies++);
    public BaseCommand UncollectGreatBayFairyCommand => new(s => CollectedGreatBayFairies--);

    public BaseCommand CollectGreatBaySmallKeyCommand => new(s => CollectedGreatBaySmallKeys++);
    public BaseCommand UncollectGreatBaySmallKeyCommand => new(s => CollectedGreatBaySmallKeys--);

    #endregion


    #region Stone Tower Temple

    public BaseCommand CollectStoneTowerMapCommand => new(s => IsStoneTowerMapCollected = true);
    public BaseCommand UncollectStoneTowerMapCommand => new(s => IsStoneTowerMapCollected = false);

    public BaseCommand CollectStoneTowerCompassCommand => new(s => IsStoneTowerCompassCollected = true);

    public BaseCommand UncollectStoneTowerCompassCommand => new(s => IsStoneTowerCompassCollected = false);

    public BaseCommand CollectStoneTowerBossKeyCommand => new(s => IsStoneTowerBossKeyCollected = true);

    public BaseCommand UncollectStoneTowerBossKeyCommand => new(s => IsStoneTowerBossKeyCollected = false);

    public BaseCommand CollectStoneTowerFairyCommand => new(s => CollectedStoneTowerFairies++);
    public BaseCommand UncollectStoneTowerFairyCommand => new(s => CollectedStoneTowerFairies--);

    public BaseCommand CollectStoneTowerSmallKeyCommand => new(s => CollectedStoneTowerSmallKeys++);
    public BaseCommand UncollectStoneTowerSmallKeyCommand => new(s => CollectedStoneTowerSmallKeys--);

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

    public SolidColorBrush ForegroundBrush => SettingsStore.Instance.ApplicationSettings.ForegroundBrush;

    #endregion
}