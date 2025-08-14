
using ArsVeneficiSpellPartModTemplate.Framework.Spells.Modifiers;
using ArsVenefici.Framework.API.Spell;
using ArsVenefici.Framework.Spells;
using ArsVenefici.Framework.Spells.Modifiers;
using ArsVenefici.Framework.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArsVeneficiSpellPartModTemplate.Framework.Spells.Registry
{
    public class ModSpellModifers
    {
        public static ObjectRegister<AbstractModifier> MODIFIERS = ObjectRegister<AbstractModifier>.Create(ModEntry.ArsVenificiTestModId);

        //Register your custom modifiers here. Make sure to add a translation for them in the translation files.
        //For most modifiers you add, making a new GenericSpellModifier instance and tweaking the values would suffice.
        //If you want a modifier that add custom behavior, you can use a new class that extends from AbtractModifier.
        //You can look at the Ars Venefici source code for more examples for how these are created.

        public static ObjectHolder<AbstractModifier> EXAMPLE_MODIFER = RegisterModifier(new ObjectHolder<AbstractModifier>(new GenericSpellModifier("example_generic_modifier", ModEntry.INSTANCE.Helper, 1.25f).AddStatModifier(new SpellPartStats(SpellPartStatType.DAMAGE), DefaultSpellPartStatModifier.Add(5f))));
        public static ObjectHolder<AbstractModifier> EXAMPLE_MODIFER2 = RegisterModifier(new ObjectHolder<AbstractModifier>(new ExampleModifier()));

        public static ObjectHolder<AbstractModifier> RegisterModifier(ObjectHolder<AbstractModifier> obj)
        {
            ObjectHolder<AbstractModifier> toReturn = MODIFIERS.Register(obj);
            ModEntry.INSTANCE.Monitor.Log("Registered Modifier " + obj.Get().GetId(), StardewModdingAPI.LogLevel.Info);
            return toReturn;
        }
    }
}
