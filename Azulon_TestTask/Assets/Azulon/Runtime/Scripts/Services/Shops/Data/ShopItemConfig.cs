namespace Azulon.Services.Shops.Data
{
    public struct ShopItemConfig
    {
        public string Id; 
        public string CategoryId;// used string, because it gives more flexibility, item categories could be changed every week
        public ItemPacks Reward;
        public ItemPack Price;

        public ShopItemConfig(string id, string categoryId, ItemPacks reward, ItemPack price)
        {
            Id = id;
            CategoryId = categoryId;
            Reward = reward;
            Price = price;
        }
    }
}