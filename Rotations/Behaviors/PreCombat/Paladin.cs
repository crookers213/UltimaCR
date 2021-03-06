﻿using System.Threading.Tasks;

namespace UltimaCR.Rotations
{
    public sealed partial class Paladin
    {
        public override async Task<bool> PreCombatBuff()
        {
            if (await Ultima.SummonChocobo()) return true;
            if (await ShieldOath()) return true;
            return await SwordOath();
        }
    }
}