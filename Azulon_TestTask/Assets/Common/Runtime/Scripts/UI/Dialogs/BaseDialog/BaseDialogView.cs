using Common.Services.Dialogs;
using UnityEngine;

namespace Common.UI.Dialogs.BaseDialog
{
    public class BaseDialogView : MonoBehaviour
    {
        public DialogState State;

        private BaseDialogConfig _config;
        public BaseDialogConfig Config => _config;

        public virtual BaseDialogMediator Mediator { get; set; }

        public virtual void Init(BaseDialogConfig config)
        {
            _config = config;
        }

        public virtual void DeInit()
        {
        }

        public void Show() => State = DialogState.OPENED;

        public void Hide() => State = DialogState.CLOSED;

        protected virtual void Close()
        {
        }
    }

    public enum DialogState
    {
        NONE,
        OPENED,
        CLOSED
    }
}