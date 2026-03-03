using UnityEngine;

namespace Azulon.Configs.Actions
{
    [CreateAssetMenu(fileName = "SpawnVFXSO", menuName = "ScriptableObjects/Actions/SpawnVFX", order = 1)]
    public class SpawnVFXActionSO:ActionSO
    {
        public string VfxName;
        public float Duration;
    }
}