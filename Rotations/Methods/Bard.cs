using Buddy.Coroutines;
using ff14bot;
using ff14bot.Enums;
using ff14bot.Managers;
using System;
using System.Threading.Tasks;
using UltimaCR.Spells.Main;

namespace UltimaCR.Rotations
{
    public sealed partial class Bard
    {
        private BardSpells _mySpells;

        private BardSpells MySpells
        {
            get { return _mySpells ?? (_mySpells = new BardSpells()); }
        }

        #region Class Spells

        private async Task<bool> HeavyShot()
        {
            return await MySpells.HeavyShot.Cast();
        }

        private async Task<bool> StraightShot()
        {
            if (Core.Player.HasAura("Straighter Shot") ||
                !Core.Player.HasAura(MySpells.StraightShot.Name, true, 4000))
            {
                return await MySpells.StraightShot.Cast();
            }
            return false;
        }

        private async Task<bool> RagingStrikes()
        {
            return await MySpells.RagingStrikes.Cast();
        }

        private async Task<bool> VenomousBite()
        {
            if (Core.Player.ClassLevel < 64)
            {
                if (!Core.Player.CurrentTarget.HasAura(MySpells.VenomousBite.Name, true, 4000))
                    return await MySpells.VenomousBite.Cast();
            }
            else
            {
                if (!Core.Player.CurrentTarget.HasAura("Caustic Bite", true))
                    return await MySpells.VenomousBite.Cast();
            }
            return false;
        }

        private async Task<bool> MiserysEnd()
        {
            if (Ultima.UltSettings.BardMiserysEnd)
            {
                return await MySpells.MiserysEnd.Cast();
            }
            return false;
        }

        private async Task<bool> Shadowbind()
        {
            return await MySpells.Shadowbind.Cast();
        }

        private async Task<bool> Bloodletter()
        {
            return await MySpells.Bloodletter.Cast();
        }

        private async Task<bool> RepellingShot()
        {
            if (Core.Player.TargetDistance(5, false))
            {
                return await MySpells.RepellingShot.Cast();
            }
            return false;
        }

        private async Task<bool> QuickNock()
        {
            return await MySpells.QuickNock.Cast();
        }

        private async Task<bool> Swiftsong()
        {
            if (!Core.Player.InCombat &&
                !Core.Player.HasAura(MySpells.Swiftsong.Name))
            {
                return await MySpells.Swiftsong.Cast();
            }
            return false;
        }

        private async Task<bool> HawksEye()
        {
            return await MySpells.HawksEye.Cast();
        }

        private async Task<bool> Windbite()
        {
            if (Core.Player.ClassLevel < 64)
            {
                if (!Core.Player.CurrentTarget.HasAura(MySpells.Windbite.Name, true, 4000))
                {
                    return await MySpells.Windbite.Cast();
                }
            }
            else
            {
                if(!Core.Player.CurrentTarget.HasAura("Storm Bite", true))
                    return await MySpells.Windbite.Cast();
            }
            return false;
        }

        private async Task<bool> QuellingStrikes()
        {
            return await MySpells.QuellingStrikes.Cast();
        }

        private async Task<bool> Barrage()
        {
            if (!ActionManager.HasSpell(MySpells.EmpyrealArrow.Name) &&
                DataManager.GetSpellData(97).Cooldown.TotalMilliseconds <= 1000)
            {
                return await MySpells.Barrage.Cast();
            }
            return false;
        }

        private async Task<bool> BluntArrow()
        {
            if (Ultima.UltSettings.BardBluntArrow)
            {
                return await MySpells.BluntArrow.Cast();
            }
            return false;
        }

        private async Task<bool> FlamingArrow()
        {
            if (Ultima.UltSettings.BardFlamingArrow)
            {
                return await MySpells.FlamingArrow.Cast();
            }
            return false;
        }

        private async Task<bool> WideVolley()
        {
            return await MySpells.WideVolley.Cast();
        }

        #endregion

        #region Role Spells

        #endregion

        #region Job Spells
        private async Task<bool> Songs(DateTime lastime)
        {
            var t = (DateTime.Now - lastime).TotalMilliseconds;
            

            if ((ActionResourceManager.Bard.ActiveSong == ActionResourceManager.Bard.BardSong.None
                            || ActionResourceManager.Bard.Timer <= new TimeSpan(0, 0, 0, 3, 0)) 
                            && ActionManager.ActionReady(ActionType.Spell, 114) && t >= 2000)
                return await MySpells.MagesBallad.Cast();
            if ((ActionResourceManager.Bard.ActiveSong == ActionResourceManager.Bard.BardSong.None
                            || ActionResourceManager.Bard.Timer <= new TimeSpan(0, 0, 0, 3, 0))
                            && ActionManager.ActionReady(ActionType.Spell, 3559) && t >= 2000)
                return await MySpells.WanderersMinuet.Cast();
            if ((ActionResourceManager.Bard.ActiveSong == ActionResourceManager.Bard.BardSong.None
                            || ActionResourceManager.Bard.Timer <= new TimeSpan(0, 0, 0, 3, 0))
                            && ActionManager.ActionReady(ActionType.Spell, 116) && t >= 2000)
                return await MySpells.ArmysPaeon.Cast();
            return false;
        }

