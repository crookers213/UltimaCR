using ff14bot;
using ff14bot.Managers;
using System.Linq;
using System.Threading.Tasks;
using UltimaCR.Spells.Main;

namespace UltimaCR.Rotations
{
    public sealed partial class Paladin
    {
        private PaladinSpells _mySpells;

        private PaladinSpells MySpells
        {
            get { return _mySpells ?? (_mySpells = new PaladinSpells()); }
        }

        #region ST

        private async Task<bool> FastBlade()
        {
            return await MySpells.FastBlade.Cast();
        }

        private async Task<bool> SavageBlade()
        {
            if (ActionManager.LastSpell.Name == MySpells.FastBlade.Name)
            {
                return await MySpells.SavageBlade.Cast();
            }
            return false;
        }

        private async Task<bool> RageOfHalone()
        {
            if (ActionManager.LastSpell.Name == MySpells.SavageBlade.Name)
            {
                return await MySpells.RageOfHalone.Cast();
            }
            return false;
        }

        private async Task<bool> RiotBlade()
        {
            if (ActionManager.LastSpell.Name == MySpells.FastBlade.Name)
            {
                if (Core.Player.CurrentManaPercent < 40 || ActionManager.HasSpell(MySpells.RoyalAuthority.Name) ||
                    (ActionManager.HasSpell(MySpells.GoringBlade.Name) &&
                     !Core.Player.CurrentTarget.HasAura(MySpells.GoringBlade.Name, true, 4000)))
                {
                    return await MySpells.RiotBlade.Cast();
                }
            }
            return false;
        }

        private async Task<bool> GoringBlade()
        {
            if (ActionManager.LastSpell.Name == MySpells.RiotBlade.Name &&
                !Core.Player.CurrentTarget.HasAura(MySpells.GoringBlade.Name, true, 4000))
            {
                return await MySpells.GoringBlade.Cast();
            }
            return false;
        }

        private async Task<bool> RoyalAuthority()
        {
            if (ActionManager.LastSpell.Name == MySpells.RiotBlade.Name)
            {
                return await MySpells.RoyalAuthority.Cast();
            }
            return false;
        }

        private async Task<bool> ShieldLob()
        {
            if (Core.Player.TargetDistance(10))
            {
                return await MySpells.ShieldLob.Cast();
            }
            return false;
        }

        #endregion

        #region AoE

        private async Task<bool> Flash()
        {
            if (Core.Player.CurrentManaPercent > 40)
            {
                return await MySpells.Flash.Cast();
            }
            return false;
        }
        
        private async Task<bool> TotalEclipse()
        {
            if (Core.Player.CurrentTPPercent > 40)
            {
                return await MySpells.TotalEclipse.Cast();
            }
            return false;
        }

        #endregion

        #region Heals
        
        private async Task<bool> Clemency()
        {
            if (Core.Player.CurrentHealthPercent < 60 && Core.Player.CurrentManaPercent > 40 && !MovementManager.IsMoving)
            {
                return await MySpells.Clemency.Cast();
            }
            return false;
        }

        #endregion

        #region Off-GCD

        private async Task<bool> ShieldSwipe()
        {
            if (Ultima.UltSettings.PaladinShieldSwipe)
            {
                return await MySpells.ShieldSwipe.Cast();
            }
            return false;
        }

        private async Task<bool> SpiritsWithin()
        {
            if (Ultima.UltSettings.PaladinSpiritsWithin)
            {
                return await MySpells.SpiritsWithin.Cast();
            }
            return false;
        }

        private async Task<bool> CircleOfScorn()
        {
            return await MySpells.CircleOfScorn.Cast();
        }
        
        private async Task<bool> Sheltron()
        {
            if (OathValue == 100 || (Core.Player.CurrentManaPercent < 70 && OathValue > 50))
            {
                return await MySpells.Sheltron.Cast();
            }
            return false;
        }

        #endregion

        #region Buffs

        private async Task<bool> FightOrFlight()
        {
            return await MySpells.FightOrFlight.Cast();
        }

        private async Task<bool> ShieldOath()
        {
            if (Ultima.UltSettings.PaladinShieldOath &&
                !Core.Player.HasAura(MySpells.ShieldOath.Name))
            {
                return await MySpells.ShieldOath.Cast();
            }
            return false;
        }

        private async Task<bool> SwordOath()
        {
            if (Ultima.UltSettings.PaladinSwordOath ||
                !ActionManager.HasSpell(MySpells.ShieldOath.Name))
            {
                if (!Core.Player.HasAura(MySpells.SwordOath.Name))
                {
                    return await MySpells.SwordOath.Cast();
                }
            }
            return false;
        }

        #endregion

        #region Role

        #endregion
        
        #region Custom
        
        private static int OathValue
        {
            get
            {
                return ActionResourceManager.Paladin.Oath;
            }
        }
        
        #endregion

        #region PVP

        #endregion
    }
}