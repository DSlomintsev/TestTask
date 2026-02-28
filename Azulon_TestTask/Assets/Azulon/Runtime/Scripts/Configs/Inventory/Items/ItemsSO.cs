using System.Collections.Generic;
using UnityEngine;

namespace Azulon.Configs.Inventory.Items
{
    [CreateAssetMenu(fileName = "ItemsSO", menuName = "ScriptableObjects/Inventory/Items", order = 1)]
    public class ItemsSO:ScriptableObject
    {
        public List<ItemSO> Items;
    }
}