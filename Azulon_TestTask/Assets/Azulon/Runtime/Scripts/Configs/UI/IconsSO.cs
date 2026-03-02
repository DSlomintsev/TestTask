using UnityEngine;
using UnityEngine.U2D;

namespace Azulon.Configs.UI
{
    [CreateAssetMenu(fileName = "IconsSO", menuName = "ScriptableObjects/UI/Icons", order = 1)]
    public class IconsSO:ScriptableObject
    {
        public SpriteAtlas Items;
    }
}