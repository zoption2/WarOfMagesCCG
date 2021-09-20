using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TheGame.Card;

namespace TheGame.Data
{
    public class CardsModels : MonoBehaviour
    {
        private readonly Dictionary<int, CardModel> data = new Dictionary<int, CardModel>();
        public IReadOnlyDictionary<int, CardModel> Data => data;

        public void Add(int uniqID, CardModel model)
        {
            if (!data.ContainsKey(uniqID))
            {
                data.Add(uniqID, model);
            }
            else
            {
                throw new System.Exception("Uniq card ID is already in use!");
            }
        }
    }
}

