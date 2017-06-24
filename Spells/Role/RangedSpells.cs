
namespace UltimaCR.Spells.Role
{
    public class RangedSpells
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
            private Spell _footgraze;
            public Spell FootGraze
            {
                get
                {
                    return _footgraze ??
                           (_footgraze =
                               new Spell
                               {
                                   Name = "Foot Graze",
                                   ID = 7553,
                                   Level = 12,
                                   GCDType = GCDType.Off,
                                   SpellType = SpellType.Debuff,
                                   CastType = CastType.Target
                               });
                }
            }
            /*private Spell _leggraze;
            public Spell LegGraze
            {
                get
                {
                    return _leggraze ??
                           (_leggraze =
                               new Spell
                               {
                                   Name = "Leg Graze",
                                   ID = ,
                                   Level = 16,
                                   GCDType = GCDType.Off,
                                   SpellType = SpellType.Debuff,
                                   CastType = CastType.Target
                               });
                }
            }*/
        }
    }
}