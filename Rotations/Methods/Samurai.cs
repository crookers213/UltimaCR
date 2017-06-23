using Buddy.Coroutines;
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
        
        private async Task<bool> JinpuBuff()
        {
            if (ActionManager.LastSpell.Name == MySpells.Hakaze.Name && !Core.Player.HasAura(MySpells.Jinpu.Name, true, 8000))
            {
                return await MySpells.Jinpu.Cast();
            }
            return false;
        }
        
        private async Task<bool> Jinpu()
        {
            if (ActionManager.LastSpell.Name == MySpells.Hakaze.Name && !GetsuActive)
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
        
        private async Task<bool> ShifuBuff()
        {
            if (ActionManager.LastSpell.Name == MySpells.Hakaze.Name && !Core.Player.HasAura(MySpells.Shifu.Name, true, 8000))
            {
                return await MySpells.Shifu.Cast();
            }
            return false;
        }

        private async Task<bool> Shifu()
        {
            if (ActionManager.LastSpell.Name == MySpells.Hakaze.Name && !KaActive)
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
        
        private async Task<bool> YukikazeDebuff()
        {
            if (ActionManager.LastSpell.Name == MySpells.Hakaze.Name && 
        !Core.Player.CurrentTarget.HasAura(819, false, 8000))
            {
                return await MySpells.Yukikaze.Cast();
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
        
        private async Task<bool> Higanbana()
        {
            if (Core.Player.CurrentTarget.CurrentHealth > 500000 && !Core.Player.CurrentTarget.HasAura("Higanbana", true, 5000) &&
        ActionManager.CanCast(MySpells.Higanbana.Name, Core.Player.CurrentTarget) && NumSen == 1)
            {
                if (await MySpells.HissatsuKaiten.Cast())
                {
                    await Coroutine.Wait(3000, () => ActionManager.CanCast(MySpells.Higanbana.Name, Core.Player.CurrentTarget) &&
                        Core.Player.HasAura("Kaiten"));
                }
                return await MySpells.Higanbana.Cast();
            }
            return false;
        }
        
        private async Task<bool> MidareSetsugekka()
        {
            if (Core.Player.CurrentTarget.CurrentHealth > 10000 && 
        ActionManager.CanCast(MySpells.MidareSetsugekka.Name, Core.Player.CurrentTarget))
            {
                if (await MySpells.HissatsuKaiten.Cast())
                {
                    await Coroutine.Wait(3000, () => ActionManager.CanCast(MySpells.MidareSetsugekka.Name, Core.Player.CurrentTarget) &&
                        Core.Player.HasAura("Kaiten"));
                }
                return await MySpells.MidareSetsugekka.Cast();
            }
            return false;
        }
        
        private async Task<bool> Hagakure()
        {
            if (NumSen == 3)
            {
                return await MySpells.Hagakure.Cast();
            }
            return false;
        }

        private async Task<bool> HissatsuKaiten()
        {
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
        
        #region Custom Spells
        
        private static bool GetsuActive
        {
            get
            {
                return ActionResourceManager.Samurai.Sen.HasFlag(ActionResourceManager.Samurai.Iaijutsu.Getsu);
            }
        }
        
        private static bool KaActive
        {
            get
            {
                return ActionResourceManager.Samurai.Sen.HasFlag(ActionResourceManager.Samurai.Iaijutsu.Ka);
            }
        }
        
        private static bool SetsuActive
        {
            get
            {
                return ActionResourceManager.Samurai.Sen.HasFlag(ActionResourceManager.Samurai.Iaijutsu.Setsu);
            }
        }
        
        private static int NumSen
        {
            get
            {
                int active = 0;
                foreach (Enum value in Enum.GetValues(typeof(ActionResourceManager.Samurai.Iaijutsu)))
                {
                    if (ActionResourceManager.Samurai.Sen.HasFlag(value))
                    {
                        active++;
                    }
                }
                return active;
            }
        }
        
        #endregion
    }
}