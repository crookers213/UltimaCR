
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
                                   SpellType = SpellType.Heal,
                                   CastType = CastType.Self
                               });
                }
            }
        }
    }
}