using System.Collections.Generic;
using Azulon.Services.Shops.Data;
using Common.Models;

namespace Azulon.Services.Shops
{
    public class ShopModel : IModel
    {
        private List<ShopItemConfig> _items = new();
        public List<ShopItemConfig> Items => _items;

        public void AddItem(ShopItemConfig config) => _items.Add(config);
        public ShopItemConfig GetItem(string itemId) => _items.Find(x => x.Id == itemId);

        public void Init()
        {
        }

        public void DeInit()
        {
        }
    }
}