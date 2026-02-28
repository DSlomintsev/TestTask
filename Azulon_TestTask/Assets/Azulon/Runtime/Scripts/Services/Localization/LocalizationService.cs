using Common.Services.Localization;

namespace Azulon.Services.Localization
{
    public class LocalizationService : LocalizationServiceBase<string>
    {
        public const string ITEM_TITLE_POSTIFX = "_title";
        public const string ITEM_DESCRIPTION_POSTIFX = "_description";

        protected override void AddStrings()
        {
            // receive string from external service, or even use i2localization
            // Items
            AddString("FIREBALL_0_title", "Small Fireball");
            AddString("FIREBALL_0_description", "Small magic fireball");
            AddString("FIREBALL_1_title", "Small Fireball");
            AddString("FIREBALL_1_description", "Small magic fireball");
            AddString("FIREBALL_2_title", "Small Fireball");
            AddString("FIREBALL_2_description", "Small magic fireball");
            
            AddString("SHIELD_0_title", "Small shield");
            AddString("SHIELD_0_description", "Small non magic shield");
            AddString("SHIELD_1_title", "Small shield");
            AddString("SHIELD_1_description", "Small non magic shield");
            AddString("SHIELD_2_title", "Small shield");
            AddString("SHIELD_2_description", "Small non magic shield");
            
            // Inventory Categories
            AddString("NONE", "ALL");
            AddString("ATTACK", "ALL");
            AddString("DEFENSE", "ALL");
            
            // Shop Categories
            AddString("LightWeapon", "Light Weapon");
            AddString("MoreDangerousWeapon", "More Dangerous Weapon");
            AddString("LightDef", "Light Defence");
            AddString("BetterDef", "Better Defence");
            AddString("Events", "Events");
            
            // Shop pack titles
            AddString("Fireball_0_Shop_title", "Fireball 0");
            AddString("Fireball_0_Shop_description", "Fireball 0 descr");
            AddString("Fireball_1_Shop_title", "Fireball 1");
            AddString("Fireball_1_Shop_description", "Fireball 0 descr");
            AddString("Fireball_2_Shop_title", "Fireball 2");
            AddString("Fireball_2_Shop_description", "Fireball 0 descr");
            AddString("Shield_0_Shop_title", "Shield 0");
            AddString("Shield_0_Shop_description", "Shield 0 descr");
            AddString("Shield_1_Shop_title", "Shield 1");
            AddString("Shield_1_Shop_description", "Shield 1 descr");
            AddString("Shield_2_Shop_title", "Shield 2");
            AddString("Shield_2_Shop_description", "Shield 2 descr");
            AddString("AllInOnePack_title", "All In One Pack");
            AddString("AllInOnePack_description", "Cool one");

            // Dialog titles
            AddString("Inventory", "Inventory");
            AddString("Shop", "Shop");
        }
    }
}