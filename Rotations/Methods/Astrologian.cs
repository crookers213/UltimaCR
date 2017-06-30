using ff14bot;
using ff14bot.Managers;
using System.Linq;
using System.Threading.Tasks;
using UltimaCR.Spells;
using UltimaCR.Spells.Main;

namespace UltimaCR.Rotations
{
    public sealed partial class Astrologian
    {
        private AstrologianSpells _mySpells;

        private AstrologianSpells MySpells
        {
            get { return _mySpells ?? (_mySpells = new AstrologianSpells()); }
        }

        #region ST
        
        private async Task<bool> Malefic()
        {
            if (!ActionManager.HasSpell(MySpells.MaleficII.Name))
            {
                return await MySpells.Malefic.Cast();
            }
            return false;
        }
        
        private async Task<bool> MaleficII()
        {
            if (!ActionManager.HasSpell(MySpells.MaleficIII.Name))
            {
                return await MySpells.MaleficII.Cast();
            }
            return false;
        }
        
        private async Task<bool> MaleficIII()
        {
            return await MySpells.MaleficIII.Cast();
        }
        
        #endregion
        
        #region AoE
        
        private async Task<bool> Gravity()
        {
            if (Helpers.EnemiesNearTarget(5) > 2 && Core.Player.CurrentManaPercent > 40)
            {
                return await MySpells.Gravity.Cast();
            }
            return false;
        }
        
        #endregion
        
        #region Heals
        
        private async Task<bool> Benefic()
        {
            if (Ultima.UltSettings.AstrologianBenefic && !ActionManager.HasSpell(MySpells.BeneficII.Name) && 
        Core.Player.CurrentHealthPercent < 50)
            {
                return await MySpells.Benefic.Cast();
            }
            return false;
        }
        
        private async Task<bool> BeneficII()
        {
            if (Ultima.UltSettings.AstrologianBeneficII && Core.Player.CurrentHealthPercent < 50)
            {
                return await MySpells.BeneficII.Cast();
            }
            return false;
        }
        
        private async Task<bool> AspectedBenefic()
        {
            if (Ultima.UltSettings.AstrologianAspectedBenefic && Core.Player.CurrentHealthPercent < 70 &&
        !Core.Player.HasAura(MySpells.AspectedBenefic.Name))
            {
                return await MySpells.AspectedBenefic.Cast();
            }
            return false;
        }
        
        #endregion
        
        #region Off-GCD
        
        private async Task<bool> Lightspeed()
        {
            return await MySpells.Lightspeed.Cast();
        }
        
        private async Task<bool> EssentialDignity()
        {
            if (Ultima.UltSettings.AstrologianEssentialDignity && Core.Player.CurrentHealthPercent < 30)
            {
                return await MySpells.EssentialDignity.Cast();
            }
            return false;
        }
        
        private async Task<bool> Draw()
        {
            if (Ultima.UltSettings.AstrologianDraw)
            {
                return await MySpells.Draw.Cast();
            }
            return false;
        }
        
        private async Task<bool> Spread()
        {
            if ((HasSpread && HasBuff) || (!HasSpread && !HasBuff))
            {
                return await MySpells.Spread.Cast();
            }
            return false;
        }

        private async Task<bool> RoyalRoad()
        {
            if (BoleActive || SpearActive)
            {
                return await MySpells.RoyalRoad.Cast();
            }
            return false;
        }
        
        private async Task<bool> Redraw()
        {
            if (!BalanceActive && !ArrowActive)
            {
                return await MySpells.Redraw.Cast();
            }
            return false;
        }
        
        private async Task<bool> Undraw()
        {
            if (DataManager.GetSpellData(3593).Cooldown.TotalSeconds <= 27)
            {
                if (EwerActive || SpireActive)
                {
                    return await MySpells.Undraw.Cast();
                }
            }
            return false;
        }
        
        private async Task<bool> Synastry()
        {
            return await MySpells.Synastry.Cast();
        }
        
        private async Task<bool> TimeDilation()
        {
            return await MySpells.TimeDilation.Cast();
        }
        
        #endregion
        
        #region Buffs
        
        private async Task<bool> DiurnalSect()
        {
            if (!Core.Player.HasAura(MySpells.DiurnalSect.Name))
            {
                return await MySpells.DiurnalSect.Cast();
            }
            return false;
        }
        
