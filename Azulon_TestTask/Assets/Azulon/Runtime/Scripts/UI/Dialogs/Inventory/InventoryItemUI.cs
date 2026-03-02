using Azulon.Configs.Inventory.Items;
using Azulon.Services.Localization;
using Azulon.Services.Resource;
using Azulon.UI.Items.ItemPanels;
using Common.Services;

namespace Azulon.UI.Dialogs.Inventory
{
    public class InventoryItemUI:ItemPanelItemUIBase<ItemSO>{
        protected override void UpdateView()
        {
            var id = _itemData.Id;
            titleLabel.SetText(ServiceLocator.Get<LocalizationService>().GetLocale(id + LocalizationService.ITEM_TITLE_POSTIFX));
            descriptionLabel.SetText(ServiceLocator.Get<LocalizationService>().GetLocale(id + LocalizationService.ITEM_DESCRIPTION_POSTIFX));
            icon.sprite = ServiceLocator.Get<ResourceService>().GetIcon(id.ToString());
        }
    }
}