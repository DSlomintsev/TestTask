using UnityEngine;

namespace Azulon.Configs.Actions
{
    [CreateAssetMenu(fileName = "ChangeSkinActionSO", menuName = "ScriptableObjects/Actions/ChangeSkinAction", order = 1)]
    public class ChangeSkinActionSO:ActionSO
    {
        public Color Color;
    }
}