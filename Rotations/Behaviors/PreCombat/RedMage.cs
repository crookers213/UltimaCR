using System.Threading.Tasks;

namespace UltimaCR.Rotations
{
    public sealed partial class RedMage
    {
        public override async Task<bool> PreCombatBuff()
        {
            return await Ultima.SummonChocobo();
        }
    }
}