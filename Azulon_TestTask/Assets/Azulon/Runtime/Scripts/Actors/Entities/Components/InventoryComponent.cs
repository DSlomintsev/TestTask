using System;
using System.Collections.Generic;
using Azulon.Configs.Inventory.Items;

namespace Azulon.Actors.Entities.Components
{
    public class InventoryComponent:ComponentBase
    {
        public List<ItemSO> Items = new();
        public Currency Currency;

        public InventoryComponent(IEntity entity) : base(entity)
        {
        }
    }

    public struct Currency
    {
        public float Gold;
        public Action<float> GoldUpdate;
    }
}