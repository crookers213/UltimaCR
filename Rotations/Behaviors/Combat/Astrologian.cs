﻿using System.Threading.Tasks;

namespace UltimaCR.Rotations
{
    public sealed partial class Astrologian : Rotation
    {
        public override async Task<bool> Combat()
        {
            if (await Gravity()) return true;
            if (await CombustII()) return true;
            if (await Combust()) return true;
            if (await MaleficIII()) return true;
            if (await MaleficII()) return true;
            return await Malefic();
        }

        public override async Task<bool> PVPRotation()
        {
            return false;
        }
    }
}