using ff14bot;
using ff14bot.Managers;
using System.Threading.Tasks;
using UltimaCR.Spells.Main;

namespace UltimaCR.Rotations
{
    public sealed partial class Gladiator
    {
        private GladiatorSpells _mySpells;

        private GladiatorSpells MySpells
        {
            get { return _mySpells ?? (_mySpells = new GladiatorSpells()); }
        }

        #region Class Spells

        private async Task<bool> FastBlade()
        {
            return await MySpells.FastBlade.Cast();
        }

        private async Task<bool> SavageBlade()
        {
            if (ActionManager.LastSpell.Name == MySpells.FastBlade.Name)
            {
                return await MySpells.SavageBlade.Cast();
            }
            return false;
        }

        private async Task<bool> FightOrFlight()
        {
            return await MySpells.FightOrFlight.Cast();
        }

        private async Task<bool> Flash()
        {
            return await MySpells.Flash.Cast();
        }

        private async Task<bool> RiotBlade()
        {
            return await MySpells.RiotBlade.Cast();
        }

        private async Task<bool> ShieldLob()
        {
            if (Core.Player.TargetDistance(10))
            {
                return await MySpells.ShieldLob.Cast();
            }
            return false;
        }

        private async Task<bool> ShieldBash()
        {
            return await MySpells.ShieldBash.Cast();
        }

        private async Task<bool> RageOfHalone()
        {
            if (ActionManager.LastSpell.Name == MySpells.SavageBlade.Name)
            {
                return await MySpells.RageOfHalone.Cast();
            }
            return false;
        }

        private async Task<bool> ShieldSwipe()
        {
            if (Ultima.UltSettings.GladiatorShieldSwipe &&
                Core.Player.CurrentTPPercent > 40)
            {
                return await MySpells.ShieldSwipe.Cast();
            }
            return false;
        }

        private async Task<bool> Sentinel()
        {
            return await MySpells.Sentinel.Cast();
        }

        private async Task<bool> TemperedWill()
        {
            return await MySpells.TemperedWill.Cast();
        }

        private async Task<bool> Bulwark()
        {
            return await MySpells.Bulwark.Cast();
        }

        private async Task<bool> CircleOfScorn()
        {
            return await MySpells.CircleOfScorn.Cast();
        }

        #endregion

        #region Role Spells

        #endregion

        #region PvP Spells

        #endregion
    }
}