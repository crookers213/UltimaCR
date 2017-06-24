﻿using System.Threading.Tasks;

namespace UltimaCR.Rotations
{
    public sealed partial class Arcanist
    {
        public override async Task<bool> PreCombatBuff()
        {
            if (await Ultima.SummonChocobo()) return true;
            if (await SummonII()) return true;
            return await Summon();
        }
    }
}