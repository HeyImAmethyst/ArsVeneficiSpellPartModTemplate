using ArsVeneficiSpellPartModTemplate.Framework.Spells.Registry;
using ArsVenefici.Framework.Events;
using ArsVenefici.Framework.Skill;
using ArsVenefici.Framework.Spells.Registry;
using StardewModdingAPI;
using StardewModdingAPI.Events;
using StardewValley;

namespace ArsVeneficiSpellPartModTemplate
{
    public class ModEntry : Mod
    {
        public static ModEntry INSTANCE;

        public static string ArsVenificiTestModId = "Template.TemplateModName";

        public override void Entry(IModHelper helper)
        {
            INSTANCE = this;

            SetUpEvents();
        }

        public void OnSaveLoaded(object sender, SaveLoadedEventArgs e)
        {
            if (Context.IsWorldReady)
            {
                
            }
        }

        /// <summary>
        /// Sets up the events for the mod.
        /// </summary>
        private void SetUpEvents()
        {
            Helper.Events.GameLoop.SaveLoaded += OnSaveLoaded;

            ArsVenefici.ModEntry.INSTANCE.spellPartEvents.AddSpellParts += OnAddSpellParts;
            ArsVenefici.ModEntry.INSTANCE.spellPartEvents.AddSpellPartSkills += OnAddSpellPartSkills;
        }

        //Make sure to add all your spell parts into the content pack lists for each spell part type
        public void OnAddSpellParts(object sender, EventArgs args)
        {
            ArsVenefici.ModEntry.INSTANCE.spellPartManager.dictionariesPoplulated = false;

            ArsVenefici.ModEntry.INSTANCE.spellPartManager.ContentPackAddShapes(ModSpellShapes.SHAPES.GetObjectList());
            ArsVenefici.ModEntry.INSTANCE.spellPartManager.ContentPackAddComponents(ModSpellComponents.COMPONENTS.GetObjectList());
            ArsVenefici.ModEntry.INSTANCE.spellPartManager.ContentPackAddModifiers(ModSpellModifers.MODIFIERS.GetObjectList());

            ArsVenefici.ModEntry.INSTANCE.spellPartManager.dictionariesPoplulated = true;
        }

        //Make sure to add all your spell part skills into the content pack list for spell part skills
        public void OnAddSpellPartSkills(object sender, EventArgs args)
        {
            ArsVenefici.ModEntry.INSTANCE.spellPartSkillManager.dictionariesPoplulated = false;

            ModSpellPartSkills.SetSkillParents();

            ArsVenefici.ModEntry.INSTANCE.spellPartSkillManager.ContentPackAddSpellPartSkills(ModSpellPartSkills.SKILLS.GetObjectList());

            ArsVenefici.ModEntry.INSTANCE.spellPartSkillManager.dictionariesPoplulated = true;
        }


    }
}
