using System.Threading.Tasks;

namespace UltimaCR.Rotations
{
    public sealed partial class Archer
    {
        public override async Task<bool> CombatBuff()
        {
            if (await Ultima.SummonChocobo()) return true;
            if (await Barrage()) return true;
            if (await BluntArrow()) return true;
            if (await MiserysEnd()) return true;
            return await Bloodletter();
        }
    }
}