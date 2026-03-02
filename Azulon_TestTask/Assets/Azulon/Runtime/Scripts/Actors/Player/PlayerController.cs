using System.Collections.Generic;
using Azulon.Actors.Entities;
using Azulon.Actors.Entities.Components;

namespace Azulon.Actors.Player
{
    public class PlayerController: IEntity
    {
        private List<IComponent> _components  = new ();
        public List<IComponent> Components => _components;
    }
}