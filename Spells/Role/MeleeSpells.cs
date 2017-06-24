
namespace UltimaCR.Spells.Role
{
    public class MeleeSpells
    {
        public class Role
        {
            private Spell _secondwind;
            public Spell SecondWind
            {
                get
                {
                    return _secondwind ??
                           (_secondwind =
                               new Spell
                               {
                                   Name = "SecondWind",
                                   ID = 7541,
                                   Level = 8,
                                   GCDType = GCDType.Off,
                                   SpellType = SpellType.Heal,
                                   CastType = CastType.Self
                               });
                }
            }
            private Spell _armslength;
            public Spell ArmsLength
            {
                get
                {
                    return _armslength ??
                           (_armslength =
                               new Spell
                               {
                                   Name = "Arm's Length",
                                   ID = 7548,
                                   Level = 12,
                                   GCDType = GCDType.Off,
                                   SpellType = SpellType.Buff,
                                   CastType = CastType.Self
                               });
                }
            }
            private Spell _legsweep;
            public Spell LegSweep
            {
                get
                {
                    return _legsweep ??
                           (_legsweep =
                               new Spell
                               {
                                   Name = "Leg Sweep",
                                   ID = 7863,
                                   Level = 16,
                                   GCDType = GCDType.Off,
                                   SpellType = SpellType.Interrupt,
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
            private Spell _invigorate;
            public Spell Invigorate
            {
                get
                {
                    return _invigorate ??
                           (_invigorate =
                               new Spell
                               {
                                   Name = "Invigorate",
                                   ID = 7544,
                                   Level = 24,
                                   GCDType = GCDType.Off,
                                   SpellType = SpellType.Buff,
                                   CastType = CastType.Self
                               });
                }
            }
            private Spell _bloodbath;
            public Spell Bloodbath
            {
                get
                {
                    return _bloodbath ??
                           (_bloodbath =
                               new Spell
                               {
                                   Name = "Bloodbath",
                                   ID = 7542,
                                   Level = 32,
                                   GCDType = GCDType.Off,
                                   SpellType = SpellType.Buff,
                                   CastType = CastType.Self
                               });
                }
            }
            private Spell _goad;
            public Spell Goad
            {
                get
                {
                    return _goad ??
                           (_goad =
                               new Spell
                               {
                                   Name = "Goad",
                                   ID = 7543,
                                   Level = 36,
                                   GCDType = GCDType.Off,
                                   SpellType = SpellType.Defensive,
                                   CastType = CastType.Target
                               });
                }
            }
            private Spell _feint;
            public Spell Feint
            {
                get
                {
                    return _feint ??
                           (_feint =
                               new Spell
                               {
                                   Name = "Feint",
                                   ID = 7549,
                                   Level = 40,
                                   GCDType = GCDType.Off,
                                   SpellType = SpellType.Debuff,
                                   CastType = CastType.Target
                               });
                }
            }
            private Spell _crutch;
            public Spell Crutch
            {
                get
                {
                    return _crutch ??
                           (_crutch =
                               new Spell
                               {
                                   Name = "Crutch",
                                   ID = 7547,
                                   Level = 44,
                                   GCDType = GCDType.Off,
                                   SpellType = SpellType.Defensive,
                                   CastType = CastType.Target
                               });
                }
            }
            private Spell _truenorth;
            public Spell TrueNorth
            {
                get
                {
                    return _truenorth ??
                           (_truenorth =
                               new Spell
                               {
                                   Name = "True North",
                                   ID = 7546,
                                   Level = 48,
                                   GCDType = GCDType.Off,
                                   SpellType = SpellType.Buff,
                                   CastType = CastType.Self
                               });
                }
            }
        }
    }
}