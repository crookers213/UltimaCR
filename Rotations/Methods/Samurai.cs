using ff14bot;
using ff14bot.Managers;
using System;
using System.Threading.Tasks;
using UltimaCR.Spells.Main;

namespace UltimaCR.Rotations
{
    public sealed partial class Samurai
    {
        private SamuraiSpells _mySpells;

        private SamuraiSpells MySpells
        {
            get { return _mySpells ?? (_mySpells = new SamuraiSpells()); }
        }

        #region Job Spells

        private async Task<bool> Hakaze()
        {
            return await MySpells.Hakaze.Cast();
        }
        
        private async Task<bool> Jinpu()
        {
            if (ActionManager.LastSpell.Name == MySpells.Hakaze.Name && !Core.Player.HasAura("Jinpu", true, 14000))
            {
                return await MySpells.Jinpu.Cast();
            }
            return false;
        }
        
        private async Task<bool> Gekko()
        {
            if (ActionManager.LastSpell.Name == MySpells.Jinpu.Name)
            {
                return await MySpells.Gekko.Cast();
            }
            return false;
        }

        private async Task<bool> Shifu()
        {
            if (ActionManager.LastSpell.Name == MySpells.Hakaze.Name && !Core.Player.HasAura("Shifu", true, 14000))
            {
                return await MySpells.Shifu.Cast();
            }
            return false;
        }

        private async Task<bool> Kasha()
        {
            if (ActionManager.LastSpell.Name == MySpells.Shifu.Name)
            {
                return await MySpells.Kasha.Cast();
            }
            return false;
        }
        
        private async Task<bool> Yukikaze()
        {
            if (ActionManager.LastSpell.Name == MySpells.Hakaze.Name)
            {
                return await MySpells.Yukikaze.Cast();
            }
            return false;
        }
        
        private async Task<bool> MidareSetsugekka()
        {
            if (Core.Player.CurrentTarget.CurrentHealthPercent > 30 && (int)ActionResourceManager.Samurai.Sen == 7)
            {
                return await MySpells.MidareSetsugekka.Cast();
            }
            return false;
        }

        private async Task<bool> HissatsuKaiten()
        {
            if (Core.Player.CurrentTarget.CurrentHealthPercent > 30 && (int)ActionResourceManager.Samurai.Sen == 7)
            {
                return await MySpells.HissatsuKaiten.Cast();
            }
            return false;
        }
        
        private async Task<bool> HissatsuShinten()
        {
            if (ActionManager.LastSpell.Name != MySpells.HissatsuKaiten.Name && ActionResourceManager.Samurai.Kenki >= 45)
            {
                return await MySpells.HissatsuShinten.Cast();
            }
            return false;
        }
        
        private async Task<bool> Ageha()
        {
            if (Core.Player.CurrentTarget.CurrentHealthPercent < 10)
            {
                return await MySpells.Ageha.Cast();
            }
            return false;
        }

        #endregion
    }
}