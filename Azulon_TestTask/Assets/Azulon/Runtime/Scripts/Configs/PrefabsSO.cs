using Common.Services.UIs;
using UnityEngine;

namespace Azulon.Configs
{
    [CreateAssetMenu(fileName = "PrefabsSO", menuName = "ScriptableObjects/Prefabs", order = 1)]
    public class PrefabsSO:ScriptableObject
    {
        public UIContainer UIContainer;
    }
}