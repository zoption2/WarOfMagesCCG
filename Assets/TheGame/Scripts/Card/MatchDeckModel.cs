using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TheGame.Card;


namespace TheGame.Match
{
    public class MatchDeckModel
    {
        private MatchDeckController controller;

        private readonly Dictionary<int, Queue<CardData>> data = new Dictionary<int, Queue<CardData>>();

        public void AddDeck(int playerID, List<CardData> cardsCollection)
        {
            if (!data.ContainsKey(playerID))
            {
                var deck = new Queue<CardData>();
                for (int i = 0; i < cardsCollection.Count; i++)
                {
                    CardData someCardData = cardsCollection[Random.Range(0, cardsCollection.Count - 1)];
                    deck.Enqueue(someCardData);
                    cardsCollection.Remove(someCardData);
                }
                data.Add(playerID, deck);
            }
        }
    }
}


