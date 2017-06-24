
namespace UltimaCR.Spells.Role
{
    public class HealerSpells
    {
        public class Role
        {
            private Spell _clericstance;
            public Spell ClericStance
            {
                get
                {
                    return _clericstance ??
                           (_clericstance =
                               new Spell
                               {
                                   Name = "Cleric Stance",
                                   ID = 7567,
                                   Level = 8,
                                   GCDType = GCDType.Off,
                                   SpellType = SpellType.Buff,
                                   CastType = CastType.Self
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
            private Spell _protect;
            public Spell Protect
            {
                get
                {
                    return _protect ??
                           (_protect =
                               new Spell
                               {
                                   Name = "Protect",
                                   ID = 7572,
                                   Level = 16,
                                   GCDType = GCDType.On,
                                   SpellType = SpellType.Defensive,
                                   CastType = CastType.Target
                               });
                }
            }
            private Spell _esuna;
            public Spell Esuna
            {
                get
                {
                    return _esuna ??
                           (_esuna =
                               new Spell
                               {
                                   Name = "Esuna",
                                   ID = 7568,
                                   Level = 20,
                                   GCDType = GCDType.On,
                                   SpellType = SpellType.Defensive,
                                   CastType = CastType.Target
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
            private Spell _eyeforaneye;
            public Spell EyeForAnEye
            {
                get
                {
                    return _eyeforaneye ??
                           (_eyeforaneye =
                               new Spell
                               {
                                   Name = "Eye for an Eye",
                                   ID = 7569,
                                   Level = 36,
                                   GCDType = GCDType.Off,
                                   SpellType = SpellType.Defensive,
                                   CastType = CastType.Target
                               });
                }
            }
            private Spell _largesse;
            public Spell Largesse
            {
                get
                {
                    return _largesse ??
                           (_largesse =
                               new Spell
                               {
                                   Name = "Largesse",
                                   ID = 7570,
                                   Level = 40,
                                   GCDType = GCDType.Off,
                                   SpellType = SpellType.Buff,
                                   CastType = CastType.Self
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
            private Spell _rescue;
            public Spell Rescue
            {
                get
                {
                    return _rescue ??
                           (_rescue =
                               new Spell
                               {
                                   Name = "Rescue",
                                   ID = 7571,
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