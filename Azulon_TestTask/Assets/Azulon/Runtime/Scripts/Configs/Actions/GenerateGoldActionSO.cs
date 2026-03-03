using UnityEngine;

namespace Azulon.Configs.Actions
{
    [CreateAssetMenu(fileName = "GenerateGoldActionSO", menuName = "ScriptableObjects/Actions/GenerateGoldAction", order = 1)]
    public class GenerateGoldActionSO:ActionSO
    {
        public float Amount;
    }
}