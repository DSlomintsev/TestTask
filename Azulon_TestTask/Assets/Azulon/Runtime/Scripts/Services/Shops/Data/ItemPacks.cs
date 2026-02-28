using System.Collections.Generic;

namespace Azulon.Services.Shops.Data
{
    public struct ItemPacks
    {
        public List<ItemPack> Items;
        
        public ItemPacks(List<ItemPack> items)
        {
            Items = items;
        }
    }
}