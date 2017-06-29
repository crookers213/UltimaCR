﻿using Buddy.Coroutines;
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

        #region ST
        
        private async Task<bool> Hakaze()
        {
            return await MySpells.Hakaze.Cast();
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
        
        private async Task<bool> Yukikaze()
        {
            if (ActionManager.LastSpell.Name == MySpells.Hakaze.Name)
            {
                return await MySpells.Yukikaze.Cast();
            }
            return false;
        }
        
        private async Task<bool> Meikyo()
        {
            if (Core.Player.HasAura(1233))
            {
                if (!GetsuActive)
                {
                    return await MySpells.Gekko.Cast();
                }
                if (!KaActive)
                {
                    return await MySpells.Kasha.Cast();
                }
                if (!SetsuActive)
                {
                    return await MySpells.Yukikaze.Cast();
                }
            }
            return false;
        }
        
        private async Task<bool> MidareSetsugekka()
        {
            if (NumSen == 3 && Core.Player.CurrentTarget.CurrentHealth > 10000 && !MovementManager.IsMoving)
            {
                if (ActionManager.CanCast(MySpells.MidareSetsugekka.Name, Core.Player.CurrentTarget))
                {
                    if (await MySpells.HissatsuKaiten.Cast())
                    {
                        await Coroutine.Wait(3000, () => Core.Player.HasAura(1229) && 
                            ActionManager.CanCast(MySpells.MidareSetsugekka.Name, Core.Player.CurrentTarget));
                    }
                }
                return await MySpells.MidareSetsugekka.Cast();
            }
            return false;
        }
        
        private async Task<bool> Hagakure()
        {
            if ((ActionManager.LastSpell.Name == MySpells.Jinpu.Name && GetsuActive) || 
        (ActionManager.LastSpell.Name == MySpells.Shifu.Name && KaActive))
            {
                return await MySpells.Hagakure.Cast();
            }
            if (NumSen == 3 && (Helpers.EnemiesNearPlayer(5) > 2 || MovementManager.IsMoving))
            {
                return await MySpells.Hagakure.Cast();
            }
            return false;
        }
        
        #endregion
        
        #region AoE
        
        private async Task<bool> Fuga()
        {
            if (Core.Player.HasAura(MySpells.Shifu.Name) && Core.Player.HasAura(MySpells.Jinpu.Name))
            {
                return await MySpells.Fuga.Cast();
            }
            return false;
        }
        
        private async Task<bool> Mangetsu()
        {
            if (ActionManager.LastSpell.Name == MySpells.Fuga.Name && !GetsuActive)
            {
                return await MySpells.Mangetsu.Cast();
            }
            return false;
        }
        
        private async Task<bool> Oka()
        {
            if (ActionManager.LastSpell.Name == MySpells.Fuga.Name && !KaActive)
            {
                return await MySpells.Oka.Cast();
            }
            return false;
        }
        
        private async Task<bool> TenkaGoken()
        {
            if (NumSen == 2 && Helpers.EnemiesNearTarget(5) > 2 && !MovementManager.IsMoving)
            {
                if (ActionManager.CanCast(MySpells.TenkaGoken.Name, Core.Player.CurrentTarget))
                {
                    if (await MySpells.HissatsuKaiten.Cast())
                    {
                        await Coroutine.Wait(3000, () => Core.Player.HasAura(1229) && 
                            ActionManager.CanCast(MySpells.TenkaGoken.Name, Core.Player.CurrentTarget));
                    }
                }
                return await MySpells.TenkaGoken.Cast();
            }
            return false;
        }
        
        #endregion
        
        #region Off-GCD

        private async Task<bool> MercifulEyes()
        {
            if (Core.Player.CurrentHealthPercent < 60)
            {
                return await MySpells.MercifulEyes.Cast();
            }
            return false;
        }

        private async Task<bool> HissatsuShinten()
        {
            if (ActionManager.LastSpell.Name != MySpells.HissatsuKaiten.Name && Kenki >= 45 && !PoolKenki)
            {
                return await MySpells.HissatsuShinten.Cast();
            }
            return false;
        }
        
        private async Task<bool> HissatsuKyuten()
        {
            if (ActionManager.LastSpell.Name != MySpells.HissatsuKaiten.Name && Kenki >= 45 && !PoolKenki)
            {
                if (!Ultima.UltSettings.SingleTarget && Helpers.EnemiesNearPlayer(5) > 2)
                {
                    return await MySpells.HissatsuKyuten.Cast();
                }
            }
            return false;
        }
        
        private async Task<bool> HissatsuSeigan()
        {
            if (ActionManager.LastSpell.Name != MySpells.HissatsuKaiten.Name && Kenki >= 45 && !PoolKenki)
            {
                return await MySpells.HissatsuSeigan.Cast();
            }
            return false;
        }
        
        private async Task<bool> HissatsuGuren()
        {
            return await MySpells.HissatsuGuren.Cast();
        }
        
        private async Task<bool> Ageha()
        {
            return await MySpells.Ageha.Cast();
        }
        
        #endregion
        
        #region Buffs
        
        private async Task<bool> JinpuBuff()
        {
            if (ActionManager.LastSpell.Name == MySpells.Hakaze.Name && !Core.Player.HasAura(MySpells.Jinpu.Name, true, 8000))
            {
                return await MySpells.Jinpu.Cast();
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
        
        #endregion
        
        #region Debuffs

        private async Task<bool> YukikazeDebuff()
        {
            if (ActionManager.LastSpell.Name == MySpells.Hakaze.Name && !Core.Player.CurrentTarget.HasAura(819, false, 8000))
            {
                return await MySpells.Yukikaze.Cast();
            }
            return false;
        }
        
        private async Task<bool> Higanbana()
        {
            if (NumSen == 1 && !Core.Player.CurrentTarget.HasAura(MySpells.Higanbana.Name, true, 5000) && 
        Core.Player.CurrentTarget.CurrentHealth > 500000 && !MovementManager.IsMoving)
            {
                if (ActionManager.CanCast(MySpells.Higanbana.Name, Core.Player.CurrentTarget))
                {
                    if (await MySpells.HissatsuKaiten.Cast())
                    {
                        await Coroutine.Wait(3000, () => Core.Player.HasAura(1229) && 
                            ActionManager.CanCast(MySpells.Higanbana.Name, Core.Player.CurrentTarget));
                    }
                }
                return await MySpells.Higanbana.Cast();
            }
            return false;
        }
        
        #endregion

        #region Role Spells
        
        private async Task<bool> SecondWind()
        {
            if (Core.Player.CurrentHealthPercent < 50)
            {
                return await MySpells.Role.SecondWind.Cast();
            }
            return false;
        }
        
        private async Task<bool> Invigorate()
        {
            if (Core.Player.CurrentTP <= 400)
            {
                return await MySpells.Role.Invigorate.Cast();
            }
            return false;
        }
        
        private async Task<bool> Bloodbath()
        {
            if (Core.Player.CurrentHealthPercent < 70)
            {
                return await MySpells.Role.Bloodbath.Cast();
            }
            return false;
        }
        
        #endregion
        
        #region Custom Spells
        
        private static int Kenki
        {
            get
            {
                return ActionResourceManager.Samurai.Kenki;
            }
        }
        
        private static bool PoolKenki
        {
            get
            {
                return ActionManager.HasSpell(7496) && DataManager.GetSpellData(7496).Cooldown.TotalMilliseconds < 6000;
            }
        }
        
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