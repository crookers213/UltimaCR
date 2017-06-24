
namespace UltimaCR.Spells.Main
{
    public class RedMageSpells
    {
        private CrossClass.RedMageSpells.Crossclass _crossClass;
        public CrossClass.RedMageSpells.Crossclass CrossClass
        {
            get { return _crossClass ?? (_crossClass = new CrossClass.RedMageSpells.Crossclass()); }
        }

        private PVP.RedMageSpells.Pvp _pvp;
        public PVP.RedMageSpells.Pvp PvP
        {
            get { return _pvp ?? (_pvp = new PVP.RedMageSpells.Pvp()); }
        }
        
        private Spell _riposte;
        public Spell Riposte
        {
            get
            {
                return _riposte ??
                       (_riposte =
                           new Spell
                           {
                               Name = "Riposte",
                               ID = 7504,
                               Level = 1,
                               GCDType = GCDType.On,
                               SpellType = SpellType.Damage,
                               CastType = CastType.Target
                           });
            }
        }
        private Spell _enchantedriposte;
        public Spell EnchantedRiposte
        {
            get
            {
                return _enchantedriposte ??
                       (_enchantedriposte =
                           new Spell
                           {
                               Name = "Enchanted Riposte",
                               ID = 7527,
                               Level = 1,
                               GCDType = GCDType.On,
                               SpellType = SpellType.Damage,
                               CastType = CastType.Target
                           });
            }
        }
        private Spell _jolt;
        public Spell Jolt
        {
            get
            {
                return _jolt ??
                       (_jolt =
                           new Spell
                           {
                               Name = "Jolt",
                               ID = 7503,
                               Level = 2,
                               GCDType = GCDType.On,
                               SpellType = SpellType.Damage,
                               CastType = CastType.Target
                           });
            }
        }
        private Spell _verthunder;
        public Spell Verthunder
        {
            get
            {
                return _verthunder ??
                       (_verthunder =
                           new Spell
                           {
                               Name = "Verthunder",
                               ID = 7505,
                               Level = 4,
                               GCDType = GCDType.On,
                               SpellType = SpellType.Damage,
                               CastType = CastType.Target
                           });
            }
        }
        private Spell _veraero;
        public Spell Veraero
        {
            get
            {
                return _veraero ??
                       (_veraero =
                           new Spell
                           {
                               Name = "Veraero",
                               ID = 7507,
                               Level = 10,
                               GCDType = GCDType.On,
                               SpellType = SpellType.Damage,
                               CastType = CastType.Target
                           });
            }
        }
        private Spell _scatter;
        public Spell Scatter
        {
            get
            {
                return _scatter ??
                       (_scatter =
                           new Spell
                           {
                               Name = "Scatter",
                               ID = 7509,
                               Level = 18,
                               GCDType = GCDType.On,
                               SpellType = SpellType.AoE,
                               CastType = CastType.Target
                           });
            }
        }
        private Spell _verfire;
        public Spell Verfire
        {
            get
            {
                return _verfire ??
                       (_verfire =
                           new Spell
                           {
                               Name = "Verfire",
                               ID = 7510,
                               Level = 26,
                               GCDType = GCDType.On,
                               SpellType = SpellType.Damage,
                               CastType = CastType.Target
                           });
            }
        }
        private Spell _verstone;
        public Spell Verstone
        {
            get
            {
                return _verstone ??
                       (_verstone =
                           new Spell
                           {
                               Name = "Verstone",
                               ID = 7511,
                               Level = 30,
                               GCDType = GCDType.On,
                               SpellType = SpellType.Damage,
                               CastType = CastType.Target
                           });
            }
        }
        private Spell _enchantedzwerchhau;
        public Spell EnchantedZwerchhau
        {
            get
            {
                return _enchantedzwerchhau ??
                       (_enchantedzwerchhau =
                           new Spell
                           {
                               Name = "Enchanted Zwerchhau",
                               ID = 7528,
                               Level = 35,
                               GCDType = GCDType.On,
                               SpellType = SpellType.Damage,
                               CastType = CastType.Target
                           });
            }
        }
        private Spell _fleche;
        public Spell Fleche
        {
            get
            {
                return _fleche ??
                       (_fleche =
                           new Spell
                           {
                               Name = "Fleche",
                               ID = 7517,
                               Level = 45,
                               GCDType = GCDType.Off,
                               SpellType = SpellType.Damage,
                               CastType = CastType.Target
                           });
            }
        }
        private Spell _enchantedredoublement;
        public Spell EnchantedRedoublement
        {
            get
            {
                return _enchantedredoublement ??
                       (_enchantedredoublement =
                           new Spell
                           {
                               Name = "Enchanted Redoublement",
                               ID = 7529,
                               Level = 50,
                               GCDType = GCDType.On,
                               SpellType = SpellType.Damage,
                               CastType = CastType.Target
                           });
            }
        }
        private Spell _acceleration;
        public Spell Acceleration
        {
            get
            {
                return _acceleration ??
                       (_acceleration =
                           new Spell
                           {
                               Name = "Acceleration",
                               ID = 7518,
                               Level = 50,
                               GCDType = GCDType.Off,
                               SpellType = SpellType.Buff,
                               CastType = CastType.Self
                           });
            }
        }
        private Spell _enchantedmoulinet;
        public Spell EnchantedMoulinet
        {
            get
            {
                return _enchantedmoulinet ??
                       (_enchantedmoulinet =
                           new Spell
                           {
                               Name = "Enchanted Moulinet",
                               ID = 7530,
                               Level = 52,
                               GCDType = GCDType.On,
                               SpellType = SpellType.AoE,
                               CastType = CastType.Target
                           });
            }
        }
        private Spell _vercure;
        public Spell Vercure
        {
            get
            {
                return _vercure ??
                       (_vercure =
                           new Spell
                           {
                               Name = "Vercure",
                               ID = 7514,
                               Level = 54,
                               GCDType = GCDType.On,
                               SpellType = SpellType.Heal,
                               CastType = CastType.Target
                           });
            }
        }
        private Spell _contresixte;
        public Spell ContreSixte
        {
            get
            {
                return _contresixte ??
                       (_contresixte =
                           new Spell
                           {
                               Name = "Contre Sixte",
                               ID = 7519,
                               Level = 56,
                               GCDType = GCDType.Off,
                               SpellType = SpellType.Damage,
                               CastType = CastType.Target
                           });
            }
        }
        private Spell _joltii;
        public Spell JoltII
        {
            get
            {
                return _joltii ??
                       (_joltii =
                           new Spell
                           {
                               Name = "Jolt II",
                               ID = 7524,
                               Level = 62,
                               GCDType = GCDType.On,
                               SpellType = SpellType.Damage,
                               CastType = CastType.Target
                           });
            }
        }
        private Spell _impact;
        public Spell Impact
        {
            get
            {
                return _impact ??
                       (_impact =
                           new Spell
                           {
                               Name = "Impact",
                               ID = 7522,
                               Level = 66,
                               GCDType = GCDType.On,
                               SpellType = SpellType.Damage,
                               CastType = CastType.Target
                           });
            }
        }
        private Spell _verflare;
        public Spell Verflare
        {
            get
            {
                return _verflare ??
                       (_verflare =
                           new Spell
                           {
                               Name = "Verflare",
                               ID = 7525,
                               Level = 68,
                               GCDType = GCDType.On,
                               SpellType = SpellType.Damage,
                               CastType = CastType.Target
                           });
            }
        }
        private Spell _verholy;
        public Spell Verholy
        {
            get
            {
                return _verholy ??
                       (_verholy =
                           new Spell
                           {
                               Name = "Verholy",
                               ID = 7526,
                               Level = 70,
                               GCDType = GCDType.On,
                               SpellType = SpellType.Damage,
                               CastType = CastType.Target
                           });
            }
        }
    }
}