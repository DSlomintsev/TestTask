using Azulon.Configs.Inventory.Items;
using Azulon.Models;
using Common.Models;
using Common.UI.Dialogs.BaseDialog;

namespace Azulon.UI.Dialogs.Inventory
{
    public class InventoryDialogMediator : BaseDialogMediator
    {
        private InventoryDialogView _view;

        public override void Init(BaseDialogView view)
        {
            base.Init(view);
            _view = (InventoryDialogView)view;
            
            _view.SetTitle("Inventory");
            _view.SetItems(ModelsLocator.Get<GameModel>().Configs.Items.Items);
            _view.SetActions(ClickAction, CloseDialog);
        }

        private void ClickAction(ItemSO item)
        {
            throw new System.NotImplementedException();
        }

        public override void DeInit()
        {
            base.DeInit();
        }
    }
}