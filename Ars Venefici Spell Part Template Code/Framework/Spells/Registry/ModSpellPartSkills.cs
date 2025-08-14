using ArsVenefici.Framework.API.Skill;
using ArsVenefici.Framework.Spells.Components;
using ArsVenefici.Framework.Spells.Registry;
using ArsVenefici.Framework.Spells.Shape;
using ArsVenefici.Framework.Util;
using StardewValley;
using StardewValley.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static StardewValley.Menus.CharacterCustomization;

namespace ArsVeneficiSpellPartModTemplate.Framework.Spells.Registry
{
    public class ModSpellPartSkills
    {
        public static ObjectRegister<SpellPartSkill> SKILLS = ObjectRegister<SpellPartSkill>.Create(ModEntry.ArsVenificiTestModId);

        //For each shape, component, or modifier you add, you must create and register skill for them so they show up in the magic altar.
        //All these custom skill must have a parent due to how the skill tree is made.
        //Make sure the id for the skill is the same as the spell part it is for (example: both the dig spell part and skill have the id "dig").
        //You can look at the Ars Venefici source code for more examples for how these are created.

        public static ObjectHolder<SpellPartSkill> EXAMPLE_SHAPE_SKILL = RegisterSpellPartSkill(new ObjectHolder<SpellPartSkill>(new SpellPartSkill("example_shape", new Dictionary<Item, int>() { { ItemRegistry.Create("((O)93"), 1 } }, ArsSpellPartSkills.utilityTab, false)));
        public static ObjectHolder<SpellPartSkill> EXAMPLE_COMPONENT_SKILL = RegisterSpellPartSkill(new ObjectHolder<SpellPartSkill>(new SpellPartSkill("example_component", new Dictionary<Item, int>() { { ItemRegistry.Create("((O)93"), 1 } }, ArsSpellPartSkills.utilityTab, false)));
        public static ObjectHolder<SpellPartSkill> EXAMPLE_GENERIC_MODIFIER_SKILL = RegisterSpellPartSkill(new ObjectHolder<SpellPartSkill>(new SpellPartSkill("example_generic_modifier", new Dictionary<Item, int>() { { ItemRegistry.Create("((O)93"), 1 } }, ArsSpellPartSkills.utilityTab, false)));
        public static ObjectHolder<SpellPartSkill> EXAMPLE_MODIFIER_SKILL = RegisterSpellPartSkill(new ObjectHolder<SpellPartSkill>(new SpellPartSkill("example_modifier", new Dictionary<Item, int>() { { ItemRegistry.Create("((O)93"), 1 } }, ArsSpellPartSkills.utilityTab, false)));
        
        //public static ObjectHolder<SpellPartSkill> SPIRIT_LIGHT = RegisterSpellPartSkill(new ObjectHolder<SpellPartSkill>(new SpellPartSkill("spirit_light", new Dictionary<Item, int>() { { ItemRegistry.Create("((O)93"), 1 } }, ArsSpellPartSkills.utilityTab, false)));

        public static void SetSkillParents()
        {
            EXAMPLE_SHAPE_SKILL.Get().SetParents(ArsSpellPartSkills.TOUCH.Get());
            EXAMPLE_COMPONENT_SKILL.Get().SetParents(ArsSpellPartSkills.TOUCH.Get());
            EXAMPLE_GENERIC_MODIFIER_SKILL.Get().SetParents(ArsSpellPartSkills.TOUCH.Get());
            EXAMPLE_MODIFIER_SKILL.Get().SetParents(ArsSpellPartSkills.TOUCH.Get());

            //SPIRIT_LIGHT.Get().SetParents(ArsSpellPartSkills.DIG.Get());
        }

        public static ObjectHolder<SpellPartSkill> RegisterSpellPartSkill(ObjectHolder<SpellPartSkill> obj)
        {
            ObjectHolder<SpellPartSkill> toReturn = SKILLS.Register(obj);
            return toReturn;
        }
    }
}
