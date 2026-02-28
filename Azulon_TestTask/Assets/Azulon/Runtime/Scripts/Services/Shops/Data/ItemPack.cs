using Azulon.Configs.Inventory.Items;

namespace Azulon.Services.Shops.Data
{
    public struct ItemPack
    {
        public ItemID Id;
        public float Amount;
        
        public ItemPack(ItemID id, float amount)
        {
            Id = id;
            Amount = amount;
        }
    }
}