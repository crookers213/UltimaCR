﻿using System.Threading.Tasks;

namespace UltimaCR.Rotations
{
    public sealed partial class Samurai
    {
        public override async Task<bool> Heal()
        {
            if (await SecondWind()) return true;
            return await Bloodbath();
        }
    }
}