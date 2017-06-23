using System.Threading.Tasks;

namespace UltimaCR.Rotations
{
    public sealed partial class Samurai : Rotation
    {
        public override async Task<bool> Combat()
        {
            if (await Hagakure()) return true;
            if (await MidareSetsugekka()) return true;
            if (await Higanbana()) return true;
            if (await Kasha()) return true;
            if (await Gekko()) return true;
            if (await ShifuBuff()) return true;
            if (await JinpuBuff()) return true;
            if (await YukikazeDebuff()) return true;
            if (await Shifu()) return true;
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