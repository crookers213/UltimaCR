﻿using System.Threading.Tasks;

namespace UltimaCR.Rotations
{
    public sealed partial class Thaumaturge
    {
        public override async Task<bool> CombatBuff()
        {
            if (await Ultima.SummonChocobo()) return true;
            return await Transpose();
        }
    }
}