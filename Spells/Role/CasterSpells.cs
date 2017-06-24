
namespace UltimaCR.Spells.Role
{
    public class CasterSpells
    {
        public class Role
        {
            private Spell _addle;
            public Spell Addle
            {
                get
                {
                    return _addle ??
                           (_addle =
                               new Spell
                               {
                                   Name = "Addle",
                                   ID = 7560,
                                   Level = 8,
                                   GCDType = GCDType.Off,
                                   SpellType = SpellType.Debuff,
                                   CastType = CastType.Target
                               });
                }
            }
            private Spell _break;
            public Spell Break
            {
                get
                {
                    return _break ??
                           (_break =
                               new Spell
                               {
                                   Name = "Break",
                                   ID = 7558,
                                   Level = 12,
                                   GCDType = GCDType.On,
                                   SpellType = SpellType.Damage,
                                   CastType = CastType.Target
                               });
                }
            }
            private Spell _drain;
            public Spell Drain
            {
                get
                {
                    return _drain ??
                           (_drain =
                               new Spell
                               {
                                   Name = "Drain",
                                   ID = 7564,
                                   Level = 16,
                                   GCDType = GCDType.On,
                                   SpellType = SpellType.Damage,
                                   CastType = CastType.Target
                               });
                }
            }
            private Spell _diversion;
            public Spell Diversion
            {
                get
                {
                    return _diversion ??
                           (_diversion =
                               new Spell
                               {
                                   Name = "Diversion",
                                   ID = 7545,
                                   Level = 20,
                                   GCDType = GCDType.Off,
                                   SpellType = SpellType.Buff,
                                   CastType = CastType.Self
                               });
                }
            }
            private Spell _luciddreaming;
            public Spell LucidDreaming
            {
                get
                {
                    return _luciddreaming ??
                           (_luciddreaming =
                               new Spell
                               {
                                   Name = "Lucid Dreaming",
                                   ID = 7562,
                                   Level = 24,
                                   GCDType = GCDType.Off,
                                   SpellType = SpellType.Buff,
                                   CastType = CastType.Self
                               });
                }
            }
            private Spell _swiftcast;
            public Spell Swiftcast
            {
                get
                {
                    return _swiftcast ??
                           (_swiftcast =
                               new Spell
                               {
                                   Name = "Swiftcast",
                                   ID = 7561,
                                   Level = 32,
                                   GCDType = GCDType.Off,
                                   SpellType = SpellType.Buff,
                                   CastType = CastType.Self
                               });
                }
            }
            private Spell _manashift;
            public Spell ManaShift
            {
                get
                {
                    return _manashift ??
                           (_manashift =
                               new Spell
                               {
                                   Name = "Mana Shift",
                                   ID = 7565,
                                   Level = 36,
                                   GCDType = GCDType.Off,
                                   SpellType = SpellType.Defensive,
                                   CastType = CastType.Target
                               });
                }
            }
            private Spell _apocatastasis;
            public Spell Apocatastasis
            {
                get
                {
                    return _apocatastasis ??
                           (_apocatastasis =
                               new Spell
                               {
                                   Name = "Apocatastasis",
                                   ID = 7563,
                                   Level = 40,
                                   GCDType = GCDType.Off,
                                   SpellType = SpellType.Defensive,
                                   CastType = CastType.Target
                               });
                }
            }
            private Spell _surecast;
            public Spell Surecast
            {
                get
                {
                    return _surecast ??
                           (_surecast =
                               new Spell
                               {
                                   Name = "Surecast",
                                   ID = 7559,
                                   Level = 44,
                                   GCDType = GCDType.Off,
                                   SpellType = SpellType.Defensive,
                                   CastType = CastType.Self
                               });
                }
            }
            private Spell _erase;
            public Spell Erase
            {
                get
                {
                    return _erase ??
                           (_erase =
                               new Spell
                               {
                                   Name = "Erase",
                                   ID = 7566,
                                   Level = 48,
                                   GCDType = GCDType.Off,
                                   SpellType = SpellType.Defensive,
                                   CastType = CastType.Target
                               });
                }
            }
        }
    }
}