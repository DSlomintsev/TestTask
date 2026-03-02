using Azulon.Actors.Entities.Systems;
using Azulon.Actors.Player.Commands;
using Azulon.Configs;
using Azulon.Models;
using Azulon.Services.Localization;
using Azulon.Services.Resource;
using Azulon.Services.Shops;
using Azulon.UI.Dialogs.GameUI;
using Azulon.UI.Dialogs.Inventory;
using Azulon.UI.Dialogs.Shop;
using Common.Input;
using Common.Models;
using Common.Services;
using Common.Services.Dialogs;
using Common.Services.Tick;
using Common.Services.UIs;
using UnityEngine;

namespace Azulon
{
    public class Init : MonoBehaviour
    {
        [SerializeField] private ConfigsSO configsSO;

        private void Awake()
        {
            ModelsLocator.Add(new GameModel(configsSO));
            ModelsLocator.Add(new PlayersModel());
            ModelsLocator.Add(new ShopModel());

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
            
            SpawnPlayerCommand.Do(true);
        }
    }
}