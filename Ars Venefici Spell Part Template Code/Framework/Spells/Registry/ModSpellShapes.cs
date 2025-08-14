using ArsVenefici.Framework.Spells.Components;
using ArsVenefici.Framework.Util;
using ArsVenefici.Framework.Spells.Registry;
using ArsVenefici.Framework.Spells.Shape;
using ArsVeneficiSpellPartModTemplate.Framework.Spells.Components;
using ArsVeneficiSpellPartModTemplate.Framework.Spells.Shapes;

namespace ArsVeneficiSpellPartModTemplate.Framework.Spells.Registry
{
    public class ModSpellShapes
    {
        public static ObjectRegister<AbstractShape> SHAPES = ObjectRegister<AbstractShape>.Create(ModEntry.ArsVenificiTestModId);

        //Register your custom shapes here. Make sure to add a translation for them in the translation files.
        //Make sure to add an icon png named with the same id for each component in the content pack included in the template.
        //Those icons goes in "assets/icon/spellpart/"
        //You can look at the Ars Venefici source code for more examples for how these are created.

        public static ObjectHolder<AbstractShape> EXAMPLE_SHAPE = RegisterShape(new ObjectHolder<AbstractShape>(new ExampleShape()));

        public static ObjectHolder<AbstractShape> RegisterShape(ObjectHolder<AbstractShape> obj)
        {
            ObjectHolder<AbstractShape> toReturn = SHAPES.Register(obj);
            ModEntry.INSTANCE.Monitor.Log("Registered Shape " + obj.Get().GetId(), StardewModdingAPI.LogLevel.Info);
            return toReturn;
        }
    }
}
