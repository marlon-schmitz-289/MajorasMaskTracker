using MajorasMaskTracker.Util;
using WPFBase.Utils;

namespace MajorasMaskTracker.Viewmodel.InventoryViewmodel;

public class QuestStatusPageViewmodel : BaseViewModel
{
    public event Action OnInitialize;
    
    
    #region Values
    
    #region Remains
    
    private bool _odolwaCollected = false;
    public bool OdolwaCollected
    {
        get => _odolwaCollected;
        set
        {
            _odolwaCollected = value;
            NotifyPropertyChanged();
        }
    }
    
    private bool _gohtCollected = false;
    public bool GohtCollected
    {
        get => _gohtCollected;
        set
        {
            _gohtCollected = value;
            NotifyPropertyChanged();
        }
    }
    
    private bool _gyorgCollected = false;
    public bool GyorgCollected
    {
        get => _gyorgCollected;
        set
        {
            _gyorgCollected = value;
            NotifyPropertyChanged();
        }
    }
    
    private bool _twinmoldCollected = false;
    public bool TwinmoldCollected
    {
        get => _twinmoldCollected;
        set
        {
            _twinmoldCollected = value;
            NotifyPropertyChanged();
        }
    }
    
    #endregion
    
    
    #region Important Items

    private int _collectedHeartPieces = 0;
    public int CollectedHeartPieces
    {
        get => _collectedHeartPieces;
        set
        {
            if (value <= 52 && value >= 0)
            {
                _collectedHeartPieces = value;
            }
            
            NotifyPropertyChanged();
            NotifyPropertyChanged(nameof(IsHeartPieceCollected));
        }
    }
    public bool IsHeartPieceCollected => CollectedHeartPieces > 0;

    private bool _bombersNotebookCollected = false;
    public bool BombersNotebookCollected
    {
        get => _bombersNotebookCollected;
        set
        {
            _bombersNotebookCollected = value;
            NotifyPropertyChanged();
        }
    }
    
    
    private CollectedWallet _wallet = CollectedWallet.None;
    public CollectedWallet Wallet
    {
        get => _wallet;
        set
        {
            if (value is > CollectedWallet.GiantsWallet or < CollectedWallet.None) return;
            
            _wallet = value;
            NotifyPropertyChanged();
            NotifyPropertyChanged(nameof(IsAnyWalletCollected));
            NotifyPropertyChanged(nameof(IsChildWalletCollected));
            NotifyPropertyChanged(nameof(IsAdultWalletCollected));
            NotifyPropertyChanged(nameof(IsGiantWalletCollected));
        }
    }
    
    public bool IsAnyWalletCollected => Wallet != CollectedWallet.None;
    public bool IsChildWalletCollected => Wallet == CollectedWallet.ChildWallet;
    public bool IsAdultWalletCollected => Wallet == CollectedWallet.AdultWallet;
    public bool IsGiantWalletCollected => Wallet == CollectedWallet.GiantsWallet;
    
    
    private CollectedMagic _magic = CollectedMagic.None;
    public CollectedMagic Magic
    {
        get => _magic;
        set
        {
            if (value is > CollectedMagic.DoubleMagic or < CollectedMagic.None) return;
            
            _magic = value;
            NotifyPropertyChanged();
            NotifyPropertyChanged(nameof(IsAnyMagicCollected));
            NotifyPropertyChanged(nameof(IsMagicCollected));
            NotifyPropertyChanged(nameof(IsDoubleMagicCollected));
        }
    }
    
    public bool IsAnyMagicCollected => Magic != CollectedMagic.None;
    public bool IsMagicCollected => Magic == CollectedMagic.Magic;
    public bool IsDoubleMagicCollected => Magic == CollectedMagic.DoubleMagic;
    
    #endregion
    
    
    #region Songs
    
    private bool _songOfTimeCollected = false;
    public bool SongOfTimeCollected
    {
        get => _songOfTimeCollected;
        set
        {
            _songOfTimeCollected = value;
            NotifyPropertyChanged();
        }
    }
    
    private bool _songOfHealingCollected = false;
    public bool SongOfHealingCollected
    {
        get => _songOfHealingCollected;
        set
        {
            _songOfHealingCollected = value;
            NotifyPropertyChanged();
        }
    }

    private bool _eponasSongCollected = false;
    public bool EponasSongCollected
    {
        get => _eponasSongCollected;
        set
        {
            _eponasSongCollected = value;
            NotifyPropertyChanged();
        }
    }

