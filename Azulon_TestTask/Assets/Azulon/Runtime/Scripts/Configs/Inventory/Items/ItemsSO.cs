using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace Azulon.Configs.Inventory.Items
{
    [CreateAssetMenu(fileName = "ItemsSO", menuName = "ScriptableObjects/Inventory/Items", order = 1)]
    public class ItemsSO:ScriptableObject
    {
        public List<ItemSO> Items;
        
        private void OnValidate()
        {
            Items.Clear();

            var guids = AssetDatabase.FindAssets("t:" + typeof(ItemSO).Name, new[] { "Assets/Azulon/Runtime/Lib/Configs/Inventory/Items" });

            foreach (string guid in guids)
            {
                var assetPath = AssetDatabase.GUIDToAssetPath(guid);
                var item = AssetDatabase.LoadAssetAtPath<ItemSO>(assetPath);
                if (item != null)
                    Items.Add(item);
            }

            EditorUtility.SetDirty(this);
            //AssetDatabase.SaveAssets();
        }
    }
}