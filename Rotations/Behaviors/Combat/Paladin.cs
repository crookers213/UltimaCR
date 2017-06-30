using System.Threading.Tasks;

namespace UltimaCR.Rotations
{
    public sealed partial class Paladin : Rotation
    {
        public override async Task<bool> Combat()
        {
            if (Ultima.UltSettings.SmartTarget)
            {
                if (await TotalEclipse()) return true;
                if (await Flash()) return true;
                if (await GoringBlade()) return true;
                if (await RoyalAuthority()) return true;
                if (await RiotBlade()) return true;
                if (await RageOfHalone()) return true;
                if (await SavageBlade()) return true;
                return await FastBlade();
            }
            if (Ultima.UltSettings.SingleTarget)
            {
                if (await GoringBlade()) return true;
                if (await RoyalAuthority()) return true;
                if (await RiotBlade()) return true;
                if (await RageOfHalone()) return true;
                if (await SavageBlade()) return true;
                return await FastBlade();
            }
            if (Ultima.UltSettings.MultiTarget)
            {
                if (await TotalEclipse()) return true;
                return await Flash();
            }
            return false;
        }

        public override async Task<bool> PVPRotation()
        {
            return false;
        }
    }
}