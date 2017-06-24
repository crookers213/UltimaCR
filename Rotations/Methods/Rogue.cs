using ff14bot;
using ff14bot.Managers;
using System.Linq;
using System.Threading.Tasks;
using UltimaCR.Spells.Main;

namespace UltimaCR.Rotations
{
    public sealed partial class Rogue
    {
        private RogueSpells _mySpells;

        private RogueSpells MySpells
        {
            get { return _mySpells ?? (_mySpells = new RogueSpells()); }
        }

        #region Class Spells

        private async Task<bool> SpinningEdge()
        {
            return await MySpells.SpinningEdge.Cast();
        }

        private async Task<bool> ShadeShift()
        {
            return await MySpells.ShadeShift.Cast();
        }

        private async Task<bool> GustSlash()
        {
            if (ActionManager.LastSpell.Name == MySpells.SpinningEdge.Name)
            {
                return await MySpells.GustSlash.Cast();
            }
            return false;
        }

        private async Task<bool> KissOfTheWasp()
        {
            if (Ultima.UltSettings.RogueKissOfTheWasp ||
                !ActionManager.HasSpell(MySpells.KissOfTheViper.Name))
            {
                if (!Core.Player.HasAura(MySpells.KissOfTheWasp.Name))
                {
                    return await MySpells.KissOfTheWasp.Cast();
                }
            }
            return false;
        }

        private async Task<bool> Mutilate()
        {
            if (!ActionManager.HasSpell(MySpells.ShadowFang.Name) ||
                Core.Player.CurrentTarget.HasAura(MySpells.ShadowFang.Name, true, 4000))
            {
                if (!Core.Player.CurrentTarget.HasAura("Mutilation", true, 4000))
                {
                    return await MySpells.Mutilate.Cast();
                }
            }
            return false;
        }

        private async Task<bool> Hide()
        {
            return await MySpells.Hide.Cast();
        }

        private async Task<bool> Assassinate()
        {
            if (Ultima.UltSettings.RogueAssassinate)
            {
                return await MySpells.Assassinate.Cast();
            }
            return false;
        }

        private async Task<bool> ThrowingDagger()
        {
            if (Core.Player.TargetDistance(10))
            {
                return await MySpells.ThrowingDagger.Cast();
            }
            return false;
        }

        private async Task<bool> Mug()
        {
            return await MySpells.Mug.Cast();
        }

        private async Task<bool> Goad()
        {
            if (Ultima.UltSettings.RogueGoad)
            {
                var target = Helpers.GoadManager.FirstOrDefault();

                if (target != null)
                {
                    return await MySpells.Goad.Cast(target);
                }
            }
            return false;
        }

        private async Task<bool> SneakAttack()
        {
            return await MySpells.SneakAttack.Cast();
        }

        private async Task<bool> AeolianEdge()
        {
            if (ActionManager.LastSpell.Name == MySpells.GustSlash.Name)
            {
                return await MySpells.AeolianEdge.Cast();
            }
            return false;
        }

        private async Task<bool> KissOfTheViper()
        {
            if (Ultima.UltSettings.RogueKissOfTheViper &&
                !Core.Player.HasAura(MySpells.KissOfTheViper.Name))
            {
                return await MySpells.KissOfTheViper.Cast();
            }
            return false;
        }

        private async Task<bool> Jugulate()
        {
            if (Ultima.UltSettings.RogueJugulate)
            {
                return await MySpells.Jugulate.Cast();
            }
            return false;
        }

        private async Task<bool> DancingEdge()
        {
            if (Ultima.UltSettings.RogueDancingEdge)
            {
                if (!Core.Player.CurrentTarget.HasAura(MySpells.DancingEdge.Name, false, 6000) &&
                    !Core.Player.CurrentTarget.HasAura("Storm's Eye", false, 6000) &&
                    ActionManager.LastSpell.Name == MySpells.GustSlash.Name)
                {
                    return await MySpells.DancingEdge.Cast();
                }
            }
            return false;
        }

        private async Task<bool> DeathBlossom()
        {
            return await MySpells.DeathBlossom.Cast();
        }

        private async Task<bool> ShadowFang()
        {
            if (Core.Player.CurrentTarget.HasAura(MySpells.DancingEdge.Name, false, 6000) ||
                Core.Player.CurrentTarget.HasAura("Storm's Eye", false, 6000) ||
                !Ultima.UltSettings.RogueDancingEdge)
            {
                if (!Core.Player.CurrentTarget.HasAura(MySpells.ShadowFang.Name, true, 4000) &&
                    ActionManager.LastSpell.Name == MySpells.SpinningEdge.Name)
                {
                    return await MySpells.ShadowFang.Cast();
                }
            }
            return false;
        }

        private async Task<bool> TrickAttack()
        {
            return await MySpells.TrickAttack.Cast();
        }

        #endregion

        #region Role Spells

        #endregion

        #region PvP Spells

        private async Task<bool> Detect()
        {
            return await MySpells.PvP.Detect.Cast();
        }

        private async Task<bool> IllWind()
        {
            return await MySpells.PvP.IllWind.Cast();
        }

        private async Task<bool> Malmsight()
        {
            return await MySpells.PvP.Malmsight.Cast();
        }

        private async Task<bool> Overwhelm()
        {
            return await MySpells.PvP.Overwhelm.Cast();
        }

        private async Task<bool> Purify()
        {
            return await MySpells.PvP.Purify.Cast();
        }

        private async Task<bool> Recouperate()
        {
            return await MySpells.PvP.Recouperate.Cast();
        }

        #endregion
    }
}