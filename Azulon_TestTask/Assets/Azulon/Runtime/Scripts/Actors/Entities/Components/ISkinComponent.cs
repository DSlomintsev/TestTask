using UnityEngine;

namespace Azulon.Actors.Entities.Components
{
    public interface ISkinComponent : IComponent
    {
        public void ApplyColor(Color color);
    }
}