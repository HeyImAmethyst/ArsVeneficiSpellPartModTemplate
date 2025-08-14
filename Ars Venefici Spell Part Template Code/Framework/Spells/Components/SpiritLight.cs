using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArsVenefici.Framework.API.Spell;
using ArsVenefici.Framework.Interfaces.Spells;
using ArsVenefici.Framework.Interfaces;
using ArsVenefici.Framework.Spells.Components;
using ArsVenefici.Framework.Util;
using StardewValley;

namespace ArsVeneficiSpellPartModTemplate.Framework.Spells.Components
{
    public class SpiritLight : AbstractComponent
    {
        private readonly Func<long> GetNewId;

        public SpiritLight(Func<long> getNewId) : base()
        {
            this.GetNewId = getNewId;
        }

        public override string GetId()
        {
            return "spirit_light";
        }

        public override SpellCastResult Invoke(ArsVenefici.ModEntry modEntry, ISpell spell, IEntity caster, GameLocation gameLocation, List<ISpellModifier> modifiers, CharacterHitResult target, int index, int ticksUsed)
        {
            Farmer player = ((Farmer)caster.entity);

            TilePos tile = new TilePos(Utils.AbsolutePosToTilePos(Utility.clampToTile(target.GetCharacter().getStandingPosition())));

            Torch torch = new Torch(1, "94");

            if (!gameLocation.objects.ContainsKey(tile.GetVector()))
            {
                gameLocation.objects.Add(tile.GetVector(), torch);
                torch.initializeLightSource(tile.GetVector());

                torch.Fragility = 1;

                if (player != null)
                {
                    Game1.playSound("woodyStep");
                }

                return new SpellCastResult(SpellCastResultType.SUCCESS);
            }

            return new SpellCastResult(SpellCastResultType.EFFECT_FAILED);
        }

        public override SpellCastResult Invoke(ArsVenefici.ModEntry modEntry, ISpell spell, IEntity caster, GameLocation gameLocation, List<ISpellModifier> modifiers, TerrainFeatureHitResult target, int index, int ticksUsed)
        {
            Farmer player = ((Farmer)caster.entity);

            TilePos tile = target.GetTilePos();

            Torch torch = new Torch(1, "94");

            if (!gameLocation.objects.ContainsKey(tile.GetVector()))
            {
                gameLocation.objects.Add(tile.GetVector(), torch);
                torch.initializeLightSource(tile.GetVector());

                torch.Fragility = 1;

                if (player != null)
                {
                    Game1.playSound("woodyStep");
                }

                return new SpellCastResult(SpellCastResultType.SUCCESS);
            }

            return new SpellCastResult(SpellCastResultType.EFFECT_FAILED);
        }

        public override float ManaCost()
        {
            return 7;
        }

        public override string DisplayName()
        {
            return ModEntry.INSTANCE.Helper.Translation.Get($"spellpart.{GetId()}.name");
        }

        public override string DisplayDiscription()
        {
            return ModEntry.INSTANCE.Helper.Translation.Get($"spellpart.{GetId()}.description");
        }
    }
}
