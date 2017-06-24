
namespace UltimaCR.Spells.Role
{
    public class TankSpells
    {
        public class Role
        {
            private Spell _rampart;
            public Spell Rampart
            {
                get
                {
                    return _rampart ??
                           (_rampart =
                               new Spell
                               {
                                   Name = "Rampart",
                                   ID = 7531,
                                   Level = 8,
                                   GCDType = GCDType.Off,
                                   SpellType = SpellType.Defensive,
                                   CastType = CastType.Self
                               });
                }
            }
            private Spell _lowblow;
            public Spell LowBlow
            {
                get
                {
                    return _lowblow ??
                           (_lowblow =
                               new Spell
                               {
                                   Name = "Low Blow",
                                   ID = 7540,
                                   Level = 12,
                                   GCDType = GCDType.Off,
                                   SpellType = SpellType.Interrupt,
                                   CastType = CastType.Target
                               });
                }
            }
            private Spell _provoke;
            public Spell Provoke
            {
                get
                {
                    return _provoke ??
                           (_provoke =
                               new Spell
                               {
                                   Name = "Provoke",
                                   ID = 7533,
                                   Level = 16,
                                   GCDType = GCDType.Off,
                                   SpellType = SpellType.Debuff,
                                   CastType = CastType.Target
                               });
                }
            }
            private Spell _convalescence;
            public Spell Convalescence
            {
                get
                {
                    return _convalescence ??
                           (_convalescence =
                               new Spell
                               {
                                   Name = "Convalescence",
                                   ID = 7532,
                                   Level = 20,
                                   GCDType = GCDType.Off,
                                   SpellType = SpellType.Defensive,
                                   CastType = CastType.Self
                               });
                }
            }
            private Spell _anticipation;
            public Spell Anticipation
            {
                get
                {
                    return _anticipation ??
                           (_anticipation =
                               new Spell
                               {
                                   Name = "Anticipation",
                                   ID = 7536,
                                   Level = 24,
                                   GCDType = GCDType.Off,
                                   SpellType = SpellType.Defensive,
                                   CastType = CastType.Self
                               });
                }
            }
            private Spell _reprisal;
            public Spell Reprisal
            {
                get
                {
                    return _reprisal ??
                           (_reprisal =
                               new Spell
                               {
                                   Name = "Reprisal",
                                   ID = 7535,
                                   Level = 32,
                                   GCDType = GCDType.Off,
                                   SpellType = SpellType.Debuff,
                                   CastType = CastType.Target
                               });
                }
            }
            private Spell _awareness;
            public Spell Awareness
            {
                get
                {
                    return _awareness ??
                           (_awareness =
                               new Spell
                               {
                                   Name = "Awareness",
                                   ID = 7534,
                                   Level = 36,
                                   GCDType = GCDType.Off,
                                   SpellType = SpellType.Defensive,
                                   CastType = CastType.Self
                               });
                }
            }
            private Spell _interject;
            public Spell Interject
            {
                get
                {
                    return _interject ??
                           (_interject =
                               new Spell
                               {
                                   Name = "Interject",
                                   ID = 7538,
                                   Level = 40,
                                   GCDType = GCDType.Off,
                                   SpellType = SpellType.Interrupt,
                                   CastType = CastType.Target
                               });
                }
            }
            private Spell _ultimatum;
            public Spell Ultimatum
            {
                get
                {
                    return _ultimatum ??
                           (_ultimatum =
                               new Spell
                               {
                                   Name = "Ultimatum",
                                   ID = 7539,
                                   Level = 44,
                                   GCDType = GCDType.Off,
                                   SpellType = SpellType.AoE,
                                   CastType = CastType.Self
                               });
                }
            }
            private Spell _shirk;
            public Spell Shirk
            {
                get
                {
                    return _shirk ??
                           (_shirk =
                               new Spell
                               {
                                   Name = "Shirk",
                                   ID = 7537,
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