using ff14bot;
using ff14bot.Managers;
using System.Threading.Tasks;
using UltimaCR.Spells.Main;

namespace UltimaCR.Rotations
{
    public sealed partial class Marauder
    {
        private MarauderSpells _mySpells;

        private MarauderSpells MySpells
        {
            get { return _mySpells ?? (_mySpells = new MarauderSpells()); }
        }

        #region Class Spells

        private async Task<bool> HeavySwing()
        {
            return await MySpells.HeavySwing.Cast();
        }

        private async Task<bool> Foresight()
        {
            return await MySpells.Foresight.Cast();
        }

        private async Task<bool> SkullSunder()
        {
            if (ActionManager.LastSpell.Name == MySpells.HeavySwing.Name)
            {
                return await MySpells.SkullSunder.Cast();
            }
            return false;
        }

        private async Task<bool> Fracture()
        {
            if (!Core.Player.CurrentTarget.HasAura(MySpells.Fracture.Name, true, 4000))
            {
                return await MySpells.Fracture.Cast();
            }
            return false;
        }

        private async Task<bool> Bloodbath()
        {
            return await MySpells.Bloodbath.Cast();
        }

        private async Task<bool> BrutalSwing()
        {
            if (Ultima.UltSettings.MarauderBrutalSwing)
            {
                return await MySpells.BrutalSwing.Cast();
            }
            return false;
        }

        private async Task<bool> Overpower()
        {
            return await MySpells.Overpower.Cast();
        }

        private async Task<bool> Tomahawk()
        {
            if (Core.Player.TargetDistance(10))
            {
                return await MySpells.Tomahawk.Cast();
            }
            return false;
        }

        private async Task<bool> Maim()
        {
            if (ActionManager.LastSpell.Name == MySpells.HeavySwing.Name)
            {
                //if (!Core.Player.CurrentTarget.HasAura(MySpells.StormsEye.Name, false, 4000) &&
                //    !Core.Player.CurrentTarget.HasAura("Dancing Edge", false, 4000) ||
                //    !Core.Player.HasAura(MySpells.StormsPath.Name, true, 4000) ||
                if (!Core.Player.HasAura(MySpells.Maim.Name, true, 4000))
                {
                    return await MySpells.Maim.Cast();
                }
                return false;
            }
            return false;
        }

        private async Task<bool> Berserk()
        {
            return await MySpells.Berserk.Cast();
        }

        private async Task<bool> MercyStroke()
        {
            if (Ultima.UltSettings.MarauderMercyStroke)
            {
                return await MySpells.MercyStroke.Cast();
            }
            return false;
        }

        private async Task<bool> ButchersBlock()
        {
            if (ActionManager.LastSpell.Name == MySpells.SkullSunder.Name)
            {
                return await MySpells.ButchersBlock.Cast();
            }
            return false;
        }

        private async Task<bool> ThrillOfBattle()
        {
            return await MySpells.ThrillOfBattle.Cast();
        }

        private async Task<bool> StormsPath()
        {
            if (ActionManager.LastSpell.Name == MySpells.Maim.Name)
            {
                return await MySpells.StormsPath.Cast();
            }
            return false;
        }

        private async Task<bool> Holmgang()
        {
            return await MySpells.Holmgang.Cast();
        }

        private async Task<bool> Vengeance()
        {
            return await MySpells.Vengeance.Cast();
        }

        private async Task<bool> StormsEye()
        {
            if (ActionManager.LastSpell.Name == MySpells.Maim.Name &&
                !Core.Player.CurrentTarget.HasAura(MySpells.StormsEye.Name, false, 4000) &&
                !Core.Player.CurrentTarget.HasAura("Dancing Edge", false, 4000))
            {
                return await MySpells.StormsEye.Cast();
            }
            return false;
        }

        #endregion

        #region Role Spells

        #endregion

        #region PvP Spells

        private async Task<bool> FullSwing()
        {
            return await MySpells.PvP.FullSwing.Cast();
        }

        private async Task<bool> MythrilTempest()
        {
            return await MySpells.PvP.MythrilTempest.Cast();
        }

        private async Task<bool> Purify()
        {
            return await MySpells.PvP.Purify.Cast();
        }

        private async Task<bool> ThrillOfWar()
        {
            return await MySpells.PvP.ThrillOfWar.Cast();
        }

        #endregion
    }
}