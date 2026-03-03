using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace Azulon.Configs.Missions
{
    [CreateAssetMenu(fileName = "MissionsSO", menuName = "ScriptableObjects/Missions/Missions", order = 1)]
    public class MissionsSO:ScriptableObject
    {
        public List<MissionSO> Items;
        
        private void OnValidate()
        {
            Items.Clear();

            var guids = AssetDatabase.FindAssets("t:" + typeof(MissionSO).Name, new[] { "Assets/Azulon/Runtime/Lib/Configs/Missions/Items" });

            foreach (string guid in guids)
            {
                var assetPath = AssetDatabase.GUIDToAssetPath(guid);
                var item = AssetDatabase.LoadAssetAtPath<MissionSO>(assetPath);
                if (item != null)
                    Items.Add(item);
            }

            EditorUtility.SetDirty(this);
            //AssetDatabase.SaveAssets();
        }
    }
}