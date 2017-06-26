using ff14bot;
using ff14bot.Managers;
using System.Threading.Tasks;
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

        #region Job Spells

        private async Task<bool> Malefic()
        {
            if (Core.Player.ClassLevel < 54)
            {
                return await MySpells.Malefic.Cast();
            }
            return false;
        }
        
        private async Task<bool> MaleficII()
        {
            if (Core.Player.ClassLevel < 64)
            {
                return await MySpells.MaleficII.Cast();
            }
            return false;
        }
        
        private async Task<bool> MaleficIII()
        {
            return await MySpells.MaleficIII.Cast();
        }
        
        private async Task<bool> Combust()
        {
            if (Core.Player.ClassLevel < 46 && !Core.Player.CurrentTarget.HasAura(MySpells.Combust.Name, true, 4000))
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
        
        private async Task<bool> Benefic()
        {
            if (Core.Player.ClassLevel < 26 && Ultima.UltSettings.AstrologianBenefic && Core.Player.CurrentHealthPercent < 50)
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
        
        private async Task<bool> EssentialDignity()
        {
            if (Ultima.UltSettings.AstrologianEssentialDignity && Core.Player.CurrentHealthPercent < 30)
            {
                return await MySpells.EssentialDignity.Cast();
            }
            return false;
        }
        
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
        
        private async Task<bool> Lightspeed()
        {
            return await MySpells.Lightspeed.Cast();
        }
        
        private async Task<bool> Draw()
        {
            if (Ultima.UltSettings.AstrologianDraw)
            {
                return await MySpells.Draw.Cast();
            }
            return false;
        }

        private async Task<bool> RoyalRoad()
        {
            return await MySpells.RoyalRoad.Cast();
        }
        
        private async Task<bool> Spread()
        {
            return await MySpells.Spread.Cast();
        }
        
        private async Task<bool> Redraw()
        {
            return await MySpells.Redraw.Cast();
        }

        private async Task<bool> Synastry()
        {
            return await MySpells.Synastry.Cast();
        }
        
        private async Task<bool> Gravity()
        {
            return await MySpells.Gravity.Cast();
        }
        
        private async Task<bool> TimeDilation()
        {
            return await MySpells.TimeDilation.Cast();
        }
        
        private async Task<bool> CollectiveUnconscious()
        {
            return await MySpells.CollectiveUnconscious.Cast();
        }
        
        private async Task<bool> CelestialOpposition()
        {
            return await MySpells.CelestialOpposition.Cast();
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
                return ActionResourceManager.Astrologian.Arcana != ActionResourceManager.Astrologian.AstrologianCard.None;
            }
        }

        #endregion

        #region PvP Spells

        #endregion
    }
}