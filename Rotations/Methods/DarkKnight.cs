using Buddy.Coroutines;
using ff14bot;
using ff14bot.Managers;
using System.Threading.Tasks;
using UltimaCR.Spells.Main;

namespace UltimaCR.Rotations
{
    public sealed partial class DarkKnight
    {
        private DarkKnightSpells _mySpells;

        private DarkKnightSpells MySpells
        {
            get { return _mySpells ?? (_mySpells = new DarkKnightSpells()); }
        }

        #region ST
        
        private async Task<bool> HardSlash()
        {
            return await MySpells.HardSlash.Cast();
        }
        
        private async Task<bool> SpinningSlash()
        {
            if (ActionManager.LastSpell.Name == MySpells.HardSlash.Name)
            {
                return await MySpells.SpinningSlash.Cast();
            }
            return false;
        }
        
        private async Task<bool> PowerSlash()
        {
            if (ActionManager.LastSpell.Name == MySpells.SpinningSlash.Name)
            {
                return await MySpells.PowerSlash.Cast();
            }
            return false;
        }
        
        private async Task<bool> SyphonStrike()
        {
            if (ActionManager.LastSpell.Name == MySpells.HardSlash.Name)
            {
                if (Core.Player.CurrentManaPercent < 50 || (ActionManager.HasSpell(MySpells.Souleater.Name) &&
            Core.Player.CurrentHealthPercent < 70))
                {
                    return await MySpells.SyphonStrike.Cast();
                }
            }
            return false;
        }
        
        private async Task<bool> Souleater()
        {
            if (ActionManager.LastSpell.Name == MySpells.SyphonStrike.Name)
            {
                if (Ultima.UltSettings.DarkKnightDarkArts && !Core.Player.HasAura(MySpells.DarkArts.Name) &&
            Core.Player.TargetDistance(3, false) && Core.Player.CurrentManaPercent >= 50)
                {
                    if (await MySpells.DarkArts.Cast())
                    {
                        await Coroutine.Wait(3000, () => ActionManager.CanCast(MySpells.Souleater.Name, Core.Player.CurrentTarget));
                    }
                }
                return await MySpells.Souleater.Cast();
            }
            return false;
        }
        
        private async Task<bool> Unmend()
        {
            if (Core.Player.TargetDistance(10))
            {
                return await MySpells.Unmend.Cast();
            }
            return false;
        }
        
        #endregion
        
        #region AoE
        
        private async Task<bool> Unleash()
        {
            return await MySpells.Unleash.Cast();
        }
        
        private async Task<bool> DarkPassenger()
        {
            return await MySpells.DarkPassenger.Cast();
        }
        
        private async Task<bool> AbyssalDrain()
        {
            return await MySpells.AbyssalDrain.Cast();
        }
        
        #endregion
        
        #region Off-GCD
        
        private async Task<bool> DarkArts()
        {
            return await MySpells.DarkArts.Cast();
        }
        
        private async Task<bool> SaltedEarth()
        {
            if (Ultima.UltSettings.DarkKnightSaltedEarth)
            {
                return await MySpells.SaltedEarth.Cast();
            }
            return false;
        }

        private async Task<bool> Plunge()
        {
            if (Ultima.UltSettings.DarkKnightPlunge)
            {
                return await MySpells.Plunge.Cast();
            }
            return false;
        }
        
        private async Task<bool> CarveAndSplit()
        {
            if (Core.Player.CurrentManaPercent < 70)
            {
                return await MySpells.CarveAndSplit.Cast();
            }
            return false;
        }
        
        #endregion
        
        #region Buffs
        
        private async Task<bool> BloodWeapon()
        {
            if (Ultima.UltSettings.DarkKnightBloodWeapon)
            {
                return await MySpells.BloodWeapon.Cast();
            }
            return false;
        }
        
        private async Task<bool> Grit()
        {
            if (!Core.Player.HasAura(MySpells.Grit.Name))
            {
                return await MySpells.Grit.Cast();
            }
            return false;
        }

        private async Task<bool> Darkside()
        {
            if (!Core.Player.HasAura(MySpells.Darkside.Name))
            {
                return await MySpells.Darkside.Cast();
            }
            return false;
        }
        
        private async Task<bool> BloodPrice()
        {
            return await MySpells.BloodPrice.Cast();
        }
        
        private async Task<bool> DarkMind()
        {
            return await MySpells.DarkMind.Cast();
        }
        
        private async Task<bool> ShadowWall()
        {
            return await MySpells.ShadowWall.Cast();
        }

        private async Task<bool> LivingDead()
        {
            return await MySpells.LivingDead.Cast();
        }
        
        #endregion
        
        #region Debuffs
        
        private async Task<bool> SoleSurvivor()
        {
            return await MySpells.SoleSurvivor.Cast();
        }
        
        #endregion
        
        #region Role

        #endregion

        #region PvP

        #endregion
    }
}