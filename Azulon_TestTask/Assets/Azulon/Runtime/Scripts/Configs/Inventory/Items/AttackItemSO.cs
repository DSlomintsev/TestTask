using UnityEngine;

namespace Azulon.Configs.Inventory.Items
{
    [CreateAssetMenu(fileName = "AttackItemSO", menuName = "ScriptableObjects/Inventory/AttackItem", order = 1)]
    public class AttackItemSO:ItemSO
    {
        public float Damage;
    }
}