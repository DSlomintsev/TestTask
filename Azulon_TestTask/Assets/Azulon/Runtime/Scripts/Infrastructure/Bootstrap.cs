using System.Threading.Tasks;
using Azulon.Actors.Entities.Systems;
using Azulon.Actors.Player.Commands;
using Azulon.Configs;
using Azulon.Infrastructure.States;
using Azulon.Models;
using Azulon.Services.Localization;
using Azulon.Services.Resource;
using Azulon.Services.Shops;
using Azulon.UI.Dialogs.GameUI;
using CloserToTheSky.Infrastructure.States;
using Common.Input;
using Common.Models;
using Common.Services;
using Common.Services.Dialogs;
using Common.Services.Tick;
using Common.Services.UIs;
using Cysharp.Threading.Tasks;
using UnityEngine;

namespace Azulon.Infrastructure
{
    public class Bootstrap : MonoBehaviour
    {
        [SerializeField] private ConfigsSO configsSO;

        private void Construct()
        {
            ModelsLocator.Add(new GameModel(configsSO));
            ModelsLocator.Add(new PlayersModel());
            ModelsLocator.Add(new ShopModel());

            ServiceLocator.Add(new AppStateMachine());
            ServiceLocator.Add(new TickService());
            ServiceLocator.Add(new InputService(configsSO.Prefabs.InputReader));
            ServiceLocator.Add(new ShopService());
            ServiceLocator.Add(new ResourceService(configsSO.Icons));
            ServiceLocator.Add(new LocalizationService());
            ServiceLocator.Add(new UIService(configsSO.Prefabs.UIContainer));
            ServiceLocator.Add(new DialogService(configsSO.Dialogs.ModalBkg, configsSO.Dialogs.Items));
            ServiceLocator.Init();
            
            SystemLocator.Add(new GenerateGoldSystem());
            SystemLocator.Init();

            ServiceLocator.Get<DialogService>().OpenDialog<GameUIMediator>(config: DialogService.DialogConfig);
        }

        private void Awake() => EnterAsync().Forget();

        private async UniTask EnterAsync()
        {
            Construct();
            await UniTask.NextFrame();
            ServiceLocator.Get<AppStateMachine>().Enter<BootstrapState>();
        }
    }
}
