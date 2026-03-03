using System.Collections.Generic;
using Azulon.Configs.Actions;
using Azulon.Configs.Inventory.Items;
using UnityEngine;

namespace Azulon.Configs.Missions
{
    [CreateAssetMenu(fileName = "MissionSO", menuName = "ScriptableObjects/Missions/Mission", order = 1)]
    public abstract class MissionSO:ScriptableObject
    {
        // started items
        // required to win conditions
        public ItemID Id;
        public ItemCategoryID CategoryId;
        public List<ConditionSO> WinCondition;
        //add conditions
        //add conditions service
    }
}