﻿using System.Threading.Tasks;

namespace UltimaCR.Rotations
{
    public sealed partial class Gladiator : Rotation
    {
        public override async Task<bool> Combat()
        {
            if (await RageOfHalone()) return true;
            if (await SavageBlade()) return true;
            return await FastBlade();
        }

        public override async Task<bool> PVPRotation()
        {
            return false;
        }
    }
}