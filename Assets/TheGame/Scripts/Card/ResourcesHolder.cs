using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;
using TheGame.Data;
using UnityEngine.AddressableAssets;
using TheGame.Match;

namespace TheGame
{
    [CreateAssetMenu(fileName = "NewResourcesHolder", menuName = "ScriptableObjects/ResourcesHolder", order = 51)]
    public class ResourcesHolder : ScriptableObject
    {
        [SerializeField] private List<Item> items;

        public Object GetItem(string itemName)
        {
            for (int i = 0; i < items.Count; i++)
            {
                if (items[i].itemName.Equals(itemName))
                {
                    return items[i].itemPrefab;
                }
            }
            throw new System.ArgumentNullException();
        }


        [System.Serializable]
        public class Item
        {
            public string itemName;
            public Object itemPrefab; 
        }
    }
}

