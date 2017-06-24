using System.Threading.Tasks;

namespace UltimaCR.Rotations
{
    public sealed partial class Monk
    {
        public override async Task<bool> CombatBuff()
        {
            if (await Ultima.SummonChocobo()) return true;
            if (await ShoulderTackle()) return true;
            if (await ElixirField()) return true;
            if (await HowlingFist()) return true;
            if (await SteelPeak()) return true;
            if (await ForbiddenChakra()) return true;
            return await Haymaker();
        }
    }
}