    private bool _songOfSoaringCollected = false;
    public bool SongOfSoaringCollected
    {
        get => _songOfSoaringCollected;
        set
        {
            _songOfSoaringCollected = value;
            NotifyPropertyChanged();
        }
    }

    private bool _songOfStormsCollected = false;
    public bool SongOfStormsCollected
    {
        get => _songOfStormsCollected;
        set
        {
            _songOfStormsCollected = value;
            NotifyPropertyChanged();
        }
    }

    private bool _sonataOfAwakeningCollected = false;
    public bool SonataOfAwakeningCollected
    {
        get => _sonataOfAwakeningCollected;
        set
        {
            _sonataOfAwakeningCollected = value;
            NotifyPropertyChanged();
        }
    }

    private bool _goronLullabyCollected = false;
    public bool GoronLullabyCollected
    {
        get => _goronLullabyCollected;
        set
        {
            _goronLullabyCollected = value;
            NotifyPropertyChanged();
        }
    }

    private bool _newWaveBossaNovaCollected = false;
    public bool NewWaveBossaNovaCollected
    {
        get => _newWaveBossaNovaCollected;
        set
        {
            _newWaveBossaNovaCollected = value;
            NotifyPropertyChanged();
        }
    }

    private bool _elegyOfEmptinessCollected = false;
    public bool ElegyOfEmptinessCollected
    {
        get => _elegyOfEmptinessCollected;
        set
        {
            _elegyOfEmptinessCollected = value;
            NotifyPropertyChanged();
        }
    }

    private bool _oathToOrderCollected = false;
    public bool OathToOrderCollected
    {
        get => _oathToOrderCollected;
        set
        {
            _oathToOrderCollected = value;
            NotifyPropertyChanged();
        }
    }
    
    #endregion
    
    
    #region Equipment

    private CollectedSword _sword = CollectedSword.None;
    public CollectedSword Sword
    {
        get => _sword;
        set
        {
            if (value is > CollectedSword.GildedSword or < CollectedSword.None) return;
            
            _sword = value;
            NotifyPropertyChanged();
            NotifyPropertyChanged(nameof(IsAnySwordCollected));
            NotifyPropertyChanged(nameof(IsKokiriSwordCollected));
            NotifyPropertyChanged(nameof(IsRazorSwordCollected));
            NotifyPropertyChanged(nameof(IsGildedSwordCollected));
        }
    }
    
    public bool IsAnySwordCollected => Sword != CollectedSword.None;
    public bool IsKokiriSwordCollected => Sword == CollectedSword.KokiriSword;
    public bool IsRazorSwordCollected => Sword == CollectedSword.RazorSword;
    public bool IsGildedSwordCollected => Sword == CollectedSword.GildedSword;
    
    
    private CollectedShield _shield = CollectedShield.None;
    public CollectedShield Shield
    {
        get => _shield;
        set
        {
            if (value is > CollectedShield.MirrorShield or < CollectedShield.None) return;
            
            _shield = value;
            NotifyPropertyChanged();
            NotifyPropertyChanged(nameof(IsAnyShieldCollected));
            NotifyPropertyChanged(nameof(IsHeroShieldCollected));
            NotifyPropertyChanged(nameof(IsMirrorShieldCollected));
        }
    }
    
    public bool IsAnyShieldCollected => Shield != CollectedShield.None;
    public bool IsHeroShieldCollected => Shield == CollectedShield.HeroShield;
    public bool IsMirrorShieldCollected => Shield == CollectedShield.MirrorShield;
    
    
    private CollectedQuiver _quiver = CollectedQuiver.None;
    public CollectedQuiver Quiver
    {
        get => _quiver;
        set
        {
            if (value is > CollectedQuiver.LargestQuiver or < CollectedQuiver.None) return;
            
            _quiver = value;
            NotifyPropertyChanged();
            NotifyPropertyChanged(nameof(IsAnyQuiverCollected));
            NotifyPropertyChanged(nameof(IsQuiverCollected));
            NotifyPropertyChanged(nameof(IsBigQuiverCollected));
            NotifyPropertyChanged(nameof(IsLargestQuiverCollected));
        }
    }
    
