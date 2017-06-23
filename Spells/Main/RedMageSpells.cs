
namespace UltimaCR.Spells.Main
{
    public class RedMageSpells
    {
        private CrossClass.RedMageSpells.Crossclass _crossClass;
        public new CrossClass.RedMageSpells.Crossclass CrossClass
        {
            get { return _crossClass ?? (_crossClass = new CrossClass.RedMageSpells.Crossclass()); }
        }

        private PVP.RedMageSpells.Pvp _pvp;
        public new PVP.RedMageSpells.Pvp PvP
        {
            get { return _pvp ?? (_pvp = new PVP.RedMageSpells.Pvp()); }
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
                               Level = 1,
                               GCDType = GCDType.On,
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
                               Level = 1,
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
                               Level = 1,
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
                               Level = 1,
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
                               Level = 1,
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
                               Level = 1,
                               GCDType = GCDType.On,
                               SpellType = SpellType.Damage,
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
                               Level = 1,
                               GCDType = GCDType.On,
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
                               Level = 1,
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
                               Level = 1,
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
                               Level = 1,
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
                               Level = 1,
                               GCDType = GCDType.Off,
                               SpellType = SpellType.Damage,
                               CastType = CastType.Target
                           });
            }
        }
        private Spell _zwerchhau;
        public Spell Zwerchhau
        {
            get
            {
                return _zwerchhau ??
                       (_zwerchhau =
                           new Spell
                           {
                               Name = "Zwerchhau",
                               ID = 7512,
                               Level = 1,
                               GCDType = GCDType.Off,
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
                               Level = 1,
                               GCDType = GCDType.Off,
                               SpellType = SpellType.Buff,
                               CastType = CastType.Self
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
                               Level = 1,
                               GCDType = GCDType.On,
                               SpellType = SpellType.Heal,
                               CastType = CastType.Target
                           });
            }
        }
    }
}