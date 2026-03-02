using System.Collections.Generic;
using Azulon.Configs.Inventory.Items;
using Common.UI.Dialogs.BaseDialog;
using UnityEngine;

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
            _view.SetActions(ClickAction, CloseDialog);
        }

        public void SetItems(List<ItemSO> items)
        {
            _view.SetItems(items);
        }

        private void ClickAction(ItemSO item)
        {
            Debug.Log("Inventory ClickAction");
        }

        public override void DeInit()
        {
            base.DeInit();
        }
    }
}