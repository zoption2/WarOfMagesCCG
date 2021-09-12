using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TheGame.Card;

namespace TheGame.Data
{
    [CreateAssetMenu(fileName = "CardDataHolder", menuName = "ScriptableObjects/CardDataHolder", order = 52)]
    public class CardDataHolder : ScriptableObject
    {
        [SerializeField] private CardData[] data;

        public CardData GetCardData (string cardKey)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i].CardName == cardKey)
                {
                    return data[i];
                }
            }
            throw new System.ArgumentNullException();
        }
    }
}

