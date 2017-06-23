using ff14bot;
using ff14bot.Managers;
using System.Threading.Tasks;
using UltimaCR.Spells.Main;

namespace UltimaCR.Rotations
{
    public sealed partial class RedMage
    {
        private RedMageSpells _mySpells;

        private RedMageSpells MySpells
        {
            get { return _mySpells ?? (_mySpells = new RedMageSpells()); }
        }

        #region Job Spells
        
        private async Task<bool> Riposte()
        {
            if (Core.Player.ClassLevel < 2)
            {
                return await MySpells.Riposte.Cast();
            }
            return false;
        }

        private async Task<bool> Jolt()
        {
            if (Core.Player.ClassLevel < 62)
            {
                return await MySpells.Jolt.Cast();
            }
            return false;
        }
        
        private async Task<bool> JoltII()
        {
            return await MySpells.JoltII.Cast();
        }
        
        private async Task<bool> Impact()
        {
            return await MySpells.Impact.Cast();
        }
        
        private async Task<bool> Veraero()
        {
            if ((Core.Player.HasAura("Dualcast") || Core.Player.HasAura("Swiftcast")) && 
        ActionResourceManager.RedMage.BlackMana > ActionResourceManager.RedMage.WhiteMana)
            {
                return await MySpells.Veraero.Cast();
            }
            return false;
        }
        
        private async Task<bool> Verstone()
        {
            return await MySpells.Verstone.Cast();
        }
        
        private async Task<bool> Verthunder()
        {
            if (Core.Player.HasAura("Dualcast") || Core.Player.HasAura("Swiftcast"))
            {
                return await MySpells.Verthunder.Cast();
            }
            return false;
        }
        
        private async Task<bool> Verfire()
        {
            return await MySpells.Verfire.Cast();
        }
        
        private async Task<bool> EnchantedRiposte()
        {
            if (ActionResourceManager.RedMage.WhiteMana >= 80 && ActionResourceManager.RedMage.BlackMana >= 80 && 
        Core.Target.Distance2D() <= 2.9f)
            {
                return await MySpells.EnchantedRiposte.Cast();
            }
            return false;
        }
        
        private async Task<bool> EnchantedZwerchhau()
        {
            if (ActionManager.LastSpell.Name == "Riposte" && Core.Target.Distance2D() <= 2.9f)
            {
                return await MySpells.EnchantedZwerchhau.Cast();
            }
            return false;
        }
        
        private async Task<bool> EnchantedRedoublement()
        {
            if (ActionManager.LastSpell.Name == "Zwerchhau" && Core.Target.Distance2D() <= 2.9f)
            {
                return await MySpells.EnchantedRedoublement.Cast();
            }
            return false;
        }
        
        private async Task<bool> Verflare()
        {
            if (ActionResourceManager.RedMage.WhiteMana >= ActionResourceManager.RedMage.BlackMana)
            {
                return await MySpells.Verflare.Cast();
            }
            return false;
        }
        
        private async Task<bool> Verholy()
        {
            if (ActionResourceManager.RedMage.BlackMana >= ActionResourceManager.RedMage.WhiteMana)
            {
                return await MySpells.Verholy.Cast();
            }
            return false;
        }
        
        private async Task<bool> Fleche()
        {
            return await MySpells.Fleche.Cast();
        }
        
        private async Task<bool> Zwerchhau()
        {
            return await MySpells.Zwerchhau.Cast();
        }
        
        private async Task<bool> Acceleration()
        {
            return await MySpells.Acceleration.Cast();
        }
        
        private async Task<bool> Vercure()
        {
            if (Core.Player.CurrentHealthPercent < 40)
            {
                return await MySpells.Vercure.Cast();
            }
            return false;
        }

        #endregion
        
        #region Cross Class Spells
        
        private async Task<bool> Swiftcast()
        {
            return await MySpells.CrossClass.Swiftcast.Cast();
        }
        
        #endregion
    }
}