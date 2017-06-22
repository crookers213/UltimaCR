using System.Threading.Tasks;

namespace UltimaCR.Rotations
{
    public sealed partial class Samurai
    {
        public override async Task<bool> CombatBuff()
        {
            if (await HissatsuKaiten()) return true;
            if (await HissatsuShinten()) return true;
            return await Ageha();
        }
    }
}