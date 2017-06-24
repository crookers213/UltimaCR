using System.Threading.Tasks;

namespace UltimaCR.Rotations
{
    public sealed partial class RedMage
    {
        public override async Task<bool> CombatBuff()
        {
            if (await Ultima.SummonChocobo()) return true;
            if (await Fleche()) return true;
            if (await ContreSixte()) return true;
            if (await Acceleration()) return true;
            return await Swiftcast();
        }
    }
}