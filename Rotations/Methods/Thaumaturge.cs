using Buddy.Coroutines;
using ff14bot;
using ff14bot.Managers;
using System;
using System.Threading.Tasks;
using UltimaCR.Spells;
using UltimaCR.Spells.Main;

namespace UltimaCR.Rotations
{
    public sealed partial class Thaumaturge
    {
        private ThaumaturgeSpells _mySpells;

        private ThaumaturgeSpells MySpells
        {
            get { return _mySpells ?? (_mySpells = new ThaumaturgeSpells()); }
        }

        #region Class Spells

        private async Task<bool> Blizzard()
        {
            if (UmbralAura && Core.Player.CurrentManaPercent < 90)
            {
                return await MySpells.Blizzard.Cast();
            }
            if (!UmbralAura && LowMP)
            {
                return await MySpells.Blizzard.Cast();
            }
            if (Core.Player.ClassLevel < 2)
            {
                return await MySpells.Blizzard.Cast();
            }
            return false;
        }
        
        private async Task<bool> BlizzardII()
        {
            return await MySpells.BlizzardII.Cast();
        }

        private async Task<bool> Fire()
        {
            if (!ActionManager.HasSpell(MySpells.FireIII.Name))
            {
                if (UmbralAura && Core.Player.CurrentManaPercent >= 90)
                {
                    return await MySpells.Fire.Cast();
                }
            }
            if (!UmbralAura)
            {
                return await MySpells.Fire.Cast();
            }
            return false;
        }
        
        private async Task<bool> FireII()
        {
            if (!UmbralAura)
            {
                return await MySpells.FireII.Cast();
            }
            return false;
        }
        
        private async Task<bool> FireIII()
        {
            if (UmbralAura)
            {
                if (Core.Player.CurrentManaPercent == 100 || Ultima.LastSpell.Name == MySpells.Scathe.Name)
                {
                    if (await MySpells.FireIII.Cast())
                    {
                        await Coroutine.Wait(5000, () => AstralAura);
                        return true;
                    }
                }
            }
            if (!AstralAura && !UmbralAura)
            {
                if (await MySpells.FireIII.Cast())
                {
                    await Coroutine.Wait(5000, () => AstralAura);
                    return true;
                }
            }
            return false;
        }

        private async Task<bool> Transpose()
        {
            if (AstralAura)
            {
                if (!Core.Player.InCombat && LowMP)
                {
                    return await MySpells.Transpose.Cast();
                }
            }
            if (UmbralAura && Core.Player.HasAura("Firestarter"))
            {
                if (Ultima.LastSpell.Name == MySpells.Scathe.Name && Core.Player.CurrentManaPercent != 100)
                {
                    await Coroutine.Wait(5000, () => Core.Player.CurrentManaPercent == 100 || MovementManager.IsMoving);
                }
                if (Core.Player.CurrentManaPercent == 100)
                {
                    return await MySpells.Transpose.Cast();
                }
            }
            if (LowMP)
            {
                return await MySpells.Transpose.Cast();
            }
            return false;
        }
        
        private async Task<bool> Scathe()
        {
            if (MovementManager.IsMoving && !LowMP && !Core.Player.HasAura(MySpells.Role.Swiftcast.Name))
            {
                return await MySpells.Scathe.Cast();
            }
            if (!ActionManager.HasSpell(MySpells.BlizzardIII.Name) && UmbralAura && Core.Player.CurrentManaPercent < 100)
            {
                if (Ultima.LastSpell.Name == MySpells.Blizzard.Name || Ultima.LastSpell.Name == MySpells.Thunder.Name ||
            Ultima.LastSpell.Name == MySpells.ThunderII.Name || Ultima.LastSpell.Name == MySpells.ThunderIII.Name)
                {
                    return await MySpells.Scathe.Cast();
                }
            }
            return false;
        }

        private async Task<bool> Thunder()
        {
            if (UmbralAura && Core.Player.CurrentManaPercent < 100)
            {
                if (!Core.Player.CurrentTarget.HasAura("Thunder", true, 3000))
                {
                    return await MySpells.Thunder.Cast();
                }
                Spell.RecentSpell.RemoveAll(t => DateTime.UtcNow > t);
                if (!RecentThunder)
                {
                    return await MySpells.Thunder.Cast();
                }
            }
            if (!AstralAura && !UmbralAura)
            {
                if (!Core.Player.CurrentTarget.HasAura("Thunder", true))
                {
                    return await MySpells.Thunder.Cast();
                }
            }
            return false;
        }
        
        private async Task<bool> ThunderII()
        {
            return false;
        }

        private async Task<bool> Sleep()
        {
            return await MySpells.Sleep.Cast();
        }

        private async Task<bool> Manaward()
        {
            return await MySpells.Manaward.Cast();
        }

        private async Task<bool> AetherialManipulation()
        {
            return await MySpells.AetherialManipulation.Cast();
        }

        #endregion

        #region Role Spells
        
        private async Task<bool> Swiftcast()
        {
            if (AstralAura && !LowMP)
            {
                return await MySpells.Role.Swiftcast.Cast();
            }
            return false;
        }

        #endregion

        #region Custom Spells

        private static bool UmbralAura
        {
            get
            {
                return ActionResourceManager.BlackMage.UmbralStacks > 0;
            }
        }

        private static bool AstralAura
        {
            get
            {
                return ActionResourceManager.BlackMage.AstralStacks > 0;
            }
        }

        private static bool RecentThunder
        {
            get
            {
                return (Spell.RecentSpell.ContainsKey(Core.Player.CurrentTarget.ObjectId.ToString("X") + "-" + "Thunder") ||
                       Spell.RecentSpell.ContainsKey(Core.Player.CurrentTarget.ObjectId.ToString("X") + "-" + "Thunder II") ||
                       Spell.RecentSpell.ContainsKey(Core.Player.CurrentTarget.ObjectId.ToString("X") + "-" + "Thunder III"));
            }
        }

        private static bool LowMP
        {
            get
            {
                return (Core.Player.CurrentManaPercent <= 32 && (Ultima.UltSettings.SmartTarget && Helpers.EnemiesNearTarget(5) >= 3 || 
                    Ultima.UltSettings.MultiTarget) || Core.Player.CurrentManaPercent <= 26.3);
            }
        }

        private async Task<bool> Thundercloud()
        {
            if (Core.Player.HasAura("Thundercloud"))
            {
                if (!UmbralAura)
                {
                    if (Ultima.LastSpell.Name == MySpells.Fire.Name || Ultima.LastSpell.Name == MySpells.FireII.Name ||
                !Core.Player.HasAura("Thundercloud", false, 5000))
                    {
                        return await MySpells.Thunder.Cast();
                    }
                }
                if (UmbralAura)
                {
                    Spell.RecentSpell.RemoveAll(t => DateTime.UtcNow > t);
                    if (!RecentThunder)
                    {
                        return await MySpells.Thunder.Cast();
                    }
                }
            }
            return false;
        }

        private async Task<bool> Firestarter()
        {
            if (!UmbralAura && Core.Player.HasAura("Firestarter"))
            {
                if (await MySpells.FireIII.Cast())
                {
                    await Coroutine.Wait(5000, () => AstralAura);
                    return true;
                }
            }
            return false;
        }

        #endregion

        #region PvP Spells

        #endregion
    }
}