using ArsVenefici.Framework.API.Spell;
using ArsVenefici.Framework.Spells.Modifiers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArsVeneficiSpellPartModTemplate.Framework.Spells.Modifiers
{
    public class ExampleModifier : AbstractModifier
    {
        public override string GetId()
        {
            return "example_modifier";
        }

        public override ISpellPartStatModifier GetStatModifier(ISpellPartStat stat)
        {
            throw new NotImplementedException();
        }

        public override List<ISpellPartStat> GetStatsModified()
        {
            throw new NotImplementedException();
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
