using System.Threading.Tasks;

namespace UltimaCR.Rotations
{
    public sealed partial class DarkKnight : Rotation
    {
        public override async Task<bool> Combat()
        {
            if (await Souleater()) return true;
            if (await SyphonStrike()) return true;
            if (await PowerSlash()) return true;
            if (await SpinningSlash()) return true;
            return await HardSlash();
        }

        public override async Task<bool> PVPRotation()
        {
            return false;
        }
    }
}