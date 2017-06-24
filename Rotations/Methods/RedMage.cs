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
            if ((Core.Player.HasAura("Dualcast") || Core.Player.HasAura("Swiftcast")) && BlackMana > WhiteMana)
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
            if (WhiteMana >= 80 && BlackMana >= 80 && Core.Player.TargetDistance(5, false))
            {
                return await MySpells.EnchantedRiposte.Cast();
            }
            return false;
        }
        
        private async Task<bool> EnchantedZwerchhau()
        {
            if (ActionManager.LastSpell.Name == "Riposte" && Core.Player.TargetDistance(5, false))
            {
                return await MySpells.EnchantedZwerchhau.Cast();
            }
            return false;
        }
        
        private async Task<bool> EnchantedRedoublement()
        {
            if (ActionManager.LastSpell.Name == "Zwerchhau" && Core.Player.TargetDistance(5, false))
            {
                return await MySpells.EnchantedRedoublement.Cast();
            }
            return false;
        }
        
        private async Task<bool> Verflare()
        {
            if (WhiteMana >= BlackMana)
            {
                return await MySpells.Verflare.Cast();
            }
            return false;
        }
        
        private async Task<bool> Verholy()
        {
            if (BlackMana >= WhiteMana)
            {
                return await MySpells.Verholy.Cast();
            }
            return false;
        }
        
        private async Task<bool> Fleche()
        {
            if (UseOffGCD)
            {
                return await MySpells.Fleche.Cast();
            }
            return false;
        }
        
        private async Task<bool> ContreSixte()
        {
            if (UseOffGCD)
            {
                return await MySpells.ContreSixte.Cast();
            }
            return false;
        }
        
        private async Task<bool> Acceleration()
        {
            if (UseOffGCD)
            {
                return await MySpells.Acceleration.Cast();
            }
            return false;
        }
        
        private async Task<bool> Vercure()
        {
            if (Core.Player.CurrentHealthPercent < 40)
            {
                return await MySpells.Vercure.Cast();
            }
            return false;
        }
        
        private async Task<bool> Scatter()
        {
            if (Core.Player.ClassLevel >= 52 || Ultima.UltSettings.MultiTarget)
            {
                return await MySpells.Scatter.Cast();
            }
            return false;
        }
        
        private async Task<bool> EnchantedMoulinet()
        {
            if (WhiteMana >= 30 && BlackMana >= 30)
            {
                return await MySpells.EnchantedMoulinet.Cast();
            }
            return false;
        }

        #endregion
        
        #region Cross Class Spells
        
        private async Task<bool> Swiftcast()
        {
            if (UseOffGCD)
            {
                return await MySpells.CrossClass.Swiftcast.Cast();
            }
            return false;
        }
        
        #endregion
        
        #region Custom Spells
        
        private static int WhiteMana
        {
            get
            {
                return ActionResourceManager.RedMage.WhiteMana;
            }
        }
        
        private static int BlackMana
        {
            get
            {
                return ActionResourceManager.RedMage.BlackMana;
            }
        }
        
        private static bool UseOffGCD
        {
            get
            {
                return ActionManager.LastSpell.Name == "Veraero" || ActionManager.LastSpell.Name == "Verthunder" || 
                    ActionManager.LastSpell.Name == "Scatter";
            }
        }
        
        #endregion
    }
}