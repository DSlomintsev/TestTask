using UnityEngine;

namespace Azulon.Configs.Inventory.Items
{
    public abstract class ItemSO:ScriptableObject
    {
        public ItemID Id;
        public ItemCategoryID CategoryId;
    }
}