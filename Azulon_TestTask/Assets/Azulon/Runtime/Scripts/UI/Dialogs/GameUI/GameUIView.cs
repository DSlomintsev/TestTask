using System;
using System.Globalization;
using Common.Components.UI;
using Common.UI.Dialogs.BaseDialog;
using Common.Utils;
using UnityEngine;

namespace Azulon.UI.Dialogs.GameUI
{
    public class GameUIView: BaseDialogView
    {
        [SerializeField] private ExtTMPText playerGold;

        private Action _onInventory;
        private Action _onShop;

        public void SetActions(Action onInventory, Action onShop)
        {
            _onInventory = onInventory;
            _onShop = onShop;
        }

        public void OnInventory() => _onInventory.Call();
        public void OnShop() => _onShop.Call();
        public void SetPlayerGold(float gold)=>playerGold.SetText(gold.ToString(CultureInfo.InvariantCulture));
    }
}