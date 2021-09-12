using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace TheGame.Match
{
    public class LoadedDeck : MonoBehaviour
    {
        private readonly Dictionary<int, PlayerData> data = new Dictionary<int, PlayerData>();

        public int CardsCount(int playerID) => data[playerID].CardsCount;

        public void AddCard(int playerID, GameObject card)
        {
            if (!data.ContainsKey(playerID))
            {
                var newPlayerData = new PlayerData(card);
                data.Add(playerID, newPlayerData);
            }
            else
            {
                data[playerID].AddCard(card);
            }
        }

        public GameObject DrawCard(int playerID)
        {
            if (data.ContainsKey(playerID))
            {
                var go = data[playerID].GetCard();
                return go;
            }
            else
            {
                throw new ArgumentNullException();
            }
        }

        [System.Serializable]
        private class PlayerData
        {
            public Queue<GameObject> data;
            public int CardsCount => data.Count;

            public PlayerData(GameObject card)
            {
                data = new Queue<GameObject>();
                AddCard(card);
            }

            public void AddCard(GameObject card)
            {
                data.Enqueue(card);
            }

            public GameObject GetCard()
            {
                var go = data.Dequeue();
                return go;
            }
        }
    }
}

