using ff14bot;
using ff14bot.Managers;
using System.Threading.Tasks;
using UltimaCR.Spells.Main;

namespace UltimaCR.Rotations
{
    public sealed partial class Archer
    {
        private ArcherSpells _mySpells;

        private ArcherSpells MySpells
        {
            get { return _mySpells ?? (_mySpells = new ArcherSpells()); }
        }

        #region Class Spells

        private async Task<bool> HeavyShot()
        {
            return await MySpells.HeavyShot.Cast();
        }

        private async Task<bool> StraightShot()
        {
            if (Core.Player.HasAura("Straighter Shot") ||
                !Core.Player.HasAura(MySpells.StraightShot.Name))
            {
                return await MySpells.StraightShot.Cast();
            }
            return false;
        }

        private async Task<bool> RagingStrikes()
        {
            return await MySpells.RagingStrikes.Cast();
        }

        private async Task<bool> VenomousBite()
        {
            if (!Core.Player.CurrentTarget.HasAura(MySpells.VenomousBite.Name, true, 4000))
            {
                return await MySpells.VenomousBite.Cast();
            }
            return false;
        }

        private async Task<bool> MiserysEnd()
        {
            if (Ultima.UltSettings.ArcherMiserysEnd)
            {
                return await MySpells.MiserysEnd.Cast();
            }
            return false;
        }

        private async Task<bool> Shadowbind()
        {
            return await MySpells.Shadowbind.Cast();
        }

        private async Task<bool> Bloodletter()
        {
            return await MySpells.Bloodletter.Cast();
        }

        private async Task<bool> RepellingShot()
        {
            if (Core.Player.TargetDistance(5, false))
            {
                return await MySpells.RepellingShot.Cast();
            }
            return false;
        }

        private async Task<bool> QuickNock()
        {
            return await MySpells.QuickNock.Cast();
        }

        private async Task<bool> Swiftsong()
        {
            if (!Core.Player.InCombat &&
                !Core.Player.HasAura(MySpells.Swiftsong.Name))
            {
                return await MySpells.Swiftsong.Cast();
            }
            return false;
        }

        private async Task<bool> HawksEye()
        {
            /*if (Core.Player.HasAura(MySpells.CrossClass.BloodForBlood.Name))
            {
                return await MySpells.HawksEye.Cast();
            }
            if (!ActionManager.HasSpell(MySpells.CrossClass.BloodForBlood.Name))
            {
                return await MySpells.HawksEye.Cast();
            }*/
            return false;
        }

        private async Task<bool> Windbite()
        {
            if (!Core.Player.CurrentTarget.HasAura(MySpells.Windbite.Name, true, 4000))
            {
                return await MySpells.Windbite.Cast();
            }
            return false;
        }

        private async Task<bool> QuellingStrikes()
        {
            return await MySpells.QuellingStrikes.Cast();
        }

        private async Task<bool> Barrage()
        {
            return await MySpells.Barrage.Cast();
        }

        private async Task<bool> BluntArrow()
        {
            if (Ultima.UltSettings.ArcherBluntArrow)
            {
                return await MySpells.BluntArrow.Cast();
            }
            return false;
        }

        private async Task<bool> FlamingArrow()
        {
            if (Ultima.UltSettings.ArcherFlamingArrow)
            {
                return await MySpells.FlamingArrow.Cast();
            }
            return false;
        }

        private async Task<bool> WideVolley()
        {
            return await MySpells.WideVolley.Cast();
        }

        #endregion

        #region Role Spells

        #endregion

        #region PvP Spells

        private async Task<bool> BlastShot()
        {
            return await MySpells.PvP.BlastShot.Cast();
        }

        private async Task<bool> Farshot()
        {
            return await MySpells.PvP.Farshot.Cast();
        }

        private async Task<bool> ManaDraw()
        {
            return await MySpells.PvP.ManaDraw.Cast();
        }

        private async Task<bool> Manasong()
        {
            return await MySpells.PvP.Manasong.Cast();
        }

        private async Task<bool> Purify()
        {
            return await MySpells.PvP.Purify.Cast();
        }

        #endregion
    }
}