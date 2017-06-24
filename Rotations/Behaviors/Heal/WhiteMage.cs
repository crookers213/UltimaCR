using System.Threading.Tasks;

namespace UltimaCR.Rotations
{
    public sealed partial class WhiteMage
    {
        public override async Task<bool> Heal()
        {
            if (await Tetragrammaton()) return true;
            if (await CureII()) return true;
            if (await Cure()) return true;
            return await Regen();
        }
    }
}