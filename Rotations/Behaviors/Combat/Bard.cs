using System.Threading.Tasks;

namespace UltimaCR.Rotations
{
    public sealed partial class Bard : Rotation
    {
        public override async Task<bool> Combat()
        {
            if (Ultima.UltSettings.SmartTarget)
            {
                if (await StraightShot()) return true;
                if (await IronJaws()) return true;
                if (await Windbite()) return true;
                if (await VenomousBite()) return true;
                if (await RefulgentArrow()) return true;
                if (await EmpyrealArrow()) return true;
                if (await QuickNock()) return true;
                if (await RainOfDeath()) return true;
                return await HeavyShot();
            }
            if (Ultima.UltSettings.SingleTarget)
            {
                if (await StraightShot()) return true;
                if (await IronJaws()) return true;
                if (await Windbite()) return true;
                if (await VenomousBite()) return true;
                if (await RefulgentArrow()) return true;
                if (await EmpyrealArrow()) return true;
                return await HeavyShot();
            }
            if (Ultima.UltSettings.MultiTarget)
            {
                if (await StraightShot()) return true;
                if (await QuickNock()) return true;
                return await RainOfDeath();
            }
            return false;
        }

        public override async Task<bool> PVPRotation()
        {
            return false;
        }
    }
}