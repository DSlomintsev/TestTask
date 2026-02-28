using UnityEngine;

namespace Azulon.Configs.Inventory.Items
{
    [CreateAssetMenu(fileName = "DefenceItemSO", menuName = "ScriptableObjects/Inventory/DefenceItem", order = 1)]
    public class DefenceItemSO:ItemSO
    {
        public float Defence;
    }
}