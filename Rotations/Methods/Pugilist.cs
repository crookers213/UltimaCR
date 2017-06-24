using Buddy.Coroutines;
using ff14bot;
using ff14bot.Managers;
using System.Threading.Tasks;
using UltimaCR.Spells.Main;

namespace UltimaCR.Rotations
{
    public sealed partial class Pugilist
    {
        private PugilistSpells _mySpells;

        private PugilistSpells MySpells
        {
            get { return _mySpells ?? (_mySpells = new PugilistSpells()); }
        }

        #region Class Spells

        private async Task<bool> Bootshine()
        {
            return await MySpells.Bootshine.Cast();
        }

        private async Task<bool> TrueStrike()
        {
            return await MySpells.TrueStrike.Cast();
        }

        private async Task<bool> Featherfoot()
        {
            return await MySpells.Featherfoot.Cast();
        }

        private async Task<bool> SnapPunch()
        {
            if (!Core.Player.HasAura(MySpells.PerfectBalance.Name) ||
                Core.Player.HasAura(MySpells.PerfectBalance.Name) &&
                 !Core.Player.HasAura("Greased Lightning III"))
            {
                return await MySpells.SnapPunch.Cast();
            }
            return false;
        }

        private async Task<bool> SecondWind()
        {
            return await MySpells.SecondWind.Cast();
        }


        private async Task<bool> Haymaker()
        {
            return await MySpells.Haymaker.Cast();
        }

        private async Task<bool> InternalRelease()
        {
            return await MySpells.InternalRelease.Cast();
        }

        private async Task<bool> TouchOfDeath()
        {
            if (!Core.Player.CurrentTarget.HasAura(MySpells.TouchOfDeath.Name, true, 4000))
            {
                if (NoGreasedLightning ||
                    HasGreasedLightning)
                {
                    return await MySpells.TouchOfDeath.Cast();
                }
                return false;
            }
            return false;
        }

        private async Task<bool> TwinSnakes()
        {
            if (!Core.Player.HasAura(MySpells.TwinSnakes.Name, true, 5000) ||
                !Core.Player.HasAura(MySpells.PerfectBalance.Name) &&
                Core.Player.HasTarget &&
                Core.Player.CurrentTarget.IsFlanking)
            {
                return await MySpells.TwinSnakes.Cast();
            }
            return false;
        }

        private async Task<bool> FistsOfEarth()
        {
            if (Ultima.UltSettings.MonkFistsOfEarth &&
                !Core.Player.HasAura(MySpells.FistsOfEarth.Name) ||
                !Core.Player.HasAura(MySpells.FistsOfEarth.Name) &&
                !Core.Player.HasAura(MySpells.FistsOfWind.Name))
            {
                return await MySpells.FistsOfEarth.Cast();
            }
            return false;
        }

        private async Task<bool> ArmOfTheDestroyer()
        {
            return await MySpells.ArmOfTheDestroyer.Cast();
        }

        private async Task<bool> Demolish()
        {
            if (!Core.Player.CurrentTarget.HasAura(MySpells.Demolish.Name, true, 5000))
            {
                return await MySpells.Demolish.Cast();
            }
            return false;
        }

        private async Task<bool> FistsOfWind()
        {
            if (Ultima.UltSettings.PugilistFistsOfWind &&
                !Core.Player.HasAura(MySpells.FistsOfWind.Name))
            {
                return await MySpells.FistsOfWind.Cast();
            }
            return false;
        }

        private async Task<bool> SteelPeak()
        {
            return await MySpells.SteelPeak.Cast();
        }

        private async Task<bool> Mantra()
        {
            return await MySpells.Mantra.Cast();
        }

        private async Task<bool> HowlingFist()
        {
            return await MySpells.HowlingFist.Cast();
        }

        private async Task<bool> PerfectBalance()
        {
            if (Ultima.UltSettings.PugilistPerfectBalance &&
                ActionManager.CanCast(MySpells.Bootshine.Name, Core.Player.CurrentTarget))
            {
                if (await MySpells.PerfectBalance.Cast())
                {
                    await Coroutine.Wait(5000, () => Core.Player.HasAura(MySpells.PerfectBalance.Name));
                    return true;
                }
                return false;
            }
            return false;
        }

        #endregion

        #region Role Spells

        #endregion

        #region Custom Spells
        private static bool NoGreasedLightning
        {
            get
            {
                return !Core.Player.HasAura("Greased Lightning") &&
                       !Core.Player.HasAura("Greased Lightning II") &&
                       !Core.Player.HasAura("Greased Lightning III");
            }
        }
        private static bool HasGreasedLightning
        {
            get
            {
                return Core.Player.HasAura("Greased Lightning", true, 4000) ||
                       Core.Player.HasAura("Greased Lightning II", true, 4000) ||
                       Core.Player.HasAura("Greased Lightning III", true, 4000);
            }
        }

        #endregion

        #region PvP Spells

        private async Task<bool> AxeKick()
        {
            return await MySpells.PvP.AxeKick.Cast();
        }

        private async Task<bool> Enliven()
        {
            return await MySpells.PvP.Enliven.Cast();
        }

        private async Task<bool> FetterWard()
        {
            return await MySpells.PvP.FetterWard.Cast();
        }

        private async Task<bool> Somersault()
        {
            return await MySpells.PvP.Somersault.Cast();
        }

        private async Task<bool> Purify()
        {
            return await MySpells.PvP.Purify.Cast();
        }

        private async Task<bool> WeaponThrow()
        {
            return await MySpells.PvP.WeaponThrow.Cast();
        }

        #endregion
    }
}