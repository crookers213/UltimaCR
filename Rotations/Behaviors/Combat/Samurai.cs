using System.Threading.Tasks;

namespace UltimaCR.Rotations
{
    public sealed partial class Samurai : Rotation
    {
        public override async Task<bool> Combat()
        {
            if (await MidareSetsugekka()) return true;
            if (await Kasha()) return true;
            if (await Shifu()) return true;
            if (await Gekko()) return true;
            if (await Jinpu()) return true;
            if (await Yukikaze()) return true;
            return await Hakaze();
        }

        public override async Task<bool> PVPRotation()
        {
            return false;
        }
    }
}