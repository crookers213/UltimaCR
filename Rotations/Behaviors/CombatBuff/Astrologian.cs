using System.Threading.Tasks;

namespace UltimaCR.Rotations
{
    public sealed partial class Astrologian
    {
        public override async Task<bool> CombatBuff()
        {
            if (await Ultima.SummonChocobo()) return true;
            if (await LucidDreaming()) return true;
            if (await RoyalRoad()) return true;
            if (await Redraw()) return true;
            if (await Undraw()) return true;
            if (await Spread()) return true;
            if (await Draw()) return true;
            return await Protect();
        }
    }
}