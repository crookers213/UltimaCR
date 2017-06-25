using System;
using System.Threading.Tasks;

namespace UltimaCR.Rotations
{
    public sealed partial class Bard
    {
        private static DateTime t = new DateTime(1970, 1, 1);

        public override async Task<bool> CombatBuff()
        {
            if (await Ultima.SummonChocobo()) return true;
            if (await Songs(t))
            {
                t = DateTime.Now;
                return true;
            }
            //if (await Barrage()) return true;
            if (await Sidewinder()) return true;
            if (await PitchPerfect()) return true;
            if (await MiserysEnd()) return true;
            if (await RainOfDeath()) return true;
            return await Bloodletter();
        }
    }
}