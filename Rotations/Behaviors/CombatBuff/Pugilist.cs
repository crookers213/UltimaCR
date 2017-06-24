using System.Threading.Tasks;

namespace UltimaCR.Rotations
{
    public sealed partial class Pugilist
    {
        public override async Task<bool> CombatBuff()
        {
            if (await Ultima.SummonChocobo()) return true;
            if (await HowlingFist()) return true;
            if (await SteelPeak()) return true;
            return await Haymaker();
        }
    }
}