    public bool IsAnyQuiverCollected => Quiver != CollectedQuiver.None;
    public bool IsQuiverCollected => Quiver == CollectedQuiver.Quiver;
    public bool IsBigQuiverCollected => Quiver == CollectedQuiver.BigQuiver;
    public bool IsLargestQuiverCollected => Quiver == CollectedQuiver.LargestQuiver;
    
    
    private CollectedBombBag _bombBag = CollectedBombBag.None;
    public CollectedBombBag BombBag
    {
        get => _bombBag;
        set
        {
            if (value is > CollectedBombBag.LargestBombBag or < CollectedBombBag.None) return;
            
            _bombBag = value;
            NotifyPropertyChanged();
            NotifyPropertyChanged(nameof(IsAnyBombBagCollected));
            NotifyPropertyChanged(nameof(IsBombBagCollected));
            NotifyPropertyChanged(nameof(IsBigBombBagCollected));
            NotifyPropertyChanged(nameof(IsLargestBombBagCollected));
        }
    }
    
    public bool IsAnyBombBagCollected => BombBag != CollectedBombBag.None;    
    public bool IsBombBagCollected => BombBag == CollectedBombBag.BombBag;
    public bool IsBigBombBagCollected => BombBag == CollectedBombBag.BigBombBag;
    public bool IsLargestBombBagCollected => BombBag == CollectedBombBag.LargestBombBag;
    
    #endregion
    
    #endregion
    
    
    #region Commands
    
    #region Important Items
    public BaseCommand CollectBombersNotebookCommand { get; set; }
    public BaseCommand UncollectBombersNotebookCommand { get; set; }
    
    public BaseCommand CollectHeartPieceCommand { get; set; }
    public BaseCommand UncollectHeartPieceCommand { get; set; }
    
    public BaseCommand CollectWalletCommand { get; set; }
    public BaseCommand UncollectWalletCommand { get; set; }
    
    public BaseCommand CollectMagicCommand { get; set; }
    public BaseCommand UncollectMagicCommand { get; set; }
    
    #endregion
    
    
    #region Remains
    
    public BaseCommand CollectOdolwaCommand { get; set; }
    public BaseCommand UncollectOdolwaCommand { get; set; }
    
    public BaseCommand CollectGohtCommand { get; set; }
    public BaseCommand UncollectGohtCommand { get; set; }
    
    public BaseCommand CollectGyorgCommand { get; set; }
    public BaseCommand UncollectGyorgCommand { get; set; }
    
    public BaseCommand CollectTwinmoldCommand { get; set; }
    public BaseCommand UncollectTwinmoldCommand { get; set; }
    
    #endregion
    
    
    #region Songs
    
    public BaseCommand CollectSongOfTimeCommand { get; set; }
    public BaseCommand UncollectSongOfTimeCommand { get; set; }
    
    public BaseCommand CollectSongOfHealingCommand { get; set; }
    public BaseCommand UncollectSongOfHealingCommand { get; set; }
    
    public BaseCommand CollectEponaSongCommand { get; set; }
    public BaseCommand UncollectEponaSongCommand { get; set; }
    
    public BaseCommand CollectSongOfSoaringCommand { get; set; }
    public BaseCommand UncollectSongOfSoaringCommand { get; set; }
    
    public BaseCommand CollectSongOfStormsCommand { get; set; }
    public BaseCommand UncollectSongOfStormsCommand { get; set; }
    
    public BaseCommand CollectSonataOfAwakeningCommand { get; set; }
    public BaseCommand UncollectSonataOfAwakeningCommand { get; set; }
    
    public BaseCommand CollectGoronLullabyCommand { get; set; }
    public BaseCommand UncollectGoronLullabyCommand { get; set; }
    
    public BaseCommand CollectNewWaveBossanovaCommand { get; set; }
    public BaseCommand UncollectNewWaveBossanovaCommand { get; set; }
    
    public BaseCommand CollectElegyOfEmptinessCommand { get; set; }
    public BaseCommand UncollectElegyOfEmptinessCommand { get; set; }
    
    public BaseCommand CollectOathToOrderCommand { get; set; }
    public BaseCommand UncollectOathToOrderCommand { get; set; }
    
    #endregion
    
    
    #region Equipment
    
    public BaseCommand CollectSwordCommand { get; set; }
    public BaseCommand UncollectSwordCommand { get; set; }
    
    public BaseCommand CollectShieldCommand { get; set; }
    public BaseCommand UncollectShieldCommand { get; set; }
    
    public BaseCommand CollectQuiverCommand { get; set; }
    public BaseCommand UncollectQuiverCommand { get; set; }
    
    public BaseCommand CollectBombBagCommand { get; set; }
    public BaseCommand UncollectBombBagCommand { get; set; }
    
    #endregion
    
