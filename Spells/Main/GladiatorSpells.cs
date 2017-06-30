
namespace UltimaCR.Spells.Main
{
    public class GladiatorSpells
    {
        private Role.TankSpells.Role _role;
        public Role.TankSpells.Role Role
        {
            get { return _role ?? (_role = new Role.TankSpells.Role()); }
        }

        private PVP.GladiatorSpells.Pvp _pvp;
        public PVP.GladiatorSpells.Pvp PvP
        {
            get { return _pvp ?? (_pvp = new PVP.GladiatorSpells.Pvp()); }
        }

        private Spell _fastblade;
        public Spell FastBlade
        {
            get
            {
                return _fastblade ??
                       (_fastblade =
                           new Spell
                           {
                               Name = "Fast Blade",
                               ID = 9,
                               Level = 1,
                               GCDType = GCDType.On,
                               SpellType = SpellType.Damage,
                               CastType = CastType.Target
                           });
            }
        }
        private Spell _fightorflight;
        public Spell FightOrFlight
        {
            get
            {
                return _fightorflight ??
                       (_fightorflight =
                           new Spell
                           {
                               Name = "Fight or Flight",
                               ID = 20,
                               Level = 2,
                               GCDType = GCDType.Off,
                               SpellType = SpellType.Buff,
                               CastType = CastType.Self
                           });
            }
        }
        private Spell _savageblade;
        public Spell SavageBlade
        {
            get
            {
                return _savageblade ??
                       (_savageblade =
                           new Spell
                           {
                               Name = "Savage Blade",
                               ID = 11,
                               Level = 4,
                               GCDType = GCDType.On,
                               SpellType = SpellType.Damage,
                               CastType = CastType.Target
                           });
            }
        }
        private Spell _flash;
        public Spell Flash
        {
            get
            {
                return _flash ??
                       (_flash =
                           new Spell
                           {
                               Name = "Flash",
                               ID = 14,
                               Level = 6,
                               GCDType = GCDType.On,
                               SpellType = SpellType.AoE,
                               CastType = CastType.Self
                           });
            }
        }
        private Spell _riotblade;
        public Spell RiotBlade
        {
            get
            {
                return _riotblade ??
                       (_riotblade =
                           new Spell
                           {
                               Name = "Riot Blade",
                               ID = 15,
                               Level = 10,
                               GCDType = GCDType.On,
                               SpellType = SpellType.Damage,
                               CastType = CastType.Target
                           });
            }
        }
        private Spell _shieldlob;
        public Spell ShieldLob
        {
            get
            {
                return _shieldlob ??
                       (_shieldlob =
                           new Spell
                           {
                               Name = "Shield Lob",
                               ID = 24,
                               Level = 15,
                               GCDType = GCDType.On,
                               SpellType = SpellType.Damage,
                               CastType = CastType.Target
                           });
            }
        }
        private Spell _shieldbash;
        public Spell ShieldBash
        {
            get
            {
                return _shieldbash ??
                       (_shieldbash =
                           new Spell
                           {
                               Name = "Shield Bash",
                               ID = 16,
                               Level = 18,
                               GCDType = GCDType.On,
                               SpellType = SpellType.Interrupt,
                               CastType = CastType.Target
                           });
            }
        }
        private Spell _rageofhalone;
        public Spell RageOfHalone
        {
            get
            {
                return _rageofhalone ??
                       (_rageofhalone =
                           new Spell
                           {
                               Name = "Rage of Halone",
                               ID = 21,
                               Level = 26,
                               GCDType = GCDType.On,
                               SpellType = SpellType.Damage,
                               CastType = CastType.Target
                           });
            }
        }
        private Spell _shieldswipe;
        public Spell ShieldSwipe
        {
            get
            {
                return _shieldswipe ??
                       (_shieldswipe =
                           new Spell
                           {
                               Name = "Shield Swipe",
                               ID = 25,
                               Level = 30,
                               GCDType = GCDType.Off,
                               SpellType = SpellType.Damage,
                               CastType = CastType.Target
                           });
            }
        }
        private Spell _sentinel;
        public Spell Sentinel
        {
            get
            {
                return _sentinel ??
                       (_sentinel =
                           new Spell
                           {
                               Name = "Sentinel",
                               ID = 17,
                               Level = 38,
                               GCDType = GCDType.On,
                               SpellType = SpellType.Defensive,
                               CastType = CastType.Self
                           });
            }
        }
        private Spell _temperedwill;
        public Spell TemperedWill
        {
            get
            {
                return _temperedwill ??
                       (_temperedwill =
                           new Spell
                           {
                               Name = "TemperedWill",
                               ID = 19,
                               Level = 42,
                               GCDType = GCDType.On,
                               SpellType = SpellType.Defensive,
                               CastType = CastType.Self
                           });
            }
        }
        private Spell _bulwark;
        public Spell Bulwark
        {
            get
            {
                return _bulwark ??
                       (_bulwark =
                           new Spell
                           {
                               Name = "Bulwark",
                               ID = 22,
                               Level = 46,
                               GCDType = GCDType.On,
                               SpellType = SpellType.Defensive,
                               CastType = CastType.Self
                           });
            }
        }
        private Spell _circleofscorn;
        public Spell CircleOfScorn
        {
            get
            {
                return _circleofscorn ??
                       (_circleofscorn =
                           new Spell
                           {
                               Name = "Circle of Scorn",
                               ID = 23,
                               Level = 50,
                               GCDType = GCDType.Off,
                               SpellType = SpellType.Cooldown,
                               CastType = CastType.Self
                           });
            }
        }
    }
}