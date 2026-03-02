using System;
using Azulon.Configs.Inventory.Items;
using Azulon.Services.Shops.Data;
using Common.Models;
using Common.Services;
using NUnit.Framework;
using UnityEngine;

namespace Azulon.Services.Shops
{
    public class ShopService : BaseService
    {
        private ShopModel _shopModel;
        protected override void OnInit()
        {
            base.OnInit();
            
            _shopModel = ModelsLocator.Get<ShopModel>();
            LoadPrices();
        }

        private void LoadPrices()
        {
            // load shop itemList from externalData service
            // would be done async

            _shopModel.AddItem(new ShopItemConfig("GOLD_GENERATOR_0_Shop", "LightWeapon", new ItemPacks
            {
                Items = new()
                {
                    new(ItemID.GOLD_GENERATOR_0, 1)
                }
            }, new ItemPack(ItemID.GOLD, 10)));
            
            _shopModel.AddItem(new ShopItemConfig("GOLD_GENERATOR_1_Shop", "MoreDangerousWeapon", new ItemPacks(new()
            {
                new(ItemID.GOLD_GENERATOR_1, 1),
            }), new ItemPack(ItemID.GOLD, 200)));
            
            _shopModel.AddItem(new ShopItemConfig("GOLD_GENERATOR_2_Shop", "MoreDangerousWeapon", new ItemPacks(new()
            {
                new(ItemID.GOLD_GENERATOR_2, 1),
            }), new ItemPack(ItemID.GOLD, 300)));
            
            _shopModel.AddItem(new ShopItemConfig("Shield_0_Shop", "LightDef", new ItemPacks(new()
            {
                new(ItemID.SHIELD_0, 1)
            }), new ItemPack(ItemID.GOLD, 80)));
            
            _shopModel.AddItem(new ShopItemConfig("Shield_1_Shop", "BetterDef", new ItemPacks(new()
            {
                new(ItemID.SHIELD_1, 1),
            }), new ItemPack(ItemID.GOLD, 160)));
            
            _shopModel.AddItem(new ShopItemConfig("Shield_2_Shop", "BetterDef", new ItemPacks(new()
            {
                new(ItemID.SHIELD_2, 1),
            }), new ItemPack(ItemID.GOLD, 240)));
            
            _shopModel.AddItem(new ShopItemConfig("AllInOnePack", "Events", new ItemPacks(new()
            {
                new(ItemID.GOLD_GENERATOR_2, 1),
                new(ItemID.SHIELD_2, 1),
            }), new ItemPack(ItemID.GOLD, 320)));
            
            _shopModel.AddItem(new ShopItemConfig("Skin", "Events", new ItemPacks(new()
            {
                new(ItemID.SKIN_0, 1),
                new(ItemID.SHIELD_2, 1),
            }), new ItemPack(ItemID.GOLD, 100)));
        }

        public void BuyItem(string playerId, string itemId, Action<bool> successCallback, Action<bool> failCallback)
        {
            
        }

        public void GetItem(string itemId) => _shopModel.GetItem(itemId);
    }

    // would be better to use record struct, but it's only available in C# 10
}