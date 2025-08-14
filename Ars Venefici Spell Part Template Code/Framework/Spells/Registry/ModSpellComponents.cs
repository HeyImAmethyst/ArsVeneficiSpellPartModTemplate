using ArsVenefici.Framework.Spells.Components;
using ArsVenefici.Framework.Util;
using ArsVenefici.Framework.Spells.Registry;
using ArsVenefici.Framework.Spells.Shape;
using ArsVeneficiSpellPartModTemplate.Framework.Spells.Components;
using ArsVeneficiSpellPartModTemplate.Framework.Spells.Shapes;

namespace ArsVeneficiSpellPartModTemplate.Framework.Spells.Registry
{
    public class ModSpellComponents
    {
        public static ObjectRegister<AbstractComponent> COMPONENTS = ObjectRegister<AbstractComponent>.Create(ModEntry.ArsVenificiTestModId);

        //Register your custom components here. Make sure to add a translation for them in the translation files.
        //Make sure to add an icon png named with the same id for each component in the content pack included in the template.
        //Those icons goes in "assets/icon/spellpart/"
        //You can look at the Ars Venefici source code for more examples for how these are created.

        public static ObjectHolder<AbstractComponent> EXAMPLE_COMPONENT = RegisterComponent(new ObjectHolder<AbstractComponent>(new ExampleComponent()));
        //public static ObjectHolder<AbstractComponent> SPIRIT_LIGHT = RegisterComponent(new ObjectHolder<AbstractComponent>(new SpiritLight(ArsVenefici.ModEntry.INSTANCE.Helper.Multiplayer.GetNewID)));

        public static ObjectHolder<AbstractComponent> RegisterComponent(ObjectHolder<AbstractComponent> obj)
        {
            ObjectHolder<AbstractComponent> toReturn = COMPONENTS.Register(obj);
            ModEntry.INSTANCE.Monitor.Log("Registered Component " + obj.Get().GetId(), StardewModdingAPI.LogLevel.Info);
            return toReturn;
        }
    }
}
