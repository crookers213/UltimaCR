using Buddy.Coroutines;
using ff14bot;
using ff14bot.Enums;
using ff14bot.Managers;
using System.Linq;
using System.Threading.Tasks;
using UltimaCR.Spells.Main;

namespace UltimaCR.Rotations
{
    public sealed partial class Conjurer
    {
        private ConjurerSpells _mySpells;

        private ConjurerSpells MySpells
        {
            get { return _mySpells ?? (_mySpells = new ConjurerSpells()); }
        }

        #region Class Spells

        private async Task<bool> Stone()
        {
            if (Core.Player.ClassLevel < 18)
            {
                return await MySpells.Stone.Cast();
            }
            return false;
        }

        private async Task<bool> StoneII()
        {
            return await MySpells.StoneII.Cast();
        }
        
        private async Task<bool> Aero()
        {
            if (Core.Player.ClassLevel < 46 && !Core.Player.CurrentTarget.HasAura(MySpells.Aero.Name, true, 3000))
            {
                return await MySpells.Aero.Cast();
            }
            return false;
        }

        private async Task<bool> AeroII()
        {
            return await MySpells.AeroII.Cast();
        }
        
        private async Task<bool> FluidAura()
        {
            if (Core.Player.TargetDistance(5, false))
            {
                return await MySpells.FluidAura.Cast();
            }
            return false;
        }
        
        private async Task<bool> Cure()
        {
            if (Core.Player.CurrentHealthPercent < 50)
            {
                return await MySpells.Cure.Cast();
            }
            return false;
        }
        
        private async Task<bool> CureII()
        {
            if (Core.Player.CurrentHealthPercent < 50)
            {
                return await MySpells.CureII.Cast();
            }
            return false;
        }

        #endregion

        #region Role Spells
        
        private async Task<bool> ClericStance()
        {
            return await MySpells.Role.ClericStance.Cast();
        }

        private async Task<bool> Protect()
        {
            if (Ultima.UltSettings.WhiteMageProtect && !Core.Player.HasAura(MySpells.Role.Protect.Name))
            {
                return await MySpells.Role.Protect.Cast();
            }
            return false;
        }

        private async Task<bool> Esuna()
        {
            return await MySpells.Role.Esuna.Cast();
        }
        
        private async Task<bool> LucidDreaming()
        {
            if (Core.Player.CurrentManaPercent <= 60)
            {
                return await MySpells.Role.LucidDreaming.Cast();
            }
            return false;
        }

        #endregion

        #region PvP Spells

        #endregion
    }
}