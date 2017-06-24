using Buddy.Coroutines;
using ff14bot;
using ff14bot.Enums;
using ff14bot.Managers;
using System.Linq;
using System.Threading.Tasks;
using UltimaCR.Spells.Main;

namespace UltimaCR.Rotations
{
    public sealed partial class WhiteMage
    {
        private WhiteMageSpells _mySpells;

        private WhiteMageSpells MySpells
        {
            get { return _mySpells ?? (_mySpells = new WhiteMageSpells()); }
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
            if (Core.Player.ClassLevel < 54)
            {
                return await MySpells.StoneII.Cast();
            }
            return false;
        }
        
        private async Task<bool> StoneIII()
        {
            if (Core.Player.ClassLevel < 64)
            {
                return await MySpells.StoneIII.Cast();
            }
            return false;
        }
        
        private async Task<bool> StoneIV()
        {
            return await MySpells.StoneIV.Cast();
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
            if (!Core.Player.CurrentTarget.HasAura(MySpells.AeroII.Name, true, 3000))
            {
                return await MySpells.AeroII.Cast();
            }
            return false;
        }

        private async Task<bool> AeroIII()
        {
            if (!Core.Player.CurrentTarget.HasAura(MySpells.AeroIII.Name, true, 4000))
            {
                return await MySpells.AeroIII.Cast();
            }
            return false;
        }
        
        private async Task<bool> Holy()
        {
            return await MySpells.Holy.Cast();
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
        
        private async Task<bool> Regen()
        {
            if (Core.Player.CurrentHealthPercent < 70 && !Core.Player.HasAura(MySpells.Regen.Name, true, 3000))
            {
                return await MySpells.Regen.Cast();
            }
            return false;
        }
        
        private async Task<bool> PresenceOfMind()
        {
            return await MySpells.PresenceOfMind.Cast();
        }
        
        private async Task<bool> Tetragrammaton()
        {
            if (Core.Player.CurrentHealthPercent < 30)
            {
                return await MySpells.Tetragrammaton.Cast();
            }
            return false;
        }
        
        private async Task<bool> ThinAir()
        {
            return await MySpells.ThinAir.Cast();
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
        
        private async Task<bool> Swiftcast()
        {
            return await MySpells.Role.Swiftcast.Cast();
        }
        
        private async Task<bool> Largesse()
        {
            return await MySpells.Role.Largesse.Cast();
        }

        #endregion
        
        #region Custom Spells
        
        private static int NumLilies
        {
            get
            {
                return ActionResourceManager.WhiteMage.Lily;
            }
        }
        
        #endregion

        #region PvP Spells

        #endregion
    }
}