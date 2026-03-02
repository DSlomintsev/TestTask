using UnityEngine;

namespace Azulon.Configs.Actions
{
    [CreateAssetMenu(fileName = "GenerateGoldActionSO", menuName = "ScriptableObjects/Actions/GenerateGoldAction", order = 1)]
    public class GenerateGoldActionSO:ItemActionSO
    {
        public float Amount;
    }
}