    #endregion

    
    public QuestStatusPageViewmodel()
    {
        InitializeCommands();
        OnInitialize?.Invoke();
    }


    private void InitializeCommands()
    {
        CollectBombersNotebookCommand = new BaseCommand((sender) => BombersNotebookCollected = true);
        UncollectBombersNotebookCommand = new BaseCommand((sender) => BombersNotebookCollected = false);
        
        CollectHeartPieceCommand = new BaseCommand((sender) => CollectedHeartPieces++);
        UncollectHeartPieceCommand = new BaseCommand((sender) => CollectedHeartPieces--);
        
        CollectOdolwaCommand = new BaseCommand((sender) => OdolwaCollected = true);
        UncollectOdolwaCommand = new BaseCommand((sender) => OdolwaCollected = false);
        
        CollectGohtCommand = new BaseCommand((sender) => GohtCollected = true);
        UncollectGohtCommand = new BaseCommand((sender) => GohtCollected = false);
        
        CollectGyorgCommand = new BaseCommand((sender) => GyorgCollected = true);
        UncollectGyorgCommand = new BaseCommand((sender) => GyorgCollected = false);
        
        CollectTwinmoldCommand = new BaseCommand((sender) => TwinmoldCollected = true);
        UncollectTwinmoldCommand = new BaseCommand((sender) => TwinmoldCollected = false);
        
        CollectSongOfTimeCommand = new BaseCommand((sender) => SongOfTimeCollected = true);
        UncollectSongOfTimeCommand = new BaseCommand((sender) => SongOfTimeCollected = false);
        
        CollectSongOfHealingCommand = new BaseCommand((sender) => SongOfHealingCollected = true);
        UncollectSongOfHealingCommand = new BaseCommand((sender) => SongOfHealingCollected = false);
        
        CollectEponaSongCommand = new BaseCommand((sender) => EponasSongCollected = true);
        UncollectEponaSongCommand = new BaseCommand((sender) => EponasSongCollected = false);
        
        CollectSongOfSoaringCommand = new BaseCommand((sender) => SongOfSoaringCollected = true);
        UncollectSongOfSoaringCommand = new BaseCommand((sender) => SongOfSoaringCollected = false);
        
        CollectSongOfStormsCommand = new BaseCommand((sender) => SongOfStormsCollected = true);
        UncollectSongOfStormsCommand = new BaseCommand((sender) => SongOfStormsCollected = false);
        
        CollectSonataOfAwakeningCommand = new BaseCommand((sender) => SonataOfAwakeningCollected = true);
        UncollectSonataOfAwakeningCommand = new BaseCommand((sender) => SonataOfAwakeningCollected = false);
        
        CollectGoronLullabyCommand = new BaseCommand((sender) => GoronLullabyCollected = true);
        UncollectGoronLullabyCommand = new BaseCommand((sender) => GoronLullabyCollected = false);
        
        CollectNewWaveBossanovaCommand = new BaseCommand((sender) => NewWaveBossaNovaCollected = true);
        UncollectNewWaveBossanovaCommand = new BaseCommand((sender) => NewWaveBossaNovaCollected = false);
        
        CollectElegyOfEmptinessCommand = new BaseCommand((sender) => ElegyOfEmptinessCollected = true);
        UncollectElegyOfEmptinessCommand = new BaseCommand((sender) => ElegyOfEmptinessCollected = false);
        
        CollectOathToOrderCommand = new BaseCommand((sender) => OathToOrderCollected = true);
        UncollectOathToOrderCommand = new BaseCommand((sender) => OathToOrderCollected = false);
        
        CollectSwordCommand = new BaseCommand((sender) => Sword++);
        UncollectSwordCommand = new BaseCommand((sender) => Sword--);
        
        CollectShieldCommand = new BaseCommand((sender) => Shield++);
        UncollectShieldCommand = new BaseCommand((sender) => Shield--);
        
        CollectQuiverCommand = new BaseCommand((sender) => Quiver++);
        UncollectQuiverCommand = new BaseCommand((sender) => Quiver--);
        
        CollectBombBagCommand = new BaseCommand((sender) => BombBag++);
        UncollectBombBagCommand = new BaseCommand((sender) => BombBag--);
        
        CollectMagicCommand = new BaseCommand((sender) => Magic++);
        UncollectMagicCommand = new BaseCommand((sender) => Magic--);
        
        CollectWalletCommand = new BaseCommand((sender) => Wallet++);
        UncollectWalletCommand = new BaseCommand((sender) => Wallet--);
    }
}