using UnityEngine;

namespace Azulon.Configs.Actions
{
    [CreateAssetMenu(fileName = "DamageSO", menuName = "ScriptableObjects/Actions/Damage", order = 1)]
    public class DamageSO:ItemActionSO
    {
        public float Damage;
    }
}