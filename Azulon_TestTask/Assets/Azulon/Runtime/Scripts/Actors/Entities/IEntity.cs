using System.Collections.Generic;
using Azulon.Actors.Entities.Components;

namespace Azulon.Actors.Entities
{
    public interface IEntity
    {
        public List<IComponent> Components { get; }
    }
}