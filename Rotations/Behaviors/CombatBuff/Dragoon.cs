using System.Threading.Tasks;

namespace UltimaCR.Rotations
{
    public sealed partial class Dragoon
    {
        public override async Task<bool> CombatBuff()
        {
            if (await Ultima.SummonChocobo()) return true;
            if (await BloodOfTheDragon()) return true;
            if (await BattleLitany()) return true;
            if (await PowerSurge()) return true;
            if (await LegSweep()) return true;
            if (await Geirskogul()) return true;
            if (await Jump()) return true;
            if (await DragonfireDive()) return true;
            return await SpineshatterDive();
        }
    }
}