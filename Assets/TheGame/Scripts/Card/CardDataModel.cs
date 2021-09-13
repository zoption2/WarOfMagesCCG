using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TheGame.Card;

namespace TheGame
{
    public class CardDataModel : AbstractModel
    {
        private CardData[] data;
        public CardData[] Data => data;

        public CardDataModel(CardData[] allCardData)
        {
            this.data = allCardData;
        }
    }
}

