using UnityEngine;

namespace Azulon.Actors.Entities.Components
{
    public class PlayerSkinComponent:ComponentBase, ISkinComponent
    {
        private static readonly int BaseColor = Shader.PropertyToID("_BaseColor");

        private Transform _skin;

        public PlayerSkinComponent(IEntity entity,Transform skin): base(entity)
        {
            _skin = skin;
        }

        public void ApplyColor(Color color)
        {
            var renderers = _skin.GetComponentsInChildren<Renderer>();
            var mpb = new MaterialPropertyBlock();
            foreach (var renderer in renderers)
            {
                renderer.GetPropertyBlock(mpb);
                mpb.SetColor(BaseColor, color);
                renderer.SetPropertyBlock(mpb);
            }
        }
    }
}