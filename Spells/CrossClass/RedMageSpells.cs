
namespace UltimaCR.Spells.CrossClass
{
    public class RedMageSpells
    {
        public class Crossclass
        {
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
                                   Level = 26,
                                   GCDType = GCDType.On,
                                   SpellType = SpellType.Buff,
                                   CastType = CastType.Self
                               });
                }
            }
        }
    }
}