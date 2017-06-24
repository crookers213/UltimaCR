﻿using Buddy.Coroutines;
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
            return await MySpells.Stone.Cast();
        }

        private async Task<bool> Cure()
        {
            if (!Core.Player.HasAura(155))
            {
                var target = Helpers.HealManager.FirstOrDefault(hm =>
                    hm.IsHealer() && hm.CurrentHealthPercent <= 70 ||
                    hm.IsDPS() && hm.CurrentHealthPercent <= 75 ||
                    hm.IsTank() && hm.CurrentHealthPercent <= 80);

                if (target != null)
                {
                    return await MySpells.Cure.Cast(target);
                }
            }
            return false;
        }

        private async Task<bool> Aero()
        {
            if (!Core.Player.CurrentTarget.HasAura(MySpells.Aero.Name, true, 4000))
            {
                return await MySpells.Aero.Cast();
            }
            return false;
        }

        private async Task<bool> ClericStance()
        {
            return await MySpells.ClericStance.Cast();
        }

        private async Task<bool> Protect()
        {
            if (Ultima.UltSettings.ConjurerProtect &&
                !Helpers.HealManager.Any(hm => hm.CurrentHealthPercent <= 70 || hm.IsDead))
            {
                var target = Helpers.HealManager.FirstOrDefault(hm => hm.Type == GameObjectType.Pc && !hm.HasAura(MySpells.Protect.Name));

                if (target != null)
                {
                    return await MySpells.Protect.Cast(target);
                }
            }
            return false;
        }

        private async Task<bool> Medica()
        {
            if (Helpers.HealManager.Count(hm =>
                hm.Distance2D(Core.Player) - hm.CombatReach - Core.Player.CombatReach <= 15 &&
                (hm.IsHealer() && hm.CurrentHealthPercent <= 55 ||
                hm.IsDPS() && hm.CurrentHealthPercent <= 60 ||
                hm.IsTank() && hm.CurrentHealthPercent <= 65)) > 2)
            {
                return await MySpells.Medica.Cast();
            }
            return false;
        }

        private async Task<bool> Raise()
        {
            /*if (Ultima.UltSettings.ConjurerRaise &&
                !Helpers.HealManager.Any(hm => hm.CurrentHealthPercent <= 70))
            {
                var target = Helpers.PartyMembers.FirstOrDefault(pm =>
                    pm.IsDead &&
                    pm.Type == GameObjectType.Pc &&
                    !pm.HasAura(MySpells.Raise.Name));

                if (target != null &&
                    ActionManager.CanCast(MySpells.Raise.Name, target))
                {
                    if (ActionManager.CanCast(MySpells.CrossClass.Swiftcast.Name, Core.Player))
                    {
                        if (await MySpells.CrossClass.Swiftcast.Cast())
                        {
                            await Coroutine.Wait(3000, () => ActionManager.CanCast(MySpells.Raise.Name, target) &&
                                                             Core.Player.HasAura(MySpells.CrossClass.Swiftcast.Name));
                        }
                    }
                    return await MySpells.Raise.Cast(target);
                }
            }*/
            return false;
        }

        private async Task<bool> FluidAura()
        {
            if (Core.Player.TargetDistance(5, false))
            {
                return await MySpells.FluidAura.Cast();
            }
            return false;
        }

        private async Task<bool> Esuna()
        {
            return await MySpells.Esuna.Cast();
        }

        private async Task<bool> StoneII()
        {
            return await MySpells.StoneII.Cast();
        }

        private async Task<bool> Repose()
        {
            return await MySpells.Repose.Cast();
        }

        private async Task<bool> CureII()
        {
            var target = Helpers.HealManager.FirstOrDefault(hm =>
                hm.IsHealer() && hm.CurrentHealthPercent <= 55 ||
                hm.IsDPS() && hm.CurrentHealthPercent <= 60 ||
                hm.IsTank() && hm.CurrentHealthPercent <= 65);

            if (target != null)
            {
                return await MySpells.CureII.Cast(target);
            }
            return false;
        }

        private async Task<bool> Stoneskin()
        {
            if (Ultima.UltSettings.ConjurerStoneskin &&
                Ultima.LastSpell.Name != MySpells.StoneskinII.Name)
            {
                var target =
                    Helpers.HealManager.FirstOrDefault(hm => !hm.HasAura(MySpells.Stoneskin.Name) && !hm.InCombat);

                if (target != null)
                {
                    return await MySpells.Stoneskin.Cast(target);
                }
            }
            return false;
        }

        private async Task<bool> ShroudOfSaints()
        {
            if (Ultima.UltSettings.ConjurerShroudOfSaints &&
                Core.Player.CurrentManaPercent <= 50)
            {
                return await MySpells.ShroudOfSaints.Cast();
            }
            return false;
        }

        private async Task<bool> CureIII()
        {
            var target = Helpers.HealManager.FirstOrDefault(pm1 =>
                Helpers.HealManager.Count(pm2 =>
                    pm1.Distance2D(pm2) - pm1.CombatReach - pm2.CombatReach <= 4 &&
                    (pm2.IsHealer() && pm2.CurrentHealthPercent <= 55 ||
                    pm2.IsDPS() && pm2.CurrentHealthPercent <= 60 ||
                    pm2.IsTank() && pm2.CurrentHealthPercent <= 65)) > 2);

            if (target != null)
            {
                return await MySpells.CureIII.Cast(target);
            }
            return false;
        }

        private async Task<bool> AeroII()
        {
            if (!Core.Player.CurrentTarget.HasAura(MySpells.AeroII.Name, true, 4000))
            {
                return await MySpells.AeroII.Cast();
            }
            return false;
        }

        private async Task<bool> MedicaII()
        {
            if (Helpers.HealManager.Count(hm =>
                hm.Distance2D(Core.Player) - hm.CombatReach - Core.Player.CombatReach <= 25 &&
                (hm.IsHealer() && hm.CurrentHealthPercent <= 55 ||
                hm.IsDPS() && hm.CurrentHealthPercent <= 60 ||
                hm.IsTank() && hm.CurrentHealthPercent <= 65)) > 2)
            {
                return await MySpells.MedicaII.Cast();
            }
            return false;
        }

        private async Task<bool> StoneskinII()
        {
            if (Ultima.UltSettings.ConjurerStoneskinII &&
                Helpers.HealManager.Count(hm => !hm.HasAura(MySpells.Stoneskin.Name) && hm.Distance2D(Core.Player) - hm.CombatReach - Core.Player.CombatReach <= 15) >= 3)
            {
                return await MySpells.StoneskinII.Cast();
            }
            return false;
        }

        #endregion

        #region Role Spells

        #endregion

        #region PvP Spells

        private async Task<bool> AethericBurst()
        {
            return await MySpells.PvP.AethericBurst.Cast();
        }

        private async Task<bool> Attunement()
        {
            return await MySpells.PvP.Attunement.Cast();
        }

        private async Task<bool> DivineBreath()
        {
            return await MySpells.PvP.DivineBreath.Cast();
        }

        private async Task<bool> Equanimity()
        {
            return await MySpells.PvP.Equanimity.Cast();
        }

        private async Task<bool> Focalization()
        {
            return await MySpells.PvP.Focalization.Cast();
        }

        private async Task<bool> ManaDraw()
        {
            return await MySpells.PvP.ManaDraw.Cast();
        }

        private async Task<bool> Purify()
        {
            return await MySpells.PvP.Purify.Cast();
        }

        private async Task<bool> SacredPrism()
        {
            return await MySpells.PvP.SacredPrism.Cast();
        }

        #endregion
    }
}