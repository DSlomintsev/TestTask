using Azulon.Actors.Entities;
using Azulon.Actors.Entities.Components;
using Azulon.Actors.Entities.Systems;
using Azulon.Actors.Player;
using Azulon.Configs.Actions;
using Azulon.Configs.Inventory.Items;
using Azulon.Models;
using Azulon.Services.Shops.Data;
using Common.Models;
using UnityEngine;

namespace Azulon.Services.Shops.Commands
{
    public static class BuyItemCommand
    {
        public static void Do(IEntity entity, ShopItemConfig shopItemConfig)
        {
            var items = ModelsLocator.Get<GameModel>().Configs.Items.Items;
            foreach (var itemPack in shopItemConfig.Reward.Items)
            {
                var item = items.Find(x => x.Id.Equals(itemPack.Id));
                if (item == null)
                {
                    Debug.LogWarning($"Item {itemPack.Id} not found");
                    continue;
                }

                var inventory = entity.GetComponent<InventoryComponent>();
                inventory?.Items.Add(item);
                ApplyItem(entity, item);
            }
        }

        private static void ApplyItem(IEntity entity, ItemSO itemSO)
        {
            foreach (var itemAction in itemSO.Actions)
                ApplyAction(entity, itemAction);
        }

        private static void ApplyAction(IEntity entity, ActionSO itemActionSO)
        {
            switch (itemActionSO)
            {
                case ChangeSkinActionSO changeSkinAction:
                    entity.GetComponent<ISkinComponent>()?.ApplyColor(changeSkinAction.Color);
                    break;
                case GenerateGoldActionSO generateGoldAction:
                    var generateGoldComponent = entity.GetComponent<GoldGeneratorComponent>();
                    if (generateGoldComponent == null)
                    {
                        generateGoldComponent = new GoldGeneratorComponent(entity);
                        entity.Components.Add(generateGoldComponent);
                        SystemLocator.Get<GenerateGoldSystem>().AddComponent(generateGoldComponent);
                    }

                    generateGoldComponent.Amount += generateGoldAction.Amount;
                    break;
            }
        }
    }
}