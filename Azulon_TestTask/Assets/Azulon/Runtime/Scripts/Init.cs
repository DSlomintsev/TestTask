using Azulon.Configs;
using Azulon.Models;
using Azulon.Services.Localization;
using Azulon.Services.Shops;
using Azulon.UI.Dialogs.Inventory;
using Azulon.UI.Dialogs.Shop;
using Common.Models;
using Common.Services;
using Common.Services.Dialogs;
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
            ModelsLocator.Add(new ShopModel());

            ServiceLocator.Add(new ShopService());
            ServiceLocator.Add(new LocalizationService());
            ServiceLocator.Add(new UIService(configsSO.Prefabs.UIContainer));
            ServiceLocator.Add(new DialogService(configsSO.Dialogs.Items));

            ServiceLocator.Init();

            //ServiceLocator.Get<DialogService>().OpenDialog<ShopDialogMediator>();
            ServiceLocator.Get<DialogService>().OpenDialog<InventoryDialogMediator>();
        }
    }
}