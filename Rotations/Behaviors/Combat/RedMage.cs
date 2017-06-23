using System.Threading.Tasks;

namespace UltimaCR.Rotations
{
    public sealed partial class RedMage : Rotation
    {
        public override async Task<bool> Combat()
        {
            if (await Verholy()) return true;
            if (await Verflare()) return true;
            if (await EnchantedRiposte()) return true;
            if (await EnchantedZwerchhau()) return true;
            if (await EnchantedRedoublement()) return true;
            if (await Veraero()) return true;
            if (await Verthunder()) return true;
            if (await Verstone()) return true;
            if (await Verfire()) return true;
            if (await Impact()) return true;
            if (await JoltII()) return true;
            if (await Riposte()) return true;
            return await Jolt();
        }

        public override async Task<bool> PVPRotation()
        {
            return false;
        }
    }
}