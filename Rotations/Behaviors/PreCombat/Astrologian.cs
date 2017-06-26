﻿using System.Threading.Tasks;

namespace UltimaCR.Rotations
{
    public sealed partial class Astrologian
    {
        public override async Task<bool> PreCombatBuff()
        {
            if (await Ultima.SummonChocobo()) return true;
            if (await DiurnalSect()) return true;
            return await Protect();
        }
    }
}