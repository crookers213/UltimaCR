﻿using System.Threading.Tasks;

namespace UltimaCR.Rotations
{
    public sealed partial class Samurai
    {
        public override async Task<bool> CombatBuff()
        {
            if (await Ultima.SummonChocobo()) return true;
            if (await HissatsuGuren()) return true;
            if (await HissatsuKyuten()) return true;
            if (await HissatsuSeigan()) return true;
            if (await HissatsuShinten()) return true;
            if (await Invigorate()) return true;
            return await Ageha();
        }
    }
}