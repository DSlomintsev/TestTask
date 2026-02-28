using System;
using Common.Components.UI;
using Common.UI.Dialogs.BaseDialog;
using Common.Utils;
using UnityEngine;

namespace Azulon.UI.Dialogs.ConfirmDialog
{
    public class ConfirmDialogView : BaseDialogView
    {
        [SerializeField] private ExtTMPText titleLabel;
        [SerializeField] private ExtTMPText descriptionLabel;
        
        private Action _confirm;
        private Action _cancel;

        public void SetTitle(string title) => titleLabel.SetText(title);
        public void SetDescription(string title) => descriptionLabel.SetText(title);

        public void SetActions(Action confirm, Action cancel)
        {
            _confirm=confirm;
            _cancel=cancel;
        }

        public void OnConfirm()=>_confirm.Call();
        public void OnCancel()=>_cancel.Call();
    }
}