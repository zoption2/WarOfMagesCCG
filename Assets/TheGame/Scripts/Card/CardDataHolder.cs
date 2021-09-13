using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TheGame.Card;

namespace TheGame
{
    [CreateAssetMenu(fileName = "CardDataHolder", menuName = "ScriptableObjects/CardDataHolder")]
    public class CardDataHolder : ScriptableObject
    {
        [SerializeField] private CardData[] allCardsData;

        public CardData GetData(int id)
        {
            for (int i = 0; i < allCardsData.Length; i++)
            {
                if (allCardsData[i].ID == id)
                {
                    return allCardsData[i];
                }
            }
            throw new System.ArgumentOutOfRangeException();
        }
    }
}

