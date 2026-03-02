using Azulon.Actors.Entities.Components;

namespace Azulon.Actors.Entities.Systems
{
    public interface ISystem
    {
        public void AddComponent(IComponent component);
        void Init();
        void DeInit();
    }
}