using Azulon.Services.Localization;
using Azulon.Services.Shops;
using Azulon.Services.Shops.Commands;
using Azulon.Services.Shops.Data;
using Common.Models;
using Common.Services;
using Common.Services.Dialogs;
using Common.UI.Dialogs.BaseDialog;

namespace Azulon.UI.Dialogs.Shop
{
    public class ShopDialogMediator : BaseDialogMediator
    {
        private ShopModel _shopModel;
        private ShopDialogView _view;

        public override void Init(BaseDialogView view)
        {
            base.Init(view);
            _view = (ShopDialogView)view;
            _shopModel = ModelsLocator.Get<ShopModel>();
            
            _view.SetTitle(ServiceLocator.Get<LocalizationService>().GetLocale("Shop"));
            _view.SetItems(_shopModel.Items);
            _view.SetActions(OnItemClick, CloseDialog);
        }

        private void OnItemClick(ShopItemConfig item)
        {
            //BuyItemCommand.Execute(item)
        }

        public override void DeInit()
        {
            base.DeInit();
        }
    }
}