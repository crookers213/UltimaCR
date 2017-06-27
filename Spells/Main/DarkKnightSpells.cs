
namespace UltimaCR.Spells.Main
{
    public class DarkKnightSpells
    {
        private Role.TankSpells.Role _role;
        public Role.TankSpells.Role Role
        {
            get { return _role ?? (_role = new Role.TankSpells.Role()); }
        }

        private PVP.DarkKnightSpells.Pvp _pvp;
        public PVP.DarkKnightSpells.Pvp PvP
        {
            get { return _pvp ?? (_pvp = new PVP.DarkKnightSpells.Pvp()); }
        }

        private Spell _hardslash;
        public Spell HardSlash
        {
            get
            {
                return _hardslash ??
                       (_hardslash =
                           new Spell
                           {
                               Name = "Hard Slash",
                               ID = 3617,
                               Level = 1,
                               GCDType = GCDType.On,
                               SpellType = SpellType.Damage,
                               CastType = CastType.Target
                           });
            }
        }
        private Spell _spinningslash;
        public Spell SpinningSlash
        {
            get
            {
                return _spinningslash ??
                       (_spinningslash =
                           new Spell
                           {
                               Name = "Spinning Slash",
                               ID = 3619,
                               Level = 4,
                               GCDType = GCDType.On,
                               SpellType = SpellType.Damage,
                               CastType = CastType.Target
                           });
            }
        }
        private Spell _unleash;
        public Spell Unleash
        {
            get
            {
                return _unleash ??
                       (_unleash =
                           new Spell
                           {
                               Name = "Unleash",
                               ID = 3621,
                               Level = 6,
                               GCDType = GCDType.On,
                               SpellType = SpellType.AoE,
                               CastType = CastType.Self
                           });
            }
        }
        private Spell _syphonstrike;
        public Spell SyphonStrike
        {
            get
            {
                return _syphonstrike ??
                       (_syphonstrike =
                           new Spell
                           {
                               Name = "Syphon Strike",
                               ID = 3623,
                               Level = 10,
                               GCDType = GCDType.On,
                               SpellType = SpellType.Damage,
                               CastType = CastType.Target
                           });
            }
        }
        private Spell _unmend;
        public Spell Unmend
        {
            get
            {
                return _unmend ??
                       (_unmend =
                           new Spell
                           {
                               Name = "Unmend",
                               ID = 3624,
                               Level = 15,
                               GCDType = GCDType.On,
                               SpellType = SpellType.Damage,
                               CastType = CastType.Target
                           });
            }
        }
        private Spell _bloodweapon;
        public Spell BloodWeapon
        {
            get
            {
                return _bloodweapon ??
                       (_bloodweapon =
                           new Spell
                           {
                               Name = "Blood Weapon",
                               ID = 3625,
                               Level = 18,
                               GCDType = GCDType.Off,
                               SpellType = SpellType.Buff,
                               CastType = CastType.Self
                           });
            }
        }
        private Spell _powerslash;
        public Spell PowerSlash
        {
            get
            {
                return _powerslash ??
                       (_powerslash =
                           new Spell
                           {
                               Name = "Power Slash",
                               ID = 3627,
                               Level = 26,
                               GCDType = GCDType.On,
                               SpellType = SpellType.Damage,
                               CastType = CastType.Target
                           });
            }
        }
        private Spell _darkside;
        public Spell Darkside
        {
            get
            {
                return _darkside ??
                       (_darkside =
                           new Spell
                           {
                               Name = "Darkside",
                               ID = 3628,
                               Level = 30,
                               GCDType = GCDType.On,
                               SpellType = SpellType.Aura,
                               CastType = CastType.Self
                           });
            }
        }
        private Spell _grit;
        public Spell Grit
        {
            get
            {
                return _grit ??
                       (_grit =
                           new Spell
                           {
                               Name = "Grit",
                               ID = 3629,
                               Level = 30,
                               GCDType = GCDType.On,
                               SpellType = SpellType.Aura,
                               CastType = CastType.Self
                           });
            }
        }
        private Spell _bloodprice;
        public Spell BloodPrice
        {
            get
            {
                return _bloodprice ??
                       (_bloodprice =
                           new Spell
                           {
                               Name = "Blood Price",
                               ID = 3631,
                               Level = 35,
                               GCDType = GCDType.On,
                               SpellType = SpellType.Buff,
                               CastType = CastType.Self
                           });
            }
        }
        private Spell _souleater;
        public Spell Souleater
        {
            get
            {
                return _souleater ??
                       (_souleater =
                           new Spell
                           {
                               Name = "Souleater",
                               ID = 3632,
                               Level = 38,
                               GCDType = GCDType.On,
                               SpellType = SpellType.Damage,
                               CastType = CastType.Target
                           });
            }
        }
        private Spell _darkpassenger;
        public Spell DarkPassenger
        {
            get
            {
                return _darkpassenger ??
                       (_darkpassenger =
                           new Spell
                           {
                               Name = "Dark Passenger",
                               ID = 3633,
                               Level = 40,
                               GCDType = GCDType.Off,
                               SpellType = SpellType.AoE,
                               CastType = CastType.Target
                           });
            }
        }
        private Spell _darkmind;
        public Spell DarkMind
        {
            get
            {
                return _darkmind ??
                       (_darkmind =
                           new Spell
                           {
                               Name = "Dark Mind",
                               ID = 3634,
                               Level = 42,
                               GCDType = GCDType.On,
                               SpellType = SpellType.Defensive,
                               CastType = CastType.Self
                           });
            }
        }
        private Spell _darkarts;
        public Spell DarkArts
        {
            get
            {
                return _darkarts ??
                       (_darkarts =
                           new Spell
                           {
                               Name = "Dark Arts",
                               ID = 3635,
                               Level = 45,
                               GCDType = GCDType.On,
                               SpellType = SpellType.Buff,
                               CastType = CastType.Self
                           });
            }
        }
        private Spell _shadowwall;
        public Spell ShadowWall
        {
            get
            {
                return _shadowwall ??
                       (_shadowwall =
                           new Spell
                           {
                               Name = "Shadow Wall",
                               ID = 3636,
                               Level = 46,
                               GCDType = GCDType.On,
                               SpellType = SpellType.Defensive,
                               CastType = CastType.Self
                           });
            }
        }
        private Spell _livingdead;
        public Spell LivingDead
        {
            get
            {
                return _livingdead ??
                       (_livingdead =
                           new Spell
                           {
                               Name = "Living Dead",
                               ID = 3638,
                               Level = 50,
                               GCDType = GCDType.On,
                               SpellType = SpellType.Defensive,
                               CastType = CastType.Self
                           });
            }
        }
        private Spell _saltedearth;
        public Spell SaltedEarth
        {
            get
            {
                return _saltedearth ??
                       (_saltedearth =
                           new Spell
                           {
                               Name = "Salted Earth",
                               ID = 3639,
                               Level = 52,
                               GCDType = GCDType.Off,
                               SpellType = SpellType.DoT,
                               CastType = CastType.TargetLocation
                           });
            }
        }
        private Spell _plunge;
        public Spell Plunge
        {
            get
            {
                return _plunge ??
                       (_plunge =
                           new Spell
                           {
                               Name = "Plunge",
                               ID = 3640,
                               Level = 54,
                               GCDType = GCDType.Off,
                               SpellType = SpellType.Movement,
                               CastType = CastType.Target
                           });
            }
        }
        private Spell _abyssaldrain;
        public Spell AbyssalDrain
        {
            get
            {
                return _abyssaldrain ??
                       (_abyssaldrain =
                           new Spell
                           {
                               Name = "Abyssal Drain",
                               ID = 3641,
                               Level = 56,
                               GCDType = GCDType.On,
                               SpellType = SpellType.AoE,
                               CastType = CastType.Target
                           });
            }
        }
        private Spell _solesurvivor;
        public Spell SoleSurvivor
        {
            get
            {
                return _solesurvivor ??
                       (_solesurvivor =
                           new Spell
                           {
                               Name = "Sole Survivor",
                               ID = 3642,
                               Level = 58,
                               GCDType = GCDType.On,
                               SpellType = SpellType.Debuff,
                               CastType = CastType.Target
                           });
            }
        }
        private Spell _carveandsplit;
        public Spell CarveAndSplit
        {
            get
            {
                return _carveandsplit ??
                       (_carveandsplit =
                           new Spell
                           {
                               Name = "Carve and Split",
                               ID = 3643,
                               Level = 60,
                               GCDType = GCDType.Off,
                               SpellType = SpellType.Cooldown,
                               CastType = CastType.Target
                           });
            }
        }
    }
}