        private async Task<bool> NocturnalSect()
        {
            return await MySpells.NocturnalSect.Cast();
        }
        
        #endregion
        
        #region Debuffs
        
        private async Task<bool> Combust()
        {
            if (!ActionManager.HasSpell(MySpells.CombustII.Name) && !Core.Player.CurrentTarget.HasAura(MySpells.Combust.Name, true, 4000))
            {
                return await MySpells.Combust.Cast();
            }
            return false;
        }
        
        private async Task<bool> CombustII()
        {
            if (!Core.Player.CurrentTarget.HasAura(MySpells.CombustII.Name, true, 4000))
            {
                return await MySpells.CombustII.Cast();
            }
            return false;
        }
        
        #endregion

        #region Role Spells
        
        private async Task<bool> ClericStance()
        {
            return await MySpells.Role.ClericStance.Cast();
        }

        private async Task<bool> Protect()
        {
            if (!Core.Player.HasAura(MySpells.Role.Protect.Name))
            {
                return await MySpells.Role.Protect.Cast();
            }
            return false;
        }

        private async Task<bool> Esuna()
        {
            return await MySpells.Role.Esuna.Cast();
        }
        
        private async Task<bool> LucidDreaming()
        {
            if (Core.Player.CurrentManaPercent <= 60)
            {
                return await MySpells.Role.LucidDreaming.Cast();
            }
            return false;
        }
        
        private async Task<bool> Swiftcast()
        {
            return await MySpells.Role.Swiftcast.Cast();
        }
        
        private async Task<bool> Largesse()
        {
            return await MySpells.Role.Largesse.Cast();
        }

        #endregion
        
        #region Custom Spells
        
        private static bool HasCard
        {
            get
            {
                return ActionResourceManager.Astrologian.Cards[0] != ActionResourceManager.Astrologian.AstrologianCard.None;
            }
        }
        
        private static bool HasSpread
        {
            get
            {
                return ActionResourceManager.Astrologian.Cards[1] != ActionResourceManager.Astrologian.AstrologianCard.None;
            }
        }
        
        private static bool HasBuff
        {
            get
            {
                return ActionResourceManager.Astrologian.Buff != ActionResourceManager.Astrologian.AstrologianCardBuff.None;
            }
        }
        
        private static bool BuffDuration
        {
            get
            {
                return ActionResourceManager.Astrologian.Buff == ActionResourceManager.Astrologian.AstrologianCardBuff.Duration;
            }
        }
        
        private static bool BuffPotency
        {
            get
            {
                return ActionResourceManager.Astrologian.Buff == ActionResourceManager.Astrologian.AstrologianCardBuff.Potency;
            }
        }
        
        private static bool BuffShared
        {
            get
            {
                return ActionResourceManager.Astrologian.Buff == ActionResourceManager.Astrologian.AstrologianCardBuff.Shared;
            }
        }
        
        private static bool BalanceActive
        {
            get
            {
                return ActionResourceManager.Astrologian.Cards[0] == ActionResourceManager.Astrologian.AstrologianCard.Balance;
            }
        }
        
        private static bool BoleActive
        {
            get
            {
                return ActionResourceManager.Astrologian.Cards[0] == ActionResourceManager.Astrologian.AstrologianCard.Bole;
            }
        }
        
        private static bool ArrowActive
        {
            get
            {
                return ActionResourceManager.Astrologian.Cards[0] == ActionResourceManager.Astrologian.AstrologianCard.Arrow;
            }
        }
        
        private static bool SpearActive
        {
            get
            {
                return ActionResourceManager.Astrologian.Cards[0] == ActionResourceManager.Astrologian.AstrologianCard.Spear;
            }
        }
        
        private static bool EwerActive
        {
            get
            {
                return ActionResourceManager.Astrologian.Cards[0] == ActionResourceManager.Astrologian.AstrologianCard.Ewer;
            }
        }
        
        private static bool SpireActive
        {
            get
            {
                return ActionResourceManager.Astrologian.Cards[0] == ActionResourceManager.Astrologian.AstrologianCard.Spire;
            }
        }

        #endregion

        #region PvP Spells

        #endregion
    }
}