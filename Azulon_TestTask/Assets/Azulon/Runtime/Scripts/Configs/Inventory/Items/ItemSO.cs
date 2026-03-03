using System.Collections.Generic;
using Azulon.Configs.Actions;
using UnityEngine;

namespace Azulon.Configs.Inventory.Items
{
    public abstract class ItemSO:ScriptableObject
    {
        public ItemID Id;
        public ItemCategoryID CategoryId;
        public List<ActionSO> Actions;
    }
}