using System.Collections.Generic;
using Azulon.Actors.Entities.Components;
using Common.Services;
using Common.Services.Tick;
using Common.Utils;
using UnityEngine;

namespace Azulon.Actors.Entities.Systems
{
    public class GenerateGoldSystem:SystemBase
    {
        private List<GoldGeneratorComponentData> _componentData = new();

        public override void Init()
        {
            ServiceLocator.Get<TickService>().AddTickSecAction(Tick);
        }

        public override void AddComponent(IComponent component)
        {
            _componentData.Add(new GoldGeneratorComponentData
            {
                GoldGeneratorComponent = component as GoldGeneratorComponent,
                InventoryComponent = component.Entity.GetComponent<InventoryComponent>()
            });   
        }

        private void Tick()
        {
            foreach (var data in _componentData)
            {
                data.InventoryComponent.Currency.Gold += data.GoldGeneratorComponent.Amount;
                data.InventoryComponent.Currency.GoldUpdate.Call(data.InventoryComponent.Currency.Gold);
            }
        }
    }

    public struct GoldGeneratorComponentData
    {
        public GoldGeneratorComponent GoldGeneratorComponent;
        public InventoryComponent InventoryComponent;
    }
}