        private async Task<bool> PitchPerfect()
        {
            if(ActionResourceManager.Bard.ActiveSong == ActionResourceManager.Bard.BardSong.WanderersMinuet && ActionResourceManager.Bard.Repertoire == 3 
                || ActionResourceManager.Bard.ActiveSong == ActionResourceManager.Bard.BardSong.WanderersMinuet && ActionResourceManager.Bard.Timer<= new TimeSpan(0, 0, 0, 3, 0))
                return await MySpells.PitchPerfect.Cast();
            return false;
        }

        private async Task<bool> MagesBallad()
        {
            return await MySpells.MagesBallad.Cast();
        }

        private async Task<bool> FoeRequiem()
        {
            return await MySpells.FoeRequiem.Cast();
        }

        private async Task<bool> ArmysPaeon()
        {
            return await MySpells.ArmysPaeon.Cast();
        }

        private async Task<bool> RainOfDeath()
        {
            if (Ultima.UltSettings.MultiTarget ||
                Ultima.UltSettings.SmartTarget &&
                Helpers.EnemiesNearTarget(8) >= 3)
            {
                return await MySpells.RainOfDeath.Cast();
            }
            return false;
        }

        private async Task<bool> BattleVoice()
        {
            return await MySpells.BattleVoice.Cast();
        }

        private async Task<bool> WanderersMinuet()
        {
            if (Ultima.UltSettings.BardTheWanderersMinuet)
            {
                if (!Core.Player.HasAura(865))
                {
                    return await MySpells.WanderersMinuet.Cast();
                }
            }
            return false;
        }

        private async Task<bool> EmpyrealArrow()
        {
            if (Core.Player.HasAura(MySpells.StraightShot.Name, true, 4000) 
                && ActionResourceManager.Bard.ActiveSong!= ActionResourceManager.Bard.BardSong.None)
                //{
                //    if (ActionManager.CanCast(MySpells.EmpyrealArrow.Name, Core.Player.CurrentTarget))
                //    {
                //        if (await MySpells.Barrage.Cast())
                //        {
                //            await Coroutine.Wait(3000, () => ActionManager.CanCast(MySpells.EmpyrealArrow.Name, Core.Player.CurrentTarget));
                //        }
                //    }
                //    return await MySpells.EmpyrealArrow.Cast();
                //}
                return await MySpells.EmpyrealArrow.Cast();
            return false;
        }

        private async Task<bool> IronJaws()
        {
            if (Core.Player.ClassLevel < 64)
            {
                if (Core.Player.CurrentTarget.HasAura(MySpells.VenomousBite.Name, true) &&
                    Core.Player.CurrentTarget.HasAura(MySpells.Windbite.Name, true))
                {
                    if (!Core.Player.CurrentTarget.HasAura(MySpells.VenomousBite.Name, true, 5000) ||
                        !Core.Player.CurrentTarget.HasAura(MySpells.Windbite.Name, true, 5000))
                        return await MySpells.IronJaws.Cast();
                }
            }
            else
            {
                if (Core.Player.CurrentTarget.HasAura("Caustic Bite", true) &&
                    Core.Player.CurrentTarget.HasAura("Storm Bite", true))
                {
                    if (!Core.Player.CurrentTarget.HasAura("Caustic Bite", true, 5000) ||
                        !Core.Player.CurrentTarget.HasAura("Storm Bite", true, 5000))
                        return await MySpells.IronJaws.Cast();
                }
            }
            return false;
        }

        private async Task<bool> TheWardensPaean()
        {
            return await MySpells.TheWardensPaean.Cast();
        }

        private async Task<bool> Sidewinder()
        {
            if (Core.Player.ClassLevel < 64)
            {
                if (Core.Player.CurrentTarget.HasAura(MySpells.VenomousBite.Name, true, 4000) &&
                    Core.Player.CurrentTarget.HasAura(MySpells.Windbite.Name, true, 4000))
                {
                    return await MySpells.Sidewinder.Cast();
                }
            }
            else
            {
                if (Core.Player.CurrentTarget.HasAura("Caustic Bite", true, 4000) &&
                    Core.Player.CurrentTarget.HasAura("Storm Bite", true, 4000))
                    return await MySpells.Sidewinder.Cast();

            }
            return false;
        }

        private async Task<bool> RefulgentArrow()
        {
            if (Core.Player.HasAura("Straighter Shot"))
            {
                return await MySpells.RefulgentArrow.Cast();
            }
            return false;
        }
        #endregion

        #region PvP Spells

        private async Task<bool> BlastShot()
        {
            return await MySpells.PvP.BlastShot.Cast();
        }

        private async Task<bool> Farshot()
        {
            return await MySpells.PvP.Farshot.Cast();
        }

        private async Task<bool> ManaDraw()
        {
            return await MySpells.PvP.ManaDraw.Cast();
        }

        private async Task<bool> Manasong()
        {
            return await MySpells.PvP.Manasong.Cast();
        }

        private async Task<bool> Purify()
        {
            return await MySpells.PvP.Purify.Cast();
        }

        #endregion
    }
}