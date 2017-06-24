
namespace UltimaCR.Spells.Main
{
    public class WhiteMageSpells : ConjurerSpells
    {
        private Role.HealerSpells.Role _role;
        public new Role.HealerSpells.Role Role
        {
            get { return _role ?? (_role = new Role.HealerSpells.Role()); }
        }

        private PVP.WhiteMageSpells.Pvp _pvp;
        public new PVP.WhiteMageSpells.Pvp PvP
        {
            get { return _pvp ?? (_pvp = new PVP.WhiteMageSpells.Pvp()); }
        }

        private Spell _presenceofmind;
        public Spell PresenceOfMind
        {
            get
            {
                return _presenceofmind ??
                       (_presenceofmind =
                           new Spell
                           {
                               Name = "Presence of Mind",
                               ID = 136,
                               Level = 30,
                               GCDType = GCDType.On,
                               SpellType = SpellType.Buff,
                               CastType = CastType.Self
                           });
            }
        }
        private Spell _regen;
        public Spell Regen
        {
            get
            {
                return _regen ??
                       (_regen =
                           new Spell
                           {
                               Name = "Regen",
                               ID = 137,
                               Level = 35,
                               GCDType = GCDType.On,
                               SpellType = SpellType.Heal,
                               CastType = CastType.Target
                           });
            }
        }
        private Spell _cureiii;
        public Spell CureIII
        {
            get
            {
                return _cureiii ??
                       (_cureiii =
                           new Spell
                           {
                               Name = "Cure III",
                               ID = 131,
                               Level = 40,
                               GCDType = GCDType.On,
                               SpellType = SpellType.Heal,
                               CastType = CastType.Target
                           });
            }
        }
        private Spell _holy;
        public Spell Holy
        {
            get
            {
                return _holy ??
                       (_holy =
                           new Spell
                           {
                               Name = "Holy",
                               ID = 139,
                               Level = 45,
                               GCDType = GCDType.On,
                               SpellType = SpellType.AoE,
                               CastType = CastType.Self
                           });
            }
        }
        private Spell _benediction;
        public Spell Benediction
        {
            get
            {
                return _benediction ??
                       (_benediction =
                           new Spell
                           {
                               Name = "Benediction",
                               ID = 140,
                               Level = 50,
                               GCDType = GCDType.On,
                               SpellType = SpellType.Heal,
                               CastType = CastType.Target
                           });
            }
        }
        private Spell _asylum;
        public Spell Asylum
        {
            get
            {
                return _asylum ??
                       (_asylum =
                           new Spell
                           {
                               Name = "Asylum",
                               ID = 3569,
                               Level = 52,
                               GCDType = GCDType.On,
                               SpellType = SpellType.Heal,
                               CastType = CastType.TargetLocation
                           });
            }
        }
        private Spell _stoneIII;
        public Spell StoneIII
        {
            get
            {
                return _stoneIII ??
                       (_stoneIII =
                           new Spell
                           {
                               Name = "Stone III",
                               ID = 3568,
                               Level = 54,
                               GCDType = GCDType.On,
                               SpellType = SpellType.Damage,
                               CastType = CastType.Target
                           });
            }
        }
        private Spell _assize;
        public Spell Assize
        {
            get
            {
                return _assize ??
                       (_assize =
                           new Spell
                           {
                               Name = "Assize",
                               ID = 3571,
                               Level = 56,
                               GCDType = GCDType.On,
                               SpellType = SpellType.Heal,
                               CastType = CastType.Self
                           });
            }
        }
        private Spell _aeroIII;
        public Spell AeroIII
        {
            get
            {
                return _aeroIII ??
                       (_aeroIII =
                           new Spell
                           {
                               Name = "Aero III",
                               ID = 3572,
                               Level = 58,
                               GCDType = GCDType.On,
                               SpellType = SpellType.DoT,
                               CastType = CastType.Target
                           });
            }
        }
        private Spell _tetragrammaton;
        public Spell Tetragrammaton
        {
            get
            {
                return _tetragrammaton ??
                       (_tetragrammaton =
                           new Spell
                           {
                               Name = "Tetragrammaton",
                               ID = 3570,
                               Level = 60,
                               GCDType = GCDType.On,
                               SpellType = SpellType.Heal,
                               CastType = CastType.Target
                           });
            }
        }
        private Spell _thinair;
        public Spell ThinAir
        {
            get
            {
                return _thinair ??
                       (_thinair =
                           new Spell
                           {
                               Name = "Thin Air",
                               ID = 7430,
                               Level = 62,
                               GCDType = GCDType.On,
                               SpellType = SpellType.Buff,
                               CastType = CastType.Self
                           });
            }
        }
        private Spell _stoneiv;
        public Spell StoneIV
        {
            get
            {
                return _stoneiv ??
                       (_stoneiv =
                           new Spell
                           {
                               Name = "Stone IV",
                               ID = 7431,
                               Level = 64,
                               GCDType = GCDType.On,
                               SpellType = SpellType.Damage,
                               CastType = CastType.Target
                           });
            }
        }
        private Spell _divinebenison;
        public Spell DivineBenison
        {
            get
            {
                return _divinebenison ??
                       (_divinebenison =
                           new Spell
                           {
                               Name = "Divine Benison",
                               ID = 7432,
                               Level = 66,
                               GCDType = GCDType.On,
                               SpellType = SpellType.Defensive,
                               CastType = CastType.Target
                           });
            }
        }
        private Spell _plenaryindulgence;
        public Spell PlenaryIndulgence
        {
            get
            {
                return _plenaryindulgence ??
                       (_plenaryindulgence =
                           new Spell
                           {
                               Name = "Plenary Indulgence",
                               ID = 7433,
                               Level = 70,
                               GCDType = GCDType.On,
                               SpellType = SpellType.Heal,
                               CastType = CastType.Self
                           });
            }
        }
    }
}