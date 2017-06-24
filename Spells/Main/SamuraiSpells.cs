
namespace UltimaCR.Spells.Main
{
    public class SamuraiSpells
    {
        private Role.MeleeSpells.Role _role;
        public Role.MeleeSpells.Role Role
        {
            get { return _role ?? (_role = new Role.MeleeSpells.Role()); }
        }

        private PVP.SamuraiSpells.PVP _pvp;
        public PVP.SamuraiSpells.PVP PVP
        {
            get { return _pvp ?? (_pvp = new PVP.SamuraiSpells.PVP()); }
        }

        private Spell _hakaze;
        public Spell Hakaze
        {
            get
            {
                return _hakaze ??
                       (_hakaze =
                           new Spell
                           {
                               Name = "Hakaze",
                               ID = 7477,
                               Level = 1,
                               GCDType = GCDType.On,
                               SpellType = SpellType.Damage,
                               CastType = CastType.Target
                           });
            }
        }
        private Spell _jinpu;
        public Spell Jinpu
        {
            get
            {
                return _jinpu ??
                       (_jinpu =
                           new Spell
                           {
                               Name = "Jinpu",
                               ID = 7478,
                               Level = 4,
                               GCDType = GCDType.On,
                               SpellType = SpellType.Damage,
                               CastType = CastType.Target
                           });
            }
        }
        private Spell _ageha;
        public Spell Ageha
        {
            get
            {
                return _ageha ??
                       (_ageha =
                           new Spell
                           {
                               Name = "Ageha",
                               ID = 7500,
                               Level = 10,
                               GCDType = GCDType.Off,
                               SpellType = SpellType.Cooldown,
                               CastType = CastType.Target
                           });
            }
        }
        private Spell _enpi;
        public Spell Enpi
        {
            get
            {
                return _enpi ??
                       (_enpi =
                           new Spell
                           {
                               Name = "Enpi",
                               ID = 7486,
                               Level = 15,
                               GCDType = GCDType.On,
                               SpellType = SpellType.Damage,
                               CastType = CastType.Target
                           });
            }
        }
        private Spell _shifu;
        public Spell Shifu
        {
            get
            {
                return _shifu ??
                       (_shifu =
                           new Spell
                           {
                               Name = "Shifu",
                               ID = 7479,
                               Level = 18,
                               GCDType = GCDType.On,
                               SpellType = SpellType.Damage,
                               CastType = CastType.Target
                           });
            }
        }
        private Spell _fuga;
        public Spell Fuga
        {
            get
            {
                return _fuga ??
                       (_fuga =
                           new Spell
                           {
                               Name = "Fuga",
                               ID = 7483,
                               Level = 26,
                               GCDType = GCDType.On,
                               SpellType = SpellType.AoE,
                               CastType = CastType.Target
                           });
            }
        }
        private Spell _gekko;
        public Spell Gekko
        {
            get
            {
                return _gekko ??
                       (_gekko =
                           new Spell
                           {
                               Name = "Gekko",
                               ID = 7481,
                               Level = 30,
                               GCDType = GCDType.On,
                               SpellType = SpellType.Behind,
                               CastType = CastType.Target
                           });
            }
        }
        private Spell _higanbana;
        public Spell Higanbana
        {
            get
            {
                return _higanbana ??
                       (_higanbana =
                           new Spell
                           {
                               Name = "Higanbana",
                               ID = 7489,
                               Level = 30,
                               GCDType = GCDType.On,
                               SpellType = SpellType.DoT,
                               CastType = CastType.Target
                           });
            }
        }
        private Spell _tenkagoken;
        public Spell TenkaGoken
        {
            get
            {
                return _tenkagoken ??
                       (_tenkagoken =
                           new Spell
                           {
                               Name = "Tenka Goken",
                               ID = 7488,
                               Level = 30,
                               GCDType = GCDType.On,
                               SpellType = SpellType.AoE,
                               CastType = CastType.Target
                           });
            }
        }
        private Spell _midaresetsugekka;
        public Spell MidareSetsugekka
        {
            get
            {
                return _midaresetsugekka ??
                       (_midaresetsugekka =
                           new Spell
                           {
                               Name = "Midare Setsugekka",
                               ID = 7487,
                               Level = 30,
                               GCDType = GCDType.On,
                               SpellType = SpellType.Damage,
                               CastType = CastType.Target
                           });
            }
        }
        private Spell _mangetsu;
        public Spell Mangetsu
        {
            get
            {
                return _mangetsu ??
                       (_mangetsu =
                           new Spell
                           {
                               Name = "Mangetsu",
                               ID = 7484,
                               Level = 35,
                               GCDType = GCDType.On,
                               SpellType = SpellType.AoE,
                               CastType = CastType.Self
                           });
            }
        }
        private Spell _kasha;
        public Spell Kasha
        {
            get
            {
                return _kasha ??
                       (_kasha =
                           new Spell
                           {
                               Name = "Kasha",
                               ID = 7482,
                               Level = 40,
                               GCDType = GCDType.On,
                               SpellType = SpellType.Flank,
                               CastType = CastType.Target
                           });
            }
        }
        private Spell _oka;
        public Spell Oka
        {
            get
            {
                return _oka ??
                       (_oka =
                           new Spell
                           {
                               Name = "Oka",
                               ID = 7485,
                               Level = 45,
                               GCDType = GCDType.On,
                               SpellType = SpellType.AoE,
                               CastType = CastType.Self
                           });
            }
        }
        private Spell _yukikaze;
        public Spell Yukikaze
        {
            get
            {
                return _yukikaze ??
                       (_yukikaze =
                           new Spell
                           {
                               Name = "Yukikaze",
                               ID = 7480,
                               Level = 50,
                               GCDType = GCDType.On,
                               SpellType = SpellType.Damage,
                               CastType = CastType.Target
                           });
            }
        }
        private Spell _hissatsukaiten;
        public Spell HissatsuKaiten
        {
            get
            {
                return _hissatsukaiten ??
                       (_hissatsukaiten =
                           new Spell
                           {
                               Name = "Hissatsu: Kaiten",
                               ID = 7494,
                               Level = 52,
                               GCDType = GCDType.On,
                               SpellType = SpellType.Buff,
                               CastType = CastType.Self
                           });
            }
        }
        private Spell _hissatsushinten;
        public Spell HissatsuShinten
        {
            get
            {
                return _hissatsushinten ??
                       (_hissatsushinten =
                           new Spell
                           {
                               Name = "Hissatsu: Shinten",
                               ID = 7490,
                               Level = 62,
                               GCDType = GCDType.Off,
                               SpellType = SpellType.Damage,
                               CastType = CastType.Target
                           });
            }
        }
        private Spell _hissatsukyuten;
        public Spell HissatsuKyuten
        {
            get
            {
                return _hissatsukyuten ??
                       (_hissatsukyuten =
                           new Spell
                           {
                               Name = "Hissatsu: Kyuten",
                               ID = 7491,
                               Level = 64,
                               GCDType = GCDType.Off,
                               SpellType = SpellType.AoE,
                               CastType = CastType.Self
                           });
            }
        }
        private Spell _hagakure;
        public Spell Hagakure
        {
            get
            {
                return _hagakure ??
                       (_hagakure =
                           new Spell
                           {
                               Name = "Hagakure",
                               ID = 7495,
                               Level = 68,
                               GCDType = GCDType.On,
                               SpellType = SpellType.Buff,
                               CastType = CastType.Self
                           });
            }
        }
    }
}