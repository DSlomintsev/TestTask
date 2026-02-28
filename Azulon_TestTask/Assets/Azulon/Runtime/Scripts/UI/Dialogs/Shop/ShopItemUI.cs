using Azulon.Services.Localization;
using Azulon.Services.Shops;
using Azulon.Services.Shops.Data;
using Azulon.UI.Items.ItemPanels;
using Common.Components.UI;
using Common.Services;
using UnityEngine;

namespace Azulon.UI.Dialogs.Shop
{
    public class ShopItemUI:ItemPanelItemUIBase<ShopItemConfig>{
        [SerializeField] private ExtTMPText price;
        
        protected override void UpdateView()
        {
            var id = _itemSO.Id;
            titleLabel.SetText(ServiceLocator.Get<LocalizationService>().GetLocale(id + LocalizationService.ITEM_TITLE_POSTIFX));
            descriptionLabel.SetText(ServiceLocator.Get<LocalizationService>().GetLocale(id + LocalizationService.ITEM_DESCRIPTION_POSTIFX));
            //icon.sprite = ServiceLocator.Get<LocalizationService>().GetLocale(id);
            price.SetText(_itemSO.Price.ToString());
        }
    }
}