using Azulon.Configs.Inventory.Items;
using Azulon.Configs.UI;
using UnityEngine;

namespace Azulon.Configs
{
    [CreateAssetMenu(fileName = "ConfigsSO", menuName = "ScriptableObjects/Configs", order = 1)]
    public class ConfigsSO:ScriptableObject
    {
        public PrefabsSO Prefabs;
        public ItemsSO Items;
        public DialogsSO Dialogs;
    }
}