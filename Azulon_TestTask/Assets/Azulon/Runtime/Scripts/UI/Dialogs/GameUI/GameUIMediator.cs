using Azulon.Actors.Entities;
using Azulon.Actors.Entities.Components;
using Azulon.Actors.Player;
using Azulon.Models;
using Azulon.UI.Dialogs.Inventory;
using Azulon.UI.Dialogs.Shop;
using Common.Models;
using Common.Services;
using Common.Services.Dialogs;
using Common.UI.Dialogs.BaseDialog;

namespace Azulon.UI.Dialogs.GameUI
{
    public class GameUIMediator : BaseDialogMediator
    {
        private GameUIView _view;

        private PlayersModel _playersModel;
        private DialogService _dialogService;

        public override void Init(BaseDialogView view)
        {
            base.Init(view);
            _view = (GameUIView)view;

            _view.SetActions(OnInventory, OnShop);

            _dialogService = ServiceLocator.Get<DialogService>();
            _playersModel = ModelsLocator.Get<PlayersModel>();
            
            _playersModel.CurrentPlayer.UpdateEvent += OnCurrentPlayerUpdateEvent;
        }

        private void OnCurrentPlayerUpdateEvent(PlayerController playerController)
        {
            if (playerController == null) return;

            var inventory = playerController.GetComponent<InventoryComponent>();
            inventory.Currency.GoldUpdate += OnGoldUpdate;
            OnGoldUpdate(inventory.Currency.Gold);
        }

        private void OnGoldUpdate(float value) => _view.SetPlayerGold(value);

        private void OnInventory()
        {
            var inventory = _dialogService.OpenDialog<InventoryDialogMediator>(config: DialogService.ModalDialogConfig);
            inventory.SetItems((_playersModel.CurrentPlayer.Value).GetComponent<InventoryComponent>().Items);
        }

        private void OnShop() => _dialogService.OpenDialog<ShopDialogMediator>(config: DialogService.ModalDialogConfig);

        public override void DeInit()
        {
            base.DeInit();
        }
    }
}
