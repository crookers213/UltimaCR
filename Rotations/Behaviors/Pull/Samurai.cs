﻿using System.Threading.Tasks;

namespace UltimaCR.Rotations
{
    public sealed partial class Samurai
    {
        public override async Task<bool> Pull()
        {
            return await Combat();
        }
    }
}