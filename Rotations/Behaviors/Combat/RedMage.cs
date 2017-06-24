using System.Threading.Tasks;

namespace UltimaCR.Rotations
{
    public sealed partial class RedMage : Rotation
    {
        public override async Task<bool> Combat()
        {
            if (Ultima.UltSettings.SmartTarget)
            {
                if (await EnchantedMoulinet()) return true;
                if (await Scatter()) return true;
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
            if (Ultima.UltSettings.SingleTarget)
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
            if (Ultima.UltSettings.MultiTarget)
            {
                if (await EnchantedMoulinet()) return true;
                return await Scatter();
            }
            return false;
        }

        public override async Task<bool> PVPRotation()
        {
            return false;
        }
    }
}