using ArsVenefici.Framework.API.Spell;
using ArsVenefici.Framework.Interfaces;
using ArsVenefici.Framework.Interfaces.Spells;
using ArsVenefici.Framework.Spells.Components;
using ArsVenefici.Framework.Util;
using StardewValley;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArsVeneficiSpellPartModTemplate.Framework.Spells.Components
{
    public class ExampleComponent : AbstractComponent
    {
        public override string GetId()
        {
            return "example_component";
        }

        public override SpellCastResult Invoke(ArsVenefici.ModEntry modEntry, ISpell spell, IEntity caster, GameLocation gameLocation, List<ISpellModifier> modifiers, CharacterHitResult target, int index, int ticksUsed)
        {
            return new SpellCastResult(SpellCastResultType.SUCCESS);
        }

        public override SpellCastResult Invoke(ArsVenefici.ModEntry modEntry, ISpell spell, IEntity caster, GameLocation gameLocation, List<ISpellModifier> modifiers, TerrainFeatureHitResult target, int index, int ticksUsed)
        {
            return new SpellCastResult(SpellCastResultType.SUCCESS);
        }

        public override float ManaCost()
        {
            return 1;
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
